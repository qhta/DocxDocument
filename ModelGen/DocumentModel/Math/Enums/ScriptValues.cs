namespace DXM;


/// <summary>
///   Defines the ScriptValues enumeration.
/// </summary>
public enum ScriptValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;roman&quot;.
  /// </summary>
  [EnumString("roman")]
  Roman,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;script&quot;.
  /// </summary>
  [EnumString("script")]
  Script,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;fraktur&quot;.
  /// </summary>
  [EnumString("fraktur")]
  Fraktur,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;double-struck&quot;.
  /// </summary>
  [EnumString("double-struck")]
  DoubleStruck,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sans-serif&quot;.
  /// </summary>
  [EnumString("sans-serif")]
  SansSerif,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;monospace&quot;.
  /// </summary>
  [EnumString("monospace")]
  Monospace,
  
}
