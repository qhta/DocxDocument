namespace DocumentModel.Drawings;

/// <summary>
///   Preset Shape Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ShapeKind
{
  /// <summary>
  ///   Line Shape.
  /// </summary>
  Line,
  /// <summary>
  ///   Line Inverse Shape.
  /// </summary>
  LineInverse,
  /// <summary>
  ///   Triangle Shape.
  /// </summary>
  Triangle,
  /// <summary>
  ///   Right Triangle Shape.
  /// </summary>
  RightTriangle,
  /// <summary>
  ///   Rectangle Shape.
  /// </summary>
  Rectangle,
  /// <summary>
  ///   Diamond Shape.
  /// </summary>
  Diamond,
  /// <summary>
  ///   Parallelogram Shape.
  /// </summary>
  Parallelogram,
  /// <summary>
  ///   Trapezoid Shape.
  /// </summary>
  Trapezoid,
  /// <summary>
  ///   Non-Isosceles Trapezoid Shape.
  /// </summary>
  NonIsoscelesTrapezoid,
  /// <summary>
  ///   Pentagon Shape.
  /// </summary>
  Pentagon,
  /// <summary>
  ///   Hexagon Shape.
  /// </summary>
  Hexagon,
  /// <summary>
  ///   Heptagon Shape.
  /// </summary>
  Heptagon,
  /// <summary>
  ///   Octagon Shape.
  /// </summary>
  Octagon,
  /// <summary>
  ///   Decagon Shape.
  /// </summary>
  Decagon,
  /// <summary>
  ///   Dodecagon Shape.
  /// </summary>
  Dodecagon,
  /// <summary>
  ///   Four Pointed Star Shape.
  /// </summary>
  Star4,
  /// <summary>
  ///   Five Pointed Star Shape.
  /// </summary>
  Star5,
  /// <summary>
  ///   Six Pointed Star Shape.
  /// </summary>
  Star6,
  /// <summary>
  ///   Seven Pointed Star Shape.
  /// </summary>
  Star7,
  /// <summary>
  ///   Eight Pointed Star Shape.
  /// </summary>
  Star8,
  /// <summary>
  ///   Ten Pointed Star Shape.
  /// </summary>
  Star10,
  /// <summary>
  ///   Twelve Pointed Star Shape.
  /// </summary>
  Star12,
  /// <summary>
  ///   Sixteen Pointed Star Shape.
  /// </summary>
  Star16,
  /// <summary>
  ///   Twenty Four Pointed Star Shape.
  /// </summary>
  Star24,
  /// <summary>
  ///   Thirty Two Pointed Star Shape.
  /// </summary>
  Star32,
  /// <summary>
  ///   Round Corner Rectangle Shape.
  /// </summary>
  RoundRectangle,
  /// <summary>
  ///   One Round Corner Rectangle Shape.
  /// </summary>
  Round1Rectangle,
  /// <summary>
  ///   Two Same-side Round Corner Rectangle Shape.
  /// </summary>
  Round2SameRectangle,
  /// <summary>
  ///   Two Diagonal Round Corner Rectangle Shape.
  /// </summary>
  Round2DiagonalRectangle,
  /// <summary>
  ///   One Snip One Round Corner Rectangle Shape.
  /// </summary>
  SnipRoundRectangle,
  /// <summary>
  ///   One Snip Corner Rectangle Shape.
  /// </summary>
  Snip1Rectangle,
  /// <summary>
  ///   Two Same-side Snip Corner Rectangle Shape.
  /// </summary>
  Snip2SameRectangle,
  /// <summary>
  ///   Two Diagonal Snip Corner Rectangle Shape.
  /// </summary>
  Snip2DiagonalRectangle,
  /// <summary>
  ///   Plaque Shape.
  /// </summary>
  Plaque,
  /// <summary>
  ///   Ellipse Shape.
  /// </summary>
  Ellipse,
  /// <summary>
  ///   Teardrop Shape.
  /// </summary>
  Teardrop,
  /// <summary>
  ///   Home Plate Shape.
  /// </summary>
  HomePlate,
  /// <summary>
  ///   Chevron Shape.
  /// </summary>
  Chevron,
  /// <summary>
  ///   Pie Wedge Shape.
  /// </summary>
  PieWedge,
  /// <summary>
  ///   Pie Shape.
  /// </summary>
  Pie,
  /// <summary>
  ///   Block Arc Shape.
  /// </summary>
  BlockArc,
  /// <summary>
  ///   Donut Shape.
  /// </summary>
  Donut,
  /// <summary>
  ///   No Smoking Shape.
  /// </summary>
  NoSmoking,
  /// <summary>
  ///   Right Arrow Shape.
  /// </summary>
  RightArrow,
  /// <summary>
  ///   Left Arrow Shape.
  /// </summary>
  LeftArrow,
  /// <summary>
  ///   Up Arrow Shape.
  /// </summary>
  UpArrow,
  /// <summary>
  ///   Down Arrow Shape.
  /// </summary>
  DownArrow,
  /// <summary>
  ///   Striped Right Arrow Shape.
  /// </summary>
  StripedRightArrow,
  /// <summary>
  ///   Notched Right Arrow Shape.
  /// </summary>
  NotchedRightArrow,
  /// <summary>
  ///   Bent Up Arrow Shape.
  /// </summary>
  BentUpArrow,
  /// <summary>
  ///   Left Right Arrow Shape.
  /// </summary>
  LeftRightArrow,
  /// <summary>
  ///   Up Down Arrow Shape.
  /// </summary>
  UpDownArrow,
  /// <summary>
  ///   Left Up Arrow Shape.
  /// </summary>
  LeftUpArrow,
  /// <summary>
  ///   Left Right Up Arrow Shape.
  /// </summary>
  LeftRightUpArrow,
  /// <summary>
  ///   Quad-Arrow Shape.
  /// </summary>
  QuadArrow,
  /// <summary>
  ///   Callout Left Arrow Shape.
  /// </summary>
  LeftArrowCallout,
  /// <summary>
  ///   Callout Right Arrow Shape.
  /// </summary>
  RightArrowCallout,
  /// <summary>
  ///   Callout Up Arrow Shape.
  /// </summary>
  UpArrowCallout,
  /// <summary>
  ///   Callout Down Arrow Shape.
  /// </summary>
  DownArrowCallout,
  /// <summary>
  ///   Callout Left Right Arrow Shape.
  /// </summary>
  LeftRightArrowCallout,
  /// <summary>
  ///   Callout Up Down Arrow Shape.
  /// </summary>
  UpDownArrowCallout,
  /// <summary>
  ///   Callout Quad-Arrow Shape.
  /// </summary>
  QuadArrowCallout,
  /// <summary>
  ///   Bent Arrow Shape.
  /// </summary>
  BentArrow,
  /// <summary>
  ///   U-Turn Arrow Shape.
  /// </summary>
  UTurnArrow,
  /// <summary>
  ///   Circular Arrow Shape.
  /// </summary>
  CircularArrow,
  /// <summary>
  ///   Left Circular Arrow Shape.
  /// </summary>
  LeftCircularArrow,
  /// <summary>
  ///   Left Right Circular Arrow Shape.
  /// </summary>
  LeftRightCircularArrow,
  /// <summary>
  ///   Curved Right Arrow Shape.
  /// </summary>
  CurvedRightArrow,
  /// <summary>
  ///   Curved Left Arrow Shape.
  /// </summary>
  CurvedLeftArrow,
  /// <summary>
  ///   Curved Up Arrow Shape.
  /// </summary>
  CurvedUpArrow,
  /// <summary>
  ///   Curved Down Arrow Shape.
  /// </summary>
  CurvedDownArrow,
  /// <summary>
  ///   Swoosh Arrow Shape.
  /// </summary>
  SwooshArrow,
  /// <summary>
  ///   Cube Shape.
  /// </summary>
  Cube,
  /// <summary>
  ///   Can Shape.
  /// </summary>
  Can,
  /// <summary>
  ///   Lightning Bolt Shape.
  /// </summary>
  LightningBolt,
  /// <summary>
  ///   Heart Shape.
  /// </summary>
  Heart,
  /// <summary>
  ///   Sun Shape.
  /// </summary>
  Sun,
  /// <summary>
  ///   Moon Shape.
  /// </summary>
  Moon,
  /// <summary>
  ///   Smiley Face Shape.
  /// </summary>
  SmileyFace,
  /// <summary>
  ///   Irregular Seal 1 Shape.
  /// </summary>
  IrregularSeal1,
  /// <summary>
  ///   Irregular Seal 2 Shape.
  /// </summary>
  IrregularSeal2,
  /// <summary>
  ///   Folded Corner Shape.
  /// </summary>
  FoldedCorner,
  /// <summary>
  ///   Bevel Shape.
  /// </summary>
  Bevel,
  /// <summary>
  ///   Frame Shape.
  /// </summary>
  Frame,
  /// <summary>
  ///   Half Frame Shape.
  /// </summary>
  HalfFrame,
  /// <summary>
  ///   Corner Shape.
  /// </summary>
  Corner,
  /// <summary>
  ///   Diagonal Stripe Shape.
  /// </summary>
  DiagonalStripe,
  /// <summary>
  ///   Chord Shape.
  /// </summary>
  Chord,
  /// <summary>
  ///   Curved Arc Shape.
  /// </summary>
  Arc,
  /// <summary>
  ///   Left Bracket Shape.
  /// </summary>
  LeftBracket,
  /// <summary>
  ///   Right Bracket Shape.
  /// </summary>
  RightBracket,
  /// <summary>
  ///   Left Brace Shape.
  /// </summary>
  LeftBrace,
  /// <summary>
  ///   Right Brace Shape.
  /// </summary>
  RightBrace,
  /// <summary>
  ///   Bracket Pair Shape.
  /// </summary>
  BracketPair,
  /// <summary>
  ///   Brace Pair Shape.
  /// </summary>
  BracePair,
  /// <summary>
  ///   Straight Connector 1 Shape.
  /// </summary>
  StraightConnector1,
  /// <summary>
  ///   Bent Connector 2 Shape.
  /// </summary>
  BentConnector2,
  /// <summary>
  ///   Bent Connector 3 Shape.
  /// </summary>
  BentConnector3,
  /// <summary>
  ///   Bent Connector 4 Shape.
  /// </summary>
  BentConnector4,
  /// <summary>
  ///   Bent Connector 5 Shape.
  /// </summary>
  BentConnector5,
  /// <summary>
  ///   Curved Connector 2 Shape.
  /// </summary>
  CurvedConnector2,
  /// <summary>
  ///   Curved Connector 3 Shape.
  /// </summary>
  CurvedConnector3,
  /// <summary>
  ///   Curved Connector 4 Shape.
  /// </summary>
  CurvedConnector4,
  /// <summary>
  ///   Curved Connector 5 Shape.
  /// </summary>
  CurvedConnector5,
  /// <summary>
  ///   Callout 1 Shape.
  /// </summary>
  Callout1,
  /// <summary>
  ///   Callout 2 Shape.
  /// </summary>
  Callout2,
  /// <summary>
  ///   Callout 3 Shape.
  /// </summary>
  Callout3,
  /// <summary>
  ///   Callout 1 Shape.
  /// </summary>
  AccentCallout1,
  /// <summary>
  ///   Callout 2 Shape.
  /// </summary>
  AccentCallout2,
  /// <summary>
  ///   Callout 3 Shape.
  /// </summary>
  AccentCallout3,
  /// <summary>
  ///   Callout 1 with Border Shape.
  /// </summary>
  BorderCallout1,
  /// <summary>
  ///   Callout 2 with Border Shape.
  /// </summary>
  BorderCallout2,
  /// <summary>
  ///   Callout 3 with Border Shape.
  /// </summary>
  BorderCallout3,
  /// <summary>
  ///   Callout 1 with Border and Accent Shape.
  /// </summary>
  AccentBorderCallout1,
  /// <summary>
  ///   Callout 2 with Border and Accent Shape.
  /// </summary>
  AccentBorderCallout2,
  /// <summary>
  ///   Callout 3 with Border and Accent Shape.
  /// </summary>
  AccentBorderCallout3,
  /// <summary>
  ///   Callout Wedge Rectangle Shape.
  /// </summary>
  WedgeRectangleCallout,
  /// <summary>
  ///   Callout Wedge Round Rectangle Shape.
  /// </summary>
  WedgeRoundRectangleCallout,
  /// <summary>
  ///   Callout Wedge Ellipse Shape.
  /// </summary>
  WedgeEllipseCallout,
  /// <summary>
  ///   Callout Cloud Shape.
  /// </summary>
  CloudCallout,
  /// <summary>
  ///   Cloud Shape.
  /// </summary>
  Cloud,
  /// <summary>
  ///   Ribbon Shape.
  /// </summary>
  Ribbon,
  /// <summary>
  ///   Ribbon 2 Shape.
  /// </summary>
  Ribbon2,
  /// <summary>
  ///   Ellipse Ribbon Shape.
  /// </summary>
  EllipseRibbon,
  /// <summary>
  ///   Ellipse Ribbon 2 Shape.
  /// </summary>
  EllipseRibbon2,
  /// <summary>
  ///   Left Right Ribbon Shape.
  /// </summary>
  LeftRightRibbon,
  /// <summary>
  ///   Vertical Scroll Shape.
  /// </summary>
  VerticalScroll,
  /// <summary>
  ///   Horizontal Scroll Shape.
  /// </summary>
  HorizontalScroll,
  /// <summary>
  ///   Wave Shape.
  /// </summary>
  Wave,
  /// <summary>
  ///   Double Wave Shape.
  /// </summary>
  DoubleWave,
  /// <summary>
  ///   Plus Shape.
  /// </summary>
  Plus,
  /// <summary>
  ///   Process Flow Shape.
  /// </summary>
  FlowChartProcess,
  /// <summary>
  ///   Decision Flow Shape.
  /// </summary>
  FlowChartDecision,
  /// <summary>
  ///   Input Output Flow Shape.
  /// </summary>
  FlowChartInputOutput,
  /// <summary>
  ///   Predefined Process Flow Shape.
  /// </summary>
  FlowChartPredefinedProcess,
  /// <summary>
  ///   Internal Storage Flow Shape.
  /// </summary>
  FlowChartInternalStorage,
  /// <summary>
  ///   Document Flow Shape.
  /// </summary>
  FlowChartDocument,
  /// <summary>
  ///   Multi-Document Flow Shape.
  /// </summary>
  FlowChartMultidocument,
  /// <summary>
  ///   Terminator Flow Shape.
  /// </summary>
  FlowChartTerminator,
  /// <summary>
  ///   Preparation Flow Shape.
  /// </summary>
  FlowChartPreparation,
  /// <summary>
  ///   Manual Input Flow Shape.
  /// </summary>
  FlowChartManualInput,
  /// <summary>
  ///   Manual Operation Flow Shape.
  /// </summary>
  FlowChartManualOperation,
  /// <summary>
  ///   Connector Flow Shape.
  /// </summary>
  FlowChartConnector,
  /// <summary>
  ///   Punched Card Flow Shape.
  /// </summary>
  FlowChartPunchedCard,
  /// <summary>
  ///   Punched Tape Flow Shape.
  /// </summary>
  FlowChartPunchedTape,
  /// <summary>
  ///   Summing Junction Flow Shape.
  /// </summary>
  FlowChartSummingJunction,
  /// <summary>
  ///   Or Flow Shape.
  /// </summary>
  FlowChartOr,
  /// <summary>
  ///   Collate Flow Shape.
  /// </summary>
  FlowChartCollate,
  /// <summary>
  ///   Sort Flow Shape.
  /// </summary>
  FlowChartSort,
  /// <summary>
  ///   Extract Flow Shape.
  /// </summary>
  FlowChartExtract,
  /// <summary>
  ///   Merge Flow Shape.
  /// </summary>
  FlowChartMerge,
  /// <summary>
  ///   Offline Storage Flow Shape.
  /// </summary>
  FlowChartOfflineStorage,
  /// <summary>
  ///   Online Storage Flow Shape.
  /// </summary>
  FlowChartOnlineStorage,
  /// <summary>
  ///   Magnetic Tape Flow Shape.
  /// </summary>
  FlowChartMagneticTape,
  /// <summary>
  ///   Magnetic Disk Flow Shape.
  /// </summary>
  FlowChartMagneticDisk,
  /// <summary>
  ///   Magnetic Drum Flow Shape.
  /// </summary>
  FlowChartMagneticDrum,
  /// <summary>
  ///   Display Flow Shape.
  /// </summary>
  FlowChartDisplay,
  /// <summary>
  ///   Delay Flow Shape.
  /// </summary>
  FlowChartDelay,
  /// <summary>
  ///   Alternate Process Flow Shape.
  /// </summary>
  FlowChartAlternateProcess,
  /// <summary>
  ///   Off-Page Connector Flow Shape.
  /// </summary>
  FlowChartOffpageConnector,
  /// <summary>
  ///   Blank Button Shape.
  /// </summary>
  ActionButtonBlank,
  /// <summary>
  ///   Home Button Shape.
  /// </summary>
  ActionButtonHome,
  /// <summary>
  ///   Help Button Shape.
  /// </summary>
  ActionButtonHelp,
  /// <summary>
  ///   Information Button Shape.
  /// </summary>
  ActionButtonInformation,
  /// <summary>
  ///   Forward or Next Button Shape.
  /// </summary>
  ActionButtonForwardNext,
  /// <summary>
  ///   Back or Previous Button Shape.
  /// </summary>
  ActionButtonBackPrevious,
  /// <summary>
  ///   End Button Shape.
  /// </summary>
  ActionButtonEnd,
  /// <summary>
  ///   Beginning Button Shape.
  /// </summary>
  ActionButtonBeginning,
  /// <summary>
  ///   Return Button Shape.
  /// </summary>
  ActionButtonReturn,
  /// <summary>
  ///   Document Button Shape.
  /// </summary>
  ActionButtonDocument,
  /// <summary>
  ///   Sound Button Shape.
  /// </summary>
  ActionButtonSound,
  /// <summary>
  ///   Movie Button Shape.
  /// </summary>
  ActionButtonMovie,
  /// <summary>
  ///   Gear 6 Shape.
  /// </summary>
  Gear6,
  /// <summary>
  ///   Gear 9 Shape.
  /// </summary>
  Gear9,
  /// <summary>
  ///   Funnel Shape.
  /// </summary>
  Funnel,
  /// <summary>
  ///   Plus Math Shape.
  /// </summary>
  MathPlus,
  /// <summary>
  ///   Minus Math Shape.
  /// </summary>
  MathMinus,
  /// <summary>
  ///   Multiply Math Shape.
  /// </summary>
  MathMultiply,
  /// <summary>
  ///   Divide Math Shape.
  /// </summary>
  MathDivide,
  /// <summary>
  ///   Equal Math Shape.
  /// </summary>
  MathEqual,
  /// <summary>
  ///   Not Equal Math Shape.
  /// </summary>
  MathNotEqual,
  /// <summary>
  ///   Corner Tabs Shape.
  /// </summary>
  CornerTabs,
  /// <summary>
  ///   Square Tabs Shape.
  /// </summary>
  SquareTabs,
  /// <summary>
  ///   Plaque Tabs Shape.
  /// </summary>
  PlaqueTabs,
  /// <summary>
  ///   Chart X Shape.
  /// </summary>
  ChartX,
  /// <summary>
  ///   Chart Star Shape.
  /// </summary>
  ChartStar,
  /// <summary>
  ///   Chart Plus Shape.
  /// </summary>
  ChartPlus
}