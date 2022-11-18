namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the SheetOp enumeration.
/// </summary>
public enum SheetOp
{
  /// <summary>
  /// insert.
  /// </summary>
  [XmlEnum("insert")]
  Insert,
  
  /// <summary>
  /// delete.
  /// </summary>
  [XmlEnum("delete")]
  Delete,
  
  /// <summary>
  /// reorder.
  /// </summary>
  [XmlEnum("reorder")]
  Reorder,
  
  /// <summary>
  /// rename.
  /// </summary>
  [XmlEnum("rename")]
  Rename,
  
}
