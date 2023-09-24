namespace DocumentModel.Vml;


/// <summary>
///   Shadow Type
/// </summary>
public enum ShadowKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;single&quot;.
  /// </summary>
  [EnumString("single")]
  Single,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;double&quot;.
  /// </summary>
  [EnumString("double")]
  Double,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;emboss&quot;.
  /// </summary>
  [EnumString("emboss")]
  Emboss,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;perspective&quot;.
  /// </summary>
  [EnumString("perspective")]
  Perspective,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;shapeRelative&quot;.
  /// </summary>
  [EnumString("shapeRelative")]
  ShapeRelative,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;drawingRelative&quot;.
  /// </summary>
  [EnumString("drawingRelative")]
  DrawingRelative,
  
}
