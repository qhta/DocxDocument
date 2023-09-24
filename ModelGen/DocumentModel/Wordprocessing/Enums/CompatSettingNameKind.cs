namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CompatSettingNameValues enumeration.
/// </summary>
public enum CompatSettingNameKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;compatibilityMode&quot;.
  /// </summary>
  [EnumString("compatibilityMode")]
  CompatibilityMode,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;overrideTableStyleFontSizeAndJustification&quot;.
  /// </summary>
  [EnumString("overrideTableStyleFontSizeAndJustification")]
  OverrideTableStyleFontSizeAndJustification,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;enableOpenTypeFeatures&quot;.
  /// </summary>
  [EnumString("enableOpenTypeFeatures")]
  EnableOpenTypeFeatures,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;doNotFlipMirrorIndents&quot;.
  /// </summary>
  [EnumString("doNotFlipMirrorIndents")]
  DoNotFlipMirrorIndents,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;differentiateMultirowTableHeaders&quot;.
  /// </summary>
  [EnumString("differentiateMultirowTableHeaders")]
  DifferentiateMultirowTableHeaders,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;useWord2013TrackBottomHyphenation&quot;. This item is only available in Office 2016 and later.
  /// </summary>
  [EnumString("useWord2013TrackBottomHyphenation")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  UseWord2013TrackBottomHyphenation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;allowHyphenationAtTrackBottom&quot;. This item is only available in Office 2016 and later.
  /// </summary>
  [EnumString("allowHyphenationAtTrackBottom")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  AllowHyphenationAtTrackBottom,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;allowTextAfterFloatingTableBreak&quot;. This item is only available in Office 2013 and later.
  /// </summary>
  [EnumString("allowTextAfterFloatingTableBreak")]
  [OfficeAvailability((DocumentFormat.OpenXml.FileFormatVersions)1)]
  AllowTextAfterFloatingTableBreak,
  
}
