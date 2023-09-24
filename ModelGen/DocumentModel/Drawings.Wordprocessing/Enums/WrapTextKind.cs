namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Text Wrapping Location
/// </summary>
public enum WrapTextKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bothSides&quot;.
  /// </summary>
  [EnumString("bothSides")]
  BothSides,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;left&quot;.
  /// </summary>
  [EnumString("left")]
  Left,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;right&quot;.
  /// </summary>
  [EnumString("right")]
  Right,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;largest&quot;.
  /// </summary>
  [EnumString("largest")]
  Largest,
  
}
