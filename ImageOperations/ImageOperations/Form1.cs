using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ImageOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap clipboardImage = (Bitmap)Clipboard.GetImage();
            string imagePath;
            if (clipboardImage != null)
            {
                clipboardImage.MakeTransparent();
                //imagePath = Environment.CurrentDirectory; // "D:\\Prakash\\DemoSolution\\ImageOperations\\ImageOperations\\bin\\Debug"
                imagePath = AppDomain.CurrentDomain.BaseDirectory;
                imagePath = Application.StartupPath + "\\Images";
                //imagePath = Application.StartupPath;// "D:\\Prakash\\DemoSolution\\ImageOperations\\ImageOperations\\bin\\Debug"

                //imagePath = "D:\\Prakash\\DemoSolution\\ImageOperations\\ImageOperations\\Images\\new.bmp";+
                //imagePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location); // D:\Prakash\DemoSolution\ImageOperations\ImageOperations\bin\Debug
                //imagePath = System.AppDomain.CurrentDomain.BaseDirectory; //D:\Prakash\DemoSolution\ImageOperations\ImageOperations\bin\Debug\
                //imagePath = @"\Images\";
                string image_outputDir = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                DirectoryInfo df = new DirectoryInfo(image_outputDir + @"\images\");
                if (!df.Exists)
                {
                    // directory exists, do you want to delete it?
                    // uncomment lines below to delete image directory if found
                    //df.Delete(true);
                    // uncomment line below to create new one
                    DirectoryInfo di = Directory.CreateDirectory(image_outputDir + @"\images\ ");
                }
                else
                {
                    // create new directory
                    //DirectoryInfo di = Directory.CreateDirectory(image_outputDir + @"\images\ ");
                }
                string imageName = String.Format("{0:yyyy-MM-dd-HH-mm-ss}", System.DateTime.Now);
                clipboardImage.Save(image_outputDir + "\\images\\" + imageName + ".bmp");
            }
            else
                MessageBox.Show("No image in clipboard press Print Screen button on your keyboard to capture image");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap clipboardImage = (Bitmap)Clipboard.GetImage();
            string imagePath;
            if (clipboardImage != null)
            {
                clipboardImage.MakeTransparent();
                //imagePath = Environment.CurrentDirectory; // "D:\\Prakash\\DemoSolution\\ImageOperations\\ImageOperations\\bin\\Debug"
                imagePath = AppDomain.CurrentDomain.BaseDirectory;
                imagePath = Application.StartupPath + "\\Images";
                //imagePath = Application.StartupPath;// "D:\\Prakash\\DemoSolution\\ImageOperations\\ImageOperations\\bin\\Debug"

                //imagePath = "D:\\Prakash\\DemoSolution\\ImageOperations\\ImageOperations\\Images\\new.bmp";+
                //imagePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location); // D:\Prakash\DemoSolution\ImageOperations\ImageOperations\bin\Debug
                //imagePath = System.AppDomain.CurrentDomain.BaseDirectory; //D:\Prakash\DemoSolution\ImageOperations\ImageOperations\bin\Debug\
                //imagePath = @"\Images\";
                string image_outputDir = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                DirectoryInfo df = new DirectoryInfo(image_outputDir + @"\images\");
                if (!df.Exists)
                {
                    // directory exists, do you want to delete it?
                    // uncomment lines below to delete image directory if found
                    //df.Delete(true);
                    // uncomment line below to create new one
                    DirectoryInfo di = Directory.CreateDirectory(image_outputDir + @"\images\ ");
                }
                else
                {
                    // create new directory
                    //DirectoryInfo di = Directory.CreateDirectory(image_outputDir + @"\images\ ");
                }
                string imageName = String.Format("{0:yyyy-MM-dd-HH-mm-ss}", System.DateTime.Now);
                clipboardImage.Save(image_outputDir + "\\images\\" + imageName + ".bmp");
                Form1 form = new Form1();
                form.Close();
                Application.Exit();
            }
            else
                MessageBox.Show("No image in clipboard press Print Screen button on your keyboard to capture image");
        }
    }
}
