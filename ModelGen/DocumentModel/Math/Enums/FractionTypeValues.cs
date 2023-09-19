namespace DXM;


/// <summary>
///   Defines the FractionTypeValues enumeration.
/// </summary>
public enum FractionTypeValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bar&quot;.
  /// </summary>
  [EnumString("bar")]
  Bar,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;skw&quot;.
  /// </summary>
  [EnumString("skw")]
  Skewed,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lin&quot;.
  /// </summary>
  [EnumString("lin")]
  Linear,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;noBar&quot;.
  /// </summary>
  [EnumString("noBar")]
  NoBar,
  
}
