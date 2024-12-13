using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Processing;

namespace size_changer
{
    public static class Changer
    {

        private static string[] validExtensions = { ".png", ".jpeg", ".jpg" };
        public static void change_images(string directory, string ox)
        {



            if (directory != "" && ox != "")
            {
                string[] imageFiles = Directory.GetFiles(directory, "*.*", SearchOption.TopDirectoryOnly);

                foreach (string imageFile in imageFiles)
                { 
                    FileInfo file = new FileInfo(imageFile);
                    if (validExtensions.Contains(file.Extension.ToLower()))
                    {
                        try
                        {
                            System.Drawing.Image img = System.Drawing.Image.FromFile(imageFile);
                            if (img.Width > Convert.ToInt32(ox))
                            {
                                img_saver(imageFile, ox, img);
                            }
                        }

                        catch (Exception ex)
{
                            MessageBox.Show($"Ошибка при обработке файла {imageFile}: {ex.Message}");
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

        private static void img_saver(string imageFile, string ox, System.Drawing.Image img)
        {
            int Converted_ox = Convert.ToInt32(ox);
            SixLabors.ImageSharp.Image image = SixLabors.ImageSharp.Image.Load(imageFile);
            image.Mutate(x => x.Resize(Converted_ox, Convert.ToInt32(Converted_ox / ((float)img.Width / (float)img.Height))));

            img.Dispose();
            image.Save(imageFile);
        }
    }
}
