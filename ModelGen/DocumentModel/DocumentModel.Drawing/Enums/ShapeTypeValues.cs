namespace DocumentModel.Drawing;

/// <summary>
/// Preset Shape Types
/// </summary>
public enum ShapeTypeValues
{
  /// <summary>
  /// Line Shape.
  /// </summary>
  [XmlEnum("line")]
  Line,
  
  /// <summary>
  /// Line Inverse Shape.
  /// </summary>
  [XmlEnum("lineInv")]
  LineInverse,
  
  /// <summary>
  /// Triangle Shape.
  /// </summary>
  [XmlEnum("triangle")]
  Triangle,
  
  /// <summary>
  /// Right Triangle Shape.
  /// </summary>
  [XmlEnum("rtTriangle")]
  RightTriangle,
  
  /// <summary>
  /// Rectangle Shape.
  /// </summary>
  [XmlEnum("rect")]
  Rectangle,
  
  /// <summary>
  /// Diamond Shape.
  /// </summary>
  [XmlEnum("diamond")]
  Diamond,
  
  /// <summary>
  /// Parallelogram Shape.
  /// </summary>
  [XmlEnum("parallelogram")]
  Parallelogram,
  
  /// <summary>
  /// Trapezoid Shape.
  /// </summary>
  [XmlEnum("trapezoid")]
  Trapezoid,
  
  /// <summary>
  /// Non-Isosceles Trapezoid Shape.
  /// </summary>
  [XmlEnum("nonIsoscelesTrapezoid")]
  NonIsoscelesTrapezoid,
  
  /// <summary>
  /// Pentagon Shape.
  /// </summary>
  [XmlEnum("pentagon")]
  Pentagon,
  
  /// <summary>
  /// Hexagon Shape.
  /// </summary>
  [XmlEnum("hexagon")]
  Hexagon,
  
  /// <summary>
  /// Heptagon Shape.
  /// </summary>
  [XmlEnum("heptagon")]
  Heptagon,
  
  /// <summary>
  /// Octagon Shape.
  /// </summary>
  [XmlEnum("octagon")]
  Octagon,
  
  /// <summary>
  /// Decagon Shape.
  /// </summary>
  [XmlEnum("decagon")]
  Decagon,
  
  /// <summary>
  /// Dodecagon Shape.
  /// </summary>
  [XmlEnum("dodecagon")]
  Dodecagon,
  
  /// <summary>
  /// Four Pointed Star Shape.
  /// </summary>
  [XmlEnum("star4")]
  Star4,
  
  /// <summary>
  /// Five Pointed Star Shape.
  /// </summary>
  [XmlEnum("star5")]
  Star5,
  
  /// <summary>
  /// Six Pointed Star Shape.
  /// </summary>
  [XmlEnum("star6")]
  Star6,
  
  /// <summary>
  /// Seven Pointed Star Shape.
  /// </summary>
  [XmlEnum("star7")]
  Star7,
  
  /// <summary>
  /// Eight Pointed Star Shape.
  /// </summary>
  [XmlEnum("star8")]
  Star8,
  
  /// <summary>
  /// Ten Pointed Star Shape.
  /// </summary>
  [XmlEnum("star10")]
  Star10,
  
  /// <summary>
  /// Twelve Pointed Star Shape.
  /// </summary>
  [XmlEnum("star12")]
  Star12,
  
  /// <summary>
  /// Sixteen Pointed Star Shape.
  /// </summary>
  [XmlEnum("star16")]
  Star16,
  
  /// <summary>
  /// Twenty Four Pointed Star Shape.
  /// </summary>
  [XmlEnum("star24")]
  Star24,
  
  /// <summary>
  /// Thirty Two Pointed Star Shape.
  /// </summary>
  [XmlEnum("star32")]
  Star32,
  
  /// <summary>
  /// Round Corner Rectangle Shape.
  /// </summary>
  [XmlEnum("roundRect")]
  RoundRectangle,
  
  /// <summary>
  /// One Round Corner Rectangle Shape.
  /// </summary>
  [XmlEnum("round1Rect")]
  Round1Rectangle,
  
