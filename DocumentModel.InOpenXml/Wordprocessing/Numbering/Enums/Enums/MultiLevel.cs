namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the MultiLevelValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.MultiLevelValues))]
public enum MultiLevel
{
  /// <summary>
  ///   Single Level Numbering Definition.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MultiLevelValues.SingleLevel))]
  SingleLevel,
  /// <summary>
  ///   MultiLevelType Numbering Definition.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MultiLevelValues.Multilevel))]
  Multilevel,
  /// <summary>
  ///   Hybrid MultiLevelType Numbering Definition.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MultiLevelValues.HybridMultilevel))]
  HybridMultilevel
}