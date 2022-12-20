namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum LineWidth
{
  Line025pt = 2,
  Line050pt = 4,
  Line075pt = 6,
  Line100pt = 8,
  Line150pt = 12, // 0x0000000C
  Line225pt = 18, // 0x00000012
  Line300pt = 24, // 0x00000018
  Line450pt = 36, // 0x00000024
  Line600pt = 48, // 0x00000030
}