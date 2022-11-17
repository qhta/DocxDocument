namespace DocumentModel.Office2010.Word;

public enum SchemeColor
{

  [XmlEnum("bg1")]
  BackgroundColor,

  [XmlEnum("tx1")]
  TextColor,

  [XmlEnum("bg2")]
  AdditionalBackgroundColor,

  [XmlEnum("tx2")]
  AdditionalTextColor,

  [XmlEnum("accent1")]
  ExtraSchemeColor1,

  [XmlEnum("accent2")]
  ExtraSchemeColor2,

  [XmlEnum("accent3")]
  ExtraSchemeColor3,

  [XmlEnum("accent4")]
  ExtraSchemeColor4,

  [XmlEnum("accent5")]
  ExtraSchemeColor5,

  [XmlEnum("accent6")]
  ExtraSchemeColor6,

  [XmlEnum("hlink")]
  HyperlinkColor,

  [XmlEnum("folHlink")]
  FollowedHyperlinkColor,

  [XmlEnum("dk1")]
  MainDarkColor1,

  [XmlEnum("lt1")]
  MainLightColor1,

  [XmlEnum("dk2")]
  MainDarkColor2,

  [XmlEnum("lt2")]
  MainLightColor2,

  [XmlEnum("phClr")]
  AutoColor,
}
