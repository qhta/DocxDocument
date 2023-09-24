namespace DocumentModel.Vml;


/// <summary>
///   Shape Fill Type
/// </summary>
public enum FillTypeKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;solid&quot;.
  /// </summary>
  [EnumString("solid")]
  Solid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gradient&quot;.
  /// </summary>
  [EnumString("gradient")]
  Gradient,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gradientRadial&quot;.
  /// </summary>
  [EnumString("gradientRadial")]
  GradientRadial,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tile&quot;.
  /// </summary>
  [EnumString("tile")]
  Tile,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pattern&quot;.
  /// </summary>
  [EnumString("pattern")]
  Pattern,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;frame&quot;.
  /// </summary>
  [EnumString("frame")]
  Frame,
  
}
