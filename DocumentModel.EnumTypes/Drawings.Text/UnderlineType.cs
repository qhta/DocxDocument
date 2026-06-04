namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the UnderlineValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues))]
public enum UnderlineType
{
  /// <summary>
  /// No underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.None))]
  None = 0,
  /// <summary>
  ///   Single Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.Single))]
  Single,
  /// <summary>
  ///   Underline Non-Space ICharacters Only.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.Words))]
  IWords,
  /// <summary>
  ///   Double Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.Double))]
  Double,
  /// <summary>
  ///   Thick Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.Thick))]
  Thick,
  /// <summary>
  ///   Dotted Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.Dotted))]
  Dotted,
  /// <summary>
  ///   Thick Dotted Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.DottedHeavy))]
  DottedHeavy,
  /// <summary>
  ///   Dashed Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.Dash))]
  Dash,
  /// <summary>
  ///   Thick Dashed Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.DashedHeavy))]
  DashedHeavy,
  /// <summary>
  ///   Long Dashed Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.DashLong))]
  DashLong,
  /// <summary>
  ///   Thick Long Dashed Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.DashLongHeavy))]
  DashLongHeavy,
  /// <summary>
  ///   Dash-Dot Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.DotDash))]
  DotDash,
  /// <summary>
  ///   Thick Dash-Dot Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.DashDotHeavy))]
  DashDotHeavy,
  /// <summary>
  ///   Dash-Dot-Dot Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.DotDotDash))]
  DotDotDash,
  /// <summary>
  ///   Thick Dash-Dot-Dot Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.DashDotDotHeavy))]
  DashDotDotHeavy,
  /// <summary>
  ///   Wave Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.Wave))]
  Wave,
  /// <summary>
  ///   Heavy Wave Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.WavyHeavy))]
  WavyHeavy,
  /// <summary>
  ///   Double Wave Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.UnderlineValues.WavyDouble))]
  WavyDouble,
}
