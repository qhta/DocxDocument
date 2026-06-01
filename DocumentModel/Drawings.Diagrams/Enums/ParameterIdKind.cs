namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Parameter Identifier
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ParameterIdKind
{
  /// <summary>
  ///   Horizontal Alignment.
  /// </summary>
  HorizontalAlignment,

  /// <summary>
  ///   Vertical Alignment.
  /// </summary>
  VerticalAlignment,

  /// <summary>
  ///   Child Direction.
  /// </summary>
  ChildDirection,

  /// <summary>
  ///   Child Alignment.
  /// </summary>
  ChildAlignment,

  /// <summary>
  ///   Secondary Child Alignment.
  /// </summary>
  SecondaryChildAlignment,

  /// <summary>
  ///   Linear Direction.
  /// </summary>
  LinearDirection,

  /// <summary>
  ///   Secondary Linear Direction.
  /// </summary>
  SecondaryLinearDirection,

  /// <summary>
  ///   Start Element.
  /// </summary>
  StartElement,

  /// <summary>
  ///   Bend IPoint.
  /// </summary>
  BendPoint,

  /// <summary>
  ///   Connection Route.
  /// </summary>
  ConnectionRoute,

  /// <summary>
  ///   Beginning Arrowhead IStyle.
  /// </summary>
  BeginningArrowheadStyle,

  /// <summary>
  ///   End IStyle.
  /// </summary>
  EndStyle,

  /// <summary>
  ///   Connector Dimension.
  /// </summary>
  ConnectorDimension,

  /// <summary>
  ///   Rotation Path.
  /// </summary>
  RotationPath,

  /// <summary>
  ///   Center IShape Mapping.
  /// </summary>
  CenterShapeMapping,

  /// <summary>
  ///   Node Horizontal Alignment.
  /// </summary>
  NodeHorizontalAlignment,

  /// <summary>
  ///   Node Vertical Alignment.
  /// </summary>
  NodeVerticalAlignment,

  /// <summary>
  ///   Fallback Scale.
  /// </summary>
  FallbackScale,

  /// <summary>
  ///   Text Direction.
  /// </summary>
  TextDirection,

  /// <summary>
  ///   Pyramid Accent Position.
  /// </summary>
  PyramidAccentPosition,

  /// <summary>
  ///   Pyramid Accent Text Margin.
  /// </summary>
  PyramidAccentTextMargin,

  /// <summary>
  ///   Text Block Direction.
  /// </summary>
  TextBlockDirection,

  /// <summary>
  ///   Text Anchor Horizontal.
  /// </summary>
  TextAnchorHorizontal,

  /// <summary>
  ///   Text Anchor Vertical.
  /// </summary>
  TextAnchorVertical,

  /// <summary>
  ///   Text Anchor Horizontal With Children.
  /// </summary>
  TextAnchorHorizontalWithChildren,

  /// <summary>
  ///   Text Anchor Vertical With Children.
  /// </summary>
  TextAnchorVerticalWithChildren,

  /// <summary>
  ///   Parent Text Left-Ito-Right Alignment.
  /// </summary>
  ParentTextLeftToRightAlignment,

  /// <summary>
  ///   Parent Text Right-Ito-Left Alignment.
  /// </summary>
  ParentTextRightToLeftAlignment,

  /// <summary>
  ///   IShape Text Left-Ito-Right Alignment.
  /// </summary>
  ShapeTextLeftToRightAlignment,

  /// <summary>
  ///   IShape Text Right-Ito-Left Alignment.
  /// </summary>
  ShapeTextRightToLeftAlignment,

  /// <summary>
  ///   Auto Text Rotation.
  /// </summary>
  AutoTextRotation,

  /// <summary>
  ///   Grow Direction.
  /// </summary>
  GrowDirection,

  /// <summary>
  ///   Flow Direction.
  /// </summary>
  FlowDirection,

  /// <summary>
  ///   Continue Direction.
  /// </summary>
  ContinueDirection,

  /// <summary>
  ///   Breakpoint.
  /// </summary>
  Breakpoint,

  /// <summary>
  ///   Offset.
  /// </summary>
  Offset,

  /// <summary>
  ///   Hierarchy Alignment.
  /// </summary>
  HierarchyAlignment,

  /// <summary>
  ///   Breakpoint Fixed Value.
  /// </summary>
  BreakpointFixedValue,

  /// <summary>
  ///   Start Bullets At Level.
  /// </summary>
  StartBulletsAtLevel,

  /// <summary>
  ///   Start Angle.
  /// </summary>
  StartAngle,

  /// <summary>
  ///   Span Angle.
  /// </summary>
  SpanAngle,

  /// <summary>
  ///   Aspect Ratio.
  /// </summary>
  AspectRatio,

  /// <summary>
  ///   ILine Spacing Parent.
  /// </summary>
  LineSpacingParent,

  /// <summary>
  ///   ILine Spacing After Parent IParagraph.
  /// </summary>
  LineSpacingAfterParentParagraph,

  /// <summary>
  ///   ILine Spacing Children.
  /// </summary>
  LineSpacingChildren,

  /// <summary>
  ///   ILine Spacing After Children IParagraph.
  /// </summary>
  LineSpacingAfterChildrenParagraph,

  /// <summary>
  ///   Route Shortest Distance.
  /// </summary>
  RouteShortestDistance,

  /// <summary>
  ///   Text Alignment.
  /// </summary>
  TextAlignment,

  /// <summary>
  ///   Pyramid Level Node.
  /// </summary>
  PyramidLevelNode,

  /// <summary>
  ///   Pyramid Accent Background Node.
  /// </summary>
  PyramidAccentBackgroundNode,

  /// <summary>
  ///   Pyramid Accent Text Node.
  /// </summary>
  PyramidAccentTextNode,

  /// <summary>
  ///   ISource Node.
  /// </summary>
  SourceNode,

  /// <summary>
  ///   Destination Node.
  /// </summary>
  DestinationNode,

  /// <summary>
  ///   Beginning IPoints.
  /// </summary>
  BeginningPoints,

  /// <summary>
  ///   End IPoints.
  /// </summary>
  EndPoints
}
