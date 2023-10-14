namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the DocPartBehaviorValues enumeration.
/// </summary>
public enum DocPartBehaviorKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;content&quot;.
  /// </summary>
  Content,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;p&quot;.
  /// </summary>
  Paragraph,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pg&quot;.
  /// </summary>
  Page,
  
}
