namespace DocumentModel.Vml.Office;


/// <summary>
///   Connection Locations Type
/// </summary>
public enum ConnectKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rect&quot;.
  /// </summary>
  [EnumString("rect")]
  Rectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;segments&quot;.
  /// </summary>
  [EnumString("segments")]
  Segments,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custom&quot;.
  /// </summary>
  [EnumString("custom")]
  Custom,
  
}
