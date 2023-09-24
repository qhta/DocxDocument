namespace DocumentModel.Vml.Wordprocessing;


/// <summary>
///   Text Wrapping Type
/// </summary>
public enum WrapKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;topAndBottom&quot;.
  /// </summary>
  [EnumString("topAndBottom")]
  TopAndBottom,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;square&quot;.
  /// </summary>
  [EnumString("square")]
  Square,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tight&quot;.
  /// </summary>
  [EnumString("tight")]
  Tight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;through&quot;.
  /// </summary>
  [EnumString("through")]
  Through,
  
}
