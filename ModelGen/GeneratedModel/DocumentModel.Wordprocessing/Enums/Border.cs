namespace DocumentModel.Wordprocessing;

public enum Border
{

  [XmlEnum("nil")]
  Nil,

  [XmlEnum("none")]
  None,

  [XmlEnum("single")]
  Single,

  [XmlEnum("thick")]
  Thick,

  [XmlEnum("double")]
  Double,

  [XmlEnum("dotted")]
  Dotted,

  [XmlEnum("dashed")]
  Dashed,

  [XmlEnum("dotDash")]
  DotDash,

  [XmlEnum("dotDotDash")]
  DotDotDash,

  [XmlEnum("triple")]
  Triple,

  [XmlEnum("thinThickSmallGap")]
  ThinThickSmallGap,

  [XmlEnum("thickThinSmallGap")]
  ThickThinSmallGap,

  [XmlEnum("thinThickThinSmallGap")]
  ThinThickThinSmallGap,

  [XmlEnum("thinThickMediumGap")]
  ThinThickMediumGap,

  [XmlEnum("thickThinMediumGap")]
  ThickThinMediumGap,

  [XmlEnum("thinThickThinMediumGap")]
  ThinThickThinMediumGap,

  [XmlEnum("thinThickLargeGap")]
  ThinThickLargeGap,

  [XmlEnum("thickThinLargeGap")]
  ThickThinLargeGap,

  [XmlEnum("thinThickThinLargeGap")]
  ThinThickThinLargeGap,

  [XmlEnum("wave")]
  Wave,

  [XmlEnum("doubleWave")]
  DoubleWave,

  [XmlEnum("dashSmallGap")]
  DashSmallGap,

  [XmlEnum("dashDotStroked")]
  DashDotStroked,

  [XmlEnum("threeDEmboss")]
  ThreeDEmboss,

  [XmlEnum("threeDEngrave")]
  ThreeDEngrave,

  [XmlEnum("outset")]
  Outset,

  [XmlEnum("inset")]
  Inset,

  [XmlEnum("apples")]
  Apples,

  [XmlEnum("archedScallops")]
  ArchedScallops,

  [XmlEnum("babyPacifier")]
  BabyPacifier,

  [XmlEnum("babyRattle")]
  BabyRattle,

  [XmlEnum("balloons3Colors")]
  Balloons3Colors,

  [XmlEnum("balloonsHotAir")]
  BalloonsHotAir,

  [XmlEnum("basicBlackDashes")]
  BasicBlackDashes,

  [XmlEnum("basicBlackDots")]
  BasicBlackDots,

  [XmlEnum("basicBlackSquares")]
  BasicBlackSquares,

  [XmlEnum("basicThinLines")]
  BasicThinLines,

  [XmlEnum("basicWhiteDashes")]
  BasicWhiteDashes,

  [XmlEnum("basicWhiteDots")]
  BasicWhiteDots,

  [XmlEnum("basicWhiteSquares")]
  BasicWhiteSquares,

  [XmlEnum("basicWideInline")]
  BasicWideInline,

  [XmlEnum("basicWideMidline")]
  BasicWideMidline,

  [XmlEnum("basicWideOutline")]
  BasicWideOutline,

  [XmlEnum("bats")]
  Bats,

  [XmlEnum("birds")]
  Birds,

  [XmlEnum("birdsFlight")]
  BirdsFlight,

  [XmlEnum("cabins")]
  Cabins,

  [XmlEnum("cakeSlice")]
  CakeSlice,

  [XmlEnum("candyCorn")]
  CandyCorn,

  [XmlEnum("celticKnotwork")]
  CelticKnotwork,

  [XmlEnum("certificateBanner")]
  CertificateBanner,

  [XmlEnum("chainLink")]
  ChainLink,

  [XmlEnum("champagneBottle")]
  ChampagneBottle,

  [XmlEnum("checkedBarBlack")]
  CheckedBarBlack,

  [XmlEnum("checkedBarColor")]
  CheckedBarColor,

  [XmlEnum("checkered")]
  Checkered,

  [XmlEnum("christmasTree")]
  ChristmasTree,

  [XmlEnum("circlesLines")]
  CirclesLines,

  [XmlEnum("circlesRectangles")]
  CirclesRectangles,

  [XmlEnum("classicalWave")]
  ClassicalWave,

  [XmlEnum("clocks")]
  Clocks,

  [XmlEnum("compass")]
  Compass,

