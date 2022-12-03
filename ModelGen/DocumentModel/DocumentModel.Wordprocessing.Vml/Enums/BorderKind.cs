namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
/// Border Type
/// </summary>
public enum BorderKind
{
  /// <summary>
  /// No Border.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Single Line Border.
  /// </summary>
  [XmlEnum("single")]
  Single,
  
  /// <summary>
  /// Thick Line Border.
  /// </summary>
  [XmlEnum("thick")]
  Thick,
  
  /// <summary>
  /// Double Line Border.
  /// </summary>
  [XmlEnum("double")]
  Double,
  
  /// <summary>
  /// Hairline Border.
  /// </summary>
  [XmlEnum("hairline")]
  Hairline,
  
  /// <summary>
  /// Dotted Border.
  /// </summary>
  [XmlEnum("dot")]
  Dot,
  
  /// <summary>
  /// Specifies a line border consisting of a dashed line around the parent object..
  /// </summary>
  [XmlEnum("dash")]
  Dash,
  
  /// <summary>
  /// Dot Dash Border.
  /// </summary>
  [XmlEnum("dotDash")]
  DotDash,
  
  /// <summary>
  /// Dash Dot Dot Border.
  /// </summary>
  [XmlEnum("dashDotDot")]
  DashDotDot,
  
  /// <summary>
  /// Triple Line Border.
  /// </summary>
  [XmlEnum("triple")]
  Triple,
  
  /// <summary>
  /// Thin Thick Small Gap Border.
  /// </summary>
  [XmlEnum("thinThickSmall")]
  ThinThickSmall,
  
  /// <summary>
  /// Small thick-thin lines border.
  /// </summary>
  [XmlEnum("thickThinSmall")]
  ThickThinSmall,
  
  /// <summary>
  /// Small thin-thick-thin Lines Border.
  /// </summary>
  [XmlEnum("thickBetweenThinSmall")]
  ThickBetweenThinSmall,
  
  /// <summary>
  /// Thin Thick Line Border.
  /// </summary>
  [XmlEnum("thinThick")]
  ThinThick,
  
  /// <summary>
  /// Thick Thin Line Border.
  /// </summary>
  [XmlEnum("thickThin")]
  ThickThin,
  
  /// <summary>
  /// Thin-thick-thin Border.
  /// </summary>
  [XmlEnum("thickBetweenThin")]
  ThickBetweenThin,
  
  /// <summary>
  /// Thin Thick Large Gap Border.
  /// </summary>
  [XmlEnum("thinThickLarge")]
  ThinThickLarge,
  
  /// <summary>
  /// Thick Thin Large Gap Border.
  /// </summary>
  [XmlEnum("thickThinLarge")]
  ThickThinLarge,
  
  /// <summary>
  /// Large thin-thick-thin Border.
  /// </summary>
  [XmlEnum("thickBetweenThinLarge")]
  ThickBetweenThinLarge,
  
  /// <summary>
  /// Wavy Border.
  /// </summary>
  [XmlEnum("wave")]
  Wave,
  
  /// <summary>
  /// Double Wavy Lines Border.
  /// </summary>
  [XmlEnum("doubleWave")]
  DoubleWave,
  
  /// <summary>
  /// Small Dash Border.
  /// </summary>
  [XmlEnum("dashedSmall")]
  DashedSmall,
  
  /// <summary>
  /// Stroked Dash Dot Border.
  /// </summary>
  [XmlEnum("dashDotStroked")]
  DashDotStroked,
  
  /// <summary>
  /// 3D Embossed Border.
  /// </summary>
  [XmlEnum("threeDEmboss")]
  ThreeDEmboss,
  
  /// <summary>
  /// 3D Engraved Border.
  /// </summary>
  [XmlEnum("threeDEngrave")]
  ThreeDEngrave,
  
  /// <summary>
  /// Outset Border.
  /// </summary>
  [XmlEnum("HTMLOutset")]
  HTMLOutset,
  
  /// <summary>
  /// Inset Border.
  /// </summary>
  [XmlEnum("HTMLInset")]
  HTMLInset,
  
}
