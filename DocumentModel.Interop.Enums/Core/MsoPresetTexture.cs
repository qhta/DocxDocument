namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies texture to be used to fill a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresettexture?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoPresetTexture")]
public enum PresetTexture
{
  /// <summary>
  /// Specifies texture to be used to fill a shape.
  /// </summary>
  [OfficeInteropEnumValue("msoPresetTextureMixed")]
  Mixed = -2,
  /// <summary>
  /// Papyrus texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTexturePapyrus")]
  Papyrus = 1,
  /// <summary>
  /// Canvas texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureCanvas")]
  Canvas = 2,
  /// <summary>
  /// Denim texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureDenim")]
  Denim = 3,
  /// <summary>
  /// Woven mat texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureWovenMat")]
  WovenMat = 4,
  /// <summary>
  /// Water droplets texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureWaterDroplets")]
  WaterDroplets = 5,
  /// <summary>
  /// Paper bag texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTexturePaperBag")]
  PaperBag = 6,
  /// <summary>
  /// Fish fossil texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureFishFossil")]
  FishFossil = 7,
  /// <summary>
  /// Sand texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureSand")]
  Sand = 8,
  /// <summary>
  /// Green marble texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureGreenMarble")]
  GreenMarble = 9,
  /// <summary>
  /// White marble texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureWhiteMarble")]
  WhiteMarble = 10,
  /// <summary>
  /// Brown marble texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureBrownMarble")]
  BrownMarble = 11,
  /// <summary>
  /// Granite texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureGranite")]
  Granite = 12,
  /// <summary>
  /// Newsprint texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureNewsprint")]
  Newsprint = 13,
  /// <summary>
  /// Recycled paper texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureRecycledPaper")]
  RecycledPaper = 14,
  /// <summary>
  /// Parchment texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureParchment")]
  Parchment = 15,
  /// <summary>
  /// Stationery texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureStationery")]
  Stationery = 16,
  /// <summary>
  /// Blue tissue paper texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureBlueTissuePaper")]
  BlueTissuePaper = 17,
  /// <summary>
  /// Pink tissue paper texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTexturePinkTissuePaper")]
  PinkTissuePaper = 18,
  /// <summary>
  /// Purple mesh texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTexturePurpleMesh")]
  PurpleMesh = 19,
  /// <summary>
  /// Bouquet texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureBouquet")]
  Bouquet = 20,
  /// <summary>
  /// Cork texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureCork")]
  Cork = 21,
  /// <summary>
  /// Walnut texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureWalnut")]
  Walnut = 22,
  /// <summary>
  /// Oak texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureOak")]
  Oak = 23,
  /// <summary>
  /// Medium wood texture.
  /// </summary>
  [OfficeInteropEnumValue("msoTextureMediumWood")]
  MediumWood = 24
}
