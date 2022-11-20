namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell Type
/// </summary>
public enum CellValues
{
  /// <summary>
  /// Boolean.
  /// </summary>
  [XmlEnum("b")]
  Boolean,
  
  /// <summary>
  /// Number.
  /// </summary>
  [XmlEnum("n")]
  Number,
  
  /// <summary>
  /// Error.
  /// </summary>
  [XmlEnum("e")]
  Error,
  
  /// <summary>
  /// Shared String.
  /// </summary>
  [XmlEnum("s")]
  SharedString,
  
  /// <summary>
  /// String.
  /// </summary>
  [XmlEnum("str")]
  String,
  
  /// <summary>
  /// Inline String.
  /// </summary>
  [XmlEnum("inlineStr")]
  InlineString,
  
  /// <summary>
  /// d.
  /// </summary>
  [XmlEnum("d")]
  Date,
  
}
