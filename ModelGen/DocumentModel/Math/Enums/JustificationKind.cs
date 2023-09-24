namespace DocumentModel.Math;


/// <summary>
///   Defines the JustificationValues enumeration.
/// </summary>
public enum JustificationKind
{
  
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
  ///   When the item is serialized out as xml, its value is &quot;center&quot;.
  /// </summary>
  [EnumString("center")]
  Center,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;centerGroup&quot;.
  /// </summary>
  [EnumString("centerGroup")]
  CenterGroup,
  
}
