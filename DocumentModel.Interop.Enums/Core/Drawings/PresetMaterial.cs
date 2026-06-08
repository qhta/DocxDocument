namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the extrusion surface material.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetmaterial?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoPresetMaterial")]
public enum PresetMaterial
{
  /// <summary>
  /// Specifies the extrusion surface material.
  /// </summary>
  [InteropEnumValue("msoPresetMaterialMixed")]
  Mixed = -2,
  /// <summary>
  /// Matte.
  /// </summary>
  [InteropEnumValue("msoMaterialMatte")]
  Matte = 1,
  /// <summary>
  /// Plastic.
  /// </summary>
  [InteropEnumValue("msoMaterialPlastic")]
  Plastic = 2,
  /// <summary>
  /// Metal.
  /// </summary>
  [InteropEnumValue("msoMaterialMetal")]
  Metal = 3,
  /// <summary>
  /// Wire frame.
  /// </summary>
  [InteropEnumValue("msoMaterialWireFrame")]
  WireFrame = 4,
  /// <summary>
  /// Matte2
  /// </summary>
  [InteropEnumValue("msoMaterialMatte2")]
  Matte2 = 5,
  /// <summary>
  /// Plastic2
  /// </summary>
  [InteropEnumValue("msoMaterialPlastic2")]
  Plastic2 = 6,
  /// <summary>
  /// Metal2
  /// </summary>
  [InteropEnumValue("msoMaterialMetal2")]
  Metal2 = 7,
  /// <summary>
  /// Warm Matte
  /// </summary>
  [InteropEnumValue("msoMaterialWarmMatte")]
  WarmMatte = 8,
  /// <summary>
  /// Translucent Powder
  /// </summary>
  [InteropEnumValue("msoMaterialTranslucentPowder")]
  TranslucentPowder = 9,
  /// <summary>
  /// Powder
  /// </summary>
  [InteropEnumValue("msoMaterialPowder")]
  Powder = 10,
  /// <summary>
  /// DarkEdge
  /// </summary>
  [InteropEnumValue("msoMaterialDarkEdge")]
  DarkEdge = 11,
  /// <summary>
  /// Soft Edge
  /// </summary>
  [InteropEnumValue("msoMaterialSoftEdge")]
  SoftEdge = 12,
  /// <summary>
  /// Clear
  /// </summary>
  [InteropEnumValue("msoMaterialClear")]
  Clear = 13,
  /// <summary>
  /// Flat
  /// </summary>
  [InteropEnumValue("msoMaterialFlat")]
  Flat = 14,
  /// <summary>
  /// Soft Metal
  /// </summary>
  [InteropEnumValue("msoMaterialSoftMetal")]
  SoftMetal = 15
}
