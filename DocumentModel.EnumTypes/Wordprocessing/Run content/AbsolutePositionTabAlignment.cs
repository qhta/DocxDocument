namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the AbsolutePositionTabAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabAlignmentValues))]
public enum AbsolutePositionTabAlignment
{
  /// <summary>
  ///   Left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabAlignmentValues.Left))]
  Left,
  /// <summary>
  ///   Center.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabAlignmentValues.Right))]
  Right
}