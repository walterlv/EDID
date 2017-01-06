using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Walterlv.EdidDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            var infoList = Edid.Get();
            var info = infoList.Aggregate("Displaying Device List:", (sum, add) =>
            {
                var detail = add.GetDetail();

                var iWidth = detail.HorizontalImageSize;
                var iHeight = detail.VerticalImageSize;
                var iHypotenuse = Math.Sqrt(iWidth*iWidth + iHeight*iHeight);

                var dWidth = detail.HorizontalDisplaySize;
                var dHeight = detail.VerticalDisplaySize;
                var dHypotenuse = Math.Sqrt(dWidth*dWidth + dHeight*dHeight);

                var text = $"{detail.Manufacturer}{Environment.NewLine}" +
                           $"{iWidth}×{iHeight}, {Math.Round(iHypotenuse/2.54, 1)}{Environment.NewLine}" +
                           $"{dWidth}×{dHeight}, {Math.Round(dHypotenuse/2.54)/10}{Environment.NewLine}" +
                           $"{add.ToString()}";

                try
                {
                    File.WriteAllText($"{detail.Manufacturer}.txt", text, Encoding.UTF8);
                }
                catch (IOException ex)
                {
                    File.WriteAllText($"edid{++i}.txt", text, Encoding.UTF8);
                    text = $"{text}{Environment.NewLine}{ex.Message}";
                }
                catch (Exception ex)
                {
                    File.WriteAllText($"edid{++i}.txt", text, Encoding.UTF8);
                    text = $"{text}{Environment.NewLine}{ex.Message}";
                }

                return $"{sum}{Environment.NewLine}=========={Environment.NewLine}{text}";
            });
            Console.WriteLine(info);
            Console.Read();
        }
    }
}
