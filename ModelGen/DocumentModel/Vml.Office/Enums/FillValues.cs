namespace DXVO;


/// <summary>
///   Shape Fill Type
/// </summary>
public enum FillValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gradientCenter&quot;.
  /// </summary>
  [EnumString("gradientCenter")]
  GradientCenter,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;solid&quot;.
  /// </summary>
  [EnumString("solid")]
  Solid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pattern&quot;.
  /// </summary>
  [EnumString("pattern")]
  Pattern,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tile&quot;.
  /// </summary>
  [EnumString("tile")]
  Tile,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;frame&quot;.
  /// </summary>
  [EnumString("frame")]
  Frame,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gradientUnscaled&quot;.
  /// </summary>
  [EnumString("gradientUnscaled")]
  GradientUnscaled,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gradientRadial&quot;.
  /// </summary>
  [EnumString("gradientRadial")]
  GradientRadial,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gradient&quot;.
  /// </summary>
  [EnumString("gradient")]
  Gradient,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;background&quot;.
  /// </summary>
  [EnumString("background")]
  Background,
  
}
