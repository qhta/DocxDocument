namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the VerticalAlignmentValues enumeration.
/// </summary>
public enum VerticalAlignmentKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;inline&quot;.
  /// </summary>
  [EnumString("inline")]
  Inline,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;top&quot;.
  /// </summary>
  [EnumString("top")]
  Top,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;center&quot;.
  /// </summary>
  [EnumString("center")]
  Center,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bottom&quot;.
  /// </summary>
  [EnumString("bottom")]
  Bottom,
  
  
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
