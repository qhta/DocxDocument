namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CompatSettingNameValues enumeration.
/// </summary>
public enum CompatSettingNameValues
{
  /// <summary>
  /// compatibilityMode.
  /// </summary>
  [XmlEnum("compatibilityMode")]
  CompatibilityMode,
  
  /// <summary>
  /// overrideTableStyleFontSizeAndJustification.
  /// </summary>
  [XmlEnum("overrideTableStyleFontSizeAndJustification")]
  OverrideTableStyleFontSizeAndJustification,
  
  /// <summary>
  /// enableOpenTypeFeatures.
  /// </summary>
  [XmlEnum("enableOpenTypeFeatures")]
  EnableOpenTypeFeatures,
  
  /// <summary>
  /// doNotFlipMirrorIndents.
  /// </summary>
  [XmlEnum("doNotFlipMirrorIndents")]
  DoNotFlipMirrorIndents,
  
  /// <summary>
  /// differentiateMultirowTableHeaders.
  /// </summary>
  [XmlEnum("differentiateMultirowTableHeaders")]
  DifferentiateMultirowTableHeaders,
  
  /// <summary>
  /// useWord2013TrackBottomHyphenation.
  /// </summary>
  [XmlEnum("useWord2013TrackBottomHyphenation")]
  UseWord2013TrackBottomHyphenation,
  
  /// <summary>
  /// allowHyphenationAtTrackBottom.
  /// </summary>
  [XmlEnum("allowHyphenationAtTrackBottom")]
  AllowHyphenationAtTrackBottom,
  
  /// <summary>
  /// allowTextAfterFloatingTableBreak.
  /// </summary>
  [XmlEnum("allowTextAfterFloatingTableBreak")]
  AllowTextAfterFloatingTableBreak,
  
}
