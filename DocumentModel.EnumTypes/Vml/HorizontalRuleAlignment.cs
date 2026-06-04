namespace DocumentModel.Vml;
/// <summary>
///   Alignment Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues))]
public enum HorizontalRuleAlignment
{
  /// <summary>
  ///   Left Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues.Left))]
  Left,
  /// <summary>
  ///   Right Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues.Right))]
  Right,
  /// <summary>
  ///   Center Alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.HorizontalRuleAlignmentValues.Center))]
  Center
}