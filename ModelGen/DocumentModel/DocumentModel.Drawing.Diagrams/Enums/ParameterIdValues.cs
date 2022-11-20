namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Parameter Identifier
/// </summary>
public enum ParameterIdValues
{
  /// <summary>
  /// Horizontal Alignment.
  /// </summary>
  [XmlEnum("horzAlign")]
  HorizontalAlignment,
  
  /// <summary>
  /// Vertical Alignment.
  /// </summary>
  [XmlEnum("vertAlign")]
  VerticalAlignment,
  
  /// <summary>
  /// Child Direction.
  /// </summary>
  [XmlEnum("chDir")]
  ChildDirection,
  
  /// <summary>
  /// Child Alignment.
  /// </summary>
  [XmlEnum("chAlign")]
  ChildAlignment,
  
  /// <summary>
  /// Secondary Child Alignment.
  /// </summary>
  [XmlEnum("secChAlign")]
  SecondaryChildAlignment,
  
  /// <summary>
  /// Linear Direction.
  /// </summary>
  [XmlEnum("linDir")]
  LinearDirection,
  
  /// <summary>
  /// Secondary Linear Direction.
  /// </summary>
  [XmlEnum("secLinDir")]
  SecondaryLinearDirection,
  
  /// <summary>
  /// Start Element.
  /// </summary>
  [XmlEnum("stElem")]
  StartElement,
  
  /// <summary>
  /// Bend Point.
  /// </summary>
  [XmlEnum("bendPt")]
  BendPoint,
  
  /// <summary>
  /// Connection Route.
  /// </summary>
  [XmlEnum("connRout")]
  ConnectionRoute,
  
  /// <summary>
  /// Beginning Arrowhead Style.
  /// </summary>
  [XmlEnum("begSty")]
  BeginningArrowheadStyle,
  
  /// <summary>
  /// End Style.
  /// </summary>
  [XmlEnum("endSty")]
  EndStyle,
  
  /// <summary>
  /// Connector Dimension.
  /// </summary>
  [XmlEnum("dim")]
  ConnectorDimension,
  
  /// <summary>
  /// Rotation Path.
  /// </summary>
  [XmlEnum("rotPath")]
  RotationPath,
  
  /// <summary>
  /// Center Shape Mapping.
  /// </summary>
  [XmlEnum("ctrShpMap")]
  CenterShapeMapping,
  
  /// <summary>
  /// Node Horizontal Alignment.
  /// </summary>
  [XmlEnum("nodeHorzAlign")]
  NodeHorizontalAlignment,
  
  /// <summary>
  /// Node Vertical Alignment.
  /// </summary>
  [XmlEnum("nodeVertAlign")]
  NodeVerticalAlignment,
  
  /// <summary>
  /// Fallback Scale.
  /// </summary>
  [XmlEnum("fallback")]
  FallbackScale,
  
  /// <summary>
  /// Text Direction.
  /// </summary>
  [XmlEnum("txDir")]
  TextDirection,
  
  /// <summary>
  /// Pyramid Accent Position.
  /// </summary>
  [XmlEnum("pyraAcctPos")]
  PyramidAccentPosition,
  
  /// <summary>
  /// Pyramid Accent Text Margin.
  /// </summary>
  [XmlEnum("pyraAcctTxMar")]
  PyramidAccentTextMargin,
  
  /// <summary>
  /// Text Block Direction.
  /// </summary>
  [XmlEnum("txBlDir")]
  TextBlockDirection,
  
  /// <summary>
  /// Text Anchor Horizontal.
  /// </summary>
  [XmlEnum("txAnchorHorz")]
  TextAnchorHorizontal,
  
  /// <summary>
  /// Text Anchor Vertical.
  /// </summary>
  [XmlEnum("txAnchorVert")]
  TextAnchorVertical,
  
  /// <summary>
  /// Text Anchor Horizontal With Children.
  /// </summary>
  [XmlEnum("txAnchorHorzCh")]
  TextAnchorHorizontalWithChildren,
  
  /// <summary>
  /// Text Anchor Vertical With Children.
  /// </summary>
  [XmlEnum("txAnchorVertCh")]
  TextAnchorVerticalWithChildren,
  
  /// <summary>
  /// Parent Text Left-to-Right Alignment.
  /// </summary>
  [XmlEnum("parTxLTRAlign")]
  ParentTextLeftToRightAlignment,
  
