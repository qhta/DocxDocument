namespace DocumentModel.Drawings;


/// <summary>
///   Line End Width
/// </summary>
public enum LineEndWidthKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sm&quot;.
  /// </summary>
  [EnumString("sm")]
  Small,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;med&quot;.
  /// </summary>
  [EnumString("med")]
  Medium,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lg&quot;.
  /// </summary>
  [EnumString("lg")]
  Large,
  
}
