namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Axis Type
/// </summary>
public enum AxisValues
{
  /// <summary>
  /// Self.
  /// </summary>
  [XmlEnum("self")]
  Self,
  
  /// <summary>
  /// Child.
  /// </summary>
  [XmlEnum("ch")]
  Child,
  
  /// <summary>
  /// Descendant.
  /// </summary>
  [XmlEnum("des")]
  Descendant,
  
  /// <summary>
  /// Descendant or Self.
  /// </summary>
  [XmlEnum("desOrSelf")]
  DescendantOrSelf,
  
  /// <summary>
  /// Parent.
  /// </summary>
  [XmlEnum("par")]
  Parent,
  
  /// <summary>
  /// Ancestor.
  /// </summary>
  [XmlEnum("ancst")]
  Ancestor,
  
  /// <summary>
  /// Ancestor or Self.
  /// </summary>
  [XmlEnum("ancstOrSelf")]
  AncestorOrSelf,
  
  /// <summary>
  /// Follow Sibling.
  /// </summary>
  [XmlEnum("followSib")]
  FollowSibling,
  
  /// <summary>
  /// Preceding Sibling.
  /// </summary>
  [XmlEnum("precedSib")]
  PrecedingSibling,
  
  /// <summary>
  /// Follow.
  /// </summary>
  [XmlEnum("follow")]
  Follow,
  
  /// <summary>
  /// Preceding.
  /// </summary>
  [XmlEnum("preced")]
  Preceding,
  
  /// <summary>
  /// Root.
  /// </summary>
  [XmlEnum("root")]
  Root,
  
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}