  /// <summary>
  /// Two Same-side Round Corner Rectangle Shape.
  /// </summary>
  [XmlEnum("round2SameRect")]
  Round2SameRectangle,
  
  /// <summary>
  /// Two Diagonal Round Corner Rectangle Shape.
  /// </summary>
  [XmlEnum("round2DiagRect")]
  Round2DiagonalRectangle,
  
  /// <summary>
  /// One Snip One Round Corner Rectangle Shape.
  /// </summary>
  [XmlEnum("snipRoundRect")]
  SnipRoundRectangle,
  
  /// <summary>
  /// One Snip Corner Rectangle Shape.
  /// </summary>
  [XmlEnum("snip1Rect")]
  Snip1Rectangle,
  
  /// <summary>
  /// Two Same-side Snip Corner Rectangle Shape.
  /// </summary>
  [XmlEnum("snip2SameRect")]
  Snip2SameRectangle,
  
  /// <summary>
  /// Two Diagonal Snip Corner Rectangle Shape.
  /// </summary>
  [XmlEnum("snip2DiagRect")]
  Snip2DiagonalRectangle,
  
  /// <summary>
  /// Plaque Shape.
  /// </summary>
  [XmlEnum("plaque")]
  Plaque,
  
  /// <summary>
  /// Ellipse Shape.
  /// </summary>
  [XmlEnum("ellipse")]
  Ellipse,
  
  /// <summary>
  /// Teardrop Shape.
  /// </summary>
  [XmlEnum("teardrop")]
  Teardrop,
  
  /// <summary>
  /// Home Plate Shape.
  /// </summary>
  [XmlEnum("homePlate")]
  HomePlate,
  
  /// <summary>
  /// Chevron Shape.
  /// </summary>
  [XmlEnum("chevron")]
  Chevron,
  
  /// <summary>
  /// Pie Wedge Shape.
  /// </summary>
  [XmlEnum("pieWedge")]
  PieWedge,
  
  /// <summary>
  /// Pie Shape.
  /// </summary>
  [XmlEnum("pie")]
  Pie,
  
  /// <summary>
  /// Block Arc Shape.
  /// </summary>
  [XmlEnum("blockArc")]
  BlockArc,
  
  /// <summary>
  /// Donut Shape.
  /// </summary>
  [XmlEnum("donut")]
  Donut,
  
  /// <summary>
  /// No Smoking Shape.
  /// </summary>
  [XmlEnum("noSmoking")]
  NoSmoking,
  
  /// <summary>
  /// Right Arrow Shape.
  /// </summary>
  [XmlEnum("rightArrow")]
  RightArrow,
  
  /// <summary>
  /// Left Arrow Shape.
  /// </summary>
  [XmlEnum("leftArrow")]
  LeftArrow,
  
  /// <summary>
  /// Up Arrow Shape.
  /// </summary>
  [XmlEnum("upArrow")]
  UpArrow,
  
  /// <summary>
  /// Down Arrow Shape.
  /// </summary>
  [XmlEnum("downArrow")]
  DownArrow,
  
  /// <summary>
  /// Striped Right Arrow Shape.
  /// </summary>
  [XmlEnum("stripedRightArrow")]
  StripedRightArrow,
  
  /// <summary>
  /// Notched Right Arrow Shape.
  /// </summary>
  [XmlEnum("notchedRightArrow")]
  NotchedRightArrow,
  
  /// <summary>
  /// Bent Up Arrow Shape.
  /// </summary>
  [XmlEnum("bentUpArrow")]
  BentUpArrow,
  
  /// <summary>
  /// Left Right Arrow Shape.
  /// </summary>
  [XmlEnum("leftRightArrow")]
  LeftRightArrow,
  
  /// <summary>
  /// Up Down Arrow Shape.
  /// </summary>
  [XmlEnum("upDownArrow")]
  UpDownArrow,
  
  /// <summary>
  /// Left Up Arrow Shape.
  /// </summary>
  [XmlEnum("leftUpArrow")]
  LeftUpArrow,
  
  /// <summary>
  /// Left Right Up Arrow Shape.
  /// </summary>
  [XmlEnum("leftRightUpArrow")]
  LeftRightUpArrow,
  
