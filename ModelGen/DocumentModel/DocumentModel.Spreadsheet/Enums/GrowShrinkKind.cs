namespace DocumentModel.Spreadsheet;

/// <summary>
/// Grow Shrink Type
/// </summary>
public enum GrowShrinkKind
{
  /// <summary>
  /// Insert and Delete On Refresh.
  /// </summary>
  InsertDelete,
  
  /// <summary>
  /// Insert and Clear On Refresh.
  /// </summary>
  InsertClear,
  
  /// <summary>
  /// Overwrite and Clear On Refresh.
  /// </summary>
  OverwriteClear,
  
}
