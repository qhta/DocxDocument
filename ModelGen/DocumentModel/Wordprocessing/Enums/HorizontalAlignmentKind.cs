namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the HorizontalAlignmentValues enumeration.
/// </summary>
public enum HorizontalAlignmentKind
{
  
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
  ///   When the item is serialized out as xml, its value is &quot;inside&quot;.
  /// </summary>
  [EnumString("inside")]
  Inside,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;outside&quot;.
  /// </summary>
  [EnumString("outside")]
  Outside,
  
}
