namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CompatSettingNameValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum CompatSettingNameKind
{
  /// <summary>
  ///   compatibilityMode.
  /// </summary>
  CompatibilityMode,

  /// <summary>
  ///   overrideTableStyleFontSizeAndJustification.
  /// </summary>
  OverrideTableStyleFontSizeAndJustification,

  /// <summary>
  ///   enableOpenTypeFeatures.
  /// </summary>
  EnableOpenTypeFeatures,

  /// <summary>
  ///   doNotFlipMirrorIndents.
  /// </summary>
  DoNotFlipMirrorIndents,

  /// <summary>
  ///   differentiateMultirowTableHeaders.
  /// </summary>
  DifferentiateMultirowTableHeaders,

  /// <summary>
  ///   useWord2013TrackBottomHyphenation.
  /// </summary>
  UseWord2013TrackBottomHyphenation,

  /// <summary>
  ///   allowHyphenationAtTrackBottom.
  /// </summary>
  AllowHyphenationAtTrackBottom,

  /// <summary>
  ///   allowTextAfterFloatingTableBreak.
  /// </summary>
  AllowTextAfterFloatingTableBreak
}