// Author: Kun Xie
// this tetris is my semester project for C#.

using System;
using System.Drawing;
using System.Windows.Forms;

namespace TetrisApp
{
    public partial class TetrisForm : Form
    {
        private const int GRID_ROWS = 20, GRID_COLS = 15, BRICK_SIZE = 20, 
            GRID_ROWS_NEXT = 4, GRID_COLS_NEXT = 4;
        private int[,] grid;
        Image image, imageNext;
        Graphics graphics, graphicsNext;
        private Bricks curBrick = null, nextBrick = new Bricks();
        private int curX, curY, score;

        public TetrisForm()
        {
            InitializeComponent();
        }

        private void TerisForm_Load(object sender, EventArgs e)
        {
            image = new Bitmap(this.panelTeris.Width, this.panelTeris.Height);
            graphics = Graphics.FromImage(image);

            imageNext = new Bitmap(this.panelNextBrick.Width, this.panelNextBrick.Height);
            graphicsNext = Graphics.FromImage(imageNext);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            tmTick.Stop();
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            tmTick.Start();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void PanelTeris_Paint(object sender, PaintEventArgs e)
        {
            if (grid == null) return;

            graphics.Clear(Color.White);
            for (int row = 0; row < GRID_ROWS; ++row)
                for (int col = 0; col < GRID_COLS; ++col)
                {
                    Brush brush;
                    switch (grid[row, col])
                    {
                        case 1: brush = new SolidBrush(Color.Red); break;
                        case 2: brush = new SolidBrush(Color.Green); break;
                        case 3: brush = new SolidBrush(Color.Purple); break;
                        case 4: brush = new SolidBrush(Color.Blue); break;
                        case 5: brush = new SolidBrush(Color.Orange); break;
                        case 6: brush = new SolidBrush(Color.Yellow); break;
                        default: brush = null; break;
                    }
                    // 重点，这里的col, row赋值的时候是相互调换的，不然坐标系就会搞混
                    // rows for height， cols for width
                    if (brush != null)
                        graphics.FillRectangle(brush,
                            BRICK_SIZE * col, BRICK_SIZE * row, BRICK_SIZE, BRICK_SIZE);
                }
            e.Graphics.DrawImage(image, 0, 0);
        }

        private void PanelNextBrick_Paint(object sender, PaintEventArgs e)
        {
            if (nextBrick == null) return;
            graphicsNext.Clear(Color.Silver);
            int[,] gridNext = nextBrick.BrickArray;
            for (int row = 0; row < GRID_ROWS_NEXT; ++row)
                for (int col = 0; col < GRID_COLS_NEXT; ++col)
                {
                    Brush brush;
                    switch (gridNext[row, col])
                    {
                        case 1: brush = new SolidBrush(Color.Red); break;
                        case 2: brush = new SolidBrush(Color.Green); break;
                        case 3: brush = new SolidBrush(Color.Purple); break;
                        case 4: brush = new SolidBrush(Color.Blue); break;
                        case 5: brush = new SolidBrush(Color.Orange); break;
                        default: brush = null; break;
                    }
                    // 重点，这里的col, row赋值的时候是相互调换的，不然坐标系就会搞混
                    // rows for height， cols for width
                    if (brush != null)
                        graphicsNext.FillRectangle(brush,
                            BRICK_SIZE * col, BRICK_SIZE * row, BRICK_SIZE, BRICK_SIZE);
                }
            e.Graphics.DrawImage(imageNext, 0, 0);
        }

        private void TmTick_Tick(object sender, EventArgs e)
        {
            MoveDown();
            panelTeris.Refresh();
        }

        /// <summary>
        ///  方向键不能准确获取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TerisForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                MoveLeft();
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                MoveRight();
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                RotateBrick();
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                QuickDown(); //  快速向下

            panelTeris.Refresh();
        }

        /// <summary>
        /// 旋转，向下，向左，向右，都是同一套逻辑， 擦除 -》 判断 -》 写入
        /// </summary>

        private void RotateBrick()
        {
            // 拿到旋转之后的brick
            Bricks rotatedBrick = curBrick.RotatedBrick();
            // 判断有没有位置放置rotatedBrick
            if (curX + rotatedBrick.GetRightLimit() >= GRID_COLS || curY + rotatedBrick.GetDownLimit() >= GRID_ROWS)
                return;

            WipeOutBrick();
           
            for (int row = 0; row < rotatedBrick.GetDownLimit(); ++row)
                for (int col = 0; col < rotatedBrick.GetRightLimit(); ++col)
                {
                    if (rotatedBrick.BrickArray[row, col] > 0 && grid[curY + row, curX + col] > 0)
                    {
                        WriteDownBrick();
                        return;
                    }
                }

            curBrick = rotatedBrick;
            WriteDownBrick();
        }

        private void QuickDown()
        {
            int originInterval = tmTick.Interval;
            tmTick.Interval = 50;
            MoveDown();
            tmTick.Interval = originInterval;
        }

        private void MoveDown()
        {
            // 当触底时
            if (curY + curBrick.GetDownLimit() == GRID_ROWS - 1)
            {
                WriteDownBrickAndDeleteLines();
                CreateBrick();
                return;
            }

            // 擦掉原来的brick
            WipeOutBrick();

            // 检查grid中将要下移的位置是不是有重合的地方
            for (int row = curBrick.GetDownLimit(); row >= 0; --row)
                for (int col = 0; col <= curBrick.GetRightLimit(); col++)
                    // 发现重合的地方，下移失败， 将brick写到原来的位置，然后新建一个brick
                    if (curBrick.BrickArray[row, col] > 0 && grid[curY + row + 1, curX + col] > 0)
                    {
                        WriteDownBrickAndDeleteLines();
                        CreateBrick();
                        return;
                    }

            curY++;
            WriteDownBrick();
        }

