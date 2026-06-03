namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the interior pattern of a chart or interior object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlpattern?view=office-pia` for Office interop details.
/// </remarks>
public enum XlPattern
{
  /// <summary>
  /// Solid color.
  /// </summary>
  Solid = 1,
  /// <summary>
  /// Checkerboard.
  /// </summary>
  Checker = 9,
  /// <summary>
  /// 75% dark moirĂ©.
  /// </summary>
  SemiGray75 = 10,
  /// <summary>
  /// Light horizontal lines. public enum XlPattern
  /// </summary>
  LightHorizontal = 11,
  /// <summary>
  /// Light vertical bars.
  /// </summary>
  LightVertical = 12,
  /// <summary>
  /// Light diagonal lines running from the upper left Ito the lower right.
  /// </summary>
  LightDown = 13,
  /// <summary>
  /// Light diagonal lines running from the lower left Ito the upper right.
  /// </summary>
  LightUp = 14,
  /// <summary>
  /// Grid.
  /// </summary>
  Grid = 15,
  /// <summary>
  /// Criss-cross lines.
  /// </summary>
  CrissCross = 16,
  /// <summary>
  /// 16% gray.
  /// </summary>
  Gray16 = 17,
  /// <summary>
  /// 8% gray.
  /// </summary>
  Gray8 = 18,
  /// <summary>
  /// Linear gradient.
  /// </summary>
  LinearGradient = 4000,
  /// <summary>
  /// Rectangular gradient.
  /// </summary>
  RectangularGradient = 4001,
  /// <summary>
  /// Dark vertical bars.
  /// </summary>
  Vertical = -4166,
  /// <summary>
  /// Dark diagonal lines running from the lower left Ito the upper right.
  /// </summary>
  Up = -4162,
  /// <summary>
  /// No pattern.
  /// </summary>
  None = -4142,
  /// <summary>
  /// Dark horizontal lines.
  /// </summary>
  Horizontal = -4128,
  /// <summary>
  /// 75% gray.
  /// </summary>
  Gray75 = -4126,
  /// <summary>
  /// 50% gray.
  /// </summary>
  Gray50 = -4125,
  /// <summary>
  /// 25% gray.
  /// </summary>
  Gray25 = -4124,
  /// <summary>
  /// Dark diagonal lines running from the upper left Ito the lower right.
  /// </summary>
  Down = -4121,
  /// <summary>
  /// Word controls the pattern.
  /// </summary>
  Automatic = -4105
}

