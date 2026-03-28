namespace DocumentModel.Drawings;
/// <summary>
///   Preset Material Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.PresetMaterialTypeValues))]
public enum PresetMaterial
{
  /// <summary>
  ///   Legacy Matte.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.LegacyMatte))]
  LegacyMatte = 1,

  /// <summary>
  ///   Legacy Plastic.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.LegacyPlastic))]
  LegacyPlastic,
  /// <summary>
  ///   Legacy Metal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.LegacyMetal))]
  LegacyMetal,
  /// <summary>
  ///   Legacy Wireframe.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.LegacyWireframe))]
  LegacyWireframe,
  /// <summary>
  ///   Matte.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.Matte))]
  Matte,
  /// <summary>
  ///   Plastic.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.Plastic))]
  Plastic,
  /// <summary>
  ///   Metal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.Metal))]
  Metal,
  /// <summary>
  ///   Warm Matte.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.WarmMatte))]
  WarmMatte,
  /// <summary>
  ///   Translucent Powder.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.TranslucentPowder))]
  TranslucentPowder,
  /// <summary>
  ///   Powder.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.Powder))]
  Powder,
  /// <summary>
  ///   Dark Edge.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.DarkEdge))]
  DarkEdge,
  /// <summary>
  ///   Soft Edge.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.SoftEdge))]
  SoftEdge,
  /// <summary>
  ///   Clear.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.Clear))]
  Clear,
  /// <summary>
  ///   Flat.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.Flat))]
  Flat,
  /// <summary>
  ///   Soft Metal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetMaterialTypeValues.SoftMetal))]
  SoftMetal
}