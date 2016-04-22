using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SaveScreenshot
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Bitmap clipboardImage = (Bitmap)Clipboard.GetImage();
            string imagePath;
            if (clipboardImage != null)
            {
                clipboardImage.MakeTransparent();
                imagePath = Application.StartupPath + "\\Images";
                string imageOutputDir = Path.GetDirectoryName(Application.ExecutablePath);
                DirectoryInfo df = new DirectoryInfo(imageOutputDir + @"\images\");
                if (!df.Exists)
                {
                    // to create new directory
                    DirectoryInfo di = Directory.CreateDirectory(imageOutputDir + @"\images\ ");
                }
                else
                {
                    // directory exists, delete image directory if found, do you want to delete it?
                    //df.Delete(true);
                }
                string imageName = String.Format("{0:yyyy-MM-dd-HH-mm-ss}", DateTime.Now);
                clipboardImage.Save(imageOutputDir + "\\images\\" + imageName + ".bmp");
                Application.Exit();
            }
            else
            {
                Console.WriteLine("No image in clipboard press Print Screen button on your keyboard to capture image. Tip :- use Alt + Print screen to save current open window ");
                Console.ReadKey();
            }
        }
    }
}
