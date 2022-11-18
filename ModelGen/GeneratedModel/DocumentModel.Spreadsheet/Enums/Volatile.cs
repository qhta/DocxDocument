namespace DocumentModel.Spreadsheet;

/// <summary>
/// Volatile Dependency Value Types
/// </summary>
public enum Volatile
{
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
  [XmlEnum("s")]
  String,
  
}
