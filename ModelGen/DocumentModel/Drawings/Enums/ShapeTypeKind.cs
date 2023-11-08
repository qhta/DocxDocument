namespace DocumentModel.Drawings;


/// <summary>
///   Preset Shape Types
/// </summary>
public enum ShapeTypeKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;line&quot;.
  /// </summary>
  Line,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lineInv&quot;.
  /// </summary>
  LineInverse,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;triangle&quot;.
  /// </summary>
  Triangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rtTriangle&quot;.
  /// </summary>
  RightTriangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rect&quot;.
  /// </summary>
  Rectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;diamond&quot;.
  /// </summary>
  Diamond,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;parallelogram&quot;.
  /// </summary>
  Parallelogram,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;trapezoid&quot;.
  /// </summary>
  Trapezoid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;nonIsoscelesTrapezoid&quot;.
  /// </summary>
  NonIsoscelesTrapezoid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pentagon&quot;.
  /// </summary>
  Pentagon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hexagon&quot;.
  /// </summary>
  Hexagon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;heptagon&quot;.
  /// </summary>
  Heptagon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;octagon&quot;.
  /// </summary>
  Octagon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;decagon&quot;.
  /// </summary>
  Decagon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dodecagon&quot;.
  /// </summary>
  Dodecagon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star4&quot;.
  /// </summary>
  Star4,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star5&quot;.
  /// </summary>
  Star5,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star6&quot;.
  /// </summary>
  Star6,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star7&quot;.
  /// </summary>
  Star7,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star8&quot;.
  /// </summary>
  Star8,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star10&quot;.
  /// </summary>
  Star10,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star12&quot;.
  /// </summary>
  Star12,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star16&quot;.
  /// </summary>
  Star16,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star24&quot;.
  /// </summary>
  Star24,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star32&quot;.
  /// </summary>
  Star32,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;roundRect&quot;.
  /// </summary>
  RoundRectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;round1Rect&quot;.
  /// </summary>
  Round1Rectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;round2SameRect&quot;.
  /// </summary>
  Round2SameRectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;round2DiagRect&quot;.
  /// </summary>
  Round2DiagonalRectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;snipRoundRect&quot;.
  /// </summary>
  SnipRoundRectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;snip1Rect&quot;.
  /// </summary>
  Snip1Rectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;snip2SameRect&quot;.
  /// </summary>
  Snip2SameRectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;snip2DiagRect&quot;.
  /// </summary>
  Snip2DiagonalRectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;plaque&quot;.
  /// </summary>
  Plaque,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ellipse&quot;.
  /// </summary>
  Ellipse,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;teardrop&quot;.
  /// </summary>
  Teardrop,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;homePlate&quot;.
  /// </summary>
  HomePlate,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chevron&quot;.
  /// </summary>
  Chevron,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pieWedge&quot;.
  /// </summary>
  PieWedge,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pie&quot;.
  /// </summary>
  Pie,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;blockArc&quot;.
  /// </summary>
  BlockArc,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;donut&quot;.
  /// </summary>
  Donut,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;noSmoking&quot;.
  /// </summary>
  NoSmoking,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rightArrow&quot;.
  /// </summary>
  RightArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftArrow&quot;.
  /// </summary>
  LeftArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;upArrow&quot;.
  /// </summary>
  UpArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;downArrow&quot;.
  /// </summary>
  DownArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;stripedRightArrow&quot;.
  /// </summary>
  StripedRightArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;notchedRightArrow&quot;.
  /// </summary>
  NotchedRightArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bentUpArrow&quot;.
  /// </summary>
  BentUpArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftRightArrow&quot;.
  /// </summary>
  LeftRightArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;upDownArrow&quot;.
  /// </summary>
  UpDownArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftUpArrow&quot;.
  /// </summary>
  LeftUpArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftRightUpArrow&quot;.
  /// </summary>
  LeftRightUpArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;quadArrow&quot;.
  /// </summary>
  QuadArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftArrowCallout&quot;.
  /// </summary>
  LeftArrowCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rightArrowCallout&quot;.
  /// </summary>
  RightArrowCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;upArrowCallout&quot;.
  /// </summary>
  UpArrowCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;downArrowCallout&quot;.
  /// </summary>
  DownArrowCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftRightArrowCallout&quot;.
  /// </summary>
  LeftRightArrowCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;upDownArrowCallout&quot;.
  /// </summary>
  UpDownArrowCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;quadArrowCallout&quot;.
  /// </summary>
  QuadArrowCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bentArrow&quot;.
  /// </summary>
  BentArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;uturnArrow&quot;.
  /// </summary>
  UTurnArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;circularArrow&quot;.
  /// </summary>
  CircularArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftCircularArrow&quot;.
  /// </summary>
  LeftCircularArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftRightCircularArrow&quot;.
  /// </summary>
  LeftRightCircularArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedRightArrow&quot;.
  /// </summary>
  CurvedRightArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedLeftArrow&quot;.
  /// </summary>
  CurvedLeftArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedUpArrow&quot;.
  /// </summary>
  CurvedUpArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedDownArrow&quot;.
  /// </summary>
  CurvedDownArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;swooshArrow&quot;.
  /// </summary>
  SwooshArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cube&quot;.
  /// </summary>
  Cube,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;can&quot;.
  /// </summary>
  Can,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lightningBolt&quot;.
  /// </summary>
  LightningBolt,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;heart&quot;.
  /// </summary>
  Heart,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sun&quot;.
  /// </summary>
  Sun,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;moon&quot;.
  /// </summary>
  Moon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;smileyFace&quot;.
  /// </summary>
  SmileyFace,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;irregularSeal1&quot;.
  /// </summary>
  IrregularSeal1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;irregularSeal2&quot;.
  /// </summary>
  IrregularSeal2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;foldedCorner&quot;.
  /// </summary>
  FoldedCorner,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bevel&quot;.
  /// </summary>
  Bevel,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;frame&quot;.
  /// </summary>
  Frame,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;halfFrame&quot;.
  /// </summary>
  HalfFrame,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;corner&quot;.
  /// </summary>
  Corner,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;diagStripe&quot;.
  /// </summary>
  DiagonalStripe,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chord&quot;.
  /// </summary>
  Chord,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arc&quot;.
  /// </summary>
  Arc,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftBracket&quot;.
  /// </summary>
  LeftBracket,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rightBracket&quot;.
  /// </summary>
  RightBracket,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftBrace&quot;.
  /// </summary>
  LeftBrace,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rightBrace&quot;.
  /// </summary>
  RightBrace,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bracketPair&quot;.
  /// </summary>
  BracketPair,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bracePair&quot;.
  /// </summary>
  BracePair,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;straightConnector1&quot;.
  /// </summary>
  StraightConnector1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bentConnector2&quot;.
  /// </summary>
  BentConnector2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bentConnector3&quot;.
  /// </summary>
  BentConnector3,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bentConnector4&quot;.
  /// </summary>
  BentConnector4,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bentConnector5&quot;.
  /// </summary>
  BentConnector5,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedConnector2&quot;.
  /// </summary>
  CurvedConnector2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedConnector3&quot;.
  /// </summary>
  CurvedConnector3,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedConnector4&quot;.
  /// </summary>
  CurvedConnector4,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedConnector5&quot;.
  /// </summary>
  CurvedConnector5,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;callout1&quot;.
  /// </summary>
  Callout1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;callout2&quot;.
  /// </summary>
  Callout2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;callout3&quot;.
  /// </summary>
  Callout3,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accentCallout1&quot;.
  /// </summary>
  AccentCallout1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accentCallout2&quot;.
  /// </summary>
  AccentCallout2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accentCallout3&quot;.
  /// </summary>
  AccentCallout3,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;borderCallout1&quot;.
  /// </summary>
  BorderCallout1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;borderCallout2&quot;.
  /// </summary>
  BorderCallout2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;borderCallout3&quot;.
  /// </summary>
  BorderCallout3,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accentBorderCallout1&quot;.
  /// </summary>
  AccentBorderCallout1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accentBorderCallout2&quot;.
  /// </summary>
  AccentBorderCallout2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accentBorderCallout3&quot;.
  /// </summary>
  AccentBorderCallout3,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wedgeRectCallout&quot;.
  /// </summary>
  WedgeRectangleCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wedgeRoundRectCallout&quot;.
  /// </summary>
  WedgeRoundRectangleCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wedgeEllipseCallout&quot;.
  /// </summary>
  WedgeEllipseCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cloudCallout&quot;.
  /// </summary>
  CloudCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cloud&quot;.
  /// </summary>
  Cloud,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ribbon&quot;.
  /// </summary>
  Ribbon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ribbon2&quot;.
  /// </summary>
  Ribbon2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ellipseRibbon&quot;.
  /// </summary>
  EllipseRibbon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ellipseRibbon2&quot;.
  /// </summary>
  EllipseRibbon2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftRightRibbon&quot;.
  /// </summary>
  LeftRightRibbon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;verticalScroll&quot;.
  /// </summary>
  VerticalScroll,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;horizontalScroll&quot;.
  /// </summary>
  HorizontalScroll,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wave&quot;.
  /// </summary>
  Wave,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;doubleWave&quot;.
  /// </summary>
  DoubleWave,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;plus&quot;.
  /// </summary>
  Plus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartProcess&quot;.
  /// </summary>
  FlowChartProcess,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartDecision&quot;.
  /// </summary>
  FlowChartDecision,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartInputOutput&quot;.
  /// </summary>
  FlowChartInputOutput,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartPredefinedProcess&quot;.
  /// </summary>
  FlowChartPredefinedProcess,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartInternalStorage&quot;.
  /// </summary>
  FlowChartInternalStorage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartDocument&quot;.
  /// </summary>
  FlowChartDocument,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartMultidocument&quot;.
  /// </summary>
  FlowChartMultidocument,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartTerminator&quot;.
  /// </summary>
  FlowChartTerminator,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartPreparation&quot;.
  /// </summary>
  FlowChartPreparation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartManualInput&quot;.
  /// </summary>
  FlowChartManualInput,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartManualOperation&quot;.
  /// </summary>
  FlowChartManualOperation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartConnector&quot;.
  /// </summary>
  FlowChartConnector,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartPunchedCard&quot;.
  /// </summary>
  FlowChartPunchedCard,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartPunchedTape&quot;.
  /// </summary>
  FlowChartPunchedTape,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartSummingJunction&quot;.
  /// </summary>
  FlowChartSummingJunction,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartOr&quot;.
  /// </summary>
  FlowChartOr,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartCollate&quot;.
  /// </summary>
  FlowChartCollate,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartSort&quot;.
  /// </summary>
  FlowChartSort,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartExtract&quot;.
  /// </summary>
  FlowChartExtract,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartMerge&quot;.
  /// </summary>
  FlowChartMerge,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartOfflineStorage&quot;.
  /// </summary>
  FlowChartOfflineStorage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartOnlineStorage&quot;.
  /// </summary>
  FlowChartOnlineStorage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartMagneticTape&quot;.
  /// </summary>
  FlowChartMagneticTape,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartMagneticDisk&quot;.
  /// </summary>
  FlowChartMagneticDisk,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartMagneticDrum&quot;.
  /// </summary>
  FlowChartMagneticDrum,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartDisplay&quot;.
  /// </summary>
  FlowChartDisplay,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartDelay&quot;.
  /// </summary>
  FlowChartDelay,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartAlternateProcess&quot;.
  /// </summary>
  FlowChartAlternateProcess,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartOffpageConnector&quot;.
  /// </summary>
  FlowChartOffpageConnector,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonBlank&quot;.
  /// </summary>
  ActionButtonBlank,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonHome&quot;.
  /// </summary>
  ActionButtonHome,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonHelp&quot;.
  /// </summary>
  ActionButtonHelp,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonInformation&quot;.
  /// </summary>
  ActionButtonInformation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonForwardNext&quot;.
  /// </summary>
  ActionButtonForwardNext,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonBackPrevious&quot;.
  /// </summary>
  ActionButtonBackPrevious,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonEnd&quot;.
  /// </summary>
  ActionButtonEnd,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonBeginning&quot;.
  /// </summary>
  ActionButtonBeginning,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonReturn&quot;.
  /// </summary>
  ActionButtonReturn,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonDocument&quot;.
  /// </summary>
  ActionButtonDocument,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonSound&quot;.
  /// </summary>
  ActionButtonSound,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonMovie&quot;.
  /// </summary>
  ActionButtonMovie,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gear6&quot;.
  /// </summary>
  Gear6,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gear9&quot;.
  /// </summary>
  Gear9,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;funnel&quot;.
  /// </summary>
  Funnel,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mathPlus&quot;.
  /// </summary>
  MathPlus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mathMinus&quot;.
  /// </summary>
  MathMinus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mathMultiply&quot;.
  /// </summary>
  MathMultiply,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mathDivide&quot;.
  /// </summary>
  MathDivide,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mathEqual&quot;.
  /// </summary>
  MathEqual,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mathNotEqual&quot;.
  /// </summary>
  MathNotEqual,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cornerTabs&quot;.
  /// </summary>
  CornerTabs,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;squareTabs&quot;.
  /// </summary>
  SquareTabs,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;plaqueTabs&quot;.
  /// </summary>
  PlaqueTabs,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chartX&quot;.
  /// </summary>
  ChartX,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chartStar&quot;.
  /// </summary>
  ChartStar,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chartPlus&quot;.
  /// </summary>
  ChartPlus,
  
}
