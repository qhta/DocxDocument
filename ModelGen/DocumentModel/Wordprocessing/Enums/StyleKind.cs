namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the StyleValues enumeration.
/// </summary>
public enum StyleKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;paragraph&quot;.
  /// </summary>
  Paragraph,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;character&quot;.
  /// </summary>
  Character,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;table&quot;.
  /// </summary>
  Table,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;numbering&quot;.
  /// </summary>
  Numbering,
  
}
