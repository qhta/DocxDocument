namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Constraint Type
/// </summary>
public enum ConstraintKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;alignOff&quot;.
  /// </summary>
  AlignmentOffset,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;begMarg&quot;.
  /// </summary>
  BeginningMargin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bendDist&quot;.
  /// </summary>
  BendingDistance,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;begPad&quot;.
  /// </summary>
  BeginningPadding,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;b&quot;.
  /// </summary>
  Bottom,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bMarg&quot;.
  /// </summary>
  BottomMargin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bOff&quot;.
  /// </summary>
  BottomOffset,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ctrX&quot;.
  /// </summary>
  CenterHeight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ctrXOff&quot;.
  /// </summary>
  CenterXOffset,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ctrY&quot;.
  /// </summary>
  CenterWidth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ctrYOff&quot;.
  /// </summary>
  CenterYOffset,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;connDist&quot;.
  /// </summary>
  ConnectionDistance,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;diam&quot;.
  /// </summary>
  Diameter,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;endMarg&quot;.
  /// </summary>
  EndMargin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;endPad&quot;.
  /// </summary>
  EndPadding,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;h&quot;.
  /// </summary>
  Height,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hArH&quot;.
  /// </summary>
  ArrowheadHeight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hOff&quot;.
  /// </summary>
  HeightOffset,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;l&quot;.
  /// </summary>
  Left,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lMarg&quot;.
  /// </summary>
  LeftMargin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lOff&quot;.
  /// </summary>
  LeftOffset,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;r&quot;.
  /// </summary>
  Right,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rMarg&quot;.
  /// </summary>
  RightMargin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rOff&quot;.
  /// </summary>
  RightOffset,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;primFontSz&quot;.
  /// </summary>
  PrimaryFontSize,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pyraAcctRatio&quot;.
  /// </summary>
  PyramidAccentRatio,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;secFontSz&quot;.
  /// </summary>
  SecondaryFontSize,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sibSp&quot;.
  /// </summary>
  SiblingSpacing,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;secSibSp&quot;.
  /// </summary>
  SecondarySiblingSpacing,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sp&quot;.
  /// </summary>
  Spacing,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;stemThick&quot;.
  /// </summary>
  StemThickness,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;t&quot;.
  /// </summary>
  Top,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tMarg&quot;.
  /// </summary>
  TopMargin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tOff&quot;.
  /// </summary>
  TopOffset,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userA&quot;.
  /// </summary>
  UserDefinedA,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userB&quot;.
  /// </summary>
  UserDefinedB,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userC&quot;.
  /// </summary>
  UserDefinedC,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userD&quot;.
  /// </summary>
  UserDefinedD,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userE&quot;.
  /// </summary>
  UserDefinedE,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userF&quot;.
  /// </summary>
  UserDefinedF,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userG&quot;.
  /// </summary>
  UserDefinedG,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userH&quot;.
  /// </summary>
  UserDefinedH,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userI&quot;.
  /// </summary>
  UserDefinedI,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userJ&quot;.
  /// </summary>
  UserDefinedJ,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userK&quot;.
  /// </summary>
  UserDefinedK,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userL&quot;.
  /// </summary>
  UserDefinedL,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userM&quot;.
  /// </summary>
  UserDefinedM,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userN&quot;.
  /// </summary>
  UserDefinedN,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userO&quot;.
  /// </summary>
  UserDefinedO,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userP&quot;.
  /// </summary>
  UserDefinedP,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userQ&quot;.
  /// </summary>
  UserDefinedQ,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userR&quot;.
  /// </summary>
  UserDefinedR,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userS&quot;.
  /// </summary>
  UserDefinedS,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userT&quot;.
  /// </summary>
  UserDefinedT,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userU&quot;.
  /// </summary>
  UserDefinedU,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userV&quot;.
  /// </summary>
  UserDefinedV,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userW&quot;.
  /// </summary>
  UserDefinedW,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userX&quot;.
  /// </summary>
  UserDefinedX,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userY&quot;.
  /// </summary>
  UserDefinedY,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;userZ&quot;.
  /// </summary>
  UserDefinedZ,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;w&quot;.
  /// </summary>
  Width,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wArH&quot;.
  /// </summary>
  ArrowheadWidth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wOff&quot;.
  /// </summary>
  WidthOffset,
  
}
