namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Point Type
/// </summary>
public enum PointKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;node&quot;.
  /// </summary>
  Node,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;asst&quot;.
  /// </summary>
  Assistant,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;doc&quot;.
  /// </summary>
  Document,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pres&quot;.
  /// </summary>
  Presentation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;parTrans&quot;.
  /// </summary>
  ParentTransition,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sibTrans&quot;.
  /// </summary>
  SiblingTransition,
  
}
