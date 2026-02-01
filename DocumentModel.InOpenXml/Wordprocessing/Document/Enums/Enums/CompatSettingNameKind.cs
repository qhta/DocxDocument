namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CompatSettingNameValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.CompatSettingNameValues))]
public enum CompatSettingNameKind
{
  /// <summary>
  ///   compatibilityMode.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CompatSettingNameValues.CompatibilityMode))]
  CompatibilityMode,
  /// <summary>
  ///   overrideTableStyleFontSizeAndJustification.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CompatSettingNameValues.OverrideTableStyleFontSizeAndJustification))]
  OverrideTableStyleFontSizeAndJustification,
  /// <summary>
  ///   enableOpenTypeFeatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CompatSettingNameValues.EnableOpenTypeFeatures))]
  EnableOpenTypeFeatures,
  /// <summary>
  ///   doNotFlipMirrorIndents.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CompatSettingNameValues.DoNotFlipMirrorIndents))]
  DoNotFlipMirrorIndents,
  /// <summary>
  ///   differentiateMultirowTableHeaders.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CompatSettingNameValues.DifferentiateMultirowTableHeaders))]
  DifferentiateMultirowTableHeaders,
  /// <summary>
  ///   useWord2013TrackBottomHyphenation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CompatSettingNameValues.UseWord2013TrackBottomHyphenation))]
  UseWord2013TrackBottomHyphenation,
  /// <summary>
  ///   allowHyphenationAtTrackBottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CompatSettingNameValues.AllowHyphenationAtTrackBottom))]
  AllowHyphenationAtTrackBottom,
  /// <summary>
  ///   allowTextAfterFloatingTableBreak.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CompatSettingNameValues.AllowTextAfterFloatingTableBreak))]
  AllowTextAfterFloatingTableBreak
}