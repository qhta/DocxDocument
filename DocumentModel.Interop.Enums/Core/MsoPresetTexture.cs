namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies texture to be used to fill a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresettexture?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoPresetTexture))]
public enum PresetTexture
{
  /// <summary>
  /// Specifies texture to be used to fill a shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoPresetTextureMixed))]
  Mixed = -2,
  /// <summary>
  /// Papyrus texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTexturePapyrus))]
  Papyrus = 1,
  /// <summary>
  /// Canvas texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureCanvas))]
  Canvas = 2,
  /// <summary>
  /// Denim texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureDenim))]
  Denim = 3,
  /// <summary>
  /// Woven mat texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureWovenMat))]
  WovenMat = 4,
  /// <summary>
  /// Water droplets texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureWaterDroplets))]
  WaterDroplets = 5,
  /// <summary>
  /// Paper bag texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTexturePaperBag))]
  PaperBag = 6,
  /// <summary>
  /// Fish fossil texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureFishFossil))]
  FishFossil = 7,
  /// <summary>
  /// Sand texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureSand))]
  Sand = 8,
  /// <summary>
  /// Green marble texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureGreenMarble))]
  GreenMarble = 9,
  /// <summary>
  /// White marble texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureWhiteMarble))]
  WhiteMarble = 10,
  /// <summary>
  /// Brown marble texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureBrownMarble))]
  BrownMarble = 11,
  /// <summary>
  /// Granite texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureGranite))]
  Granite = 12,
  /// <summary>
  /// Newsprint texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureNewsprint))]
  Newsprint = 13,
  /// <summary>
  /// Recycled paper texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureRecycledPaper))]
  RecycledPaper = 14,
  /// <summary>
  /// Parchment texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureParchment))]
  Parchment = 15,
  /// <summary>
  /// Stationery texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureStationery))]
  Stationery = 16,
  /// <summary>
  /// Blue tissue paper texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureBlueTissuePaper))]
  BlueTissuePaper = 17,
  /// <summary>
  /// Pink tissue paper texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTexturePinkTissuePaper))]
  PinkTissuePaper = 18,
  /// <summary>
  /// Purple mesh texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTexturePurpleMesh))]
  PurpleMesh = 19,
  /// <summary>
  /// Bouquet texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureBouquet))]
  Bouquet = 20,
  /// <summary>
  /// Cork texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureCork))]
  Cork = 21,
  /// <summary>
  /// Walnut texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureWalnut))]
  Walnut = 22,
  /// <summary>
  /// Oak texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureOak))]
  Oak = 23,
  /// <summary>
  /// Medium wood texture.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTexture.msoTextureMediumWood))]
  MediumWood = 24
}
