namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the fill pattern used in a shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopatterntype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoPatternType))]
public enum PatternType
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternMixed))]
  Mixed = -2,
  /// <summary>
  /// 5% of the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPattern5Percent))]
  FivePercent = 1,
  /// <summary>
  /// 10% of the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPattern10Percent))]
  TenPercent = 2,
  /// <summary>
  /// 20% of the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPattern20Percent))]
  TwentyPercent = 3,
  /// <summary>
  /// 25% of the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPattern25Percent))]
  TwentyFivePercent = 4,
  /// <summary>
  /// 30% of the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPattern30Percent))]
  ThirtyPercent = 5,
  /// <summary>
  /// 40% of the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPattern40Percent))]
  FortyPercent = 6,
  /// <summary>
  /// 50% of the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPattern50Percent))]
  FiftyPercent = 7,
  /// <summary>
  /// 60% of the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPattern60Percent))]
  SixtyPercent = 8,
  /// <summary>
  /// 70% of the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPattern70Percent))]
  SeventyPercent = 9,
  /// <summary>
  /// 75% of the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPattern75Percent))]
  SeventyFivePercent = 10,
  /// <summary>
  /// 80% of the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPattern80Percent))]
  EightyPercent = 11,
  /// <summary>
  /// 90% of the foreground colorExpand table
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPattern90Percent))]
  NinetyPercent = 12,
  /// <summary>
  /// Thick horizontal lines in the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternDarkHorizontal))]
  DarkHorizontal = 13,
  /// <summary>
  /// Thick vertical lines in the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternDarkVertical))]
  DarkVertical = 14,
  /// <summary>
  /// Thick lines in the foreground color running from the top to the right-hand side of the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternDarkDownwardDiagonal))]
  DarkDownwardDiagonal = 15,
  /// <summary>
  /// Thick lines in the foreground color running from the top to the left-hand side of the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternDarkUpwardDiagonal))]
  DarkUpwardDiagonal = 16,
  /// <summary>
  /// Small squares in alternating foreground/background colors.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternSmallCheckerBoard))]
  SmallCheckerBoard = 17,
  /// <summary>
  /// Trellis pattern in the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternTrellis))]
  Trellis = 18,
  /// <summary>
  /// Thin horizontal lines in the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternLightHorizontal))]
  LightHorizontal = 19,
  /// <summary>
  /// Thin vertical lines in the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternLightVertical))]
  LightVertical = 20,
  /// <summary>
  /// Thin lines in the foreground color running from the top to the right-hand side of the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternLightDownwardDiagonal))]
  LightDownwardDiagonal = 21,
  /// <summary>
  /// Thin lines in the foreground color running from the top to the left-hand side of the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternLightUpwardDiagonal))]
  LightUpwardDiagonal = 22,
  /// <summary>
  /// Solid, closely spaced perpendicular lines in the foreground color running horizontally and vertically to form
  /// grid lines across the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternSmallGrid))]
  SmallGrid = 23,
  /// <summary>
  /// Dotted perpendicular lines in the foreground color running diagonally to form diamonds across the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternDottedDiamond))]
  DottedDiamond = 24,
  /// <summary>
  /// Widely spaced lines in the foreground color running from the top to the right-hand side of the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternWideDownwardDiagonal))]
  WideDownwardDiagonal = 25,
  /// <summary>
  /// Widely spaced lines in the foreground color running from the top to the left-hand side of the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternWideUpwardDiagonal))]
  WideUpwardDiagonal = 26,
  /// <summary>
  /// Dashed lines in the foreground color running from the top to the left-hand side of the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternDashedUpwardDiagonal))]
  DashedUpwardDiagonal = 27,
  /// <summary>
  /// Dashed lines in the foreground color running from the top to the right-hand side of the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternDashedDownwardDiagonal))]
  DashedDownwardDiagonal = 28,
  /// <summary>
  /// Narrowly spaced vertical lines in the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternNarrowVertical))]
  NarrowVertical = 29,
  /// <summary>
  /// Narrowly spaced horizontal lines in the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternNarrowHorizontal))]
  NarrowHorizontal = 30,
  /// <summary>
  /// Dashed vertical lines in the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternDashedVertical))]
  DashedVertical = 31,
  /// <summary>
  /// Dashed horizontal lines in the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternDashedHorizontal))]
  DashedHorizontal = 32,
  /// <summary>
  /// Large dots in the foreground color scattered across the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternLargeConfetti))]
  LargeConfetti = 33,
  /// <summary>
  /// Solid, widely spaced perpendicular lines in the foreground color running horizontally and vertically to form
  /// grid lines across the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternLargeGrid))]
  LargeGrid = 34,
  /// <summary>
  /// Rectangular brick pattern running horizontally across the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternHorizontalBrick))]
  HorizontalBrick = 35,
  /// <summary>
  /// Squares in alternating foreground/background colors.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternLargeCheckerBoard))]
  LargeCheckerBoard = 36,
  /// <summary>
  /// Small dots in the foreground color scattered across the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternSmallConfetti))]
  SmallConfetti = 37,
  /// <summary>
  /// Zigzag lines running horizontally across the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternZigZag))]
  ZigZag = 38,
  /// <summary>
  /// Diamond shapes in alternating foreground/background colors.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternSolidDiamond))]
  SolidDiamond = 39,
  /// <summary>
  /// Rectangular brick pattern running diagonally across the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternDiagonalBrick))]
  DiagonalBrick = 40,
  /// <summary>
  /// Solid perpendicular lines in the foreground color running diagonally to form diamonds across the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternOutlinedDiamond))]
  OutlinedDiamond = 41,
  /// <summary>
  /// Very thick solid lines in the foreground color running vertically, coupled with very thick lines and 40% of
  /// the foreground color running horizontally.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternPlaid))]
  Plaid = 42,
  /// <summary>
  /// Circles that use foreground and background colors to make them appear three-dimensional, oriented in rows
  /// across the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternSphere))]
  Sphere = 43,
  /// <summary>
  /// Weave pattern in the foreground color running diagonally across the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternWeave))]
  Weave = 44,
  /// <summary>
  /// Dotted perpendicular lines in the foreground color running horizontally and vertically to form grid lines
  /// across the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternDottedGrid))]
  DottedGrid = 45,
  /// <summary>
  /// Small angled shapes in the foreground color running in alternating rows down the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternDivot))]
  Divot = 46,
  /// <summary>
  /// Overlapping curved rectangles running diagonally across the shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternShingle))]
  Shingle = 47,
  /// <summary>
  /// Wavy lines in the foreground color.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternWave))]
  Wave = 48,
  /// <summary>
  /// Horizontal
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternHorizontal))]
  Horizontal = 49,
  /// <summary>
  /// Vertical
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternVertical))]
  Vertical = 50,
  /// <summary>
  /// Cross
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternCross))]
  Cross = 51,
  /// <summary>
  /// Downward Diagonal
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternDownwardDiagonal))]
  DownwardDiagonal = 52,
  /// <summary>
  /// Upward Diagonal
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternUpwardDiagonal))]
  UpwardDiagonal = 53,
  /// <summary>
  /// Diagonal Cross
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPatternType.msoPatternDiagonalCross))]
  DiagonalCross = 54
}
