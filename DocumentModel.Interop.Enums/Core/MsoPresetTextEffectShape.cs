namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies shape of WordArt text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresettexteffectshape?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoPresetTextEffectShape))]
public enum PresetTextEffectShape
{
  /// <summary>
  /// Not used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeMixed))]
  Mixed = -2,
  /// <summary>
  /// No shape applied.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapePlainText))]
  PlainText = 1,
  /// <summary>
  /// Text follows the shape of a stop sign.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeStop))]
  Stop = 2,
  /// <summary>
  /// Text slants down, then up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeTriangleUp))]
  TriangleUp = 3,
  /// <summary>
  /// Text slants up, then down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeTriangleDown))]
  TriangleDown = 4,
  /// <summary>
  /// Text slants down to its center point and then slants up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeChevronUp))]
  ChevronUp = 5,
  /// <summary>
  /// Text slants up to its center point and then slants down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeChevronDown))]
  ChevronDown = 6,
  /// <summary>
  /// Text appears to be written on the inside of a 3-D ring.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeRingInside))]
  RingInside = 7,
  /// <summary>
  /// Text appears to be written on the outside of a 3-D ring.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeRingOutside))]
  RingOutside = 8,
  /// <summary>
  /// Text is an arch that curves up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeArchUpCurve))]
  ArchUpCurve = 9,
  /// <summary>
  /// Text is an arch that curves down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeArchDownCurve))]
  ArchDownCurve = 10,
  /// <summary>
  /// Text follows a circle, reading clockwise.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeCircleCurve))]
  CircleCurve = 11,
  /// <summary>
  /// Text is curved around a center "button."
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeButtonCurve))]
  ButtonCurve = 12,
  /// <summary>
  /// Text is a 3-D arch that curves up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeArchUpPour))]
  ArchUpPour = 13,
  /// <summary>
  /// Text is a 3-D arch that curves down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeArchDownPour))]
  ArchDownPour = 14,
  /// <summary>
  /// Text has a 3-D effect and follows a circle, reading clockwise.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeCirclePour))]
  CirclePour = 15,
  /// <summary>
  /// Text is seen in 3-D, curved around a center "button."
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeButtonPour))]
  ButtonPour = 16,
  /// <summary>
  /// Text curves down and to the right as font size increases.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeCurveUp))]
  CurveUp = 17,
  /// <summary>
  /// Text curves down and to the right as font size decreases.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeCurveDown))]
  CurveDown = 18,
  /// <summary>
  /// Text is stretched to fill the height of the shape, with only a slight curve up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeCanUp))]
  CanUp = 19,
  /// <summary>
  /// Text is stretched to fill the height of the shape, with only a slight curve down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeCanDown))]
  CanDown = 20,
  /// <summary>
  /// Text follows a wave up, then down and up again.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeWave1))]
  Wave1 = 21,
  /// <summary>
  /// Text follows a wave down, then up and down again.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeWave2))]
  Wave2 = 22,
  /// <summary>
  /// Text follows a line that curves up, then down, then up and down again.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeDoubleWave1))]
  DoubleWave1 = 23,
  /// <summary>
  /// Text follows a line that curves down, then up, then down and up again.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeDoubleWave2))]
  DoubleWave2 = 24,
  /// <summary>
  /// Font size of text increases to its center point, then decreases. Center point of each letter is on the same
  /// straight line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeInflate))]
  Inflate = 25,
  /// <summary>
  /// Font size decreases to the text's midpoint, then increases to the starting size.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeDeflate))]
  Deflate = 26,
  /// <summary>
  /// Font size of text increases to its center point, then decreases. Center point of each letter follows an arch
  /// that curves downward.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeInflateBottom))]
  InflateBottom = 27,
  /// <summary>
  /// Font size decreases to the text's midpoint, then increases to the starting size, while keeping the top of the
  /// text along the same curve.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeDeflateBottom))]
  DeflateBottom = 28,
  /// <summary>
  /// Font size of text increases to its center point, then decreases. Center point of each letter follows an arch
  /// that curves upward.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeInflateTop))]
  InflateTop = 29,
  /// <summary>
  /// Font size decreases to the text's midpoint, then increases to the starting size, while keeping the bottom of
  /// the text along the same curve.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeDeflateTop))]
  DeflateTop = 30,
  /// <summary>
  /// Font size increases to the text's midpoint, then decreases to the starting size.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeDeflateInflate))]
  DeflateInflate = 31,
  /// <summary>
  /// Font size decreases, increases, and decreases again across the text.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeDeflateInflateDeflate))]
  DeflateInflateDeflate = 32,
  /// <summary>
  /// Right side of text appears to be closer to the viewer than left side.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeFadeRight))]
  FadeRight = 33,
  /// <summary>
  /// Left side of text appears to be closer to the viewer than right side.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeFadeLeft))]
  FadeLeft = 34,
  /// <summary>
  /// Bottom of text appears to be closer to the viewer than top.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeFadeUp))]
  FadeUp = 35,
  /// <summary>
  /// Top of the text appears to be closer to the viewer than bottom of the text.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeFadeDown))]
  FadeDown = 36,
  /// <summary>
  /// Text slants up and to the right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeSlantUp))]
  SlantUp = 37,
  /// <summary>
  /// Text slants down and to the right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeSlantDown))]
  SlantDown = 38,
  /// <summary>
  /// Text slants down and to the right as font size increases.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeCascadeUp))]
  CascadeUp = 39,
  /// <summary>
  /// Text slants up and to the right as font size decreases.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPresetTextEffectShape.msoTextEffectShapeCascadeDown))]
  CascadeDown = 40
}
