namespace DocumentModel.Drawings;
/// <summary>
///   Preset IShape Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.ShapeValues))]
public enum BuiltInShapeType
{
  /// <summary>
  ///   ILine IShape.
  /// </summary>
  ILine,
  /// <summary>
  ///   ILine Inverse IShape.
  /// </summary>
  LineInverse,
  /// <summary>
  ///   Triangle IShape.
  /// </summary>
  Triangle,
  /// <summary>
  ///   Right Triangle IShape.
  /// </summary>
  RightTriangle,
  /// <summary>
  ///   IRectangle IShape.
  /// </summary>
  IRectangle,
  /// <summary>
  ///   Diamond IShape.
  /// </summary>
  Diamond,
  /// <summary>
  ///   Parallelogram IShape.
  /// </summary>
  Parallelogram,
  /// <summary>
  ///   Trapezoid IShape.
  /// </summary>
  Trapezoid,
  /// <summary>
  ///   Non-Isosceles Trapezoid IShape.
  /// </summary>
  NonIsoscelesTrapezoid,
  /// <summary>
  ///   Pentagon IShape.
  /// </summary>
  Pentagon,
  /// <summary>
  ///   Hexagon IShape.
  /// </summary>
  Hexagon,
  /// <summary>
  ///   Heptagon IShape.
  /// </summary>
  Heptagon,
  /// <summary>
  ///   Octagon IShape.
  /// </summary>
  Octagon,
  /// <summary>
  ///   Decagon IShape.
  /// </summary>
  Decagon,
  /// <summary>
  ///   Dodecagon IShape.
  /// </summary>
  Dodecagon,
  /// <summary>
  ///   Four Pointed Star IShape.
  /// </summary>
  Star4,
  /// <summary>
  ///   Five Pointed Star IShape.
  /// </summary>
  Star5,
  /// <summary>
  ///   Six Pointed Star IShape.
  /// </summary>
  Star6,
  /// <summary>
  ///   Seven Pointed Star IShape.
  /// </summary>
  Star7,
  /// <summary>
  ///   Eight Pointed Star IShape.
  /// </summary>
  Star8,
  /// <summary>
  ///   Ten Pointed Star IShape.
  /// </summary>
  Star10,
  /// <summary>
  ///   Twelve Pointed Star IShape.
  /// </summary>
  Star12,
  /// <summary>
  ///   Sixteen Pointed Star IShape.
  /// </summary>
  Star16,
  /// <summary>
  ///   Twenty Four Pointed Star IShape.
  /// </summary>
  Star24,
  /// <summary>
  ///   Thirty Two Pointed Star IShape.
  /// </summary>
  Star32,
  /// <summary>
  ///   Round Corner IRectangle IShape.
  /// </summary>
  RoundRectangle,
  /// <summary>
  ///   One Round Corner IRectangle IShape.
  /// </summary>
  Round1Rectangle,
  /// <summary>
  ///   Two Same-side Round Corner IRectangle IShape.
  /// </summary>
  Round2SameRectangle,
  /// <summary>
  ///   Two Diagonal Round Corner IRectangle IShape.
  /// </summary>
  Round2DiagonalRectangle,
  /// <summary>
  ///   One Snip One Round Corner IRectangle IShape.
  /// </summary>
  SnipRoundRectangle,
  /// <summary>
  ///   One Snip Corner IRectangle IShape.
  /// </summary>
  Snip1Rectangle,
  /// <summary>
  ///   Two Same-side Snip Corner IRectangle IShape.
  /// </summary>
  Snip2SameRectangle,
  /// <summary>
  ///   Two Diagonal Snip Corner IRectangle IShape.
  /// </summary>
  Snip2DiagonalRectangle,
  /// <summary>
  ///   Plaque IShape.
  /// </summary>
  Plaque,
  /// <summary>
  ///   Ellipse IShape.
  /// </summary>
  Ellipse,
  /// <summary>
  ///   Teardrop IShape.
  /// </summary>
  Teardrop,
  /// <summary>
  ///   Home Plate IShape.
  /// </summary>
  HomePlate,
  /// <summary>
  ///   Chevron IShape.
  /// </summary>
  Chevron,
  /// <summary>
  ///   Pie Wedge IShape.
  /// </summary>
  PieWedge,
  /// <summary>
  ///   Pie IShape.
  /// </summary>
  Pie,
  /// <summary>
  ///   Block Arc IShape.
  /// </summary>
  BlockArc,
  /// <summary>
  ///   Donut IShape.
  /// </summary>
  Donut,
  /// <summary>
  ///   No Smoking IShape.
  /// </summary>
  NoSmoking,
  /// <summary>
  ///   Right Arrow IShape.
  /// </summary>
  RightArrow,
  /// <summary>
  ///   Left Arrow IShape.
  /// </summary>
  LeftArrow,
  /// <summary>
  ///   Up Arrow IShape.
  /// </summary>
  UpArrow,
  /// <summary>
  ///   Down Arrow IShape.
  /// </summary>
  DownArrow,
  /// <summary>
  ///   Striped Right Arrow IShape.
  /// </summary>
  StripedRightArrow,
  /// <summary>
  ///   Notched Right Arrow IShape.
  /// </summary>
  NotchedRightArrow,
  /// <summary>
  ///   Bent Up Arrow IShape.
  /// </summary>
  BentUpArrow,
  /// <summary>
  ///   Left Right Arrow IShape.
  /// </summary>
  LeftRightArrow,
  /// <summary>
  ///   Up Down Arrow IShape.
  /// </summary>
  UpDownArrow,
  /// <summary>
  ///   Left Up Arrow IShape.
  /// </summary>
  LeftUpArrow,
  /// <summary>
  ///   Left Right Up Arrow IShape.
  /// </summary>
  LeftRightUpArrow,
  /// <summary>
  ///   Quad-Arrow IShape.
  /// </summary>
  QuadArrow,
  /// <summary>
  ///   Callout Left Arrow IShape.
  /// </summary>
  LeftArrowCallout,
  /// <summary>
  ///   Callout Right Arrow IShape.
  /// </summary>
  RightArrowCallout,
  /// <summary>
  ///   Callout Up Arrow IShape.
  /// </summary>
  UpArrowCallout,
  /// <summary>
  ///   Callout Down Arrow IShape.
  /// </summary>
  DownArrowCallout,
  /// <summary>
  ///   Callout Left Right Arrow IShape.
  /// </summary>
  LeftRightArrowCallout,
  /// <summary>
  ///   Callout Up Down Arrow IShape.
  /// </summary>
  UpDownArrowCallout,
  /// <summary>
  ///   Callout Quad-Arrow IShape.
  /// </summary>
  QuadArrowCallout,
  /// <summary>
  ///   Bent Arrow IShape.
  /// </summary>
  BentArrow,
  /// <summary>
  ///   U-Turn Arrow IShape.
  /// </summary>
  UTurnArrow,
  /// <summary>
  ///   Circular Arrow IShape.
  /// </summary>
  CircularArrow,
  /// <summary>
  ///   Left Circular Arrow IShape.
  /// </summary>
  LeftCircularArrow,
  /// <summary>
  ///   Left Right Circular Arrow IShape.
  /// </summary>
  LeftRightCircularArrow,
  /// <summary>
  ///   Curved Right Arrow IShape.
  /// </summary>
  CurvedRightArrow,
  /// <summary>
  ///   Curved Left Arrow IShape.
  /// </summary>
  CurvedLeftArrow,
  /// <summary>
  ///   Curved Up Arrow IShape.
  /// </summary>
  CurvedUpArrow,
  /// <summary>
  ///   Curved Down Arrow IShape.
  /// </summary>
  CurvedDownArrow,
  /// <summary>
  ///   Swoosh Arrow IShape.
  /// </summary>
  SwooshArrow,
  /// <summary>
  ///   Cube IShape.
  /// </summary>
  Cube,
  /// <summary>
  ///   Can IShape.
  /// </summary>
  Can,
  /// <summary>
  ///   Lightning Bolt IShape.
  /// </summary>
  LightningBolt,
  /// <summary>
  ///   Heart IShape.
  /// </summary>
  Heart,
  /// <summary>
  ///   Sun IShape.
  /// </summary>
  Sun,
  /// <summary>
  ///   Moon IShape.
  /// </summary>
  Moon,
  /// <summary>
  ///   Smiley Face IShape.
  /// </summary>
  SmileyFace,
  /// <summary>
  ///   Irregular Seal 1 IShape.
  /// </summary>
  IrregularSeal1,
  /// <summary>
  ///   Irregular Seal 2 IShape.
  /// </summary>
  IrregularSeal2,
  /// <summary>
  ///   Folded Corner IShape.
  /// </summary>
  FoldedCorner,
  /// <summary>
  ///   Bevel IShape.
  /// </summary>
  Bevel,
  /// <summary>
  ///   IFrame IShape.
  /// </summary>
  IFrame,
  /// <summary>
  ///   Half IFrame IShape.
  /// </summary>
  HalfFrame,
  /// <summary>
  ///   Corner IShape.
  /// </summary>
  Corner,
  /// <summary>
  ///   Diagonal Stripe IShape.
  /// </summary>
  DiagonalStripe,
  /// <summary>
  ///   Chord IShape.
  /// </summary>
  Chord,
  /// <summary>
  ///   Curved Arc IShape.
  /// </summary>
  Arc,
  /// <summary>
  ///   Left Bracket IShape.
  /// </summary>
  LeftBracket,
  /// <summary>
  ///   Right Bracket IShape.
  /// </summary>
  RightBracket,
  /// <summary>
  ///   Left Brace IShape.
  /// </summary>
  LeftBrace,
  /// <summary>
  ///   Right Brace IShape.
  /// </summary>
  RightBrace,
  /// <summary>
  ///   Bracket Pair IShape.
  /// </summary>
  BracketPair,
  /// <summary>
  ///   Brace Pair IShape.
  /// </summary>
  BracePair,
  /// <summary>
  ///   Straight Connector 1 IShape.
  /// </summary>
  StraightConnector1,
  /// <summary>
  ///   Bent Connector 2 IShape.
  /// </summary>
  BentConnector2,
  /// <summary>
  ///   Bent Connector 3 IShape.
  /// </summary>
  BentConnector3,
  /// <summary>
  ///   Bent Connector 4 IShape.
  /// </summary>
  BentConnector4,
  /// <summary>
  ///   Bent Connector 5 IShape.
  /// </summary>
  BentConnector5,
  /// <summary>
  ///   Curved Connector 2 IShape.
  /// </summary>
  CurvedConnector2,
  /// <summary>
  ///   Curved Connector 3 IShape.
  /// </summary>
  CurvedConnector3,
  /// <summary>
  ///   Curved Connector 4 IShape.
  /// </summary>
  CurvedConnector4,
  /// <summary>
  ///   Curved Connector 5 IShape.
  /// </summary>
  CurvedConnector5,
  /// <summary>
  ///   Callout 1 IShape.
  /// </summary>
  Callout1,
  /// <summary>
  ///   Callout 2 IShape.
  /// </summary>
  Callout2,
  /// <summary>
  ///   Callout 3 IShape.
  /// </summary>
  Callout3,
  /// <summary>
  ///   Callout 1 IShape.
  /// </summary>
  AccentCallout1,
  /// <summary>
  ///   Callout 2 IShape.
  /// </summary>
  AccentCallout2,
  /// <summary>
  ///   Callout 3 IShape.
  /// </summary>
  AccentCallout3,
  /// <summary>
  ///   Callout 1 with IBorder IShape.
  /// </summary>
  BorderCallout1,
  /// <summary>
  ///   Callout 2 with IBorder IShape.
  /// </summary>
  BorderCallout2,
  /// <summary>
  ///   Callout 3 with IBorder IShape.
  /// </summary>
  BorderCallout3,
  /// <summary>
  ///   Callout 1 with IBorder and Accent IShape.
  /// </summary>
  AccentBorderCallout1,
  /// <summary>
  ///   Callout 2 with IBorder and Accent IShape.
  /// </summary>
  AccentBorderCallout2,
  /// <summary>
  ///   Callout 3 with IBorder and Accent IShape.
  /// </summary>
  AccentBorderCallout3,
  /// <summary>
  ///   Callout Wedge IRectangle IShape.
  /// </summary>
  WedgeRectangleCallout,
  /// <summary>
  ///   Callout Wedge Round IRectangle IShape.
  /// </summary>
  WedgeRoundRectangleCallout,
  /// <summary>
  ///   Callout Wedge Ellipse IShape.
  /// </summary>
  WedgeEllipseCallout,
  /// <summary>
  ///   Callout Cloud IShape.
  /// </summary>
  CloudCallout,
  /// <summary>
  ///   Cloud IShape.
  /// </summary>
  Cloud,
  /// <summary>
  ///   Ribbon IShape.
  /// </summary>
  Ribbon,
  /// <summary>
  ///   Ribbon 2 IShape.
  /// </summary>
  Ribbon2,
  /// <summary>
  ///   Ellipse Ribbon IShape.
  /// </summary>
  EllipseRibbon,
  /// <summary>
  ///   Ellipse Ribbon 2 IShape.
  /// </summary>
  EllipseRibbon2,
  /// <summary>
  ///   Left Right Ribbon IShape.
  /// </summary>
  LeftRightRibbon,
  /// <summary>
  ///   Vertical Scroll IShape.
  /// </summary>
  VerticalScroll,
  /// <summary>
  ///   Horizontal Scroll IShape.
  /// </summary>
  HorizontalScroll,
  /// <summary>
  ///   Wave IShape.
  /// </summary>
  Wave,
  /// <summary>
  ///   Double Wave IShape.
  /// </summary>
  DoubleWave,
  /// <summary>
  ///   Plus IShape.
  /// </summary>
  Plus,
  /// <summary>
  ///   Process Flow IShape.
  /// </summary>
  FlowChartProcess,
  /// <summary>
  ///   Decision Flow IShape.
  /// </summary>
  FlowChartDecision,
  /// <summary>
  ///   Input Output Flow IShape.
  /// </summary>
  FlowChartInputOutput,
  /// <summary>
  ///   Predefined Process Flow IShape.
  /// </summary>
  FlowChartPredefinedProcess,
  /// <summary>
  ///   Internal Storage Flow IShape.
  /// </summary>
  FlowChartInternalStorage,
  /// <summary>
  ///   IDocument Flow IShape.
  /// </summary>
  FlowChartDocument,
  /// <summary>
  ///   Multi-IDocument Flow IShape.
  /// </summary>
  FlowChartMultidocument,
  /// <summary>
  ///   Terminator Flow IShape.
  /// </summary>
  FlowChartTerminator,
  /// <summary>
  ///   Preparation Flow IShape.
  /// </summary>
  FlowChartPreparation,
  /// <summary>
  ///   Manual Input Flow IShape.
  /// </summary>
  FlowChartManualInput,
  /// <summary>
  ///   Manual Operation Flow IShape.
  /// </summary>
  FlowChartManualOperation,
  /// <summary>
  ///   Connector Flow IShape.
  /// </summary>
  FlowChartConnector,
  /// <summary>
  ///   Punched Card Flow IShape.
  /// </summary>
  FlowChartPunchedCard,
  /// <summary>
  ///   Punched Tape Flow IShape.
  /// </summary>
  FlowChartPunchedTape,
  /// <summary>
  ///   Summing Junction Flow IShape.
  /// </summary>
  FlowChartSummingJunction,
  /// <summary>
  ///   Or Flow IShape.
  /// </summary>
  FlowChartOr,
  /// <summary>
  ///   Collate Flow IShape.
  /// </summary>
  FlowChartCollate,
  /// <summary>
  ///   Sort Flow IShape.
  /// </summary>
  FlowChartSort,
  /// <summary>
  ///   Extract Flow IShape.
  /// </summary>
  FlowChartExtract,
  /// <summary>
  ///   Merge Flow IShape.
  /// </summary>
  FlowChartMerge,
  /// <summary>
  ///   Offline Storage Flow IShape.
  /// </summary>
  FlowChartOfflineStorage,
  /// <summary>
  ///   Online Storage Flow IShape.
  /// </summary>
  FlowChartOnlineStorage,
  /// <summary>
  ///   Magnetic Tape Flow IShape.
  /// </summary>
  FlowChartMagneticTape,
  /// <summary>
  ///   Magnetic Disk Flow IShape.
  /// </summary>
  FlowChartMagneticDisk,
  /// <summary>
  ///   Magnetic Drum Flow IShape.
  /// </summary>
  FlowChartMagneticDrum,
  /// <summary>
  ///   Display Flow IShape.
  /// </summary>
  FlowChartDisplay,
  /// <summary>
  ///   Delay Flow IShape.
  /// </summary>
  FlowChartDelay,
  /// <summary>
  ///   Alternate Process Flow IShape.
  /// </summary>
  FlowChartAlternateProcess,
  /// <summary>
  ///   Off-IPage Connector Flow IShape.
  /// </summary>
  FlowChartOffpageConnector,
  /// <summary>
  ///   Blank Button IShape.
  /// </summary>
  ActionButtonBlank,
  /// <summary>
  ///   Home Button IShape.
  /// </summary>
  ActionButtonHome,
  /// <summary>
  ///   Help Button IShape.
  /// </summary>
  ActionButtonHelp,
  /// <summary>
  ///   Information Button IShape.
  /// </summary>
  ActionButtonInformation,
  /// <summary>
  ///   Forward or Next Button IShape.
  /// </summary>
  ActionButtonForwardNext,
  /// <summary>
  ///   Back or Previous Button IShape.
  /// </summary>
  ActionButtonBackPrevious,
  /// <summary>
  ///   End Button IShape.
  /// </summary>
  ActionButtonEnd,
  /// <summary>
  ///   Beginning Button IShape.
  /// </summary>
  ActionButtonBeginning,
  /// <summary>
  ///   Return Button IShape.
  /// </summary>
  ActionButtonReturn,
  /// <summary>
  ///   IDocument Button IShape.
  /// </summary>
  ActionButtonDocument,
  /// <summary>
  ///   Sound Button IShape.
  /// </summary>
  ActionButtonSound,
  /// <summary>
  ///   Movie Button IShape.
  /// </summary>
  ActionButtonMovie,
  /// <summary>
  ///   Gear 6 IShape.
  /// </summary>
  Gear6,
  /// <summary>
  ///   Gear 9 IShape.
  /// </summary>
  Gear9,
  /// <summary>
  ///   Funnel IShape.
  /// </summary>
  Funnel,
  /// <summary>
  ///   Plus Math IShape.
  /// </summary>
  MathPlus,
  /// <summary>
  ///   Minus Math IShape.
  /// </summary>
  MathMinus,
  /// <summary>
  ///   Multiply Math IShape.
  /// </summary>
  MathMultiply,
  /// <summary>
  ///   Divide Math IShape.
  /// </summary>
  MathDivide,
  /// <summary>
  ///   Equal Math IShape.
  /// </summary>
  MathEqual,
  /// <summary>
  ///   Not Equal Math IShape.
  /// </summary>
  MathNotEqual,
  /// <summary>
  ///   Corner Tabs IShape.
  /// </summary>
  CornerTabs,
  /// <summary>
  ///   Square Tabs IShape.
  /// </summary>
  SquareTabs,
  /// <summary>
  ///   Plaque Tabs IShape.
  /// </summary>
  PlaqueTabs,
  /// <summary>
  ///   IChart X IShape.
  /// </summary>
  ChartX,
  /// <summary>
  ///   IChart Star IShape.
  /// </summary>
  ChartStar,
  /// <summary>
  ///   IChart Plus IShape.
  /// </summary>
  ChartPlus
}
