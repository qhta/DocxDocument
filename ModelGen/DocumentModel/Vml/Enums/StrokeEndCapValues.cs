namespace DXV;


/// <summary>
///   Stroke End Cap Type
/// </summary>
public enum StrokeEndCapValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flat&quot;.
  /// </summary>
  [EnumString("flat")]
  Flat,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;square&quot;.
  /// </summary>
  [EnumString("square")]
  Square,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;round&quot;.
  /// </summary>
  [EnumString("round")]
  Round,
  
}
