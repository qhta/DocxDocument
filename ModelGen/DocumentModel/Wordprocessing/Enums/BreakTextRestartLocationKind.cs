namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the BreakTextRestartLocationValues enumeration.
/// </summary>
public enum BreakTextRestartLocationKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
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
  ///   When the item is serialized out as xml, its value is &quot;all&quot;.
  /// </summary>
  [EnumString("all")]
  All,
  
}
