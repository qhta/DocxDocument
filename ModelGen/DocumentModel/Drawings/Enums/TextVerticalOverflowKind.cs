namespace DocumentModel.Drawings;


/// <summary>
///   Text Vertical Overflow
/// </summary>
public enum TextVerticalOverflowKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;overflow&quot;.
  /// </summary>
  Overflow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ellipsis&quot;.
  /// </summary>
  Ellipsis,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;clip&quot;.
  /// </summary>
  Clip,
  
}
