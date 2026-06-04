namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CompatSettingNameValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues))]
public enum CompatSettingName
{
  /// <summary>
  ///   compatibilityMode.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues.CompatibilityMode))]
  CompatibilityMode,
  /// <summary>
  ///   overrideTableStyleFontSizeAndJustification.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues.OverrideTableStyleFontSizeAndJustification))]
  OverrideTableStyleFontSizeAndJustification,
  /// <summary>
  ///   enableOpenTypeFeatures.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues.EnableOpenTypeFeatures))]
  EnableOpenTypeFeatures,
  /// <summary>
  ///   doNotFlipMirrorIndents.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues.DoNotFlipMirrorIndents))]
  DoNotFlipMirrorIndents,
  /// <summary>
  ///   differentiateMultirowTableHeaders.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues.DifferentiateMultirowTableHeaders))]
  DifferentiateMultirowTableHeaders,
  /// <summary>
  ///   useWord2013TrackBottomHyphenation.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues.UseWord2013TrackBottomHyphenation))]
  UseWord2013TrackBottomHyphenation,
  /// <summary>
  ///   allowHyphenationAtTrackBottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues.AllowHyphenationAtTrackBottom))]
  AllowHyphenationAtTrackBottom,
  /// <summary>
  ///   allowTextAfterFloatingTableBreak.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.CompatSettingNameValues.AllowTextAfterFloatingTableBreak))]
  AllowTextAfterFloatingTableBreak
}