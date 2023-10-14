namespace DocumentModel.Drawings;


/// <summary>
///   Blip Compression Type
/// </summary>
public enum BlipCompressionKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;email&quot;.
  /// </summary>
  Email,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;screen&quot;.
  /// </summary>
  Screen,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;print&quot;.
  /// </summary>
  Print,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hqprint&quot;.
  /// </summary>
  HighQualityPrint,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  None,
  
}
