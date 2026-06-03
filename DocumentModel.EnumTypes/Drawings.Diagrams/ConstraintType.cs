namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the Constraint enumeration.
/// Used in types such as AddOpenXmlElementAttribute, AddOpenXmlPropertyAttribute, AnalyzeHelper.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDD.ConstraintValues))]
public enum ConstraintType
{
  /// <summary>
  ///   Unknown.
  /// </summary>
  [OpenXmlEnumValue("None")]
  None,
  /// <summary>
  ///   Alignment Offset.
  /// </summary>
  [OpenXmlEnumValue("AlignmentOffset")]
  AlignmentOffset,
  /// <summary>
  ///   Beginning Margin.
  /// </summary>
  [OpenXmlEnumValue("BeginningMargin")]
  BeginningMargin,
  /// <summary>
  ///   Bending Distance.
  /// </summary>
  [OpenXmlEnumValue("BendingDistance")]
  BendingDistance,
  /// <summary>
  ///   Beginning Padding.
  /// </summary>
  [OpenXmlEnumValue("BeginningPadding")]
  BeginningPadding,
  /// <summary>
  ///   Bottom.
  /// </summary>
  [OpenXmlEnumValue("Bottom")]
  Bottom,
  /// <summary>
  ///   Bottom Margin.
  /// </summary>
  [OpenXmlEnumValue("BottomMargin")]
  BottomMargin,
  /// <summary>
  ///   Bottom Offset.
  /// </summary>
  [OpenXmlEnumValue("BottomOffset")]
  BottomOffset,
  /// <summary>
  ///   Center Height.
  /// </summary>
  [OpenXmlEnumValue("CenterHeight")]
  CenterHeight,
  /// <summary>
  ///   Center X Offset.
  /// </summary>
  [OpenXmlEnumValue("CenterXOffset")]
  CenterXOffset,
  /// <summary>
  ///   Center Width.
  /// </summary>
  [OpenXmlEnumValue("CenterWidth")]
  CenterWidth,
  /// <summary>
  ///   Center Y Offset.
  /// </summary>
  [OpenXmlEnumValue("CenterYOffset")]
  CenterYOffset,
  /// <summary>
  ///   Connection Distance.
  /// </summary>
  [OpenXmlEnumValue("ConnectionDistance")]
  ConnectionDistance,
  /// <summary>
  ///   Diameter.
  /// </summary>
  [OpenXmlEnumValue("Diameter")]
  Diameter,
  /// <summary>
  ///   End Margin.
  /// </summary>
  [OpenXmlEnumValue("EndMargin")]
  EndMargin,
  /// <summary>
  ///   End Padding.
  /// </summary>
  [OpenXmlEnumValue("EndPadding")]
  EndPadding,
  /// <summary>
  ///   Height.
  /// </summary>
  [OpenXmlEnumValue("Height")]
  Height,
  /// <summary>
  ///   Arrowhead Height.
  /// </summary>
  [OpenXmlEnumValue("ArrowheadHeight")]
  ArrowheadHeight,
  /// <summary>
  ///   Height Offset.
  /// </summary>
  [OpenXmlEnumValue("HeightOffset")]
  HeightOffset,
  /// <summary>
  ///   Left.
  /// </summary>
  [OpenXmlEnumValue("Left")]
  Left,
  /// <summary>
  ///   Left Margin.
  /// </summary>
  [OpenXmlEnumValue("LeftMargin")]
  LeftMargin,
  /// <summary>
  ///   Left Offset.
  /// </summary>
  [OpenXmlEnumValue("LeftOffset")]
  LeftOffset,
  /// <summary>
  ///   Right.
  /// </summary>
  [OpenXmlEnumValue("Right")]
  Right,
  /// <summary>
  ///   Right Margin.
  /// </summary>
  [OpenXmlEnumValue("RightMargin")]
  RightMargin,
  /// <summary>
  ///   Right Offset.
  /// </summary>
  [OpenXmlEnumValue("RightOffset")]
  RightOffset,
  /// <summary>
  ///   Primary IFont Size.
  /// </summary>
  [OpenXmlEnumValue("PrimaryFontSize")]
  PrimaryFontSize,
  /// <summary>
  ///   Pyramid Accent Ratio.
  /// </summary>
  [OpenXmlEnumValue("PyramidAccentRatio")]
  PyramidAccentRatio,
  /// <summary>
  ///   Secondary IFont Size.
  /// </summary>
  [OpenXmlEnumValue("SecondaryFontSize")]
  SecondaryFontSize,
  /// <summary>
  ///   Sibling Spacing.
  /// </summary>
  [OpenXmlEnumValue("SiblingSpacing")]
  SiblingSpacing,
  /// <summary>
  ///   Secondary Sibling Spacing.
  /// </summary>
  [OpenXmlEnumValue("SecondarySiblingSpacing")]
  SecondarySiblingSpacing,
  /// <summary>
  ///   Spacing.
  /// </summary>
  [OpenXmlEnumValue("Spacing")]
  Spacing,
  /// <summary>
  ///   Stem Thickness.
  /// </summary>
  [OpenXmlEnumValue("StemThickness")]
  StemThickness,
  /// <summary>
  ///   Top.
  /// </summary>
  [OpenXmlEnumValue("Top")]
  Top,
  /// <summary>
  ///   Top Margin.
  /// </summary>
  [OpenXmlEnumValue("TopMargin")]
  TopMargin,
  /// <summary>
  ///   Top Offset.
  /// </summary>
  [OpenXmlEnumValue("TopOffset")]
  TopOffset,
  /// <summary>
  ///   User Defined A.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedA")]
  UserDefinedA,
  /// <summary>
  ///   User Defined B.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedB")]
  UserDefinedB,
  /// <summary>
  ///   User Defined C.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedC")]
  UserDefinedC,
  /// <summary>
  ///   User Defined D.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedD")]
  UserDefinedD,
  /// <summary>
  ///   User Defined E.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedE")]
  UserDefinedE,
  /// <summary>
  ///   User Defined F.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedF")]
  UserDefinedF,
  /// <summary>
  ///   User Defined G.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedG")]
  UserDefinedG,
  /// <summary>
  ///   User Defined H.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedH")]
  UserDefinedH,
  /// <summary>
  ///   User Defined I.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedI")]
  UserDefinedI,
  /// <summary>
  ///   User Defined J.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedJ")]
  UserDefinedJ,
  /// <summary>
  ///   User Defined K.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedK")]
  UserDefinedK,
  /// <summary>
  ///   User Defined L.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedL")]
  UserDefinedL,
  /// <summary>
  ///   User Defined M.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedM")]
  UserDefinedM,
  /// <summary>
  ///   User Defined N.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedN")]
  UserDefinedN,
  /// <summary>
  ///   User Defined O.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedO")]
  UserDefinedO,
  /// <summary>
  ///   User Defined P.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedP")]
  UserDefinedP,
  /// <summary>
  ///   User Defined Q.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedQ")]
  UserDefinedQ,
  /// <summary>
  ///   User Defined R.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedR")]
  UserDefinedR,
  /// <summary>
  ///   User Defined S.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedS")]
  UserDefinedS,
  /// <summary>
  ///   User Defined T.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedT")]
  UserDefinedT,
  /// <summary>
  ///   User Defined U.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedU")]
  UserDefinedU,
  /// <summary>
  ///   User Defined V.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedV")]
  UserDefinedV,
  /// <summary>
  ///   User Defined W.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedW")]
  UserDefinedW,
  /// <summary>
  ///   User Defined X.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedX")]
  UserDefinedX,
  /// <summary>
  ///   User Defined Y.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedY")]
  UserDefinedY,
  /// <summary>
  ///   User Defined Z.
  /// </summary>
  [OpenXmlEnumValue("UserDefinedZ")]
  UserDefinedZ,
  /// <summary>
  ///   Width.
  /// </summary>
  [OpenXmlEnumValue("Width")]
  Width,
  /// <summary>
  ///   Arrowhead Width.
  /// </summary>
  [OpenXmlEnumValue("ArrowheadWidth")]
  ArrowheadWidth,
  /// <summary>
  ///   Width Offset.
  /// </summary>
  [OpenXmlEnumValue("WidthOffset")]
  WidthOffset
}

