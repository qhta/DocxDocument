namespace DocumentModel.Drawing;

public enum ShapeType
{
  
  [XmlEnum("line")]
  Line,
  
  [XmlEnum("lineInv")]
  LineInverse,
  
  [XmlEnum("triangle")]
  Triangle,
  
  [XmlEnum("rtTriangle")]
  RightTriangle,
  
  [XmlEnum("rect")]
  Rectangle,
  
  [XmlEnum("diamond")]
  Diamond,
  
  [XmlEnum("parallelogram")]
  Parallelogram,
  
  [XmlEnum("trapezoid")]
  Trapezoid,
  
  [XmlEnum("nonIsoscelesTrapezoid")]
  NonIsoscelesTrapezoid,
  
  [XmlEnum("pentagon")]
  Pentagon,
  
  [XmlEnum("hexagon")]
  Hexagon,
  
  [XmlEnum("heptagon")]
  Heptagon,
  
  [XmlEnum("octagon")]
  Octagon,
  
  [XmlEnum("decagon")]
  Decagon,
  
  [XmlEnum("dodecagon")]
  Dodecagon,
  
  [XmlEnum("star4")]
  Star4,
  
  [XmlEnum("star5")]
  Star5,
  
  [XmlEnum("star6")]
  Star6,
  
  [XmlEnum("star7")]
  Star7,
  
  [XmlEnum("star8")]
  Star8,
  
  [XmlEnum("star10")]
  Star10,
  
  [XmlEnum("star12")]
  Star12,
  
  [XmlEnum("star16")]
  Star16,
  
  [XmlEnum("star24")]
  Star24,
  
  [XmlEnum("star32")]
  Star32,
  
  [XmlEnum("roundRect")]
  RoundRectangle,
  
  [XmlEnum("round1Rect")]
  Round1Rectangle,
  
  [XmlEnum("round2SameRect")]
  Round2SameRectangle,
  
  [XmlEnum("round2DiagRect")]
  Round2DiagonalRectangle,
  
  [XmlEnum("snipRoundRect")]
  SnipRoundRectangle,
  
  [XmlEnum("snip1Rect")]
  Snip1Rectangle,
  
  [XmlEnum("snip2SameRect")]
  Snip2SameRectangle,
  
  [XmlEnum("snip2DiagRect")]
  Snip2DiagonalRectangle,
  
  [XmlEnum("plaque")]
  Plaque,
  
  [XmlEnum("ellipse")]
  Ellipse,
  
  [XmlEnum("teardrop")]
  Teardrop,
  
  [XmlEnum("homePlate")]
  HomePlate,
  
  [XmlEnum("chevron")]
  Chevron,
  
  [XmlEnum("pieWedge")]
  PieWedge,
  
  [XmlEnum("pie")]
  Pie,
  
  [XmlEnum("blockArc")]
  BlockArc,
  
  [XmlEnum("donut")]
  Donut,
  
  [XmlEnum("noSmoking")]
  NoSmoking,
  
  [XmlEnum("rightArrow")]
  RightArrow,
  
  [XmlEnum("leftArrow")]
  LeftArrow,
  
  [XmlEnum("upArrow")]
  UpArrow,
  
  [XmlEnum("downArrow")]
  DownArrow,
  
  [XmlEnum("stripedRightArrow")]
  StripedRightArrow,
  
  [XmlEnum("notchedRightArrow")]
  NotchedRightArrow,
  
  [XmlEnum("bentUpArrow")]
  BentUpArrow,
  
  [XmlEnum("leftRightArrow")]
  LeftRightArrow,
  
  [XmlEnum("upDownArrow")]
  UpDownArrow,
  
  [XmlEnum("leftUpArrow")]
  LeftUpArrow,
  
  [XmlEnum("leftRightUpArrow")]
  LeftRightUpArrow,
  
  [XmlEnum("quadArrow")]
  QuadArrow,
  
  [XmlEnum("leftArrowCallout")]
  LeftArrowCallout,
  
  [XmlEnum("rightArrowCallout")]
  RightArrowCallout,
  
  [XmlEnum("upArrowCallout")]
  UpArrowCallout,
  
  [XmlEnum("downArrowCallout")]
  DownArrowCallout,
  
  [XmlEnum("leftRightArrowCallout")]
  LeftRightArrowCallout,
  
  [XmlEnum("upDownArrowCallout")]
  UpDownArrowCallout,
  
  [XmlEnum("quadArrowCallout")]
  QuadArrowCallout,
  
  [XmlEnum("bentArrow")]
  BentArrow,
  
  [XmlEnum("uturnArrow")]
  UTurnArrow,
  
  [XmlEnum("circularArrow")]
  CircularArrow,
  
