namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
///   Border Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BorderKind
{
  /// <summary>
  ///   No Border.
  /// </summary>
  None,
  /// <summary>
  ///   Single Line Border.
  /// </summary>
  Single,
  /// <summary>
  ///   Thick Line Border.
  /// </summary>
  Thick,
  /// <summary>
  ///   Double Line Border.
  /// </summary>
  Double,
  /// <summary>
  ///   Hairline Border.
  /// </summary>
  Hairline,
  /// <summary>
  ///   Dotted Border.
  /// </summary>
  Dot,
  /// <summary>
  ///   pecifies a line border consisting of a dashed line around the parent object..
  /// </summary>
  Dash,
  /// <summary>
  ///   Dot Dash Border.
  /// </summary>
  DotDash,
  /// <summary>
  ///   Dash Dot Dot Border.
  /// </summary>
  DashDotDot,
  /// <summary>
  ///   Triple Line Border.
  /// </summary>
  Triple,
  /// <summary>
  ///   Thin Thick Small Gap Border.
  /// </summary>
  ThinThickSmall,
  /// <summary>
  ///   Small thick-thin lines border.
  /// </summary>
  ThickThinSmall,
  /// <summary>
  ///   Small thin-thick-thin Lines Border.
  /// </summary>
  ThickBetweenThinSmall,
  /// <summary>
  ///   Thin Thick Line Border.
  /// </summary>
  ThinThick,
  /// <summary>
  ///   Thick Thin Line Border.
  /// </summary>
  ThickThin,
  /// <summary>
  ///   Thin-thick-thin Border.
  /// </summary>
  ThickBetweenThin,
  /// <summary>
  ///   Thin Thick Large Gap Border.
  /// </summary>
  ThinThickLarge,
  /// <summary>
  ///   Thick Thin Large Gap Border.
  /// </summary>
  ThickThinLarge,
  /// <summary>
  ///   Large thin-thick-thin Border.
  /// </summary>
  ThickBetweenThinLarge,
  /// <summary>
  ///   Wavy Border.
  /// </summary>
  Wave,
  /// <summary>
  ///   Double Wavy Lines Border.
  /// </summary>
  DoubleWave,
  /// <summary>
  ///   Small Dash Border.
  /// </summary>
  DashedSmall,
  /// <summary>
  ///   Stroked Dash Dot Border.
  /// </summary>
  DashDotStroked,
  /// <summary>
  ///   3D Embossed Border.
  /// </summary>
  ThreeDEmboss,
  /// <summary>
  ///   3D Engraved Border.
  /// </summary>
  ThreeDEngrave,
  /// <summary>
  ///   Outset Border.
  /// </summary>
  HTMLOutset,
  /// <summary>
  ///   Inset Border.
  /// </summary>
  HTMLInset
}