namespace DocumentModel.Drawings;


/// <summary>
///   Black and White Mode
/// </summary>
public enum BlackWhiteMode
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;clr&quot;.
  /// </summary>
  [EnumString("clr")]
  Color,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;auto&quot;.
  /// </summary>
  [EnumString("auto")]
  Auto,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gray&quot;.
  /// </summary>
  [EnumString("gray")]
  Gray,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ltGray&quot;.
  /// </summary>
  [EnumString("ltGray")]
  LightGray,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;invGray&quot;.
  /// </summary>
  [EnumString("invGray")]
  InvGray,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;grayWhite&quot;.
  /// </summary>
  [EnumString("grayWhite")]
  GrayWhite,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;blackGray&quot;.
  /// </summary>
  [EnumString("blackGray")]
  BlackGray,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;blackWhite&quot;.
  /// </summary>
  [EnumString("blackWhite")]
  BlackWhite,
  
  
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
  ///   When the item is serialized out as xml, its value is &quot;hidden&quot;.
  /// </summary>
  [EnumString("hidden")]
  Hidden,
  
}