  [XmlEnum("confetti")]
  Confetti,

  [XmlEnum("confettiGrays")]
  ConfettiGrays,

  [XmlEnum("confettiOutline")]
  ConfettiOutline,

  [XmlEnum("confettiStreamers")]
  ConfettiStreamers,

  [XmlEnum("confettiWhite")]
  ConfettiWhite,

  [XmlEnum("cornerTriangles")]
  CornerTriangles,

  [XmlEnum("couponCutoutDashes")]
  CouponCutoutDashes,

  [XmlEnum("couponCutoutDots")]
  CouponCutoutDots,

  [XmlEnum("crazyMaze")]
  CrazyMaze,

  [XmlEnum("creaturesButterfly")]
  CreaturesButterfly,

  [XmlEnum("creaturesFish")]
  CreaturesFish,

  [XmlEnum("creaturesInsects")]
  CreaturesInsects,

  [XmlEnum("creaturesLadyBug")]
  CreaturesLadyBug,

  [XmlEnum("crossStitch")]
  CrossStitch,

  [XmlEnum("cup")]
  Cup,

  [XmlEnum("decoArch")]
  DecoArch,

  [XmlEnum("decoArchColor")]
  DecoArchColor,

  [XmlEnum("decoBlocks")]
  DecoBlocks,

  [XmlEnum("diamondsGray")]
  DiamondsGray,

  [XmlEnum("doubleD")]
  DoubleD,

  [XmlEnum("doubleDiamonds")]
  DoubleDiamonds,

  [XmlEnum("earth1")]
  Earth1,

  [XmlEnum("earth2")]
  Earth2,

  [XmlEnum("eclipsingSquares1")]
  EclipsingSquares1,

  [XmlEnum("eclipsingSquares2")]
  EclipsingSquares2,

  [XmlEnum("eggsBlack")]
  EggsBlack,

  [XmlEnum("fans")]
  Fans,

  [XmlEnum("film")]
  Film,

  [XmlEnum("firecrackers")]
  Firecrackers,

  [XmlEnum("flowersBlockPrint")]
  FlowersBlockPrint,

  [XmlEnum("flowersDaisies")]
  FlowersDaisies,

  [XmlEnum("flowersModern1")]
  FlowersModern1,

  [XmlEnum("flowersModern2")]
  FlowersModern2,

  [XmlEnum("flowersPansy")]
  FlowersPansy,

  [XmlEnum("flowersRedRose")]
  FlowersRedRose,

  [XmlEnum("flowersRoses")]
  FlowersRoses,

  [XmlEnum("flowersTeacup")]
  FlowersTeacup,

  [XmlEnum("flowersTiny")]
  FlowersTiny,

  [XmlEnum("gems")]
  Gems,

  [XmlEnum("gingerbreadMan")]
  GingerbreadMan,

  [XmlEnum("gradient")]
  Gradient,

  [XmlEnum("handmade1")]
  Handmade1,

  [XmlEnum("handmade2")]
  Handmade2,

  [XmlEnum("heartBalloon")]
  HeartBalloon,

  [XmlEnum("heartGray")]
  HeartGray,

  [XmlEnum("hearts")]
  Hearts,

  [XmlEnum("heebieJeebies")]
  HeebieJeebies,

  [XmlEnum("holly")]
  Holly,

  [XmlEnum("houseFunky")]
  HouseFunky,

  [XmlEnum("hypnotic")]
  Hypnotic,

  [XmlEnum("iceCreamCones")]
  IceCreamCones,

  [XmlEnum("lightBulb")]
  LightBulb,

  [XmlEnum("lightning1")]
  Lightning1,

  [XmlEnum("lightning2")]
  Lightning2,

  [XmlEnum("mapPins")]
  MapPins,

  [XmlEnum("mapleLeaf")]
  MapleLeaf,

  [XmlEnum("mapleMuffins")]
  MapleMuffins,

  [XmlEnum("marquee")]
  Marquee,

  [XmlEnum("marqueeToothed")]
  MarqueeToothed,

  [XmlEnum("moons")]
  Moons,

  [XmlEnum("mosaic")]
  Mosaic,

  [XmlEnum("musicNotes")]
  MusicNotes,

  [XmlEnum("northwest")]
  Northwest,

  [XmlEnum("ovals")]
  Ovals,

  [XmlEnum("packages")]
  Packages,

  [XmlEnum("palmsBlack")]
  PalmsBlack,

