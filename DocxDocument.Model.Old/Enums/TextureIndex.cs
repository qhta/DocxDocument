namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum TextureIndex
{
  DiagonalCross = -12, // 0xFFFFFFF4
  Cross = -11, // 0xFFFFFFF5
  DiagonalUp = -10, // 0xFFFFFFF6
  DiagonalDown = -9, // 0xFFFFFFF7
  Vertical = -8, // 0xFFFFFFF8
  Horizontal = -7, // 0xFFFFFFF9
  DarkDiagonalCross = -6, // 0xFFFFFFFA
  DarkCross = -5, // 0xFFFFFFFB
  DarkDiagonalUp = -4, // 0xFFFFFFFC
  DarkDiagonalDown = -3, // 0xFFFFFFFD
  DarkVertical = -2, // 0xFFFFFFFE
  DarkHorizontal = -1, // 0xFFFFFFFF
  None = 0,
  Shade2Pt5Percent = 25, // 0x00000019
  Shade5Percent = 50, // 0x00000032
  Shade7Pt5Percent = 75, // 0x0000004B
  Shade10Percent = 100, // 0x00000064
  Shade12Pt5Percent = 125, // 0x0000007D
  Shade15Percent = 150, // 0x00000096
  Shade17Pt5Percent = 175, // 0x000000AF
  Shade20Percent = 200, // 0x000000C8
  Shade22Pt5Percent = 225, // 0x000000E1
  Shade25Percent = 250, // 0x000000FA
  Shade27Pt5Percent = 275, // 0x00000113
  Shade30Percent = 300, // 0x0000012C
  Shade32Pt5Percent = 325, // 0x00000145
  Shade35Percent = 350, // 0x0000015E
  Shade37Pt5Percent = 375, // 0x00000177
  Shade40Percent = 400, // 0x00000190
  Shade42Pt5Percent = 425, // 0x000001A9
  Shade45Percent = 450, // 0x000001C2
  Shade47Pt5Percent = 475, // 0x000001DB
  Shade50Percent = 500, // 0x000001F4
  Shade52Pt5Percent = 525, // 0x0000020D
  Shade55Percent = 550, // 0x00000226
  Shade57Pt5Percent = 575, // 0x0000023F
  Shade60Percent = 600, // 0x00000258
  Shade62Pt5Percent = 625, // 0x00000271
  Shade65Percent = 650, // 0x0000028A
  Shade67Pt5Percent = 675, // 0x000002A3
  Shade70Percent = 700, // 0x000002BC
  Shade72Pt5Percent = 725, // 0x000002D5
  Shade75Percent = 750, // 0x000002EE
  Shade77Pt5Percent = 775, // 0x00000307
  Shade80Percent = 800, // 0x00000320
  Shade82Pt5Percent = 825, // 0x00000339
  Shade85Percent = 850, // 0x00000352
  Shade87Pt5Percent = 875, // 0x0000036B
  Shade90Percent = 900, // 0x00000384
  Shade92Pt5Percent = 925, // 0x0000039D
  Shade95Percent = 950, // 0x000003B6
  Shade97Pt5Percent = 975, // 0x000003CF
  Solid = 1000, // 0x000003E8

}