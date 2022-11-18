namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Order
/// </summary>
public enum PageOrder
{
  /// <summary>
  /// Down Then Over.
  /// </summary>
  [XmlEnum("downThenOver")]
  DownThenOver,
  
  /// <summary>
  /// Over Then Down.
  /// </summary>
  [XmlEnum("overThenDown")]
  OverThenDown,
  
}
