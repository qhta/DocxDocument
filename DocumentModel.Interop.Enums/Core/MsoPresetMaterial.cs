namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the extrusion surface material.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresetmaterial?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoPresetMaterial))]
public enum PresetMaterial
{
  /// <summary>
  /// Specifies the extrusion surface material.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoPresetMaterialMixed))]
  Mixed = -2,
  /// <summary>
  /// Matte.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoMaterialMatte))]
  Matte = 1,
  /// <summary>
  /// Plastic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoMaterialPlastic))]
  Plastic = 2,
  /// <summary>
  /// Metal.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoMaterialMetal))]
  Metal = 3,
  /// <summary>
  /// Wire frame.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoMaterialWireFrame))]
  WireFrame = 4,
  /// <summary>
  /// Matte2
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoMaterialMatte2))]
  Matte2 = 5,
  /// <summary>
  /// Plastic2
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoMaterialPlastic2))]
  Plastic2 = 6,
  /// <summary>
  /// Metal2
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoMaterialMetal2))]
  Metal2 = 7,
  /// <summary>
  /// Warm Matte
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoMaterialWarmMatte))]
  WarmMatte = 8,
  /// <summary>
  /// Translucent Powder
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoMaterialTranslucentPowder))]
  TranslucentPowder = 9,
  /// <summary>
  /// Powder
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoMaterialPowder))]
  Powder = 10,
  /// <summary>
  /// DarkEdge
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoMaterialDarkEdge))]
  DarkEdge = 11,
  /// <summary>
  /// Soft Edge
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoMaterialSoftEdge))]
  SoftEdge = 12,
  /// <summary>
  /// Clear
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoMaterialClear))]
  Clear = 13,
  /// <summary>
  /// Flat
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoMaterialFlat))]
  Flat = 14,
  /// <summary>
  /// Soft Metal
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetMaterial.msoMaterialSoftMetal))]
  SoftMetal = 15
}
