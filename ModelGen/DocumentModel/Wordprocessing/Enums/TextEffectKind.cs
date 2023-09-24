namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TextEffectValues enumeration.
/// </summary>
public enum TextEffectKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;blinkBackground&quot;.
  /// </summary>
  [EnumString("blinkBackground")]
  BlinkBackground,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lights&quot;.
  /// </summary>
  [EnumString("lights")]
  Lights,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;antsBlack&quot;.
  /// </summary>
  [EnumString("antsBlack")]
  AntsBlack,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;antsRed&quot;.
  /// </summary>
  [EnumString("antsRed")]
  AntsRed,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;shimmer&quot;.
  /// </summary>
  [EnumString("shimmer")]
  Shimmer,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sparkle&quot;.
  /// </summary>
  [EnumString("sparkle")]
  Sparkle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
}
