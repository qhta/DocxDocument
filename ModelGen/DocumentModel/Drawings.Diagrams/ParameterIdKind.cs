namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Parameter Identifier
/// </summary>
public enum ParameterIdKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;horzAlign&quot;.
  /// </summary>
  HorizontalAlignment,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;vertAlign&quot;.
  /// </summary>
  VerticalAlignment,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chDir&quot;.
  /// </summary>
  ChildDirection,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chAlign&quot;.
  /// </summary>
  ChildAlignment,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;secChAlign&quot;.
  /// </summary>
  SecondaryChildAlignment,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;linDir&quot;.
  /// </summary>
  LinearDirection,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;secLinDir&quot;.
  /// </summary>
  SecondaryLinearDirection,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;stElem&quot;.
  /// </summary>
  StartElement,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bendPt&quot;.
  /// </summary>
  BendPoint,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;connRout&quot;.
  /// </summary>
  ConnectionRoute,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;begSty&quot;.
  /// </summary>
  BeginningArrowheadStyle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;endSty&quot;.
  /// </summary>
  EndStyle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dim&quot;.
  /// </summary>
  ConnectorDimension,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rotPath&quot;.
  /// </summary>
  RotationPath,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ctrShpMap&quot;.
  /// </summary>
  CenterShapeMapping,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;nodeHorzAlign&quot;.
  /// </summary>
  NodeHorizontalAlignment,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;nodeVertAlign&quot;.
  /// </summary>
  NodeVerticalAlignment,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;fallback&quot;.
  /// </summary>
  FallbackScale,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;txDir&quot;.
  /// </summary>
  TextDirection,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pyraAcctPos&quot;.
  /// </summary>
  PyramidAccentPosition,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pyraAcctTxMar&quot;.
  /// </summary>
  PyramidAccentTextMargin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;txBlDir&quot;.
  /// </summary>
  TextBlockDirection,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;txAnchorHorz&quot;.
  /// </summary>
  TextAnchorHorizontal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;txAnchorVert&quot;.
  /// </summary>
  TextAnchorVertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;txAnchorHorzCh&quot;.
  /// </summary>
  TextAnchorHorizontalWithChildren,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;txAnchorVertCh&quot;.
  /// </summary>
  TextAnchorVerticalWithChildren,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;parTxLTRAlign&quot;.
  /// </summary>
  ParentTextLeftToRightAlignment,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;parTxRTLAlign&quot;.
  /// </summary>
  ParentTextRightToLeftAlignment,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;shpTxLTRAlignCh&quot;.
  /// </summary>
  ShapeTextLeftToRightAlignment,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;shpTxRTLAlignCh&quot;.
  /// </summary>
  ShapeTextRightToLeftAlignment,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;autoTxRot&quot;.
  /// </summary>
  AutoTextRotation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;grDir&quot;.
  /// </summary>
  GrowDirection,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowDir&quot;.
  /// </summary>
  FlowDirection,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;contDir&quot;.
  /// </summary>
  ContinueDirection,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bkpt&quot;.
  /// </summary>
  Breakpoint,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;off&quot;.
  /// </summary>
  Offset,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hierAlign&quot;.
  /// </summary>
  HierarchyAlignment,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bkPtFixedVal&quot;.
  /// </summary>
  BreakpointFixedValue,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;stBulletLvl&quot;.
  /// </summary>
  StartBulletsAtLevel,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;stAng&quot;.
  /// </summary>
  StartAngle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;spanAng&quot;.
  /// </summary>
  SpanAngle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ar&quot;.
  /// </summary>
  AspectRatio,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lnSpPar&quot;.
  /// </summary>
  LineSpacingParent,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lnSpAfParP&quot;.
  /// </summary>
  LineSpacingAfterParentParagraph,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lnSpCh&quot;.
  /// </summary>
  LineSpacingChildren,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lnSpAfChP&quot;.
  /// </summary>
  LineSpacingAfterChildrenParagraph,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rtShortDist&quot;.
  /// </summary>
  RouteShortestDistance,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;alignTx&quot;.
  /// </summary>
  TextAlignment,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pyraLvlNode&quot;.
  /// </summary>
  PyramidLevelNode,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pyraAcctBkgdNode&quot;.
  /// </summary>
  PyramidAccentBackgroundNode,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pyraAcctTxNode&quot;.
  /// </summary>
  PyramidAccentTextNode,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;srcNode&quot;.
  /// </summary>
  SourceNode,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dstNode&quot;.
  /// </summary>
  DestinationNode,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;begPts&quot;.
  /// </summary>
  BeginningPoints,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;endPts&quot;.
  /// </summary>
  EndPoints,
  
}
