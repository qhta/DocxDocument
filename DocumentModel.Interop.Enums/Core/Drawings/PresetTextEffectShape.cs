namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies shape of WordArt text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresettexteffectshape?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoPresetTextEffectShape")]
public enum PresetTextEffectShape
{
  /// <summary>
  /// Not used.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeMixed")]
  Mixed = -2,
  /// <summary>
  /// No shape applied.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapePlainText")]
  PlainText = 1,
  /// <summary>
  /// Text follows the shape of a stop sign.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeStop")]
  Stop = 2,
  /// <summary>
  /// Text slants down, then up.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeTriangleUp")]
  TriangleUp = 3,
  /// <summary>
  /// Text slants up, then down.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeTriangleDown")]
  TriangleDown = 4,
  /// <summary>
  /// Text slants down to its center point and then slants up.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeChevronUp")]
  ChevronUp = 5,
  /// <summary>
  /// Text slants up to its center point and then slants down.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeChevronDown")]
  ChevronDown = 6,
  /// <summary>
  /// Text appears to be written on the inside of a 3-D ring.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeRingInside")]
  RingInside = 7,
  /// <summary>
  /// Text appears to be written on the outside of a 3-D ring.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeRingOutside")]
  RingOutside = 8,
  /// <summary>
  /// Text is an arch that curves up.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeArchUpCurve")]
  ArchUpCurve = 9,
  /// <summary>
  /// Text is an arch that curves down.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeArchDownCurve")]
  ArchDownCurve = 10,
  /// <summary>
  /// Text follows a circle, reading clockwise.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeCircleCurve")]
  CircleCurve = 11,
  /// <summary>
  /// Text is curved around a center "button."
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeButtonCurve")]
  ButtonCurve = 12,
  /// <summary>
  /// Text is a 3-D arch that curves up.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeArchUpPour")]
  ArchUpPour = 13,
  /// <summary>
  /// Text is a 3-D arch that curves down.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeArchDownPour")]
  ArchDownPour = 14,
  /// <summary>
  /// Text has a 3-D effect and follows a circle, reading clockwise.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeCirclePour")]
  CirclePour = 15,
  /// <summary>
  /// Text is seen in 3-D, curved around a center "button."
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeButtonPour")]
  ButtonPour = 16,
  /// <summary>
  /// Text curves down and to the right as font size increases.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeCurveUp")]
  CurveUp = 17,
  /// <summary>
  /// Text curves down and to the right as font size decreases.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeCurveDown")]
  CurveDown = 18,
  /// <summary>
  /// Text is stretched to fill the height of the shape, with only a slight curve up.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeCanUp")]
  CanUp = 19,
  /// <summary>
  /// Text is stretched to fill the height of the shape, with only a slight curve down.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeCanDown")]
  CanDown = 20,
  /// <summary>
  /// Text follows a wave up, then down and up again.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeWave1")]
  Wave1 = 21,
  /// <summary>
  /// Text follows a wave down, then up and down again.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeWave2")]
  Wave2 = 22,
  /// <summary>
  /// Text follows a line that curves up, then down, then up and down again.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeDoubleWave1")]
  DoubleWave1 = 23,
  /// <summary>
  /// Text follows a line that curves down, then up, then down and up again.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeDoubleWave2")]
  DoubleWave2 = 24,
  /// <summary>
  /// Font size of text increases to its center point, then decreases. Center point of each letter is on the same
  /// straight line.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeInflate")]
  Inflate = 25,
  /// <summary>
  /// Font size decreases to the text's midpoint, then increases to the starting size.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeDeflate")]
  Deflate = 26,
  /// <summary>
  /// Font size of text increases to its center point, then decreases. Center point of each letter follows an arch
  /// that curves downward.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeInflateBottom")]
  InflateBottom = 27,
  /// <summary>
  /// Font size decreases to the text's midpoint, then increases to the starting size, while keeping the top of the
  /// text along the same curve.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeDeflateBottom")]
  DeflateBottom = 28,
  /// <summary>
  /// Font size of text increases to its center point, then decreases. Center point of each letter follows an arch
  /// that curves upward.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeInflateTop")]
  InflateTop = 29,
  /// <summary>
  /// Font size decreases to the text's midpoint, then increases to the starting size, while keeping the bottom of
  /// the text along the same curve.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeDeflateTop")]
  DeflateTop = 30,
  /// <summary>
  /// Font size increases to the text's midpoint, then decreases to the starting size.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeDeflateInflate")]
  DeflateInflate = 31,
  /// <summary>
  /// Font size decreases, increases, and decreases again across the text.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeDeflateInflateDeflate")]
  DeflateInflateDeflate = 32,
  /// <summary>
  /// Right side of text appears to be closer to the viewer than left side.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeFadeRight")]
  FadeRight = 33,
  /// <summary>
  /// Left side of text appears to be closer to the viewer than right side.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeFadeLeft")]
  FadeLeft = 34,
  /// <summary>
  /// Bottom of text appears to be closer to the viewer than top.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeFadeUp")]
  FadeUp = 35,
  /// <summary>
  /// Top of the text appears to be closer to the viewer than bottom of the text.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeFadeDown")]
  FadeDown = 36,
  /// <summary>
  /// Text slants up and to the right.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeSlantUp")]
  SlantUp = 37,
  /// <summary>
  /// Text slants down and to the right.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeSlantDown")]
  SlantDown = 38,
  /// <summary>
  /// Text slants down and to the right as font size increases.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeCascadeUp")]
  CascadeUp = 39,
  /// <summary>
  /// Text slants up and to the right as font size decreases.
  /// </summary>
  [InteropEnumValue("msoTextEffectShapeCascadeDown")]
  CascadeDown = 40
}
