namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CombineBracketValues enumeration.
/// </summary>
public enum CombineBracketKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;round&quot;.
  /// </summary>
  Round,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;square&quot;.
  /// </summary>
  Square,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;angle&quot;.
  /// </summary>
  Angle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curly&quot;.
  /// </summary>
  Curly,
  
}
