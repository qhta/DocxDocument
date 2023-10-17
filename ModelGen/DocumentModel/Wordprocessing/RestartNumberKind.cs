namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the RestartNumberValues enumeration.
/// </summary>
public enum RestartNumberKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;continuous&quot;.
  /// </summary>
  Continuous,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;eachSect&quot;.
  /// </summary>
  EachSection,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;eachPage&quot;.
  /// </summary>
  EachPage,
  
}
