namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the PageBorderOffsetValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.PageBorderOffsetValues))]
public enum PageBorderOffset
{
  /// <summary>
  ///   Page Border Is Positioned Relative to Page Edges.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.PageBorderOffsetValues.Page))]
  Page,
  /// <summary>
  ///   Page Border Is Positioned Relative to Text Extents.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.PageBorderOffsetValues.Text))]
  Text
}