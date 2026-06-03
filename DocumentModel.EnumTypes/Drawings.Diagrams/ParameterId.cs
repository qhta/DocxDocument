namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the ParameterId enumeration.
/// Used in types such as Parameter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDD.ParameterIdValues))]
public enum ParameterId
{
  /// <summary>
  ///   Horizontal Alignment.
  /// </summary>
  [OpenXmlEnumValue("HorizontalAlignment")]
  HorizontalAlignment,
  /// <summary>
  ///   Vertical Alignment.
  /// </summary>
  [OpenXmlEnumValue("VerticalAlignment")]
  VerticalAlignment,
  /// <summary>
  ///   Child Direction.
  /// </summary>
  [OpenXmlEnumValue("ChildDirection")]
  ChildDirection,
  /// <summary>
  ///   Child Alignment.
  /// </summary>
  [OpenXmlEnumValue("ChildAlignment")]
  ChildAlignment,
  /// <summary>
  ///   Secondary Child Alignment.
  /// </summary>
  [OpenXmlEnumValue("SecondaryChildAlignment")]
  SecondaryChildAlignment,
  /// <summary>
  ///   Linear Direction.
  /// </summary>
  [OpenXmlEnumValue("LinearDirection")]
  LinearDirection,
  /// <summary>
  ///   Secondary Linear Direction.
  /// </summary>
  [OpenXmlEnumValue("SecondaryLinearDirection")]
  SecondaryLinearDirection,
  /// <summary>
  ///   Start Element.
  /// </summary>
  [OpenXmlEnumValue("StartElement")]
  StartElement,
  /// <summary>
  ///   Bend IPoint.
  /// </summary>
  [OpenXmlEnumValue("BendPoint")]
  BendPoint,
  /// <summary>
  ///   Connection Route.
  /// </summary>
  [OpenXmlEnumValue("ConnectionRoute")]
  ConnectionRoute,
  /// <summary>
  ///   Beginning Arrowhead IStyle.
  /// </summary>
  [OpenXmlEnumValue("BeginningArrowheadStyle")]
  BeginningArrowheadStyle,
  /// <summary>
  ///   End IStyle.
  /// </summary>
  [OpenXmlEnumValue("EndStyle")]
  EndStyle,
  /// <summary>
  ///   Connector Dimension.
  /// </summary>
  [OpenXmlEnumValue("ConnectorDimension")]
  ConnectorDimension,
  /// <summary>
  ///   Rotation Path.
  /// </summary>
  [OpenXmlEnumValue("RotationPath")]
  RotationPath,
  /// <summary>
  ///   Center IShape Mapping.
  /// </summary>
  [OpenXmlEnumValue("CenterShapeMapping")]
  CenterShapeMapping,
  /// <summary>
  ///   Node Horizontal Alignment.
  /// </summary>
  [OpenXmlEnumValue("NodeHorizontalAlignment")]
  NodeHorizontalAlignment,
  /// <summary>
  ///   Node Vertical Alignment.
  /// </summary>
  [OpenXmlEnumValue("NodeVerticalAlignment")]
  NodeVerticalAlignment,
  /// <summary>
  ///   Fallback Scale.
  /// </summary>
  [OpenXmlEnumValue("FallbackScale")]
  FallbackScale,
  /// <summary>
  ///   Text Direction.
  /// </summary>
  [OpenXmlEnumValue("TextDirection")]
  TextDirection,
  /// <summary>
  ///   Pyramid Accent Position.
  /// </summary>
  [OpenXmlEnumValue("PyramidAccentPosition")]
  PyramidAccentPosition,
  /// <summary>
  ///   Pyramid Accent Text Margin.
  /// </summary>
  [OpenXmlEnumValue("PyramidAccentTextMargin")]
  PyramidAccentTextMargin,
  /// <summary>
  ///   Text Block Direction.
  /// </summary>
  [OpenXmlEnumValue("TextBlockDirection")]
  TextBlockDirection,
  /// <summary>
  ///   Text Anchor Horizontal.
  /// </summary>
  [OpenXmlEnumValue("TextAnchorHorizontal")]
  TextAnchorHorizontal,
  /// <summary>
  ///   Text Anchor Vertical.
  /// </summary>
  [OpenXmlEnumValue("TextAnchorVertical")]
  TextAnchorVertical,
  /// <summary>
  ///   Text Anchor Horizontal With Children.
  /// </summary>
  [OpenXmlEnumValue("TextAnchorHorizontalWithChildren")]
  TextAnchorHorizontalWithChildren,
  /// <summary>
  ///   Text Anchor Vertical With Children.
  /// </summary>
  [OpenXmlEnumValue("TextAnchorVerticalWithChildren")]
  TextAnchorVerticalWithChildren,
  /// <summary>
  ///   Parent Text Left-to-Right Alignment.
  /// </summary>
  [OpenXmlEnumValue("ParentTextLeftToRightAlignment")]
  ParentTextLeftToRightAlignment,
  /// <summary>
  ///   Parent Text Right-to-Left Alignment.
  /// </summary>
  [OpenXmlEnumValue("ParentTextRightToLeftAlignment")]
  ParentTextRightToLeftAlignment,
  /// <summary>
  ///   IShape Text Left-to-Right Alignment.
  /// </summary>
  [OpenXmlEnumValue("ShapeTextLeftToRightAlignment")]
  ShapeTextLeftToRightAlignment,
  /// <summary>
  ///   IShape Text Right-to-Left Alignment.
  /// </summary>
  [OpenXmlEnumValue("ShapeTextRightToLeftAlignment")]
  ShapeTextRightToLeftAlignment,
  /// <summary>
  ///   Auto Text Rotation.
  /// </summary>
  [OpenXmlEnumValue("AutoTextRotation")]
  AutoTextRotation,
  /// <summary>
  ///   Grow Direction.
  /// </summary>
  [OpenXmlEnumValue("GrowDirection")]
  GrowDirection,
  /// <summary>
  ///   Flow Direction.
  /// </summary>
  [OpenXmlEnumValue("FlowDirection")]
  FlowDirection,
  /// <summary>
  ///   Continue Direction.
  /// </summary>
  [OpenXmlEnumValue("ContinueDirection")]
  ContinueDirection,
  /// <summary>
  ///   Breakpoint.
  /// </summary>
  [OpenXmlEnumValue("Breakpoint")]
  Breakpoint,
  /// <summary>
  ///   Offset.
  /// </summary>
  [OpenXmlEnumValue("Offset")]
  Offset,
  /// <summary>
  ///   Hierarchy Alignment.
  /// </summary>
  [OpenXmlEnumValue("HierarchyAlignment")]
  HierarchyAlignment,
  /// <summary>
  ///   Breakpoint Fixed Value.
  /// </summary>
  [OpenXmlEnumValue("BreakpointFixedValue")]
  BreakpointFixedValue,
  /// <summary>
  ///   Start Bullets At Level.
  /// </summary>
  [OpenXmlEnumValue("StartBulletsAtLevel")]
  StartBulletsAtLevel,
  /// <summary>
  ///   Start Angle.
  /// </summary>
  [OpenXmlEnumValue("StartAngle")]
  StartAngle,
  /// <summary>
  ///   Span Angle.
  /// </summary>
  [OpenXmlEnumValue("SpanAngle")]
  SpanAngle,
  /// <summary>
  ///   Aspect Ratio.
  /// </summary>
  [OpenXmlEnumValue("AspectRatio")]
  AspectRatio,
  /// <summary>
  ///   ILine Spacing Parent.
  /// </summary>
  [OpenXmlEnumValue("LineSpacingParent")]
  LineSpacingParent,
  /// <summary>
  ///   ILine Spacing After Parent IParagraph.
  /// </summary>
  [OpenXmlEnumValue("LineSpacingAfterParentParagraph")]
  LineSpacingAfterParentParagraph,
  /// <summary>
  ///   ILine Spacing Children.
  /// </summary>
  [OpenXmlEnumValue("LineSpacingChildren")]
  LineSpacingChildren,
  /// <summary>
  ///   ILine Spacing After Children IParagraph.
  /// </summary>
  [OpenXmlEnumValue("LineSpacingAfterChildrenParagraph")]
  LineSpacingAfterChildrenParagraph,
  /// <summary>
  ///   Route Shortest Distance.
  /// </summary>
  [OpenXmlEnumValue("RouteShortestDistance")]
  RouteShortestDistance,
  /// <summary>
  ///   Text Alignment.
  /// </summary>
  [OpenXmlEnumValue("TextAlignment")]
  TextAlignment,
  /// <summary>
  ///   Pyramid Level Node.
  /// </summary>
  [OpenXmlEnumValue("PyramidLevelNode")]
  PyramidLevelNode,
  /// <summary>
  ///   Pyramid Accent Background Node.
  /// </summary>
  [OpenXmlEnumValue("PyramidAccentBackgroundNode")]
  PyramidAccentBackgroundNode,
  /// <summary>
  ///   Pyramid Accent Text Node.
  /// </summary>
  [OpenXmlEnumValue("PyramidAccentTextNode")]
  PyramidAccentTextNode,
  /// <summary>
  ///   ISource Node.
  /// </summary>
  [OpenXmlEnumValue("SourceNode")]
  SourceNode,
  /// <summary>
  ///   Destination Node.
  /// </summary>
  [OpenXmlEnumValue("DestinationNode")]
  DestinationNode,
  /// <summary>
  ///   Beginning IPoints.
  /// </summary>
  [OpenXmlEnumValue("BeginningPoints")]
  BeginningPoints,
  /// <summary>
  ///   End IPoints.
  /// </summary>
  [OpenXmlEnumValue("EndPoints")]
  EndPoints
}

