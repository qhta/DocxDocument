namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the DocPartBehaviorValues enumeration.
/// </summary>
public enum DocPartBehaviorKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;content&quot;.
  /// </summary>
  [EnumString("content")]
  Content,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;p&quot;.
  /// </summary>
  [EnumString("p")]
  Paragraph,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pg&quot;.
  /// </summary>
  [EnumString("pg")]
  Page,
  
}
