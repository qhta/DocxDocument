namespace DocumentModel.Vml;
/// <summary>
///   Border Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues))]
public enum BorderType
{
  /// <summary>
  ///   No Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.None))]
  None,
  /// <summary>
  ///   Single Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.Single))]
  Single,
  /// <summary>
  ///   Thick Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.Thick))]
  Thick,
  /// <summary>
  ///   Double Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.Double))]
  Double,
  /// <summary>
  ///   Hairline Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.Hairline))]
  Hairline,
  /// <summary>
  ///   Dotted Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.Dot))]
  Dot,
  /// <summary>
  ///   Specifies a line border consisting of a dashed line around the parent object.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.Dash))]
  Dash,
  /// <summary>
  ///   Dot Dash Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.DotDash))]
  DotDash,
  /// <summary>
  ///   Dash Dot Dot Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.DashDotDot))]
  DashDotDot,
  /// <summary>
  ///   Triple Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.Triple))]
  Triple,
  /// <summary>
  ///   Thin Thick Small Gap Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.ThinThickSmall))]
  ThinThickSmall,
  /// <summary>
  ///   Small thick-thin lines border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.ThickThinSmall))]
  ThickThinSmall,
  /// <summary>
  ///   Small thin-thick-thin Lines Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.ThickBetweenThinSmall))]
  ThickBetweenThinSmall,
  /// <summary>
  ///   Thin Thick Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.ThinThick))]
  ThinThick,
  /// <summary>
  ///   Thick Thin Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.ThickThin))]
  ThickThin,
  /// <summary>
  ///   Thin-thick-thin Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.ThickBetweenThin))]
  ThickBetweenThin,
  /// <summary>
  ///   Thin Thick Large Gap Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.ThinThickLarge))]
  ThinThickLarge,
  /// <summary>
  ///   Thick Thin Large Gap Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.ThickThinLarge))]
  ThickThinLarge,
  /// <summary>
  ///   Large thin-thick-thin Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.ThickBetweenThinLarge))]
  ThickBetweenThinLarge,
  /// <summary>
  ///   Wavy Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.Wave))]
  Wave,
  /// <summary>
  ///   Double Wavy Lines Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.DoubleWave))]
  DoubleWave,
  /// <summary>
  ///   Small Dash Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.DashedSmall))]
  DashedSmall,
  /// <summary>
  ///   Stroked Dash Dot Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.DashDotStroked))]
  DashDotStroked,
  /// <summary>
  ///   3D Embossed Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.ThreeDEmboss))]
  ThreeDEmboss,
  /// <summary>
  ///   3D Engraved Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.ThreeDEngrave))]
  ThreeDEngrave,
  /// <summary>
  ///   Outset Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.HTMLOutset))]
  Outset,
  /// <summary>
  ///   Inset Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues.HTMLInset))]
  Inset
}