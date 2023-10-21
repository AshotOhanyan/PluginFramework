using PluginFramework;

var processor = new ImageProcessor();
var image1 = new Image() { FileName = "nkar", Width = 500,Height = 40,Quality = 90 };
var image2 = new Image() { FileName = "nkar1", Width = 342, Height = 123, Quality = 150 };

processor.AddImage(image1);
processor.AddImage(image2);

var resizeEffect = new ImageEffect
{
    Type = ImageEffectType.Resize,
    Parameters = new Dictionary<string, string>
    {
        { "Width", "50" }
    }
};

var blurEffect = new ImageEffect
{
    Type = ImageEffectType.Blur,
    Parameters = new Dictionary<string, string>
    {
        { "Radius", "6" }
    }
};

var grayscaleEffect = new ImageEffect
{
    Type = ImageEffectType.Grayscale
};

processor.AddEffect(resizeEffect, image1);
processor.AddEffect(blurEffect,image2);
processor.AddEffect(grayscaleEffect,image2);

processor.ApplyEffects();

Console.WriteLine($"Name : {image1.FileName}, Width : {image1.Width}, Height : {image1.Height}, Quality : {image1.Quality}, Format : {image1.Format}");
Console.WriteLine($"Name : {image2.FileName}, Width : {image2.Width}, Height : {image2.Height}, Quality : {image2.Quality}, Format : {image2.Format}");