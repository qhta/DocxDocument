namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the graphical page border setting of a page.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpageborderart?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdPageBorderArt")]
public enum PageBorderArt
{
  /// <summary>
  /// An apple border.
  /// </summary>
  [InteropEnumValue("wdArtApples")]
  Apples = 1,
  /// <summary>
  /// A maple muffins border.
  /// </summary>
  [InteropEnumValue("wdArtMapleMuffins")]
  MapleMuffins = 2,
  /// <summary>
  /// A cake slice border.
  /// </summary>
  [InteropEnumValue("wdArtCakeSlice")]
  CakeSlice = 3,
  /// <summary>
  /// A candy corn border.
  /// </summary>
  [InteropEnumValue("wdArtCandyCorn")]
  CandyCorn = 4,
  /// <summary>
  /// An ice cream cones border.
  /// </summary>
  [InteropEnumValue("wdArtIceCreamCones")]
  IceCreamCones = 5,
  /// <summary>
  /// A champagne bottle border.
  /// </summary>
  [InteropEnumValue("wdArtChampagneBottle")]
  ChampagneBottle = 6,
  /// <summary>
  /// A party glass border.
  /// </summary>
  [InteropEnumValue("wdArtPartyGlass")]
  PartyGlass = 7,
  /// <summary>
  /// A Christmas tree border.
  /// </summary>
  [InteropEnumValue("wdArtChristmasTree")]
  ChristmasTree = 8,
  /// <summary>
  /// A trees border.
  /// </summary>
  [InteropEnumValue("wdArtTrees")]
  Trees = 9,
  /// <summary>
  /// A colored palms border.
  /// </summary>
  [InteropEnumValue("wdArtPalmsColor")]
  PalmsColor = 10,
  /// <summary>
  /// Balloons in three colors as the border.
  /// </summary>
  [InteropEnumValue("wdArtBalloons3Colors")]
  Balloons3Colors = 11,
  /// <summary>
  /// A hot air balloon border.
  /// </summary>
  [InteropEnumValue("wdArtBalloonsHotAir")]
  BalloonsHotAir = 12,
  /// <summary>
  /// A party favor border.
  /// </summary>
  [InteropEnumValue("wdArtPartyFavor")]
  PartyFavor = 13,
  /// <summary>
  /// A confetti streamers border.
  /// </summary>
  [InteropEnumValue("wdArtConfettiStreamers")]
  ConfettiStreamers = 14,
  /// <summary>
  /// A hearts border.
  /// </summary>
  [InteropEnumValue("wdArtHearts")]
  Hearts = 15,
  /// <summary>
  /// A heart balloon border.
  /// </summary>
  [InteropEnumValue("wdArtHeartBalloon")]
  HeartBalloon = 16,
  /// <summary>
  /// A 3-D stars border.
  /// </summary>
  [InteropEnumValue("wdArtStars3D")]
  Stars3D = 17,
  /// <summary>
  /// A shadowed stars border.
  /// </summary>
  [InteropEnumValue("wdArtStarsShadowed")]
  StarsShadowed = 18,
  /// <summary>
  /// A stars border.
  /// </summary>
  [InteropEnumValue("wdArtStars")]
  Stars = 19,
  /// <summary>
  /// A sun border.
  /// </summary>
  [InteropEnumValue("wdArtSun")]
  Sun = 20,
  /// <summary>
  /// An earth number 2 border.
  /// </summary>
  [InteropEnumValue("wdArtEarth2")]
  Earth2 = 21,
  /// <summary>
  /// An earth number 1 border.
  /// </summary>
  [InteropEnumValue("wdArtEarth1")]
  Earth1 = 22,
  /// <summary>
  /// A people wearing hats border.
  /// </summary>
  [InteropEnumValue("wdArtPeopleHats")]
  PeopleHats = 23,
  /// <summary>
  /// A sombrero border.
  /// </summary>
  [InteropEnumValue("wdArtSombrero")]
  Sombrero = 24,
  /// <summary>
  /// A pencils border.
  /// </summary>
  [InteropEnumValue("wdArtPencils")]
  Pencils = 25,
  /// <summary>
  /// A packages border.
  /// </summary>
  [InteropEnumValue("wdArtPackages")]
  Packages = 26,
  /// <summary>
  /// A clocks border.
  /// </summary>
  [InteropEnumValue("wdArtClocks")]
  Clocks = 27,
  /// <summary>
  /// A fire crackers border.
  /// </summary>
  [InteropEnumValue("wdArtFirecrackers")]
  Firecrackers = 28,
  /// <summary>
  /// A rings border.
  /// </summary>
  [InteropEnumValue("wdArtRings")]
  Rings = 29,
  /// <summary>
  /// A map pins border.
  /// </summary>
  [InteropEnumValue("wdArtMapPins")]
  MapPins = 30,
  /// <summary>
  /// A confetti border.
  /// </summary>
  [InteropEnumValue("wdArtConfetti")]
  Confetti = 31,
  /// <summary>
  /// A butterfly border.
  /// </summary>
  [InteropEnumValue("wdArtCreaturesButterfly")]
  CreaturesButterfly = 32,
  /// <summary>
  /// A ladybug border.
  /// </summary>
  [InteropEnumValue("wdArtCreaturesLadyBug")]
  CreaturesLadyBug = 33,
  /// <summary>
  /// A fish border.
  /// </summary>
  [InteropEnumValue("wdArtCreaturesFish")]
  CreaturesFish = 34,
  /// <summary>
  /// A birds in flight border.
  /// </summary>
  [InteropEnumValue("wdArtBirdsFlight")]
  BirdsFlight = 35,
  /// <summary>
  /// A scared cat border.
  /// </summary>
  [InteropEnumValue("wdArtScaredCat")]
  ScaredCat = 36,
  /// <summary>
  /// A bats border.
  /// </summary>
  [InteropEnumValue("wdArtBats")]
  Bats = 37,
  /// <summary>
  /// A rose border.
  /// </summary>
  [InteropEnumValue("wdArtFlowersRoses")]
  FlowersRoses = 38,
  /// <summary>
  /// A red rose border.
  /// </summary>
  [InteropEnumValue("wdArtFlowersRedRose")]
  FlowersRedRose = 39,
  /// <summary>
  /// A poinsettias border.
  /// </summary>
  [InteropEnumValue("wdArtPoinsettias")]
  Poinsettias = 40,
  /// <summary>
  /// A holly border.
  /// </summary>
  [InteropEnumValue("wdArtHolly")]
  Holly = 41,
  /// <summary>
  /// A tiny flower border.
  /// </summary>
  [InteropEnumValue("wdArtFlowersTiny")]
  FlowersTiny = 42,
  /// <summary>
  /// A pansy border.
  /// </summary>
  [InteropEnumValue("wdArtFlowersPansy")]
  FlowersPansy = 43,
  /// <summary>
  /// A modern flowers number 2 border.
  /// </summary>
  [InteropEnumValue("wdArtFlowersModern2")]
  FlowersModern2 = 44,
  /// <summary>
  /// A modern flowers number 1 border.
  /// </summary>
  [InteropEnumValue("wdArtFlowersModern1")]
  FlowersModern1 = 45,
  /// <summary>
  /// A white flower border.
  /// </summary>
  [InteropEnumValue("wdArtWhiteFlowers")]
  WhiteFlowers = 46,
  /// <summary>
  /// A vine border.
  /// </summary>
  [InteropEnumValue("wdArtVine")]
  Vine = 47,
  /// <summary>
  /// A daisies border.
  /// </summary>
  [InteropEnumValue("wdArtFlowersDaisies")]
  FlowersDaisies = 48,
  /// <summary>
  /// A block flowers print border.
  /// </summary>
  [InteropEnumValue("wdArtFlowersBlockPrint")]
  FlowersBlockPrint = 49,
  /// <summary>
  /// A deco arch colored border.
  /// </summary>
  [InteropEnumValue("wdArtDecoArchColor")]
  DecoArchColor = 50,
  /// <summary>
  /// A fans border.
  /// </summary>
  [InteropEnumValue("wdArtFans")]
  Fans = 51,
  /// <summary>
  /// A film border.
  /// </summary>
  [InteropEnumValue("wdArtFilm")]
  Film = 52,
  /// <summary>
  /// A lightning number 1 border.
  /// </summary>
  [InteropEnumValue("wdArtLightning1")]
  Lightning1 = 53,
  /// <summary>
  /// A compass border.
  /// </summary>
  [InteropEnumValue("wdArtCompass")]
  Compass = 54,
  /// <summary>
  /// A double-D border.
  /// </summary>
  [InteropEnumValue("wdArtDoubleD")]
  DoubleD = 55,
  /// <summary>
  /// A classical wave border.
  /// </summary>
  [InteropEnumValue("wdArtClassicalWave")]
  ClassicalWave = 56,
  /// <summary>
  /// A shadowed squared border.
  /// </summary>
  [InteropEnumValue("wdArtShadowedSquares")]
  ShadowedSquares = 57,
  /// <summary>
  /// A twisted lines number 1 border.
  /// </summary>
  [InteropEnumValue("wdArtTwistedLines1")]
  TwistedLines1 = 58,
  /// <summary>
  /// A wave line border.
  /// </summary>
  [InteropEnumValue("wdArtWaveline")]
  Waveline = 59,
  /// <summary>
  /// A quadrants border.
  /// </summary>
  [InteropEnumValue("wdArtQuadrants")]
  Quadrants = 60,
  /// <summary>
  /// A checked-bar colored border.
  /// </summary>
  [InteropEnumValue("wdArtCheckedBarColor")]
  CheckedBarColor = 61,
  /// <summary>
  /// A swirling border.
  /// </summary>
  [InteropEnumValue("wdArtSwirligig")]
  Swirligig = 62,
  /// <summary>
  /// A pushpin note number 1 border.
  /// </summary>
  [InteropEnumValue("wdArtPushPinNote1")]
  PushPinNote1 = 63,
  /// <summary>
  /// A pushpin note number 2 border.
  /// </summary>
  [InteropEnumValue("wdArtPushPinNote2")]
  PushPinNote2 = 64,
  /// <summary>
  /// A pumpkin number 1 border.
  /// </summary>
  [InteropEnumValue("wdArtPumpkin1")]
  Pumpkin1 = 65,
  /// <summary>
  /// A black eggs border.
  /// </summary>
  [InteropEnumValue("wdArtEggsBlack")]
  EggsBlack = 66,
  /// <summary>
  /// A cup border.
  /// </summary>
  [InteropEnumValue("wdArtCup")]
  Cup = 67,
  /// <summary>
  /// A heart border in shades of gray.
  /// </summary>
  [InteropEnumValue("wdArtHeartGray")]
  HeartGray = 68,
  /// <summary>
  /// A gingerbread man border.
  /// </summary>
  [InteropEnumValue("wdArtGingerbreadMan")]
  GingerbreadMan = 69,
  /// <summary>
  /// A baby pacifier border.
  /// </summary>
  [InteropEnumValue("wdArtBabyPacifier")]
  BabyPacifier = 70,
  /// <summary>
  /// A baby rattle border.
  /// </summary>
  [InteropEnumValue("wdArtBabyRattle")]
  BabyRattle = 71,
  /// <summary>
  /// A cabins border.
  /// </summary>
  [InteropEnumValue("wdArtCabins")]
  Cabins = 72,
  /// <summary>
  /// A funky house border.
  /// </summary>
  [InteropEnumValue("wdArtHouseFunky")]
  HouseFunky = 73,
  /// <summary>
  /// A black stars border.
  /// </summary>
  [InteropEnumValue("wdArtStarsBlack")]
  StarsBlack = 74,
  /// <summary>
  /// A snowflake border.
  /// </summary>
  [InteropEnumValue("wdArtSnowflakes")]
  Snowflakes = 75,
  /// <summary>
  /// A fancy snowflake border.
  /// </summary>
  [InteropEnumValue("wdArtSnowflakeFancy")]
  SnowflakeFancy = 76,
  /// <summary>
  /// A sky rocket border.
  /// </summary>
  [InteropEnumValue("wdArtSkyrocket")]
  Skyrocket = 77,
  /// <summary>
  /// A Seattle border.
  /// </summary>
  [InteropEnumValue("wdArtSeattle")]
  Seattle = 78,
  /// <summary>
  /// A music notes border.
  /// </summary>
  [InteropEnumValue("wdArtMusicNotes")]
  MusicNotes = 79,
  /// <summary>
  /// A black palms border.
  /// </summary>
  [InteropEnumValue("wdArtPalmsBlack")]
  PalmsBlack = 80,
  /// <summary>
  /// A maple leaf border.
  /// </summary>
  [InteropEnumValue("wdArtMapleLeaf")]
  MapleLeaf = 81,
  /// <summary>
  /// A paper clips border.
  /// </summary>
  [InteropEnumValue("wdArtPaperClips")]
  PaperClips = 82,
  /// <summary>
  /// A shorebird tracks border.
  /// </summary>
  [InteropEnumValue("wdArtShorebirdTracks")]
  ShorebirdTracks = 83,
  /// <summary>
  /// A people border.
  /// </summary>
  [InteropEnumValue("wdArtPeople")]
  People = 84,
  /// <summary>
  /// A people waving border.
  /// </summary>
  [InteropEnumValue("wdArtPeopleWaving")]
  PeopleWaving = 85,
  /// <summary>
  /// An eclipsing squares number 2 border.
  /// </summary>
  [InteropEnumValue("wdArtEclipsingSquares2")]
  EclipsingSquares2 = 86,
  /// <summary>
  /// A hypnotic border.
  /// </summary>
  [InteropEnumValue("wdArtHypnotic")]
  Hypnotic = 87,
  /// <summary>
  /// A diamond border using shades of gray.
  /// </summary>
  [InteropEnumValue("wdArtDiamondsGray")]
  DiamondsGray = 88,
  /// <summary>
  /// A deco arch border.
  /// </summary>
  [InteropEnumValue("wdArtDecoArch")]
  DecoArch = 89,
  /// <summary>
  /// A deco blocks border.
  /// </summary>
  [InteropEnumValue("wdArtDecoBlocks")]
  DecoBlocks = 90,
  /// <summary>
  /// A circles and lines border.
  /// </summary>
  [InteropEnumValue("wdArtCirclesLines")]
  CirclesLines = 91,
  /// <summary>
  /// A papyrus border.
  /// </summary>
  [InteropEnumValue("wdArtPapyrus")]
  Papyrus = 92,
  /// <summary>
  /// A woodwork border.
  /// </summary>
  [InteropEnumValue("wdArtWoodwork")]
  Woodwork = 93,
  /// <summary>
  /// A weaving braid border.
  /// </summary>
  [InteropEnumValue("wdArtWeavingBraid")]
  WeavingBraid = 94,
  /// <summary>
  /// A weaving ribbon border.
  /// </summary>
  [InteropEnumValue("wdArtWeavingRibbon")]
  WeavingRibbon = 95,
  /// <summary>
  /// A weaving angle border.
  /// </summary>
  [InteropEnumValue("wdArtWeavingAngles")]
  WeavingAngles = 96,
  /// <summary>
  /// An arched scalloped border.
  /// </summary>
  [InteropEnumValue("wdArtArchedScallops")]
  ArchedScallops = 97,
  /// <summary>
  /// A safari border.
  /// </summary>
  [InteropEnumValue("wdArtSafari")]
  Safari = 98,
  /// <summary>
  /// A Celtic knot work border.
  /// </summary>
  [InteropEnumValue("wdArtCelticKnotwork")]
  CelticKnotwork = 99,
  /// <summary>
  /// A crazy maze border.
  /// </summary>
  [InteropEnumValue("wdArtCrazyMaze")]
  CrazyMaze = 100,
  /// <summary>
  /// An eclipsing squares number 1 border.
  /// </summary>
  [InteropEnumValue("wdArtEclipsingSquares1")]
  EclipsingSquares1 = 101,
  /// <summary>
  /// A birds border.
  /// </summary>
  [InteropEnumValue("wdArtBirds")]
  Birds = 102,
  /// <summary>
  /// A teacup border.
  /// </summary>
  [InteropEnumValue("wdArtFlowersTeacup")]
  FlowersTeacup = 103,
  /// <summary>
  /// A northwest border.
  /// </summary>
  [InteropEnumValue("wdArtNorthwest")]
  Northwest = 104,
  /// <summary>
  /// A southwest border.
  /// </summary>
  [InteropEnumValue("wdArtSouthwest")]
  Southwest = 105,
  /// <summary>
  /// A tribal number 6 border.
  /// </summary>
  [InteropEnumValue("wdArtTribal6")]
  Tribal6 = 106,
  /// <summary>
  /// A tribal number 4 border.
  /// </summary>
  [InteropEnumValue("wdArtTribal4")]
  Tribal4 = 107,
  /// <summary>
  /// A tribal number 3 border.
  /// </summary>
  [InteropEnumValue("wdArtTribal3")]
  Tribal3 = 108,
  /// <summary>
  /// A tribal number 2 border.
  /// </summary>
  [InteropEnumValue("wdArtTribal2")]
  Tribal2 = 109,
  /// <summary>
  /// A tribal number 5 border.
  /// </summary>
  [InteropEnumValue("wdArtTribal5")]
  Tribal5 = 110,
  /// <summary>
  /// An X illusion border.
  /// </summary>
  [InteropEnumValue("wdArtXIllusions")]
  XIllusions = 111,
  /// <summary>
  /// A zany triangle border.
  /// </summary>
  [InteropEnumValue("wdArtZanyTriangles")]
  ZanyTriangles = 112,
  /// <summary>
  /// A pyramids border.
  /// </summary>
  [InteropEnumValue("wdArtPyramids")]
  Pyramids = 113,
  /// <summary>
  /// An external pyramids border.
  /// </summary>
  [InteropEnumValue("wdArtPyramidsAbove")]
  PyramidsAbove = 114,
  /// <summary>
  /// A confetti border using shades of gray.
  /// </summary>
  [InteropEnumValue("wdArtConfettiGrays")]
  ConfettiGrays = 115,
  /// <summary>
  /// A confetti outline border.
  /// </summary>
  [InteropEnumValue("wdArtConfettiOutline")]
  ConfettiOutline = 116,
  /// <summary>
  /// A confetti white border.
  /// </summary>
  [InteropEnumValue("wdArtConfettiWhite")]
  ConfettiWhite = 117,
  /// <summary>
  /// A mosaic border.
  /// </summary>
  [InteropEnumValue("wdArtMosaic")]
  Mosaic = 118,
  /// <summary>
  /// A lightning number 2 border.
  /// </summary>
  [InteropEnumValue("wdArtLightning2")]
  Lightning2 = 119,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtHeebieJeebies")]
  HeebieJeebies = 120,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtLightBulb")]
  LightBulb = 121,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtGradient")]
  Gradient = 122,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtTriangleParty")]
  TriangleParty = 123,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtTwistedLines2")]
  TwistedLines2 = 124,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtMoons")]
  Moons = 125,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtOvals")]
  Ovals = 126,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtDoubleDiamonds")]
  DoubleDiamonds = 127,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtChainLink")]
  ChainLink = 128,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtTriangles")]
  Triangles = 129,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtTribal1")]
  Tribal1 = 130,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtMarqueeToothed")]
  MarqueeToothed = 131,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtSharksTeeth")]
  SharksTeeth = 132,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtSawtooth")]
  Sawtooth = 133,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtSawtoothGray")]
  SawtoothGray = 134,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtPostageStamp")]
  PostageStamp = 135,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtWeavingStrips")]
  WeavingStrips = 136,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtZigZag")]
  ZigZag = 137,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtCrossStitch")]
  CrossStitch = 138,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtGems")]
  Gems = 139,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtCirclesRectangles")]
  CirclesRectangles = 140,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtCornerTriangles")]
  CornerTriangles = 141,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtCreaturesInsects")]
  CreaturesInsects = 142,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtZigZagStitch")]
  ZigZagStitch = 143,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtCheckered")]
  Checkered = 144,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtCheckedBarBlack")]
  CheckedBarBlack = 145,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtMarquee")]
  Marquee = 146,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtBasicWhiteDots")]
  BasicWhiteDots = 147,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtBasicWideMidline")]
  BasicWideMidline = 148,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtBasicWideOutline")]
  BasicWideOutline = 149,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtBasicWideInline")]
  BasicWideInline = 150,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtBasicThinLines")]
  BasicThinLines = 151,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtBasicWhiteDashes")]
  BasicWhiteDashes = 152,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtBasicWhiteSquares")]
  BasicWhiteSquares = 153,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtBasicBlackSquares")]
  BasicBlackSquares = 154,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtBasicBlackDashes")]
  BasicBlackDashes = 155,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtBasicBlackDots")]
  BasicBlackDots = 156,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtStarsTop")]
  StarsTop = 157,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtCertificateBanner")]
  CertificateBanner = 158,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtHandmade1")]
  Handmade1 = 159,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtHandmade2")]
  Handmade2 = 160,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtTornPaper")]
  TornPaper = 161,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtTornPaperBlack")]
  TornPaperBlack = 162,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtCouponCutoutDashes")]
  CouponCutoutDashes = 163,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [InteropEnumValue("wdArtCouponCutoutDots")]
  CouponCutoutDots = 164
}
