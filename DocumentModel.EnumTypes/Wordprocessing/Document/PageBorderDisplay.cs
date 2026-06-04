namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the PageBorderDisplayValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.PageBorderDisplayValues))]
public enum PageBorderDisplay
{
  /// <summary>
  ///   Display Page Border on All Pages.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.PageBorderDisplayValues.AllPages))]
  AllPages,
  /// <summary>
  ///   Display Page Border on First Page.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.PageBorderDisplayValues.FirstPage))]
  FirstPage,
  /// <summary>
  ///   Display Page Border on All Pages Except First.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.PageBorderDisplayValues.NotFirstPage))]
  NotFirstPage
}