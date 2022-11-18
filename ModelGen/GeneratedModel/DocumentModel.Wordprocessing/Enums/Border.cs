namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BorderValues enumeration.
/// </summary>
public enum Border
{
  /// <summary>
  /// No Border.
  /// </summary>
  [XmlEnum("nil")]
  Nil,
  
  /// <summary>
  /// No Border.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Single Line Border.
  /// </summary>
  [XmlEnum("single")]
  Single,
  
  /// <summary>
  /// Single Line Border.
  /// </summary>
  [XmlEnum("thick")]
  Thick,
  
  /// <summary>
  /// Double Line Border.
  /// </summary>
  [XmlEnum("double")]
  Double,
  
  /// <summary>
  /// Dotted Line Border.
  /// </summary>
  [XmlEnum("dotted")]
  Dotted,
  
  /// <summary>
  /// Dashed Line Border.
  /// </summary>
  [XmlEnum("dashed")]
  Dashed,
  
  /// <summary>
  /// Dot Dash Line Border.
  /// </summary>
  [XmlEnum("dotDash")]
  DotDash,
  
  /// <summary>
  /// Dot Dot Dash Line Border.
  /// </summary>
  [XmlEnum("dotDotDash")]
  DotDotDash,
  
  /// <summary>
  /// Triple Line Border.
  /// </summary>
  [XmlEnum("triple")]
  Triple,
  
  /// <summary>
  /// Thin, Thick Line Border.
  /// </summary>
  [XmlEnum("thinThickSmallGap")]
  ThinThickSmallGap,
  
  /// <summary>
  /// Thick, Thin Line Border.
  /// </summary>
  [XmlEnum("thickThinSmallGap")]
  ThickThinSmallGap,
  
  /// <summary>
  /// Thin, Thick, Thin Line Border.
  /// </summary>
  [XmlEnum("thinThickThinSmallGap")]
  ThinThickThinSmallGap,
  
  /// <summary>
  /// Thin, Thick Line Border.
  /// </summary>
  [XmlEnum("thinThickMediumGap")]
  ThinThickMediumGap,
  
  /// <summary>
  /// Thick, Thin Line Border.
  /// </summary>
  [XmlEnum("thickThinMediumGap")]
  ThickThinMediumGap,
  
  /// <summary>
  /// Thin, Thick, Thin Line Border.
  /// </summary>
  [XmlEnum("thinThickThinMediumGap")]
  ThinThickThinMediumGap,
  
  /// <summary>
  /// Thin, Thick Line Border.
  /// </summary>
  [XmlEnum("thinThickLargeGap")]
  ThinThickLargeGap,
  
  /// <summary>
  /// Thick, Thin Line Border.
  /// </summary>
  [XmlEnum("thickThinLargeGap")]
  ThickThinLargeGap,
  
  /// <summary>
  /// Thin, Thick, Thin Line Border.
  /// </summary>
  [XmlEnum("thinThickThinLargeGap")]
  ThinThickThinLargeGap,
  
  /// <summary>
  /// Wavy Line Border.
  /// </summary>
  [XmlEnum("wave")]
  Wave,
  
  /// <summary>
  /// Double Wave Line Border.
  /// </summary>
  [XmlEnum("doubleWave")]
  DoubleWave,
  
  /// <summary>
  /// Dashed Line Border.
  /// </summary>
  [XmlEnum("dashSmallGap")]
  DashSmallGap,
  
  /// <summary>
  /// Dash Dot Strokes Line Border.
  /// </summary>
  [XmlEnum("dashDotStroked")]
  DashDotStroked,
  
  /// <summary>
  /// 3D Embossed Line Border.
  /// </summary>
  [XmlEnum("threeDEmboss")]
  ThreeDEmboss,
  
  /// <summary>
  /// 3D Engraved Line Border.
  /// </summary>
  [XmlEnum("threeDEngrave")]
  ThreeDEngrave,
  
  /// <summary>
  /// Outset Line Border.
  /// </summary>
  [XmlEnum("outset")]
  Outset,
  
  /// <summary>
  /// Inset Line Border.
  /// </summary>
  [XmlEnum("inset")]
  Inset,
  
