namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the LineSpacingRuleValues enumeration.
/// </summary>
public enum LineSpacingRuleKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;auto&quot;.
  /// </summary>
  Auto,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;exact&quot;.
  /// </summary>
  Exact,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;atLeast&quot;.
  /// </summary>
  AtLeast,
  
}
