namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies shape of WordArt text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresettexteffectshape?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoPresetTextEffectShape")]
public enum PresetTextEffectShape
{
  /// <summary>
  /// Not used.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeMixed")]
  Mixed = -2,
  /// <summary>
  /// No shape applied.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapePlainText")]
  PlainText = 1,
  /// <summary>
  /// Text follows the shape of a stop sign.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeStop")]
  Stop = 2,
  /// <summary>
  /// Text slants down, then up.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeTriangleUp")]
  TriangleUp = 3,
  /// <summary>
  /// Text slants up, then down.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeTriangleDown")]
  TriangleDown = 4,
  /// <summary>
  /// Text slants down to its center point and then slants up.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeChevronUp")]
  ChevronUp = 5,
  /// <summary>
  /// Text slants up to its center point and then slants down.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeChevronDown")]
  ChevronDown = 6,
  /// <summary>
  /// Text appears to be written on the inside of a 3-D ring.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeRingInside")]
  RingInside = 7,
  /// <summary>
  /// Text appears to be written on the outside of a 3-D ring.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeRingOutside")]
  RingOutside = 8,
  /// <summary>
  /// Text is an arch that curves up.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeArchUpCurve")]
  ArchUpCurve = 9,
  /// <summary>
  /// Text is an arch that curves down.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeArchDownCurve")]
  ArchDownCurve = 10,
  /// <summary>
  /// Text follows a circle, reading clockwise.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeCircleCurve")]
  CircleCurve = 11,
  /// <summary>
  /// Text is curved around a center "button."
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeButtonCurve")]
  ButtonCurve = 12,
  /// <summary>
  /// Text is a 3-D arch that curves up.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeArchUpPour")]
  ArchUpPour = 13,
  /// <summary>
  /// Text is a 3-D arch that curves down.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeArchDownPour")]
  ArchDownPour = 14,
  /// <summary>
  /// Text has a 3-D effect and follows a circle, reading clockwise.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeCirclePour")]
  CirclePour = 15,
  /// <summary>
  /// Text is seen in 3-D, curved around a center "button."
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeButtonPour")]
  ButtonPour = 16,
  /// <summary>
  /// Text curves down and to the right as font size increases.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeCurveUp")]
  CurveUp = 17,
  /// <summary>
  /// Text curves down and to the right as font size decreases.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeCurveDown")]
  CurveDown = 18,
  /// <summary>
  /// Text is stretched to fill the height of the shape, with only a slight curve up.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeCanUp")]
  CanUp = 19,
  /// <summary>
  /// Text is stretched to fill the height of the shape, with only a slight curve down.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeCanDown")]
  CanDown = 20,
  /// <summary>
  /// Text follows a wave up, then down and up again.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeWave1")]
  Wave1 = 21,
  /// <summary>
  /// Text follows a wave down, then up and down again.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeWave2")]
  Wave2 = 22,
  /// <summary>
  /// Text follows a line that curves up, then down, then up and down again.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeDoubleWave1")]
  DoubleWave1 = 23,
  /// <summary>
  /// Text follows a line that curves down, then up, then down and up again.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeDoubleWave2")]
  DoubleWave2 = 24,
  /// <summary>
  /// Font size of text increases to its center point, then decreases. Center point of each letter is on the same
  /// straight line.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeInflate")]
  Inflate = 25,
  /// <summary>
  /// Font size decreases to the text's midpoint, then increases to the starting size.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeDeflate")]
  Deflate = 26,
  /// <summary>
  /// Font size of text increases to its center point, then decreases. Center point of each letter follows an arch
  /// that curves downward.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeInflateBottom")]
  InflateBottom = 27,
  /// <summary>
  /// Font size decreases to the text's midpoint, then increases to the starting size, while keeping the top of the
  /// text along the same curve.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeDeflateBottom")]
  DeflateBottom = 28,
  /// <summary>
  /// Font size of text increases to its center point, then decreases. Center point of each letter follows an arch
  /// that curves upward.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeInflateTop")]
  InflateTop = 29,
  /// <summary>
  /// Font size decreases to the text's midpoint, then increases to the starting size, while keeping the bottom of
  /// the text along the same curve.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeDeflateTop")]
  DeflateTop = 30,
  /// <summary>
  /// Font size increases to the text's midpoint, then decreases to the starting size.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeDeflateInflate")]
  DeflateInflate = 31,
  /// <summary>
  /// Font size decreases, increases, and decreases again across the text.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeDeflateInflateDeflate")]
  DeflateInflateDeflate = 32,
  /// <summary>
  /// Right side of text appears to be closer to the viewer than left side.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeFadeRight")]
  FadeRight = 33,
  /// <summary>
  /// Left side of text appears to be closer to the viewer than right side.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeFadeLeft")]
  FadeLeft = 34,
  /// <summary>
  /// Bottom of text appears to be closer to the viewer than top.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeFadeUp")]
  FadeUp = 35,
  /// <summary>
  /// Top of the text appears to be closer to the viewer than bottom of the text.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeFadeDown")]
  FadeDown = 36,
  /// <summary>
  /// Text slants up and to the right.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeSlantUp")]
  SlantUp = 37,
  /// <summary>
  /// Text slants down and to the right.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeSlantDown")]
  SlantDown = 38,
  /// <summary>
  /// Text slants down and to the right as font size increases.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeCascadeUp")]
  CascadeUp = 39,
  /// <summary>
  /// Text slants up and to the right as font size decreases.
  /// </summary>
  [OfficeInteropEnumValue("msoTextEffectShapeCascadeDown")]
  CascadeDown = 40
}
