namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the SchemeColorValues enumeration.
/// </summary>
public enum SchemeColorValues
{
  /// <summary>
  /// bg1.
  /// </summary>
  [XmlEnum("bg1")]
  BackgroundColor,
  
  /// <summary>
  /// tx1.
  /// </summary>
  [XmlEnum("tx1")]
  TextColor,
  
  /// <summary>
  /// bg2.
  /// </summary>
  [XmlEnum("bg2")]
  AdditionalBackgroundColor,
  
  /// <summary>
  /// tx2.
  /// </summary>
  [XmlEnum("tx2")]
  AdditionalTextColor,
  
  /// <summary>
  /// accent1.
  /// </summary>
  [XmlEnum("accent1")]
  ExtraSchemeColor1,
  
  /// <summary>
  /// accent2.
  /// </summary>
  [XmlEnum("accent2")]
  ExtraSchemeColor2,
  
  /// <summary>
  /// accent3.
  /// </summary>
  [XmlEnum("accent3")]
  ExtraSchemeColor3,
  
  /// <summary>
  /// accent4.
  /// </summary>
  [XmlEnum("accent4")]
  ExtraSchemeColor4,
  
  /// <summary>
  /// accent5.
  /// </summary>
  [XmlEnum("accent5")]
  ExtraSchemeColor5,
  
  /// <summary>
  /// accent6.
  /// </summary>
  [XmlEnum("accent6")]
  ExtraSchemeColor6,
  
  /// <summary>
  /// hlink.
  /// </summary>
  [XmlEnum("hlink")]
  HyperlinkColor,
  
  /// <summary>
  /// folHlink.
  /// </summary>
  [XmlEnum("folHlink")]
  FollowedHyperlinkColor,
  
  /// <summary>
  /// dk1.
  /// </summary>
  [XmlEnum("dk1")]
  MainDarkColor1,
  
  /// <summary>
  /// lt1.
  /// </summary>
  [XmlEnum("lt1")]
  MainLightColor1,
  
  /// <summary>
  /// dk2.
  /// </summary>
  [XmlEnum("dk2")]
  MainDarkColor2,
  
  /// <summary>
  /// lt2.
  /// </summary>
  [XmlEnum("lt2")]
  MainLightColor2,
  
  /// <summary>
  /// phClr.
  /// </summary>
  [XmlEnum("phClr")]
  AutoColor,
  
}
