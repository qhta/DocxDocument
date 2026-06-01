namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Preset Text IShape Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextShapeKind
{
  /// <summary>
  ///   No Text IShape.
  /// </summary>
  TextNoShape,

  /// <summary>
  ///   Plain Text IShape.
  /// </summary>
  TextPlain,

  /// <summary>
  ///   Stop Sign Text IShape.
  /// </summary>
  TextStop,

  /// <summary>
  ///   Triangle Text IShape.
  /// </summary>
  TextTriangle,

  /// <summary>
  ///   Inverted Triangle Text IShape.
  /// </summary>
  TextTriangleInverted,

  /// <summary>
  ///   Chevron Text IShape.
  /// </summary>
  TextChevron,

  /// <summary>
  ///   Inverted Chevron Text IShape.
  /// </summary>
  TextChevronInverted,

  /// <summary>
  ///   Inside Ring Text IShape.
  /// </summary>
  TextRingInside,

  /// <summary>
  ///   Outside Ring Text IShape.
  /// </summary>
  TextRingOutside,

  /// <summary>
  ///   Upward Arch Text IShape.
  /// </summary>
  TextArchUp,

  /// <summary>
  ///   Downward Arch Text IShape.
  /// </summary>
  TextArchDown,

  /// <summary>
  ///   Circle Text IShape.
  /// </summary>
  TextCircle,

  /// <summary>
  ///   Button Text IShape.
  /// </summary>
  TextButton,

  /// <summary>
  ///   Upward Pour Arch Text IShape.
  /// </summary>
  TextArchUpPour,

  /// <summary>
  ///   Downward Pour Arch Text IShape.
  /// </summary>
  TextArchDownPour,

  /// <summary>
  ///   Circle Pour Text IShape.
  /// </summary>
  TextCirclePour,

  /// <summary>
  ///   Button Pour Text IShape.
  /// </summary>
  TextButtonPour,

  /// <summary>
  ///   Upward Curve Text IShape.
  /// </summary>
  TextCurveUp,

  /// <summary>
  ///   Downward Curve Text IShape.
  /// </summary>
  TextCurveDown,

  /// <summary>
  ///   Upward Can Text IShape.
  /// </summary>
  TextCanUp,

  /// <summary>
  ///   Downward Can Text IShape.
  /// </summary>
  TextCanDown,

  /// <summary>
  ///   Wave 1 Text IShape.
  /// </summary>
  TextWave1,

  /// <summary>
  ///   Wave 2 Text IShape.
  /// </summary>
  TextWave2,

  /// <summary>
  ///   Double Wave 1 Text IShape.
  /// </summary>
  TextDoubleWave1,

  /// <summary>
  ///   Wave 4 Text IShape.
  /// </summary>
  TextWave4,

  /// <summary>
  ///   Inflate Text IShape.
  /// </summary>
  TextInflate,

  /// <summary>
  ///   Deflate Text IShape.
  /// </summary>
  TextDeflate,

  /// <summary>
  ///   Bottom Inflate Text IShape.
  /// </summary>
  TextInflateBottom,

  /// <summary>
  ///   Bottom Deflate Text IShape.
  /// </summary>
  TextDeflateBottom,

  /// <summary>
  ///   Top Inflate Text IShape.
  /// </summary>
  TextInflateTop,

  /// <summary>
  ///   Top Deflate Text IShape.
  /// </summary>
  TextDeflateTop,

  /// <summary>
  ///   Deflate-Inflate Text IShape.
  /// </summary>
  TextDeflateInflate,

  /// <summary>
  ///   Deflate-Inflate-Deflate Text IShape.
  /// </summary>
  TextDeflateInflateDeflate,

  /// <summary>
  ///   Right Fade Text IShape.
  /// </summary>
  TextFadeRight,

  /// <summary>
  ///   Left Fade Text IShape.
  /// </summary>
  TextFadeLeft,

  /// <summary>
  ///   Upward Fade Text IShape.
  /// </summary>
  TextFadeUp,

  /// <summary>
  ///   Downward Fade Text IShape.
  /// </summary>
  TextFadeDown,

  /// <summary>
  ///   Upward Slant Text IShape.
  /// </summary>
  TextSlantUp,

  /// <summary>
  ///   Downward Slant Text IShape.
  /// </summary>
  TextSlantDown,

  /// <summary>
  ///   Upward Cascade Text IShape.
  /// </summary>
  TextCascadeUp,

  /// <summary>
  ///   Downward Cascade Text IShape.
  /// </summary>
  TextCascadeDown
}
