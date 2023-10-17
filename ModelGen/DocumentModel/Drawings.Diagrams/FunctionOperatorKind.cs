namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Function Operator
/// </summary>
public enum FunctionOperatorKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;equ&quot;.
  /// </summary>
  Equal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;neq&quot;.
  /// </summary>
  NotEqualTo,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gt&quot;.
  /// </summary>
  GreaterThan,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lt&quot;.
  /// </summary>
  LessThan,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gte&quot;.
  /// </summary>
  GreaterThanOrEqualTo,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lte&quot;.
  /// </summary>
  LessThanOrEqualTo,
  
}
