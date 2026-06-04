namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the MultiLevelValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues))]
public enum MultiLevel
{
  /// <summary>
  ///   Single Level Numbering Definition.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues.SingleLevel))]
  SingleLevel,
  /// <summary>
  ///   MultiLevelType Numbering Definition.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues.Multilevel))]
  Multilevel,
  /// <summary>
  ///   Hybrid MultiLevelType Numbering Definition.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues.HybridMultilevel))]
  HybridMultilevel
}