namespace DocumentModel.Vml;


/// <summary>
///   Stroke Arrowhead Length
/// </summary>
public enum StrokeArrowLengthKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;short&quot;.
  /// </summary>
  [EnumString("short")]
  Short,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;medium&quot;.
  /// </summary>
  [EnumString("medium")]
  Medium,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;long&quot;.
  /// </summary>
  [EnumString("long")]
  Long,
  
}
