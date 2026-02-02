namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Specifies the preset material type options for 3D rendering in WordprocessingML drawings.
/// This enumeration provides values for various material effects, supporting advanced visual appearance and surface rendering for 3D shapes and graphical elements within the document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.PresetMaterialTypeValues))]
public enum PresetMaterial
{
  /// <summary>
  /// Legacy matte material.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.LegacyMatte))]
  LegacyMatte,
  /// <summary>
  /// Legacy plastic material.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.LegacyPlastic))]
  LegacyPlastic,
  /// <summary>
  /// Legacy metal material.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.LegacyMetal))]
  LegacyMetal,
  /// <summary>
  /// Legacy wireframe material.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.LegacyWireframe))]
  LegacyWireframe,
  /// <summary>
  /// Matte material.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.Matte))]
  Matte,
  /// <summary>
  /// Plastic material.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.Plastic))]
  Plastic,
  /// <summary>
  /// Metal material.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.Metal))]
  Metal,
  /// <summary>
  /// Warm matte material.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.WarmMatte))]
  WarmMatte,
  /// <summary>
  /// Translucent powder material.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.TranslucentPowder))]
  TranslucentPowder,
  /// <summary>
  /// Powder material.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.Powder))]
  Powder,
  /// <summary>
  /// Dark edge material.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.DarkEdge))]
  DarkEdge,
  /// <summary>
  /// Soft edge material.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.SoftEdge))]
  SoftEdge,
  /// <summary>
  /// Clear material.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.Clear))]
  Clear,
  /// <summary>
  /// Flat material.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.Flat))]
  Flat,
  /// <summary>
  /// Soft metal material.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.SoftMetal))]
  SoftMetal,
  /// <summary>
  /// No material effect.
  /// </summary>
  None
}