namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Error Bar Type
/// </summary>
public enum ErrorBarValues
{
  /// <summary>
  /// Both.
  /// </summary>
  [XmlEnum("both")]
  Both,
  
  /// <summary>
  /// Minus.
  /// </summary>
  [XmlEnum("minus")]
  Minus,
  
  /// <summary>
  /// Plus.
  /// </summary>
  [XmlEnum("plus")]
  Plus,
  
}
