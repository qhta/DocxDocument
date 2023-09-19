namespace DocumentFormat.OpenXml.Drawings;


/// <summary>
///   Blip Compression Type
/// </summary>
public enum BlipCompressionValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;email&quot;.
  /// </summary>
  [EnumString("email")]
  Email,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;screen&quot;.
  /// </summary>
  [EnumString("screen")]
  Screen,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;print&quot;.
  /// </summary>
  [EnumString("print")]
  Print,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hqprint&quot;.
  /// </summary>
  [EnumString("hqprint")]
  HighQualityPrint,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
}
