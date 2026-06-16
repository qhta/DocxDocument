namespace DocumentModel.Drawings;

/// <summary>
/// Specifies shape of WordArt text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopresettexteffectshape?view=office-pia` for Office interop details.
/// </remarks>
public enum PresetTextEffectShape
{
  /// <summary>
  /// Not used.
  /// </summary>
  /// <summary>
  /// No shape applied.
  /// </summary>
  PlainText = 1,
  /// <summary>
  /// Text follows the shape of a stop sign.
  /// </summary>
  Stop = 2,
  /// <summary>
  /// Text slants down, then up.
  /// </summary>
  TriangleUp = 3,
  /// <summary>
  /// Text slants up, then down.
  /// </summary>
  TriangleDown = 4,
  /// <summary>
  /// Text slants down to its center point and then slants up.
  /// </summary>
  ChevronUp = 5,
  /// <summary>
  /// Text slants up to its center point and then slants down.
  /// </summary>
  ChevronDown = 6,
  /// <summary>
  /// Text appears to be written on the inside of a 3-D ring.
  /// </summary>
  RingInside = 7,
  /// <summary>
  /// Text appears to be written on the outside of a 3-D ring.
  /// </summary>
  RingOutside = 8,
  /// <summary>
  /// Text is an arch that curves up.
  /// </summary>
  ArchUpCurve = 9,
  /// <summary>
  /// Text is an arch that curves down.
  /// </summary>
  ArchDownCurve = 10,
  /// <summary>
  /// Text follows a circle, reading clockwise.
  /// </summary>
  CircleCurve = 11,
  /// <summary>
  /// Text is curved around a center "button."
  /// </summary>
  ButtonCurve = 12,
  /// <summary>
  /// Text is a 3-D arch that curves up.
  /// </summary>
  ArchUpPour = 13,
  /// <summary>
  /// Text is a 3-D arch that curves down.
  /// </summary>
  ArchDownPour = 14,
  /// <summary>
  /// Text has a 3-D effect and follows a circle, reading clockwise.
  /// </summary>
  CirclePour = 15,
  /// <summary>
  /// Text is seen in 3-D, curved around a center "button."
  /// </summary>
  ButtonPour = 16,
  /// <summary>
  /// Text curves down and to the right as font size increases.
  /// </summary>
  CurveUp = 17,
  /// <summary>
  /// Text curves down and to the right as font size decreases.
  /// </summary>
  CurveDown = 18,
  /// <summary>
  /// Text is stretched to fill the height of the shape, with only a slight curve up.
  /// </summary>
  CanUp = 19,
  /// <summary>
  /// Text is stretched to fill the height of the shape, with only a slight curve down.
  /// </summary>
  CanDown = 20,
  /// <summary>
  /// Text follows a wave up, then down and up again.
  /// </summary>
  Wave1 = 21,
  /// <summary>
  /// Text follows a wave down, then up and down again.
  /// </summary>
  Wave2 = 22,
  /// <summary>
  /// Text follows a line that curves up, then down, then up and down again.
  /// </summary>
  DoubleWave1 = 23,
  /// <summary>
  /// Text follows a line that curves down, then up, then down and up again.
  /// </summary>
  DoubleWave2 = 24,
  /// <summary>
  /// IFont size of text increases to its center point, then decreases. Center point of each letter is on the same
  /// straight line.
  /// </summary>
  Inflate = 25,
  /// <summary>
  /// IFont size decreases to the text's midpoint, then increases to the starting size.
  /// </summary>
  Deflate = 26,
  /// <summary>
  /// IFont size of text increases to its center point, then decreases. Center point of each letter follows an arch
  /// that curves downward.
  /// </summary>
  InflateBottom = 27,
  /// <summary>
  /// IFont size decreases to the text's midpoint, then increases to the starting size, while keeping the top of the
  /// text along the same curve.
  /// </summary>
  DeflateBottom = 28,
  /// <summary>
  /// IFont size of text increases to its center point, then decreases. Center point of each letter follows an arch
  /// that curves upward.
  /// </summary>
  InflateTop = 29,
  /// <summary>
  /// IFont size decreases to the text's midpoint, then increases to the starting size, while keeping the bottom of
  /// the text along the same curve.
  /// </summary>
  DeflateTop = 30,
  /// <summary>
  /// IFont size increases to the text's midpoint, then decreases to the starting size.
  /// </summary>
  DeflateInflate = 31,
  /// <summary>
  /// IFont size decreases, increases, and decreases again across the text.
  /// </summary>
  DeflateInflateDeflate = 32,
  /// <summary>
  /// Right side of text appears to be closer to the viewer than left side.
  /// </summary>
  FadeRight = 33,
  /// <summary>
  /// Left side of text appears to be closer to the viewer than right side.
  /// </summary>
  FadeLeft = 34,
  /// <summary>
  /// Bottom of text appears to be closer to the viewer than top.
  /// </summary>
  FadeUp = 35,
  /// <summary>
  /// Top of the text appears to be closer to the viewer than bottom of the text.
  /// </summary>
  FadeDown = 36,
  /// <summary>
  /// Text slants up and to the right.
  /// </summary>
  SlantUp = 37,
  /// <summary>
  /// Text slants down and to the right.
  /// </summary>
  SlantDown = 38,
  /// <summary>
  /// Text slants down and to the right as font size increases.
  /// </summary>
  CascadeUp = 39,
  /// <summary>
  /// Text slants up and to the right as font size decreases.
  /// </summary>
  CascadeDown = 40
}

