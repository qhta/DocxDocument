namespace DocumentModel.Drawings;
/// <summary>
///   Preset Pattern Value
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.PresetPatternValues))]
public enum PresetPattern
{
  /// <summary>
  ///   5%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Percent5))]
  Percent5 = 1,

  /// <summary>
  ///   10%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Percent10))]
  Percent10,
  /// <summary>
  ///   20%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Percent20))]
  Percent20,
  /// <summary>
  ///   25%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Percent25))]
  Percent25,
  /// <summary>
  ///   30%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Percent30))]
  Percent30,
  /// <summary>
  ///   40%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Percent40))]
  Percent40,
  /// <summary>
  ///   50%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Percent50))]
  Percent50,
  /// <summary>
  ///   60%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Percent60))]
  Percent60,
  /// <summary>
  ///   70%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Percent70))]
  Percent70,
  /// <summary>
  ///   75%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Percent75))]
  Percent75,
  /// <summary>
  ///   80%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Percent80))]
  Percent80,
  /// <summary>
  ///   90%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Percent90))]
  Percent90,
  /// <summary>
  ///   Horizontal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Horizontal))]
  Horizontal,
  /// <summary>
  ///   Vertical.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Vertical))]
  Vertical,
  /// <summary>
  ///   Light Horizontal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.LightHorizontal))]
  LightHorizontal,
  /// <summary>
  ///   Light Vertical.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.LightVertical))]
  LightVertical,
  /// <summary>
  ///   Dark Horizontal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.DarkHorizontal))]
  DarkHorizontal,
  /// <summary>
  ///   Dark Vertical.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.DarkVertical))]
  DarkVertical,
  /// <summary>
  ///   Narrow Horizontal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.NarrowHorizontal))]
  NarrowHorizontal,
  /// <summary>
  ///   Narrow Vertical.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.NarrowVertical))]
  NarrowVertical,
  /// <summary>
  ///   Dashed Horizontal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.DashedHorizontal))]
  DashedHorizontal,
  /// <summary>
  ///   Dashed Vertical.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.DashedVertical))]
  DashedVertical,
  /// <summary>
  ///   Cross.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Cross))]
  Cross,
  /// <summary>
  ///   Downward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.DownwardDiagonal))]
  DownwardDiagonal,
  /// <summary>
  ///   Upward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.UpwardDiagonal))]
  UpwardDiagonal,
  /// <summary>
  ///   Light Downward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.LightDownwardDiagonal))]
  LightDownwardDiagonal,
  /// <summary>
  ///   Light Upward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.LightUpwardDiagonal))]
  LightUpwardDiagonal,
  /// <summary>
  ///   Dark Downward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.DarkDownwardDiagonal))]
  DarkDownwardDiagonal,
  /// <summary>
  ///   Dark Upward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.DarkUpwardDiagonal))]
  DarkUpwardDiagonal,
  /// <summary>
  ///   Wide Downward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.WideDownwardDiagonal))]
  WideDownwardDiagonal,
  /// <summary>
  ///   Wide Upward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.WideUpwardDiagonal))]
  WideUpwardDiagonal,
  /// <summary>
  ///   Dashed Downward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.DashedDownwardDiagonal))]
  DashedDownwardDiagonal,
  /// <summary>
  ///   Dashed Upward DIagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.DashedUpwardDiagonal))]
  DashedUpwardDiagonal,
  /// <summary>
  ///   Diagonal Cross.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.DiagonalCross))]
  DiagonalCross,
  /// <summary>
  ///   Small Checker Board.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.SmallCheck))]
  SmallCheck,
  /// <summary>
  ///   Large Checker Board.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.LargeCheck))]
  LargeCheck,
  /// <summary>
  ///   Small Grid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.SmallGrid))]
  SmallGrid,
  /// <summary>
  ///   Large Grid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.LargeGrid))]
  LargeGrid,
  /// <summary>
  ///   Dotted Grid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.DotGrid))]
  DotGrid,
  /// <summary>
  ///   Small Confetti.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.SmallConfetti))]
  SmallConfetti,
  /// <summary>
  ///   Large Confetti.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.LargeConfetti))]
  LargeConfetti,
  /// <summary>
  ///   Horizontal Brick.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.HorizontalBrick))]
  HorizontalBrick,
  /// <summary>
  ///   Diagonal Brick.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.DiagonalBrick))]
  DiagonalBrick,
  /// <summary>
  ///   Solid Diamond.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.SolidDiamond))]
  SolidDiamond,
  /// <summary>
  ///   Open Diamond.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.OpenDiamond))]
  OpenDiamond,
  /// <summary>
  ///   Dotted Diamond.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.DottedDiamond))]
  DottedDiamond,
  /// <summary>
  ///   Plaid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Plaid))]
  Plaid,
  /// <summary>
  ///   Sphere.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Sphere))]
  Sphere,
  /// <summary>
  ///   Weave.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Weave))]
  Weave,
  /// <summary>
  ///   Divot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Divot))]
  Divot,
  /// <summary>
  ///   Shingle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Shingle))]
  Shingle,
  /// <summary>
  ///   Wave.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Wave))]
  Wave,
  /// <summary>
  ///   Trellis.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.Trellis))]
  Trellis,
  /// <summary>
  ///   Zig Zag.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.PresetPatternValues.ZigZag))]
  ZigZag
}