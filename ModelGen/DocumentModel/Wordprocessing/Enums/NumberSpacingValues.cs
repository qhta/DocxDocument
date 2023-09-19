namespace DXW;


/// <summary>
///   Defines the NumberSpacingValues enumeration.
/// </summary>
public enum NumberSpacingValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;default&quot;.
  /// </summary>
  [EnumString("default")]
  Default,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;proportional&quot;.
  /// </summary>
  [EnumString("proportional")]
  Proportional,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tabular&quot;.
  /// </summary>
  [EnumString("tabular")]
  Tabular,
  
}
