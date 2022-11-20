namespace DocumentModel.Drawing;

/// <summary>
/// Effect Container Type
/// </summary>
public enum EffectContainerValues
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
