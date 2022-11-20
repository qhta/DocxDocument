namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageBorderDisplayValues enumeration.
/// </summary>
public enum PageBorderDisplayValues
{
  /// <summary>
  /// Display Page Border on All Pages.
  /// </summary>
  [XmlEnum("allPages")]
  AllPages,
  
  /// <summary>
  /// Display Page Border on First Page.
  /// </summary>
  [XmlEnum("firstPage")]
  FirstPage,
  
  /// <summary>
  /// Display Page Border on All Pages Except First.
  /// </summary>
  [XmlEnum("notFirstPage")]
  NotFirstPage,
  
}
