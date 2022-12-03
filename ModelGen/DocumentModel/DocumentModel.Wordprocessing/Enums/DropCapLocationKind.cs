namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DropCapLocationValues enumeration.
/// </summary>
public enum DropCapLocationKind
{
  /// <summary>
  /// Not Drop Cap.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Drop Cap Inside Margin.
  /// </summary>
  [XmlEnum("drop")]
  Drop,
  
  /// <summary>
  /// Drop Cap Outside Margin.
  /// </summary>
  [XmlEnum("margin")]
  Margin,
  
}
