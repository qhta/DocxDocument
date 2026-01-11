namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the PageBorderDisplayValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PageBorderDisplayKind
{
  /// <summary>
  ///   Display Page Border on All Pages.
  /// </summary>
  AllPages,
  /// <summary>
  ///   Display Page Border on First Page.
  /// </summary>
  FirstPage,
  /// <summary>
  ///   Display Page Border on All Pages Except First.
  /// </summary>
  NotFirstPage
}