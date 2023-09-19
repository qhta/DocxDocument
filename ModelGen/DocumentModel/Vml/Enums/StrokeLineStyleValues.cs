namespace DXV;


/// <summary>
///   Stroke Line Style
/// </summary>
public enum StrokeLineStyleValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;single&quot;.
  /// </summary>
  [EnumString("single")]
  Single,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thinThin&quot;.
  /// </summary>
  [EnumString("thinThin")]
  ThinThin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thinThick&quot;.
  /// </summary>
  [EnumString("thinThick")]
  ThinThick,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thickThin&quot;.
  /// </summary>
  [EnumString("thickThin")]
  ThickThin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thickBetweenThin&quot;.
  /// </summary>
  [EnumString("thickBetweenThin")]
  ThickBetweenThin,
  
}
