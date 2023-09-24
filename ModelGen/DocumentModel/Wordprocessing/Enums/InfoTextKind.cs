namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the InfoTextValues enumeration.
/// </summary>
public enum InfoTextKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;text&quot;.
  /// </summary>
  [EnumString("text")]
  Text,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;autoText&quot;.
  /// </summary>
  [EnumString("autoText")]
  AutoText,
  
}
