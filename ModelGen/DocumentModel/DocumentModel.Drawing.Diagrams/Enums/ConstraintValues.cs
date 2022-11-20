namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Constraint Type
/// </summary>
public enum ConstraintValues
{
  /// <summary>
  /// Unknown.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Alignment Offset.
  /// </summary>
  [XmlEnum("alignOff")]
  AlignmentOffset,
  
  /// <summary>
  /// Beginning Margin.
  /// </summary>
  [XmlEnum("begMarg")]
  BeginningMargin,
  
  /// <summary>
  /// Bending Distance.
  /// </summary>
  [XmlEnum("bendDist")]
  BendingDistance,
  
  /// <summary>
  /// Beginning Padding.
  /// </summary>
  [XmlEnum("begPad")]
  BeginningPadding,
  
  /// <summary>
  /// Bottom.
  /// </summary>
  [XmlEnum("b")]
  Bottom,
  
  /// <summary>
  /// Bottom Margin.
  /// </summary>
  [XmlEnum("bMarg")]
  BottomMargin,
  
  /// <summary>
  /// Bottom Offset.
  /// </summary>
  [XmlEnum("bOff")]
  BottomOffset,
  
  /// <summary>
  /// Center Height.
  /// </summary>
  [XmlEnum("ctrX")]
  CenterHeight,
  
  /// <summary>
  /// Center X Offset.
  /// </summary>
  [XmlEnum("ctrXOff")]
  CenterXOffset,
  
  /// <summary>
  /// Center Width.
  /// </summary>
  [XmlEnum("ctrY")]
  CenterWidth,
  
  /// <summary>
  /// Center Y Offset.
  /// </summary>
  [XmlEnum("ctrYOff")]
  CenterYOffset,
  
  /// <summary>
  /// Connection Distance.
  /// </summary>
  [XmlEnum("connDist")]
  ConnectionDistance,
  
  /// <summary>
  /// Diameter.
  /// </summary>
  [XmlEnum("diam")]
  Diameter,
  
  /// <summary>
  /// End Margin.
  /// </summary>
  [XmlEnum("endMarg")]
  EndMargin,
  
  /// <summary>
  /// End Padding.
  /// </summary>
  [XmlEnum("endPad")]
  EndPadding,
  
  /// <summary>
  /// Height.
  /// </summary>
  [XmlEnum("h")]
  Height,
  
  /// <summary>
  /// Arrowhead Height.
  /// </summary>
  [XmlEnum("hArH")]
  ArrowheadHeight,
  
  /// <summary>
  /// Height Offset.
  /// </summary>
  [XmlEnum("hOff")]
  HeightOffset,
  
  /// <summary>
  /// Left.
  /// </summary>
  [XmlEnum("l")]
  Left,
  
  /// <summary>
  /// Left Margin.
  /// </summary>
  [XmlEnum("lMarg")]
  LeftMargin,
  
  /// <summary>
  /// Left Offset.
  /// </summary>
  [XmlEnum("lOff")]
  LeftOffset,
  
  /// <summary>
  /// Right.
  /// </summary>
  [XmlEnum("r")]
  Right,
  
  /// <summary>
  /// Right Margin.
  /// </summary>
  [XmlEnum("rMarg")]
  RightMargin,
  
  /// <summary>
  /// Right Offset.
  /// </summary>
  [XmlEnum("rOff")]
  RightOffset,
  
  /// <summary>
  /// Primary Font Size.
  /// </summary>
  [XmlEnum("primFontSz")]
  PrimaryFontSize,
  
  /// <summary>
  /// Pyramid Accent Ratio.
  /// </summary>
  [XmlEnum("pyraAcctRatio")]
  PyramidAccentRatio,
  
  /// <summary>
  /// Secondary Font Size.
  /// </summary>
  [XmlEnum("secFontSz")]
  SecondaryFontSize,
  
  /// <summary>
  /// Sibling Spacing.
  /// </summary>
  [XmlEnum("sibSp")]
  SiblingSpacing,
  
  /// <summary>
  /// Secondary Sibling Spacing.
  /// </summary>
  [XmlEnum("secSibSp")]
  SecondarySiblingSpacing,
  
  /// <summary>
  /// Spacing.
  /// </summary>
  [XmlEnum("sp")]
  Spacing,
  
