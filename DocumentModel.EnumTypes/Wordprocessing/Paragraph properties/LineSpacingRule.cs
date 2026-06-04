namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the LineSpacingRuleValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues))]
public enum LineSpacingRule
{
  /// <summary>
  ///   Automatically Determined Line Height.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues.Auto))]
  Auto,
  /// <summary>
  ///   Exact Line Height.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues.Exact))]
  Exact,
  /// <summary>
  ///   Minimum Line Height.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LineSpacingRuleValues.AtLeast))]
  AtLeast
}