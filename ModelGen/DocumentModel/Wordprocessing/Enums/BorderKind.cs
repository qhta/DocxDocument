namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the BorderValues enumeration.
/// </summary>
public enum BorderKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;nil&quot;.
  /// </summary>
  [EnumString("nil")]
  Nil,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;single&quot;.
  /// </summary>
  [EnumString("single")]
  Single,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thick&quot;.
  /// </summary>
  [EnumString("thick")]
  Thick,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;double&quot;.
  /// </summary>
  [EnumString("double")]
  Double,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dotted&quot;.
  /// </summary>
  [EnumString("dotted")]
  Dotted,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dashed&quot;.
  /// </summary>
  [EnumString("dashed")]
  Dashed,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dotDash&quot;.
  /// </summary>
  [EnumString("dotDash")]
  DotDash,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dotDotDash&quot;.
  /// </summary>
  [EnumString("dotDotDash")]
  DotDotDash,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;triple&quot;.
  /// </summary>
  [EnumString("triple")]
  Triple,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thinThickSmallGap&quot;.
  /// </summary>
  [EnumString("thinThickSmallGap")]
  ThinThickSmallGap,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thickThinSmallGap&quot;.
  /// </summary>
  [EnumString("thickThinSmallGap")]
  ThickThinSmallGap,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thinThickThinSmallGap&quot;.
  /// </summary>
  [EnumString("thinThickThinSmallGap")]
  ThinThickThinSmallGap,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thinThickMediumGap&quot;.
  /// </summary>
  [EnumString("thinThickMediumGap")]
  ThinThickMediumGap,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thickThinMediumGap&quot;.
  /// </summary>
  [EnumString("thickThinMediumGap")]
  ThickThinMediumGap,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thinThickThinMediumGap&quot;.
  /// </summary>
  [EnumString("thinThickThinMediumGap")]
  ThinThickThinMediumGap,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thinThickLargeGap&quot;.
  /// </summary>
  [EnumString("thinThickLargeGap")]
  ThinThickLargeGap,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thickThinLargeGap&quot;.
  /// </summary>
  [EnumString("thickThinLargeGap")]
  ThickThinLargeGap,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thinThickThinLargeGap&quot;.
  /// </summary>
  [EnumString("thinThickThinLargeGap")]
  ThinThickThinLargeGap,
  
  
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
  ///   When the item is serialized out as xml, its value is &quot;dashSmallGap&quot;.
  /// </summary>
  [EnumString("dashSmallGap")]
  DashSmallGap,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dashDotStroked&quot;.
  /// </summary>
  [EnumString("dashDotStroked")]
  DashDotStroked,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;threeDEmboss&quot;.
  /// </summary>
  [EnumString("threeDEmboss")]
  ThreeDEmboss,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;threeDEngrave&quot;.
  /// </summary>
  [EnumString("threeDEngrave")]
  ThreeDEngrave,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;outset&quot;.
  /// </summary>
  [EnumString("outset")]
  Outset,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;inset&quot;.
  /// </summary>
  [EnumString("inset")]
  Inset,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;apples&quot;.
  /// </summary>
  [EnumString("apples")]
  Apples,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;archedScallops&quot;.
  /// </summary>
  [EnumString("archedScallops")]
  ArchedScallops,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;babyPacifier&quot;.
  /// </summary>
  [EnumString("babyPacifier")]
  BabyPacifier,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;babyRattle&quot;.
  /// </summary>
  [EnumString("babyRattle")]
  BabyRattle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;balloons3Colors&quot;.
  /// </summary>
  [EnumString("balloons3Colors")]
  Balloons3Colors,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;balloonsHotAir&quot;.
  /// </summary>
  [EnumString("balloonsHotAir")]
  BalloonsHotAir,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;basicBlackDashes&quot;.
  /// </summary>
  [EnumString("basicBlackDashes")]
  BasicBlackDashes,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;basicBlackDots&quot;.
  /// </summary>
  [EnumString("basicBlackDots")]
  BasicBlackDots,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;basicBlackSquares&quot;.
  /// </summary>
  [EnumString("basicBlackSquares")]
  BasicBlackSquares,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;basicThinLines&quot;.
  /// </summary>
  [EnumString("basicThinLines")]
  BasicThinLines,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;basicWhiteDashes&quot;.
  /// </summary>
  [EnumString("basicWhiteDashes")]
  BasicWhiteDashes,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;basicWhiteDots&quot;.
  /// </summary>
  [EnumString("basicWhiteDots")]
  BasicWhiteDots,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;basicWhiteSquares&quot;.
  /// </summary>
  [EnumString("basicWhiteSquares")]
  BasicWhiteSquares,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;basicWideInline&quot;.
  /// </summary>
  [EnumString("basicWideInline")]
  BasicWideInline,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;basicWideMidline&quot;.
  /// </summary>
  [EnumString("basicWideMidline")]
  BasicWideMidline,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;basicWideOutline&quot;.
  /// </summary>
  [EnumString("basicWideOutline")]
  BasicWideOutline,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bats&quot;.
  /// </summary>
  [EnumString("bats")]
  Bats,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;birds&quot;.
  /// </summary>
  [EnumString("birds")]
  Birds,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;birdsFlight&quot;.
  /// </summary>
  [EnumString("birdsFlight")]
  BirdsFlight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cabins&quot;.
  /// </summary>
  [EnumString("cabins")]
  Cabins,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cakeSlice&quot;.
  /// </summary>
  [EnumString("cakeSlice")]
  CakeSlice,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;candyCorn&quot;.
  /// </summary>
  [EnumString("candyCorn")]
  CandyCorn,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;celticKnotwork&quot;.
  /// </summary>
  [EnumString("celticKnotwork")]
  CelticKnotwork,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;certificateBanner&quot;.
  /// </summary>
  [EnumString("certificateBanner")]
  CertificateBanner,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;chainLink&quot;.
  /// </summary>
  [EnumString("chainLink")]
  ChainLink,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;champagneBottle&quot;.
  /// </summary>
  [EnumString("champagneBottle")]
  ChampagneBottle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;checkedBarBlack&quot;.
  /// </summary>
  [EnumString("checkedBarBlack")]
  CheckedBarBlack,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;checkedBarColor&quot;.
  /// </summary>
  [EnumString("checkedBarColor")]
  CheckedBarColor,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;checkered&quot;.
  /// </summary>
  [EnumString("checkered")]
  Checkered,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;christmasTree&quot;.
  /// </summary>
  [EnumString("christmasTree")]
  ChristmasTree,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;circlesLines&quot;.
  /// </summary>
  [EnumString("circlesLines")]
  CirclesLines,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;circlesRectangles&quot;.
  /// </summary>
  [EnumString("circlesRectangles")]
  CirclesRectangles,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;classicalWave&quot;.
  /// </summary>
  [EnumString("classicalWave")]
  ClassicalWave,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;clocks&quot;.
  /// </summary>
  [EnumString("clocks")]
  Clocks,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;compass&quot;.
  /// </summary>
  [EnumString("compass")]
  Compass,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;confetti&quot;.
  /// </summary>
  [EnumString("confetti")]
  Confetti,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;confettiGrays&quot;.
  /// </summary>
  [EnumString("confettiGrays")]
  ConfettiGrays,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;confettiOutline&quot;.
  /// </summary>
  [EnumString("confettiOutline")]
  ConfettiOutline,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;confettiStreamers&quot;.
  /// </summary>
  [EnumString("confettiStreamers")]
  ConfettiStreamers,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;confettiWhite&quot;.
  /// </summary>
  [EnumString("confettiWhite")]
  ConfettiWhite,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cornerTriangles&quot;.
  /// </summary>
  [EnumString("cornerTriangles")]
  CornerTriangles,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;couponCutoutDashes&quot;.
  /// </summary>
  [EnumString("couponCutoutDashes")]
  CouponCutoutDashes,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;couponCutoutDots&quot;.
  /// </summary>
  [EnumString("couponCutoutDots")]
  CouponCutoutDots,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;crazyMaze&quot;.
  /// </summary>
  [EnumString("crazyMaze")]
  CrazyMaze,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;creaturesButterfly&quot;.
  /// </summary>
  [EnumString("creaturesButterfly")]
  CreaturesButterfly,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;creaturesFish&quot;.
  /// </summary>
  [EnumString("creaturesFish")]
  CreaturesFish,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;creaturesInsects&quot;.
  /// </summary>
  [EnumString("creaturesInsects")]
  CreaturesInsects,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;creaturesLadyBug&quot;.
  /// </summary>
  [EnumString("creaturesLadyBug")]
  CreaturesLadyBug,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;crossStitch&quot;.
  /// </summary>
  [EnumString("crossStitch")]
  CrossStitch,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cup&quot;.
  /// </summary>
  [EnumString("cup")]
  Cup,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;decoArch&quot;.
  /// </summary>
  [EnumString("decoArch")]
  DecoArch,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;decoArchColor&quot;.
  /// </summary>
  [EnumString("decoArchColor")]
  DecoArchColor,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;decoBlocks&quot;.
  /// </summary>
  [EnumString("decoBlocks")]
  DecoBlocks,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;diamondsGray&quot;.
  /// </summary>
  [EnumString("diamondsGray")]
  DiamondsGray,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;doubleD&quot;.
  /// </summary>
  [EnumString("doubleD")]
  DoubleD,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;doubleDiamonds&quot;.
  /// </summary>
  [EnumString("doubleDiamonds")]
  DoubleDiamonds,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;earth1&quot;.
  /// </summary>
  [EnumString("earth1")]
  Earth1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;earth2&quot;.
  /// </summary>
  [EnumString("earth2")]
  Earth2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;eclipsingSquares1&quot;.
  /// </summary>
  [EnumString("eclipsingSquares1")]
  EclipsingSquares1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;eclipsingSquares2&quot;.
  /// </summary>
  [EnumString("eclipsingSquares2")]
  EclipsingSquares2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;eggsBlack&quot;.
  /// </summary>
  [EnumString("eggsBlack")]
  EggsBlack,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;fans&quot;.
  /// </summary>
  [EnumString("fans")]
  Fans,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;film&quot;.
  /// </summary>
  [EnumString("film")]
  Film,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;firecrackers&quot;.
  /// </summary>
  [EnumString("firecrackers")]
  Firecrackers,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowersBlockPrint&quot;.
  /// </summary>
  [EnumString("flowersBlockPrint")]
  FlowersBlockPrint,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowersDaisies&quot;.
  /// </summary>
  [EnumString("flowersDaisies")]
  FlowersDaisies,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowersModern1&quot;.
  /// </summary>
  [EnumString("flowersModern1")]
  FlowersModern1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowersModern2&quot;.
  /// </summary>
  [EnumString("flowersModern2")]
  FlowersModern2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowersPansy&quot;.
  /// </summary>
  [EnumString("flowersPansy")]
  FlowersPansy,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowersRedRose&quot;.
  /// </summary>
  [EnumString("flowersRedRose")]
  FlowersRedRose,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowersRoses&quot;.
  /// </summary>
  [EnumString("flowersRoses")]
  FlowersRoses,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowersTeacup&quot;.
  /// </summary>
  [EnumString("flowersTeacup")]
  FlowersTeacup,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;flowersTiny&quot;.
  /// </summary>
  [EnumString("flowersTiny")]
  FlowersTiny,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gems&quot;.
  /// </summary>
  [EnumString("gems")]
  Gems,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gingerbreadMan&quot;.
  /// </summary>
  [EnumString("gingerbreadMan")]
  GingerbreadMan,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gradient&quot;.
  /// </summary>
  [EnumString("gradient")]
  Gradient,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;handmade1&quot;.
  /// </summary>
  [EnumString("handmade1")]
  Handmade1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;handmade2&quot;.
  /// </summary>
  [EnumString("handmade2")]
  Handmade2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;heartBalloon&quot;.
  /// </summary>
  [EnumString("heartBalloon")]
  HeartBalloon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;heartGray&quot;.
  /// </summary>
  [EnumString("heartGray")]
  HeartGray,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hearts&quot;.
  /// </summary>
  [EnumString("hearts")]
  Hearts,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;heebieJeebies&quot;.
  /// </summary>
  [EnumString("heebieJeebies")]
  HeebieJeebies,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;holly&quot;.
  /// </summary>
  [EnumString("holly")]
  Holly,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;houseFunky&quot;.
  /// </summary>
  [EnumString("houseFunky")]
  HouseFunky,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hypnotic&quot;.
  /// </summary>
  [EnumString("hypnotic")]
  Hypnotic,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;iceCreamCones&quot;.
  /// </summary>
  [EnumString("iceCreamCones")]
  IceCreamCones,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lightBulb&quot;.
  /// </summary>
  [EnumString("lightBulb")]
  LightBulb,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lightning1&quot;.
  /// </summary>
  [EnumString("lightning1")]
  Lightning1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lightning2&quot;.
  /// </summary>
  [EnumString("lightning2")]
  Lightning2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mapPins&quot;.
  /// </summary>
  [EnumString("mapPins")]
  MapPins,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mapleLeaf&quot;.
  /// </summary>
  [EnumString("mapleLeaf")]
  MapleLeaf,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mapleMuffins&quot;.
  /// </summary>
  [EnumString("mapleMuffins")]
  MapleMuffins,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;marquee&quot;.
  /// </summary>
  [EnumString("marquee")]
  Marquee,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;marqueeToothed&quot;.
  /// </summary>
  [EnumString("marqueeToothed")]
  MarqueeToothed,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;moons&quot;.
  /// </summary>
  [EnumString("moons")]
  Moons,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mosaic&quot;.
  /// </summary>
  [EnumString("mosaic")]
  Mosaic,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;musicNotes&quot;.
  /// </summary>
  [EnumString("musicNotes")]
  MusicNotes,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;northwest&quot;.
  /// </summary>
  [EnumString("northwest")]
  Northwest,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ovals&quot;.
  /// </summary>
  [EnumString("ovals")]
  Ovals,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;packages&quot;.
  /// </summary>
  [EnumString("packages")]
  Packages,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;palmsBlack&quot;.
  /// </summary>
  [EnumString("palmsBlack")]
  PalmsBlack,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;palmsColor&quot;.
  /// </summary>
  [EnumString("palmsColor")]
  PalmsColor,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;paperClips&quot;.
  /// </summary>
  [EnumString("paperClips")]
  PaperClips,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;papyrus&quot;.
  /// </summary>
  [EnumString("papyrus")]
  Papyrus,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;partyFavor&quot;.
  /// </summary>
  [EnumString("partyFavor")]
  PartyFavor,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;partyGlass&quot;.
  /// </summary>
  [EnumString("partyGlass")]
  PartyGlass,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pencils&quot;.
  /// </summary>
  [EnumString("pencils")]
  Pencils,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;people&quot;.
  /// </summary>
  [EnumString("people")]
  People,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;peopleWaving&quot;.
  /// </summary>
  [EnumString("peopleWaving")]
  PeopleWaving,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;peopleHats&quot;.
  /// </summary>
  [EnumString("peopleHats")]
  PeopleHats,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;poinsettias&quot;.
  /// </summary>
  [EnumString("poinsettias")]
  Poinsettias,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;postageStamp&quot;.
  /// </summary>
  [EnumString("postageStamp")]
  PostageStamp,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pumpkin1&quot;.
  /// </summary>
  [EnumString("pumpkin1")]
  Pumpkin1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pushPinNote2&quot;.
  /// </summary>
  [EnumString("pushPinNote2")]
  PushPinNote2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pushPinNote1&quot;.
  /// </summary>
  [EnumString("pushPinNote1")]
  PushPinNote1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pyramids&quot;.
  /// </summary>
  [EnumString("pyramids")]
  Pyramids,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pyramidsAbove&quot;.
  /// </summary>
  [EnumString("pyramidsAbove")]
  PyramidsAbove,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;quadrants&quot;.
  /// </summary>
  [EnumString("quadrants")]
  Quadrants,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;rings&quot;.
  /// </summary>
  [EnumString("rings")]
  Rings,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;safari&quot;.
  /// </summary>
  [EnumString("safari")]
  Safari,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sawtooth&quot;.
  /// </summary>
  [EnumString("sawtooth")]
  Sawtooth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sawtoothGray&quot;.
  /// </summary>
  [EnumString("sawtoothGray")]
  SawtoothGray,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;scaredCat&quot;.
  /// </summary>
  [EnumString("scaredCat")]
  ScaredCat,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;seattle&quot;.
  /// </summary>
  [EnumString("seattle")]
  Seattle,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;shadowedSquares&quot;.
  /// </summary>
  [EnumString("shadowedSquares")]
  ShadowedSquares,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sharksTeeth&quot;.
  /// </summary>
  [EnumString("sharksTeeth")]
  SharksTeeth,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;shorebirdTracks&quot;.
  /// </summary>
  [EnumString("shorebirdTracks")]
  ShorebirdTracks,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;skyrocket&quot;.
  /// </summary>
  [EnumString("skyrocket")]
  Skyrocket,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;snowflakeFancy&quot;.
  /// </summary>
  [EnumString("snowflakeFancy")]
  SnowflakeFancy,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;snowflakes&quot;.
  /// </summary>
  [EnumString("snowflakes")]
  Snowflakes,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sombrero&quot;.
  /// </summary>
  [EnumString("sombrero")]
  Sombrero,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;southwest&quot;.
  /// </summary>
  [EnumString("southwest")]
  Southwest,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;stars&quot;.
  /// </summary>
  [EnumString("stars")]
  Stars,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;starsTop&quot;.
  /// </summary>
  [EnumString("starsTop")]
  StarsTop,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;stars3d&quot;.
  /// </summary>
  [EnumString("stars3d")]
  Stars3d,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;starsBlack&quot;.
  /// </summary>
  [EnumString("starsBlack")]
  StarsBlack,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;starsShadowed&quot;.
  /// </summary>
  [EnumString("starsShadowed")]
  StarsShadowed,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sun&quot;.
  /// </summary>
  [EnumString("sun")]
  Sun,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;swirligig&quot;.
  /// </summary>
  [EnumString("swirligig")]
  Swirligig,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tornPaper&quot;.
  /// </summary>
  [EnumString("tornPaper")]
  TornPaper,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tornPaperBlack&quot;.
  /// </summary>
  [EnumString("tornPaperBlack")]
  TornPaperBlack,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;trees&quot;.
  /// </summary>
  [EnumString("trees")]
  Trees,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;triangleParty&quot;.
  /// </summary>
  [EnumString("triangleParty")]
  TriangleParty,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;triangles&quot;.
  /// </summary>
  [EnumString("triangles")]
  Triangles,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tribal1&quot;.
  /// </summary>
  [EnumString("tribal1")]
  Tribal1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tribal2&quot;.
  /// </summary>
  [EnumString("tribal2")]
  Tribal2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tribal3&quot;.
  /// </summary>
  [EnumString("tribal3")]
  Tribal3,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tribal4&quot;.
  /// </summary>
  [EnumString("tribal4")]
  Tribal4,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tribal5&quot;.
  /// </summary>
  [EnumString("tribal5")]
  Tribal5,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tribal6&quot;.
  /// </summary>
  [EnumString("tribal6")]
  Tribal6,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;triangle1&quot;.
  /// </summary>
  [EnumString("triangle1")]
  Triangle1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;triangle2&quot;.
  /// </summary>
  [EnumString("triangle2")]
  Triangle2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;triangleCircle1&quot;.
  /// </summary>
  [EnumString("triangleCircle1")]
  TriangleCircle1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;triangleCircle2&quot;.
  /// </summary>
  [EnumString("triangleCircle2")]
  TriangleCircle2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;shapes1&quot;.
  /// </summary>
  [EnumString("shapes1")]
  Shapes1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;shapes2&quot;.
  /// </summary>
  [EnumString("shapes2")]
  Shapes2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;twistedLines1&quot;.
  /// </summary>
  [EnumString("twistedLines1")]
  TwistedLines1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;twistedLines2&quot;.
  /// </summary>
  [EnumString("twistedLines2")]
  TwistedLines2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;vine&quot;.
  /// </summary>
  [EnumString("vine")]
  Vine,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;waveline&quot;.
  /// </summary>
  [EnumString("waveline")]
  Waveline,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;weavingAngles&quot;.
  /// </summary>
  [EnumString("weavingAngles")]
  WeavingAngles,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;weavingBraid&quot;.
  /// </summary>
  [EnumString("weavingBraid")]
  WeavingBraid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;weavingRibbon&quot;.
  /// </summary>
  [EnumString("weavingRibbon")]
  WeavingRibbon,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;weavingStrips&quot;.
  /// </summary>
  [EnumString("weavingStrips")]
  WeavingStrips,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;whiteFlowers&quot;.
  /// </summary>
  [EnumString("whiteFlowers")]
  WhiteFlowers,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;woodwork&quot;.
  /// </summary>
  [EnumString("woodwork")]
  Woodwork,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;xIllusions&quot;.
  /// </summary>
  [EnumString("xIllusions")]
  XIllusions,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;zanyTriangles&quot;.
  /// </summary>
  [EnumString("zanyTriangles")]
  ZanyTriangles,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;zigZag&quot;.
  /// </summary>
  [EnumString("zigZag")]
  ZigZag,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;zigZagStitch&quot;.
  /// </summary>
  [EnumString("zigZagStitch")]
  ZigZagStitch,
  
}
