namespace DocumentModel.Drawings;
/// <summary>
///   Preset Text Shape Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TextShapeValues))]
public enum TextShape
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  /// <summary>
  ///   No Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextNoShape))]
  TextNoShape = 1,

  /// <summary>
  ///   Plain Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextPlain))]
  TextPlain,
  /// <summary>
  ///   Stop Sign Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextStop))]
  TextStop,
  /// <summary>
  ///   Triangle Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextTriangle))]
  TextTriangle,
  /// <summary>
  ///   Inverted Triangle Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextTriangleInverted))]
  TextTriangleInverted,
  /// <summary>
  ///   Chevron Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextChevron))]
  TextChevron,
  /// <summary>
  ///   Inverted Chevron Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextChevronInverted))]
  TextChevronInverted,
  /// <summary>
  ///   Inside Ring Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextRingInside))]
  TextRingInside,
  /// <summary>
  ///   Outside Ring Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextRingOutside))]
  TextRingOutside,
  /// <summary>
  ///   Upward Arch Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextArchUp))]
  TextArchUp,
  /// <summary>
  ///   Downward Arch Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextArchDown))]
  TextArchDown,
  /// <summary>
  ///   Circle Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCircle))]
  TextCircle,
  /// <summary>
  ///   Button Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextButton))]
  TextButton,
  /// <summary>
  ///   Upward Pour Arch Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextArchUpPour))]
  TextArchUpPour,
  /// <summary>
  ///   Downward Pour Arch Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextArchDownPour))]
  TextArchDownPour,
  /// <summary>
  ///   Circle Pour Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCirclePour))]
  TextCirclePour,
  /// <summary>
  ///   Button Pour Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextButtonPour))]
  TextButtonPour,
  /// <summary>
  ///   Upward Curve Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCurveUp))]
  TextCurveUp,
  /// <summary>
  ///   Downward Curve Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCurveDown))]
  TextCurveDown,
  /// <summary>
  ///   Upward Can Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCanUp))]
  TextCanUp,
  /// <summary>
  ///   Downward Can Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCanDown))]
  TextCanDown,
  /// <summary>
  ///   Wave 1 Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextWave1))]
  TextWave1,
  /// <summary>
  ///   Wave 2 Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextWave2))]
  TextWave2,
  /// <summary>
  ///   Double Wave 1 Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextDoubleWave1))]
  TextDoubleWave1,
  /// <summary>
  ///   Wave 4 Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextWave4))]
  TextWave4,
  /// <summary>
  ///   Inflate Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextInflate))]
  TextInflate,
  /// <summary>
  ///   Deflate Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextDeflate))]
  TextDeflate,
  /// <summary>
  ///   Bottom Inflate Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextInflateBottom))]
  TextInflateBottom,
  /// <summary>
  ///   Bottom Deflate Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextDeflateBottom))]
  TextDeflateBottom,
  /// <summary>
  ///   Top Inflate Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextInflateTop))]
  TextInflateTop,
  /// <summary>
  ///   Top Deflate Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextDeflateTop))]
  TextDeflateTop,
  /// <summary>
  ///   Deflate-Inflate Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextDeflateInflate))]
  TextDeflateInflate,
  /// <summary>
  ///   Deflate-Inflate-Deflate Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextDeflateInflateDeflate))]
  TextDeflateInflateDeflate,
  /// <summary>
  ///   Right Fade Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextFadeRight))]
  TextFadeRight,
  /// <summary>
  ///   Left Fade Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextFadeLeft))]
  TextFadeLeft,
  /// <summary>
  ///   Upward Fade Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextFadeUp))]
  TextFadeUp,
  /// <summary>
  ///   Downward Fade Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextFadeDown))]
  TextFadeDown,
  /// <summary>
  ///   Upward Slant Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextSlantUp))]
  TextSlantUp,
  /// <summary>
  ///   Downward Slant Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextSlantDown))]
  TextSlantDown,
  /// <summary>
  ///   Upward Cascade Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCascadeUp))]
  TextCascadeUp,
  /// <summary>
  ///   Downward Cascade Text Shape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextShapeValues.TextCascadeDown))]
  TextCascadeDown
}