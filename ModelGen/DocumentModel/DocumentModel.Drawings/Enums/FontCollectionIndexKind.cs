namespace DocumentModel.Drawings;

/// <summary>
/// Font Collection Index
/// </summary>
public enum FontCollectionIndexKind
{
  /// <summary>
  /// Major Font.
  /// </summary>
  [XmlEnum("major")]
  Major,
  
  /// <summary>
  /// Minor Font.
  /// </summary>
  [XmlEnum("minor")]
  Minor,
  
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}
