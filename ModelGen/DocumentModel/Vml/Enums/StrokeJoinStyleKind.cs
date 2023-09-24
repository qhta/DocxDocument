namespace DocumentModel.Vml;


/// <summary>
///   Line Join Type
/// </summary>
public enum StrokeJoinStyleKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;round&quot;.
  /// </summary>
  [EnumString("round")]
  Round,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bevel&quot;.
  /// </summary>
  [EnumString("bevel")]
  Bevel,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;miter&quot;.
  /// </summary>
  [EnumString("miter")]
  Miter,
  
}
