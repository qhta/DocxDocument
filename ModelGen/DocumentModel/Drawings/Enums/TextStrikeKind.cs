namespace DocumentModel.Drawings;


/// <summary>
///   Text Strike Type
/// </summary>
public enum TextStrikeKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;noStrike&quot;.
  /// </summary>
  NoStrike,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sngStrike&quot;.
  /// </summary>
  SingleStrike,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dblStrike&quot;.
  /// </summary>
  DoubleStrike,
  
}
