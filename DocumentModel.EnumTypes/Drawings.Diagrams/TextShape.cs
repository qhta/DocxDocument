namespace DocumentModel.Drawings;
/// <summary>
///   Preset Text IShape Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TextShapeValues))]
public enum TextShape
{
  /// <summary>
  ///   No Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextNoShape))]
  TextNoShape = 1,

  /// <summary>
  ///   Plain Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextPlain))]
  TextPlain,
  /// <summary>
  ///   Stop Sign Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextStop))]
  TextStop,
  /// <summary>
  ///   Triangle Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextTriangle))]
  TextTriangle,
  /// <summary>
  ///   Inverted Triangle Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextTriangleInverted))]
  TextTriangleInverted,
  /// <summary>
  ///   Chevron Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextChevron))]
  TextChevron,
  /// <summary>
  ///   Inverted Chevron Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextChevronInverted))]
  TextChevronInverted,
  /// <summary>
  ///   Inside Ring Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextRingInside))]
  TextRingInside,
  /// <summary>
  ///   Outside Ring Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextRingOutside))]
  TextRingOutside,
  /// <summary>
  ///   Upward Arch Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextArchUp))]
  TextArchUp,
  /// <summary>
  ///   Downward Arch Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextArchDown))]
  TextArchDown,
  /// <summary>
  ///   Circle Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCircle))]
  TextCircle,
  /// <summary>
  ///   Button Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextButton))]
  TextButton,
  /// <summary>
  ///   Upward Pour Arch Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextArchUpPour))]
  TextArchUpPour,
  /// <summary>
  ///   Downward Pour Arch Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextArchDownPour))]
  TextArchDownPour,
  /// <summary>
  ///   Circle Pour Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCirclePour))]
  TextCirclePour,
  /// <summary>
  ///   Button Pour Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextButtonPour))]
  TextButtonPour,
  /// <summary>
  ///   Upward Curve Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCurveUp))]
  TextCurveUp,
  /// <summary>
  ///   Downward Curve Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCurveDown))]
  TextCurveDown,
  /// <summary>
  ///   Upward Can Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCanUp))]
  TextCanUp,
  /// <summary>
  ///   Downward Can Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCanDown))]
  TextCanDown,
  /// <summary>
  ///   Wave 1 Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextWave1))]
  TextWave1,
  /// <summary>
  ///   Wave 2 Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextWave2))]
  TextWave2,
  /// <summary>
  ///   Double Wave 1 Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextDoubleWave1))]
  TextDoubleWave1,
  /// <summary>
  ///   Wave 4 Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextWave4))]
  TextWave4,
  /// <summary>
  ///   Inflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextInflate))]
  TextInflate,
  /// <summary>
  ///   Deflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextDeflate))]
  TextDeflate,
  /// <summary>
  ///   Bottom Inflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextInflateBottom))]
  TextInflateBottom,
  /// <summary>
  ///   Bottom Deflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextDeflateBottom))]
  TextDeflateBottom,
  /// <summary>
  ///   Top Inflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextInflateTop))]
  TextInflateTop,
  /// <summary>
  ///   Top Deflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextDeflateTop))]
  TextDeflateTop,
  /// <summary>
  ///   Deflate-Inflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextDeflateInflate))]
  TextDeflateInflate,
  /// <summary>
  ///   Deflate-Inflate-Deflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextDeflateInflateDeflate))]
  TextDeflateInflateDeflate,
  /// <summary>
  ///   Right Fade Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextFadeRight))]
  TextFadeRight,
  /// <summary>
  ///   Left Fade Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextFadeLeft))]
  TextFadeLeft,
  /// <summary>
  ///   Upward Fade Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextFadeUp))]
  TextFadeUp,
  /// <summary>
  ///   Downward Fade Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextFadeDown))]
  TextFadeDown,
  /// <summary>
  ///   Upward Slant Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextSlantUp))]
  TextSlantUp,
  /// <summary>
  ///   Downward Slant Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextSlantDown))]
  TextSlantDown,
  /// <summary>
  ///   Upward Cascade Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCascadeUp))]
  TextCascadeUp,
  /// <summary>
  ///   Downward Cascade Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCascadeDown))]
  TextCascadeDown
}
