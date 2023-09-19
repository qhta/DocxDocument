namespace DXM;


/// <summary>
///   Defines the BreakBinaryOperatorValues enumeration.
/// </summary>
public enum BreakBinaryOperatorValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;before&quot;.
  /// </summary>
  [EnumString("before")]
  Before,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;after&quot;.
  /// </summary>
  [EnumString("after")]
  After,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;repeat&quot;.
  /// </summary>
  [EnumString("repeat")]
  Repeat,
  
}
