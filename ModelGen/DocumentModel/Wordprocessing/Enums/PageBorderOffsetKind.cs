namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageBorderOffsetValues enumeration.
/// </summary>
public enum PageBorderOffsetKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;page&quot;.
  /// </summary>
  [EnumString("page")]
  Page,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;text&quot;.
  /// </summary>
  [EnumString("text")]
  Text,
  
}
