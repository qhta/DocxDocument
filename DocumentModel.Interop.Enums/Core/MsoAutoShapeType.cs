namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the shape type for an AutoShape object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoautoshapetype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoAutoShapeType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Rectangle.
  /// </summary>
  Rectangle = 1,
  /// <summary>
  /// Parallelogram.
  /// </summary>
  Parallelogram = 2,
  /// <summary>
  /// Trapezoid.
  /// </summary>
  Trapezoid = 3,
  /// <summary>
  /// Diamond.
  /// </summary>
  Diamond = 4,
  /// <summary>
  /// Rounded rectangle.
  /// </summary>
  RoundedRectangle = 5,
  /// <summary>
  /// Octagon.
  /// </summary>
  Octagon = 6,
  /// <summary>
  /// Isosceles triangle.
  /// </summary>
  IsoscelesTriangle = 7,
  /// <summary>
  /// Right triangle.
  /// </summary>
  RightTriangle = 8,
  /// <summary>
  /// Oval.
  /// </summary>
  Oval = 9,
  /// <summary>
  /// Hexagon.
  /// </summary>
  Hexagon = 10,
  /// <summary>
  /// Cross. public enum class MsoAutoShapeType
  /// </summary>
  Cross = 11,
  /// <summary>
  /// Pentagon.
  /// </summary>
  RegularPentagon = 12,
  /// <summary>
  /// Can.
  /// </summary>
  Can = 13,
  /// <summary>
  /// Cube.
  /// </summary>
  Cube = 14,
  /// <summary>
  /// Bevel.
  /// </summary>
  Bevel = 15,
  /// <summary>
  /// Folded corner.
  /// </summary>
  FoldedCorner = 16,
  /// <summary>
  /// Smiley face.
  /// </summary>
  SmileyFace = 17,
  /// <summary>
  /// Donut.
  /// </summary>
  Donut = 18,
  /// <summary>
  /// "No" symbol.
  /// </summary>
  NoSymbol = 19,
  /// <summary>
  /// Block arc.
  /// </summary>
  BlockArc = 20,
  /// <summary>
  /// Heart.
  /// </summary>
  Heart = 21,
  /// <summary>
  /// Lightning bolt.
  /// </summary>
  LightningBolt = 22,
  /// <summary>
  /// Sun.
  /// </summary>
  Sun = 23,
  /// <summary>
  /// Moon.
  /// </summary>
  Moon = 24,
  /// <summary>
  /// Arc.
  /// </summary>
  Arc = 25,
  /// <summary>
  /// Double bracket.
  /// </summary>
  DoubleBracket = 26,
  /// <summary>
  /// Double brace.
  /// </summary>
  DoubleBrace = 27,
  /// <summary>
  /// Plaque.
  /// </summary>
  Plaque = 28,
  /// <summary>
  /// Left bracket.
  /// </summary>
  LeftBracket = 29,
  /// <summary>
  /// Right bracket.
  /// </summary>
  RightBracket = 30,
  /// <summary>
  /// Left brace.
  /// </summary>
  LeftBrace = 31,
  /// <summary>
  /// Right brace.
  /// </summary>
  RightBrace = 32,
  /// <summary>
  /// Block arrow that points right.
  /// </summary>
  RightArrow = 33,
  /// <summary>
  /// Block arrow that points left.
  /// </summary>
  LeftArrow = 34,
  /// <summary>
  /// Block arrow that points up.
  /// </summary>
  UpArrow = 35,
  /// <summary>
  /// Block arrow that points down.
  /// </summary>
  DownArrow = 36,
  /// <summary>
  /// Block arrow with arrowheads that point both left and right.
  /// </summary>
  LeftRightArrow = 37,
  /// <summary>
  /// Block arrow that points up and down.
  /// </summary>
  UpDownArrow = 38,
  /// <summary>
  /// Block arrows that point up, down, left, and right.
  /// </summary>
  QuadArrow = 39,
  /// <summary>
  /// Block arrow with arrowheads that point left, right, and up.
  /// </summary>
  LeftRightUpArrow = 40,
  /// <summary>
  /// Block arrow that follows a curved 90-degree angle.
  /// </summary>
  BentArrow = 41,
  /// <summary>
  /// Block arrow forming a U shape.
  /// </summary>
  UTurnArrow = 42,
  /// <summary>
  /// Block arrow with arrowheads that point left and up.
  /// </summary>
  LeftUpArrow = 43,
  /// <summary>
  /// Block arrow that follows a sharp 90-degree angle. Points up by default.
  /// </summary>
  BentUpArrow = 44,
  /// <summary>
  /// Block arrow that curves right.
  /// </summary>
  CurvedRightArrow = 45,
  /// <summary>
  /// Block arrow that curves left.
  /// </summary>
  CurvedLeftArrow = 46,
  /// <summary>
  /// Block arrow that curves up.
  /// </summary>
  CurvedUpArrow = 47,
  /// <summary>
  /// Block arrow that curves down.
  /// </summary>
  CurvedDownArrow = 48,
  /// <summary>
  /// Block arrow that points right with stripes at the tail.
  /// </summary>
  StripedRightArrow = 49,
  /// <summary>
  /// Notched block arrow that points right.
  /// </summary>
  NotchedRightArrow = 50,
  /// <summary>
  /// Pentagon.
  /// </summary>
  Pentagon = 51,
  /// <summary>
  /// Chevron.
  /// </summary>
  Chevron = 52,
  /// <summary>
  /// Callout with arrow that points right.
  /// </summary>
  RightArrowCallout = 53,
  /// <summary>
  /// Callout with arrow that points left.
  /// </summary>
  LeftArrowCallout = 54,
  /// <summary>
  /// Callout with arrow that points up.
  /// </summary>
  UpArrowCallout = 55,
  /// <summary>
  /// Callout with arrow that points down.
  /// </summary>
  DownArrowCallout = 56,
  /// <summary>
  /// Callout with arrowheads that point both left and right.
  /// </summary>
  LeftRightArrowCallout = 57,
  /// <summary>
  /// Callout with arrows that point up and down.
  /// </summary>
  UpDownArrowCallout = 58,
  /// <summary>
  /// Callout with arrows that point up, down, left, and right.
  /// </summary>
  QuadArrowCallout = 59,
  /// <summary>
  /// Block arrow that follows a curved 180-degree angle.
  /// </summary>
  CircularArrow = 60,
  /// <summary>
  /// Process flowchart symbol.
  /// </summary>
  FlowchartProcess = 61,
  /// <summary>
  /// Alternate process flowchart symbol.
  /// </summary>
  FlowchartAlternateProcess = 62,
  /// <summary>
  /// Decision flowchart symbol.
  /// </summary>
  FlowchartDecision = 63,
  /// <summary>
  /// Data flowchart symbol.
  /// </summary>
  FlowchartData = 64,
  /// <summary>
  /// Predefined process flowchart symbol.
  /// </summary>
  FlowchartPredefinedProcess = 65,
  /// <summary>
  /// Internal storage flowchart symbol.
  /// </summary>
  FlowchartInternalStorage = 66,
  /// <summary>
  /// Document flowchart symbol.
  /// </summary>
  FlowchartDocument = 67,
  /// <summary>
  /// Multi-document flowchart symbol.
  /// </summary>
  FlowchartMultidocument = 68,
  /// <summary>
  /// Terminator flowchart symbol.
  /// </summary>
  FlowchartTerminator = 69,
  /// <summary>
  /// Preparation flowchart symbol.
  /// </summary>
  FlowchartPreparation = 70,
  /// <summary>
  /// Manual input flowchart symbol.
  /// </summary>
  FlowchartManualInput = 71,
  /// <summary>
  /// Manual operation flowchart symbol.
  /// </summary>
  FlowchartManualOperation = 72,
  /// <summary>
  /// Connector flowchart symbol.
  /// </summary>
  FlowchartConnector = 73,
  /// <summary>
  /// Off-page connector flowchart symbol.
  /// </summary>
  FlowchartOffpageConnector = 74,
  /// <summary>
  /// Card flowchart symbol.
  /// </summary>
  FlowchartCard = 75,
  /// <summary>
  /// Punched tape flowchart symbol.
  /// </summary>
  FlowchartPunchedTape = 76,
  /// <summary>
  /// Summing junction flowchart symbol.
  /// </summary>
  FlowchartSummingJunction = 77,
  /// <summary>
  /// "Or" flowchart symbol.
  /// </summary>
  FlowchartOr = 78,
  /// <summary>
  /// Collate flowchart symbol.
  /// </summary>
  FlowchartCollate = 79,
  /// <summary>
  /// Sort flowchart symbol.
  /// </summary>
  FlowchartSort = 80,
  /// <summary>
  /// Extract flowchart symbol.
  /// </summary>
  FlowchartExtract = 81,
  /// <summary>
  /// Merge flowchart symbol.
  /// </summary>
  FlowchartMerge = 82,
  /// <summary>
  /// Stored data flowchart symbol.
  /// </summary>
  FlowchartStoredData = 83,
  /// <summary>
  /// Delay flowchart symbol.
  /// </summary>
  FlowchartDelay = 84,
  /// <summary>
  /// Sequential access storage flowchart symbol.
  /// </summary>
  FlowchartSequentialAccessStorage = 85,
  /// <summary>
  /// Magnetic disk flowchart symbol.
  /// </summary>
  FlowchartMagneticDisk = 86,
  /// <summary>
  /// Direct access storage flowchart symbol.
  /// </summary>
  FlowchartDirectAccessStorage = 87,
  /// <summary>
  /// Display flowchart symbol.
  /// </summary>
  FlowchartDisplay = 88,
  /// <summary>
  /// Explosion.
  /// </summary>
  Explosion1 = 89,
  /// <summary>
  /// Explosion.
  /// </summary>
  Explosion2 = 90,
  /// <summary>
  /// 4-point star.
  /// </summary>
  FourPointStar = 91,
  /// <summary>
  /// 5-point star.
  /// </summary>
  FivePointStar = 92,
  /// <summary>
  /// 8-point star.
  /// </summary>
  EightPointStar = 93,
  /// <summary>
  /// 16-point star.
  /// </summary>
  SixteenPointStar = 94,
  /// <summary>
  /// 24-point star.
  /// </summary>
  TwentyFourPointStar = 95,
  /// <summary>
  /// 32-point star.
  /// </summary>
  ThirtyTwoPointStar = 96,
  /// <summary>
  /// Ribbon banner with center area above ribbon ends.
  /// </summary>
  UpRibbon = 97,
  /// <summary>
  /// Ribbon banner with center area below ribbon ends.
  /// </summary>
  DownRibbon = 98,
  /// <summary>
  /// Ribbon banner that curves up.
  /// </summary>
  CurvedUpRibbon = 99,
  /// <summary>
  /// Ribbon banner that curves down.
  /// </summary>
  CurvedDownRibbon = 100,
  /// <summary>
  /// Vertical scroll.
  /// </summary>
  VerticalScroll = 101,
  /// <summary>
  /// Horizontal scroll.
  /// </summary>
  HorizontalScroll = 102,
  /// <summary>
  /// Wave.
  /// </summary>
  Wave = 103,
  /// <summary>
  /// Double wave.
  /// </summary>
  DoubleWave = 104,
  /// <summary>
  /// Rectangular callout.
  /// </summary>
  RectangularCallout = 105,
  /// <summary>
  /// Rounded rectangle-shaped callout.
  /// </summary>
  RoundedRectangularCallout = 106,
  /// <summary>
  /// Oval-shaped callout.
  /// </summary>
  OvalCallout = 107,
  /// <summary>
  /// Cloud callout.
  /// </summary>
  CloudCallout = 108,
  /// <summary>
  /// Callout with border and horizontal callout line.
  /// </summary>
  LineCallout1 = 109,
  /// <summary>
  /// Callout with diagonal straight line.
  /// </summary>
  LineCallout2 = 110,
  /// <summary>
  /// Callout with angled line.
  /// </summary>
  LineCallout3 = 111,
  /// <summary>
  /// Callout with callout line segments forming a U- shape.
  /// </summary>
  LineCallout4 = 112,
  /// <summary>
  /// Callout with horizontal accent bar.
  /// </summary>
  LineCallout1AccentBar = 113,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  LineCallout2AccentBar = 114,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  LineCallout3AccentBar = 115,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  LineCallout4AccentBar = 116,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  LineCallout1NoBorder = 117,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  LineCallout2NoBorder = 118,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  LineCallout3NoBorder = 119,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  LineCallout4NoBorder = 120,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  LineCallout1BorderandAccentBar = 121,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  LineCallout2BorderandAccentBar = 122,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  LineCallout3BorderandAccentBar = 123,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  LineCallout4BorderandAccentBar = 124,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  ActionButtonCustom = 125,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  ActionButtonHome = 126,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  ActionButtonHelp = 127,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  ActionButtonInformation = 128,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  ActionButtonBackorPrevious = 129,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  ActionButtonForwardorNext = 130,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  ActionButtonBeginning = 131,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  ActionButtonEnd = 132,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  ActionButtonReturn = 133,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  ActionButtonDocument = 134,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  ActionButtonSound = 135,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  ActionButtonMovie = 136,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Balloon = 137,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  NotPrimitive = 138,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  FlowchartOfflineStorage = 139,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  LeftRightRibbon = 140,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  DiagonalStripe = 141,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Pie = 142,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  NonIsoscelesTrapezoid = 143,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Decagon = 144,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Heptagon = 145,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Dodecagon = 146,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  SixPointStar = 147,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  SevenPointStar = 148,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  TenPointStar = 149,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  TwelvePointStar = 150,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Round1Rectangle = 151,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Round2SameRectangle = 152,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Round2DiagRectangle = 153,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  SnipRoundRectangle = 154,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Snip1Rectangle = 155,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Snip2SameRectangle = 156,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Snip2DiagRectangle = 157,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Frame = 158,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  HalfFrame = 159,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Tear = 160,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Chord = 161,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Corner = 162,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  MathPlus = 163,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  MathMinus = 164,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  MathMultiply = 165,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  MathDivide = 166,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  MathEqual = 167,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  MathNotEqual = 168,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  CornerTabs = 169,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  SquareTabs = 170,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  PlaqueTabs = 171,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Gear6 = 172,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Gear9 = 173,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Funnel = 174,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  PieWedge = 175,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  LeftCircularArrow = 176,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  LeftRightCircularArrow = 177,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  SwooshArrow = 178,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  Cloud = 179,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  ChartX = 180,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  ChartStar = 181,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  ChartPlus = 182,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  LineInverse = 183
}