  [XmlEnum("leftCircularArrow")]
  LeftCircularArrow,
  
  [XmlEnum("leftRightCircularArrow")]
  LeftRightCircularArrow,
  
  [XmlEnum("curvedRightArrow")]
  CurvedRightArrow,
  
  [XmlEnum("curvedLeftArrow")]
  CurvedLeftArrow,
  
  [XmlEnum("curvedUpArrow")]
  CurvedUpArrow,
  
  [XmlEnum("curvedDownArrow")]
  CurvedDownArrow,
  
  [XmlEnum("swooshArrow")]
  SwooshArrow,
  
  [XmlEnum("cube")]
  Cube,
  
  [XmlEnum("can")]
  Can,
  
  [XmlEnum("lightningBolt")]
  LightningBolt,
  
  [XmlEnum("heart")]
  Heart,
  
  [XmlEnum("sun")]
  Sun,
  
  [XmlEnum("moon")]
  Moon,
  
  [XmlEnum("smileyFace")]
  SmileyFace,
  
  [XmlEnum("irregularSeal1")]
  IrregularSeal1,
  
  [XmlEnum("irregularSeal2")]
  IrregularSeal2,
  
  [XmlEnum("foldedCorner")]
  FoldedCorner,
  
  [XmlEnum("bevel")]
  Bevel,
  
  [XmlEnum("frame")]
  Frame,
  
  [XmlEnum("halfFrame")]
  HalfFrame,
  
  [XmlEnum("corner")]
  Corner,
  
  [XmlEnum("diagStripe")]
  DiagonalStripe,
  
  [XmlEnum("chord")]
  Chord,
  
  [XmlEnum("arc")]
  Arc,
  
  [XmlEnum("leftBracket")]
  LeftBracket,
  
  [XmlEnum("rightBracket")]
  RightBracket,
  
  [XmlEnum("leftBrace")]
  LeftBrace,
  
  [XmlEnum("rightBrace")]
  RightBrace,
  
  [XmlEnum("bracketPair")]
  BracketPair,
  
  [XmlEnum("bracePair")]
  BracePair,
  
  [XmlEnum("straightConnector1")]
  StraightConnector1,
  
  [XmlEnum("bentConnector2")]
  BentConnector2,
  
  [XmlEnum("bentConnector3")]
  BentConnector3,
  
  [XmlEnum("bentConnector4")]
  BentConnector4,
  
  [XmlEnum("bentConnector5")]
  BentConnector5,
  
  [XmlEnum("curvedConnector2")]
  CurvedConnector2,
  
  [XmlEnum("curvedConnector3")]
  CurvedConnector3,
  
  [XmlEnum("curvedConnector4")]
  CurvedConnector4,
  
  [XmlEnum("curvedConnector5")]
  CurvedConnector5,
  
  [XmlEnum("callout1")]
  Callout1,
  
  [XmlEnum("callout2")]
  Callout2,
  
  [XmlEnum("callout3")]
  Callout3,
  
  [XmlEnum("accentCallout1")]
  AccentCallout1,
  
  [XmlEnum("accentCallout2")]
  AccentCallout2,
  
  [XmlEnum("accentCallout3")]
  AccentCallout3,
  
  [XmlEnum("borderCallout1")]
  BorderCallout1,
  
  [XmlEnum("borderCallout2")]
  BorderCallout2,
  
  [XmlEnum("borderCallout3")]
  BorderCallout3,
  
  [XmlEnum("accentBorderCallout1")]
  AccentBorderCallout1,
  
  [XmlEnum("accentBorderCallout2")]
  AccentBorderCallout2,
  
  [XmlEnum("accentBorderCallout3")]
  AccentBorderCallout3,
  
  [XmlEnum("wedgeRectCallout")]
  WedgeRectangleCallout,
  
  [XmlEnum("wedgeRoundRectCallout")]
  WedgeRoundRectangleCallout,
  
  [XmlEnum("wedgeEllipseCallout")]
  WedgeEllipseCallout,
  
  [XmlEnum("cloudCallout")]
  CloudCallout,
  
  [XmlEnum("cloud")]
  Cloud,
  
  [XmlEnum("ribbon")]
  Ribbon,
  
  [XmlEnum("ribbon2")]
  Ribbon2,
  
  [XmlEnum("ellipseRibbon")]
  EllipseRibbon,
  
  [XmlEnum("ellipseRibbon2")]
  EllipseRibbon2,
  
  [XmlEnum("leftRightRibbon")]
  LeftRightRibbon,
  
  [XmlEnum("verticalScroll")]
  VerticalScroll,
  
  [XmlEnum("horizontalScroll")]
  HorizontalScroll,
  
  [XmlEnum("wave")]
  Wave,
  
  [XmlEnum("doubleWave")]
  DoubleWave,
  
