using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PluginFramework
{
    public class ImageEffect
    {
        public ImageEffectType Type { get; set; }
        public Dictionary<string, string> Parameters { get; set; }
        public Image TargetImage { get; set; }

        public void ApplyEffect()
        {
            if (Type == ImageEffectType.Resize)
            {
                if (Parameters.ContainsKey("Width") && int.TryParse(Parameters["Width"], out int width))
                {
                    TargetImage.Width = width;
                    TargetImage.Height = (int)((double)TargetImage.Height * width / TargetImage.Width);
                }
            }
            else if (Type == ImageEffectType.Blur)
            {
                if (Parameters.ContainsKey("Radius") && int.TryParse(Parameters["Radius"], out int radius))
                {
                    TargetImage.Quality -= radius;
                }
            }
            else if (Type == ImageEffectType.Grayscale)
            {
                TargetImage.Format = "Grayscale";
            }
            else if(Type == ImageEffectType.Angle)
            {
                if (Parameters.ContainsKey("Angle") && int.TryParse(Parameters["Angle"], out int angle))
                {
                    TargetImage.Andgle= angle;
                }
            }
            else if(Type == ImageEffectType.Brightness)
            {
                if (Parameters.ContainsKey("Brightness") && int.TryParse(Parameters["Brightness"], out int brightness))
                {
                    TargetImage.Brightness = brightness;
                }
            }
        }
    }

    public enum ImageEffectType
    {
        Resize,
        Blur,
        Grayscale,
        Angle,
        Brightness
    }
}
