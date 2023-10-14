namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Axis Type
/// </summary>
public enum AxisKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;self&quot;.
  /// </summary>
  Self,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ch&quot;.
  /// </summary>
  Child,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;des&quot;.
  /// </summary>
  Descendant,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;desOrSelf&quot;.
  /// </summary>
  DescendantOrSelf,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;par&quot;.
  /// </summary>
  Parent,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ancst&quot;.
  /// </summary>
  Ancestor,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ancstOrSelf&quot;.
  /// </summary>
  AncestorOrSelf,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;followSib&quot;.
  /// </summary>
  FollowSibling,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;precedSib&quot;.
  /// </summary>
  PrecedingSibling,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;follow&quot;.
  /// </summary>
  Follow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;preced&quot;.
  /// </summary>
  Preceding,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;root&quot;.
  /// </summary>
  Root,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  None,
  
}
