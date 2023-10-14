namespace DocumentModel.Vml;


/// <summary>
///   Shape Fill Type
/// </summary>
public enum FillTypeKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;solid&quot;.
  /// </summary>
  Solid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gradient&quot;.
  /// </summary>
  Gradient,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gradientRadial&quot;.
  /// </summary>
  GradientRadial,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tile&quot;.
  /// </summary>
  Tile,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pattern&quot;.
  /// </summary>
  Pattern,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;frame&quot;.
  /// </summary>
  Frame,
  
}
