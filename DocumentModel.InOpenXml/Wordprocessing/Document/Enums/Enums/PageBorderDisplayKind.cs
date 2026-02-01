namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the PageBorderDisplayValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.PageBorderDisplayValues))]
public enum PageBorderDisplayKind
{
  /// <summary>
  ///   Display Page Border on All Pages.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.PageBorderDisplayValues.AllPages))]
  AllPages,
  /// <summary>
  ///   Display Page Border on First Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.PageBorderDisplayValues.FirstPage))]
  FirstPage,
  /// <summary>
  ///   Display Page Border on All Pages Except First.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.PageBorderDisplayValues.NotFirstPage))]
  NotFirstPage
}