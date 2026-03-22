namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the shape type for an AutoShape object.
/// </summary>
public enum MsoAutoShapeType
{
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeMixed = -2,
  /// <summary>
  /// Rectangle.
  /// </summary>
  msoShapeRectangle = 1,
  /// <summary>
  /// Parallelogram.
  /// </summary>
  msoShapeParallelogram = 2,
  /// <summary>
  /// Trapezoid.
  /// </summary>
  msoShapeTrapezoid = 3,
  /// <summary>
  /// Diamond.
  /// </summary>
  msoShapeDiamond = 4,
  /// <summary>
  /// Rounded rectangle.
  /// </summary>
  msoShapeRoundedRectangle = 5,
  /// <summary>
  /// Octagon.
  /// </summary>
  msoShapeOctagon = 6,
  /// <summary>
  /// Isosceles triangle.
  /// </summary>
  msoShapeIsoscelesTriangle = 7,
  /// <summary>
  /// Right triangle.
  /// </summary>
  msoShapeRightTriangle = 8,
  /// <summary>
  /// Oval.
  /// </summary>
  msoShapeOval = 9,
  /// <summary>
  /// Hexagon.
  /// </summary>
  msoShapeHexagon = 10,
  /// <summary>
  /// Cross. public enum class MsoAutoShapeType ﾉ Expand table
  /// </summary>
  msoShapeCross = 11,
  /// <summary>
  /// Pentagon.
  /// </summary>
  msoShapeRegularPentagon = 12,
  /// <summary>
  /// Can.
  /// </summary>
  msoShapeCan = 13,
  /// <summary>
  /// Cube.
  /// </summary>
  msoShapeCube = 14,
  /// <summary>
  /// Bevel.
  /// </summary>
  msoShapeBevel = 15,
  /// <summary>
  /// Folded corner.
  /// </summary>
  msoShapeFoldedCorner = 16,
  /// <summary>
  /// Smiley face.
  /// </summary>
  msoShapeSmileyFace = 17,
  /// <summary>
  /// Donut.
  /// </summary>
  msoShapeDonut = 18,
  /// <summary>
  /// "No" symbol.
  /// </summary>
  msoShapeNoSymbol = 19,
  /// <summary>
  /// Block arc.
  /// </summary>
  msoShapeBlockArc = 20,
  /// <summary>
  /// Heart.
  /// </summary>
  msoShapeHeart = 21,
  /// <summary>
  /// Lightning bolt.
  /// </summary>
  msoShapeLightningBolt = 22,
  /// <summary>
  /// Sun.
  /// </summary>
  msoShapeSun = 23,
  /// <summary>
  /// Moon.
  /// </summary>
  msoShapeMoon = 24,
  /// <summary>
  /// Arc.
  /// </summary>
  msoShapeArc = 25,
  /// <summary>
  /// Double bracket.
  /// </summary>
  msoShapeDoubleBracket = 26,
  /// <summary>
  /// Double brace.
  /// </summary>
  msoShapeDoubleBrace = 27,
  /// <summary>
  /// Plaque.
  /// </summary>
  msoShapePlaque = 28,
  /// <summary>
  /// Left bracket.
  /// </summary>
  msoShapeLeftBracket = 29,
  /// <summary>
  /// Right bracket.
  /// </summary>
  msoShapeRightBracket = 30,
  /// <summary>
  /// Left brace.
  /// </summary>
  msoShapeLeftBrace = 31,
  /// <summary>
  /// Right brace.
  /// </summary>
  msoShapeRightBrace = 32,
  /// <summary>
  /// Block arrow that points right.
  /// </summary>
  msoShapeRightArrow = 33,
  /// <summary>
  /// Block arrow that points left.
  /// </summary>
  msoShapeLeftArrow = 34,
  /// <summary>
  /// Block arrow that points up.
  /// </summary>
  msoShapeUpArrow = 35,
  /// <summary>
  /// Block arrow that points down.
  /// </summary>
  msoShapeDownArrow = 36,
  /// <summary>
  /// Block arrow with arrowheads that point both left and right.
  /// </summary>
  msoShapeLeftRightArrow = 37,
  /// <summary>
  /// Block arrow that points up and down.
  /// </summary>
  msoShapeUpDownArrow = 38,
  /// <summary>
  /// Block arrows that point up, down, left, and right.
  /// </summary>
  msoShapeQuadArrow = 39,
  /// <summary>
  /// Block arrow with arrowheads that point left, right, and up.
  /// </summary>
  msoShapeLeftRightUpArrow = 40,
  /// <summary>
  /// Block arrow that follows a curved 90-degree angle.
  /// </summary>
  msoShapeBentArrow = 41,
  /// <summary>
  /// Block arrow forming a U shape.
  /// </summary>
  msoShapeUTurnArrow = 42,
  /// <summary>
  /// Block arrow with arrowheads that point left and up.
  /// </summary>
  msoShapeLeftUpArrow = 43,
  /// <summary>
  /// Block arrow that follows a sharp 90-degree angle. Points up by default.
  /// </summary>
  msoShapeBentUpArrow = 44,
  /// <summary>
  /// Block arrow that curves right.
  /// </summary>
  msoShapeCurvedRightArrow = 45,
  /// <summary>
  /// Block arrow that curves left.
  /// </summary>
  msoShapeCurvedLeftArrow = 46,
  /// <summary>
  /// Block arrow that curves up.
  /// </summary>
  msoShapeCurvedUpArrow = 47,
  /// <summary>
  /// Block arrow that curves down.
  /// </summary>
  msoShapeCurvedDownArrow = 48,
  /// <summary>
  /// Block arrow that points right with stripes at the tail.
  /// </summary>
  msoShapeStripedRightArrow = 49,
  /// <summary>
  /// Notched block arrow that points right.
  /// </summary>
  msoShapeNotchedRightArrow = 50,
  /// <summary>
  /// Pentagon.
  /// </summary>
  msoShapePentagon = 51,
  /// <summary>
  /// Chevron.
  /// </summary>
  msoShapeChevron = 52,
  /// <summary>
  /// Callout with arrow that points right.
  /// </summary>
  msoShapeRightArrowCallout = 53,
  /// <summary>
  /// Callout with arrow that points left.
  /// </summary>
  msoShapeLeftArrowCallout = 54,
  /// <summary>
  /// Callout with arrow that points up.
  /// </summary>
  msoShapeUpArrowCallout = 55,
  /// <summary>
  /// Callout with arrow that points down.
  /// </summary>
  msoShapeDownArrowCallout = 56,
  /// <summary>
  /// Callout with arrowheads that point both left and right.
  /// </summary>
  msoShapeLeftRightArrowCallout = 57,
  /// <summary>
  /// Callout with arrows that point up and down.
  /// </summary>
  msoShapeUpDownArrowCallout = 58,
  /// <summary>
  /// Callout with arrows that point up, down, left, and right.
  /// </summary>
  msoShapeQuadArrowCallout = 59,
  /// <summary>
  /// Block arrow that follows a curved 180-degree angle.
  /// </summary>
  msoShapeCircularArrow = 60,
  /// <summary>
  /// Process flowchart symbol. msoShapeFlowchartAlternateProcess62 Alternate process flowchart symbol.
  /// </summary>
  msoShapeFlowchartProcess = 61,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeFlowchartAlternateProcess = 62,
  /// <summary>
  /// Decision flowchart symbol.
  /// </summary>
  msoShapeFlowchartDecision = 63,
  /// <summary>
  /// Data flowchart symbol. msoShapeFlowchartPredefinedProcess65 Predefined process flowchart symbol.
  /// </summary>
  msoShapeFlowchartData = 64,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeFlowchartPredefinedProcess = 65,
  /// <summary>
  /// Internal storage flowchart symbol.
  /// </summary>
  msoShapeFlowchartInternalStorage = 66,
  /// <summary>
  /// Document flowchart symbol. msoShapeFlowchartMultidocument68 Multi-document flowchart symbol.
  /// </summary>
  msoShapeFlowchartDocument = 67,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeFlowchartMultidocument = 68,
  /// <summary>
  /// Terminator flowchart symbol.
  /// </summary>
  msoShapeFlowchartTerminator = 69,
  /// <summary>
  /// Preparation flowchart symbol.
  /// </summary>
  msoShapeFlowchartPreparation = 70,
  /// <summary>
  /// Manual input flowchart symbol. msoShapeFlowchartManualOperation72 Manual operation flowchart symbol.
  /// </summary>
  msoShapeFlowchartManualInput = 71,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeFlowchartManualOperation = 72,
  /// <summary>
  /// Connector flowchart symbol. msoShapeFlowchartOffpageConnector74 Off-page connector flowchart symbol.
  /// </summary>
  msoShapeFlowchartConnector = 73,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeFlowchartOffpageConnector = 74,
  /// <summary>
  /// Card flowchart symbol.
  /// </summary>
  msoShapeFlowchartCard = 75,
  /// <summary>
  /// Punched tape flowchart symbol. msoShapeFlowchartSummingJunction77 Summing junction flowchart symbol.
  /// </summary>
  msoShapeFlowchartPunchedTape = 76,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeFlowchartSummingJunction = 77,
  /// <summary>
  /// "Or" flowchart symbol.
  /// </summary>
  msoShapeFlowchartOr = 78,
  /// <summary>
  /// Collate flowchart symbol.
  /// </summary>
  msoShapeFlowchartCollate = 79,
  /// <summary>
  /// Sort flowchart symbol.
  /// </summary>
  msoShapeFlowchartSort = 80,
  /// <summary>
  /// Extract flowchart symbol.
  /// </summary>
  msoShapeFlowchartExtract = 81,
  /// <summary>
  /// Merge flowchart symbol.
  /// </summary>
  msoShapeFlowchartMerge = 82,
  /// <summary>
  /// Stored data flowchart symbol.
  /// </summary>
  msoShapeFlowchartStoredData = 83,
  /// <summary>
  /// Delay flowchart symbol. msoShapeFlowchartSequentialAccessStorage85 Sequential access storage flowchart symbol.
  /// </summary>
  msoShapeFlowchartDelay = 84,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeFlowchartSequentialAccessStorage = 85,
  /// <summary>
  /// Magnetic disk flowchart symbol.
  /// </summary>
  msoShapeFlowchartMagneticDisk = 86,
  /// <summary>
  /// Direct access storage flowchart symbol.
  /// </summary>
  msoShapeFlowchartDirectAccessStorage = 87,
  /// <summary>
  /// Display flowchart symbol.
  /// </summary>
  msoShapeFlowchartDisplay = 88,
  /// <summary>
  /// Explosion.
  /// </summary>
  msoShapeExplosion1 = 89,
  /// <summary>
  /// Explosion.
  /// </summary>
  msoShapeExplosion2 = 90,
  /// <summary>
  /// 4-point star.
  /// </summary>
  msoShape4pointStar = 91,
  /// <summary>
  /// 5-point star.
  /// </summary>
  msoShape5pointStar = 92,
  /// <summary>
  /// 8-point star.
  /// </summary>
  msoShape8pointStar = 93,
  /// <summary>
  /// 16-point star.
  /// </summary>
  msoShape16pointStar = 94,
  /// <summary>
  /// 24-point star.
  /// </summary>
  msoShape24pointStar = 95,
  /// <summary>
  /// 32-point star.
  /// </summary>
  msoShape32pointStar = 96,
  /// <summary>
  /// Ribbon banner with center area above ribbon ends.
  /// </summary>
  msoShapeUpRibbon = 97,
  /// <summary>
  /// Ribbon banner with center area below ribbon ends.
  /// </summary>
  msoShapeDownRibbon = 98,
  /// <summary>
  /// Ribbon banner that curves up.
  /// </summary>
  msoShapeCurvedUpRibbon = 99,
  /// <summary>
  /// Ribbon banner that curves down.
  /// </summary>
  msoShapeCurvedDownRibbon = 100,
  /// <summary>
  /// Vertical scroll.
  /// </summary>
  msoShapeVerticalScroll = 101,
  /// <summary>
  /// Horizontal scroll.
  /// </summary>
  msoShapeHorizontalScroll = 102,
  /// <summary>
  /// Wave.
  /// </summary>
  msoShapeWave = 103,
  /// <summary>
  /// Double wave.
  /// </summary>
  msoShapeDoubleWave = 104,
  /// <summary>
  /// Rectangular callout.
  /// </summary>
  msoShapeRectangularCallout = 105,
  /// <summary>
  /// Rounded rectangle-shaped callout.
  /// </summary>
  msoShapeRoundedRectangularCallout = 106,
  /// <summary>
  /// Oval-shaped callout.
  /// </summary>
  msoShapeOvalCallout = 107,
  /// <summary>
  /// Cloud callout.
  /// </summary>
  msoShapeCloudCallout = 108,
  /// <summary>
  /// Callout with border and horizontal callout line.
  /// </summary>
  msoShapeLineCallout1 = 109,
  /// <summary>
  /// Callout with diagonal straight line.
  /// </summary>
  msoShapeLineCallout2 = 110,
  /// <summary>
  /// Callout with angled line.
  /// </summary>
  msoShapeLineCallout3 = 111,
  /// <summary>
  /// Callout with callout line segments forming a U- shape.
  /// </summary>
  msoShapeLineCallout4 = 112,
  /// <summary>
  /// Callout with horizontal accent bar.
  /// </summary>
  msoShapeLineCallout1AccentBar = 113,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeLineCallout2AccentBar = 114,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeLineCallout3AccentBar = 115,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeLineCallout4AccentBar = 116,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeLineCallout1NoBorder = 117,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeLineCallout2NoBorder = 118,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeLineCallout3NoBorder = 119,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeLineCallout4NoBorder = 120,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeLineCallout1BorderandAccentBar = 121,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeLineCallout2BorderandAccentBar = 122,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeLineCallout3BorderandAccentBar = 123,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeLineCallout4BorderandAccentBar = 124,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeActionButtonCustom = 125,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeActionButtonHome = 126,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeActionButtonHelp = 127,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeActionButtonInformation = 128,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeActionButtonBackorPrevious = 129,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeActionButtonForwardorNext = 130,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeActionButtonBeginning = 131,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeActionButtonEnd = 132,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeActionButtonReturn = 133,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeActionButtonDocument = 134,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeActionButtonSound = 135,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeActionButtonMovie = 136,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeBalloon = 137,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeNotPrimitive = 138,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeFlowchartOfflineStorage = 139,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeLeftRightRibbon = 140,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeDiagonalStripe = 141,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapePie = 142,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeNonIsoscelesTrapezoid = 143,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeDecagon = 144,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeHeptagon = 145,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeDodecagon = 146,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShape6pointStar = 147,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShape7pointStar = 148,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShape10pointStar = 149,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShape12pointStar = 150,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeRound1Rectangle = 151,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeRound2SameRectangle = 152,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeRound2DiagRectangle = 153,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeSnipRoundRectangle = 154,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeSnip1Rectangle = 155,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeSnip2SameRectangle = 156,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeSnip2DiagRectangle = 157,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeFrame = 158,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeHalfFrame = 159,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeTear = 160,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeChord = 161,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeCorner = 162,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeMathPlus = 163,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeMathMinus = 164,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeMathMultiply = 165,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeMathDivide = 166,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeMathEqual = 167,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeMathNotEqual = 168,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeCornerTabs = 169,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeSquareTabs = 170,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapePlaqueTabs = 171,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeGear6 = 172,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeGear9 = 173,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeFunnel = 174,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapePieWedge = 175,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeLeftCircularArrow = 176,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeLeftRightCircularArrow = 177,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeSwooshArrow = 178,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeCloud = 179,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeChartX = 180,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeChartStar = 181,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeChartPlus = 182,
  /// <summary>
  /// Specifies the shape type for an AutoShape object.
  /// </summary>
  msoShapeLineInverse = 183
}