  /// <summary>
  /// Apples Art Border.
  /// </summary>
  [XmlEnum("apples")]
  Apples,
  
  /// <summary>
  /// Arched Scallops Art Border.
  /// </summary>
  [XmlEnum("archedScallops")]
  ArchedScallops,
  
  /// <summary>
  /// Baby Pacifier Art Border.
  /// </summary>
  [XmlEnum("babyPacifier")]
  BabyPacifier,
  
  /// <summary>
  /// Baby Rattle Art Border.
  /// </summary>
  [XmlEnum("babyRattle")]
  BabyRattle,
  
  /// <summary>
  /// Three Color Balloons Art Border.
  /// </summary>
  [XmlEnum("balloons3Colors")]
  Balloons3Colors,
  
  /// <summary>
  /// Hot Air Balloons Art Border.
  /// </summary>
  [XmlEnum("balloonsHotAir")]
  BalloonsHotAir,
  
  /// <summary>
  /// Black Dash Art Border.
  /// </summary>
  [XmlEnum("basicBlackDashes")]
  BasicBlackDashes,
  
  /// <summary>
  /// Black Dot Art Border.
  /// </summary>
  [XmlEnum("basicBlackDots")]
  BasicBlackDots,
  
  /// <summary>
  /// Black Square Art Border.
  /// </summary>
  [XmlEnum("basicBlackSquares")]
  BasicBlackSquares,
  
  /// <summary>
  /// Thin Line Art Border.
  /// </summary>
  [XmlEnum("basicThinLines")]
  BasicThinLines,
  
  /// <summary>
  /// White Dash Art Border.
  /// </summary>
  [XmlEnum("basicWhiteDashes")]
  BasicWhiteDashes,
  
  /// <summary>
  /// White Dot Art Border.
  /// </summary>
  [XmlEnum("basicWhiteDots")]
  BasicWhiteDots,
  
  /// <summary>
  /// White Square Art Border.
  /// </summary>
  [XmlEnum("basicWhiteSquares")]
  BasicWhiteSquares,
  
  /// <summary>
  /// Wide Inline Art Border.
  /// </summary>
  [XmlEnum("basicWideInline")]
  BasicWideInline,
  
  /// <summary>
  /// Wide Midline Art Border.
  /// </summary>
  [XmlEnum("basicWideMidline")]
  BasicWideMidline,
  
  /// <summary>
  /// Wide Outline Art Border.
  /// </summary>
  [XmlEnum("basicWideOutline")]
  BasicWideOutline,
  
  /// <summary>
  /// Bats Art Border.
  /// </summary>
  [XmlEnum("bats")]
  Bats,
  
  /// <summary>
  /// Birds Art Border.
  /// </summary>
  [XmlEnum("birds")]
  Birds,
  
  /// <summary>
  /// Birds Flying Art Border.
  /// </summary>
  [XmlEnum("birdsFlight")]
  BirdsFlight,
  
  /// <summary>
  /// Cabin Art Border.
  /// </summary>
  [XmlEnum("cabins")]
  Cabins,
  
  /// <summary>
  /// Cake Art Border.
  /// </summary>
  [XmlEnum("cakeSlice")]
  CakeSlice,
  
  /// <summary>
  /// Candy Corn Art Border.
  /// </summary>
  [XmlEnum("candyCorn")]
  CandyCorn,
  
  /// <summary>
  /// Knot Work Art Border.
  /// </summary>
  [XmlEnum("celticKnotwork")]
  CelticKnotwork,
  
  /// <summary>
  /// Certificate Banner Art Border.
  /// </summary>
  [XmlEnum("certificateBanner")]
  CertificateBanner,
  
  /// <summary>
  /// Chain Link Art Border.
  /// </summary>
  [XmlEnum("chainLink")]
  ChainLink,
  
  /// <summary>
  /// Champagne Bottle Art Border.
  /// </summary>
  [XmlEnum("champagneBottle")]
  ChampagneBottle,
  
  /// <summary>
  /// Black and White Bar Art Border.
  /// </summary>
  [XmlEnum("checkedBarBlack")]
  CheckedBarBlack,
  
