namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SectionMarkValues enumeration.
/// </summary>
public enum SectionMarkKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;nextPage&quot;.
  /// </summary>
  NextPage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;nextColumn&quot;.
  /// </summary>
  NextColumn,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;continuous&quot;.
  /// </summary>
  Continuous,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;evenPage&quot;.
  /// </summary>
  EvenPage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;oddPage&quot;.
  /// </summary>
  OddPage,
  
}
