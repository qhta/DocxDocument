namespace DocumentFormat.OpenXml.Drawings;


/// <summary>
///   Defines the ClassificationOutcomeType enumeration.
/// </summary>
public enum ClassificationOutcomeType
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hdr&quot;.
  /// </summary>
  [EnumString("hdr")]
  Hdr,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ftr&quot;.
  /// </summary>
  [EnumString("ftr")]
  Ftr,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;watermark&quot;.
  /// </summary>
  [EnumString("watermark")]
  Watermark,
  
}