  /// <summary>
  /// Color Checked Bar Art Border.
  /// </summary>
  [XmlEnum("checkedBarColor")]
  CheckedBarColor,
  
  /// <summary>
  /// Checkerboard Art Border.
  /// </summary>
  [XmlEnum("checkered")]
  Checkered,
  
  /// <summary>
  /// Christmas Tree Art Border.
  /// </summary>
  [XmlEnum("christmasTree")]
  ChristmasTree,
  
  /// <summary>
  /// Circles And Lines Art Border.
  /// </summary>
  [XmlEnum("circlesLines")]
  CirclesLines,
  
  /// <summary>
  /// Circles and Rectangles Art Border.
  /// </summary>
  [XmlEnum("circlesRectangles")]
  CirclesRectangles,
  
  /// <summary>
  /// Wave Art Border.
  /// </summary>
  [XmlEnum("classicalWave")]
  ClassicalWave,
  
  /// <summary>
  /// Clocks Art Border.
  /// </summary>
  [XmlEnum("clocks")]
  Clocks,
  
  /// <summary>
  /// Compass Art Border.
  /// </summary>
  [XmlEnum("compass")]
  Compass,
  
  /// <summary>
  /// Confetti Art Border.
  /// </summary>
  [XmlEnum("confetti")]
  Confetti,
  
  /// <summary>
  /// Confetti Art Border.
  /// </summary>
  [XmlEnum("confettiGrays")]
  ConfettiGrays,
  
  /// <summary>
  /// Confetti Art Border.
  /// </summary>
  [XmlEnum("confettiOutline")]
  ConfettiOutline,
  
  /// <summary>
  /// Confetti Streamers Art Border.
  /// </summary>
  [XmlEnum("confettiStreamers")]
  ConfettiStreamers,
  
  /// <summary>
  /// Confetti Art Border.
  /// </summary>
  [XmlEnum("confettiWhite")]
  ConfettiWhite,
  
  /// <summary>
  /// Corner Triangle Art Border.
  /// </summary>
  [XmlEnum("cornerTriangles")]
  CornerTriangles,
  
  /// <summary>
  /// Dashed Line Art Border.
  /// </summary>
  [XmlEnum("couponCutoutDashes")]
  CouponCutoutDashes,
  
  /// <summary>
  /// Dotted Line Art Border.
  /// </summary>
  [XmlEnum("couponCutoutDots")]
  CouponCutoutDots,
  
  /// <summary>
  /// Maze Art Border.
  /// </summary>
  [XmlEnum("crazyMaze")]
  CrazyMaze,
  
  /// <summary>
  /// Butterfly Art Border.
  /// </summary>
  [XmlEnum("creaturesButterfly")]
  CreaturesButterfly,
  
  /// <summary>
  /// Fish Art Border.
  /// </summary>
  [XmlEnum("creaturesFish")]
  CreaturesFish,
  
  /// <summary>
  /// Insects Art Border.
  /// </summary>
  [XmlEnum("creaturesInsects")]
  CreaturesInsects,
  
  /// <summary>
  /// Ladybug Art Border.
  /// </summary>
  [XmlEnum("creaturesLadyBug")]
  CreaturesLadyBug,
  
  /// <summary>
  /// Cross-stitch Art Border.
  /// </summary>
  [XmlEnum("crossStitch")]
  CrossStitch,
  
  /// <summary>
  /// Cupid Art Border.
  /// </summary>
  [XmlEnum("cup")]
  Cup,
  
  /// <summary>
  /// Archway Art Border.
  /// </summary>
  [XmlEnum("decoArch")]
  DecoArch,
  
  /// <summary>
  /// Color Archway Art Border.
  /// </summary>
  [XmlEnum("decoArchColor")]
  DecoArchColor,
  
  /// <summary>
  /// Blocks Art Border.
  /// </summary>
  [XmlEnum("decoBlocks")]
  DecoBlocks,
  
  /// <summary>
  /// Gray Diamond Art Border.
  /// </summary>
  [XmlEnum("diamondsGray")]
  DiamondsGray,
  
  /// <summary>
  /// Double D Art Border.
  /// </summary>
  [XmlEnum("doubleD")]
  DoubleD,
  
