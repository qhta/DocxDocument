namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies shape of WordArt text.
/// </summary>
public enum MsoPresetTextEffectShape
{
  /// <summary>
  /// Specifies shape of WordArt text.
  /// </summary>
  msoTextEffectShapeMixed = -2,
  /// <summary>
  /// No shape applied.
  /// </summary>
  msoTextEffectShapePlainText = 1,
  /// <summary>
  /// Text follows the shape of a stop sign.
  /// </summary>
  msoTextEffectShapeStop = 2,
  /// <summary>
  /// Text slants down, then up.
  /// </summary>
  msoTextEffectShapeTriangleUp = 3,
  /// <summary>
  /// Text slants up, then down.
  /// </summary>
  msoTextEffectShapeTriangleDown = 4,
  /// <summary>
  /// Text slants down to its center point and then slants up. msoTextEffectShapeChevronDown6 Text slants up to its
  /// center point and then slants down.
  /// </summary>
  msoTextEffectShapeChevronUp = 5,
  /// <summary>
  /// Specifies shape of WordArt text.
  /// </summary>
  msoTextEffectShapeChevronDown = 6,
  /// <summary>
  /// Text appears to be written on the inside of a 3-D ring.
  /// </summary>
  msoTextEffectShapeRingInside = 7,
  /// <summary>
  /// Text appears to be written on the outside of a 3-D ring.
  /// </summary>
  msoTextEffectShapeRingOutside = 8,
  /// <summary>
  /// Text is an arch that curves up. msoTextEffectShapeArchDownCurve10 Text is an arch that curves down.
  /// </summary>
  msoTextEffectShapeArchUpCurve = 9,
  /// <summary>
  /// Specifies shape of WordArt text.
  /// </summary>
  msoTextEffectShapeArchDownCurve = 10,
  /// <summary>
  /// Text follows a circle, reading clockwise. public enum class MsoPresetTextEffectShape ﾉ Expand table
  /// </summary>
  msoTextEffectShapeCircleCurve = 11,
  /// <summary>
  /// Text is curved around a center "button."
  /// </summary>
  msoTextEffectShapeButtonCurve = 12,
  /// <summary>
  /// Text is a 3-D arch that curves up.
  /// </summary>
  msoTextEffectShapeArchUpPour = 13,
  /// <summary>
  /// Text is a 3-D arch that curves down.
  /// </summary>
  msoTextEffectShapeArchDownPour = 14,
  /// <summary>
  /// Text has a 3-D effect and follows a circle, reading clockwise.
  /// </summary>
  msoTextEffectShapeCirclePour = 15,
  /// <summary>
  /// Text is seen in 3-D, curved around a center "button."
  /// </summary>
  msoTextEffectShapeButtonPour = 16,
  /// <summary>
  /// Text curves down and to the right as font size increases.
  /// </summary>
  msoTextEffectShapeCurveUp = 17,
  /// <summary>
  /// Text curves down and to the right as font size decreases.
  /// </summary>
  msoTextEffectShapeCurveDown = 18,
  /// <summary>
  /// Text is stretched to fill the height of the shape, with only a slight curve up.
  /// </summary>
  msoTextEffectShapeCanUp = 19,
  /// <summary>
  /// Text is stretched to fill the height of the shape, with only a slight curve down.
  /// </summary>
  msoTextEffectShapeCanDown = 20,
  /// <summary>
  /// Text follows a wave up, then down and up again.
  /// </summary>
  msoTextEffectShapeWave1 = 21,
  /// <summary>
  /// Text follows a wave down, then up and down again.
  /// </summary>
  msoTextEffectShapeWave2 = 22,
  /// <summary>
  /// Text follows a line that curves up, then down, then up and down again.
  /// </summary>
  msoTextEffectShapeDoubleWave1 = 23,
  /// <summary>
  /// Text follows a line that curves down, then up, then down and up again.
  /// </summary>
  msoTextEffectShapeDoubleWave2 = 24,
  /// <summary>
  /// Font size of text increases to its center point, then decreases. Center point of each letter is on the same
  /// straight line.
  /// </summary>
  msoTextEffectShapeInflate = 25,
  /// <summary>
  /// Font size decreases to the text's midpoint, then increases to the starting size.
  /// msoTextEffectShapeInflateBottom27 Font size of text increases to its center point, then decreases. Center
  /// point of each letter follows an arch that curves downward. msoTextEffectShapeDeflateBottom28 Font size
  /// decreases to the text's midpoint, then increases to the starting size, while keeping the top of the text along
  /// the same curve.
  /// </summary>
  msoTextEffectShapeDeflate = 26,
  /// <summary>
  /// Specifies shape of WordArt text.
  /// </summary>
  msoTextEffectShapeInflateBottom = 27,
  /// <summary>
  /// Specifies shape of WordArt text.
  /// </summary>
  msoTextEffectShapeDeflateBottom = 28,
  /// <summary>
  /// Font size of text increases to its center point, then decreases. Center point of each letter follows an arch
  /// that curves upward.
  /// </summary>
  msoTextEffectShapeInflateTop = 29,
  /// <summary>
  /// Font size decreases to the text's midpoint, then increases to the starting size, while keeping the bottom of
  /// the text along the same curve. msoTextEffectShapeDeflateInflate31 Font size increases to the text's midpoint,
  /// then decreases to the starting size. msoTextEffectShapeDeflateInflateDeflate32 Font size decreases, increases,
  /// and decreases again across the text.
  /// </summary>
  msoTextEffectShapeDeflateTop = 30,
  /// <summary>
  /// Specifies shape of WordArt text.
  /// </summary>
  msoTextEffectShapeDeflateInflate = 31,
  /// <summary>
  /// Specifies shape of WordArt text.
  /// </summary>
  msoTextEffectShapeDeflateInflateDeflate = 32,
  /// <summary>
  /// Right side of text appears to be closer to the viewer than left side.
  /// </summary>
  msoTextEffectShapeFadeRight = 33,
  /// <summary>
  /// Left side of text appears to be closer to the viewer than right side.
  /// </summary>
  msoTextEffectShapeFadeLeft = 34,
  /// <summary>
  /// Bottom of text appears to be closer to the viewer than top.
  /// </summary>
  msoTextEffectShapeFadeUp = 35,
  /// <summary>
  /// Top of the text appears to be closer to the viewer than bottom of the text.
  /// </summary>
  msoTextEffectShapeFadeDown = 36,
  /// <summary>
  /// Text slants up and to the right.
  /// </summary>
  msoTextEffectShapeSlantUp = 37,
  /// <summary>
  /// Text slants down and to the right.
  /// </summary>
  msoTextEffectShapeSlantDown = 38,
  /// <summary>
  /// Text slants down and to the right as font size increases. msoTextEffectShapeCascadeDown40 Text slants up and
  /// to the right as font size decreases.
  /// </summary>
  msoTextEffectShapeCascadeUp = 39,
  /// <summary>
  /// Specifies shape of WordArt text.
  /// </summary>
  msoTextEffectShapeCascadeDown = 40
}
