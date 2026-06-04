namespace DocumentModel.Wordprocessing;
/// <summary>
///   Border Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.BorderValues))]
public enum BorderType
{
  /// <summary>
  ///   No Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.None))]
  None,
  /// <summary>
  ///   Single Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Single))]
  Single,
  /// <summary>
  ///   Thick Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Thick))]
  Thick,
  /// <summary>
  ///   Double Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Double))]
  Double,
  /// <summary>
  ///   Hairline Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Nil))]
  Hairline,
  /// <summary>
  ///   Dotted Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Dotted))]
  Dotted,
  /// <summary>
  ///   Specifies a line border consisting of a dashed line around the parent object.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Dashed))]
  Dashed,
  /// <summary>
  ///   Dot Dash Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.DotDash))]
  DotDash,
  /// <summary>
  ///   Dash Dot Dot Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.DotDotDash))]
  DotDotDash,
  /// <summary>
  ///   Triple Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Triple))]
  Triple,
  /// <summary>
  ///   Thin Thick Small Gap Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickSmallGap))]
  ThinThickSmallGap,
  /// <summary>
  ///   Small thick-thin lines border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThickThinSmallGap))]
  ThickThinSmallGap,
  /// <summary>
  ///   Small thin-thick-thin Lines Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickThinSmallGap))]
  ThinThickThinSmallGap,
  /// <summary>
  ///   Thin Thick Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickMediumGap))]
  ThinThickMediumGap,
  /// <summary>
  ///   Thick Thin Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThickThinMediumGap))]
  ThickThinMediumGap,
  /// <summary>
  ///   Thin-thick-thin Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickThinMediumGap))]
  ThinThickThinMediumGap,
  /// <summary>
  ///   Thin Thick Large Gap Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickLargeGap))]
  ThinThickLargeGap,
  /// <summary>
  ///   Thick Thin Large Gap Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThickThinLargeGap))]
  ThickThinLargeGap,
  /// <summary>
  ///   Large thin-thick-thin Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickThinLargeGap))]
  ThinThickThinLargeGap,
  /// <summary>
  ///   Wavy Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Wave))]
  Wave,
  /// <summary>
  ///   Double Wavy Lines Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.DoubleWave))]
  DoubleWave,
  /// <summary>
  ///   Small Dash Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.DashSmallGap))]
  DashSmallGap,
  /// <summary>
  ///   Stroked Dash Dot Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.DashDotStroked))]
  DashDotStroked,
  /// <summary>
  ///   3D Embossed Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThreeDEmboss))]
  ThreeDEmboss,
  /// <summary>
  ///   3D Engraved Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThreeDEngrave))]
  ThreeDEngrave,
  /// <summary>
  ///   Outset Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Outset))]
  Outset,
  /// <summary>
  ///   Inset Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Inset))]
  Inset,
}