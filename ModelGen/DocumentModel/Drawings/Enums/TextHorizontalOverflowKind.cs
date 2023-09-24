namespace DocumentModel.Drawings;


/// <summary>
///   Text Horizontal Overflow Types
/// </summary>
public enum TextHorizontalOverflowKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;overflow&quot;.
  /// </summary>
  [EnumString("overflow")]
  Overflow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;clip&quot;.
  /// </summary>
  [EnumString("clip")]
  Clip,
  
}