        private void MoveLeft()
        {
            if (curX == 0) return;

            WipeOutBrick();
            // 检查grid中将要左移的位置是不是有重合的地方
            for (int row = curBrick.GetDownLimit(); row >= 0; --row)
                for (int col = 0; col <= curBrick.GetRightLimit(); col++)
                    // 发现重合的地方，左移失败， 将brick写到原来的位置
                    if (curBrick.BrickArray[row, col] > 0 && grid[curY + row, curX + col - 1] > 0)
                    {
                        WriteDownBrick();
                        return;
                    }

            --curX;
            WriteDownBrick();
        }

        private void MoveRight()
        {
            if (curX + curBrick.GetRightLimit() == GRID_COLS - 1) return;

            WipeOutBrick();
            // 检查grid中将要右移的位置是不是有重合的地方
            for (int row = curBrick.GetDownLimit(); row >= 0; --row)
                for (int col = 0; col <= curBrick.GetRightLimit(); col++)
                    // 发现重合的地方，右移失败， 将brick写到原来的位置
                    if (curBrick.BrickArray[row, col] > 0 && grid[curY + row, curX + col + 1] > 0)
                    {
                        WriteDownBrick();
                        return;
                    }

            ++curX;
            WriteDownBrick();
        }

        /// <summary>
        /// Create a new Brick，当新brick不能成功创建时，游戏结束
        /// </summary>
        private void CreateBrick()
        {
            curBrick = nextBrick;
            nextBrick = new Bricks();
            panelNextBrick.Refresh();

            curX = 6;
            curY = 0;
            // 检查是否还能映射到grid上
            for (int row = 0; row <= curBrick.GetDownLimit(); ++row)
                for (int col = 0; col <= curBrick.GetRightLimit(); ++col)
                    if (curBrick.BrickArray[row, col] > 0 && grid[row + curY, col + curX] > 0)
                    {
                        tmTick.Stop();
                        MessageBox.Show("You are failed!");
                        return;
                    }
        }
        
        private void Init()
        {
            grid = new int[GRID_ROWS, GRID_COLS];
            score = 0;
            radBtnMedian.Checked = true;
            tmTick.Interval = 300;
            CreateBrick();
            tmTick.Start();
        }

        private void RadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnEasy.Checked == true)
                tmTick.Interval = 600;
            else if (radBtnMedian.Checked)
                tmTick.Interval = 300;
            else
                tmTick.Interval = 150;
        }

        /// <summary>
        /// Write the current brick into grid according the left-top point (curX, curY)
        /// </summary>
        private void WriteDownBrick()
        {
            if (curBrick.GetRightLimit() + curX >= GRID_COLS 
                || curBrick.GetDownLimit() + curY >= GRID_ROWS)
                return;

            for (int row = 0; row <= curBrick.GetDownLimit(); ++row)
                for (int col = 0; col <= curBrick.GetRightLimit(); ++col)
                    if (curBrick.BrickArray[row, col] > 0
                        && grid[row + curY, col + curX] == 0)
                        grid[row + curY, col + curX] = curBrick.BrickArray[row, col];
        }

        /// <summary>
        /// 当方块的触底的时候，写入这个函数，把颜色统一
        /// </summary>
        private void WriteDownBrickAndDeleteLines()
        {
            // 把大于1的数都变成6，方便涂颜色
            for (int row = 0; row <= curBrick.GetDownLimit(); ++row)
                for (int col = 0; col <= curBrick.GetRightLimit(); ++col)
                    if (curBrick.BrickArray[row, col] > 0 
                        && row + curY < GRID_ROWS && col + curX < GRID_COLS)
                        grid[row + curY, col + curX] = 6;

            /// 下面是消行的逻辑
            int count = 0;
            // 判断是否存在消行
            for (int row = GRID_ROWS - 1; row >= 0; --row)
            {
                for (int col = 0; col < GRID_COLS; ++col)
                {
                    if (grid[row, col] == 0)
                    {
                        count = 0;
                        break;
                    }
                    else
                        count++;
                }
                //  遇到满足消行条件的行
                if (count == GRID_COLS)
                {
                    score++;
                    lblScoreNum.Text = score.ToString();
                    // 整体向下覆盖
                    for (int r = row; r > 0; --r)
                        for (int c = 0; c < GRID_COLS; ++c)
                            grid[r, c] = grid[r - 1, c];
                    //  填充第一行
                    for (int c = 0; c < GRID_COLS; ++c)
                        grid[0, c] = 0;
                    row = GRID_ROWS - 1; // 重新循环
                }
            }
        }

        /// <summary>
        ///  Wipe out the current brick from the grid
        /// </summary>
        private void WipeOutBrick()
        {
            for (int row = 0; row <= curBrick.GetDownLimit(); ++row)
                for (int col = 0; col <= curBrick.GetRightLimit(); ++col)
                    if (curBrick.BrickArray[row, col] > 0)
                        grid[row + curY, col + curX] = 0;
        }


        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a semester project made by Kun Xie");
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("W --> transform\nA --> Go Left\nD --> Go Right\nS --> Speed");
        }
    }
}

