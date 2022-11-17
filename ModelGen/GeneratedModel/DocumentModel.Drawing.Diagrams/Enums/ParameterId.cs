namespace DocumentModel.Drawing.Diagrams;

public enum ParameterId
{
  
  [XmlEnum("horzAlign")]
  HorizontalAlignment,
  
  [XmlEnum("vertAlign")]
  VerticalAlignment,
  
  [XmlEnum("chDir")]
  ChildDirection,
  
  [XmlEnum("chAlign")]
  ChildAlignment,
  
  [XmlEnum("secChAlign")]
  SecondaryChildAlignment,
  
  [XmlEnum("linDir")]
  LinearDirection,
  
  [XmlEnum("secLinDir")]
  SecondaryLinearDirection,
  
  [XmlEnum("stElem")]
  StartElement,
  
  [XmlEnum("bendPt")]
  BendPoint,
  
  [XmlEnum("connRout")]
  ConnectionRoute,
  
  [XmlEnum("begSty")]
  BeginningArrowheadStyle,
  
  [XmlEnum("endSty")]
  EndStyle,
  
  [XmlEnum("dim")]
  ConnectorDimension,
  
  [XmlEnum("rotPath")]
  RotationPath,
  
  [XmlEnum("ctrShpMap")]
  CenterShapeMapping,
  
  [XmlEnum("nodeHorzAlign")]
  NodeHorizontalAlignment,
  
  [XmlEnum("nodeVertAlign")]
  NodeVerticalAlignment,
  
  [XmlEnum("fallback")]
  FallbackScale,
  
  [XmlEnum("txDir")]
  TextDirection,
  
  [XmlEnum("pyraAcctPos")]
  PyramidAccentPosition,
  
  [XmlEnum("pyraAcctTxMar")]
  PyramidAccentTextMargin,
  
  [XmlEnum("txBlDir")]
  TextBlockDirection,
  
  [XmlEnum("txAnchorHorz")]
  TextAnchorHorizontal,
  
  [XmlEnum("txAnchorVert")]
  TextAnchorVertical,
  
  [XmlEnum("txAnchorHorzCh")]
  TextAnchorHorizontalWithChildren,
  
  [XmlEnum("txAnchorVertCh")]
  TextAnchorVerticalWithChildren,
  
  [XmlEnum("parTxLTRAlign")]
  ParentTextLeftToRightAlignment,
  
  [XmlEnum("parTxRTLAlign")]
  ParentTextRightToLeftAlignment,
  
  [XmlEnum("shpTxLTRAlignCh")]
  ShapeTextLeftToRightAlignment,
  
  [XmlEnum("shpTxRTLAlignCh")]
  ShapeTextRightToLeftAlignment,
  
  [XmlEnum("autoTxRot")]
  AutoTextRotation,
  
  [XmlEnum("grDir")]
  GrowDirection,
  
  [XmlEnum("flowDir")]
  FlowDirection,
  
  [XmlEnum("contDir")]
  ContinueDirection,
  
  [XmlEnum("bkpt")]
  Breakpoint,
  
  [XmlEnum("off")]
  Offset,
  
  [XmlEnum("hierAlign")]
  HierarchyAlignment,
  
  [XmlEnum("bkPtFixedVal")]
  BreakpointFixedValue,
  
  [XmlEnum("stBulletLvl")]
  StartBulletsAtLevel,
  
  [XmlEnum("stAng")]
  StartAngle,
  
  [XmlEnum("spanAng")]
  SpanAngle,
  
  [XmlEnum("ar")]
  AspectRatio,
  
  [XmlEnum("lnSpPar")]
  LineSpacingParent,
  
  [XmlEnum("lnSpAfParP")]
  LineSpacingAfterParentParagraph,
  
  [XmlEnum("lnSpCh")]
  LineSpacingChildren,
  
  [XmlEnum("lnSpAfChP")]
  LineSpacingAfterChildrenParagraph,
  
  [XmlEnum("rtShortDist")]
  RouteShortestDistance,
  
  [XmlEnum("alignTx")]
  TextAlignment,
  
  [XmlEnum("pyraLvlNode")]
  PyramidLevelNode,
  
  [XmlEnum("pyraAcctBkgdNode")]
  PyramidAccentBackgroundNode,
  
  [XmlEnum("pyraAcctTxNode")]
  PyramidAccentTextNode,
  
  [XmlEnum("srcNode")]
  SourceNode,
  
  [XmlEnum("dstNode")]
  DestinationNode,
  
  [XmlEnum("begPts")]
  BeginningPoints,
  
  [XmlEnum("endPts")]
  EndPoints,
}
