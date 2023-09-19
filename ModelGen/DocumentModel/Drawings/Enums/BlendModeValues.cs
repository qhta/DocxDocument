namespace DocumentFormat.OpenXml.Drawings;


/// <summary>
///   Blend Mode
/// </summary>
public enum BlendModeValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;over&quot;.
  /// </summary>
  [EnumString("over")]
  Overlay,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mult&quot;.
  /// </summary>
  [EnumString("mult")]
  Multiply,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;screen&quot;.
  /// </summary>
  [EnumString("screen")]
  Screen,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;darken&quot;.
  /// </summary>
  [EnumString("darken")]
  Darken,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lighten&quot;.
  /// </summary>
  [EnumString("lighten")]
  Lighten,
  
}
