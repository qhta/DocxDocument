namespace DocumentModel.Drawings;
/// <summary>
///   Preset Text IShape Types
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.TextShapeValues))]
public enum TextShape
{
  /// <summary>
  ///   No Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextNoShape))]
  TextNoShape = 1,

  /// <summary>
  ///   Plain Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextPlain))]
  TextPlain,
  /// <summary>
  ///   Stop Sign Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextStop))]
  TextStop,
  /// <summary>
  ///   Triangle Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextTriangle))]
  TextTriangle,
  /// <summary>
  ///   Inverted Triangle Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextTriangleInverted))]
  TextTriangleInverted,
  /// <summary>
  ///   Chevron Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextChevron))]
  TextChevron,
  /// <summary>
  ///   Inverted Chevron Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextChevronInverted))]
  TextChevronInverted,
  /// <summary>
  ///   Inside Ring Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextRingInside))]
  TextRingInside,
  /// <summary>
  ///   Outside Ring Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextRingOutside))]
  TextRingOutside,
  /// <summary>
  ///   Upward Arch Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextArchUp))]
  TextArchUp,
  /// <summary>
  ///   Downward Arch Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextArchDown))]
  TextArchDown,
  /// <summary>
  ///   Circle Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextCircle))]
  TextCircle,
  /// <summary>
  ///   Button Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextButton))]
  TextButton,
  /// <summary>
  ///   Upward Pour Arch Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextArchUpPour))]
  TextArchUpPour,
  /// <summary>
  ///   Downward Pour Arch Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextArchDownPour))]
  TextArchDownPour,
  /// <summary>
  ///   Circle Pour Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextCirclePour))]
  TextCirclePour,
  /// <summary>
  ///   Button Pour Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextButtonPour))]
  TextButtonPour,
  /// <summary>
  ///   Upward Curve Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextCurveUp))]
  TextCurveUp,
  /// <summary>
  ///   Downward Curve Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextCurveDown))]
  TextCurveDown,
  /// <summary>
  ///   Upward Can Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextCanUp))]
  TextCanUp,
  /// <summary>
  ///   Downward Can Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextCanDown))]
  TextCanDown,
  /// <summary>
  ///   Wave 1 Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextWave1))]
  TextWave1,
  /// <summary>
  ///   Wave 2 Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextWave2))]
  TextWave2,
  /// <summary>
  ///   Double Wave 1 Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextDoubleWave1))]
  TextDoubleWave1,
  /// <summary>
  ///   Wave 4 Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextWave4))]
  TextWave4,
  /// <summary>
  ///   Inflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextInflate))]
  TextInflate,
  /// <summary>
  ///   Deflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextDeflate))]
  TextDeflate,
  /// <summary>
  ///   Bottom Inflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextInflateBottom))]
  TextInflateBottom,
  /// <summary>
  ///   Bottom Deflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextDeflateBottom))]
  TextDeflateBottom,
  /// <summary>
  ///   Top Inflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextInflateTop))]
  TextInflateTop,
  /// <summary>
  ///   Top Deflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextDeflateTop))]
  TextDeflateTop,
  /// <summary>
  ///   Deflate-Inflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextDeflateInflate))]
  TextDeflateInflate,
  /// <summary>
  ///   Deflate-Inflate-Deflate Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextDeflateInflateDeflate))]
  TextDeflateInflateDeflate,
  /// <summary>
  ///   Right Fade Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextFadeRight))]
  TextFadeRight,
  /// <summary>
  ///   Left Fade Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextFadeLeft))]
  TextFadeLeft,
  /// <summary>
  ///   Upward Fade Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextFadeUp))]
  TextFadeUp,
  /// <summary>
  ///   Downward Fade Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextFadeDown))]
  TextFadeDown,
  /// <summary>
  ///   Upward Slant Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextSlantUp))]
  TextSlantUp,
  /// <summary>
  ///   Downward Slant Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextSlantDown))]
  TextSlantDown,
  /// <summary>
  ///   Upward Cascade Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextCascadeUp))]
  TextCascadeUp,
  /// <summary>
  ///   Downward Cascade Text IShape.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextShapeValues.TextCascadeDown))]
  TextCascadeDown
}
