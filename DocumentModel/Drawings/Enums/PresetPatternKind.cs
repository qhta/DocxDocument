namespace DocumentModel.Drawings;

/// <summary>
///   Preset Pattern Value
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PresetPatternKind
{
  /// <summary>
  ///   5%.
  /// </summary>
  Percent5,

  /// <summary>
  ///   10%.
  /// </summary>
  Percent10,

  /// <summary>
  ///   20%.
  /// </summary>
  Percent20,

  /// <summary>
  ///   25%.
  /// </summary>
  Percent25,

  /// <summary>
  ///   30%.
  /// </summary>
  Percent30,

  /// <summary>
  ///   40%.
  /// </summary>
  Percent40,

  /// <summary>
  ///   50%.
  /// </summary>
  Percent50,

  /// <summary>
  ///   60%.
  /// </summary>
  Percent60,

  /// <summary>
  ///   70%.
  /// </summary>
  Percent70,

  /// <summary>
  ///   75%.
  /// </summary>
  Percent75,

  /// <summary>
  ///   80%.
  /// </summary>
  Percent80,

  /// <summary>
  ///   90%.
  /// </summary>
  Percent90,

  /// <summary>
  ///   Horizontal.
  /// </summary>
  Horizontal,

  /// <summary>
  ///   Vertical.
  /// </summary>
  Vertical,

  /// <summary>
  ///   Light Horizontal.
  /// </summary>
  LightHorizontal,

  /// <summary>
  ///   Light Vertical.
  /// </summary>
  LightVertical,

  /// <summary>
  ///   Dark Horizontal.
  /// </summary>
  DarkHorizontal,

  /// <summary>
  ///   Dark Vertical.
  /// </summary>
  DarkVertical,

  /// <summary>
  ///   Narrow Horizontal.
  /// </summary>
  NarrowHorizontal,

  /// <summary>
  ///   Narrow Vertical.
  /// </summary>
  NarrowVertical,

  /// <summary>
  ///   Dashed Horizontal.
  /// </summary>
  DashedHorizontal,

  /// <summary>
  ///   Dashed Vertical.
  /// </summary>
  DashedVertical,

  /// <summary>
  ///   Cross.
  /// </summary>
  Cross,

  /// <summary>
  ///   Downward Diagonal.
  /// </summary>
  DownwardDiagonal,

  /// <summary>
  ///   Upward Diagonal.
  /// </summary>
  UpwardDiagonal,

  /// <summary>
  ///   Light Downward Diagonal.
  /// </summary>
  LightDownwardDiagonal,

  /// <summary>
  ///   Light Upward Diagonal.
  /// </summary>
  LightUpwardDiagonal,

  /// <summary>
  ///   Dark Downward Diagonal.
  /// </summary>
  DarkDownwardDiagonal,

  /// <summary>
  ///   Dark Upward Diagonal.
  /// </summary>
  DarkUpwardDiagonal,

  /// <summary>
  ///   Wide Downward Diagonal.
  /// </summary>
  WideDownwardDiagonal,

  /// <summary>
  ///   Wide Upward Diagonal.
  /// </summary>
  WideUpwardDiagonal,

  /// <summary>
  ///   Dashed Downward Diagonal.
  /// </summary>
  DashedDownwardDiagonal,

  /// <summary>
  ///   Dashed Upward DIagonal.
  /// </summary>
  DashedUpwardDiagonal,

  /// <summary>
  ///   Diagonal Cross.
  /// </summary>
  DiagonalCross,

  /// <summary>
  ///   Small Checker Board.
  /// </summary>
  SmallCheck,

  /// <summary>
  ///   Large Checker Board.
  /// </summary>
  LargeCheck,

  /// <summary>
  ///   Small Grid.
  /// </summary>
  SmallGrid,

  /// <summary>
  ///   Large Grid.
  /// </summary>
  LargeGrid,

  /// <summary>
  ///   Dotted Grid.
  /// </summary>
  DotGrid,

  /// <summary>
  ///   Small Confetti.
  /// </summary>
  SmallConfetti,

  /// <summary>
  ///   Large Confetti.
  /// </summary>
  LargeConfetti,

  /// <summary>
  ///   Horizontal Brick.
  /// </summary>
  HorizontalBrick,

  /// <summary>
  ///   Diagonal Brick.
  /// </summary>
  DiagonalBrick,

  /// <summary>
  ///   Solid Diamond.
  /// </summary>
  SolidDiamond,

  /// <summary>
  ///   Open Diamond.
  /// </summary>
  OpenDiamond,

  /// <summary>
  ///   Dotted Diamond.
  /// </summary>
  DottedDiamond,

  /// <summary>
  ///   Plaid.
  /// </summary>
  Plaid,

  /// <summary>
  ///   Sphere.
  /// </summary>
  Sphere,

  /// <summary>
  ///   Weave.
  /// </summary>
  Weave,

  /// <summary>
  ///   Divot.
  /// </summary>
  Divot,

  /// <summary>
  ///   Shingle.
  /// </summary>
  Shingle,

  /// <summary>
  ///   Wave.
  /// </summary>
  Wave,

  /// <summary>
  ///   Trellis.
  /// </summary>
  Trellis,

  /// <summary>
  ///   Zig Zag.
  /// </summary>
  ZigZag
}