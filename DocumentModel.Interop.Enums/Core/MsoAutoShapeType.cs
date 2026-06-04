namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the shape type for an AutoShape object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoautoshapetype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoAutoShapeType")]
public enum AutoShapeType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeMixed")]
  Mixed = -2,
  /// <summary>
  /// Rectangle.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeRectangle")]
  Rectangle = 1,
  /// <summary>
  /// Parallelogram.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeParallelogram")]
  Parallelogram = 2,
  /// <summary>
  /// Trapezoid.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeTrapezoid")]
  Trapezoid = 3,
  /// <summary>
  /// Diamond.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeDiamond")]
  Diamond = 4,
  /// <summary>
  /// Rounded rectangle.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeRoundedRectangle")]
  RoundedRectangle = 5,
  /// <summary>
  /// Octagon.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeOctagon")]
  Octagon = 6,
  /// <summary>
  /// Isosceles triangle.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeIsoscelesTriangle")]
  IsoscelesTriangle = 7,
  /// <summary>
  /// Right triangle.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeRightTriangle")]
  RightTriangle = 8,
  /// <summary>
  /// Oval.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeOval")]
  Oval = 9,
  /// <summary>
  /// Hexagon.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeHexagon")]
  Hexagon = 10,
  /// <summary>
  /// Cross.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeCross")]
  Cross = 11,
  /// <summary>
  /// Pentagon.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeRegularPentagon")]
  RegularPentagon = 12,
  /// <summary>
  /// Can.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeCan")]
  Can = 13,
  /// <summary>
  /// Cube.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeCube")]
  Cube = 14,
  /// <summary>
  /// Bevel.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeBevel")]
  Bevel = 15,
  /// <summary>
  /// Folded corner.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFoldedCorner")]
  FoldedCorner = 16,
  /// <summary>
  /// Smiley face.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeSmileyFace")]
  SmileyFace = 17,
  /// <summary>
  /// Donut.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeDonut")]
  Donut = 18,
  /// <summary>
  /// "No" symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeNoSymbol")]
  NoSymbol = 19,
  /// <summary>
  /// Block arc.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeBlockArc")]
  BlockArc = 20,
  /// <summary>
  /// Heart.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeHeart")]
  Heart = 21,
  /// <summary>
  /// Lightning bolt.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLightningBolt")]
  LightningBolt = 22,
  /// <summary>
  /// Sun.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeSun")]
  Sun = 23,
  /// <summary>
  /// Moon.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeMoon")]
  Moon = 24,
  /// <summary>
  /// Arc.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeArc")]
  Arc = 25,
  /// <summary>
  /// Double bracket.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeDoubleBracket")]
  DoubleBracket = 26,
  /// <summary>
  /// Double brace.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeDoubleBrace")]
  DoubleBrace = 27,
  /// <summary>
  /// Plaque.
  /// </summary>
  [OfficeInteropEnumValue("msoShapePlaque")]
  Plaque = 28,
  /// <summary>
  /// Left bracket.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLeftBracket")]
  LeftBracket = 29,
  /// <summary>
  /// Right bracket.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeRightBracket")]
  RightBracket = 30,
  /// <summary>
  /// Left brace.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLeftBrace")]
  LeftBrace = 31,
  /// <summary>
  /// Right brace.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeRightBrace")]
  RightBrace = 32,
  /// <summary>
  /// Block arrow that points right.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeRightArrow")]
  RightArrow = 33,
  /// <summary>
  /// Block arrow that points left.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLeftArrow")]
  LeftArrow = 34,
  /// <summary>
  /// Block arrow that points up.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeUpArrow")]
  UpArrow = 35,
  /// <summary>
  /// Block arrow that points down.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeDownArrow")]
  DownArrow = 36,
  /// <summary>
  /// Block arrow with arrowheads that point both left and right.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLeftRightArrow")]
  LeftRightArrow = 37,
  /// <summary>
  /// Block arrow that points up and down.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeUpDownArrow")]
  UpDownArrow = 38,
  /// <summary>
  /// Block arrows that point up, down, left, and right.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeQuadArrow")]
  QuadArrow = 39,
  /// <summary>
  /// Block arrow with arrowheads that point left, right, and up.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLeftRightUpArrow")]
  LeftRightUpArrow = 40,
  /// <summary>
  /// Block arrow that follows a curved 90-degree angle.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeBentArrow")]
  BentArrow = 41,
  /// <summary>
  /// Block arrow forming a U shape.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeUTurnArrow")]
  UTurnArrow = 42,
  /// <summary>
  /// Block arrow with arrowheads that point left and up.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLeftUpArrow")]
  LeftUpArrow = 43,
  /// <summary>
  /// Block arrow that follows a sharp 90-degree angle. Points up by default.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeBentUpArrow")]
  BentUpArrow = 44,
  /// <summary>
  /// Block arrow that curves right.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeCurvedRightArrow")]
  CurvedRightArrow = 45,
  /// <summary>
  /// Block arrow that curves left.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeCurvedLeftArrow")]
  CurvedLeftArrow = 46,
  /// <summary>
  /// Block arrow that curves up.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeCurvedUpArrow")]
  CurvedUpArrow = 47,
  /// <summary>
  /// Block arrow that curves down.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeCurvedDownArrow")]
  CurvedDownArrow = 48,
  /// <summary>
  /// Block arrow that points right with stripes at the tail.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeStripedRightArrow")]
  StripedRightArrow = 49,
  /// <summary>
  /// Notched block arrow that points right.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeNotchedRightArrow")]
  NotchedRightArrow = 50,
  /// <summary>
  /// Pentagon.
  /// </summary>
  [OfficeInteropEnumValue("msoShapePentagon")]
  Pentagon = 51,
  /// <summary>
  /// Chevron.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeChevron")]
  Chevron = 52,
  /// <summary>
  /// Callout with arrow that points right.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeRightArrowCallout")]
  RightArrowCallout = 53,
  /// <summary>
  /// Callout with arrow that points left.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLeftArrowCallout")]
  LeftArrowCallout = 54,
  /// <summary>
  /// Callout with arrow that points up.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeUpArrowCallout")]
  UpArrowCallout = 55,
  /// <summary>
  /// Callout with arrow that points down.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeDownArrowCallout")]
  DownArrowCallout = 56,
  /// <summary>
  /// Callout with arrowheads that point both left and right.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLeftRightArrowCallout")]
  LeftRightArrowCallout = 57,
  /// <summary>
  /// Callout with arrows that point up and down.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeUpDownArrowCallout")]
  UpDownArrowCallout = 58,
  /// <summary>
  /// Callout with arrows that point up, down, left, and right.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeQuadArrowCallout")]
  QuadArrowCallout = 59,
  /// <summary>
  /// Block arrow that follows a curved 180-degree angle.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeCircularArrow")]
  CircularArrow = 60,
  /// <summary>
  /// Process flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartProcess")]
  FlowchartProcess = 61,
  /// <summary>
  /// Alternate process flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartAlternateProcess")]
  FlowchartAlternateProcess = 62,
  /// <summary>
  /// Decision flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartDecision")]
  FlowchartDecision = 63,
  /// <summary>
  /// Data flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartData")]
  FlowchartData = 64,
  /// <summary>
  /// Predefined process flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartPredefinedProcess")]
  FlowchartPredefinedProcess = 65,
  /// <summary>
  /// Internal storage flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartInternalStorage")]
  FlowchartInternalStorage = 66,
  /// <summary>
  /// Document flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartDocument")]
  FlowchartDocument = 67,
  /// <summary>
  /// Multi-document flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartMultidocument")]
  FlowchartMultidocument = 68,
  /// <summary>
  /// Terminator flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartTerminator")]
  FlowchartTerminator = 69,
  /// <summary>
  /// Preparation flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartPreparation")]
  FlowchartPreparation = 70,
  /// <summary>
  /// Manual input flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartManualInput")]
  FlowchartManualInput = 71,
  /// <summary>
  /// Manual operation flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartManualOperation")]
  FlowchartManualOperation = 72,
  /// <summary>
  /// Connector flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartConnector")]
  FlowchartConnector = 73,
  /// <summary>
  /// Off-page connector flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartOffpageConnector")]
  FlowchartOffpageConnector = 74,
  /// <summary>
  /// Card flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartCard")]
  FlowchartCard = 75,
  /// <summary>
  /// Punched tape flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartPunchedTape")]
  FlowchartPunchedTape = 76,
  /// <summary>
  /// Summing junction flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartSummingJunction")]
  FlowchartSummingJunction = 77,
  /// <summary>
  /// "Or" flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartOr")]
  FlowchartOr = 78,
  /// <summary>
  /// Collate flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartCollate")]
  FlowchartCollate = 79,
  /// <summary>
  /// Sort flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartSort")]
  FlowchartSort = 80,
  /// <summary>
  /// Extract flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartExtract")]
  FlowchartExtract = 81,
  /// <summary>
  /// Merge flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartMerge")]
  FlowchartMerge = 82,
  /// <summary>
  /// Stored data flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartStoredData")]
  FlowchartStoredData = 83,
  /// <summary>
  /// Delay flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartDelay")]
  FlowchartDelay = 84,
  /// <summary>
  /// Sequential access storage flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartSequentialAccessStorage")]
  FlowchartSequentialAccessStorage = 85,
  /// <summary>
  /// Magnetic disk flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartMagneticDisk")]
  FlowchartMagneticDisk = 86,
  /// <summary>
  /// Direct access storage flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartDirectAccessStorage")]
  FlowchartDirectAccessStorage = 87,
  /// <summary>
  /// Display flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartDisplay")]
  FlowchartDisplay = 88,
  /// <summary>
  /// Explosion.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeExplosion1")]
  Explosion1 = 89,
  /// <summary>
  /// Explosion.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeExplosion2")]
  Explosion2 = 90,
  /// <summary>
  /// 4-point star.
  /// </summary>
  [OfficeInteropEnumValue("msoShape4pointStar")]
  FourPointStar = 91,
  /// <summary>
  /// 5-point star.
  /// </summary>
  [OfficeInteropEnumValue("msoShape5pointStar")]
  FivePointStar = 92,
  /// <summary>
  /// 8-point star.
  /// </summary>
  [OfficeInteropEnumValue("msoShape8pointStar")]
  EightPointStar = 93,
  /// <summary>
  /// 16-point star.
  /// </summary>
  [OfficeInteropEnumValue("msoShape16pointStar")]
  SixteenPointStar = 94,
  /// <summary>
  /// 24-point star.
  /// </summary>
  [OfficeInteropEnumValue("msoShape24pointStar")]
  TwentyFourPointStar = 95,
  /// <summary>
  /// 32-point star.
  /// </summary>
  [OfficeInteropEnumValue("msoShape32pointStar")]
  ThirtyTwoPointStar = 96,
  /// <summary>
  /// Ribbon banner with center area above ribbon ends.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeUpRibbon")]
  UpRibbon = 97,
  /// <summary>
  /// Ribbon banner with center area below ribbon ends.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeDownRibbon")]
  DownRibbon = 98,
  /// <summary>
  /// Ribbon banner that curves up.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeCurvedUpRibbon")]
  CurvedUpRibbon = 99,
  /// <summary>
  /// Ribbon banner that curves down.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeCurvedDownRibbon")]
  CurvedDownRibbon = 100,
  /// <summary>
  /// Vertical scroll.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeVerticalScroll")]
  VerticalScroll = 101,
  /// <summary>
  /// Horizontal scroll.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeHorizontalScroll")]
  HorizontalScroll = 102,
  /// <summary>
  /// Wave.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeWave")]
  Wave = 103,
  /// <summary>
  /// Double wave.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeDoubleWave")]
  DoubleWave = 104,
  /// <summary>
  /// Rectangular callout.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeRectangularCallout")]
  RectangularCallout = 105,
  /// <summary>
  /// Rounded rectangle-shaped callout.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeRoundedRectangularCallout")]
  RoundedRectangularCallout = 106,
  /// <summary>
  /// Oval-shaped callout.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeOvalCallout")]
  OvalCallout = 107,
  /// <summary>
  /// Cloud callout.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeCloudCallout")]
  CloudCallout = 108,
  /// <summary>
  /// Callout with border and horizontal callout line.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout1")]
  LineCallout1 = 109,
  /// <summary>
  /// Callout with diagonal straight line.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout2")]
  LineCallout2 = 110,
  /// <summary>
  /// Callout with angled line.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout3")]
  LineCallout3 = 111,
  /// <summary>
  /// Callout with callout line segments forming a U- shape.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout4")]
  LineCallout4 = 112,
  /// <summary>
  /// Callout with horizontal accent bar.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout1AccentBar")]
  LineCallout1AccentBar = 113,
  /// <summary>
  /// Callout with diagonal callout line and accent bar.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout2AccentBar")]
  LineCallout2AccentBar = 114,
  /// <summary>
  /// Callout with angled callout line and accent bar.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout3AccentBar")]
  LineCallout3AccentBar = 115,
  /// <summary>
  /// Callout with accent bar and callout line segments forming a U-shape.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout4AccentBar")]
  LineCallout4AccentBar = 116,
  /// <summary>
  /// Callout with horizontal line.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout1NoBorder")]
  LineCallout1NoBorder = 117,
  /// <summary>
  /// Callout with no border and diagonal callout line.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout2NoBorder")]
  LineCallout2NoBorder = 118,
  /// <summary>
  /// Callout with no border and angled callout line.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout3NoBorder")]
  LineCallout3NoBorder = 119,
  /// <summary>
  /// Callout with no border and callout line segments forming a U-shape.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout4NoBorder")]
  LineCallout4NoBorder = 120,
  /// <summary>
  /// Callout with border and horizontal accent bar.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout1BorderandAccentBar")]
  LineCallout1BorderandAccentBar = 121,
  /// <summary>
  /// Callout with border, diagonal straight line, and accent bar.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout2BorderandAccentBar")]
  LineCallout2BorderandAccentBar = 122,
  /// <summary>
  /// Callout with border, angled callout line, and accent bar.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout3BorderandAccentBar")]
  LineCallout3BorderandAccentBar = 123,
  /// <summary>
  /// Callout with border, accent bar, and callout line segments forming a U-shape.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineCallout4BorderandAccentBar")]
  LineCallout4BorderandAccentBar = 124,
  /// <summary>
  /// Button with no default picture or text. Supports mouse-click and mouse-over actions.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeActionButtonCustom")]
  ActionButtonCustom = 125,
  /// <summary>
  /// Home button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeActionButtonHome")]
  ActionButtonHome = 126,
  /// <summary>
  /// Help button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeActionButtonHelp")]
  ActionButtonHelp = 127,
  /// <summary>
  /// Information button. Supports mouse-click and mouse-over actions.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeActionButtonInformation")]
  ActionButtonInformation = 128,
  /// <summary>
  /// Back or Previous button. Supports mouse-click and mouse-over actions.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeActionButtonBackorPrevious")]
  ActionButtonBackorPrevious = 129,
  /// <summary>
  /// Forward or Next button. Supports mouse-click and mouse-over actions.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeActionButtonForwardorNext")]
  ActionButtonForwardorNext = 130,
  /// <summary>
  /// Beginning button. Supports mouse-click and mouse-over actions.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeActionButtonBeginning")]
  ActionButtonBeginning = 131,
  /// <summary>
  /// End button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeActionButtonEnd")]
  ActionButtonEnd = 132,
  /// <summary>
  /// Return button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeActionButtonReturn")]
  ActionButtonReturn = 133,
  /// <summary>
  /// Document button. Supports mouse-click and mouse-over actions.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeActionButtonDocument")]
  ActionButtonDocument = 134,
  /// <summary>
  /// Sound button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeActionButtonSound")]
  ActionButtonSound = 135,
  /// <summary>
  /// Movie button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeActionButtonMovie")]
  ActionButtonMovie = 136,
  /// <summary>
  /// Balloon.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeBalloon")]
  Balloon = 137,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeNotPrimitive")]
  NotPrimitive = 138,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFlowchartOfflineStorage")]
  FlowchartOfflineStorage = 139,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLeftRightRibbon")]
  LeftRightRibbon = 140,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeDiagonalStripe")]
  DiagonalStripe = 141,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapePie")]
  Pie = 142,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeNonIsoscelesTrapezoid")]
  NonIsoscelesTrapezoid = 143,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeDecagon")]
  Decagon = 144,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeHeptagon")]
  Heptagon = 145,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeDodecagon")]
  Dodecagon = 146,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShape6pointStar")]
  SixPointStar = 147,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShape7pointStar")]
  SevenPointStar = 148,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShape10pointStar")]
  TenPointStar = 149,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShape12pointStar")]
  TwelvePointStar = 150,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeRound1Rectangle")]
  Round1Rectangle = 151,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeRound2SameRectangle")]
  Round2SameRectangle = 152,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeRound2DiagRectangle")]
  Round2DiagRectangle = 153,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeSnipRoundRectangle")]
  SnipRoundRectangle = 154,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeSnip1Rectangle")]
  Snip1Rectangle = 155,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeSnip2SameRectangle")]
  Snip2SameRectangle = 156,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeSnip2DiagRectangle")]
  Snip2DiagRectangle = 157,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFrame")]
  Frame = 158,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeHalfFrame")]
  HalfFrame = 159,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeTear")]
  Tear = 160,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeChord")]
  Chord = 161,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeCorner")]
  Corner = 162,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeMathPlus")]
  MathPlus = 163,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeMathMinus")]
  MathMinus = 164,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeMathMultiply")]
  MathMultiply = 165,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeMathDivide")]
  MathDivide = 166,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeMathEqual")]
  MathEqual = 167,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeMathNotEqual")]
  MathNotEqual = 168,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeCornerTabs")]
  CornerTabs = 169,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeSquareTabs")]
  SquareTabs = 170,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapePlaqueTabs")]
  PlaqueTabs = 171,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeGear6")]
  Gear6 = 172,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeGear9")]
  Gear9 = 173,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeFunnel")]
  Funnel = 174,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapePieWedge")]
  PieWedge = 175,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLeftCircularArrow")]
  LeftCircularArrow = 176,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLeftRightCircularArrow")]
  LeftRightCircularArrow = 177,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeSwooshArrow")]
  SwooshArrow = 178,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeCloud")]
  Cloud = 179,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeChartX")]
  ChartX = 180,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeChartStar")]
  ChartStar = 181,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeChartPlus")]
  ChartPlus = 182,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoShapeLineInverse")]
  LineInverse = 183
}
