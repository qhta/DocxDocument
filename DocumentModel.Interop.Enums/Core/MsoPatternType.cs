namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the fill pattern used in a shape.
/// </summary>
public enum MsoPatternType
{
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  msoPatternMixed = -2,
  /// <summary>
  /// 5% of the foreground color.
  /// </summary>
  msoPattern5Percent = 1,
  /// <summary>
  /// 10% of the foreground color.
  /// </summary>
  msoPattern10Percent = 2,
  /// <summary>
  /// 20% of the foreground color.
  /// </summary>
  msoPattern20Percent = 3,
  /// <summary>
  /// 25% of the foreground color.
  /// </summary>
  msoPattern25Percent = 4,
  /// <summary>
  /// 30% of the foreground color.
  /// </summary>
  msoPattern30Percent = 5,
  /// <summary>
  /// 40% of the foreground color.
  /// </summary>
  msoPattern40Percent = 6,
  /// <summary>
  /// 50% of the foreground color.
  /// </summary>
  msoPattern50Percent = 7,
  /// <summary>
  /// 60% of the foreground color.
  /// </summary>
  msoPattern60Percent = 8,
  /// <summary>
  /// 70% of the foreground color.
  /// </summary>
  msoPattern70Percent = 9,
  /// <summary>
  /// 75% of the foreground color.
  /// </summary>
  msoPattern75Percent = 10,
  /// <summary>
  /// 80% of the foreground color.
  /// </summary>
  msoPattern80Percent = 11,
  /// <summary>
  /// 90% of the foreground color. public enum class MsoPatternType ﾉ Expand table
  /// </summary>
  msoPattern90Percent = 12,
  /// <summary>
  /// Thick horizontal lines in the foreground color.
  /// </summary>
  msoPatternDarkHorizontal = 13,
  /// <summary>
  /// Thick vertical lines in the foreground color. msoPatternDarkDownwardDiagonal15 Thick lines in the foreground
  /// color running from the top to the right-hand side of the shape. msoPatternDarkUpwardDiagonal16 Thick lines in
  /// the foreground color running from the top to the left-hand side of the shape.
  /// </summary>
  msoPatternDarkVertical = 14,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  msoPatternDarkDownwardDiagonal = 15,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  msoPatternDarkUpwardDiagonal = 16,
  /// <summary>
  /// Small squares in alternating foreground/background colors.
  /// </summary>
  msoPatternSmallCheckerBoard = 17,
  /// <summary>
  /// Trellis pattern in the foreground color.
  /// </summary>
  msoPatternTrellis = 18,
  /// <summary>
  /// Thin horizontal lines in the foreground color.
  /// </summary>
  msoPatternLightHorizontal = 19,
  /// <summary>
  /// Thin vertical lines in the foreground color. msoPatternLightDownwardDiagonal21 Thin lines in the foreground
  /// color running from the top to the right-hand side of the shape. msoPatternLightUpwardDiagonal22 Thin lines in
  /// the foreground color running from the top to the left-hand side of the shape.
  /// </summary>
  msoPatternLightVertical = 20,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  msoPatternLightDownwardDiagonal = 21,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  msoPatternLightUpwardDiagonal = 22,
  /// <summary>
  /// Solid, closely spaced perpendicular lines in the foreground color running horizontally and vertically to form
  /// grid lines across the shape.
  /// </summary>
  msoPatternSmallGrid = 23,
  /// <summary>
  /// Dotted perpendicular lines in the foreground color running diagonally to form diamonds across the shape.
  /// msoPatternWideDownwardDiagonal25 Widely spaced lines in the foreground color running from the top to the
  /// right-hand side of the shape. msoPatternWideUpwardDiagonal26 Widely spaced lines in the foreground color
  /// running from the top to the left-hand side of the shape. msoPatternDashedUpwardDiagonal27 Dashed lines in the
  /// foreground color running from the top to the left-hand side of the shape. msoPatternDashedDownwardDiagonal28
  /// Dashed lines in the foreground color running from the top to the right-hand side of the shape.
  /// </summary>
  msoPatternDottedDiamond = 24,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  msoPatternWideDownwardDiagonal = 25,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  msoPatternWideUpwardDiagonal = 26,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  msoPatternDashedUpwardDiagonal = 27,
  /// <summary>
  /// Specifies the fill pattern used in a shape.
  /// </summary>
  msoPatternDashedDownwardDiagonal = 28,
  /// <summary>
  /// Narrowly spaced vertical lines in the foreground color.
  /// </summary>
  msoPatternNarrowVertical = 29,
  /// <summary>
  /// Narrowly spaced horizontal lines in the foreground color.
  /// </summary>
  msoPatternNarrowHorizontal = 30,
  /// <summary>
  /// Dashed vertical lines in the foreground color.
  /// </summary>
  msoPatternDashedVertical = 31,
  /// <summary>
  /// Dashed horizontal lines in the foreground color.
  /// </summary>
  msoPatternDashedHorizontal = 32,
  /// <summary>
  /// Large dots in the foreground color scattered across the shape.
  /// </summary>
  msoPatternLargeConfetti = 33,
  /// <summary>
  /// Solid, widely spaced perpendicular lines in the foreground color running horizontally and vertically to form
  /// grid lines across the shape.
  /// </summary>
  msoPatternLargeGrid = 34,
  /// <summary>
  /// Rectangular brick pattern running horizontally across the shape.
  /// </summary>
  msoPatternHorizontalBrick = 35,
  /// <summary>
  /// Squares in alternating foreground/background colors.
  /// </summary>
  msoPatternLargeCheckerBoard = 36,
  /// <summary>
  /// Small dots in the foreground color scattered across the shape.
  /// </summary>
  msoPatternSmallConfetti = 37,
  /// <summary>
  /// Zigzag lines running horizontally across the shape.
  /// </summary>
  msoPatternZigZag = 38,
  /// <summary>
  /// Diamond shapes in alternating foreground/background colors.
  /// </summary>
  msoPatternSolidDiamond = 39,
  /// <summary>
  /// Rectangular brick pattern running diagonally across the shape.
  /// </summary>
  msoPatternDiagonalBrick = 40,
  /// <summary>
  /// Solid perpendicular lines in the foreground color running diagonally to form diamonds across the shape.
  /// </summary>
  msoPatternOutlinedDiamond = 41,
  /// <summary>
  /// Very thick solid lines in the foreground color running vertically, coupled with very thick lines and 40% of
  /// the foreground color running horizontally.
  /// </summary>
  msoPatternPlaid = 42,
  /// <summary>
  /// Circles that use foreground and background colors to make them appear three-dimensional, oriented in rows
  /// across the shape.
  /// </summary>
  msoPatternSphere = 43,
  /// <summary>
  /// Weave pattern in the foreground color running diagonally across the shape.
  /// </summary>
  msoPatternWeave = 44,
  /// <summary>
  /// Dotted perpendicular lines in the foreground color running horizontally and vertically to form grid lines
  /// across the shape.
  /// </summary>
  msoPatternDottedGrid = 45,
  /// <summary>
  /// Small angled shapes in the foreground color running in alternating rows down the shape.
  /// </summary>
  msoPatternDivot = 46,
  /// <summary>
  /// Overlapping curved rectangles running diagonally across the shape.
  /// </summary>
  msoPatternShingle = 47,
  /// <summary>
  /// Wavy lines in the foreground color.
  /// </summary>
  msoPatternWave = 48,
  /// <summary>
  /// Horizontal
  /// </summary>
  msoPatternHorizontal = 49,
  /// <summary>
  /// Vertical
  /// </summary>
  msoPatternVertical = 50,
  /// <summary>
  /// Cross
  /// </summary>
  msoPatternCross = 51,
  /// <summary>
  /// Downward Diagonal
  /// </summary>
  msoPatternDownwardDiagonal = 52,
  /// <summary>
  /// Upward Diagonal
  /// </summary>
  msoPatternUpwardDiagonal = 53,
  /// <summary>
  /// Diagonal Cross
  /// </summary>
  msoPatternDiagonalCross = 54
}