  [XmlEnum("plus")]
  Plus,
  
  [XmlEnum("flowChartProcess")]
  FlowChartProcess,
  
  [XmlEnum("flowChartDecision")]
  FlowChartDecision,
  
  [XmlEnum("flowChartInputOutput")]
  FlowChartInputOutput,
  
  [XmlEnum("flowChartPredefinedProcess")]
  FlowChartPredefinedProcess,
  
  [XmlEnum("flowChartInternalStorage")]
  FlowChartInternalStorage,
  
  [XmlEnum("flowChartDocument")]
  FlowChartDocument,
  
  [XmlEnum("flowChartMultidocument")]
  FlowChartMultidocument,
  
  [XmlEnum("flowChartTerminator")]
  FlowChartTerminator,
  
  [XmlEnum("flowChartPreparation")]
  FlowChartPreparation,
  
  [XmlEnum("flowChartManualInput")]
  FlowChartManualInput,
  
  [XmlEnum("flowChartManualOperation")]
  FlowChartManualOperation,
  
  [XmlEnum("flowChartConnector")]
  FlowChartConnector,
  
  [XmlEnum("flowChartPunchedCard")]
  FlowChartPunchedCard,
  
  [XmlEnum("flowChartPunchedTape")]
  FlowChartPunchedTape,
  
  [XmlEnum("flowChartSummingJunction")]
  FlowChartSummingJunction,
  
  [XmlEnum("flowChartOr")]
  FlowChartOr,
  
  [XmlEnum("flowChartCollate")]
  FlowChartCollate,
  
  [XmlEnum("flowChartSort")]
  FlowChartSort,
  
  [XmlEnum("flowChartExtract")]
  FlowChartExtract,
  
  [XmlEnum("flowChartMerge")]
  FlowChartMerge,
  
  [XmlEnum("flowChartOfflineStorage")]
  FlowChartOfflineStorage,
  
  [XmlEnum("flowChartOnlineStorage")]
  FlowChartOnlineStorage,
  
  [XmlEnum("flowChartMagneticTape")]
  FlowChartMagneticTape,
  
  [XmlEnum("flowChartMagneticDisk")]
  FlowChartMagneticDisk,
  
  [XmlEnum("flowChartMagneticDrum")]
  FlowChartMagneticDrum,
  
  [XmlEnum("flowChartDisplay")]
  FlowChartDisplay,
  
  [XmlEnum("flowChartDelay")]
  FlowChartDelay,
  
  [XmlEnum("flowChartAlternateProcess")]
  FlowChartAlternateProcess,
  
  [XmlEnum("flowChartOffpageConnector")]
  FlowChartOffpageConnector,
  
  [XmlEnum("actionButtonBlank")]
  ActionButtonBlank,
  
  [XmlEnum("actionButtonHome")]
  ActionButtonHome,
  
  [XmlEnum("actionButtonHelp")]
  ActionButtonHelp,
  
  [XmlEnum("actionButtonInformation")]
  ActionButtonInformation,
  
  [XmlEnum("actionButtonForwardNext")]
  ActionButtonForwardNext,
  
  [XmlEnum("actionButtonBackPrevious")]
  ActionButtonBackPrevious,
  
  [XmlEnum("actionButtonEnd")]
  ActionButtonEnd,
  
  [XmlEnum("actionButtonBeginning")]
  ActionButtonBeginning,
  
  [XmlEnum("actionButtonReturn")]
  ActionButtonReturn,
  
  [XmlEnum("actionButtonDocument")]
  ActionButtonDocument,
  
  [XmlEnum("actionButtonSound")]
  ActionButtonSound,
  
  [XmlEnum("actionButtonMovie")]
  ActionButtonMovie,
  
  [XmlEnum("gear6")]
  Gear6,
  
  [XmlEnum("gear9")]
  Gear9,
  
  [XmlEnum("funnel")]
  Funnel,
  
  [XmlEnum("mathPlus")]
  MathPlus,
  
  [XmlEnum("mathMinus")]
  MathMinus,
  
  [XmlEnum("mathMultiply")]
  MathMultiply,
  
  [XmlEnum("mathDivide")]
  MathDivide,
  
  [XmlEnum("mathEqual")]
  MathEqual,
  
  [XmlEnum("mathNotEqual")]
  MathNotEqual,
  
  [XmlEnum("cornerTabs")]
  CornerTabs,
  
  [XmlEnum("squareTabs")]
  SquareTabs,
  
  [XmlEnum("plaqueTabs")]
  PlaqueTabs,
  
  [XmlEnum("chartX")]
  ChartX,
  
  [XmlEnum("chartStar")]
  ChartStar,
  
  [XmlEnum("chartPlus")]
  ChartPlus,
}