  /// <summary>
  /// Parent Text Right-to-Left Alignment.
  /// </summary>
  [XmlEnum("parTxRTLAlign")]
  ParentTextRightToLeftAlignment,
  
  /// <summary>
  /// Shape Text Left-to-Right Alignment.
  /// </summary>
  [XmlEnum("shpTxLTRAlignCh")]
  ShapeTextLeftToRightAlignment,
  
  /// <summary>
  /// Shape Text Right-to-Left Alignment.
  /// </summary>
  [XmlEnum("shpTxRTLAlignCh")]
  ShapeTextRightToLeftAlignment,
  
  /// <summary>
  /// Auto Text Rotation.
  /// </summary>
  [XmlEnum("autoTxRot")]
  AutoTextRotation,
  
  /// <summary>
  /// Grow Direction.
  /// </summary>
  [XmlEnum("grDir")]
  GrowDirection,
  
  /// <summary>
  /// Flow Direction.
  /// </summary>
  [XmlEnum("flowDir")]
  FlowDirection,
  
  /// <summary>
  /// Continue Direction.
  /// </summary>
  [XmlEnum("contDir")]
  ContinueDirection,
  
  /// <summary>
  /// Breakpoint.
  /// </summary>
  [XmlEnum("bkpt")]
  Breakpoint,
  
  /// <summary>
  /// Offset.
  /// </summary>
  [XmlEnum("off")]
  Offset,
  
  /// <summary>
  /// Hierarchy Alignment.
  /// </summary>
  [XmlEnum("hierAlign")]
  HierarchyAlignment,
  
  /// <summary>
  /// Breakpoint Fixed Value.
  /// </summary>
  [XmlEnum("bkPtFixedVal")]
  BreakpointFixedValue,
  
  /// <summary>
  /// Start Bullets At Level.
  /// </summary>
  [XmlEnum("stBulletLvl")]
  StartBulletsAtLevel,
  
  /// <summary>
  /// Start Angle.
  /// </summary>
  [XmlEnum("stAng")]
  StartAngle,
  
  /// <summary>
  /// Span Angle.
  /// </summary>
  [XmlEnum("spanAng")]
  SpanAngle,
  
  /// <summary>
  /// Aspect Ratio.
  /// </summary>
  [XmlEnum("ar")]
  AspectRatio,
  
  /// <summary>
  /// Line Spacing Parent.
  /// </summary>
  [XmlEnum("lnSpPar")]
  LineSpacingParent,
  
  /// <summary>
  /// Line Spacing After Parent Paragraph.
  /// </summary>
  [XmlEnum("lnSpAfParP")]
  LineSpacingAfterParentParagraph,
  
  /// <summary>
  /// Line Spacing Children.
  /// </summary>
  [XmlEnum("lnSpCh")]
  LineSpacingChildren,
  
  /// <summary>
  /// Line Spacing After Children Paragraph.
  /// </summary>
  [XmlEnum("lnSpAfChP")]
  LineSpacingAfterChildrenParagraph,
  
  /// <summary>
  /// Route Shortest Distance.
  /// </summary>
  [XmlEnum("rtShortDist")]
  RouteShortestDistance,
  
  /// <summary>
  /// Text Alignment.
  /// </summary>
  [XmlEnum("alignTx")]
  TextAlignment,
  
  /// <summary>
  /// Pyramid Level Node.
  /// </summary>
  [XmlEnum("pyraLvlNode")]
  PyramidLevelNode,
  
  /// <summary>
  /// Pyramid Accent Background Node.
  /// </summary>
  [XmlEnum("pyraAcctBkgdNode")]
  PyramidAccentBackgroundNode,
  
  /// <summary>
  /// Pyramid Accent Text Node.
  /// </summary>
  [XmlEnum("pyraAcctTxNode")]
  PyramidAccentTextNode,
  
  /// <summary>
  /// Source Node.
  /// </summary>
  [XmlEnum("srcNode")]
  SourceNode,
  
  /// <summary>
  /// Destination Node.
  /// </summary>
  [XmlEnum("dstNode")]
  DestinationNode,
  
  /// <summary>
  /// Beginning Points.
  /// </summary>
  [XmlEnum("begPts")]
  BeginningPoints,
  
  /// <summary>
  /// End Points.
  /// </summary>
  [XmlEnum("endPts")]
  EndPoints,
  
}
