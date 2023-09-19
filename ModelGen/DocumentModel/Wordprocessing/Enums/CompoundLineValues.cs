namespace DXW;


/// <summary>
///   Defines the CompoundLineValues enumeration.
/// </summary>
public enum CompoundLineValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sng&quot;.
  /// </summary>
  [EnumString("sng")]
  Simple,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dbl&quot;.
  /// </summary>
  [EnumString("dbl")]
  Double,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thickThin&quot;.
  /// </summary>
  [EnumString("thickThin")]
  ThickThin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thinThick&quot;.
  /// </summary>
  [EnumString("thinThick")]
  ThinThick,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tri&quot;.
  /// </summary>
  [EnumString("tri")]
  Triple,
  
}