  /// <summary>
  /// Quad-Arrow Shape.
  /// </summary>
  [XmlEnum("quadArrow")]
  QuadArrow,
  
  /// <summary>
  /// Callout Left Arrow Shape.
  /// </summary>
  [XmlEnum("leftArrowCallout")]
  LeftArrowCallout,
  
  /// <summary>
  /// Callout Right Arrow Shape.
  /// </summary>
  [XmlEnum("rightArrowCallout")]
  RightArrowCallout,
  
  /// <summary>
  /// Callout Up Arrow Shape.
  /// </summary>
  [XmlEnum("upArrowCallout")]
  UpArrowCallout,
  
  /// <summary>
  /// Callout Down Arrow Shape.
  /// </summary>
  [XmlEnum("downArrowCallout")]
  DownArrowCallout,
  
  /// <summary>
  /// Callout Left Right Arrow Shape.
  /// </summary>
  [XmlEnum("leftRightArrowCallout")]
  LeftRightArrowCallout,
  
  /// <summary>
  /// Callout Up Down Arrow Shape.
  /// </summary>
  [XmlEnum("upDownArrowCallout")]
  UpDownArrowCallout,
  
  /// <summary>
  /// Callout Quad-Arrow Shape.
  /// </summary>
  [XmlEnum("quadArrowCallout")]
  QuadArrowCallout,
  
  /// <summary>
  /// Bent Arrow Shape.
  /// </summary>
  [XmlEnum("bentArrow")]
  BentArrow,
  
  /// <summary>
  /// U-Turn Arrow Shape.
  /// </summary>
  [XmlEnum("uturnArrow")]
  UTurnArrow,
  
  /// <summary>
  /// Circular Arrow Shape.
  /// </summary>
  [XmlEnum("circularArrow")]
  CircularArrow,
  
  /// <summary>
  /// Left Circular Arrow Shape.
  /// </summary>
  [XmlEnum("leftCircularArrow")]
  LeftCircularArrow,
  
  /// <summary>
  /// Left Right Circular Arrow Shape.
  /// </summary>
  [XmlEnum("leftRightCircularArrow")]
  LeftRightCircularArrow,
  
  /// <summary>
  /// Curved Right Arrow Shape.
  /// </summary>
  [XmlEnum("curvedRightArrow")]
  CurvedRightArrow,
  
  /// <summary>
  /// Curved Left Arrow Shape.
  /// </summary>
  [XmlEnum("curvedLeftArrow")]
  CurvedLeftArrow,
  
  /// <summary>
  /// Curved Up Arrow Shape.
  /// </summary>
  [XmlEnum("curvedUpArrow")]
  CurvedUpArrow,
  
  /// <summary>
  /// Curved Down Arrow Shape.
  /// </summary>
  [XmlEnum("curvedDownArrow")]
  CurvedDownArrow,
  
  /// <summary>
  /// Swoosh Arrow Shape.
  /// </summary>
  [XmlEnum("swooshArrow")]
  SwooshArrow,
  
  /// <summary>
  /// Cube Shape.
  /// </summary>
  [XmlEnum("cube")]
  Cube,
  
  /// <summary>
  /// Can Shape.
  /// </summary>
  [XmlEnum("can")]
  Can,
  
  /// <summary>
  /// Lightning Bolt Shape.
  /// </summary>
  [XmlEnum("lightningBolt")]
  LightningBolt,
  
  /// <summary>
  /// Heart Shape.
  /// </summary>
  [XmlEnum("heart")]
  Heart,
  
  /// <summary>
  /// Sun Shape.
  /// </summary>
  [XmlEnum("sun")]
  Sun,
  
  /// <summary>
  /// Moon Shape.
  /// </summary>
  [XmlEnum("moon")]
  Moon,
  
  /// <summary>
  /// Smiley Face Shape.
  /// </summary>
  [XmlEnum("smileyFace")]
  SmileyFace,
  
  /// <summary>
  /// Irregular Seal 1 Shape.
  /// </summary>
  [XmlEnum("irregularSeal1")]
  IrregularSeal1,
  
  /// <summary>
  /// Irregular Seal 2 Shape.
  /// </summary>
  [XmlEnum("irregularSeal2")]
  IrregularSeal2,
  
