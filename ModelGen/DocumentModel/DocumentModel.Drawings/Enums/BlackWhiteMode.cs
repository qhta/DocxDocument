namespace DocumentModel.Drawings;

/// <summary>
/// Black and White Mode
/// </summary>
public enum BlackWhiteMode
{
  /// <summary>
  /// Color.
  /// </summary>
  [XmlEnum("clr")]
  Color,
  
  /// <summary>
  /// Automatic.
  /// </summary>
  [XmlEnum("auto")]
  Auto,
  
  /// <summary>
  /// Gray.
  /// </summary>
  [XmlEnum("gray")]
  Gray,
  
  /// <summary>
  /// Light Gray.
  /// </summary>
  [XmlEnum("ltGray")]
  LightGray,
  
  /// <summary>
  /// Inverse Gray.
  /// </summary>
  [XmlEnum("invGray")]
  InvGray,
  
  /// <summary>
  /// Gray and White.
  /// </summary>
  [XmlEnum("grayWhite")]
  GrayWhite,
  
  /// <summary>
  /// Black and Gray.
  /// </summary>
  [XmlEnum("blackGray")]
  BlackGray,
  
  /// <summary>
  /// Black and White.
  /// </summary>
  [XmlEnum("blackWhite")]
  BlackWhite,
  
  /// <summary>
  /// Black.
  /// </summary>
  [XmlEnum("black")]
  Black,
  
  /// <summary>
  /// White.
  /// </summary>
  [XmlEnum("white")]
  White,
  
  /// <summary>
  /// Hidden.
  /// </summary>
  [XmlEnum("hidden")]
  Hidden,
  
}
