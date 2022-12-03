namespace DocumentModel.Drawings;

/// <summary>
/// Effect Container Type
/// </summary>
public enum EffectContainerKind
{
  /// <summary>
  /// Sibling.
  /// </summary>
  [XmlEnum("sib")]
  Sibling,
  
  /// <summary>
  /// Tree.
  /// </summary>
  [XmlEnum("tree")]
  Tree,
  
}
