using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApp
{
    /// <summary>
    /// 专门生成bricks的class
    /// </summary>
    class Bricks
    {
        // int[5, 4, 4, 4]
        private static int[,,,] bricks = {
            {
                {
                    {1, 0, 0, 0},
                    {1, 0, 0, 0},
                    {1, 0, 0, 0},
                    {1, 0, 0, 0}
                },
                {
                    {1, 1, 1, 1},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0}
                },
                {
                    {1, 0, 0, 0},
                    {1, 0, 0, 0},
                    {1, 0, 0, 0},
                    {1, 0, 0, 0}
                },
                {
                    {1, 1, 1, 1},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0}
                }
            },
            {
                {
                    {2, 2, 0, 0},
                    {2, 2, 0, 0},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0}
                },
                {
                    {2, 2, 0, 0},
                    {2, 2, 0, 0},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0}
                },
                {
                    {2, 2, 0, 0},
                    {2, 2, 0, 0},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0}
                },
                {
                    {2, 2, 0, 0},
                    {2, 2, 0, 0},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0}
                }
            },
            {
                {
                    {3, 0, 0, 0},
                    {3, 3, 0, 0},
                    {0, 3, 0, 0},
                    {0, 0, 0, 0}
                },
                {
                    {0, 3, 3, 0},
                    {3, 3, 0, 0},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0}
                },
                {
                    {3, 0, 0, 0},
                    {3, 3, 0, 0},
                    {0, 3, 0, 0},
                    {0, 0, 0, 0}
                },
                {
                    {0, 3, 3, 0},
                    {3, 3, 0, 0},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0}
                }
            },
            {
                {
                    {4, 4, 0, 0},
                    {0, 4, 0, 0},
                    {0, 4, 0, 0},
                    {0, 0, 0, 0}
                },
                {
                    {0, 0, 4, 0},
                    {4, 4, 4, 0},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0}
                },
                {
                    {4, 0, 0, 0},
                    {4, 0, 0, 0},
                    {4, 4, 0, 0},
                    {0, 0, 0, 0}
                },
                {
                    {4, 4, 4, 0},
                    {4, 0, 0, 0},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0}
                }
            },
            {
                {
                    {0, 5, 0, 0},
                    {5, 5, 5, 0},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0}
                },
                {
                    {5, 0, 0, 0},
                    {5, 5, 0, 0},
                    {5, 0, 0, 0},
                    {0, 0, 0, 0}
                },
                {
                    {5, 5, 5, 0},
                    {0, 5, 0, 0},
                    {0, 0, 0, 0},
                    {0, 0, 0, 0}
                },
                {
                    {0, 5, 0, 0},
                    {5, 5, 0, 0},
                    {0, 5, 0, 0},
                    {0, 0, 0, 0}
                }
            }
        };
        // int[type(5), state(4), borders(1)]
        //  borders = [down(1), right(1)]
        private static int[,,] borders =
        {
            {
                {3, 0},
                {0, 3},
                {3, 0},
                {0, 3}
            },
            {
                {1, 1},
                {1, 1},
                {1, 1},
                {1, 1}
            },
            {
                {2, 1},
                {1, 2},
                {2, 1},
                {1, 2}
            },
            {
                {2, 1},
                {1, 2},
                {2, 1},
                {1, 2}
            },
            {
                {1, 2},
                {2, 1},
                {1, 2},
                {2, 1}
            }
        };

        private int[,] brickArray = new int[4, 4];
        private int type, state;

        public Bricks()
        {
            Type = (new Random()).Next(5);
            State = (new Random()).Next(4);
            UpdateBrickArray(Type, State);
        }

        public Bricks(int type, int state)
        {
            Type = type;
            State = state;
            UpdateBrickArray(Type, State);
        }

        public int Type { get => type; set => type = value; }
        public int State { get => state; set => state = value; }
        public int[,] BrickArray { get => brickArray; set => brickArray = value; }

        private void UpdateBrickArray(int type, int state)
        {
            for (int row = 0; row < 4; ++row)
                for (int col = 0; col < 4; ++col)
                    BrickArray[row, col] = bricks[type, state, row, col];
        }

        /// <summary>
        /// Factory method of create Bricks rotated object
        /// </summary>
        /// <returns></returns>
        public Bricks RotatedBrick()
        {
            return new Bricks(Type, (State + 1) % 4);
        }

        public int GetDownLimit()
        {
            return borders[Type, State, 0];
        }

        public int GetRightLimit()
        {
            return borders[Type, State, 1];
        }
    }
}
