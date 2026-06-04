namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies horizontal alignment options for numbering levels in WordprocessingML documents.
/// This enumeration provides values for left, center, and right alignment, supporting advanced formatting and layout control for numbered lists and outline levels within document content.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues))]
public enum LevelJustification
{
  /// <summary>
  /// Align left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues.Left))]
  Left,
  /// <summary>
  /// Align center.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues.Center))]
  Center,
  /// <summary>
  /// Align right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues.Right))]
  Right
}