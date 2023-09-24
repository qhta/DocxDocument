namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the DisplacedByCustomXmlValues enumeration.
/// </summary>
public enum DisplacedByCustomXmlKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;next&quot;.
  /// </summary>
  [EnumString("next")]
  Next,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;prev&quot;.
  /// </summary>
  [EnumString("prev")]
  Previous,
  
}