  /// <summary>
  /// Diamond Art Border.
  /// </summary>
  [XmlEnum("doubleDiamonds")]
  DoubleDiamonds,
  
  /// <summary>
  /// Earth Art Border.
  /// </summary>
  [XmlEnum("earth1")]
  Earth1,
  
  /// <summary>
  /// Earth Art Border.
  /// </summary>
  [XmlEnum("earth2")]
  Earth2,
  
  /// <summary>
  /// Shadowed Square Art Border.
  /// </summary>
  [XmlEnum("eclipsingSquares1")]
  EclipsingSquares1,
  
  /// <summary>
  /// Shadowed Square Art Border.
  /// </summary>
  [XmlEnum("eclipsingSquares2")]
  EclipsingSquares2,
  
  /// <summary>
  /// Painted Egg Art Border.
  /// </summary>
  [XmlEnum("eggsBlack")]
  EggsBlack,
  
  /// <summary>
  /// Fans Art Border.
  /// </summary>
  [XmlEnum("fans")]
  Fans,
  
  /// <summary>
  /// Film Reel Art Border.
  /// </summary>
  [XmlEnum("film")]
  Film,
  
  /// <summary>
  /// Firecracker Art Border.
  /// </summary>
  [XmlEnum("firecrackers")]
  Firecrackers,
  
  /// <summary>
  /// Flowers Art Border.
  /// </summary>
  [XmlEnum("flowersBlockPrint")]
  FlowersBlockPrint,
  
  /// <summary>
  /// Daisy Art Border.
  /// </summary>
  [XmlEnum("flowersDaisies")]
  FlowersDaisies,
  
  /// <summary>
  /// Flowers Art Border.
  /// </summary>
  [XmlEnum("flowersModern1")]
  FlowersModern1,
  
  /// <summary>
  /// Flowers Art Border.
  /// </summary>
  [XmlEnum("flowersModern2")]
  FlowersModern2,
  
  /// <summary>
  /// Pansy Art Border.
  /// </summary>
  [XmlEnum("flowersPansy")]
  FlowersPansy,
  
  /// <summary>
  /// Red Rose Art Border.
  /// </summary>
  [XmlEnum("flowersRedRose")]
  FlowersRedRose,
  
  /// <summary>
  /// Roses Art Border.
  /// </summary>
  [XmlEnum("flowersRoses")]
  FlowersRoses,
  
  /// <summary>
  /// Flowers in a Teacup Art Border.
  /// </summary>
  [XmlEnum("flowersTeacup")]
  FlowersTeacup,
  
  /// <summary>
  /// Small Flower Art Border.
  /// </summary>
  [XmlEnum("flowersTiny")]
  FlowersTiny,
  
  /// <summary>
  /// Gems Art Border.
  /// </summary>
  [XmlEnum("gems")]
  Gems,
  
  /// <summary>
  /// Gingerbread Man Art Border.
  /// </summary>
  [XmlEnum("gingerbreadMan")]
  GingerbreadMan,
  
  /// <summary>
  /// Triangle Gradient Art Border.
  /// </summary>
  [XmlEnum("gradient")]
  Gradient,
  
  /// <summary>
  /// Handmade Art Border.
  /// </summary>
  [XmlEnum("handmade1")]
  Handmade1,
  
  /// <summary>
  /// Handmade Art Border.
  /// </summary>
  [XmlEnum("handmade2")]
  Handmade2,
  
  /// <summary>
  /// Heart-Shaped Balloon Art Border.
  /// </summary>
  [XmlEnum("heartBalloon")]
  HeartBalloon,
  
  /// <summary>
  /// Gray Heart Art Border.
  /// </summary>
  [XmlEnum("heartGray")]
  HeartGray,
  
  /// <summary>
  /// Hearts Art Border.
  /// </summary>
  [XmlEnum("hearts")]
  Hearts,
  
  /// <summary>
  /// Pattern Art Border.
  /// </summary>
  [XmlEnum("heebieJeebies")]
  HeebieJeebies,
  
  /// <summary>
  /// Holly Art Border.
  /// </summary>
  [XmlEnum("holly")]
  Holly,
  
  /// <summary>
  /// House Art Border.
  /// </summary>
  [XmlEnum("houseFunky")]
  HouseFunky,
  