  /// <summary>
  /// Stem Thickness.
  /// </summary>
  [XmlEnum("stemThick")]
  StemThickness,
  
  /// <summary>
  /// Top.
  /// </summary>
  [XmlEnum("t")]
  Top,
  
  /// <summary>
  /// Top Margin.
  /// </summary>
  [XmlEnum("tMarg")]
  TopMargin,
  
  /// <summary>
  /// Top Offset.
  /// </summary>
  [XmlEnum("tOff")]
  TopOffset,
  
  /// <summary>
  /// User Defined A.
  /// </summary>
  [XmlEnum("userA")]
  UserDefinedA,
  
  /// <summary>
  /// User Defined B.
  /// </summary>
  [XmlEnum("userB")]
  UserDefinedB,
  
  /// <summary>
  /// User Defined C.
  /// </summary>
  [XmlEnum("userC")]
  UserDefinedC,
  
  /// <summary>
  /// User Defined D.
  /// </summary>
  [XmlEnum("userD")]
  UserDefinedD,
  
  /// <summary>
  /// User Defined E.
  /// </summary>
  [XmlEnum("userE")]
  UserDefinedE,
  
  /// <summary>
  /// User Defined F.
  /// </summary>
  [XmlEnum("userF")]
  UserDefinedF,
  
  /// <summary>
  /// User Defined G.
  /// </summary>
  [XmlEnum("userG")]
  UserDefinedG,
  
  /// <summary>
  /// User Defined H.
  /// </summary>
  [XmlEnum("userH")]
  UserDefinedH,
  
  /// <summary>
  /// User Defined I.
  /// </summary>
  [XmlEnum("userI")]
  UserDefinedI,
  
  /// <summary>
  /// User Defined J.
  /// </summary>
  [XmlEnum("userJ")]
  UserDefinedJ,
  
  /// <summary>
  /// User Defined K.
  /// </summary>
  [XmlEnum("userK")]
  UserDefinedK,
  
  /// <summary>
  /// User Defined L.
  /// </summary>
  [XmlEnum("userL")]
  UserDefinedL,
  
  /// <summary>
  /// User Defined M.
  /// </summary>
  [XmlEnum("userM")]
  UserDefinedM,
  
  /// <summary>
  /// User Defined N.
  /// </summary>
  [XmlEnum("userN")]
  UserDefinedN,
  
  /// <summary>
  /// User Defined O.
  /// </summary>
  [XmlEnum("userO")]
  UserDefinedO,
  
  /// <summary>
  /// User Defined P.
  /// </summary>
  [XmlEnum("userP")]
  UserDefinedP,
  
  /// <summary>
  /// User Defined Q.
  /// </summary>
  [XmlEnum("userQ")]
  UserDefinedQ,
  
  /// <summary>
  /// User Defined R.
  /// </summary>
  [XmlEnum("userR")]
  UserDefinedR,
  
  /// <summary>
  /// User Defined S.
  /// </summary>
  [XmlEnum("userS")]
  UserDefinedS,
  
  /// <summary>
  /// User Defined T.
  /// </summary>
  [XmlEnum("userT")]
  UserDefinedT,
  
  /// <summary>
  /// User Defined U.
  /// </summary>
  [XmlEnum("userU")]
  UserDefinedU,
  
  /// <summary>
  /// User Defined V.
  /// </summary>
  [XmlEnum("userV")]
  UserDefinedV,
  
  /// <summary>
  /// User Defined W.
  /// </summary>
  [XmlEnum("userW")]
  UserDefinedW,
  
  /// <summary>
  /// User Defined X.
  /// </summary>
  [XmlEnum("userX")]
  UserDefinedX,
  
  /// <summary>
  /// User Defined Y.
  /// </summary>
  [XmlEnum("userY")]
  UserDefinedY,
  
  /// <summary>
  /// User Defined Z.
  /// </summary>
  [XmlEnum("userZ")]
  UserDefinedZ,
  
  /// <summary>
  /// Width.
  /// </summary>
  [XmlEnum("w")]
  Width,
  
  /// <summary>
  /// Arrowhead Width.
  /// </summary>
  [XmlEnum("wArH")]
  ArrowheadWidth,
  
  /// <summary>
  /// Width Offset.
  /// </summary>
  [XmlEnum("wOff")]
  WidthOffset,
  
}
