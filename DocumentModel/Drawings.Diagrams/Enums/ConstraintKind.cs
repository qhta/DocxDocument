namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Constraint Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ConstraintKind
{
  /// <summary>
  ///   Unknown.
  /// </summary>
  None,

  /// <summary>
  ///   Alignment Offset.
  /// </summary>
  AlignmentOffset,

  /// <summary>
  ///   Beginning Margin.
  /// </summary>
  BeginningMargin,

  /// <summary>
  ///   Bending Distance.
  /// </summary>
  BendingDistance,

  /// <summary>
  ///   Beginning Padding.
  /// </summary>
  BeginningPadding,

  /// <summary>
  ///   Bottom.
  /// </summary>
  Bottom,

  /// <summary>
  ///   Bottom Margin.
  /// </summary>
  BottomMargin,

  /// <summary>
  ///   Bottom Offset.
  /// </summary>
  BottomOffset,

  /// <summary>
  ///   Center Height.
  /// </summary>
  CenterHeight,

  /// <summary>
  ///   Center X Offset.
  /// </summary>
  CenterXOffset,

  /// <summary>
  ///   Center Width.
  /// </summary>
  CenterWidth,

  /// <summary>
  ///   Center Y Offset.
  /// </summary>
  CenterYOffset,

  /// <summary>
  ///   Connection Distance.
  /// </summary>
  ConnectionDistance,

  /// <summary>
  ///   Diameter.
  /// </summary>
  Diameter,

  /// <summary>
  ///   End Margin.
  /// </summary>
  EndMargin,

  /// <summary>
  ///   End Padding.
  /// </summary>
  EndPadding,

  /// <summary>
  ///   Height.
  /// </summary>
  Height,

  /// <summary>
  ///   Arrowhead Height.
  /// </summary>
  ArrowheadHeight,

  /// <summary>
  ///   Height Offset.
  /// </summary>
  HeightOffset,

  /// <summary>
  ///   Left.
  /// </summary>
  Left,

  /// <summary>
  ///   Left Margin.
  /// </summary>
  LeftMargin,

  /// <summary>
  ///   Left Offset.
  /// </summary>
  LeftOffset,

  /// <summary>
  ///   Right.
  /// </summary>
  Right,

  /// <summary>
  ///   Right Margin.
  /// </summary>
  RightMargin,

  /// <summary>
  ///   Right Offset.
  /// </summary>
  RightOffset,

  /// <summary>
  ///   Primary Font Size.
  /// </summary>
  PrimaryFontSize,

  /// <summary>
  ///   Pyramid Accent Ratio.
  /// </summary>
  PyramidAccentRatio,

  /// <summary>
  ///   Secondary Font Size.
  /// </summary>
  SecondaryFontSize,

  /// <summary>
  ///   Sibling Spacing.
  /// </summary>
  SiblingSpacing,

  /// <summary>
  ///   Secondary Sibling Spacing.
  /// </summary>
  SecondarySiblingSpacing,

  /// <summary>
  ///   Spacing.
  /// </summary>
  Spacing,

  /// <summary>
  ///   Stem Thickness.
  /// </summary>
  StemThickness,

  /// <summary>
  ///   Top.
  /// </summary>
  Top,

  /// <summary>
  ///   Top Margin.
  /// </summary>
  TopMargin,

  /// <summary>
  ///   Top Offset.
  /// </summary>
  TopOffset,

  /// <summary>
  ///   User Defined A.
  /// </summary>
  UserDefinedA,

  /// <summary>
  ///   User Defined B.
  /// </summary>
  UserDefinedB,

  /// <summary>
  ///   User Defined C.
  /// </summary>
  UserDefinedC,

  /// <summary>
  ///   User Defined D.
  /// </summary>
  UserDefinedD,

  /// <summary>
  ///   User Defined E.
  /// </summary>
  UserDefinedE,

  /// <summary>
  ///   User Defined F.
  /// </summary>
  UserDefinedF,

  /// <summary>
  ///   User Defined G.
  /// </summary>
  UserDefinedG,

  /// <summary>
  ///   User Defined H.
  /// </summary>
  UserDefinedH,

  /// <summary>
  ///   User Defined I.
  /// </summary>
  UserDefinedI,

  /// <summary>
  ///   User Defined J.
  /// </summary>
  UserDefinedJ,

  /// <summary>
  ///   User Defined K.
  /// </summary>
  UserDefinedK,

  /// <summary>
  ///   User Defined L.
  /// </summary>
  UserDefinedL,

  /// <summary>
  ///   User Defined M.
  /// </summary>
  UserDefinedM,

  /// <summary>
  ///   User Defined N.
  /// </summary>
  UserDefinedN,

  /// <summary>
  ///   User Defined O.
  /// </summary>
  UserDefinedO,

  /// <summary>
  ///   User Defined P.
  /// </summary>
  UserDefinedP,

  /// <summary>
  ///   User Defined Q.
  /// </summary>
  UserDefinedQ,

  /// <summary>
  ///   User Defined R.
  /// </summary>
  UserDefinedR,

  /// <summary>
  ///   User Defined S.
  /// </summary>
  UserDefinedS,

  /// <summary>
  ///   User Defined T.
  /// </summary>
  UserDefinedT,

  /// <summary>
  ///   User Defined U.
  /// </summary>
  UserDefinedU,

  /// <summary>
  ///   User Defined V.
  /// </summary>
  UserDefinedV,

  /// <summary>
  ///   User Defined W.
  /// </summary>
  UserDefinedW,

  /// <summary>
  ///   User Defined X.
  /// </summary>
  UserDefinedX,

  /// <summary>
  ///   User Defined Y.
  /// </summary>
  UserDefinedY,

  /// <summary>
  ///   User Defined Z.
  /// </summary>
  UserDefinedZ,

  /// <summary>
  ///   Width.
  /// </summary>
  Width,

  /// <summary>
  ///   Arrowhead Width.
  /// </summary>
  ArrowheadWidth,

  /// <summary>
  ///   Width Offset.
  /// </summary>
  WidthOffset
}