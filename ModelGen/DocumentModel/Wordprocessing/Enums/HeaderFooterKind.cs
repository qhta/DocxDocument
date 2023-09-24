namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the HeaderFooterValues enumeration.
/// </summary>
public enum HeaderFooterKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;even&quot;.
  /// </summary>
  [EnumString("even")]
  Even,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;default&quot;.
  /// </summary>
  [EnumString("default")]
  Default,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;first&quot;.
  /// </summary>
  [EnumString("first")]
  First,
  
}
