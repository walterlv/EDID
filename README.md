# EDID
Read EDID information to get Extended Display Identification Data, such as screen physical size, etc.

## Sample

This is a sample running result on my computer.

```
Displaying Device List:  
==========  
DELL S2240T  
48×27, 21.7  
477×268, 21.5  
00 FF FF FF FF FF FF 00 10 AC 95 A0 55 31 59 30  
2E 17 01 03 80 30 1B 78 EA 27 95 A5 55 50 A2 27  
0B 50 54 A5 4B 00 71 4F 81 80 D1 C0 01 01 01 01  
01 01 01 01 01 01 02 3A 80 18 71 38 2D 40 58 2C  
45 00 DD 0C 11 00 00 1E 00 00 00 FF 00 46 50 35  
33 50 33 42 42 30 59 31 55 0A 00 00 00 FC 00 44  
45 4C 4C 20 53 32 32 34 30 54 0A 20 00 00 00 FD  
00 38 4C 1E 53 11 00 0A 20 20 20 20 20 20 00 3B  

==========  
DELL U2414H  
53×30, 24  
527×296, 23.8  
00 FF FF FF FF FF FF 00 10 AC B2 A0 4C 35 41 33  
1F 1A 01 03 80 35 1E 78 EE 7E 75 A7 55 52 9C 27  
0F 50 54 A5 4B 00 71 4F 81 80 A9 C0 A9 40 D1 C0  
01 01 01 01 01 01 02 3A 80 18 71 38 2D 40 58 2C  
45 00 0F 28 21 00 00 1E 00 00 00 FF 00 47 4E 36  
34 56 36 37 50 33 41 35 4C 0A 00 00 00 FC 00 44  
45 4C 4C 20 55 32 34 31 34 48 0A 20 00 00 00 FD  
00 38 4C 1E 53 11 00 0A 20 20 20 20 20 20 01 66  
```

## Getting Started

- Visual Studio Community 2015/2017 (or the latest version)
- .NET Framework 4.5

## Reference

[Extended Display Identification Data](https://en.wikipedia.org/wiki/Extended_Display_Identification_Data)

## Thanks

[EDID Puller](https://edid.codeplex.com/) from [CodePlex](https://www.codeplex.com/)  
This project provides code to get EDID data. Most of my code comes from this project.  
It targets .NET 2.0, but its code can still work on .NET 4.5. 

[edidreader](https://github.com/dgallegos/edidreader)  
It's an open source online EDID parser on github. My project doesn't use any code from it, but the calculation procedure helps me a lot.