  /// <summary>
  /// Folded Corner Shape.
  /// </summary>
  [XmlEnum("foldedCorner")]
  FoldedCorner,
  
  /// <summary>
  /// Bevel Shape.
  /// </summary>
  [XmlEnum("bevel")]
  Bevel,
  
  /// <summary>
  /// Frame Shape.
  /// </summary>
  [XmlEnum("frame")]
  Frame,
  
  /// <summary>
  /// Half Frame Shape.
  /// </summary>
  [XmlEnum("halfFrame")]
  HalfFrame,
  
  /// <summary>
  /// Corner Shape.
  /// </summary>
  [XmlEnum("corner")]
  Corner,
  
  /// <summary>
  /// Diagonal Stripe Shape.
  /// </summary>
  [XmlEnum("diagStripe")]
  DiagonalStripe,
  
  /// <summary>
  /// Chord Shape.
  /// </summary>
  [XmlEnum("chord")]
  Chord,
  
  /// <summary>
  /// Curved Arc Shape.
  /// </summary>
  [XmlEnum("arc")]
  Arc,
  
  /// <summary>
  /// Left Bracket Shape.
  /// </summary>
  [XmlEnum("leftBracket")]
  LeftBracket,
  
  /// <summary>
  /// Right Bracket Shape.
  /// </summary>
  [XmlEnum("rightBracket")]
  RightBracket,
  
  /// <summary>
  /// Left Brace Shape.
  /// </summary>
  [XmlEnum("leftBrace")]
  LeftBrace,
  
  /// <summary>
  /// Right Brace Shape.
  /// </summary>
  [XmlEnum("rightBrace")]
  RightBrace,
  
  /// <summary>
  /// Bracket Pair Shape.
  /// </summary>
  [XmlEnum("bracketPair")]
  BracketPair,
  
  /// <summary>
  /// Brace Pair Shape.
  /// </summary>
  [XmlEnum("bracePair")]
  BracePair,
  
  /// <summary>
  /// Straight Connector 1 Shape.
  /// </summary>
  [XmlEnum("straightConnector1")]
  StraightConnector1,
  
  /// <summary>
  /// Bent Connector 2 Shape.
  /// </summary>
  [XmlEnum("bentConnector2")]
  BentConnector2,
  
  /// <summary>
  /// Bent Connector 3 Shape.
  /// </summary>
  [XmlEnum("bentConnector3")]
  BentConnector3,
  
  /// <summary>
  /// Bent Connector 4 Shape.
  /// </summary>
  [XmlEnum("bentConnector4")]
  BentConnector4,
  
  /// <summary>
  /// Bent Connector 5 Shape.
  /// </summary>
  [XmlEnum("bentConnector5")]
  BentConnector5,
  
  /// <summary>
  /// Curved Connector 2 Shape.
  /// </summary>
  [XmlEnum("curvedConnector2")]
  CurvedConnector2,
  
  /// <summary>
  /// Curved Connector 3 Shape.
  /// </summary>
  [XmlEnum("curvedConnector3")]
  CurvedConnector3,
  
  /// <summary>
  /// Curved Connector 4 Shape.
  /// </summary>
  [XmlEnum("curvedConnector4")]
  CurvedConnector4,
  
  /// <summary>
  /// Curved Connector 5 Shape.
  /// </summary>
  [XmlEnum("curvedConnector5")]
  CurvedConnector5,
  
  /// <summary>
  /// Callout 1 Shape.
  /// </summary>
  [XmlEnum("callout1")]
  Callout1,
  
  /// <summary>
  /// Callout 2 Shape.
  /// </summary>
  [XmlEnum("callout2")]
  Callout2,
  
  /// <summary>
  /// Callout 3 Shape.
  /// </summary>
  [XmlEnum("callout3")]
  Callout3,
  
  /// <summary>
  /// Callout 1 Shape.
  /// </summary>
  [XmlEnum("accentCallout1")]
  AccentCallout1,
  
  /// <summary>
  /// Callout 2 Shape.
  /// </summary>
  [XmlEnum("accentCallout2")]
  AccentCallout2,
  
