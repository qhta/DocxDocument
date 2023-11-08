namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Element Type
/// </summary>
public enum ElementKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;all&quot;.
  /// </summary>
  All,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;doc&quot;.
  /// </summary>
  Document,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;node&quot;.
  /// </summary>
  Node,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;norm&quot;.
  /// </summary>
  Normal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;nonNorm&quot;.
  /// </summary>
  NonNormal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;asst&quot;.
  /// </summary>
  Assistant,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;nonAsst&quot;.
  /// </summary>
  NonAssistant,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;parTrans&quot;.
  /// </summary>
  ParentTransition,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pres&quot;.
  /// </summary>
  Presentation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sibTrans&quot;.
  /// </summary>
  SiblingTransition,
  
}
