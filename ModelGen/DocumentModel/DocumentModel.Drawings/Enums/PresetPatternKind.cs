namespace DocumentModel.Drawings;

/// <summary>
/// Preset Pattern Value
/// </summary>
public enum PresetPatternKind
{
  /// <summary>
  /// 5%.
  /// </summary>
  [XmlEnum("pct5")]
  Percent5,
  
  /// <summary>
  /// 10%.
  /// </summary>
  [XmlEnum("pct10")]
  Percent10,
  
  /// <summary>
  /// 20%.
  /// </summary>
  [XmlEnum("pct20")]
  Percent20,
  
  /// <summary>
  /// 25%.
  /// </summary>
  [XmlEnum("pct25")]
  Percent25,
  
  /// <summary>
  /// 30%.
  /// </summary>
  [XmlEnum("pct30")]
  Percent30,
  
  /// <summary>
  /// 40%.
  /// </summary>
  [XmlEnum("pct40")]
  Percent40,
  
  /// <summary>
  /// 50%.
  /// </summary>
  [XmlEnum("pct50")]
  Percent50,
  
  /// <summary>
  /// 60%.
  /// </summary>
  [XmlEnum("pct60")]
  Percent60,
  
  /// <summary>
  /// 70%.
  /// </summary>
  [XmlEnum("pct70")]
  Percent70,
  
  /// <summary>
  /// 75%.
  /// </summary>
  [XmlEnum("pct75")]
  Percent75,
  
  /// <summary>
  /// 80%.
  /// </summary>
  [XmlEnum("pct80")]
  Percent80,
  
  /// <summary>
  /// 90%.
  /// </summary>
  [XmlEnum("pct90")]
  Percent90,
  
  /// <summary>
  /// Horizontal.
  /// </summary>
  [XmlEnum("horz")]
  Horizontal,
  
  /// <summary>
  /// Vertical.
  /// </summary>
  [XmlEnum("vert")]
  Vertical,
  
  /// <summary>
  /// Light Horizontal.
  /// </summary>
  [XmlEnum("ltHorz")]
  LightHorizontal,
  
  /// <summary>
  /// Light Vertical.
  /// </summary>
  [XmlEnum("ltVert")]
  LightVertical,
  
  /// <summary>
  /// Dark Horizontal.
  /// </summary>
  [XmlEnum("dkHorz")]
  DarkHorizontal,
  
  /// <summary>
  /// Dark Vertical.
  /// </summary>
  [XmlEnum("dkVert")]
  DarkVertical,
  
  /// <summary>
  /// Narrow Horizontal.
  /// </summary>
  [XmlEnum("narHorz")]
  NarrowHorizontal,
  
  /// <summary>
  /// Narrow Vertical.
  /// </summary>
  [XmlEnum("narVert")]
  NarrowVertical,
  
  /// <summary>
  /// Dashed Horizontal.
  /// </summary>
  [XmlEnum("dashHorz")]
  DashedHorizontal,
  
  /// <summary>
  /// Dashed Vertical.
  /// </summary>
  [XmlEnum("dashVert")]
  DashedVertical,
  
  /// <summary>
  /// Cross.
  /// </summary>
  [XmlEnum("cross")]
  Cross,
  
  /// <summary>
  /// Downward Diagonal.
  /// </summary>
  [XmlEnum("dnDiag")]
  DownwardDiagonal,
  
  /// <summary>
  /// Upward Diagonal.
  /// </summary>
  [XmlEnum("upDiag")]
  UpwardDiagonal,
  
  /// <summary>
  /// Light Downward Diagonal.
  /// </summary>
  [XmlEnum("ltDnDiag")]
  LightDownwardDiagonal,
  
  /// <summary>
  /// Light Upward Diagonal.
  /// </summary>
  [XmlEnum("ltUpDiag")]
  LightUpwardDiagonal,
  
  /// <summary>
  /// Dark Downward Diagonal.
  /// </summary>
  [XmlEnum("dkDnDiag")]
  DarkDownwardDiagonal,
  
  /// <summary>
  /// Dark Upward Diagonal.
  /// </summary>
  [XmlEnum("dkUpDiag")]
  DarkUpwardDiagonal,
  
  /// <summary>
  /// Wide Downward Diagonal.
  /// </summary>
  [XmlEnum("wdDnDiag")]
  WideDownwardDiagonal,
  
  /// <summary>
  /// Wide Upward Diagonal.
  /// </summary>
  [XmlEnum("wdUpDiag")]
  WideUpwardDiagonal,
  
  /// <summary>
  /// Dashed Downward Diagonal.
  /// </summary>
  [XmlEnum("dashDnDiag")]
  DashedDownwardDiagonal,
  
  /// <summary>
  /// Dashed Upward DIagonal.
  /// </summary>
  [XmlEnum("dashUpDiag")]
  DashedUpwardDiagonal,
  
  /// <summary>
  /// Diagonal Cross.
  /// </summary>
  [XmlEnum("diagCross")]
  DiagonalCross,
  
  /// <summary>
  /// Small Checker Board.
  /// </summary>
  [XmlEnum("smCheck")]
  SmallCheck,
  
  /// <summary>
  /// Large Checker Board.
  /// </summary>
  [XmlEnum("lgCheck")]
  LargeCheck,
  
  /// <summary>
  /// Small Grid.
  /// </summary>
  [XmlEnum("smGrid")]
  SmallGrid,
  
  /// <summary>
  /// Large Grid.
  /// </summary>
  [XmlEnum("lgGrid")]
  LargeGrid,
  
  /// <summary>
  /// Dotted Grid.
  /// </summary>
  [XmlEnum("dotGrid")]
  DotGrid,
  
  /// <summary>
  /// Small Confetti.
  /// </summary>
  [XmlEnum("smConfetti")]
  SmallConfetti,
  
  /// <summary>
  /// Large Confetti.
  /// </summary>
  [XmlEnum("lgConfetti")]
  LargeConfetti,
  
  /// <summary>
  /// Horizontal Brick.
  /// </summary>
  [XmlEnum("horzBrick")]
  HorizontalBrick,
  
  /// <summary>
  /// Diagonal Brick.
  /// </summary>
  [XmlEnum("diagBrick")]
  DiagonalBrick,
  
  /// <summary>
  /// Solid Diamond.
  /// </summary>
  [XmlEnum("solidDmnd")]
  SolidDiamond,
  
  /// <summary>
  /// Open Diamond.
  /// </summary>
  [XmlEnum("openDmnd")]
  OpenDiamond,
  
  /// <summary>
  /// Dotted Diamond.
  /// </summary>
  [XmlEnum("dotDmnd")]
  DottedDiamond,
  
  /// <summary>
  /// Plaid.
  /// </summary>
  [XmlEnum("plaid")]
  Plaid,
  
  /// <summary>
  /// Sphere.
  /// </summary>
  [XmlEnum("sphere")]
  Sphere,
  
  /// <summary>
  /// Weave.
  /// </summary>
  [XmlEnum("weave")]
  Weave,
  
  /// <summary>
  /// Divot.
  /// </summary>
  [XmlEnum("divot")]
  Divot,
  
  /// <summary>
  /// Shingle.
  /// </summary>
  [XmlEnum("shingle")]
  Shingle,
  
  /// <summary>
  /// Wave.
  /// </summary>
  [XmlEnum("wave")]
  Wave,
  
  /// <summary>
  /// Trellis.
  /// </summary>
  [XmlEnum("trellis")]
  Trellis,
  
  /// <summary>
  /// Zig Zag.
  /// </summary>
  [XmlEnum("zigZag")]
  ZigZag,
  
}
