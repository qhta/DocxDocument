namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the HeightRuleValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.HeightRuleValues))]
public enum HeightRule
{
  /// <summary>
  ///   Determine Height Based On Contents.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HeightRuleValues.Auto))]
  Auto,
  /// <summary>
  ///   Exact Height.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HeightRuleValues.Exact))]
  Exact,
  /// <summary>
  ///   Minimum Height.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HeightRuleValues.AtLeast))]
  AtLeast
}