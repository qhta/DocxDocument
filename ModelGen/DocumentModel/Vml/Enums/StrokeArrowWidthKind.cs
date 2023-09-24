namespace DocumentModel.Vml;


/// <summary>
///   Stroke Arrowhead Width
/// </summary>
public enum StrokeArrowWidthKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;narrow&quot;.
  /// </summary>
  [EnumString("narrow")]
  Narrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;medium&quot;.
  /// </summary>
  [EnumString("medium")]
  Medium,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wide&quot;.
  /// </summary>
  [EnumString("wide")]
  Wide,
  
}
