namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Resizing Behaviors
/// </summary>
public enum EditAsKind
{
  /// <summary>
  /// Move and Resize With Anchor Cells.
  /// </summary>
  TwoCell,
  
  /// <summary>
  /// Move With Cells but Do Not Resize.
  /// </summary>
  OneCell,
  
  /// <summary>
  /// Do Not Move or Resize With Underlying Rows/Columns.
  /// </summary>
  Absolute,
  
}
