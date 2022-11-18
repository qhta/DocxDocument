namespace DocumentModel.Spreadsheet;

/// <summary>
/// Qualifier
/// </summary>
public enum Qualifier
{
  /// <summary>
  /// Double Quote.
  /// </summary>
  [XmlEnum("doubleQuote")]
  DoubleQuote,
  
  /// <summary>
  /// Single Quote.
  /// </summary>
  [XmlEnum("singleQuote")]
  SingleQuote,
  
  /// <summary>
  /// No Text Qualifier.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}
