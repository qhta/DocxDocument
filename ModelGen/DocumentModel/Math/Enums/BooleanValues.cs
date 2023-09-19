namespace DXM;


/// <summary>
///   Defines the BooleanValues enumeration.
/// </summary>
public enum BooleanValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;true&quot;.
  /// </summary>
  [EnumString("true")]
  True,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;false&quot;.
  /// </summary>
  [EnumString("false")]
  False,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;on&quot;.
  /// </summary>
  [EnumString("on")]
  On,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;off&quot;.
  /// </summary>
  [EnumString("off")]
  Off,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;0&quot;.
  /// </summary>
  [EnumString("0")]
  Zero,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;1&quot;.
  /// </summary>
  [EnumString("1")]
  One,
  
}
