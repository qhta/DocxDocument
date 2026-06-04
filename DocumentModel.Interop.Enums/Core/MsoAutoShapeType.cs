namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the shape type for an AutoShape object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoautoshapetype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoAutoShapeType")]
public enum AutoShapeType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [InteropEnumValue("msoShapeMixed")]
  Mixed = -2,
  /// <summary>
  /// Rectangle.
  /// </summary>
  [InteropEnumValue("msoShapeRectangle")]
  Rectangle = 1,
  /// <summary>
  /// Parallelogram.
  /// </summary>
  [InteropEnumValue("msoShapeParallelogram")]
  Parallelogram = 2,
  /// <summary>
  /// Trapezoid.
  /// </summary>
  [InteropEnumValue("msoShapeTrapezoid")]
  Trapezoid = 3,
  /// <summary>
  /// Diamond.
  /// </summary>
  [InteropEnumValue("msoShapeDiamond")]
  Diamond = 4,
  /// <summary>
  /// Rounded rectangle.
  /// </summary>
  [InteropEnumValue("msoShapeRoundedRectangle")]
  RoundedRectangle = 5,
  /// <summary>
  /// Octagon.
  /// </summary>
  [InteropEnumValue("msoShapeOctagon")]
  Octagon = 6,
  /// <summary>
  /// Isosceles triangle.
  /// </summary>
  [InteropEnumValue("msoShapeIsoscelesTriangle")]
  IsoscelesTriangle = 7,
  /// <summary>
  /// Right triangle.
  /// </summary>
  [InteropEnumValue("msoShapeRightTriangle")]
  RightTriangle = 8,
  /// <summary>
  /// Oval.
  /// </summary>
  [InteropEnumValue("msoShapeOval")]
  Oval = 9,
  /// <summary>
  /// Hexagon.
  /// </summary>
  [InteropEnumValue("msoShapeHexagon")]
  Hexagon = 10,
  /// <summary>
  /// Cross.
  /// </summary>
  [InteropEnumValue("msoShapeCross")]
  Cross = 11,
  /// <summary>
  /// Pentagon.
  /// </summary>
  [InteropEnumValue("msoShapeRegularPentagon")]
  RegularPentagon = 12,
  /// <summary>
  /// Can.
  /// </summary>
  [InteropEnumValue("msoShapeCan")]
  Can = 13,
  /// <summary>
  /// Cube.
  /// </summary>
  [InteropEnumValue("msoShapeCube")]
  Cube = 14,
  /// <summary>
  /// Bevel.
  /// </summary>
  [InteropEnumValue("msoShapeBevel")]
  Bevel = 15,
  /// <summary>
  /// Folded corner.
  /// </summary>
  [InteropEnumValue("msoShapeFoldedCorner")]
  FoldedCorner = 16,
  /// <summary>
  /// Smiley face.
  /// </summary>
  [InteropEnumValue("msoShapeSmileyFace")]
  SmileyFace = 17,
  /// <summary>
  /// Donut.
  /// </summary>
  [InteropEnumValue("msoShapeDonut")]
  Donut = 18,
  /// <summary>
  /// "No" symbol.
  /// </summary>
  [InteropEnumValue("msoShapeNoSymbol")]
  NoSymbol = 19,
  /// <summary>
  /// Block arc.
  /// </summary>
  [InteropEnumValue("msoShapeBlockArc")]
  BlockArc = 20,
  /// <summary>
  /// Heart.
  /// </summary>
  [InteropEnumValue("msoShapeHeart")]
  Heart = 21,
  /// <summary>
  /// Lightning bolt.
  /// </summary>
  [InteropEnumValue("msoShapeLightningBolt")]
  LightningBolt = 22,
  /// <summary>
  /// Sun.
  /// </summary>
  [InteropEnumValue("msoShapeSun")]
  Sun = 23,
  /// <summary>
  /// Moon.
  /// </summary>
  [InteropEnumValue("msoShapeMoon")]
  Moon = 24,
  /// <summary>
  /// Arc.
  /// </summary>
  [InteropEnumValue("msoShapeArc")]
  Arc = 25,
  /// <summary>
  /// Double bracket.
  /// </summary>
  [InteropEnumValue("msoShapeDoubleBracket")]
  DoubleBracket = 26,
  /// <summary>
  /// Double brace.
  /// </summary>
  [InteropEnumValue("msoShapeDoubleBrace")]
  DoubleBrace = 27,
  /// <summary>
  /// Plaque.
  /// </summary>
  [InteropEnumValue("msoShapePlaque")]
  Plaque = 28,
  /// <summary>
  /// Left bracket.
  /// </summary>
  [InteropEnumValue("msoShapeLeftBracket")]
  LeftBracket = 29,
  /// <summary>
  /// Right bracket.
  /// </summary>
  [InteropEnumValue("msoShapeRightBracket")]
  RightBracket = 30,
  /// <summary>
  /// Left brace.
  /// </summary>
  [InteropEnumValue("msoShapeLeftBrace")]
  LeftBrace = 31,
  /// <summary>
  /// Right brace.
  /// </summary>
  [InteropEnumValue("msoShapeRightBrace")]
  RightBrace = 32,
  /// <summary>
  /// Block arrow that points right.
  /// </summary>
  [InteropEnumValue("msoShapeRightArrow")]
  RightArrow = 33,
  /// <summary>
  /// Block arrow that points left.
  /// </summary>
  [InteropEnumValue("msoShapeLeftArrow")]
  LeftArrow = 34,
  /// <summary>
  /// Block arrow that points up.
  /// </summary>
  [InteropEnumValue("msoShapeUpArrow")]
  UpArrow = 35,
  /// <summary>
  /// Block arrow that points down.
  /// </summary>
  [InteropEnumValue("msoShapeDownArrow")]
  DownArrow = 36,
  /// <summary>
  /// Block arrow with arrowheads that point both left and right.
  /// </summary>
  [InteropEnumValue("msoShapeLeftRightArrow")]
  LeftRightArrow = 37,
  /// <summary>
  /// Block arrow that points up and down.
  /// </summary>
  [InteropEnumValue("msoShapeUpDownArrow")]
  UpDownArrow = 38,
  /// <summary>
  /// Block arrows that point up, down, left, and right.
  /// </summary>
  [InteropEnumValue("msoShapeQuadArrow")]
  QuadArrow = 39,
  /// <summary>
  /// Block arrow with arrowheads that point left, right, and up.
  /// </summary>
  [InteropEnumValue("msoShapeLeftRightUpArrow")]
  LeftRightUpArrow = 40,
  /// <summary>
  /// Block arrow that follows a curved 90-degree angle.
  /// </summary>
  [InteropEnumValue("msoShapeBentArrow")]
  BentArrow = 41,
  /// <summary>
  /// Block arrow forming a U shape.
  /// </summary>
  [InteropEnumValue("msoShapeUTurnArrow")]
  UTurnArrow = 42,
  /// <summary>
  /// Block arrow with arrowheads that point left and up.
  /// </summary>
  [InteropEnumValue("msoShapeLeftUpArrow")]
  LeftUpArrow = 43,
  /// <summary>
  /// Block arrow that follows a sharp 90-degree angle. Points up by default.
  /// </summary>
  [InteropEnumValue("msoShapeBentUpArrow")]
  BentUpArrow = 44,
  /// <summary>
  /// Block arrow that curves right.
  /// </summary>
  [InteropEnumValue("msoShapeCurvedRightArrow")]
  CurvedRightArrow = 45,
  /// <summary>
  /// Block arrow that curves left.
  /// </summary>
  [InteropEnumValue("msoShapeCurvedLeftArrow")]
  CurvedLeftArrow = 46,
  /// <summary>
  /// Block arrow that curves up.
  /// </summary>
  [InteropEnumValue("msoShapeCurvedUpArrow")]
  CurvedUpArrow = 47,
  /// <summary>
  /// Block arrow that curves down.
  /// </summary>
  [InteropEnumValue("msoShapeCurvedDownArrow")]
  CurvedDownArrow = 48,
  /// <summary>
  /// Block arrow that points right with stripes at the tail.
  /// </summary>
  [InteropEnumValue("msoShapeStripedRightArrow")]
  StripedRightArrow = 49,
  /// <summary>
  /// Notched block arrow that points right.
  /// </summary>
  [InteropEnumValue("msoShapeNotchedRightArrow")]
  NotchedRightArrow = 50,
  /// <summary>
  /// Pentagon.
  /// </summary>
  [InteropEnumValue("msoShapePentagon")]
  Pentagon = 51,
  /// <summary>
  /// Chevron.
  /// </summary>
  [InteropEnumValue("msoShapeChevron")]
  Chevron = 52,
  /// <summary>
  /// Callout with arrow that points right.
  /// </summary>
  [InteropEnumValue("msoShapeRightArrowCallout")]
  RightArrowCallout = 53,
  /// <summary>
  /// Callout with arrow that points left.
  /// </summary>
  [InteropEnumValue("msoShapeLeftArrowCallout")]
  LeftArrowCallout = 54,
  /// <summary>
  /// Callout with arrow that points up.
  /// </summary>
  [InteropEnumValue("msoShapeUpArrowCallout")]
  UpArrowCallout = 55,
  /// <summary>
  /// Callout with arrow that points down.
  /// </summary>
  [InteropEnumValue("msoShapeDownArrowCallout")]
  DownArrowCallout = 56,
  /// <summary>
  /// Callout with arrowheads that point both left and right.
  /// </summary>
  [InteropEnumValue("msoShapeLeftRightArrowCallout")]
  LeftRightArrowCallout = 57,
  /// <summary>
  /// Callout with arrows that point up and down.
  /// </summary>
  [InteropEnumValue("msoShapeUpDownArrowCallout")]
  UpDownArrowCallout = 58,
  /// <summary>
  /// Callout with arrows that point up, down, left, and right.
  /// </summary>
  [InteropEnumValue("msoShapeQuadArrowCallout")]
  QuadArrowCallout = 59,
  /// <summary>
  /// Block arrow that follows a curved 180-degree angle.
  /// </summary>
  [InteropEnumValue("msoShapeCircularArrow")]
  CircularArrow = 60,
  /// <summary>
  /// Process flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartProcess")]
  FlowchartProcess = 61,
  /// <summary>
  /// Alternate process flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartAlternateProcess")]
  FlowchartAlternateProcess = 62,
  /// <summary>
  /// Decision flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartDecision")]
  FlowchartDecision = 63,
  /// <summary>
  /// Data flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartData")]
  FlowchartData = 64,
  /// <summary>
  /// Predefined process flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartPredefinedProcess")]
  FlowchartPredefinedProcess = 65,
  /// <summary>
  /// Internal storage flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartInternalStorage")]
  FlowchartInternalStorage = 66,
  /// <summary>
  /// Document flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartDocument")]
  FlowchartDocument = 67,
  /// <summary>
  /// Multi-document flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartMultidocument")]
  FlowchartMultidocument = 68,
  /// <summary>
  /// Terminator flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartTerminator")]
  FlowchartTerminator = 69,
  /// <summary>
  /// Preparation flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartPreparation")]
  FlowchartPreparation = 70,
  /// <summary>
  /// Manual input flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartManualInput")]
  FlowchartManualInput = 71,
  /// <summary>
  /// Manual operation flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartManualOperation")]
  FlowchartManualOperation = 72,
  /// <summary>
  /// Connector flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartConnector")]
  FlowchartConnector = 73,
  /// <summary>
  /// Off-page connector flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartOffpageConnector")]
  FlowchartOffpageConnector = 74,
  /// <summary>
  /// Card flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartCard")]
  FlowchartCard = 75,
  /// <summary>
  /// Punched tape flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartPunchedTape")]
  FlowchartPunchedTape = 76,
  /// <summary>
  /// Summing junction flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartSummingJunction")]
  FlowchartSummingJunction = 77,
  /// <summary>
  /// "Or" flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartOr")]
  FlowchartOr = 78,
  /// <summary>
  /// Collate flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartCollate")]
  FlowchartCollate = 79,
  /// <summary>
  /// Sort flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartSort")]
  FlowchartSort = 80,
  /// <summary>
  /// Extract flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartExtract")]
  FlowchartExtract = 81,
  /// <summary>
  /// Merge flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartMerge")]
  FlowchartMerge = 82,
  /// <summary>
  /// Stored data flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartStoredData")]
  FlowchartStoredData = 83,
  /// <summary>
  /// Delay flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartDelay")]
  FlowchartDelay = 84,
  /// <summary>
  /// Sequential access storage flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartSequentialAccessStorage")]
  FlowchartSequentialAccessStorage = 85,
  /// <summary>
  /// Magnetic disk flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartMagneticDisk")]
  FlowchartMagneticDisk = 86,
  /// <summary>
  /// Direct access storage flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartDirectAccessStorage")]
  FlowchartDirectAccessStorage = 87,
  /// <summary>
  /// Display flowchart symbol.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartDisplay")]
  FlowchartDisplay = 88,
  /// <summary>
  /// Explosion.
  /// </summary>
  [InteropEnumValue("msoShapeExplosion1")]
  Explosion1 = 89,
  /// <summary>
  /// Explosion.
  /// </summary>
  [InteropEnumValue("msoShapeExplosion2")]
  Explosion2 = 90,
  /// <summary>
  /// 4-point star.
  /// </summary>
  [InteropEnumValue("msoShape4pointStar")]
  FourPointStar = 91,
  /// <summary>
  /// 5-point star.
  /// </summary>
  [InteropEnumValue("msoShape5pointStar")]
  FivePointStar = 92,
  /// <summary>
  /// 8-point star.
  /// </summary>
  [InteropEnumValue("msoShape8pointStar")]
  EightPointStar = 93,
  /// <summary>
  /// 16-point star.
  /// </summary>
  [InteropEnumValue("msoShape16pointStar")]
  SixteenPointStar = 94,
  /// <summary>
  /// 24-point star.
  /// </summary>
  [InteropEnumValue("msoShape24pointStar")]
  TwentyFourPointStar = 95,
  /// <summary>
  /// 32-point star.
  /// </summary>
  [InteropEnumValue("msoShape32pointStar")]
  ThirtyTwoPointStar = 96,
  /// <summary>
  /// Ribbon banner with center area above ribbon ends.
  /// </summary>
  [InteropEnumValue("msoShapeUpRibbon")]
  UpRibbon = 97,
  /// <summary>
  /// Ribbon banner with center area below ribbon ends.
  /// </summary>
  [InteropEnumValue("msoShapeDownRibbon")]
  DownRibbon = 98,
  /// <summary>
  /// Ribbon banner that curves up.
  /// </summary>
  [InteropEnumValue("msoShapeCurvedUpRibbon")]
  CurvedUpRibbon = 99,
  /// <summary>
  /// Ribbon banner that curves down.
  /// </summary>
  [InteropEnumValue("msoShapeCurvedDownRibbon")]
  CurvedDownRibbon = 100,
  /// <summary>
  /// Vertical scroll.
  /// </summary>
  [InteropEnumValue("msoShapeVerticalScroll")]
  VerticalScroll = 101,
  /// <summary>
  /// Horizontal scroll.
  /// </summary>
  [InteropEnumValue("msoShapeHorizontalScroll")]
  HorizontalScroll = 102,
  /// <summary>
  /// Wave.
  /// </summary>
  [InteropEnumValue("msoShapeWave")]
  Wave = 103,
  /// <summary>
  /// Double wave.
  /// </summary>
  [InteropEnumValue("msoShapeDoubleWave")]
  DoubleWave = 104,
  /// <summary>
  /// Rectangular callout.
  /// </summary>
  [InteropEnumValue("msoShapeRectangularCallout")]
  RectangularCallout = 105,
  /// <summary>
  /// Rounded rectangle-shaped callout.
  /// </summary>
  [InteropEnumValue("msoShapeRoundedRectangularCallout")]
  RoundedRectangularCallout = 106,
  /// <summary>
  /// Oval-shaped callout.
  /// </summary>
  [InteropEnumValue("msoShapeOvalCallout")]
  OvalCallout = 107,
  /// <summary>
  /// Cloud callout.
  /// </summary>
  [InteropEnumValue("msoShapeCloudCallout")]
  CloudCallout = 108,
  /// <summary>
  /// Callout with border and horizontal callout line.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout1")]
  LineCallout1 = 109,
  /// <summary>
  /// Callout with diagonal straight line.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout2")]
  LineCallout2 = 110,
  /// <summary>
  /// Callout with angled line.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout3")]
  LineCallout3 = 111,
  /// <summary>
  /// Callout with callout line segments forming a U- shape.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout4")]
  LineCallout4 = 112,
  /// <summary>
  /// Callout with horizontal accent bar.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout1AccentBar")]
  LineCallout1AccentBar = 113,
  /// <summary>
  /// Callout with diagonal callout line and accent bar.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout2AccentBar")]
  LineCallout2AccentBar = 114,
  /// <summary>
  /// Callout with angled callout line and accent bar.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout3AccentBar")]
  LineCallout3AccentBar = 115,
  /// <summary>
  /// Callout with accent bar and callout line segments forming a U-shape.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout4AccentBar")]
  LineCallout4AccentBar = 116,
  /// <summary>
  /// Callout with horizontal line.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout1NoBorder")]
  LineCallout1NoBorder = 117,
  /// <summary>
  /// Callout with no border and diagonal callout line.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout2NoBorder")]
  LineCallout2NoBorder = 118,
  /// <summary>
  /// Callout with no border and angled callout line.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout3NoBorder")]
  LineCallout3NoBorder = 119,
  /// <summary>
  /// Callout with no border and callout line segments forming a U-shape.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout4NoBorder")]
  LineCallout4NoBorder = 120,
  /// <summary>
  /// Callout with border and horizontal accent bar.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout1BorderandAccentBar")]
  LineCallout1BorderandAccentBar = 121,
  /// <summary>
  /// Callout with border, diagonal straight line, and accent bar.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout2BorderandAccentBar")]
  LineCallout2BorderandAccentBar = 122,
  /// <summary>
  /// Callout with border, angled callout line, and accent bar.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout3BorderandAccentBar")]
  LineCallout3BorderandAccentBar = 123,
  /// <summary>
  /// Callout with border, accent bar, and callout line segments forming a U-shape.
  /// </summary>
  [InteropEnumValue("msoShapeLineCallout4BorderandAccentBar")]
  LineCallout4BorderandAccentBar = 124,
  /// <summary>
  /// Button with no default picture or text. Supports mouse-click and mouse-over actions.
  /// </summary>
  [InteropEnumValue("msoShapeActionButtonCustom")]
  ActionButtonCustom = 125,
  /// <summary>
  /// Home button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [InteropEnumValue("msoShapeActionButtonHome")]
  ActionButtonHome = 126,
  /// <summary>
  /// Help button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [InteropEnumValue("msoShapeActionButtonHelp")]
  ActionButtonHelp = 127,
  /// <summary>
  /// Information button. Supports mouse-click and mouse-over actions.
  /// </summary>
  [InteropEnumValue("msoShapeActionButtonInformation")]
  ActionButtonInformation = 128,
  /// <summary>
  /// Back or Previous button. Supports mouse-click and mouse-over actions.
  /// </summary>
  [InteropEnumValue("msoShapeActionButtonBackorPrevious")]
  ActionButtonBackorPrevious = 129,
  /// <summary>
  /// Forward or Next button. Supports mouse-click and mouse-over actions.
  /// </summary>
  [InteropEnumValue("msoShapeActionButtonForwardorNext")]
  ActionButtonForwardorNext = 130,
  /// <summary>
  /// Beginning button. Supports mouse-click and mouse-over actions.
  /// </summary>
  [InteropEnumValue("msoShapeActionButtonBeginning")]
  ActionButtonBeginning = 131,
  /// <summary>
  /// End button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [InteropEnumValue("msoShapeActionButtonEnd")]
  ActionButtonEnd = 132,
  /// <summary>
  /// Return button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [InteropEnumValue("msoShapeActionButtonReturn")]
  ActionButtonReturn = 133,
  /// <summary>
  /// Document button. Supports mouse-click and mouse-over actions.
  /// </summary>
  [InteropEnumValue("msoShapeActionButtonDocument")]
  ActionButtonDocument = 134,
  /// <summary>
  /// Sound button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [InteropEnumValue("msoShapeActionButtonSound")]
  ActionButtonSound = 135,
  /// <summary>
  /// Movie button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [InteropEnumValue("msoShapeActionButtonMovie")]
  ActionButtonMovie = 136,
  /// <summary>
  /// Balloon.
  /// </summary>
  [InteropEnumValue("msoShapeBalloon")]
  Balloon = 137,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("msoShapeNotPrimitive")]
  NotPrimitive = 138,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeFlowchartOfflineStorage")]
  FlowchartOfflineStorage = 139,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeLeftRightRibbon")]
  LeftRightRibbon = 140,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeDiagonalStripe")]
  DiagonalStripe = 141,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapePie")]
  Pie = 142,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeNonIsoscelesTrapezoid")]
  NonIsoscelesTrapezoid = 143,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeDecagon")]
  Decagon = 144,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeHeptagon")]
  Heptagon = 145,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeDodecagon")]
  Dodecagon = 146,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShape6pointStar")]
  SixPointStar = 147,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShape7pointStar")]
  SevenPointStar = 148,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShape10pointStar")]
  TenPointStar = 149,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShape12pointStar")]
  TwelvePointStar = 150,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeRound1Rectangle")]
  Round1Rectangle = 151,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeRound2SameRectangle")]
  Round2SameRectangle = 152,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeRound2DiagRectangle")]
  Round2DiagRectangle = 153,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeSnipRoundRectangle")]
  SnipRoundRectangle = 154,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeSnip1Rectangle")]
  Snip1Rectangle = 155,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeSnip2SameRectangle")]
  Snip2SameRectangle = 156,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeSnip2DiagRectangle")]
  Snip2DiagRectangle = 157,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeFrame")]
  Frame = 158,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeHalfFrame")]
  HalfFrame = 159,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeTear")]
  Tear = 160,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeChord")]
  Chord = 161,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeCorner")]
  Corner = 162,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeMathPlus")]
  MathPlus = 163,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeMathMinus")]
  MathMinus = 164,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeMathMultiply")]
  MathMultiply = 165,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeMathDivide")]
  MathDivide = 166,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeMathEqual")]
  MathEqual = 167,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeMathNotEqual")]
  MathNotEqual = 168,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeCornerTabs")]
  CornerTabs = 169,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeSquareTabs")]
  SquareTabs = 170,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapePlaqueTabs")]
  PlaqueTabs = 171,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeGear6")]
  Gear6 = 172,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeGear9")]
  Gear9 = 173,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeFunnel")]
  Funnel = 174,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapePieWedge")]
  PieWedge = 175,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeLeftCircularArrow")]
  LeftCircularArrow = 176,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeLeftRightCircularArrow")]
  LeftRightCircularArrow = 177,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeSwooshArrow")]
  SwooshArrow = 178,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeCloud")]
  Cloud = 179,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeChartX")]
  ChartX = 180,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeChartStar")]
  ChartStar = 181,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeChartPlus")]
  ChartPlus = 182,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoShapeLineInverse")]
  LineInverse = 183
}
