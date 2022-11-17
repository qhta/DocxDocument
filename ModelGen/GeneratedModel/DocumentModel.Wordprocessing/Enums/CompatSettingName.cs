namespace DocumentModel.Wordprocessing;

public enum CompatSettingName
{
  
  [XmlEnum("compatibilityMode")]
  CompatibilityMode,
  
  [XmlEnum("overrideTableStyleFontSizeAndJustification")]
  OverrideTableStyleFontSizeAndJustification,
  
  [XmlEnum("enableOpenTypeFeatures")]
  EnableOpenTypeFeatures,
  
  [XmlEnum("doNotFlipMirrorIndents")]
  DoNotFlipMirrorIndents,
  
  [XmlEnum("differentiateMultirowTableHeaders")]
  DifferentiateMultirowTableHeaders,
  
  [XmlEnum("useWord2013TrackBottomHyphenation")]
  UseWord2013TrackBottomHyphenation,
  
  [XmlEnum("allowHyphenationAtTrackBottom")]
  AllowHyphenationAtTrackBottom,
  
  [XmlEnum("allowTextAfterFloatingTableBreak")]
  AllowTextAfterFloatingTableBreak,
}
