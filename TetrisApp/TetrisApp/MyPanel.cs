/// <summary>
/// This class is created to solve the flicking problem when painting.
/// The solution comes from :
/// https://stackoverflow.com/questions/8046560/how-to-stop-flickering-c-sharp-winforms/8046796
/// </summary>

namespace TetrisApp
{
    class MyPanel : System.Windows.Forms.Panel
    {
        public MyPanel()
        {
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
        }
    }
}