  /// <summary>
  /// Circular Art Border.
  /// </summary>
  [XmlEnum("hypnotic")]
  Hypnotic,
  
  /// <summary>
  /// Ice Cream Cone Art Border.
  /// </summary>
  [XmlEnum("iceCreamCones")]
  IceCreamCones,
  
  /// <summary>
  /// Light Bulb Art Border.
  /// </summary>
  [XmlEnum("lightBulb")]
  LightBulb,
  
  /// <summary>
  /// Lightning Art Border.
  /// </summary>
  [XmlEnum("lightning1")]
  Lightning1,
  
  /// <summary>
  /// Lightning Art Border.
  /// </summary>
  [XmlEnum("lightning2")]
  Lightning2,
  
  /// <summary>
  /// Map Pins Art Border.
  /// </summary>
  [XmlEnum("mapPins")]
  MapPins,
  
  /// <summary>
  /// Maple Leaf Art Border.
  /// </summary>
  [XmlEnum("mapleLeaf")]
  MapleLeaf,
  
  /// <summary>
  /// Muffin Art Border.
  /// </summary>
  [XmlEnum("mapleMuffins")]
  MapleMuffins,
  
  /// <summary>
  /// Marquee Art Border.
  /// </summary>
  [XmlEnum("marquee")]
  Marquee,
  
  /// <summary>
  /// Marquee Art Border.
  /// </summary>
  [XmlEnum("marqueeToothed")]
  MarqueeToothed,
  
  /// <summary>
  /// Moon Art Border.
  /// </summary>
  [XmlEnum("moons")]
  Moons,
  
  /// <summary>
  /// Mosaic Art Border.
  /// </summary>
  [XmlEnum("mosaic")]
  Mosaic,
  
  /// <summary>
  /// Musical Note Art Border.
  /// </summary>
  [XmlEnum("musicNotes")]
  MusicNotes,
  
  /// <summary>
  /// Patterned Art Border.
  /// </summary>
  [XmlEnum("northwest")]
  Northwest,
  
  /// <summary>
  /// Oval Art Border.
  /// </summary>
  [XmlEnum("ovals")]
  Ovals,
  
  /// <summary>
  /// Package Art Border.
  /// </summary>
  [XmlEnum("packages")]
  Packages,
  
  /// <summary>
  /// Black Palm Tree Art Border.
  /// </summary>
  [XmlEnum("palmsBlack")]
  PalmsBlack,
  
  /// <summary>
  /// Color Palm Tree Art Border.
  /// </summary>
  [XmlEnum("palmsColor")]
  PalmsColor,
  
  /// <summary>
  /// Paper Clip Art Border.
  /// </summary>
  [XmlEnum("paperClips")]
  PaperClips,
  
  /// <summary>
  /// Papyrus Art Border.
  /// </summary>
  [XmlEnum("papyrus")]
  Papyrus,
  
  /// <summary>
  /// Party Favor Art Border.
  /// </summary>
  [XmlEnum("partyFavor")]
  PartyFavor,
  
  /// <summary>
  /// Party Glass Art Border.
  /// </summary>
  [XmlEnum("partyGlass")]
  PartyGlass,
  
  /// <summary>
  /// Pencils Art Border.
  /// </summary>
  [XmlEnum("pencils")]
  Pencils,
  
  /// <summary>
  /// Character Art Border.
  /// </summary>
  [XmlEnum("people")]
  People,
  
  /// <summary>
  /// Waving Character Border.
  /// </summary>
  [XmlEnum("peopleWaving")]
  PeopleWaving,
  
  /// <summary>
  /// Character With Hat Art Border.
  /// </summary>
  [XmlEnum("peopleHats")]
  PeopleHats,
  
  /// <summary>
  /// Poinsettia Art Border.
  /// </summary>
  [XmlEnum("poinsettias")]
  Poinsettias,
  
  /// <summary>
  /// Postage Stamp Art Border.
  /// </summary>
  [XmlEnum("postageStamp")]
  PostageStamp,
  
  /// <summary>
  /// Pumpkin Art Border.
  /// </summary>
  [XmlEnum("pumpkin1")]
  Pumpkin1,
  
