namespace DocumentModel.Wordprocessing;
/// <summary>
///   Border Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVW.BorderValues))]
public enum BorderStyle
{
  /// <summary>
  ///   No Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.None))]
  None,
  /// <summary>
  ///   Single Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.Single))]
  Single,
  /// <summary>
  ///   Thick Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.Thick))]
  Thick,
  /// <summary>
  ///   Double Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.Double))]
  Double,
  /// <summary>
  ///   Hairline Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.Hairline))]
  Hairline,
  /// <summary>
  ///   Dotted Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.Dot))]
  Dot,
  /// <summary>
  ///   Specifies a line border consisting of a dashed line around the parent object.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.Dash))]
  Dash,
  /// <summary>
  ///   Dot Dash Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.DotDash))]
  DotDash,
  /// <summary>
  ///   Dash Dot Dot Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.DashDotDot))]
  DashDotDot,
  /// <summary>
  ///   Triple Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.Triple))]
  Triple,
  /// <summary>
  ///   Thin Thick Small Gap Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.ThinThickSmall))]
  ThinThickSmall,
  /// <summary>
  ///   Small thick-thin lines border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.ThickThinSmall))]
  ThickThinSmall,
  /// <summary>
  ///   Small thin-thick-thin Lines Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.ThickBetweenThinSmall))]
  ThickBetweenThinSmall,
  /// <summary>
  ///   Thin Thick Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.ThinThick))]
  ThinThick,
  /// <summary>
  ///   Thick Thin Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.ThickThin))]
  ThickThin,
  /// <summary>
  ///   Thin-thick-thin Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.ThickBetweenThin))]
  ThickBetweenThin,
  /// <summary>
  ///   Thin Thick Large Gap Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.ThinThickLarge))]
  ThinThickLarge,
  /// <summary>
  ///   Thick Thin Large Gap Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.ThickThinLarge))]
  ThickThinLarge,
  /// <summary>
  ///   Large thin-thick-thin Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.ThickBetweenThinLarge))]
  ThickBetweenThinLarge,
  /// <summary>
  ///   Wavy Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.Wave))]
  Wave,
  /// <summary>
  ///   Double Wavy Lines Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.DoubleWave))]
  DoubleWave,
  /// <summary>
  ///   Small Dash Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.DashedSmall))]
  DashedSmall,
  /// <summary>
  ///   Stroked Dash Dot Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.DashDotStroked))]
  DashDotStroked,
  /// <summary>
  ///   3D Embossed Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.ThreeDEmboss))]
  ThreeDEmboss,
  /// <summary>
  ///   3D Engraved Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.ThreeDEngrave))]
  ThreeDEngrave,
  /// <summary>
  ///   Outset Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.HTMLOutset))]
  HTMLOutset,
  /// <summary>
  ///   Inset Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVW.BorderValues.HTMLInset))]
  HTMLInset
}