namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the shading texture to use for a selected item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtextureindex?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdTextureIndex")]
public enum TextureIndex
{
  /// <summary>
  /// No shading.
  /// </summary>
  [InteropEnumValue("wdTextureNone")]
  None = 0,
  /// <summary>
  /// 2.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture2Pt5Percent")]
  Texture2Pt5Percent = 25,
  /// <summary>
  /// 5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture5Percent")]
  Texture5Percent = 50,
  /// <summary>
  /// 7.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture7Pt5Percent")]
  Texture7Pt5Percent = 75,
  /// <summary>
  /// 10 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture10Percent")]
  Texture10Percent = 100,
  /// <summary>
  /// 12.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture12Pt5Percent")]
  Texture12Pt5Percent = 125,
  /// <summary>
  /// 15 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture15Percent")]
  Texture15Percent = 150,
  /// <summary>
  /// 17.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture17Pt5Percent")]
  Texture17Pt5Percent = 175,
  /// <summary>
  /// 20 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture20Percent")]
  Texture20Percent = 200,
  /// <summary>
  /// 22.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture22Pt5Percent")]
  Texture22Pt5Percent = 225,
  /// <summary>
  /// 25 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture25Percent")]
  Texture25Percent = 250,
  /// <summary>
  /// 27.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture27Pt5Percent")]
  Texture27Pt5Percent = 275,
  /// <summary>
  /// 30 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture30Percent")]
  Texture30Percent = 300,
  /// <summary>
  /// 32.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture32Pt5Percent")]
  Texture32Pt5Percent = 325,
  /// <summary>
  /// 35 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture35Percent")]
  Texture35Percent = 350,
  /// <summary>
  /// 37.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture37Pt5Percent")]
  Texture37Pt5Percent = 375,
  /// <summary>
  /// 40 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture40Percent")]
  Texture40Percent = 400,
  /// <summary>
  /// 42.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture42Pt5Percent")]
  Texture42Pt5Percent = 425,
  /// <summary>
  /// 45 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture45Percent")]
  Texture45Percent = 450,
  /// <summary>
  /// 47.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture47Pt5Percent")]
  Texture47Pt5Percent = 475,
  /// <summary>
  /// 50 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture50Percent")]
  Texture50Percent = 500,
  /// <summary>
  /// 52.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture52Pt5Percent")]
  Texture52Pt5Percent = 525,
  /// <summary>
  /// 55 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture55Percent")]
  Texture55Percent = 550,
  /// <summary>
  /// 57.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture57Pt5Percent")]
  Texture57Pt5Percent = 575,
  /// <summary>
  /// 60 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture60Percent")]
  Texture60Percent = 600,
  /// <summary>
  /// 62.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture62Pt5Percent")]
  Texture62Pt5Percent = 625,
  /// <summary>
  /// 65 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture65Percent")]
  Texture65Percent = 650,
  /// <summary>
  /// 67.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture67Pt5Percent")]
  Texture67Pt5Percent = 675,
  /// <summary>
  /// 70 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture70Percent")]
  Texture70Percent = 700,
  /// <summary>
  /// 72.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture72Pt5Percent")]
  Texture72Pt5Percent = 725,
  /// <summary>
  /// 75 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture75Percent")]
  Texture75Percent = 750,
  /// <summary>
  /// 77.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture77Pt5Percent")]
  Texture77Pt5Percent = 775,
  /// <summary>
  /// 80 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture80Percent")]
  Texture80Percent = 800,
  /// <summary>
  /// 82.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture82Pt5Percent")]
  Texture82Pt5Percent = 825,
  /// <summary>
  /// 85 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture85Percent")]
  Texture85Percent = 850,
  /// <summary>
  /// 87.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture87Pt5Percent")]
  Texture87Pt5Percent = 875,
  /// <summary>
  /// 90 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture90Percent")]
  Texture90Percent = 900,
  /// <summary>
  /// 92.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture92Pt5Percent")]
  Texture92Pt5Percent = 925,
  /// <summary>
  /// 95 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture95Percent")]
  Texture95Percent = 950,
  /// <summary>
  /// 97.5 percent shading.
  /// </summary>
  [InteropEnumValue("wdTexture97Pt5Percent")]
  Texture97Pt5Percent = 975,
  /// <summary>
  /// Solid shading.
  /// </summary>
  [InteropEnumValue("wdTextureSolid")]
  Solid = 1000,
  /// <summary>
  /// Diagonal cross shading.
  /// </summary>
  [InteropEnumValue("wdTextureDiagonalCross")]
  DiagonalCross = -12,
  /// <summary>
  /// Horizontal cross shading.
  /// </summary>
  [InteropEnumValue("wdTextureCross")]
  Cross = -11,
  /// <summary>
  /// Diagonal up shading.
  /// </summary>
  [InteropEnumValue("wdTextureDiagonalUp")]
  DiagonalUp = -10,
  /// <summary>
  /// Diagonal down shading.
  /// </summary>
  [InteropEnumValue("wdTextureDiagonalDown")]
  DiagonalDown = -9,
  /// <summary>
  /// Vertical shading.
  /// </summary>
  [InteropEnumValue("wdTextureVertical")]
  Vertical = -8,
  /// <summary>
  /// Horizontal shading.
  /// </summary>
  [InteropEnumValue("wdTextureHorizontal")]
  Horizontal = -7,
  /// <summary>
  /// Dark diagonal cross shading.
  /// </summary>
  [InteropEnumValue("wdTextureDarkDiagonalCross")]
  DarkDiagonalCross = -6,
  /// <summary>
  /// Dark horizontal cross shading.
  /// </summary>
  [InteropEnumValue("wdTextureDarkCross")]
  DarkCross = -5,
  /// <summary>
  /// Dark diagonal up shading.
  /// </summary>
  [InteropEnumValue("wdTextureDarkDiagonalUp")]
  DarkDiagonalUp = -4,
  /// <summary>
  /// Dark diagonal down shading.
  /// </summary>
  [InteropEnumValue("wdTextureDarkDiagonalDown")]
  DarkDiagonalDown = -3,
  /// <summary>
  /// Dark vertical shading.
  /// </summary>
  [InteropEnumValue("wdTextureDarkVertical")]
  DarkVertical = -2,
  /// <summary>
  /// Dark horizontal shading.
  /// </summary>
  [InteropEnumValue("wdTextureDarkHorizontal")]
  DarkHorizontal = -1
}