  /// <summary>
  /// Push Pin Art Border.
  /// </summary>
  [XmlEnum("pushPinNote2")]
  PushPinNote2,
  
  /// <summary>
  /// Push Pin Art Border.
  /// </summary>
  [XmlEnum("pushPinNote1")]
  PushPinNote1,
  
  /// <summary>
  /// Pyramid Art Border.
  /// </summary>
  [XmlEnum("pyramids")]
  Pyramids,
  
  /// <summary>
  /// Pyramid Art Border.
  /// </summary>
  [XmlEnum("pyramidsAbove")]
  PyramidsAbove,
  
  /// <summary>
  /// Quadrants Art Border.
  /// </summary>
  [XmlEnum("quadrants")]
  Quadrants,
  
  /// <summary>
  /// Rings Art Border.
  /// </summary>
  [XmlEnum("rings")]
  Rings,
  
  /// <summary>
  /// Safari Art Border.
  /// </summary>
  [XmlEnum("safari")]
  Safari,
  
  /// <summary>
  /// Saw tooth Art Border.
  /// </summary>
  [XmlEnum("sawtooth")]
  Sawtooth,
  
  /// <summary>
  /// Gray Saw tooth Art Border.
  /// </summary>
  [XmlEnum("sawtoothGray")]
  SawtoothGray,
  
  /// <summary>
  /// Scared Cat Art Border.
  /// </summary>
  [XmlEnum("scaredCat")]
  ScaredCat,
  
  /// <summary>
  /// Umbrella Art Border.
  /// </summary>
  [XmlEnum("seattle")]
  Seattle,
  
  /// <summary>
  /// Shadowed Squares Art Border.
  /// </summary>
  [XmlEnum("shadowedSquares")]
  ShadowedSquares,
  
  /// <summary>
  /// Shark Tooth Art Border.
  /// </summary>
  [XmlEnum("sharksTeeth")]
  SharksTeeth,
  
  /// <summary>
  /// Bird Tracks Art Border.
  /// </summary>
  [XmlEnum("shorebirdTracks")]
  ShorebirdTracks,
  
  /// <summary>
  /// Rocket Art Border.
  /// </summary>
  [XmlEnum("skyrocket")]
  Skyrocket,
  
  /// <summary>
  /// Snowflake Art Border.
  /// </summary>
  [XmlEnum("snowflakeFancy")]
  SnowflakeFancy,
  
  /// <summary>
  /// Snowflake Art Border.
  /// </summary>
  [XmlEnum("snowflakes")]
  Snowflakes,
  
  /// <summary>
  /// Sombrero Art Border.
  /// </summary>
  [XmlEnum("sombrero")]
  Sombrero,
  
  /// <summary>
  /// Southwest-themed Art Border.
  /// </summary>
  [XmlEnum("southwest")]
  Southwest,
  
  /// <summary>
  /// Stars Art Border.
  /// </summary>
  [XmlEnum("stars")]
  Stars,
  
  /// <summary>
  /// Stars On Top Art Border.
  /// </summary>
  [XmlEnum("starsTop")]
  StarsTop,
  
  /// <summary>
  /// 3-D Stars Art Border.
  /// </summary>
  [XmlEnum("stars3d")]
  Stars3d,
  
  /// <summary>
  /// Stars Art Border.
  /// </summary>
  [XmlEnum("starsBlack")]
  StarsBlack,
  
  /// <summary>
  /// Stars With Shadows Art Border.
  /// </summary>
  [XmlEnum("starsShadowed")]
  StarsShadowed,
  
  /// <summary>
  /// Sun Art Border.
  /// </summary>
  [XmlEnum("sun")]
  Sun,
  
  /// <summary>
  /// Whirligig Art Border.
  /// </summary>
  [XmlEnum("swirligig")]
  Swirligig,
  
  /// <summary>
  /// Torn Paper Art Border.
  /// </summary>
  [XmlEnum("tornPaper")]
  TornPaper,
  
  /// <summary>
  /// Black Torn Paper Art Border.
  /// </summary>
  [XmlEnum("tornPaperBlack")]
  TornPaperBlack,
  
