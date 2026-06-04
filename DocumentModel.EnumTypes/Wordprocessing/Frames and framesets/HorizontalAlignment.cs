namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the HorizontalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Math.HorizontalAlignmentValues))]
public enum HorizontalAlignment
{
  /// <summary>
  ///   Left Aligned Horizontally.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.HorizontalAlignmentValues.Left))]
  Left,
  /// <summary>
  ///   Centered Horizontally.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.HorizontalAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Right Aligned Horizontally.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Math.HorizontalAlignmentValues.Right))]
  Right,
  /// <summary>
  ///   Inside.
  /// </summary>
  Inside,
  /// <summary>
  ///   Outside.
  /// </summary>
  Outside
}