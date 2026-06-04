namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the PageBorderOffsetValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.PageBorderOffsetValues))]
public enum PageBorderOffset
{
  /// <summary>
  ///   Page Border Is Positioned Relative to Page Edges.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.PageBorderOffsetValues.Page))]
  Page,
  /// <summary>
  ///   Page Border Is Positioned Relative to Text Extents.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.PageBorderOffsetValues.Text))]
  Text
}