  /// <summary>
  /// Tree Art Border.
  /// </summary>
  [XmlEnum("trees")]
  Trees,
  
  /// <summary>
  /// Triangle Art Border.
  /// </summary>
  [XmlEnum("triangleParty")]
  TriangleParty,
  
  /// <summary>
  /// Triangles Art Border.
  /// </summary>
  [XmlEnum("triangles")]
  Triangles,
  
  /// <summary>
  /// Tribal Art Border One.
  /// </summary>
  [XmlEnum("tribal1")]
  Tribal1,
  
  /// <summary>
  /// Tribal Art Border Two.
  /// </summary>
  [XmlEnum("tribal2")]
  Tribal2,
  
  /// <summary>
  /// Tribal Art Border Three.
  /// </summary>
  [XmlEnum("tribal3")]
  Tribal3,
  
  /// <summary>
  /// Tribal Art Border Four.
  /// </summary>
  [XmlEnum("tribal4")]
  Tribal4,
  
  /// <summary>
  /// Tribal Art Border Five.
  /// </summary>
  [XmlEnum("tribal5")]
  Tribal5,
  
  /// <summary>
  /// Tribal Art Border Six.
  /// </summary>
  [XmlEnum("tribal6")]
  Tribal6,
  
  /// <summary>
  /// triangle1.
  /// </summary>
  [XmlEnum("triangle1")]
  Triangle1,
  
  /// <summary>
  /// triangle2.
  /// </summary>
  [XmlEnum("triangle2")]
  Triangle2,
  
  /// <summary>
  /// triangleCircle1.
  /// </summary>
  [XmlEnum("triangleCircle1")]
  TriangleCircle1,
  
  /// <summary>
  /// triangleCircle2.
  /// </summary>
  [XmlEnum("triangleCircle2")]
  TriangleCircle2,
  
  /// <summary>
  /// shapes1.
  /// </summary>
  [XmlEnum("shapes1")]
  Shapes1,
  
  /// <summary>
  /// shapes2.
  /// </summary>
  [XmlEnum("shapes2")]
  Shapes2,
  
  /// <summary>
  /// Twisted Lines Art Border.
  /// </summary>
  [XmlEnum("twistedLines1")]
  TwistedLines1,
  
  /// <summary>
  /// Twisted Lines Art Border.
  /// </summary>
  [XmlEnum("twistedLines2")]
  TwistedLines2,
  
  /// <summary>
  /// Vine Art Border.
  /// </summary>
  [XmlEnum("vine")]
  Vine,
  
  /// <summary>
  /// Wavy Line Art Border.
  /// </summary>
  [XmlEnum("waveline")]
  Waveline,
  
  /// <summary>
  /// Weaving Angles Art Border.
  /// </summary>
  [XmlEnum("weavingAngles")]
  WeavingAngles,
  
  /// <summary>
  /// Weaving Braid Art Border.
  /// </summary>
  [XmlEnum("weavingBraid")]
  WeavingBraid,
  
  /// <summary>
  /// Weaving Ribbon Art Border.
  /// </summary>
  [XmlEnum("weavingRibbon")]
  WeavingRibbon,
  
  /// <summary>
  /// Weaving Strips Art Border.
  /// </summary>
  [XmlEnum("weavingStrips")]
  WeavingStrips,
  
  /// <summary>
  /// White Flowers Art Border.
  /// </summary>
  [XmlEnum("whiteFlowers")]
  WhiteFlowers,
  
  /// <summary>
  /// Woodwork Art Border.
  /// </summary>
  [XmlEnum("woodwork")]
  Woodwork,
  
  /// <summary>
  /// Crisscross Art Border.
  /// </summary>
  [XmlEnum("xIllusions")]
  XIllusions,
  
  /// <summary>
  /// Triangle Art Border.
  /// </summary>
  [XmlEnum("zanyTriangles")]
  ZanyTriangles,
  
  /// <summary>
  /// Zigzag Art Border.
  /// </summary>
  [XmlEnum("zigZag")]
  ZigZag,
  
  /// <summary>
  /// Zigzag stitch.
  /// </summary>
  [XmlEnum("zigZagStitch")]
  ZigZagStitch,
  
}
