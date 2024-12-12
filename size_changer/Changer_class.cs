using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace size_changer
{
    public static class Changer
    {
        public static void change_images(string directory, string ox)
        {


            if (directory != "" && ox != "")
            {
                string[] imageFiles = Directory.GetFiles(directory, "*.*", SearchOption.TopDirectoryOnly);

                foreach (string imageFile in imageFiles)
                { 
                    FileInfo file = new FileInfo(imageFile);
                    string fileex = file.Extension;
                    if (fileex == ".png" || fileex == ".jpeg")
                    {
                        MessageBox.Show(".");
                        Image img = Image.FromFile(imageFile);
                        if(img.Width > Convert.ToInt32(ox))
                        {
                            try
                            {
                                int Converted_ox = Convert.ToInt32(ox);
                                Bitmap bmp = new Bitmap(img, Converted_ox, Convert.ToInt32(Converted_ox / ((float)img.Width / (float)img.Height)));
                                img.Dispose();
                                bmp.Save(imageFile, ImageFormat.Jpeg);
                            }

                            catch
                            {
                                MessageBox.Show(imageFile);
                            }
                        }
                    }
                }

                MessageBox.Show("процесс закончен");
            }

            else
            {
                MessageBox.Show("не все поля заполнены");
            }
            
        }
    }
}
