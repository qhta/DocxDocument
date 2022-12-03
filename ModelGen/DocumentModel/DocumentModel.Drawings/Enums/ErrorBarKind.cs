namespace DocumentModel.Drawings;

/// <summary>
/// Error Bar Type
/// </summary>
public enum ErrorBarKind
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
