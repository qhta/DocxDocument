namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the fill pattern used in a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopatterntype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoPatternType")]
public enum PatternType
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoPatternMixed")]
  Mixed = -2,
  /// <summary>
  /// 5% of the foreground color.
  /// </summary>
  [InteropEnumValue("msoPattern5Percent")]
  FivePercent = 1,
  /// <summary>
  /// 10% of the foreground color.
  /// </summary>
  [InteropEnumValue("msoPattern10Percent")]
  TenPercent = 2,
  /// <summary>
  /// 20% of the foreground color.
  /// </summary>
  [InteropEnumValue("msoPattern20Percent")]
  TwentyPercent = 3,
  /// <summary>
  /// 25% of the foreground color.
  /// </summary>
  [InteropEnumValue("msoPattern25Percent")]
  TwentyFivePercent = 4,
  /// <summary>
  /// 30% of the foreground color.
  /// </summary>
  [InteropEnumValue("msoPattern30Percent")]
  ThirtyPercent = 5,
  /// <summary>
  /// 40% of the foreground color.
  /// </summary>
  [InteropEnumValue("msoPattern40Percent")]
  FortyPercent = 6,
  /// <summary>
  /// 50% of the foreground color.
  /// </summary>
  [InteropEnumValue("msoPattern50Percent")]
  FiftyPercent = 7,
  /// <summary>
  /// 60% of the foreground color.
  /// </summary>
  [InteropEnumValue("msoPattern60Percent")]
  SixtyPercent = 8,
  /// <summary>
  /// 70% of the foreground color.
  /// </summary>
  [InteropEnumValue("msoPattern70Percent")]
  SeventyPercent = 9,
  /// <summary>
  /// 75% of the foreground color.
  /// </summary>
  [InteropEnumValue("msoPattern75Percent")]
  SeventyFivePercent = 10,
  /// <summary>
  /// 80% of the foreground color.
  /// </summary>
  [InteropEnumValue("msoPattern80Percent")]
  EightyPercent = 11,
  /// <summary>
  /// 90% of the foreground colorExpand table
  /// </summary>
  [InteropEnumValue("msoPattern90Percent")]
  NinetyPercent = 12,
  /// <summary>
  /// Thick horizontal lines in the foreground color.
  /// </summary>
  [InteropEnumValue("msoPatternDarkHorizontal")]
  DarkHorizontal = 13,
  /// <summary>
  /// Thick vertical lines in the foreground color.
  /// </summary>
  [InteropEnumValue("msoPatternDarkVertical")]
  DarkVertical = 14,
  /// <summary>
  /// Thick lines in the foreground color running from the top to the right-hand side of the shape.
  /// </summary>
  [InteropEnumValue("msoPatternDarkDownwardDiagonal")]
  DarkDownwardDiagonal = 15,
  /// <summary>
  /// Thick lines in the foreground color running from the top to the left-hand side of the shape.
  /// </summary>
  [InteropEnumValue("msoPatternDarkUpwardDiagonal")]
  DarkUpwardDiagonal = 16,
  /// <summary>
  /// Small squares in alternating foreground/background colors.
  /// </summary>
  [InteropEnumValue("msoPatternSmallCheckerBoard")]
  SmallCheckerBoard = 17,
  /// <summary>
  /// Trellis pattern in the foreground color.
  /// </summary>
  [InteropEnumValue("msoPatternTrellis")]
  Trellis = 18,
  /// <summary>
  /// Thin horizontal lines in the foreground color.
  /// </summary>
  [InteropEnumValue("msoPatternLightHorizontal")]
  LightHorizontal = 19,
  /// <summary>
  /// Thin vertical lines in the foreground color.
  /// </summary>
  [InteropEnumValue("msoPatternLightVertical")]
  LightVertical = 20,
  /// <summary>
  /// Thin lines in the foreground color running from the top to the right-hand side of the shape.
  /// </summary>
  [InteropEnumValue("msoPatternLightDownwardDiagonal")]
  LightDownwardDiagonal = 21,
  /// <summary>
  /// Thin lines in the foreground color running from the top to the left-hand side of the shape.
  /// </summary>
  [InteropEnumValue("msoPatternLightUpwardDiagonal")]
  LightUpwardDiagonal = 22,
  /// <summary>
  /// Solid, closely spaced perpendicular lines in the foreground color running horizontally and vertically to form
  /// grid lines across the shape.
  /// </summary>
  [InteropEnumValue("msoPatternSmallGrid")]
  SmallGrid = 23,
  /// <summary>
  /// Dotted perpendicular lines in the foreground color running diagonally to form diamonds across the shape.
  /// </summary>
  [InteropEnumValue("msoPatternDottedDiamond")]
  DottedDiamond = 24,
  /// <summary>
  /// Widely spaced lines in the foreground color running from the top to the right-hand side of the shape.
  /// </summary>
  [InteropEnumValue("msoPatternWideDownwardDiagonal")]
  WideDownwardDiagonal = 25,
  /// <summary>
  /// Widely spaced lines in the foreground color running from the top to the left-hand side of the shape.
  /// </summary>
  [InteropEnumValue("msoPatternWideUpwardDiagonal")]
  WideUpwardDiagonal = 26,
  /// <summary>
  /// Dashed lines in the foreground color running from the top to the left-hand side of the shape.
  /// </summary>
  [InteropEnumValue("msoPatternDashedUpwardDiagonal")]
  DashedUpwardDiagonal = 27,
  /// <summary>
  /// Dashed lines in the foreground color running from the top to the right-hand side of the shape.
  /// </summary>
  [InteropEnumValue("msoPatternDashedDownwardDiagonal")]
  DashedDownwardDiagonal = 28,
  /// <summary>
  /// Narrowly spaced vertical lines in the foreground color.
  /// </summary>
  [InteropEnumValue("msoPatternNarrowVertical")]
  NarrowVertical = 29,
  /// <summary>
  /// Narrowly spaced horizontal lines in the foreground color.
  /// </summary>
  [InteropEnumValue("msoPatternNarrowHorizontal")]
  NarrowHorizontal = 30,
  /// <summary>
  /// Dashed vertical lines in the foreground color.
  /// </summary>
  [InteropEnumValue("msoPatternDashedVertical")]
  DashedVertical = 31,
  /// <summary>
  /// Dashed horizontal lines in the foreground color.
  /// </summary>
  [InteropEnumValue("msoPatternDashedHorizontal")]
  DashedHorizontal = 32,
  /// <summary>
  /// Large dots in the foreground color scattered across the shape.
  /// </summary>
  [InteropEnumValue("msoPatternLargeConfetti")]
  LargeConfetti = 33,
  /// <summary>
  /// Solid, widely spaced perpendicular lines in the foreground color running horizontally and vertically to form
  /// grid lines across the shape.
  /// </summary>
  [InteropEnumValue("msoPatternLargeGrid")]
  LargeGrid = 34,
  /// <summary>
  /// Rectangular brick pattern running horizontally across the shape.
  /// </summary>
  [InteropEnumValue("msoPatternHorizontalBrick")]
  HorizontalBrick = 35,
  /// <summary>
  /// Squares in alternating foreground/background colors.
  /// </summary>
  [InteropEnumValue("msoPatternLargeCheckerBoard")]
  LargeCheckerBoard = 36,
  /// <summary>
  /// Small dots in the foreground color scattered across the shape.
  /// </summary>
  [InteropEnumValue("msoPatternSmallConfetti")]
  SmallConfetti = 37,
  /// <summary>
  /// Zigzag lines running horizontally across the shape.
  /// </summary>
  [InteropEnumValue("msoPatternZigZag")]
  ZigZag = 38,
  /// <summary>
  /// Diamond shapes in alternating foreground/background colors.
  /// </summary>
  [InteropEnumValue("msoPatternSolidDiamond")]
  SolidDiamond = 39,
  /// <summary>
  /// Rectangular brick pattern running diagonally across the shape.
  /// </summary>
  [InteropEnumValue("msoPatternDiagonalBrick")]
  DiagonalBrick = 40,
  /// <summary>
  /// Solid perpendicular lines in the foreground color running diagonally to form diamonds across the shape.
  /// </summary>
  [InteropEnumValue("msoPatternOutlinedDiamond")]
  OutlinedDiamond = 41,
  /// <summary>
  /// Very thick solid lines in the foreground color running vertically, coupled with very thick lines and 40% of
  /// the foreground color running horizontally.
  /// </summary>
  [InteropEnumValue("msoPatternPlaid")]
  Plaid = 42,
  /// <summary>
  /// Circles that use foreground and background colors to make them appear three-dimensional, oriented in rows
  /// across the shape.
  /// </summary>
  [InteropEnumValue("msoPatternSphere")]
  Sphere = 43,
  /// <summary>
  /// Weave pattern in the foreground color running diagonally across the shape.
  /// </summary>
  [InteropEnumValue("msoPatternWeave")]
  Weave = 44,
  /// <summary>
  /// Dotted perpendicular lines in the foreground color running horizontally and vertically to form grid lines
  /// across the shape.
  /// </summary>
  [InteropEnumValue("msoPatternDottedGrid")]
  DottedGrid = 45,
  /// <summary>
  /// Small angled shapes in the foreground color running in alternating rows down the shape.
  /// </summary>
  [InteropEnumValue("msoPatternDivot")]
  Divot = 46,
  /// <summary>
  /// Overlapping curved rectangles running diagonally across the shape.
  /// </summary>
  [InteropEnumValue("msoPatternShingle")]
  Shingle = 47,
  /// <summary>
  /// Wavy lines in the foreground color.
  /// </summary>
  [InteropEnumValue("msoPatternWave")]
  Wave = 48,
  /// <summary>
  /// Horizontal
  /// </summary>
  [InteropEnumValue("msoPatternHorizontal")]
  Horizontal = 49,
  /// <summary>
  /// Vertical
  /// </summary>
  [InteropEnumValue("msoPatternVertical")]
  Vertical = 50,
  /// <summary>
  /// Cross
  /// </summary>
  [InteropEnumValue("msoPatternCross")]
  Cross = 51,
  /// <summary>
  /// Downward Diagonal
  /// </summary>
  [InteropEnumValue("msoPatternDownwardDiagonal")]
  DownwardDiagonal = 52,
  /// <summary>
  /// Upward Diagonal
  /// </summary>
  [InteropEnumValue("msoPatternUpwardDiagonal")]
  UpwardDiagonal = 53,
  /// <summary>
  /// Diagonal Cross
  /// </summary>
  [InteropEnumValue("msoPatternDiagonalCross")]
  DiagonalCross = 54
}
