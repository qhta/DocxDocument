namespace DXW;


/// <summary>
///   Defines the NumberFormValues enumeration.
/// </summary>
public enum NumberFormValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;default&quot;.
  /// </summary>
  [EnumString("default")]
  Default,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lining&quot;.
  /// </summary>
  [EnumString("lining")]
  Lining,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;oldStyle&quot;.
  /// </summary>
  [EnumString("oldStyle")]
  OldStyle,
  
}
