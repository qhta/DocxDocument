namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Function Type
/// </summary>
public enum FunctionKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cnt&quot;.
  /// </summary>
  Count,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pos&quot;.
  /// </summary>
  Position,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;revPos&quot;.
  /// </summary>
  ReversePosition,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;posEven&quot;.
  /// </summary>
  PositionEven,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;posOdd&quot;.
  /// </summary>
  PositionOdd,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;var&quot;.
  /// </summary>
  Variable,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;depth&quot;.
  /// </summary>
  Depth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;maxDepth&quot;.
  /// </summary>
  MaxDepth,
  
}
