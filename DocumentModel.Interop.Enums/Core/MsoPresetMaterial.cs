namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the extrusion surface material.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetmaterial?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoPresetMaterial")]
public enum PresetMaterial
{
  /// <summary>
  /// Specifies the extrusion surface material.
  /// </summary>
  [OfficeInteropEnumValue("msoPresetMaterialMixed")]
  Mixed = -2,
  /// <summary>
  /// Matte.
  /// </summary>
  [OfficeInteropEnumValue("msoMaterialMatte")]
  Matte = 1,
  /// <summary>
  /// Plastic.
  /// </summary>
  [OfficeInteropEnumValue("msoMaterialPlastic")]
  Plastic = 2,
  /// <summary>
  /// Metal.
  /// </summary>
  [OfficeInteropEnumValue("msoMaterialMetal")]
  Metal = 3,
  /// <summary>
  /// Wire frame.
  /// </summary>
  [OfficeInteropEnumValue("msoMaterialWireFrame")]
  WireFrame = 4,
  /// <summary>
  /// Matte2
  /// </summary>
  [OfficeInteropEnumValue("msoMaterialMatte2")]
  Matte2 = 5,
  /// <summary>
  /// Plastic2
  /// </summary>
  [OfficeInteropEnumValue("msoMaterialPlastic2")]
  Plastic2 = 6,
  /// <summary>
  /// Metal2
  /// </summary>
  [OfficeInteropEnumValue("msoMaterialMetal2")]
  Metal2 = 7,
  /// <summary>
  /// Warm Matte
  /// </summary>
  [OfficeInteropEnumValue("msoMaterialWarmMatte")]
  WarmMatte = 8,
  /// <summary>
  /// Translucent Powder
  /// </summary>
  [OfficeInteropEnumValue("msoMaterialTranslucentPowder")]
  TranslucentPowder = 9,
  /// <summary>
  /// Powder
  /// </summary>
  [OfficeInteropEnumValue("msoMaterialPowder")]
  Powder = 10,
  /// <summary>
  /// DarkEdge
  /// </summary>
  [OfficeInteropEnumValue("msoMaterialDarkEdge")]
  DarkEdge = 11,
  /// <summary>
  /// Soft Edge
  /// </summary>
  [OfficeInteropEnumValue("msoMaterialSoftEdge")]
  SoftEdge = 12,
  /// <summary>
  /// Clear
  /// </summary>
  [OfficeInteropEnumValue("msoMaterialClear")]
  Clear = 13,
  /// <summary>
  /// Flat
  /// </summary>
  [OfficeInteropEnumValue("msoMaterialFlat")]
  Flat = 14,
  /// <summary>
  /// Soft Metal
  /// </summary>
  [OfficeInteropEnumValue("msoMaterialSoftMetal")]
  SoftMetal = 15
}
