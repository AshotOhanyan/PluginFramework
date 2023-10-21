using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PluginFramework
{
    public class ImageProcessor
    {
        private List<Image> images = new List<Image>();
        private List<ImageEffect> effects = new List<ImageEffect>();

        public void AddImage(Image image)
        {
            images.Add(image);
        }

        public void AddEffect(ImageEffect effect,Image image)
        {
            effects.Add(effect);
            effect.TargetImage = image;
        }

        public void ApplyEffects()
        {
            foreach (var effect in effects)
            {
                effect.ApplyEffect(); // Apply the effect to the target image
            }
        }

        //private Image ApplyEffect(Image image, ImageEffect effect)
        //{
        //    Image modifiedImage = new Image
        //    {
        //        FileName = image.FileName,
        //        Width = image.Width,
        //        Height = image.Height,
        //        Quality = image.Quality,
        //        Format = image.Format
        //    };

        //    if (effect.Type == ImageEffectType.Resize)
        //    {
        //        if (effect.Parameters.ContainsKey("Width") && int.TryParse(effect.Parameters["Width"], out int width))
        //        {
        //            modifiedImage.Width = width;
        //            modifiedImage.Height = (int)((double)image.Height * width / image.Width);
        //        }
        //    }
        //    else if (effect.Type == ImageEffectType.Blur)
        //    {
        //        if (effect.Parameters.ContainsKey("Radius") && int.TryParse(effect.Parameters["Radius"], out int radius))
        //        {
        //            modifiedImage.Quality -= radius;
        //        }
        //    }
        //    else if (effect.Type == ImageEffectType.Grayscale)
        //    {
        //        modifiedImage.Format = "Grayscale";
        //    }

        //    return modifiedImage;
        //}

    }
}
