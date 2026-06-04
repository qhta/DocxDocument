namespace DocumentModel.Drawings;
/// <summary>
///   Preset Pattern Value
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.PresetPatternValues))]
public enum PresetPattern
{
  /// <summary>
  ///   5%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Percent5))]
  Percent5 = 1,

  /// <summary>
  ///   10%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Percent10))]
  Percent10,
  /// <summary>
  ///   20%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Percent20))]
  Percent20,
  /// <summary>
  ///   25%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Percent25))]
  Percent25,
  /// <summary>
  ///   30%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Percent30))]
  Percent30,
  /// <summary>
  ///   40%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Percent40))]
  Percent40,
  /// <summary>
  ///   50%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Percent50))]
  Percent50,
  /// <summary>
  ///   60%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Percent60))]
  Percent60,
  /// <summary>
  ///   70%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Percent70))]
  Percent70,
  /// <summary>
  ///   75%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Percent75))]
  Percent75,
  /// <summary>
  ///   80%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Percent80))]
  Percent80,
  /// <summary>
  ///   90%.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Percent90))]
  Percent90,
  /// <summary>
  ///   Horizontal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Horizontal))]
  Horizontal,
  /// <summary>
  ///   Vertical.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Vertical))]
  Vertical,
  /// <summary>
  ///   Light Horizontal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.LightHorizontal))]
  LightHorizontal,
  /// <summary>
  ///   Light Vertical.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.LightVertical))]
  LightVertical,
  /// <summary>
  ///   Dark Horizontal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.DarkHorizontal))]
  DarkHorizontal,
  /// <summary>
  ///   Dark Vertical.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.DarkVertical))]
  DarkVertical,
  /// <summary>
  ///   Narrow Horizontal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.NarrowHorizontal))]
  NarrowHorizontal,
  /// <summary>
  ///   Narrow Vertical.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.NarrowVertical))]
  NarrowVertical,
  /// <summary>
  ///   Dashed Horizontal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.DashedHorizontal))]
  DashedHorizontal,
  /// <summary>
  ///   Dashed Vertical.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.DashedVertical))]
  DashedVertical,
  /// <summary>
  ///   Cross.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Cross))]
  Cross,
  /// <summary>
  ///   Downward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.DownwardDiagonal))]
  DownwardDiagonal,
  /// <summary>
  ///   Upward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.UpwardDiagonal))]
  UpwardDiagonal,
  /// <summary>
  ///   Light Downward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.LightDownwardDiagonal))]
  LightDownwardDiagonal,
  /// <summary>
  ///   Light Upward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.LightUpwardDiagonal))]
  LightUpwardDiagonal,
  /// <summary>
  ///   Dark Downward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.DarkDownwardDiagonal))]
  DarkDownwardDiagonal,
  /// <summary>
  ///   Dark Upward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.DarkUpwardDiagonal))]
  DarkUpwardDiagonal,
  /// <summary>
  ///   Wide Downward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.WideDownwardDiagonal))]
  WideDownwardDiagonal,
  /// <summary>
  ///   Wide Upward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.WideUpwardDiagonal))]
  WideUpwardDiagonal,
  /// <summary>
  ///   Dashed Downward Diagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.DashedDownwardDiagonal))]
  DashedDownwardDiagonal,
  /// <summary>
  ///   Dashed Upward DIagonal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.DashedUpwardDiagonal))]
  DashedUpwardDiagonal,
  /// <summary>
  ///   Diagonal Cross.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.DiagonalCross))]
  DiagonalCross,
  /// <summary>
  ///   Small Checker Board.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.SmallCheck))]
  SmallCheck,
  /// <summary>
  ///   Large Checker Board.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.LargeCheck))]
  LargeCheck,
  /// <summary>
  ///   Small Grid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.SmallGrid))]
  SmallGrid,
  /// <summary>
  ///   Large Grid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.LargeGrid))]
  LargeGrid,
  /// <summary>
  ///   Dotted Grid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.DotGrid))]
  DotGrid,
  /// <summary>
  ///   Small Confetti.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.SmallConfetti))]
  SmallConfetti,
  /// <summary>
  ///   Large Confetti.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.LargeConfetti))]
  LargeConfetti,
  /// <summary>
  ///   Horizontal Brick.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.HorizontalBrick))]
  HorizontalBrick,
  /// <summary>
  ///   Diagonal Brick.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.DiagonalBrick))]
  DiagonalBrick,
  /// <summary>
  ///   Solid Diamond.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.SolidDiamond))]
  SolidDiamond,
  /// <summary>
  ///   Open Diamond.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.OpenDiamond))]
  OpenDiamond,
  /// <summary>
  ///   Dotted Diamond.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.DottedDiamond))]
  DottedDiamond,
  /// <summary>
  ///   Plaid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Plaid))]
  Plaid,
  /// <summary>
  ///   Sphere.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Sphere))]
  Sphere,
  /// <summary>
  ///   Weave.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Weave))]
  Weave,
  /// <summary>
  ///   Divot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Divot))]
  Divot,
  /// <summary>
  ///   Shingle.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Shingle))]
  Shingle,
  /// <summary>
  ///   Wave.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Wave))]
  Wave,
  /// <summary>
  ///   Trellis.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.Trellis))]
  Trellis,
  /// <summary>
  ///   Zig Zag.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.PresetPatternValues.ZigZag))]
  ZigZag
}