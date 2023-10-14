namespace DocumentModel.Drawings;


/// <summary>
///   Preset Pattern Value
/// </summary>
public enum PresetPatternKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pct5&quot;.
  /// </summary>
  Percent5,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pct10&quot;.
  /// </summary>
  Percent10,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pct20&quot;.
  /// </summary>
  Percent20,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pct25&quot;.
  /// </summary>
  Percent25,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pct30&quot;.
  /// </summary>
  Percent30,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pct40&quot;.
  /// </summary>
  Percent40,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pct50&quot;.
  /// </summary>
  Percent50,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pct60&quot;.
  /// </summary>
  Percent60,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pct70&quot;.
  /// </summary>
  Percent70,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pct75&quot;.
  /// </summary>
  Percent75,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pct80&quot;.
  /// </summary>
  Percent80,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pct90&quot;.
  /// </summary>
  Percent90,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;horz&quot;.
  /// </summary>
  Horizontal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;vert&quot;.
  /// </summary>
  Vertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ltHorz&quot;.
  /// </summary>
  LightHorizontal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ltVert&quot;.
  /// </summary>
  LightVertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dkHorz&quot;.
  /// </summary>
  DarkHorizontal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dkVert&quot;.
  /// </summary>
  DarkVertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;narHorz&quot;.
  /// </summary>
  NarrowHorizontal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;narVert&quot;.
  /// </summary>
  NarrowVertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dashHorz&quot;.
  /// </summary>
  DashedHorizontal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dashVert&quot;.
  /// </summary>
  DashedVertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cross&quot;.
  /// </summary>
  Cross,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dnDiag&quot;.
  /// </summary>
  DownwardDiagonal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;upDiag&quot;.
  /// </summary>
  UpwardDiagonal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ltDnDiag&quot;.
  /// </summary>
  LightDownwardDiagonal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ltUpDiag&quot;.
  /// </summary>
  LightUpwardDiagonal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dkDnDiag&quot;.
  /// </summary>
  DarkDownwardDiagonal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dkUpDiag&quot;.
  /// </summary>
  DarkUpwardDiagonal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wdDnDiag&quot;.
  /// </summary>
  WideDownwardDiagonal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wdUpDiag&quot;.
  /// </summary>
  WideUpwardDiagonal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dashDnDiag&quot;.
  /// </summary>
  DashedDownwardDiagonal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dashUpDiag&quot;.
  /// </summary>
  DashedUpwardDiagonal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;diagCross&quot;.
  /// </summary>
  DiagonalCross,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;smCheck&quot;.
  /// </summary>
  SmallCheck,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lgCheck&quot;.
  /// </summary>
  LargeCheck,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;smGrid&quot;.
  /// </summary>
  SmallGrid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lgGrid&quot;.
  /// </summary>
  LargeGrid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dotGrid&quot;.
  /// </summary>
  DotGrid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;smConfetti&quot;.
  /// </summary>
  SmallConfetti,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lgConfetti&quot;.
  /// </summary>
  LargeConfetti,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;horzBrick&quot;.
  /// </summary>
  HorizontalBrick,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;diagBrick&quot;.
  /// </summary>
  DiagonalBrick,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;solidDmnd&quot;.
  /// </summary>
  SolidDiamond,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;openDmnd&quot;.
  /// </summary>
  OpenDiamond,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dotDmnd&quot;.
  /// </summary>
  DottedDiamond,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;plaid&quot;.
  /// </summary>
  Plaid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sphere&quot;.
  /// </summary>
  Sphere,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;weave&quot;.
  /// </summary>
  Weave,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;divot&quot;.
  /// </summary>
  Divot,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;shingle&quot;.
  /// </summary>
  Shingle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wave&quot;.
  /// </summary>
  Wave,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;trellis&quot;.
  /// </summary>
  Trellis,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;zigZag&quot;.
  /// </summary>
  ZigZag,
  
}
