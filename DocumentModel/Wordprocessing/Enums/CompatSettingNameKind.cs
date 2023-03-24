namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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