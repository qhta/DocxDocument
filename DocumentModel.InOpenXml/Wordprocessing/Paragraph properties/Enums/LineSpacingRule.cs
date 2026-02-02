namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the LineSpacingRuleValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.LineSpacingRuleValues))]
public enum LineSpacingRule
{
  /// <summary>
  ///   Automatically Determined Line Height.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LineSpacingRuleValues.Auto))]
  Auto,
  /// <summary>
  ///   Exact Line Height.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LineSpacingRuleValues.Exact))]
  Exact,
  /// <summary>
  ///   Minimum Line Height.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.LineSpacingRuleValues.AtLeast))]
  AtLeast
}