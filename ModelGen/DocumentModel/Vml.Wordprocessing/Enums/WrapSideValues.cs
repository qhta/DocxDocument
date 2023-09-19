namespace DXVW;


/// <summary>
///   Text Wrapping Side
/// </summary>
public enum WrapSideValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;both&quot;.
  /// </summary>
  [EnumString("both")]
  Both,
  
  
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
