namespace DocumentModel.Drawings;


/// <summary>
///   Preset Shape Types
/// </summary>
public enum ShapeTypeKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;line&quot;.
  /// </summary>
  [EnumString("line")]
  Line,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lineInv&quot;.
  /// </summary>
  [EnumString("lineInv")]
  LineInverse,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;triangle&quot;.
  /// </summary>
  [EnumString("triangle")]
  Triangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rtTriangle&quot;.
  /// </summary>
  [EnumString("rtTriangle")]
  RightTriangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rect&quot;.
  /// </summary>
  [EnumString("rect")]
  Rectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;diamond&quot;.
  /// </summary>
  [EnumString("diamond")]
  Diamond,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;parallelogram&quot;.
  /// </summary>
  [EnumString("parallelogram")]
  Parallelogram,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;trapezoid&quot;.
  /// </summary>
  [EnumString("trapezoid")]
  Trapezoid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;nonIsoscelesTrapezoid&quot;.
  /// </summary>
  [EnumString("nonIsoscelesTrapezoid")]
  NonIsoscelesTrapezoid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pentagon&quot;.
  /// </summary>
  [EnumString("pentagon")]
  Pentagon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hexagon&quot;.
  /// </summary>
  [EnumString("hexagon")]
  Hexagon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;heptagon&quot;.
  /// </summary>
  [EnumString("heptagon")]
  Heptagon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;octagon&quot;.
  /// </summary>
  [EnumString("octagon")]
  Octagon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;decagon&quot;.
  /// </summary>
  [EnumString("decagon")]
  Decagon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dodecagon&quot;.
  /// </summary>
  [EnumString("dodecagon")]
  Dodecagon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star4&quot;.
  /// </summary>
  [EnumString("star4")]
  Star4,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star5&quot;.
  /// </summary>
  [EnumString("star5")]
  Star5,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star6&quot;.
  /// </summary>
  [EnumString("star6")]
  Star6,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star7&quot;.
  /// </summary>
  [EnumString("star7")]
  Star7,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star8&quot;.
  /// </summary>
  [EnumString("star8")]
  Star8,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star10&quot;.
  /// </summary>
  [EnumString("star10")]
  Star10,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star12&quot;.
  /// </summary>
  [EnumString("star12")]
  Star12,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star16&quot;.
  /// </summary>
  [EnumString("star16")]
  Star16,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star24&quot;.
  /// </summary>
  [EnumString("star24")]
  Star24,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;star32&quot;.
  /// </summary>
  [EnumString("star32")]
  Star32,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;roundRect&quot;.
  /// </summary>
  [EnumString("roundRect")]
  RoundRectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;round1Rect&quot;.
  /// </summary>
  [EnumString("round1Rect")]
  Round1Rectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;round2SameRect&quot;.
  /// </summary>
  [EnumString("round2SameRect")]
  Round2SameRectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;round2DiagRect&quot;.
  /// </summary>
  [EnumString("round2DiagRect")]
  Round2DiagonalRectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;snipRoundRect&quot;.
  /// </summary>
  [EnumString("snipRoundRect")]
  SnipRoundRectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;snip1Rect&quot;.
  /// </summary>
  [EnumString("snip1Rect")]
  Snip1Rectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;snip2SameRect&quot;.
  /// </summary>
  [EnumString("snip2SameRect")]
  Snip2SameRectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;snip2DiagRect&quot;.
  /// </summary>
  [EnumString("snip2DiagRect")]
  Snip2DiagonalRectangle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;plaque&quot;.
  /// </summary>
  [EnumString("plaque")]
  Plaque,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ellipse&quot;.
  /// </summary>
  [EnumString("ellipse")]
  Ellipse,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;teardrop&quot;.
  /// </summary>
  [EnumString("teardrop")]
  Teardrop,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;homePlate&quot;.
  /// </summary>
  [EnumString("homePlate")]
  HomePlate,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chevron&quot;.
  /// </summary>
  [EnumString("chevron")]
  Chevron,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pieWedge&quot;.
  /// </summary>
  [EnumString("pieWedge")]
  PieWedge,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pie&quot;.
  /// </summary>
  [EnumString("pie")]
  Pie,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;blockArc&quot;.
  /// </summary>
  [EnumString("blockArc")]
  BlockArc,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;donut&quot;.
  /// </summary>
  [EnumString("donut")]
  Donut,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;noSmoking&quot;.
  /// </summary>
  [EnumString("noSmoking")]
  NoSmoking,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rightArrow&quot;.
  /// </summary>
  [EnumString("rightArrow")]
  RightArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftArrow&quot;.
  /// </summary>
  [EnumString("leftArrow")]
  LeftArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;upArrow&quot;.
  /// </summary>
  [EnumString("upArrow")]
  UpArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;downArrow&quot;.
  /// </summary>
  [EnumString("downArrow")]
  DownArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;stripedRightArrow&quot;.
  /// </summary>
  [EnumString("stripedRightArrow")]
  StripedRightArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;notchedRightArrow&quot;.
  /// </summary>
  [EnumString("notchedRightArrow")]
  NotchedRightArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bentUpArrow&quot;.
  /// </summary>
  [EnumString("bentUpArrow")]
  BentUpArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftRightArrow&quot;.
  /// </summary>
  [EnumString("leftRightArrow")]
  LeftRightArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;upDownArrow&quot;.
  /// </summary>
  [EnumString("upDownArrow")]
  UpDownArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftUpArrow&quot;.
  /// </summary>
  [EnumString("leftUpArrow")]
  LeftUpArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftRightUpArrow&quot;.
  /// </summary>
  [EnumString("leftRightUpArrow")]
  LeftRightUpArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;quadArrow&quot;.
  /// </summary>
  [EnumString("quadArrow")]
  QuadArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftArrowCallout&quot;.
  /// </summary>
  [EnumString("leftArrowCallout")]
  LeftArrowCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rightArrowCallout&quot;.
  /// </summary>
  [EnumString("rightArrowCallout")]
  RightArrowCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;upArrowCallout&quot;.
  /// </summary>
  [EnumString("upArrowCallout")]
  UpArrowCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;downArrowCallout&quot;.
  /// </summary>
  [EnumString("downArrowCallout")]
  DownArrowCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftRightArrowCallout&quot;.
  /// </summary>
  [EnumString("leftRightArrowCallout")]
  LeftRightArrowCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;upDownArrowCallout&quot;.
  /// </summary>
  [EnumString("upDownArrowCallout")]
  UpDownArrowCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;quadArrowCallout&quot;.
  /// </summary>
  [EnumString("quadArrowCallout")]
  QuadArrowCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bentArrow&quot;.
  /// </summary>
  [EnumString("bentArrow")]
  BentArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;uturnArrow&quot;.
  /// </summary>
  [EnumString("uturnArrow")]
  UTurnArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;circularArrow&quot;.
  /// </summary>
  [EnumString("circularArrow")]
  CircularArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftCircularArrow&quot;.
  /// </summary>
  [EnumString("leftCircularArrow")]
  LeftCircularArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftRightCircularArrow&quot;.
  /// </summary>
  [EnumString("leftRightCircularArrow")]
  LeftRightCircularArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedRightArrow&quot;.
  /// </summary>
  [EnumString("curvedRightArrow")]
  CurvedRightArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedLeftArrow&quot;.
  /// </summary>
  [EnumString("curvedLeftArrow")]
  CurvedLeftArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedUpArrow&quot;.
  /// </summary>
  [EnumString("curvedUpArrow")]
  CurvedUpArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedDownArrow&quot;.
  /// </summary>
  [EnumString("curvedDownArrow")]
  CurvedDownArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;swooshArrow&quot;.
  /// </summary>
  [EnumString("swooshArrow")]
  SwooshArrow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cube&quot;.
  /// </summary>
  [EnumString("cube")]
  Cube,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;can&quot;.
  /// </summary>
  [EnumString("can")]
  Can,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lightningBolt&quot;.
  /// </summary>
  [EnumString("lightningBolt")]
  LightningBolt,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;heart&quot;.
  /// </summary>
  [EnumString("heart")]
  Heart,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sun&quot;.
  /// </summary>
  [EnumString("sun")]
  Sun,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;moon&quot;.
  /// </summary>
  [EnumString("moon")]
  Moon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;smileyFace&quot;.
  /// </summary>
  [EnumString("smileyFace")]
  SmileyFace,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;irregularSeal1&quot;.
  /// </summary>
  [EnumString("irregularSeal1")]
  IrregularSeal1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;irregularSeal2&quot;.
  /// </summary>
  [EnumString("irregularSeal2")]
  IrregularSeal2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;foldedCorner&quot;.
  /// </summary>
  [EnumString("foldedCorner")]
  FoldedCorner,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bevel&quot;.
  /// </summary>
  [EnumString("bevel")]
  Bevel,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;frame&quot;.
  /// </summary>
  [EnumString("frame")]
  Frame,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;halfFrame&quot;.
  /// </summary>
  [EnumString("halfFrame")]
  HalfFrame,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;corner&quot;.
  /// </summary>
  [EnumString("corner")]
  Corner,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;diagStripe&quot;.
  /// </summary>
  [EnumString("diagStripe")]
  DiagonalStripe,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chord&quot;.
  /// </summary>
  [EnumString("chord")]
  Chord,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;arc&quot;.
  /// </summary>
  [EnumString("arc")]
  Arc,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftBracket&quot;.
  /// </summary>
  [EnumString("leftBracket")]
  LeftBracket,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rightBracket&quot;.
  /// </summary>
  [EnumString("rightBracket")]
  RightBracket,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftBrace&quot;.
  /// </summary>
  [EnumString("leftBrace")]
  LeftBrace,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rightBrace&quot;.
  /// </summary>
  [EnumString("rightBrace")]
  RightBrace,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bracketPair&quot;.
  /// </summary>
  [EnumString("bracketPair")]
  BracketPair,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bracePair&quot;.
  /// </summary>
  [EnumString("bracePair")]
  BracePair,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;straightConnector1&quot;.
  /// </summary>
  [EnumString("straightConnector1")]
  StraightConnector1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bentConnector2&quot;.
  /// </summary>
  [EnumString("bentConnector2")]
  BentConnector2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bentConnector3&quot;.
  /// </summary>
  [EnumString("bentConnector3")]
  BentConnector3,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bentConnector4&quot;.
  /// </summary>
  [EnumString("bentConnector4")]
  BentConnector4,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bentConnector5&quot;.
  /// </summary>
  [EnumString("bentConnector5")]
  BentConnector5,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedConnector2&quot;.
  /// </summary>
  [EnumString("curvedConnector2")]
  CurvedConnector2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedConnector3&quot;.
  /// </summary>
  [EnumString("curvedConnector3")]
  CurvedConnector3,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedConnector4&quot;.
  /// </summary>
  [EnumString("curvedConnector4")]
  CurvedConnector4,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curvedConnector5&quot;.
  /// </summary>
  [EnumString("curvedConnector5")]
  CurvedConnector5,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;callout1&quot;.
  /// </summary>
  [EnumString("callout1")]
  Callout1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;callout2&quot;.
  /// </summary>
  [EnumString("callout2")]
  Callout2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;callout3&quot;.
  /// </summary>
  [EnumString("callout3")]
  Callout3,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accentCallout1&quot;.
  /// </summary>
  [EnumString("accentCallout1")]
  AccentCallout1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accentCallout2&quot;.
  /// </summary>
  [EnumString("accentCallout2")]
  AccentCallout2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accentCallout3&quot;.
  /// </summary>
  [EnumString("accentCallout3")]
  AccentCallout3,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;borderCallout1&quot;.
  /// </summary>
  [EnumString("borderCallout1")]
  BorderCallout1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;borderCallout2&quot;.
  /// </summary>
  [EnumString("borderCallout2")]
  BorderCallout2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;borderCallout3&quot;.
  /// </summary>
  [EnumString("borderCallout3")]
  BorderCallout3,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accentBorderCallout1&quot;.
  /// </summary>
  [EnumString("accentBorderCallout1")]
  AccentBorderCallout1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accentBorderCallout2&quot;.
  /// </summary>
  [EnumString("accentBorderCallout2")]
  AccentBorderCallout2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;accentBorderCallout3&quot;.
  /// </summary>
  [EnumString("accentBorderCallout3")]
  AccentBorderCallout3,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wedgeRectCallout&quot;.
  /// </summary>
  [EnumString("wedgeRectCallout")]
  WedgeRectangleCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wedgeRoundRectCallout&quot;.
  /// </summary>
  [EnumString("wedgeRoundRectCallout")]
  WedgeRoundRectangleCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wedgeEllipseCallout&quot;.
  /// </summary>
  [EnumString("wedgeEllipseCallout")]
  WedgeEllipseCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cloudCallout&quot;.
  /// </summary>
  [EnumString("cloudCallout")]
  CloudCallout,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cloud&quot;.
  /// </summary>
  [EnumString("cloud")]
  Cloud,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ribbon&quot;.
  /// </summary>
  [EnumString("ribbon")]
  Ribbon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ribbon2&quot;.
  /// </summary>
  [EnumString("ribbon2")]
  Ribbon2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ellipseRibbon&quot;.
  /// </summary>
  [EnumString("ellipseRibbon")]
  EllipseRibbon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ellipseRibbon2&quot;.
  /// </summary>
  [EnumString("ellipseRibbon2")]
  EllipseRibbon2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;leftRightRibbon&quot;.
  /// </summary>
  [EnumString("leftRightRibbon")]
  LeftRightRibbon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;verticalScroll&quot;.
  /// </summary>
  [EnumString("verticalScroll")]
  VerticalScroll,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;horizontalScroll&quot;.
  /// </summary>
  [EnumString("horizontalScroll")]
  HorizontalScroll,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wave&quot;.
  /// </summary>
  [EnumString("wave")]
  Wave,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;doubleWave&quot;.
  /// </summary>
  [EnumString("doubleWave")]
  DoubleWave,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;plus&quot;.
  /// </summary>
  [EnumString("plus")]
  Plus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartProcess&quot;.
  /// </summary>
  [EnumString("flowChartProcess")]
  FlowChartProcess,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartDecision&quot;.
  /// </summary>
  [EnumString("flowChartDecision")]
  FlowChartDecision,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartInputOutput&quot;.
  /// </summary>
  [EnumString("flowChartInputOutput")]
  FlowChartInputOutput,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartPredefinedProcess&quot;.
  /// </summary>
  [EnumString("flowChartPredefinedProcess")]
  FlowChartPredefinedProcess,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartInternalStorage&quot;.
  /// </summary>
  [EnumString("flowChartInternalStorage")]
  FlowChartInternalStorage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartDocument&quot;.
  /// </summary>
  [EnumString("flowChartDocument")]
  FlowChartDocument,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartMultidocument&quot;.
  /// </summary>
  [EnumString("flowChartMultidocument")]
  FlowChartMultidocument,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartTerminator&quot;.
  /// </summary>
  [EnumString("flowChartTerminator")]
  FlowChartTerminator,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartPreparation&quot;.
  /// </summary>
  [EnumString("flowChartPreparation")]
  FlowChartPreparation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartManualInput&quot;.
  /// </summary>
  [EnumString("flowChartManualInput")]
  FlowChartManualInput,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartManualOperation&quot;.
  /// </summary>
  [EnumString("flowChartManualOperation")]
  FlowChartManualOperation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartConnector&quot;.
  /// </summary>
  [EnumString("flowChartConnector")]
  FlowChartConnector,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartPunchedCard&quot;.
  /// </summary>
  [EnumString("flowChartPunchedCard")]
  FlowChartPunchedCard,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartPunchedTape&quot;.
  /// </summary>
  [EnumString("flowChartPunchedTape")]
  FlowChartPunchedTape,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartSummingJunction&quot;.
  /// </summary>
  [EnumString("flowChartSummingJunction")]
  FlowChartSummingJunction,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartOr&quot;.
  /// </summary>
  [EnumString("flowChartOr")]
  FlowChartOr,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartCollate&quot;.
  /// </summary>
  [EnumString("flowChartCollate")]
  FlowChartCollate,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartSort&quot;.
  /// </summary>
  [EnumString("flowChartSort")]
  FlowChartSort,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartExtract&quot;.
  /// </summary>
  [EnumString("flowChartExtract")]
  FlowChartExtract,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartMerge&quot;.
  /// </summary>
  [EnumString("flowChartMerge")]
  FlowChartMerge,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartOfflineStorage&quot;.
  /// </summary>
  [EnumString("flowChartOfflineStorage")]
  FlowChartOfflineStorage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartOnlineStorage&quot;.
  /// </summary>
  [EnumString("flowChartOnlineStorage")]
  FlowChartOnlineStorage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartMagneticTape&quot;.
  /// </summary>
  [EnumString("flowChartMagneticTape")]
  FlowChartMagneticTape,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartMagneticDisk&quot;.
  /// </summary>
  [EnumString("flowChartMagneticDisk")]
  FlowChartMagneticDisk,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartMagneticDrum&quot;.
  /// </summary>
  [EnumString("flowChartMagneticDrum")]
  FlowChartMagneticDrum,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartDisplay&quot;.
  /// </summary>
  [EnumString("flowChartDisplay")]
  FlowChartDisplay,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartDelay&quot;.
  /// </summary>
  [EnumString("flowChartDelay")]
  FlowChartDelay,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartAlternateProcess&quot;.
  /// </summary>
  [EnumString("flowChartAlternateProcess")]
  FlowChartAlternateProcess,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowChartOffpageConnector&quot;.
  /// </summary>
  [EnumString("flowChartOffpageConnector")]
  FlowChartOffpageConnector,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonBlank&quot;.
  /// </summary>
  [EnumString("actionButtonBlank")]
  ActionButtonBlank,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonHome&quot;.
  /// </summary>
  [EnumString("actionButtonHome")]
  ActionButtonHome,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonHelp&quot;.
  /// </summary>
  [EnumString("actionButtonHelp")]
  ActionButtonHelp,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonInformation&quot;.
  /// </summary>
  [EnumString("actionButtonInformation")]
  ActionButtonInformation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonForwardNext&quot;.
  /// </summary>
  [EnumString("actionButtonForwardNext")]
  ActionButtonForwardNext,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonBackPrevious&quot;.
  /// </summary>
  [EnumString("actionButtonBackPrevious")]
  ActionButtonBackPrevious,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonEnd&quot;.
  /// </summary>
  [EnumString("actionButtonEnd")]
  ActionButtonEnd,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonBeginning&quot;.
  /// </summary>
  [EnumString("actionButtonBeginning")]
  ActionButtonBeginning,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonReturn&quot;.
  /// </summary>
  [EnumString("actionButtonReturn")]
  ActionButtonReturn,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonDocument&quot;.
  /// </summary>
  [EnumString("actionButtonDocument")]
  ActionButtonDocument,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonSound&quot;.
  /// </summary>
  [EnumString("actionButtonSound")]
  ActionButtonSound,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;actionButtonMovie&quot;.
  /// </summary>
  [EnumString("actionButtonMovie")]
  ActionButtonMovie,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gear6&quot;.
  /// </summary>
  [EnumString("gear6")]
  Gear6,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gear9&quot;.
  /// </summary>
  [EnumString("gear9")]
  Gear9,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;funnel&quot;.
  /// </summary>
  [EnumString("funnel")]
  Funnel,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mathPlus&quot;.
  /// </summary>
  [EnumString("mathPlus")]
  MathPlus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mathMinus&quot;.
  /// </summary>
  [EnumString("mathMinus")]
  MathMinus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mathMultiply&quot;.
  /// </summary>
  [EnumString("mathMultiply")]
  MathMultiply,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mathDivide&quot;.
  /// </summary>
  [EnumString("mathDivide")]
  MathDivide,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mathEqual&quot;.
  /// </summary>
  [EnumString("mathEqual")]
  MathEqual,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mathNotEqual&quot;.
  /// </summary>
  [EnumString("mathNotEqual")]
  MathNotEqual,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cornerTabs&quot;.
  /// </summary>
  [EnumString("cornerTabs")]
  CornerTabs,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;squareTabs&quot;.
  /// </summary>
  [EnumString("squareTabs")]
  SquareTabs,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;plaqueTabs&quot;.
  /// </summary>
  [EnumString("plaqueTabs")]
  PlaqueTabs,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chartX&quot;.
  /// </summary>
  [EnumString("chartX")]
  ChartX,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chartStar&quot;.
  /// </summary>
  [EnumString("chartStar")]
  ChartStar,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chartPlus&quot;.
  /// </summary>
  [EnumString("chartPlus")]
  ChartPlus,
  
}
