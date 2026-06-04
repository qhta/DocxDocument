namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TableRowAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues))]
public enum TableRowAlignment
{
  /// <summary>
  ///   left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues.Left))]
  Left,
  /// <summary>
  ///   center.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues.Right))]
  Right
}