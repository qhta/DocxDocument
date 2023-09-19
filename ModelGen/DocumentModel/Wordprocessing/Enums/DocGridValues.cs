namespace DXW;


/// <summary>
///   Defines the DocGridValues enumeration.
/// </summary>
public enum DocGridValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;default&quot;.
  /// </summary>
  [EnumString("default")]
  Default,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lines&quot;.
  /// </summary>
  [EnumString("lines")]
  Lines,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;linesAndChars&quot;.
  /// </summary>
  [EnumString("linesAndChars")]
  LinesAndChars,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;snapToChars&quot;.
  /// </summary>
  [EnumString("snapToChars")]
  SnapToChars,
  
}
