namespace DocumentModel.Drawing;

/// <summary>
/// Font Collection Index
/// </summary>
public enum FontCollectionIndex
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
