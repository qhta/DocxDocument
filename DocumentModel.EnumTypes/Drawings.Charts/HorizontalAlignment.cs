namespace DocumentModel.Math;
/// <summary>
///   Defines the HorizontalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Math.HorizontalAlignmentValues))]
public enum HorizontalAlignment
{
  /// <summary>
  ///   Left Justification.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.HorizontalAlignmentValues.Left))]
  Left,
  /// <summary>
  ///   Center.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.HorizontalAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.HorizontalAlignmentValues.Right))]
  Right
}