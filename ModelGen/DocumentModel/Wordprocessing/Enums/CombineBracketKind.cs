namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CombineBracketValues enumeration.
/// </summary>
public enum CombineBracketKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;round&quot;.
  /// </summary>
  [EnumString("round")]
  Round,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;square&quot;.
  /// </summary>
  [EnumString("square")]
  Square,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;angle&quot;.
  /// </summary>
  [EnumString("angle")]
  Angle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curly&quot;.
  /// </summary>
  [EnumString("curly")]
  Curly,
  
}
