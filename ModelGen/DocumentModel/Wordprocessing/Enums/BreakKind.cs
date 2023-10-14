namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the BreakValues enumeration.
/// </summary>
public enum BreakKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;page&quot;.
  /// </summary>
  Page,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;column&quot;.
  /// </summary>
  Column,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;textWrapping&quot;.
  /// </summary>
  TextWrapping,
  
}
