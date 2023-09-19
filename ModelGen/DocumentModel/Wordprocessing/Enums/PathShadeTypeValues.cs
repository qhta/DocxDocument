namespace DXW;


/// <summary>
///   Defines the PathShadeTypeValues enumeration.
/// </summary>
public enum PathShadeTypeValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;shape&quot;.
  /// </summary>
  [EnumString("shape")]
  Shape,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;circle&quot;.
  /// </summary>
  [EnumString("circle")]
  Circle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rect&quot;.
  /// </summary>
  [EnumString("rect")]
  Rect,
  
}
