namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the graphical page border setting of a page.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpageborderart?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdPageBorderArt")]
public enum PageBorderArt
{
  /// <summary>
  /// An apple border.
  /// </summary>
  [WordInteropEnumValue("wdArtApples")]
  Apples = 1,
  /// <summary>
  /// A maple muffins border.
  /// </summary>
  [WordInteropEnumValue("wdArtMapleMuffins")]
  MapleMuffins = 2,
  /// <summary>
  /// A cake slice border.
  /// </summary>
  [WordInteropEnumValue("wdArtCakeSlice")]
  CakeSlice = 3,
  /// <summary>
  /// A candy corn border.
  /// </summary>
  [WordInteropEnumValue("wdArtCandyCorn")]
  CandyCorn = 4,
  /// <summary>
  /// An ice cream cones border.
  /// </summary>
  [WordInteropEnumValue("wdArtIceCreamCones")]
  IceCreamCones = 5,
  /// <summary>
  /// A champagne bottle border.
  /// </summary>
  [WordInteropEnumValue("wdArtChampagneBottle")]
  ChampagneBottle = 6,
  /// <summary>
  /// A party glass border.
  /// </summary>
  [WordInteropEnumValue("wdArtPartyGlass")]
  PartyGlass = 7,
  /// <summary>
  /// A Christmas tree border.
  /// </summary>
  [WordInteropEnumValue("wdArtChristmasTree")]
  ChristmasTree = 8,
  /// <summary>
  /// A trees border.
  /// </summary>
  [WordInteropEnumValue("wdArtTrees")]
  Trees = 9,
  /// <summary>
  /// A colored palms border.
  /// </summary>
  [WordInteropEnumValue("wdArtPalmsColor")]
  PalmsColor = 10,
  /// <summary>
  /// Balloons in three colors as the border.
  /// </summary>
  [WordInteropEnumValue("wdArtBalloons3Colors")]
  Balloons3Colors = 11,
  /// <summary>
  /// A hot air balloon border.
  /// </summary>
  [WordInteropEnumValue("wdArtBalloonsHotAir")]
  BalloonsHotAir = 12,
  /// <summary>
  /// A party favor border.
  /// </summary>
  [WordInteropEnumValue("wdArtPartyFavor")]
  PartyFavor = 13,
  /// <summary>
  /// A confetti streamers border.
  /// </summary>
  [WordInteropEnumValue("wdArtConfettiStreamers")]
  ConfettiStreamers = 14,
  /// <summary>
  /// A hearts border.
  /// </summary>
  [WordInteropEnumValue("wdArtHearts")]
  Hearts = 15,
  /// <summary>
  /// A heart balloon border.
  /// </summary>
  [WordInteropEnumValue("wdArtHeartBalloon")]
  HeartBalloon = 16,
  /// <summary>
  /// A 3-D stars border.
  /// </summary>
  [WordInteropEnumValue("wdArtStars3D")]
  Stars3D = 17,
  /// <summary>
  /// A shadowed stars border.
  /// </summary>
  [WordInteropEnumValue("wdArtStarsShadowed")]
  StarsShadowed = 18,
  /// <summary>
  /// A stars border.
  /// </summary>
  [WordInteropEnumValue("wdArtStars")]
  Stars = 19,
  /// <summary>
  /// A sun border.
  /// </summary>
  [WordInteropEnumValue("wdArtSun")]
  Sun = 20,
  /// <summary>
  /// An earth number 2 border.
  /// </summary>
  [WordInteropEnumValue("wdArtEarth2")]
  Earth2 = 21,
  /// <summary>
  /// An earth number 1 border.
  /// </summary>
  [WordInteropEnumValue("wdArtEarth1")]
  Earth1 = 22,
  /// <summary>
  /// A people wearing hats border.
  /// </summary>
  [WordInteropEnumValue("wdArtPeopleHats")]
  PeopleHats = 23,
  /// <summary>
  /// A sombrero border.
  /// </summary>
  [WordInteropEnumValue("wdArtSombrero")]
  Sombrero = 24,
  /// <summary>
  /// A pencils border.
  /// </summary>
  [WordInteropEnumValue("wdArtPencils")]
  Pencils = 25,
  /// <summary>
  /// A packages border.
  /// </summary>
  [WordInteropEnumValue("wdArtPackages")]
  Packages = 26,
  /// <summary>
  /// A clocks border.
  /// </summary>
  [WordInteropEnumValue("wdArtClocks")]
  Clocks = 27,
  /// <summary>
  /// A fire crackers border.
  /// </summary>
  [WordInteropEnumValue("wdArtFirecrackers")]
  Firecrackers = 28,
  /// <summary>
  /// A rings border.
  /// </summary>
  [WordInteropEnumValue("wdArtRings")]
  Rings = 29,
  /// <summary>
  /// A map pins border.
  /// </summary>
  [WordInteropEnumValue("wdArtMapPins")]
  MapPins = 30,
  /// <summary>
  /// A confetti border.
  /// </summary>
  [WordInteropEnumValue("wdArtConfetti")]
  Confetti = 31,
  /// <summary>
  /// A butterfly border.
  /// </summary>
  [WordInteropEnumValue("wdArtCreaturesButterfly")]
  CreaturesButterfly = 32,
  /// <summary>
  /// A ladybug border.
  /// </summary>
  [WordInteropEnumValue("wdArtCreaturesLadyBug")]
  CreaturesLadyBug = 33,
  /// <summary>
  /// A fish border.
  /// </summary>
  [WordInteropEnumValue("wdArtCreaturesFish")]
  CreaturesFish = 34,
  /// <summary>
  /// A birds in flight border.
  /// </summary>
  [WordInteropEnumValue("wdArtBirdsFlight")]
  BirdsFlight = 35,
  /// <summary>
  /// A scared cat border.
  /// </summary>
  [WordInteropEnumValue("wdArtScaredCat")]
  ScaredCat = 36,
  /// <summary>
  /// A bats border.
  /// </summary>
  [WordInteropEnumValue("wdArtBats")]
  Bats = 37,
  /// <summary>
  /// A rose border.
  /// </summary>
  [WordInteropEnumValue("wdArtFlowersRoses")]
  FlowersRoses = 38,
  /// <summary>
  /// A red rose border.
  /// </summary>
  [WordInteropEnumValue("wdArtFlowersRedRose")]
  FlowersRedRose = 39,
  /// <summary>
  /// A poinsettias border.
  /// </summary>
  [WordInteropEnumValue("wdArtPoinsettias")]
  Poinsettias = 40,
  /// <summary>
  /// A holly border.
  /// </summary>
  [WordInteropEnumValue("wdArtHolly")]
  Holly = 41,
  /// <summary>
  /// A tiny flower border.
  /// </summary>
  [WordInteropEnumValue("wdArtFlowersTiny")]
  FlowersTiny = 42,
  /// <summary>
  /// A pansy border.
  /// </summary>
  [WordInteropEnumValue("wdArtFlowersPansy")]
  FlowersPansy = 43,
  /// <summary>
  /// A modern flowers number 2 border.
  /// </summary>
  [WordInteropEnumValue("wdArtFlowersModern2")]
  FlowersModern2 = 44,
  /// <summary>
  /// A modern flowers number 1 border.
  /// </summary>
  [WordInteropEnumValue("wdArtFlowersModern1")]
  FlowersModern1 = 45,
  /// <summary>
  /// A white flower border.
  /// </summary>
  [WordInteropEnumValue("wdArtWhiteFlowers")]
  WhiteFlowers = 46,
  /// <summary>
  /// A vine border.
  /// </summary>
  [WordInteropEnumValue("wdArtVine")]
  Vine = 47,
  /// <summary>
  /// A daisies border.
  /// </summary>
  [WordInteropEnumValue("wdArtFlowersDaisies")]
  FlowersDaisies = 48,
  /// <summary>
  /// A block flowers print border.
  /// </summary>
  [WordInteropEnumValue("wdArtFlowersBlockPrint")]
  FlowersBlockPrint = 49,
  /// <summary>
  /// A deco arch colored border.
  /// </summary>
  [WordInteropEnumValue("wdArtDecoArchColor")]
  DecoArchColor = 50,
  /// <summary>
  /// A fans border.
  /// </summary>
  [WordInteropEnumValue("wdArtFans")]
  Fans = 51,
  /// <summary>
  /// A film border.
  /// </summary>
  [WordInteropEnumValue("wdArtFilm")]
  Film = 52,
  /// <summary>
  /// A lightning number 1 border.
  /// </summary>
  [WordInteropEnumValue("wdArtLightning1")]
  Lightning1 = 53,
  /// <summary>
  /// A compass border.
  /// </summary>
  [WordInteropEnumValue("wdArtCompass")]
  Compass = 54,
  /// <summary>
  /// A double-D border.
  /// </summary>
  [WordInteropEnumValue("wdArtDoubleD")]
  DoubleD = 55,
  /// <summary>
  /// A classical wave border.
  /// </summary>
  [WordInteropEnumValue("wdArtClassicalWave")]
  ClassicalWave = 56,
  /// <summary>
  /// A shadowed squared border.
  /// </summary>
  [WordInteropEnumValue("wdArtShadowedSquares")]
  ShadowedSquares = 57,
  /// <summary>
  /// A twisted lines number 1 border.
  /// </summary>
  [WordInteropEnumValue("wdArtTwistedLines1")]
  TwistedLines1 = 58,
  /// <summary>
  /// A wave line border.
  /// </summary>
  [WordInteropEnumValue("wdArtWaveline")]
  Waveline = 59,
  /// <summary>
  /// A quadrants border.
  /// </summary>
  [WordInteropEnumValue("wdArtQuadrants")]
  Quadrants = 60,
  /// <summary>
  /// A checked-bar colored border.
  /// </summary>
  [WordInteropEnumValue("wdArtCheckedBarColor")]
  CheckedBarColor = 61,
  /// <summary>
  /// A swirling border.
  /// </summary>
  [WordInteropEnumValue("wdArtSwirligig")]
  Swirligig = 62,
  /// <summary>
  /// A pushpin note number 1 border.
  /// </summary>
  [WordInteropEnumValue("wdArtPushPinNote1")]
  PushPinNote1 = 63,
  /// <summary>
  /// A pushpin note number 2 border.
  /// </summary>
  [WordInteropEnumValue("wdArtPushPinNote2")]
  PushPinNote2 = 64,
  /// <summary>
  /// A pumpkin number 1 border.
  /// </summary>
  [WordInteropEnumValue("wdArtPumpkin1")]
  Pumpkin1 = 65,
  /// <summary>
  /// A black eggs border.
  /// </summary>
  [WordInteropEnumValue("wdArtEggsBlack")]
  EggsBlack = 66,
  /// <summary>
  /// A cup border.
  /// </summary>
  [WordInteropEnumValue("wdArtCup")]
  Cup = 67,
  /// <summary>
  /// A heart border in shades of gray.
  /// </summary>
  [WordInteropEnumValue("wdArtHeartGray")]
  HeartGray = 68,
  /// <summary>
  /// A gingerbread man border.
  /// </summary>
  [WordInteropEnumValue("wdArtGingerbreadMan")]
  GingerbreadMan = 69,
  /// <summary>
  /// A baby pacifier border.
  /// </summary>
  [WordInteropEnumValue("wdArtBabyPacifier")]
  BabyPacifier = 70,
  /// <summary>
  /// A baby rattle border.
  /// </summary>
  [WordInteropEnumValue("wdArtBabyRattle")]
  BabyRattle = 71,
  /// <summary>
  /// A cabins border.
  /// </summary>
  [WordInteropEnumValue("wdArtCabins")]
  Cabins = 72,
  /// <summary>
  /// A funky house border.
  /// </summary>
  [WordInteropEnumValue("wdArtHouseFunky")]
  HouseFunky = 73,
  /// <summary>
  /// A black stars border.
  /// </summary>
  [WordInteropEnumValue("wdArtStarsBlack")]
  StarsBlack = 74,
  /// <summary>
  /// A snowflake border.
  /// </summary>
  [WordInteropEnumValue("wdArtSnowflakes")]
  Snowflakes = 75,
  /// <summary>
  /// A fancy snowflake border.
  /// </summary>
  [WordInteropEnumValue("wdArtSnowflakeFancy")]
  SnowflakeFancy = 76,
  /// <summary>
  /// A sky rocket border.
  /// </summary>
  [WordInteropEnumValue("wdArtSkyrocket")]
  Skyrocket = 77,
  /// <summary>
  /// A Seattle border.
  /// </summary>
  [WordInteropEnumValue("wdArtSeattle")]
  Seattle = 78,
  /// <summary>
  /// A music notes border.
  /// </summary>
  [WordInteropEnumValue("wdArtMusicNotes")]
  MusicNotes = 79,
  /// <summary>
  /// A black palms border.
  /// </summary>
  [WordInteropEnumValue("wdArtPalmsBlack")]
  PalmsBlack = 80,
  /// <summary>
  /// A maple leaf border.
  /// </summary>
  [WordInteropEnumValue("wdArtMapleLeaf")]
  MapleLeaf = 81,
  /// <summary>
  /// A paper clips border.
  /// </summary>
  [WordInteropEnumValue("wdArtPaperClips")]
  PaperClips = 82,
  /// <summary>
  /// A shorebird tracks border.
  /// </summary>
  [WordInteropEnumValue("wdArtShorebirdTracks")]
  ShorebirdTracks = 83,
  /// <summary>
  /// A people border.
  /// </summary>
  [WordInteropEnumValue("wdArtPeople")]
  People = 84,
  /// <summary>
  /// A people waving border.
  /// </summary>
  [WordInteropEnumValue("wdArtPeopleWaving")]
  PeopleWaving = 85,
  /// <summary>
  /// An eclipsing squares number 2 border.
  /// </summary>
  [WordInteropEnumValue("wdArtEclipsingSquares2")]
  EclipsingSquares2 = 86,
  /// <summary>
  /// A hypnotic border.
  /// </summary>
  [WordInteropEnumValue("wdArtHypnotic")]
  Hypnotic = 87,
  /// <summary>
  /// A diamond border using shades of gray.
  /// </summary>
  [WordInteropEnumValue("wdArtDiamondsGray")]
  DiamondsGray = 88,
  /// <summary>
  /// A deco arch border.
  /// </summary>
  [WordInteropEnumValue("wdArtDecoArch")]
  DecoArch = 89,
  /// <summary>
  /// A deco blocks border.
  /// </summary>
  [WordInteropEnumValue("wdArtDecoBlocks")]
  DecoBlocks = 90,
  /// <summary>
  /// A circles and lines border.
  /// </summary>
  [WordInteropEnumValue("wdArtCirclesLines")]
  CirclesLines = 91,
  /// <summary>
  /// A papyrus border.
  /// </summary>
  [WordInteropEnumValue("wdArtPapyrus")]
  Papyrus = 92,
  /// <summary>
  /// A woodwork border.
  /// </summary>
  [WordInteropEnumValue("wdArtWoodwork")]
  Woodwork = 93,
  /// <summary>
  /// A weaving braid border.
  /// </summary>
  [WordInteropEnumValue("wdArtWeavingBraid")]
  WeavingBraid = 94,
  /// <summary>
  /// A weaving ribbon border.
  /// </summary>
  [WordInteropEnumValue("wdArtWeavingRibbon")]
  WeavingRibbon = 95,
  /// <summary>
  /// A weaving angle border.
  /// </summary>
  [WordInteropEnumValue("wdArtWeavingAngles")]
  WeavingAngles = 96,
  /// <summary>
  /// An arched scalloped border.
  /// </summary>
  [WordInteropEnumValue("wdArtArchedScallops")]
  ArchedScallops = 97,
  /// <summary>
  /// A safari border.
  /// </summary>
  [WordInteropEnumValue("wdArtSafari")]
  Safari = 98,
  /// <summary>
  /// A Celtic knot work border.
  /// </summary>
  [WordInteropEnumValue("wdArtCelticKnotwork")]
  CelticKnotwork = 99,
  /// <summary>
  /// A crazy maze border.
  /// </summary>
  [WordInteropEnumValue("wdArtCrazyMaze")]
  CrazyMaze = 100,
  /// <summary>
  /// An eclipsing squares number 1 border.
  /// </summary>
  [WordInteropEnumValue("wdArtEclipsingSquares1")]
  EclipsingSquares1 = 101,
  /// <summary>
  /// A birds border.
  /// </summary>
  [WordInteropEnumValue("wdArtBirds")]
  Birds = 102,
  /// <summary>
  /// A teacup border.
  /// </summary>
  [WordInteropEnumValue("wdArtFlowersTeacup")]
  FlowersTeacup = 103,
  /// <summary>
  /// A northwest border.
  /// </summary>
  [WordInteropEnumValue("wdArtNorthwest")]
  Northwest = 104,
  /// <summary>
  /// A southwest border.
  /// </summary>
  [WordInteropEnumValue("wdArtSouthwest")]
  Southwest = 105,
  /// <summary>
  /// A tribal number 6 border.
  /// </summary>
  [WordInteropEnumValue("wdArtTribal6")]
  Tribal6 = 106,
  /// <summary>
  /// A tribal number 4 border.
  /// </summary>
  [WordInteropEnumValue("wdArtTribal4")]
  Tribal4 = 107,
  /// <summary>
  /// A tribal number 3 border.
  /// </summary>
  [WordInteropEnumValue("wdArtTribal3")]
  Tribal3 = 108,
  /// <summary>
  /// A tribal number 2 border.
  /// </summary>
  [WordInteropEnumValue("wdArtTribal2")]
  Tribal2 = 109,
  /// <summary>
  /// A tribal number 5 border.
  /// </summary>
  [WordInteropEnumValue("wdArtTribal5")]
  Tribal5 = 110,
  /// <summary>
  /// An X illusion border.
  /// </summary>
  [WordInteropEnumValue("wdArtXIllusions")]
  XIllusions = 111,
  /// <summary>
  /// A zany triangle border.
  /// </summary>
  [WordInteropEnumValue("wdArtZanyTriangles")]
  ZanyTriangles = 112,
  /// <summary>
  /// A pyramids border.
  /// </summary>
  [WordInteropEnumValue("wdArtPyramids")]
  Pyramids = 113,
  /// <summary>
  /// An external pyramids border.
  /// </summary>
  [WordInteropEnumValue("wdArtPyramidsAbove")]
  PyramidsAbove = 114,
  /// <summary>
  /// A confetti border using shades of gray.
  /// </summary>
  [WordInteropEnumValue("wdArtConfettiGrays")]
  ConfettiGrays = 115,
  /// <summary>
  /// A confetti outline border.
  /// </summary>
  [WordInteropEnumValue("wdArtConfettiOutline")]
  ConfettiOutline = 116,
  /// <summary>
  /// A confetti white border.
  /// </summary>
  [WordInteropEnumValue("wdArtConfettiWhite")]
  ConfettiWhite = 117,
  /// <summary>
  /// A mosaic border.
  /// </summary>
  [WordInteropEnumValue("wdArtMosaic")]
  Mosaic = 118,
  /// <summary>
  /// A lightning number 2 border.
  /// </summary>
  [WordInteropEnumValue("wdArtLightning2")]
  Lightning2 = 119,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtHeebieJeebies")]
  HeebieJeebies = 120,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtLightBulb")]
  LightBulb = 121,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtGradient")]
  Gradient = 122,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtTriangleParty")]
  TriangleParty = 123,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtTwistedLines2")]
  TwistedLines2 = 124,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtMoons")]
  Moons = 125,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtOvals")]
  Ovals = 126,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtDoubleDiamonds")]
  DoubleDiamonds = 127,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtChainLink")]
  ChainLink = 128,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtTriangles")]
  Triangles = 129,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtTribal1")]
  Tribal1 = 130,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtMarqueeToothed")]
  MarqueeToothed = 131,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtSharksTeeth")]
  SharksTeeth = 132,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtSawtooth")]
  Sawtooth = 133,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtSawtoothGray")]
  SawtoothGray = 134,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtPostageStamp")]
  PostageStamp = 135,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtWeavingStrips")]
  WeavingStrips = 136,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtZigZag")]
  ZigZag = 137,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtCrossStitch")]
  CrossStitch = 138,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtGems")]
  Gems = 139,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtCirclesRectangles")]
  CirclesRectangles = 140,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtCornerTriangles")]
  CornerTriangles = 141,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtCreaturesInsects")]
  CreaturesInsects = 142,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtZigZagStitch")]
  ZigZagStitch = 143,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtCheckered")]
  Checkered = 144,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtCheckedBarBlack")]
  CheckedBarBlack = 145,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtMarquee")]
  Marquee = 146,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtBasicWhiteDots")]
  BasicWhiteDots = 147,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtBasicWideMidline")]
  BasicWideMidline = 148,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtBasicWideOutline")]
  BasicWideOutline = 149,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtBasicWideInline")]
  BasicWideInline = 150,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtBasicThinLines")]
  BasicThinLines = 151,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtBasicWhiteDashes")]
  BasicWhiteDashes = 152,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtBasicWhiteSquares")]
  BasicWhiteSquares = 153,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtBasicBlackSquares")]
  BasicBlackSquares = 154,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtBasicBlackDashes")]
  BasicBlackDashes = 155,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtBasicBlackDots")]
  BasicBlackDots = 156,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtStarsTop")]
  StarsTop = 157,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtCertificateBanner")]
  CertificateBanner = 158,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtHandmade1")]
  Handmade1 = 159,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtHandmade2")]
  Handmade2 = 160,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtTornPaper")]
  TornPaper = 161,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtTornPaperBlack")]
  TornPaperBlack = 162,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtCouponCutoutDashes")]
  CouponCutoutDashes = 163,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue("wdArtCouponCutoutDots")]
  CouponCutoutDots = 164
}
