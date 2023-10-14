namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Boolean Constraint
/// </summary>
public enum BoolOperatorKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;equ&quot;.
  /// </summary>
  Equal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gte&quot;.
  /// </summary>
  GreaterThanOrEqualTo,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lte&quot;.
  /// </summary>
  LessThanOrEqualTo,
  
}
