namespace DocumentModel.Spreadsheet;

/// <summary>
/// DDE Value Types
/// </summary>
public enum Dde
{
  /// <summary>
  /// Nil.
  /// </summary>
  [XmlEnum("nil")]
  Nil,
  
  /// <summary>
  /// Boolean.
  /// </summary>
  [XmlEnum("b")]
  Boolean,
  
  /// <summary>
  /// Real Number.
  /// </summary>
  [XmlEnum("n")]
  RealNumber,
  
  /// <summary>
  /// Error.
  /// </summary>
  [XmlEnum("e")]
  Error,
  
  /// <summary>
  /// String.
  /// </summary>
  [XmlEnum("str")]
  String,
  
}
