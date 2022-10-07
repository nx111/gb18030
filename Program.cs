// See https://aka.ms/new-console-template for more information
using cp52936;
using System;
using System.IO;

FileStream fileStream = new FileStream("test.txt", FileMode.Open);
BinaryReader binary = new BinaryReader(fileStream);
byte[] data = binary.ReadBytes((int)fileStream.Length);
GB18030Encoding encoding = new GB18030Encoding(true);
string result = encoding.Gb18030_GetString(data);
Console.WriteLine(result);