  [XmlEnum("palmsColor")]
  PalmsColor,

  [XmlEnum("paperClips")]
  PaperClips,

  [XmlEnum("papyrus")]
  Papyrus,

  [XmlEnum("partyFavor")]
  PartyFavor,

  [XmlEnum("partyGlass")]
  PartyGlass,

  [XmlEnum("pencils")]
  Pencils,

  [XmlEnum("people")]
  People,

  [XmlEnum("peopleWaving")]
  PeopleWaving,

  [XmlEnum("peopleHats")]
  PeopleHats,

  [XmlEnum("poinsettias")]
  Poinsettias,

  [XmlEnum("postageStamp")]
  PostageStamp,

  [XmlEnum("pumpkin1")]
  Pumpkin1,

  [XmlEnum("pushPinNote2")]
  PushPinNote2,

  [XmlEnum("pushPinNote1")]
  PushPinNote1,

  [XmlEnum("pyramids")]
  Pyramids,

  [XmlEnum("pyramidsAbove")]
  PyramidsAbove,

  [XmlEnum("quadrants")]
  Quadrants,

  [XmlEnum("rings")]
  Rings,

  [XmlEnum("safari")]
  Safari,

  [XmlEnum("sawtooth")]
  Sawtooth,

  [XmlEnum("sawtoothGray")]
  SawtoothGray,

  [XmlEnum("scaredCat")]
  ScaredCat,

  [XmlEnum("seattle")]
  Seattle,

  [XmlEnum("shadowedSquares")]
  ShadowedSquares,

  [XmlEnum("sharksTeeth")]
  SharksTeeth,

  [XmlEnum("shorebirdTracks")]
  ShorebirdTracks,

  [XmlEnum("skyrocket")]
  Skyrocket,

  [XmlEnum("snowflakeFancy")]
  SnowflakeFancy,

  [XmlEnum("snowflakes")]
  Snowflakes,

  [XmlEnum("sombrero")]
  Sombrero,

  [XmlEnum("southwest")]
  Southwest,

  [XmlEnum("stars")]
  Stars,

  [XmlEnum("starsTop")]
  StarsTop,

  [XmlEnum("stars3d")]
  Stars3d,

  [XmlEnum("starsBlack")]
  StarsBlack,

  [XmlEnum("starsShadowed")]
  StarsShadowed,

  [XmlEnum("sun")]
  Sun,

  [XmlEnum("swirligig")]
  Swirligig,

  [XmlEnum("tornPaper")]
  TornPaper,

  [XmlEnum("tornPaperBlack")]
  TornPaperBlack,

  [XmlEnum("trees")]
  Trees,

  [XmlEnum("triangleParty")]
  TriangleParty,

  [XmlEnum("triangles")]
  Triangles,

  [XmlEnum("tribal1")]
  Tribal1,

  [XmlEnum("tribal2")]
  Tribal2,

  [XmlEnum("tribal3")]
  Tribal3,

  [XmlEnum("tribal4")]
  Tribal4,

  [XmlEnum("tribal5")]
  Tribal5,

  [XmlEnum("tribal6")]
  Tribal6,

  [XmlEnum("triangle1")]
  Triangle1,

  [XmlEnum("triangle2")]
  Triangle2,

  [XmlEnum("triangleCircle1")]
  TriangleCircle1,

  [XmlEnum("triangleCircle2")]
  TriangleCircle2,

  [XmlEnum("shapes1")]
  Shapes1,

  [XmlEnum("shapes2")]
  Shapes2,

  [XmlEnum("twistedLines1")]
  TwistedLines1,

  [XmlEnum("twistedLines2")]
  TwistedLines2,

  [XmlEnum("vine")]
  Vine,

  [XmlEnum("waveline")]
  Waveline,

  [XmlEnum("weavingAngles")]
  WeavingAngles,

  [XmlEnum("weavingBraid")]
  WeavingBraid,

  [XmlEnum("weavingRibbon")]
  WeavingRibbon,

  [XmlEnum("weavingStrips")]
  WeavingStrips,

  [XmlEnum("whiteFlowers")]
  WhiteFlowers,

  [XmlEnum("woodwork")]
  Woodwork,

  [XmlEnum("xIllusions")]
  XIllusions,

  [XmlEnum("zanyTriangles")]
  ZanyTriangles,

  [XmlEnum("zigZag")]
  ZigZag,

  [XmlEnum("zigZagStitch")]
  ZigZagStitch,
}
