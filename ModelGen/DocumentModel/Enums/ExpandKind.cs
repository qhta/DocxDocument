namespace DocumentModel;


/// <summary>
///   Defines the ExpandValues enumeration.
/// </summary>
public enum ExpandKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;topLeft&quot;.
  /// </summary>
  [EnumString("topLeft")]
  TopLeft,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;top&quot;.
  /// </summary>
  [EnumString("top")]
  Top,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;topRight&quot;.
  /// </summary>
  [EnumString("topRight")]
  TopRight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;left&quot;.
  /// </summary>
  [EnumString("left")]
  Left,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;center&quot;.
  /// </summary>
  [EnumString("center")]
  Center,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;right&quot;.
  /// </summary>
  [EnumString("right")]
  Right,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bottomLeft&quot;.
  /// </summary>
  [EnumString("bottomLeft")]
  BottomLeft,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bottom&quot;.
  /// </summary>
  [EnumString("bottom")]
  Bottom,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bottomRight&quot;.
  /// </summary>
  [EnumString("bottomRight")]
  BottomRight,
  
}
