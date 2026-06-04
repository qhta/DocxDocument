namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies texture to be used to fill a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresettexture?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoPresetTexture")]
public enum PresetTexture
{
  /// <summary>
  /// Specifies texture to be used to fill a shape.
  /// </summary>
  [InteropEnumValue("msoPresetTextureMixed")]
  Mixed = -2,
  /// <summary>
  /// Papyrus texture.
  /// </summary>
  [InteropEnumValue("msoTexturePapyrus")]
  Papyrus = 1,
  /// <summary>
  /// Canvas texture.
  /// </summary>
  [InteropEnumValue("msoTextureCanvas")]
  Canvas = 2,
  /// <summary>
  /// Denim texture.
  /// </summary>
  [InteropEnumValue("msoTextureDenim")]
  Denim = 3,
  /// <summary>
  /// Woven mat texture.
  /// </summary>
  [InteropEnumValue("msoTextureWovenMat")]
  WovenMat = 4,
  /// <summary>
  /// Water droplets texture.
  /// </summary>
  [InteropEnumValue("msoTextureWaterDroplets")]
  WaterDroplets = 5,
  /// <summary>
  /// Paper bag texture.
  /// </summary>
  [InteropEnumValue("msoTexturePaperBag")]
  PaperBag = 6,
  /// <summary>
  /// Fish fossil texture.
  /// </summary>
  [InteropEnumValue("msoTextureFishFossil")]
  FishFossil = 7,
  /// <summary>
  /// Sand texture.
  /// </summary>
  [InteropEnumValue("msoTextureSand")]
  Sand = 8,
  /// <summary>
  /// Green marble texture.
  /// </summary>
  [InteropEnumValue("msoTextureGreenMarble")]
  GreenMarble = 9,
  /// <summary>
  /// White marble texture.
  /// </summary>
  [InteropEnumValue("msoTextureWhiteMarble")]
  WhiteMarble = 10,
  /// <summary>
  /// Brown marble texture.
  /// </summary>
  [InteropEnumValue("msoTextureBrownMarble")]
  BrownMarble = 11,
  /// <summary>
  /// Granite texture.
  /// </summary>
  [InteropEnumValue("msoTextureGranite")]
  Granite = 12,
  /// <summary>
  /// Newsprint texture.
  /// </summary>
  [InteropEnumValue("msoTextureNewsprint")]
  Newsprint = 13,
  /// <summary>
  /// Recycled paper texture.
  /// </summary>
  [InteropEnumValue("msoTextureRecycledPaper")]
  RecycledPaper = 14,
  /// <summary>
  /// Parchment texture.
  /// </summary>
  [InteropEnumValue("msoTextureParchment")]
  Parchment = 15,
  /// <summary>
  /// Stationery texture.
  /// </summary>
  [InteropEnumValue("msoTextureStationery")]
  Stationery = 16,
  /// <summary>
  /// Blue tissue paper texture.
  /// </summary>
  [InteropEnumValue("msoTextureBlueTissuePaper")]
  BlueTissuePaper = 17,
  /// <summary>
  /// Pink tissue paper texture.
  /// </summary>
  [InteropEnumValue("msoTexturePinkTissuePaper")]
  PinkTissuePaper = 18,
  /// <summary>
  /// Purple mesh texture.
  /// </summary>
  [InteropEnumValue("msoTexturePurpleMesh")]
  PurpleMesh = 19,
  /// <summary>
  /// Bouquet texture.
  /// </summary>
  [InteropEnumValue("msoTextureBouquet")]
  Bouquet = 20,
  /// <summary>
  /// Cork texture.
  /// </summary>
  [InteropEnumValue("msoTextureCork")]
  Cork = 21,
  /// <summary>
  /// Walnut texture.
  /// </summary>
  [InteropEnumValue("msoTextureWalnut")]
  Walnut = 22,
  /// <summary>
  /// Oak texture.
  /// </summary>
  [InteropEnumValue("msoTextureOak")]
  Oak = 23,
  /// <summary>
  /// Medium wood texture.
  /// </summary>
  [InteropEnumValue("msoTextureMediumWood")]
  MediumWood = 24
}
