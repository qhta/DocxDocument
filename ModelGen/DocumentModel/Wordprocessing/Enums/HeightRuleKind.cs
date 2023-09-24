namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the HeightRuleValues enumeration.
/// </summary>
public enum HeightRuleKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;auto&quot;.
  /// </summary>
  [EnumString("auto")]
  Auto,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;exact&quot;.
  /// </summary>
  [EnumString("exact")]
  Exact,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;atLeast&quot;.
  /// </summary>
  [EnumString("atLeast")]
  AtLeast,
  
}
