namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the shape type for an AutoShape object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoautoshapetype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoAutoShapeType))]
public enum AutoShapeType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeMixed))]
  Mixed = -2,
  /// <summary>
  /// Rectangle.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRectangle))]
  Rectangle = 1,
  /// <summary>
  /// Parallelogram.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeParallelogram))]
  Parallelogram = 2,
  /// <summary>
  /// Trapezoid.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeTrapezoid))]
  Trapezoid = 3,
  /// <summary>
  /// Diamond.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeDiamond))]
  Diamond = 4,
  /// <summary>
  /// Rounded rectangle.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRoundedRectangle))]
  RoundedRectangle = 5,
  /// <summary>
  /// Octagon.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeOctagon))]
  Octagon = 6,
  /// <summary>
  /// Isosceles triangle.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeIsoscelesTriangle))]
  IsoscelesTriangle = 7,
  /// <summary>
  /// Right triangle.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRightTriangle))]
  RightTriangle = 8,
  /// <summary>
  /// Oval.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeOval))]
  Oval = 9,
  /// <summary>
  /// Hexagon.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeHexagon))]
  Hexagon = 10,
  /// <summary>
  /// Cross.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeCross))]
  Cross = 11,
  /// <summary>
  /// Pentagon.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRegularPentagon))]
  RegularPentagon = 12,
  /// <summary>
  /// Can.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeCan))]
  Can = 13,
  /// <summary>
  /// Cube.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeCube))]
  Cube = 14,
  /// <summary>
  /// Bevel.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeBevel))]
  Bevel = 15,
  /// <summary>
  /// Folded corner.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFoldedCorner))]
  FoldedCorner = 16,
  /// <summary>
  /// Smiley face.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeSmileyFace))]
  SmileyFace = 17,
  /// <summary>
  /// Donut.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeDonut))]
  Donut = 18,
  /// <summary>
  /// "No" symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeNoSymbol))]
  NoSymbol = 19,
  /// <summary>
  /// Block arc.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeBlockArc))]
  BlockArc = 20,
  /// <summary>
  /// Heart.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeHeart))]
  Heart = 21,
  /// <summary>
  /// Lightning bolt.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLightningBolt))]
  LightningBolt = 22,
  /// <summary>
  /// Sun.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeSun))]
  Sun = 23,
  /// <summary>
  /// Moon.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeMoon))]
  Moon = 24,
  /// <summary>
  /// Arc.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeArc))]
  Arc = 25,
  /// <summary>
  /// Double bracket.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeDoubleBracket))]
  DoubleBracket = 26,
  /// <summary>
  /// Double brace.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeDoubleBrace))]
  DoubleBrace = 27,
  /// <summary>
  /// Plaque.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapePlaque))]
  Plaque = 28,
  /// <summary>
  /// Left bracket.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLeftBracket))]
  LeftBracket = 29,
  /// <summary>
  /// Right bracket.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRightBracket))]
  RightBracket = 30,
  /// <summary>
  /// Left brace.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLeftBrace))]
  LeftBrace = 31,
  /// <summary>
  /// Right brace.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRightBrace))]
  RightBrace = 32,
  /// <summary>
  /// Block arrow that points right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRightArrow))]
  RightArrow = 33,
  /// <summary>
  /// Block arrow that points left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLeftArrow))]
  LeftArrow = 34,
  /// <summary>
  /// Block arrow that points up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeUpArrow))]
  UpArrow = 35,
  /// <summary>
  /// Block arrow that points down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeDownArrow))]
  DownArrow = 36,
  /// <summary>
  /// Block arrow with arrowheads that point both left and right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLeftRightArrow))]
  LeftRightArrow = 37,
  /// <summary>
  /// Block arrow that points up and down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeUpDownArrow))]
  UpDownArrow = 38,
  /// <summary>
  /// Block arrows that point up, down, left, and right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeQuadArrow))]
  QuadArrow = 39,
  /// <summary>
  /// Block arrow with arrowheads that point left, right, and up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLeftRightUpArrow))]
  LeftRightUpArrow = 40,
  /// <summary>
  /// Block arrow that follows a curved 90-degree angle.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeBentArrow))]
  BentArrow = 41,
  /// <summary>
  /// Block arrow forming a U shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeUTurnArrow))]
  UTurnArrow = 42,
  /// <summary>
  /// Block arrow with arrowheads that point left and up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLeftUpArrow))]
  LeftUpArrow = 43,
  /// <summary>
  /// Block arrow that follows a sharp 90-degree angle. Points up by default.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeBentUpArrow))]
  BentUpArrow = 44,
  /// <summary>
  /// Block arrow that curves right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeCurvedRightArrow))]
  CurvedRightArrow = 45,
  /// <summary>
  /// Block arrow that curves left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeCurvedLeftArrow))]
  CurvedLeftArrow = 46,
  /// <summary>
  /// Block arrow that curves up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeCurvedUpArrow))]
  CurvedUpArrow = 47,
  /// <summary>
  /// Block arrow that curves down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeCurvedDownArrow))]
  CurvedDownArrow = 48,
  /// <summary>
  /// Block arrow that points right with stripes at the tail.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeStripedRightArrow))]
  StripedRightArrow = 49,
  /// <summary>
  /// Notched block arrow that points right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeNotchedRightArrow))]
  NotchedRightArrow = 50,
  /// <summary>
  /// Pentagon.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapePentagon))]
  Pentagon = 51,
  /// <summary>
  /// Chevron.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeChevron))]
  Chevron = 52,
  /// <summary>
  /// Callout with arrow that points right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRightArrowCallout))]
  RightArrowCallout = 53,
  /// <summary>
  /// Callout with arrow that points left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLeftArrowCallout))]
  LeftArrowCallout = 54,
  /// <summary>
  /// Callout with arrow that points up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeUpArrowCallout))]
  UpArrowCallout = 55,
  /// <summary>
  /// Callout with arrow that points down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeDownArrowCallout))]
  DownArrowCallout = 56,
  /// <summary>
  /// Callout with arrowheads that point both left and right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLeftRightArrowCallout))]
  LeftRightArrowCallout = 57,
  /// <summary>
  /// Callout with arrows that point up and down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeUpDownArrowCallout))]
  UpDownArrowCallout = 58,
  /// <summary>
  /// Callout with arrows that point up, down, left, and right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeQuadArrowCallout))]
  QuadArrowCallout = 59,
  /// <summary>
  /// Block arrow that follows a curved 180-degree angle.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeCircularArrow))]
  CircularArrow = 60,
  /// <summary>
  /// Process flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartProcess))]
  FlowchartProcess = 61,
  /// <summary>
  /// Alternate process flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartAlternateProcess))]
  FlowchartAlternateProcess = 62,
  /// <summary>
  /// Decision flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartDecision))]
  FlowchartDecision = 63,
  /// <summary>
  /// Data flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartData))]
  FlowchartData = 64,
  /// <summary>
  /// Predefined process flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartPredefinedProcess))]
  FlowchartPredefinedProcess = 65,
  /// <summary>
  /// Internal storage flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartInternalStorage))]
  FlowchartInternalStorage = 66,
  /// <summary>
  /// Document flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartDocument))]
  FlowchartDocument = 67,
  /// <summary>
  /// Multi-document flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartMultidocument))]
  FlowchartMultidocument = 68,
  /// <summary>
  /// Terminator flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartTerminator))]
  FlowchartTerminator = 69,
  /// <summary>
  /// Preparation flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartPreparation))]
  FlowchartPreparation = 70,
  /// <summary>
  /// Manual input flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartManualInput))]
  FlowchartManualInput = 71,
  /// <summary>
  /// Manual operation flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartManualOperation))]
  FlowchartManualOperation = 72,
  /// <summary>
  /// Connector flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartConnector))]
  FlowchartConnector = 73,
  /// <summary>
  /// Off-page connector flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartOffpageConnector))]
  FlowchartOffpageConnector = 74,
  /// <summary>
  /// Card flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartCard))]
  FlowchartCard = 75,
  /// <summary>
  /// Punched tape flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartPunchedTape))]
  FlowchartPunchedTape = 76,
  /// <summary>
  /// Summing junction flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartSummingJunction))]
  FlowchartSummingJunction = 77,
  /// <summary>
  /// "Or" flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartOr))]
  FlowchartOr = 78,
  /// <summary>
  /// Collate flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartCollate))]
  FlowchartCollate = 79,
  /// <summary>
  /// Sort flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartSort))]
  FlowchartSort = 80,
  /// <summary>
  /// Extract flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartExtract))]
  FlowchartExtract = 81,
  /// <summary>
  /// Merge flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartMerge))]
  FlowchartMerge = 82,
  /// <summary>
  /// Stored data flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartStoredData))]
  FlowchartStoredData = 83,
  /// <summary>
  /// Delay flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartDelay))]
  FlowchartDelay = 84,
  /// <summary>
  /// Sequential access storage flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartSequentialAccessStorage))]
  FlowchartSequentialAccessStorage = 85,
  /// <summary>
  /// Magnetic disk flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartMagneticDisk))]
  FlowchartMagneticDisk = 86,
  /// <summary>
  /// Direct access storage flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartDirectAccessStorage))]
  FlowchartDirectAccessStorage = 87,
  /// <summary>
  /// Display flowchart symbol.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartDisplay))]
  FlowchartDisplay = 88,
  /// <summary>
  /// Explosion.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeExplosion1))]
  Explosion1 = 89,
  /// <summary>
  /// Explosion.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeExplosion2))]
  Explosion2 = 90,
  /// <summary>
  /// 4-point star.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShape4pointStar))]
  FourPointStar = 91,
  /// <summary>
  /// 5-point star.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShape5pointStar))]
  FivePointStar = 92,
  /// <summary>
  /// 8-point star.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShape8pointStar))]
  EightPointStar = 93,
  /// <summary>
  /// 16-point star.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShape16pointStar))]
  SixteenPointStar = 94,
  /// <summary>
  /// 24-point star.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShape24pointStar))]
  TwentyFourPointStar = 95,
  /// <summary>
  /// 32-point star.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShape32pointStar))]
  ThirtyTwoPointStar = 96,
  /// <summary>
  /// Ribbon banner with center area above ribbon ends.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeUpRibbon))]
  UpRibbon = 97,
  /// <summary>
  /// Ribbon banner with center area below ribbon ends.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeDownRibbon))]
  DownRibbon = 98,
  /// <summary>
  /// Ribbon banner that curves up.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeCurvedUpRibbon))]
  CurvedUpRibbon = 99,
  /// <summary>
  /// Ribbon banner that curves down.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeCurvedDownRibbon))]
  CurvedDownRibbon = 100,
  /// <summary>
  /// Vertical scroll.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeVerticalScroll))]
  VerticalScroll = 101,
  /// <summary>
  /// Horizontal scroll.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeHorizontalScroll))]
  HorizontalScroll = 102,
  /// <summary>
  /// Wave.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeWave))]
  Wave = 103,
  /// <summary>
  /// Double wave.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeDoubleWave))]
  DoubleWave = 104,
  /// <summary>
  /// Rectangular callout.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRectangularCallout))]
  RectangularCallout = 105,
  /// <summary>
  /// Rounded rectangle-shaped callout.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRoundedRectangularCallout))]
  RoundedRectangularCallout = 106,
  /// <summary>
  /// Oval-shaped callout.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeOvalCallout))]
  OvalCallout = 107,
  /// <summary>
  /// Cloud callout.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeCloudCallout))]
  CloudCallout = 108,
  /// <summary>
  /// Callout with border and horizontal callout line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout1))]
  LineCallout1 = 109,
  /// <summary>
  /// Callout with diagonal straight line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout2))]
  LineCallout2 = 110,
  /// <summary>
  /// Callout with angled line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout3))]
  LineCallout3 = 111,
  /// <summary>
  /// Callout with callout line segments forming a U- shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout4))]
  LineCallout4 = 112,
  /// <summary>
  /// Callout with horizontal accent bar.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout1AccentBar))]
  LineCallout1AccentBar = 113,
  /// <summary>
  /// Callout with diagonal callout line and accent bar.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout2AccentBar))]
  LineCallout2AccentBar = 114,
  /// <summary>
  /// Callout with angled callout line and accent bar.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout3AccentBar))]
  LineCallout3AccentBar = 115,
  /// <summary>
  /// Callout with accent bar and callout line segments forming a U-shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout4AccentBar))]
  LineCallout4AccentBar = 116,
  /// <summary>
  /// Callout with horizontal line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout1NoBorder))]
  LineCallout1NoBorder = 117,
  /// <summary>
  /// Callout with no border and diagonal callout line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout2NoBorder))]
  LineCallout2NoBorder = 118,
  /// <summary>
  /// Callout with no border and angled callout line.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout3NoBorder))]
  LineCallout3NoBorder = 119,
  /// <summary>
  /// Callout with no border and callout line segments forming a U-shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout4NoBorder))]
  LineCallout4NoBorder = 120,
  /// <summary>
  /// Callout with border and horizontal accent bar.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout1BorderandAccentBar))]
  LineCallout1BorderandAccentBar = 121,
  /// <summary>
  /// Callout with border, diagonal straight line, and accent bar.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout2BorderandAccentBar))]
  LineCallout2BorderandAccentBar = 122,
  /// <summary>
  /// Callout with border, angled callout line, and accent bar.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout3BorderandAccentBar))]
  LineCallout3BorderandAccentBar = 123,
  /// <summary>
  /// Callout with border, accent bar, and callout line segments forming a U-shape.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineCallout4BorderandAccentBar))]
  LineCallout4BorderandAccentBar = 124,
  /// <summary>
  /// Button with no default picture or text. Supports mouse-click and mouse-over actions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeActionButtonCustom))]
  ActionButtonCustom = 125,
  /// <summary>
  /// Home button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeActionButtonHome))]
  ActionButtonHome = 126,
  /// <summary>
  /// Help button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeActionButtonHelp))]
  ActionButtonHelp = 127,
  /// <summary>
  /// Information button. Supports mouse-click and mouse-over actions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeActionButtonInformation))]
  ActionButtonInformation = 128,
  /// <summary>
  /// Back or Previous button. Supports mouse-click and mouse-over actions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeActionButtonBackorPrevious))]
  ActionButtonBackorPrevious = 129,
  /// <summary>
  /// Forward or Next button. Supports mouse-click and mouse-over actions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeActionButtonForwardorNext))]
  ActionButtonForwardorNext = 130,
  /// <summary>
  /// Beginning button. Supports mouse-click and mouse-over actions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeActionButtonBeginning))]
  ActionButtonBeginning = 131,
  /// <summary>
  /// End button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeActionButtonEnd))]
  ActionButtonEnd = 132,
  /// <summary>
  /// Return button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeActionButtonReturn))]
  ActionButtonReturn = 133,
  /// <summary>
  /// Document button. Supports mouse-click and mouse-over actions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeActionButtonDocument))]
  ActionButtonDocument = 134,
  /// <summary>
  /// Sound button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeActionButtonSound))]
  ActionButtonSound = 135,
  /// <summary>
  /// Movie button. Supports mouse-click and mouse- over actions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeActionButtonMovie))]
  ActionButtonMovie = 136,
  /// <summary>
  /// Balloon.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeBalloon))]
  Balloon = 137,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeNotPrimitive))]
  NotPrimitive = 138,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFlowchartOfflineStorage))]
  FlowchartOfflineStorage = 139,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLeftRightRibbon))]
  LeftRightRibbon = 140,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeDiagonalStripe))]
  DiagonalStripe = 141,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapePie))]
  Pie = 142,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeNonIsoscelesTrapezoid))]
  NonIsoscelesTrapezoid = 143,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeDecagon))]
  Decagon = 144,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeHeptagon))]
  Heptagon = 145,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeDodecagon))]
  Dodecagon = 146,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShape6pointStar))]
  SixPointStar = 147,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShape7pointStar))]
  SevenPointStar = 148,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShape10pointStar))]
  TenPointStar = 149,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShape12pointStar))]
  TwelvePointStar = 150,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRound1Rectangle))]
  Round1Rectangle = 151,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRound2SameRectangle))]
  Round2SameRectangle = 152,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRound2DiagRectangle))]
  Round2DiagRectangle = 153,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeSnipRoundRectangle))]
  SnipRoundRectangle = 154,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeSnip1Rectangle))]
  Snip1Rectangle = 155,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeSnip2SameRectangle))]
  Snip2SameRectangle = 156,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeSnip2DiagRectangle))]
  Snip2DiagRectangle = 157,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFrame))]
  Frame = 158,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeHalfFrame))]
  HalfFrame = 159,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeTear))]
  Tear = 160,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeChord))]
  Chord = 161,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeCorner))]
  Corner = 162,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeMathPlus))]
  MathPlus = 163,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeMathMinus))]
  MathMinus = 164,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeMathMultiply))]
  MathMultiply = 165,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeMathDivide))]
  MathDivide = 166,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeMathEqual))]
  MathEqual = 167,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeMathNotEqual))]
  MathNotEqual = 168,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeCornerTabs))]
  CornerTabs = 169,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeSquareTabs))]
  SquareTabs = 170,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapePlaqueTabs))]
  PlaqueTabs = 171,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeGear6))]
  Gear6 = 172,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeGear9))]
  Gear9 = 173,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeFunnel))]
  Funnel = 174,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapePieWedge))]
  PieWedge = 175,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLeftCircularArrow))]
  LeftCircularArrow = 176,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLeftRightCircularArrow))]
  LeftRightCircularArrow = 177,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeSwooshArrow))]
  SwooshArrow = 178,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeCloud))]
  Cloud = 179,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeChartX))]
  ChartX = 180,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeChartStar))]
  ChartStar = 181,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeChartPlus))]
  ChartPlus = 182,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAutoShapeType.msoShapeLineInverse))]
  LineInverse = 183
}
