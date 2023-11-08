namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the DocGridValues enumeration.
/// </summary>
public enum DocGridKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;default&quot;.
  /// </summary>
  Default,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lines&quot;.
  /// </summary>
  Lines,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;linesAndChars&quot;.
  /// </summary>
  LinesAndChars,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;snapToChars&quot;.
  /// </summary>
  SnapToChars,
  
}
