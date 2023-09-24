namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TableVerticalAlignmentValues enumeration.
/// </summary>
public enum TableVerticalAlignmentKind
{
  
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
  
}
