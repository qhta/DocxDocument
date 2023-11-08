namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CompatSettingNameValues enumeration.
/// </summary>
public enum CompatSettingNameKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;compatibilityMode&quot;.
  /// </summary>
  CompatibilityMode,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;overrideTableStyleFontSizeAndJustification&quot;.
  /// </summary>
  OverrideTableStyleFontSizeAndJustification,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;enableOpenTypeFeatures&quot;.
  /// </summary>
  EnableOpenTypeFeatures,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;doNotFlipMirrorIndents&quot;.
  /// </summary>
  DoNotFlipMirrorIndents,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;differentiateMultirowTableHeaders&quot;.
  /// </summary>
  DifferentiateMultirowTableHeaders,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;useWord2013TrackBottomHyphenation&quot;. This item is only available in Office 2016 and later.
  /// </summary>
  UseWord2013TrackBottomHyphenation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;allowHyphenationAtTrackBottom&quot;. This item is only available in Office 2016 and later.
  /// </summary>
  AllowHyphenationAtTrackBottom,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;allowTextAfterFloatingTableBreak&quot;. This item is only available in Office 2013 and later.
  /// </summary>
  AllowTextAfterFloatingTableBreak,
  
}
