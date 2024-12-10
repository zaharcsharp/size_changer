using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace size_changer
{
    public static class Changer
    {
        public static void change_images(string directory, int ox)
        {
            string[] imageFiles = Directory.GetFiles(directory, "*.*", SearchOption.TopDirectoryOnly);

            foreach (string imageFile in imageFiles)
            {
                Image img = Image.FromFile(imageFile);
                var newImage = ScaleImage(img, ox);
                img.Dispose();
                newImage.Save(imageFile);
            }
        }

        public static Image ScaleImage(Image image, int Width)
        {
            var newImage = new Bitmap(Width, Convert.ToInt32(Width/1.77777777));
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, Width, Convert.ToInt32(Width / 1.77777777));
            return newImage;
        }
    }
}
