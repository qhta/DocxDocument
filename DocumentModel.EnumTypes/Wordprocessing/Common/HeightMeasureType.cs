namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the HeightRuleValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues))]
public enum HeightMeasureType
{
  /// <summary>
  ///   Determine Height Based On Contents.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues.Auto))]
  Auto,
  /// <summary>
  ///   Exact Height.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues.Exact))]
  Exact,
  /// <summary>
  ///   Minimum Height.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HeightRuleValues.AtLeast))]
  AtLeast
}