namespace DocumentModel.Drawings;


/// <summary>
///   Text Wrapping Types
/// </summary>
public enum TextWrappingKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;square&quot;.
  /// </summary>
  [EnumString("square")]
  Square,
  
}
