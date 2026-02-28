namespace DocumentModel.Wordprocessing;
/// <summary>
///   Border Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.BorderValues))]
public enum BorderStyle
{
  /// <summary>
  ///   No Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.None))]
  None,
  /// <summary>
  ///   Single Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.Single))]
  Single,
  /// <summary>
  ///   Thick Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.Thick))]
  Thick,
  /// <summary>
  ///   Double Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.Double))]
  Double,
  ///// <summary>
  /////   Hairline Border.
  ///// </summary>
  //[OpenXmlEnumValue(nameof(DXW.BorderValues.Hairline))]
  //Hairline,
  /// <summary>
  ///   Dotted Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.Dotted))]
  Dot,
  /// <summary>
  ///   Specifies a line border consisting of a dashed line around the parent object.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.Dashed))]
  Dash,
  /// <summary>
  ///   Dot Dash Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.DotDash))]
  DotDash,
  /// <summary>
  ///   Dash Dot Dot Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.DotDotDash))]
  DashDotDot,
  /// <summary>
  ///   Triple Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.Triple))]
  Triple,
  /// <summary>
  ///   Thin Thick Small Gap Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.ThinThickSmallGap))]
  ThinThickSmallGap,
  /// <summary>
  ///   Small thick-thin lines border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.ThickThinSmallGap))]
  ThickThinSmallGap,
  /// <summary>
  ///   Small thin-thick-thin Lines Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.ThinThickThinSmallGap))]
  ThinThickThinSmallGap,
  /// <summary>
  ///   Thin Thick Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.ThinThickMediumGap))]
  ThinThickMediumGap,
  /// <summary>
  ///   Thick Thin Line Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.ThickThinMediumGap))]
  ThickThinMediumGap,
  /// <summary>
  ///   Thin-thick-thin Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.ThinThickThinMediumGap))]
  ThinThickThinMediumGap,
  /// <summary>
  ///   Thin Thick Large Gap Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.ThinThickLargeGap))]
  ThinThickLargeGap,
  /// <summary>
  ///   Thick Thin Large Gap Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.ThickThinLargeGap))]
  ThickThinLargeGap,
  /// <summary>
  ///   Large thin-thick-thin Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.ThinThickThinLargeGap))]
  ThinThickThinLargeGap,
  /// <summary>
  ///   Wavy Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.Wave))]
  Wave,
  /// <summary>
  ///   Double Wavy Lines Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.DoubleWave))]
  DoubleWave,
  /// <summary>
  ///   Small Dash Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.DashSmallGap))]
  DashSmallGap,
  /// <summary>
  ///   Stroked Dash Dot Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.DashDotStroked))]
  DashDotStroked,
  /// <summary>
  ///   3D Embossed Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.ThreeDEmboss))]
  ThreeDEmboss,
  /// <summary>
  ///   3D Engraved Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.ThreeDEngrave))]
  ThreeDEngrave,
  /// <summary>
  ///   Outset Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.Outset))]
  Outset,
  /// <summary>
  ///   Inset Border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BorderValues.Inset))]
  Inset
}