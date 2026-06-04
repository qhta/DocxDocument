namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TableVerticalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues))]
public enum TableVerticalAlignment
{
  /// <summary>
  ///   top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues.Top))]
  Top,
  /// <summary>
  ///   center.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues.Bottom))]
  Bottom
}