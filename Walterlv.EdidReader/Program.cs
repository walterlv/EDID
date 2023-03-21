using System.Text;

using Walterlv.EdidReader;

var infoList = Edid.Get();
Console.WriteLine("Displaying Device List:");
Console.WriteLine();
for (var i = 0; i < infoList.Length; i++)
{
    if (i is not 0)
    {
        Console.WriteLine("==========");
    }

    var detail = infoList[i].GetDetail();

    var iWidth = detail.HorizontalImageSize;
    var iHeight = detail.VerticalImageSize;
    var iHypotenuse = Math.Sqrt(iWidth * iWidth + iHeight * iHeight);

    var dWidth = detail.HorizontalDisplaySize;
    var dHeight = detail.VerticalDisplaySize;
    var dHypotenuse = Math.Sqrt(dWidth * dWidth + dHeight * dHeight);

    var text = $"""
        {detail.Manufacturer}
        {iWidth}×{iHeight}, {Math.Round(iHypotenuse / 2.54, 1)}
        {dWidth}×{dHeight}, {Math.Round(dHypotenuse / 2.54) / 10}
        {infoList[i]}
        """;
    Console.WriteLine(text);

    try
    {
        File.WriteAllText($"{detail.Manufacturer}.txt", text, Encoding.UTF8);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
}

Console.WriteLine("Press ANY KEY to exit...");
Console.Read();
