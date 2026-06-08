namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BorderValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BorderKind
{
  /// <summary>
  ///   No IBorder.
  /// </summary>
  Nil,

  /// <summary>
  ///   No IBorder.
  /// </summary>
  None,

  /// <summary>
  ///   Single ILine IBorder.
  /// </summary>
  Single,

  /// <summary>
  ///   Single ILine IBorder.
  /// </summary>
  Thick,

  /// <summary>
  ///   Double ILine IBorder.
  /// </summary>
  Double,

  /// <summary>
  ///   Dotted ILine IBorder.
  /// </summary>
  Dotted,

  /// <summary>
  ///   Dashed ILine IBorder.
  /// </summary>
  Dashed,

  /// <summary>
  ///   Dot Dash ILine IBorder.
  /// </summary>
  DotDash,

  /// <summary>
  ///   Dot Dot Dash ILine IBorder.
  /// </summary>
  DotDotDash,

  /// <summary>
  ///   Triple ILine IBorder.
  /// </summary>
  Triple,

  /// <summary>
  ///   Thin, Thick ILine IBorder.
  /// </summary>
  ThinThickSmallGap,

  /// <summary>
  ///   Thick, Thin ILine IBorder.
  /// </summary>
  ThickThinSmallGap,

  /// <summary>
  ///   Thin, Thick, Thin ILine IBorder.
  /// </summary>
  ThinThickThinSmallGap,

  /// <summary>
  ///   Thin, Thick ILine IBorder.
  /// </summary>
  ThinThickMediumGap,

  /// <summary>
  ///   Thick, Thin ILine IBorder.
  /// </summary>
  ThickThinMediumGap,

  /// <summary>
  ///   Thin, Thick, Thin ILine IBorder.
  /// </summary>
  ThinThickThinMediumGap,

  /// <summary>
  ///   Thin, Thick ILine IBorder.
  /// </summary>
  ThinThickLargeGap,

  /// <summary>
  ///   Thick, Thin ILine IBorder.
  /// </summary>
  ThickThinLargeGap,

  /// <summary>
  ///   Thin, Thick, Thin ILine IBorder.
  /// </summary>
  ThinThickThinLargeGap,

  /// <summary>
  ///   Wavy ILine IBorder.
  /// </summary>
  Wave,

  /// <summary>
  ///   Double Wave ILine IBorder.
  /// </summary>
  DoubleWave,

  /// <summary>
  ///   Dashed ILine IBorder.
  /// </summary>
  DashSmallGap,

  /// <summary>
  ///   Dash Dot Strokes ILine IBorder.
  /// </summary>
  DashDotStroked,

  /// <summary>
  ///   3D Embossed ILine IBorder.
  /// </summary>
  ThreeDEmboss,

  /// <summary>
  ///   3D Engraved ILine IBorder.
  /// </summary>
  ThreeDEngrave,

  /// <summary>
  ///   Outset ILine IBorder.
  /// </summary>
  Outset,

  /// <summary>
  ///   Inset ILine IBorder.
  /// </summary>
  Inset,

  /// <summary>
  ///   Apples Art IBorder.
  /// </summary>
  Apples,

  /// <summary>
  ///   Arched Scallops Art IBorder.
  /// </summary>
  ArchedScallops,

  /// <summary>
  ///   Baby Pacifier Art IBorder.
  /// </summary>
  BabyPacifier,

  /// <summary>
  ///   Baby Rattle Art IBorder.
  /// </summary>
  BabyRattle,

  /// <summary>
  ///   Three Color Balloons Art IBorder.
  /// </summary>
  Balloons3Colors,

  /// <summary>
  ///   Hot Air Balloons Art IBorder.
  /// </summary>
  BalloonsHotAir,

  /// <summary>
  ///   Black Dash Art IBorder.
  /// </summary>
  BasicBlackDashes,

  /// <summary>
  ///   Black Dot Art IBorder.
  /// </summary>
  BasicBlackDots,

  /// <summary>
  ///   Black Square Art IBorder.
  /// </summary>
  BasicBlackSquares,

  /// <summary>
  ///   Thin ILine Art IBorder.
  /// </summary>
  BasicThinLines,

  /// <summary>
  ///   White Dash Art IBorder.
  /// </summary>
  BasicWhiteDashes,

  /// <summary>
  ///   White Dot Art IBorder.
  /// </summary>
  BasicWhiteDots,

  /// <summary>
  ///   White Square Art IBorder.
  /// </summary>
  BasicWhiteSquares,

  /// <summary>
  ///   Wide Inline Art IBorder.
  /// </summary>
  BasicWideInline,

  /// <summary>
  ///   Wide Midline Art IBorder.
  /// </summary>
  BasicWideMidline,

  /// <summary>
  ///   Wide Outline Art IBorder.
  /// </summary>
  BasicWideOutline,

  /// <summary>
  ///   Bats Art IBorder.
  /// </summary>
  Bats,

  /// <summary>
  ///   Birds Art IBorder.
  /// </summary>
  Birds,

  /// <summary>
  ///   Birds Flying Art IBorder.
  /// </summary>
  BirdsFlight,

  /// <summary>
  ///   Cabin Art IBorder.
  /// </summary>
  Cabins,

  /// <summary>
  ///   Cake Art IBorder.
  /// </summary>
  CakeSlice,

  /// <summary>
  ///   Candy Corn Art IBorder.
  /// </summary>
  CandyCorn,

  /// <summary>
  ///   Knot Work Art IBorder.
  /// </summary>
  CelticKnotwork,

  /// <summary>
  ///   Certificate Banner Art IBorder.
  /// </summary>
  CertificateBanner,

  /// <summary>
  ///   Chain Link Art IBorder.
  /// </summary>
  ChainLink,

  /// <summary>
  ///   Champagne Bottle Art IBorder.
  /// </summary>
  ChampagneBottle,

  /// <summary>
  ///   Black and White Bar Art IBorder.
  /// </summary>
  CheckedBarBlack,

  /// <summary>
  ///   Color Checked Bar Art IBorder.
  /// </summary>
  CheckedBarColor,

  /// <summary>
  ///   Checkerboard Art IBorder.
  /// </summary>
  Checkered,

  /// <summary>
  ///   Christmas Tree Art IBorder.
  /// </summary>
  ChristmasTree,

  /// <summary>
  ///   Circles And ILines Art IBorder.
  /// </summary>
  CirclesLines,

  /// <summary>
  ///   Circles and IRectangles Art IBorder.
  /// </summary>
  CirclesRectangles,

  /// <summary>
  ///   Wave Art IBorder.
  /// </summary>
  ClassicalWave,

  /// <summary>
  ///   Clocks Art IBorder.
  /// </summary>
  Clocks,

  /// <summary>
  ///   Compass Art IBorder.
  /// </summary>
  Compass,

  /// <summary>
  ///   Confetti Art IBorder.
  /// </summary>
  Confetti,

  /// <summary>
  ///   Confetti Art IBorder.
  /// </summary>
  ConfettiGrays,

  /// <summary>
  ///   Confetti Art IBorder.
  /// </summary>
  ConfettiOutline,

  /// <summary>
  ///   Confetti Streamers Art IBorder.
  /// </summary>
  ConfettiStreamers,

  /// <summary>
  ///   Confetti Art IBorder.
  /// </summary>
  ConfettiWhite,

  /// <summary>
  ///   Corner Triangle Art IBorder.
  /// </summary>
  CornerTriangles,

  /// <summary>
  ///   Dashed ILine Art IBorder.
  /// </summary>
  CouponCutoutDashes,

  /// <summary>
  ///   Dotted ILine Art IBorder.
  /// </summary>
  CouponCutoutDots,

  /// <summary>
  ///   Maze Art IBorder.
  /// </summary>
  CrazyMaze,

  /// <summary>
  ///   Butterfly Art IBorder.
  /// </summary>
  CreaturesButterfly,

  /// <summary>
  ///   Fish Art IBorder.
  /// </summary>
  CreaturesFish,

  /// <summary>
  ///   Insects Art IBorder.
  /// </summary>
  CreaturesInsects,

  /// <summary>
  ///   Ladybug Art IBorder.
  /// </summary>
  CreaturesLadyBug,

  /// <summary>
  ///   Cross-stitch Art IBorder.
  /// </summary>
  CrossStitch,

  /// <summary>
  ///   Cupid Art IBorder.
  /// </summary>
  Cup,

  /// <summary>
  ///   Archway Art IBorder.
  /// </summary>
  DecoArch,

  /// <summary>
  ///   Color Archway Art IBorder.
  /// </summary>
  DecoArchColor,

  /// <summary>
  ///   Blocks Art IBorder.
  /// </summary>
  DecoBlocks,

  /// <summary>
  ///   Gray Diamond Art IBorder.
  /// </summary>
  DiamondsGray,

  /// <summary>
  ///   Double D Art IBorder.
  /// </summary>
  DoubleD,

  /// <summary>
  ///   Diamond Art IBorder.
  /// </summary>
  DoubleDiamonds,

  /// <summary>
  ///   Earth Art IBorder.
  /// </summary>
  Earth1,

  /// <summary>
  ///   Earth Art IBorder.
  /// </summary>
  Earth2,

  /// <summary>
  ///   Shadowed Square Art IBorder.
  /// </summary>
  EclipsingSquares1,

  /// <summary>
  ///   Shadowed Square Art IBorder.
  /// </summary>
  EclipsingSquares2,

  /// <summary>
  ///   Painted Egg Art IBorder.
  /// </summary>
  EggsBlack,

  /// <summary>
  ///   Fans Art IBorder.
  /// </summary>
  Fans,

  /// <summary>
  ///   Film Reel Art IBorder.
  /// </summary>
  Film,

  /// <summary>
  ///   Firecracker Art IBorder.
  /// </summary>
  Firecrackers,

  /// <summary>
  ///   Flowers Art IBorder.
  /// </summary>
  FlowersBlockPrint,

  /// <summary>
  ///   Daisy Art IBorder.
  /// </summary>
  FlowersDaisies,

  /// <summary>
  ///   Flowers Art IBorder.
  /// </summary>
  FlowersModern1,

  /// <summary>
  ///   Flowers Art IBorder.
  /// </summary>
  FlowersModern2,

  /// <summary>
  ///   Pansy Art IBorder.
  /// </summary>
  FlowersPansy,

  /// <summary>
  ///   Red Rose Art IBorder.
  /// </summary>
  FlowersRedRose,

  /// <summary>
  ///   Roses Art IBorder.
  /// </summary>
  FlowersRoses,

  /// <summary>
  ///   Flowers in a Teacup Art IBorder.
  /// </summary>
  FlowersTeacup,

  /// <summary>
  ///   Small Flower Art IBorder.
  /// </summary>
  FlowersTiny,

  /// <summary>
  ///   Gems Art IBorder.
  /// </summary>
  Gems,

  /// <summary>
  ///   Gingerbread Man Art IBorder.
  /// </summary>
  GingerbreadMan,

  /// <summary>
  ///   Triangle Gradient Art IBorder.
  /// </summary>
  Gradient,

  /// <summary>
  ///   Handmade Art IBorder.
  /// </summary>
  Handmade1,

  /// <summary>
  ///   Handmade Art IBorder.
  /// </summary>
  Handmade2,

  /// <summary>
  ///   Heart-Shaped Balloon Art IBorder.
  /// </summary>
  HeartBalloon,

  /// <summary>
  ///   Gray Heart Art IBorder.
  /// </summary>
  HeartGray,

  /// <summary>
  ///   Hearts Art IBorder.
  /// </summary>
  Hearts,

  /// <summary>
  ///   Pattern Art IBorder.
  /// </summary>
  HeebieJeebies,

  /// <summary>
  ///   Holly Art IBorder.
  /// </summary>
  Holly,

  /// <summary>
  ///   House Art IBorder.
  /// </summary>
  HouseFunky,

  /// <summary>
  ///   Circular Art IBorder.
  /// </summary>
  Hypnotic,

  /// <summary>
  ///   Ice Cream Cone Art IBorder.
  /// </summary>
  IceCreamCones,

  /// <summary>
  ///   Light Bulb Art IBorder.
  /// </summary>
  LightBulb,

  /// <summary>
  ///   Lightning Art IBorder.
  /// </summary>
  Lightning1,

  /// <summary>
  ///   Lightning Art IBorder.
  /// </summary>
  Lightning2,

  /// <summary>
  ///   Map Pins Art IBorder.
  /// </summary>
  MapPins,

  /// <summary>
  ///   Maple Leaf Art IBorder.
  /// </summary>
  MapleLeaf,

  /// <summary>
  ///   Muffin Art IBorder.
  /// </summary>
  MapleMuffins,

  /// <summary>
  ///   Marquee Art IBorder.
  /// </summary>
  Marquee,

  /// <summary>
  ///   Marquee Art IBorder.
  /// </summary>
  MarqueeToothed,

  /// <summary>
  ///   Moon Art IBorder.
  /// </summary>
  Moons,

  /// <summary>
  ///   Mosaic Art IBorder.
  /// </summary>
  Mosaic,

  /// <summary>
  ///   Musical Note Art IBorder.
  /// </summary>
  MusicNotes,

  /// <summary>
  ///   Patterned Art IBorder.
  /// </summary>
  Northwest,

  /// <summary>
  ///   Oval Art IBorder.
  /// </summary>
  Ovals,

  /// <summary>
  ///   Package Art IBorder.
  /// </summary>
  Packages,

  /// <summary>
  ///   Black Palm Tree Art IBorder.
  /// </summary>
  PalmsBlack,

  /// <summary>
  ///   Color Palm Tree Art IBorder.
  /// </summary>
  PalmsColor,

  /// <summary>
  ///   Paper Clip Art IBorder.
  /// </summary>
  PaperClips,

  /// <summary>
  ///   Papyrus Art IBorder.
  /// </summary>
  Papyrus,

  /// <summary>
  ///   Party Favor Art IBorder.
  /// </summary>
  PartyFavor,

  /// <summary>
  ///   Party Glass Art IBorder.
  /// </summary>
  PartyGlass,

  /// <summary>
  ///   Pencils Art IBorder.
  /// </summary>
  Pencils,

  /// <summary>
  ///   Character Art IBorder.
  /// </summary>
  People,

  /// <summary>
  ///   Waving Character IBorder.
  /// </summary>
  PeopleWaving,

  /// <summary>
  ///   Character With Hat Art IBorder.
  /// </summary>
  PeopleHats,

  /// <summary>
  ///   Poinsettia Art IBorder.
  /// </summary>
  Poinsettias,

  /// <summary>
  ///   Postage Stamp Art IBorder.
  /// </summary>
  PostageStamp,

  /// <summary>
  ///   Pumpkin Art IBorder.
  /// </summary>
  Pumpkin1,

  /// <summary>
  ///   Push Pin Art IBorder.
  /// </summary>
  PushPinNote2,

  /// <summary>
  ///   Push Pin Art IBorder.
  /// </summary>
  PushPinNote1,

  /// <summary>
  ///   Pyramid Art IBorder.
  /// </summary>
  Pyramids,

  /// <summary>
  ///   Pyramid Art IBorder.
  /// </summary>
  PyramidsAbove,

  /// <summary>
  ///   Quadrants Art IBorder.
  /// </summary>
  Quadrants,

  /// <summary>
  ///   Rings Art IBorder.
  /// </summary>
  Rings,

  /// <summary>
  ///   Safari Art IBorder.
  /// </summary>
  Safari,

  /// <summary>
  ///   Saw tooth Art IBorder.
  /// </summary>
  Sawtooth,

  /// <summary>
  ///   Gray Saw tooth Art IBorder.
  /// </summary>
  SawtoothGray,

  /// <summary>
  ///   Scared Cat Art IBorder.
  /// </summary>
  ScaredCat,

  /// <summary>
  ///   Umbrella Art IBorder.
  /// </summary>
  Seattle,

  /// <summary>
  ///   Shadowed Squares Art IBorder.
  /// </summary>
  ShadowedSquares,

  /// <summary>
  ///   Shark Tooth Art IBorder.
  /// </summary>
  SharksTeeth,

  /// <summary>
  ///   Bird Tracks Art IBorder.
  /// </summary>
  ShorebirdTracks,

  /// <summary>
  ///   Rocket Art IBorder.
  /// </summary>
  Skyrocket,

  /// <summary>
  ///   Snowflake Art IBorder.
  /// </summary>
  SnowflakeFancy,

  /// <summary>
  ///   Snowflake Art IBorder.
  /// </summary>
  Snowflakes,

  /// <summary>
  ///   Sombrero Art IBorder.
  /// </summary>
  Sombrero,

  /// <summary>
  ///   Southwest-themed Art IBorder.
  /// </summary>
  Southwest,

  /// <summary>
  ///   Stars Art IBorder.
  /// </summary>
  Stars,

  /// <summary>
  ///   Stars On Top Art IBorder.
  /// </summary>
  StarsTop,

  /// <summary>
  ///   3-D Stars Art IBorder.
  /// </summary>
  Stars3d,

  /// <summary>
  ///   Stars Art IBorder.
  /// </summary>
  StarsBlack,

  /// <summary>
  ///   Stars With Shadows Art IBorder.
  /// </summary>
  StarsShadowed,

  /// <summary>
  ///   Sun Art IBorder.
  /// </summary>
  Sun,

  /// <summary>
  ///   Whirligig Art IBorder.
  /// </summary>
  Swirligig,

  /// <summary>
  ///   Torn Paper Art IBorder.
  /// </summary>
  TornPaper,

  /// <summary>
  ///   Black Torn Paper Art IBorder.
  /// </summary>
  TornPaperBlack,

  /// <summary>
  ///   Tree Art IBorder.
  /// </summary>
  Trees,

  /// <summary>
  ///   Triangle Art IBorder.
  /// </summary>
  TriangleParty,

  /// <summary>
  ///   Triangles Art IBorder.
  /// </summary>
  Triangles,

  /// <summary>
  ///   Tribal Art IBorder One.
  /// </summary>
  Tribal1,

  /// <summary>
  ///   Tribal Art IBorder Two.
  /// </summary>
  Tribal2,

  /// <summary>
  ///   Tribal Art IBorder Three.
  /// </summary>
  Tribal3,

  /// <summary>
  ///   Tribal Art IBorder Four.
  /// </summary>
  Tribal4,

  /// <summary>
  ///   Tribal Art IBorder Five.
  /// </summary>
  Tribal5,

  /// <summary>
  ///   Tribal Art IBorder Six.
  /// </summary>
  Tribal6,

  /// <summary>
  ///   triangle1.
  /// </summary>
  Triangle1,

  /// <summary>
  ///   triangle2.
  /// </summary>
  Triangle2,

  /// <summary>
  ///   triangleCircle1.
  /// </summary>
  TriangleCircle1,

  /// <summary>
  ///   triangleCircle2.
  /// </summary>
  TriangleCircle2,

  /// <summary>
  ///   shapes1.
  /// </summary>
  Shapes1,

  /// <summary>
  ///   shapes2.
  /// </summary>
  Shapes2,

  /// <summary>
  ///   Twisted ILines Art IBorder.
  /// </summary>
  TwistedLines1,

  /// <summary>
  ///   Twisted ILines Art IBorder.
  /// </summary>
  TwistedLines2,

  /// <summary>
  ///   Vine Art IBorder.
  /// </summary>
  Vine,

  /// <summary>
  ///   Wavy ILine Art IBorder.
  /// </summary>
  Waveline,

  /// <summary>
  ///   Weaving Angles Art IBorder.
  /// </summary>
  WeavingAngles,

  /// <summary>
  ///   Weaving Braid Art IBorder.
  /// </summary>
  WeavingBraid,

  /// <summary>
  ///   Weaving Ribbon Art IBorder.
  /// </summary>
  WeavingRibbon,

  /// <summary>
  ///   Weaving Strips Art IBorder.
  /// </summary>
  WeavingStrips,

  /// <summary>
  ///   White Flowers Art IBorder.
  /// </summary>
  WhiteFlowers,

  /// <summary>
  ///   Woodwork Art IBorder.
  /// </summary>
  Woodwork,

  /// <summary>
  ///   Crisscross Art IBorder.
  /// </summary>
  XIllusions,

  /// <summary>
  ///   Triangle Art IBorder.
  /// </summary>
  ZanyTriangles,

  /// <summary>
  ///   Zigzag Art IBorder.
  /// </summary>
  ZigZag,

  /// <summary>
  ///   Zigzag stitch.
  /// </summary>
  ZigZagStitch
}
