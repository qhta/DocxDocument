namespace DocumentModel.Drawings;

/// <summary>
/// One by One Animation Value Definition
/// </summary>
public enum AnimateOneByOneKind
{
  /// <summary>
  /// Disable One-by-One.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// One By One.
  /// </summary>
  [XmlEnum("one")]
  One,
  
  /// <summary>
  /// By Branch One By One.
  /// </summary>
  [XmlEnum("branch")]
  Branch,
  
}
