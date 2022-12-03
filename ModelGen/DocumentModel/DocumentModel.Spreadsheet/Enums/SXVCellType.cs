namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SXVCellType enumeration.
/// </summary>
public enum SXVCellType
{
  /// <summary>
  /// b.
  /// </summary>
  [XmlEnum("b")]
  Boolean,
  
  /// <summary>
  /// n.
  /// </summary>
  [XmlEnum("n")]
  Number,
  
  /// <summary>
  /// e.
  /// </summary>
  [XmlEnum("e")]
  Error,
  
  /// <summary>
  /// str.
  /// </summary>
  [XmlEnum("str")]
  String,
  
  /// <summary>
  /// d.
  /// </summary>
  [XmlEnum("d")]
  Date,
  
  /// <summary>
  /// bl.
  /// </summary>
  [XmlEnum("bl")]
  Blank,
  
}
