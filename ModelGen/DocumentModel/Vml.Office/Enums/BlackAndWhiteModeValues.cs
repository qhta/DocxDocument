namespace DXVO;


/// <summary>
///   Black And White Modes
/// </summary>
public enum BlackAndWhiteModeValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;color&quot;.
  /// </summary>
  [EnumString("color")]
  Color,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;auto&quot;.
  /// </summary>
  [EnumString("auto")]
  Auto,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;grayScale&quot;.
  /// </summary>
  [EnumString("grayScale")]
  GrayScale,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lightGrayScale&quot;.
  /// </summary>
  [EnumString("lightGrayScale")]
  LightGrayScale,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;inverseGray&quot;.
  /// </summary>
  [EnumString("inverseGray")]
  InverseGray,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;grayOutline&quot;.
  /// </summary>
  [EnumString("grayOutline")]
  GrayOutline,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;highContrast&quot;.
  /// </summary>
  [EnumString("highContrast")]
  HighContrast,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;black&quot;.
  /// </summary>
  [EnumString("black")]
  Black,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;white&quot;.
  /// </summary>
  [EnumString("white")]
  White,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;undrawn&quot;.
  /// </summary>
  [EnumString("undrawn")]
  Undrawn,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;blackTextAndLines&quot;.
  /// </summary>
  [EnumString("blackTextAndLines")]
  BlackTextAndLines,
  
}