  /// <summary>
  /// Callout 3 Shape.
  /// </summary>
  [XmlEnum("accentCallout3")]
  AccentCallout3,
  
  /// <summary>
  /// Callout 1 with Border Shape.
  /// </summary>
  [XmlEnum("borderCallout1")]
  BorderCallout1,
  
  /// <summary>
  /// Callout 2 with Border Shape.
  /// </summary>
  [XmlEnum("borderCallout2")]
  BorderCallout2,
  
  /// <summary>
  /// Callout 3 with Border Shape.
  /// </summary>
  [XmlEnum("borderCallout3")]
  BorderCallout3,
  
  /// <summary>
  /// Callout 1 with Border and Accent Shape.
  /// </summary>
  [XmlEnum("accentBorderCallout1")]
  AccentBorderCallout1,
  
  /// <summary>
  /// Callout 2 with Border and Accent Shape.
  /// </summary>
  [XmlEnum("accentBorderCallout2")]
  AccentBorderCallout2,
  
  /// <summary>
  /// Callout 3 with Border and Accent Shape.
  /// </summary>
  [XmlEnum("accentBorderCallout3")]
  AccentBorderCallout3,
  
  /// <summary>
  /// Callout Wedge Rectangle Shape.
  /// </summary>
  [XmlEnum("wedgeRectCallout")]
  WedgeRectangleCallout,
  
  /// <summary>
  /// Callout Wedge Round Rectangle Shape.
  /// </summary>
  [XmlEnum("wedgeRoundRectCallout")]
  WedgeRoundRectangleCallout,
  
  /// <summary>
  /// Callout Wedge Ellipse Shape.
  /// </summary>
  [XmlEnum("wedgeEllipseCallout")]
  WedgeEllipseCallout,
  
  /// <summary>
  /// Callout Cloud Shape.
  /// </summary>
  [XmlEnum("cloudCallout")]
  CloudCallout,
  
  /// <summary>
  /// Cloud Shape.
  /// </summary>
  [XmlEnum("cloud")]
  Cloud,
  
  /// <summary>
  /// Ribbon Shape.
  /// </summary>
  [XmlEnum("ribbon")]
  Ribbon,
  
  /// <summary>
  /// Ribbon 2 Shape.
  /// </summary>
  [XmlEnum("ribbon2")]
  Ribbon2,
  
  /// <summary>
  /// Ellipse Ribbon Shape.
  /// </summary>
  [XmlEnum("ellipseRibbon")]
  EllipseRibbon,
  
  /// <summary>
  /// Ellipse Ribbon 2 Shape.
  /// </summary>
  [XmlEnum("ellipseRibbon2")]
  EllipseRibbon2,
  
  /// <summary>
  /// Left Right Ribbon Shape.
  /// </summary>
  [XmlEnum("leftRightRibbon")]
  LeftRightRibbon,
  
  /// <summary>
  /// Vertical Scroll Shape.
  /// </summary>
  [XmlEnum("verticalScroll")]
  VerticalScroll,
  
  /// <summary>
  /// Horizontal Scroll Shape.
  /// </summary>
  [XmlEnum("horizontalScroll")]
  HorizontalScroll,
  
  /// <summary>
  /// Wave Shape.
  /// </summary>
  [XmlEnum("wave")]
  Wave,
  
  /// <summary>
  /// Double Wave Shape.
  /// </summary>
  [XmlEnum("doubleWave")]
  DoubleWave,
  
  /// <summary>
  /// Plus Shape.
  /// </summary>
  [XmlEnum("plus")]
  Plus,
  
  /// <summary>
  /// Process Flow Shape.
  /// </summary>
  [XmlEnum("flowChartProcess")]
  FlowChartProcess,
  
  /// <summary>
  /// Decision Flow Shape.
  /// </summary>
  [XmlEnum("flowChartDecision")]
  FlowChartDecision,
  
  /// <summary>
  /// Input Output Flow Shape.
  /// </summary>
  [XmlEnum("flowChartInputOutput")]
  FlowChartInputOutput,
  
  /// <summary>
  /// Predefined Process Flow Shape.
  /// </summary>
  [XmlEnum("flowChartPredefinedProcess")]
  FlowChartPredefinedProcess,
  
