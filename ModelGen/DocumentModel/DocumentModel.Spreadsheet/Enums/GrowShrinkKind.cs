namespace DocumentModel.Spreadsheet;

/// <summary>
/// Grow Shrink Type
/// </summary>
public enum GrowShrinkKind
{
  /// <summary>
  /// Insert and Delete On Refresh.
  /// </summary>
  [XmlEnum("insertDelete")]
  InsertDelete,
  
  /// <summary>
  /// Insert and Clear On Refresh.
  /// </summary>
  [XmlEnum("insertClear")]
  InsertClear,
  
  /// <summary>
  /// Overwrite and Clear On Refresh.
  /// </summary>
  [XmlEnum("overwriteClear")]
  OverwriteClear,
  
}
