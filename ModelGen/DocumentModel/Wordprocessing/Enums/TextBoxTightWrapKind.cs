namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TextBoxTightWrapValues enumeration.
/// </summary>
public enum TextBoxTightWrapKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;allLines&quot;.
  /// </summary>
  AllLines,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;firstAndLastLine&quot;.
  /// </summary>
  FirstAndLastLine,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;firstLineOnly&quot;.
  /// </summary>
  FirstLineOnly,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lastLineOnly&quot;.
  /// </summary>
  LastLineOnly,
  
}
