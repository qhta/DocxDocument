namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FootnotePositionValues enumeration.
/// </summary>
public enum FootnotePositionKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pageBottom&quot;.
  /// </summary>
  PageBottom,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;beneathText&quot;.
  /// </summary>
  BeneathText,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sectEnd&quot;.
  /// </summary>
  SectionEnd,
  
}