  /// <summary>
  /// Internal Storage Flow Shape.
  /// </summary>
  [XmlEnum("flowChartInternalStorage")]
  FlowChartInternalStorage,
  
  /// <summary>
  /// Document Flow Shape.
  /// </summary>
  [XmlEnum("flowChartDocument")]
  FlowChartDocument,
  
  /// <summary>
  /// Multi-Document Flow Shape.
  /// </summary>
  [XmlEnum("flowChartMultidocument")]
  FlowChartMultidocument,
  
  /// <summary>
  /// Terminator Flow Shape.
  /// </summary>
  [XmlEnum("flowChartTerminator")]
  FlowChartTerminator,
  
  /// <summary>
  /// Preparation Flow Shape.
  /// </summary>
  [XmlEnum("flowChartPreparation")]
  FlowChartPreparation,
  
  /// <summary>
  /// Manual Input Flow Shape.
  /// </summary>
  [XmlEnum("flowChartManualInput")]
  FlowChartManualInput,
  
  /// <summary>
  /// Manual Operation Flow Shape.
  /// </summary>
  [XmlEnum("flowChartManualOperation")]
  FlowChartManualOperation,
  
  /// <summary>
  /// Connector Flow Shape.
  /// </summary>
  [XmlEnum("flowChartConnector")]
  FlowChartConnector,
  
  /// <summary>
  /// Punched Card Flow Shape.
  /// </summary>
  [XmlEnum("flowChartPunchedCard")]
  FlowChartPunchedCard,
  
  /// <summary>
  /// Punched Tape Flow Shape.
  /// </summary>
  [XmlEnum("flowChartPunchedTape")]
  FlowChartPunchedTape,
  
  /// <summary>
  /// Summing Junction Flow Shape.
  /// </summary>
  [XmlEnum("flowChartSummingJunction")]
  FlowChartSummingJunction,
  
  /// <summary>
  /// Or Flow Shape.
  /// </summary>
  [XmlEnum("flowChartOr")]
  FlowChartOr,
  
  /// <summary>
  /// Collate Flow Shape.
  /// </summary>
  [XmlEnum("flowChartCollate")]
  FlowChartCollate,
  
  /// <summary>
  /// Sort Flow Shape.
  /// </summary>
  [XmlEnum("flowChartSort")]
  FlowChartSort,
  
  /// <summary>
  /// Extract Flow Shape.
  /// </summary>
  [XmlEnum("flowChartExtract")]
  FlowChartExtract,
  
  /// <summary>
  /// Merge Flow Shape.
  /// </summary>
  [XmlEnum("flowChartMerge")]
  FlowChartMerge,
  
  /// <summary>
  /// Offline Storage Flow Shape.
  /// </summary>
  [XmlEnum("flowChartOfflineStorage")]
  FlowChartOfflineStorage,
  
  /// <summary>
  /// Online Storage Flow Shape.
  /// </summary>
  [XmlEnum("flowChartOnlineStorage")]
  FlowChartOnlineStorage,
  
  /// <summary>
  /// Magnetic Tape Flow Shape.
  /// </summary>
  [XmlEnum("flowChartMagneticTape")]
  FlowChartMagneticTape,
  
  /// <summary>
  /// Magnetic Disk Flow Shape.
  /// </summary>
  [XmlEnum("flowChartMagneticDisk")]
  FlowChartMagneticDisk,
  
  /// <summary>
  /// Magnetic Drum Flow Shape.
  /// </summary>
  [XmlEnum("flowChartMagneticDrum")]
  FlowChartMagneticDrum,
  
  /// <summary>
  /// Display Flow Shape.
  /// </summary>
  [XmlEnum("flowChartDisplay")]
  FlowChartDisplay,
  
  /// <summary>
  /// Delay Flow Shape.
  /// </summary>
  [XmlEnum("flowChartDelay")]
  FlowChartDelay,
  
  /// <summary>
  /// Alternate Process Flow Shape.
  /// </summary>
  [XmlEnum("flowChartAlternateProcess")]
  FlowChartAlternateProcess,
  
  /// <summary>
  /// Off-Page Connector Flow Shape.
  /// </summary>
  [XmlEnum("flowChartOffpageConnector")]
  FlowChartOffpageConnector,
  
