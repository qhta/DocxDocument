namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the fill pattern used in a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopatterntype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoPatternType
{
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// 5% of the foreground color.
  /// </summary>
  FivePercent = 1,
  /// <summary>
  /// 10% of the foreground color.
  /// </summary>
  TenPercent = 2,
  /// <summary>
  /// 20% of the foreground color.
  /// </summary>
  TwentyPercent = 3,
  /// <summary>
  /// 25% of the foreground color.
  /// </summary>
  TwentyFivePercent = 4,
  /// <summary>
  /// 30% of the foreground color.
  /// </summary>
  ThirtyPercent = 5,
  /// <summary>
  /// 40% of the foreground color.
  /// </summary>
  FortyPercent = 6,
  /// <summary>
  /// 50% of the foreground color.
  /// </summary>
  FiftyPercent = 7,
  /// <summary>
  /// 60% of the foreground color.
  /// </summary>
  SixtyPercent = 8,
  /// <summary>
  /// 70% of the foreground color.
  /// </summary>
  SeventyPercent = 9,
  /// <summary>
  /// 75% of the foreground color.
  /// </summary>
  SeventyFivePercent = 10,
  /// <summary>
  /// 80% of the foreground color.
  /// </summary>
  EightyPercent = 11,
  /// <summary>
  /// 90% of the foreground colorExpand table
  /// </summary>
  NinetyPercent = 12,
  /// <summary>
  /// Thick horizontal lines in the foreground color.
  /// </summary>
  DarkHorizontal = 13,
  /// <summary>
  /// Thick vertical lines in the foreground color. msoPatternDarkDownwardDiagonal15 Thick lines in the foreground
  /// color running from the top to the right-hand side of the shape. msoPatternDarkUpwardDiagonal16 Thick lines in
  /// the foreground color running from the top to the left-hand side of the shape.
  /// </summary>
  DarkVertical = 14,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  DarkDownwardDiagonal = 15,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  DarkUpwardDiagonal = 16,
  /// <summary>
  /// Small squares in alternating foreground/background colors.
  /// </summary>
  SmallCheckerBoard = 17,
  /// <summary>
  /// Trellis pattern in the foreground color.
  /// </summary>
  Trellis = 18,
  /// <summary>
  /// Thin horizontal lines in the foreground color.
  /// </summary>
  LightHorizontal = 19,
  /// <summary>
  /// Thin vertical lines in the foreground color. msoPatternLightDownwardDiagonal21 Thin lines in the foreground
  /// color running from the top to the right-hand side of the shape. msoPatternLightUpwardDiagonal22 Thin lines in
  /// the foreground color running from the top to the left-hand side of the shape.
  /// </summary>
  LightVertical = 20,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  LightDownwardDiagonal = 21,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  LightUpwardDiagonal = 22,
  /// <summary>
  /// Solid, closely spaced perpendicular lines in the foreground color running horizontally and vertically to form
  /// grid lines across the shape.
  /// </summary>
  SmallGrid = 23,
  /// <summary>
  /// Dotted perpendicular lines in the foreground color running diagonally to form diamonds across the shape.
  /// msoPatternWideDownwardDiagonal25 Widely spaced lines in the foreground color running from the top to the
  /// right-hand side of the shape. msoPatternWideUpwardDiagonal26 Widely spaced lines in the foreground color
  /// running from the top to the left-hand side of the shape. msoPatternDashedUpwardDiagonal27 Dashed lines in the
  /// foreground color running from the top to the left-hand side of the shape. msoPatternDashedDownwardDiagonal28
  /// Dashed lines in the foreground color running from the top to the right-hand side of the shape.
  /// </summary>
  DottedDiamond = 24,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  WideDownwardDiagonal = 25,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  WideUpwardDiagonal = 26,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  DashedUpwardDiagonal = 27,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  DashedDownwardDiagonal = 28,
  /// <summary>
  /// Narrowly spaced vertical lines in the foreground color.
  /// </summary>
  NarrowVertical = 29,
  /// <summary>
  /// Narrowly spaced horizontal lines in the foreground color.
  /// </summary>
  NarrowHorizontal = 30,
  /// <summary>
  /// Dashed vertical lines in the foreground color.
  /// </summary>
  DashedVertical = 31,
  /// <summary>
  /// Dashed horizontal lines in the foreground color.
  /// </summary>
  DashedHorizontal = 32,
  /// <summary>
  /// Large dots in the foreground color scattered across the shape.
  /// </summary>
  LargeConfetti = 33,
  /// <summary>
  /// Solid, widely spaced perpendicular lines in the foreground color running horizontally and vertically to form
  /// grid lines across the shape.
  /// </summary>
  LargeGrid = 34,
  /// <summary>
  /// Rectangular brick pattern running horizontally across the shape.
  /// </summary>
  HorizontalBrick = 35,
  /// <summary>
  /// Squares in alternating foreground/background colors.
  /// </summary>
  LargeCheckerBoard = 36,
  /// <summary>
  /// Small dots in the foreground color scattered across the shape.
  /// </summary>
  SmallConfetti = 37,
  /// <summary>
  /// Zigzag lines running horizontally across the shape.
  /// </summary>
  ZigZag = 38,
  /// <summary>
  /// Diamond shapes in alternating foreground/background colors.
  /// </summary>
  SolidDiamond = 39,
  /// <summary>
  /// Rectangular brick pattern running diagonally across the shape.
  /// </summary>
  DiagonalBrick = 40,
  /// <summary>
  /// Solid perpendicular lines in the foreground color running diagonally to form diamonds across the shape.
  /// </summary>
  OutlinedDiamond = 41,
  /// <summary>
  /// Very thick solid lines in the foreground color running vertically, coupled with very thick lines and 40% of
  /// the foreground color running horizontally.
  /// </summary>
  Plaid = 42,
  /// <summary>
  /// Circles that use foreground and background colors to make them appear three-dimensional, oriented in rows
  /// across the shape.
  /// </summary>
  Sphere = 43,
  /// <summary>
  /// Weave pattern in the foreground color running diagonally across the shape.
  /// </summary>
  Weave = 44,
  /// <summary>
  /// Dotted perpendicular lines in the foreground color running horizontally and vertically to form grid lines
  /// across the shape.
  /// </summary>
  DottedGrid = 45,
  /// <summary>
  /// Small angled shapes in the foreground color running in alternating rows down the shape.
  /// </summary>
  Divot = 46,
  /// <summary>
  /// Overlapping curved rectangles running diagonally across the shape.
  /// </summary>
  Shingle = 47,
  /// <summary>
  /// Wavy lines in the foreground color.
  /// </summary>
  Wave = 48,
  /// <summary>
  /// Horizontal
  /// </summary>
  Horizontal = 49,
  /// <summary>
  /// Vertical
  /// </summary>
  Vertical = 50,
  /// <summary>
  /// Cross
  /// </summary>
  Cross = 51,
  /// <summary>
  /// Downward Diagonal
  /// </summary>
  DownwardDiagonal = 52,
  /// <summary>
  /// Upward Diagonal
  /// </summary>
  UpwardDiagonal = 53,
  /// <summary>
  /// Diagonal Cross
  /// </summary>
  DiagonalCross = 54
}
