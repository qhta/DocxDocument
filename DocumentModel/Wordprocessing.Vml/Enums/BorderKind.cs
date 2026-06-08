namespace DocumentModel.Wordprocessing.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   IBorder Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BorderKind
{
  /// <summary>
  ///   No IBorder.
  /// </summary>
  None,

  /// <summary>
  ///   Single ILine IBorder.
  /// </summary>
  Single,

  /// <summary>
  ///   Thick ILine IBorder.
  /// </summary>
  Thick,

  /// <summary>
  ///   Double ILine IBorder.
  /// </summary>
  Double,

  /// <summary>
  ///   Hairline IBorder.
  /// </summary>
  Hairline,

  /// <summary>
  ///   Dotted IBorder.
  /// </summary>
  Dot,

  /// <summary>
  ///   pecifies a line border consisting of a dashed line around the parent object..
  /// </summary>
  Dash,

  /// <summary>
  ///   Dot Dash IBorder.
  /// </summary>
  DotDash,

  /// <summary>
  ///   Dash Dot Dot IBorder.
  /// </summary>
  DashDotDot,

  /// <summary>
  ///   Triple ILine IBorder.
  /// </summary>
  Triple,

  /// <summary>
  ///   Thin Thick Small Gap IBorder.
  /// </summary>
  ThinThickSmall,

  /// <summary>
  ///   Small thick-thin lines border.
  /// </summary>
  ThickThinSmall,

  /// <summary>
  ///   Small thin-thick-thin ILines IBorder.
  /// </summary>
  ThickBetweenThinSmall,

  /// <summary>
  ///   Thin Thick ILine IBorder.
  /// </summary>
  ThinThick,

  /// <summary>
  ///   Thick Thin ILine IBorder.
  /// </summary>
  ThickThin,

  /// <summary>
  ///   Thin-thick-thin IBorder.
  /// </summary>
  ThickBetweenThin,

  /// <summary>
  ///   Thin Thick Large Gap IBorder.
  /// </summary>
  ThinThickLarge,

  /// <summary>
  ///   Thick Thin Large Gap IBorder.
  /// </summary>
  ThickThinLarge,

  /// <summary>
  ///   Large thin-thick-thin IBorder.
  /// </summary>
  ThickBetweenThinLarge,

  /// <summary>
  ///   Wavy IBorder.
  /// </summary>
  Wave,

  /// <summary>
  ///   Double Wavy ILines IBorder.
  /// </summary>
  DoubleWave,

  /// <summary>
  ///   Small Dash IBorder.
  /// </summary>
  DashedSmall,

  /// <summary>
  ///   Stroked Dash Dot IBorder.
  /// </summary>
  DashDotStroked,

  /// <summary>
  ///   3D Embossed IBorder.
  /// </summary>
  ThreeDEmboss,

  /// <summary>
  ///   3D Engraved IBorder.
  /// </summary>
  ThreeDEngrave,

  /// <summary>
  ///   Outset IBorder.
  /// </summary>
  HTMLOutset,

  /// <summary>
  ///   Inset IBorder.
  /// </summary>
  HTMLInset
}
