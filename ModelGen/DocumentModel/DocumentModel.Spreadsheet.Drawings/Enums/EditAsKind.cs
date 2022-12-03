namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Resizing Behaviors
/// </summary>
public enum EditAsKind
{
  /// <summary>
  /// Move and Resize With Anchor Cells.
  /// </summary>
  [XmlEnum("twoCell")]
  TwoCell,
  
  /// <summary>
  /// Move With Cells but Do Not Resize.
  /// </summary>
  [XmlEnum("oneCell")]
  OneCell,
  
  /// <summary>
  /// Do Not Move or Resize With Underlying Rows/Columns.
  /// </summary>
  [XmlEnum("absolute")]
  Absolute,
  
}
