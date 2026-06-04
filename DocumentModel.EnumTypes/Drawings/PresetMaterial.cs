namespace DocumentModel.Drawings;
/// <summary>
///   Preset Material Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues))]
public enum PresetMaterial
{
  /// <summary>
  ///   Legacy Matte.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues.LegacyMatte))]
  LegacyMatte = 1,

  /// <summary>
  ///   Legacy Plastic.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues.LegacyPlastic))]
  LegacyPlastic,
  /// <summary>
  ///   Legacy Metal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues.LegacyMetal))]
  LegacyMetal,
  /// <summary>
  ///   Legacy Wireframe.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues.LegacyWireframe))]
  LegacyWireframe,
  /// <summary>
  ///   Matte.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues.Matte))]
  Matte,
  /// <summary>
  ///   Plastic.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues.Plastic))]
  Plastic,
  /// <summary>
  ///   Metal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues.Metal))]
  Metal,
  /// <summary>
  ///   Warm Matte.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues.WarmMatte))]
  WarmMatte,
  /// <summary>
  ///   Translucent Powder.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues.TranslucentPowder))]
  TranslucentPowder,
  /// <summary>
  ///   Powder.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues.Powder))]
  Powder,
  /// <summary>
  ///   Dark Edge.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues.DarkEdge))]
  DarkEdge,
  /// <summary>
  ///   Soft Edge.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues.SoftEdge))]
  SoftEdge,
  /// <summary>
  ///   Clear.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues.Clear))]
  Clear,
  /// <summary>
  ///   Flat.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues.Flat))]
  Flat,
  /// <summary>
  ///   Soft Metal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues.SoftMetal))]
  SoftMetal
}