  /// <summary>
  /// Blank Button Shape.
  /// </summary>
  [XmlEnum("actionButtonBlank")]
  ActionButtonBlank,
  
  /// <summary>
  /// Home Button Shape.
  /// </summary>
  [XmlEnum("actionButtonHome")]
  ActionButtonHome,
  
  /// <summary>
  /// Help Button Shape.
  /// </summary>
  [XmlEnum("actionButtonHelp")]
  ActionButtonHelp,
  
  /// <summary>
  /// Information Button Shape.
  /// </summary>
  [XmlEnum("actionButtonInformation")]
  ActionButtonInformation,
  
  /// <summary>
  /// Forward or Next Button Shape.
  /// </summary>
  [XmlEnum("actionButtonForwardNext")]
  ActionButtonForwardNext,
  
  /// <summary>
  /// Back or Previous Button Shape.
  /// </summary>
  [XmlEnum("actionButtonBackPrevious")]
  ActionButtonBackPrevious,
  
  /// <summary>
  /// End Button Shape.
  /// </summary>
  [XmlEnum("actionButtonEnd")]
  ActionButtonEnd,
  
  /// <summary>
  /// Beginning Button Shape.
  /// </summary>
  [XmlEnum("actionButtonBeginning")]
  ActionButtonBeginning,
  
  /// <summary>
  /// Return Button Shape.
  /// </summary>
  [XmlEnum("actionButtonReturn")]
  ActionButtonReturn,
  
  /// <summary>
  /// Document Button Shape.
  /// </summary>
  [XmlEnum("actionButtonDocument")]
  ActionButtonDocument,
  
  /// <summary>
  /// Sound Button Shape.
  /// </summary>
  [XmlEnum("actionButtonSound")]
  ActionButtonSound,
  
  /// <summary>
  /// Movie Button Shape.
  /// </summary>
  [XmlEnum("actionButtonMovie")]
  ActionButtonMovie,
  
  /// <summary>
  /// Gear 6 Shape.
  /// </summary>
  [XmlEnum("gear6")]
  Gear6,
  
  /// <summary>
  /// Gear 9 Shape.
  /// </summary>
  [XmlEnum("gear9")]
  Gear9,
  
  /// <summary>
  /// Funnel Shape.
  /// </summary>
  [XmlEnum("funnel")]
  Funnel,
  
  /// <summary>
  /// Plus Math Shape.
  /// </summary>
  [XmlEnum("mathPlus")]
  MathPlus,
  
  /// <summary>
  /// Minus Math Shape.
  /// </summary>
  [XmlEnum("mathMinus")]
  MathMinus,
  
  /// <summary>
  /// Multiply Math Shape.
  /// </summary>
  [XmlEnum("mathMultiply")]
  MathMultiply,
  
  /// <summary>
  /// Divide Math Shape.
  /// </summary>
  [XmlEnum("mathDivide")]
  MathDivide,
  
  /// <summary>
  /// Equal Math Shape.
  /// </summary>
  [XmlEnum("mathEqual")]
  MathEqual,
  
  /// <summary>
  /// Not Equal Math Shape.
  /// </summary>
  [XmlEnum("mathNotEqual")]
  MathNotEqual,
  
  /// <summary>
  /// Corner Tabs Shape.
  /// </summary>
  [XmlEnum("cornerTabs")]
  CornerTabs,
  
  /// <summary>
  /// Square Tabs Shape.
  /// </summary>
  [XmlEnum("squareTabs")]
  SquareTabs,
  
  /// <summary>
  /// Plaque Tabs Shape.
  /// </summary>
  [XmlEnum("plaqueTabs")]
  PlaqueTabs,
  
  /// <summary>
  /// Chart X Shape.
  /// </summary>
  [XmlEnum("chartX")]
  ChartX,
  
  /// <summary>
  /// Chart Star Shape.
  /// </summary>
  [XmlEnum("chartStar")]
  ChartStar,
  
  /// <summary>
  /// Chart Plus Shape.
  /// </summary>
  [XmlEnum("chartPlus")]
  ChartPlus,
  
}
