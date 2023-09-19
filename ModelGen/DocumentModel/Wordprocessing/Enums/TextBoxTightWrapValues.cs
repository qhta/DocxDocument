namespace DXW;


/// <summary>
///   Defines the TextBoxTightWrapValues enumeration.
/// </summary>
public enum TextBoxTightWrapValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;allLines&quot;.
  /// </summary>
  [EnumString("allLines")]
  AllLines,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;firstAndLastLine&quot;.
  /// </summary>
  [EnumString("firstAndLastLine")]
  FirstAndLastLine,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;firstLineOnly&quot;.
  /// </summary>
  [EnumString("firstLineOnly")]
  FirstLineOnly,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lastLineOnly&quot;.
  /// </summary>
  [EnumString("lastLineOnly")]
  LastLineOnly,
  
}
