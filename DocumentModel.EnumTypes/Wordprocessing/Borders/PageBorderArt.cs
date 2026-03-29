namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the graphical page border setting of a page.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpageborderart?view=office-pia` for Office interop details.
/// </remarks>
public enum PageBorderArt
{
  /// <summary>
  /// An apple border.
  /// </summary>
  Apples = 1,
  /// <summary>
  /// A maple muffins border.
  /// </summary>
  MapleMuffins = 2,
  /// <summary>
  /// A cake slice border.
  /// </summary>
  CakeSlice = 3,
  /// <summary>
  /// A candy corn border.
  /// </summary>
  CandyCorn = 4,
  /// <summary>
  /// An ice cream cones border.
  /// </summary>
  IceCreamCones = 5,
  /// <summary>
  /// A champagne bottle border.
  /// </summary>
  ChampagneBottle = 6,
  /// <summary>
  /// A party glass border.
  /// </summary>
  PartyGlass = 7,
  /// <summary>
  /// A Christmas tree border.
  /// </summary>
  ChristmasTree = 8,
  /// <summary>
  /// A trees border.
  /// </summary>
  Trees = 9,
  /// <summary>
  /// A colored palms border.
  /// </summary>
  PalmsColor = 10,
  /// <summary>
  /// Balloons in three colors as the border.
  /// </summary>
  Balloons3Colors = 11,
  /// <summary>
  /// A hot air balloon border.
  /// </summary>
  BalloonsHotAir = 12,
  /// <summary>
  /// A party favor border.
  /// </summary>
  PartyFavor = 13,
  /// <summary>
  /// A confetti streamers border.
  /// </summary>
  ConfettiStreamers = 14,
  /// <summary>
  /// A hearts border.
  /// </summary>
  Hearts = 15,
  /// <summary>
  /// A heart balloon border.
  /// </summary>
  HeartBalloon = 16,
  /// <summary>
  /// A 3-D stars border.
  /// </summary>
  Stars3D = 17,
  /// <summary>
  /// A shadowed stars border.
  /// </summary>
  StarsShadowed = 18,
  /// <summary>
  /// A stars border.
  /// </summary>
  Stars = 19,
  /// <summary>
  /// A sun border.
  /// </summary>
  Sun = 20,
  /// <summary>
  /// An earth number 2 border.
  /// </summary>
  Earth2 = 21,
  /// <summary>
  /// An earth number 1 border.
  /// </summary>
  Earth1 = 22,
  /// <summary>
  /// A people wearing hats border.
  /// </summary>
  PeopleHats = 23,
  /// <summary>
  /// A sombrero border.
  /// </summary>
  Sombrero = 24,
  /// <summary>
  /// A pencils border.
  /// </summary>
  Pencils = 25,
  /// <summary>
  /// A packages border.
  /// </summary>
  Packages = 26,
  /// <summary>
  /// A clocks border.
  /// </summary>
  Clocks = 27,
  /// <summary>
  /// A fire crackers border.
  /// </summary>
  Firecrackers = 28,
  /// <summary>
  /// A rings border.
  /// </summary>
  Rings = 29,
  /// <summary>
  /// A map pins border.
  /// </summary>
  MapPins = 30,
  /// <summary>
  /// A confetti border.
  /// </summary>
  Confetti = 31,
  /// <summary>
  /// A butterfly border.
  /// </summary>
  CreaturesButterfly = 32,
  /// <summary>
  /// A ladybug border.
  /// </summary>
  CreaturesLadyBug = 33,
  /// <summary>
  /// A fish border.
  /// </summary>
  CreaturesFish = 34,
  /// <summary>
  /// A birds in flight border.
  /// </summary>
  BirdsFlight = 35,
  /// <summary>
  /// A scared cat border.
  /// </summary>
  ScaredCat = 36,
  /// <summary>
  /// A bats border.
  /// </summary>
  Bats = 37,
  /// <summary>
  /// A rose border.
  /// </summary>
  FlowersRoses = 38,
  /// <summary>
  /// A red rose border.
  /// </summary>
  FlowersRedRose = 39,
  /// <summary>
  /// A poinsettias border.
  /// </summary>
  Poinsettias = 40,
  /// <summary>
  /// A holly border.
  /// </summary>
  Holly = 41,
  /// <summary>
  /// A tiny flower border.
  /// </summary>
  FlowersTiny = 42,
  /// <summary>
  /// A pansy border.
  /// </summary>
  FlowersPansy = 43,
  /// <summary>
  /// A modern flowers number 2 border.
  /// </summary>
  FlowersModern2 = 44,
  /// <summary>
  /// A modern flowers number 1 border.
  /// </summary>
  FlowersModern1 = 45,
  /// <summary>
  /// A white flower border.
  /// </summary>
  WhiteFlowers = 46,
  /// <summary>
  /// A vine border.
  /// </summary>
  Vine = 47,
  /// <summary>
  /// A daisies border.
  /// </summary>
  FlowersDaisies = 48,
  /// <summary>
  /// A block flowers print border.
  /// </summary>
  FlowersBlockPrint = 49,
  /// <summary>
  /// A deco arch colored border.
  /// </summary>
  DecoArchColor = 50,
  /// <summary>
  /// A fans border.
  /// </summary>
  Fans = 51,
  /// <summary>
  /// A film border.
  /// </summary>
  Film = 52,
  /// <summary>
  /// A lightning number 1 border.
  /// </summary>
  Lightning1 = 53,
  /// <summary>
  /// A compass border.
  /// </summary>
  Compass = 54,
  /// <summary>
  /// A double-D border.
  /// </summary>
  DoubleD = 55,
  /// <summary>
  /// A classical wave border.
  /// </summary>
  ClassicalWave = 56,
  /// <summary>
  /// A shadowed squared border.
  /// </summary>
  ShadowedSquares = 57,
  /// <summary>
  /// A twisted lines number 1 border.
  /// </summary>
  TwistedLines1 = 58,
  /// <summary>
  /// A wave line border.
  /// </summary>
  Waveline = 59,
  /// <summary>
  /// A quadrants border.
  /// </summary>
  Quadrants = 60,
  /// <summary>
  /// A checked-bar colored border.
  /// </summary>
  CheckedBarColor = 61,
  /// <summary>
  /// A swirling border.
  /// </summary>
  Swirligig = 62,
  /// <summary>
  /// A pushpin note number 1 border.
  /// </summary>
  PushPinNote1 = 63,
  /// <summary>
  /// A pushpin note number 2 border.
  /// </summary>
  PushPinNote2 = 64,
  /// <summary>
  /// A pumpkin number 1 border.
  /// </summary>
  Pumpkin1 = 65,
  /// <summary>
  /// A black eggs border.
  /// </summary>
  EggsBlack = 66,
  /// <summary>
  /// A cup border.
  /// </summary>
  Cup = 67,
  /// <summary>
  /// A heart border in shades of gray.
  /// </summary>
  HeartGray = 68,
  /// <summary>
  /// A gingerbread man border.
  /// </summary>
  GingerbreadMan = 69,
  /// <summary>
  /// A baby pacifier border.
  /// </summary>
  BabyPacifier = 70,
  /// <summary>
  /// A baby rattle border.
  /// </summary>
  BabyRattle = 71,
  /// <summary>
  /// A cabins border.
  /// </summary>
  Cabins = 72,
  /// <summary>
  /// A funky house border.
  /// </summary>
  HouseFunky = 73,
  /// <summary>
  /// A black stars border.
  /// </summary>
  StarsBlack = 74,
  /// <summary>
  /// A snowflake border.
  /// </summary>
  Snowflakes = 75,
  /// <summary>
  /// A fancy snowflake border.
  /// </summary>
  SnowflakeFancy = 76,
  /// <summary>
  /// A sky rocket border.
  /// </summary>
  Skyrocket = 77,
  /// <summary>
  /// A Seattle border.
  /// </summary>
  Seattle = 78,
  /// <summary>
  /// A music notes border.
  /// </summary>
  MusicNotes = 79,
  /// <summary>
  /// A black palms border.
  /// </summary>
  PalmsBlack = 80,
  /// <summary>
  /// A maple leaf border.
  /// </summary>
  MapleLeaf = 81,
  /// <summary>
  /// A paper clips border.
  /// </summary>
  PaperClips = 82,
  /// <summary>
  /// A shorebird tracks border.
  /// </summary>
  ShorebirdTracks = 83,
  /// <summary>
  /// A people border.
  /// </summary>
  People = 84,
  /// <summary>
  /// A people waving border.
  /// </summary>
  PeopleWaving = 85,
  /// <summary>
  /// An eclipsing squares number 2 border.
  /// </summary>
  EclipsingSquares2 = 86,
  /// <summary>
  /// A hypnotic border.
  /// </summary>
  Hypnotic = 87,
  /// <summary>
  /// A diamond border using shades of gray.
  /// </summary>
  DiamondsGray = 88,
  /// <summary>
  /// A deco arch border.
  /// </summary>
  DecoArch = 89,
  /// <summary>
  /// A deco blocks border.
  /// </summary>
  DecoBlocks = 90,
  /// <summary>
  /// A circles and lines border.
  /// </summary>
  CirclesLines = 91,
  /// <summary>
  /// A papyrus border.
  /// </summary>
  Papyrus = 92,
  /// <summary>
  /// A woodwork border.
  /// </summary>
  Woodwork = 93,
  /// <summary>
  /// A weaving braid border.
  /// </summary>
  WeavingBraid = 94,
  /// <summary>
  /// A weaving ribbon border.
  /// </summary>
  WeavingRibbon = 95,
  /// <summary>
  /// A weaving angle border.
  /// </summary>
  WeavingAngles = 96,
  /// <summary>
  /// An arched scalloped border.
  /// </summary>
  ArchedScallops = 97,
  /// <summary>
  /// A safari border.
  /// </summary>
  Safari = 98,
  /// <summary>
  /// A Celtic knot work border.
  /// </summary>
  CelticKnotwork = 99,
  /// <summary>
  /// A crazy maze border.
  /// </summary>
  CrazyMaze = 100,
  /// <summary>
  /// An eclipsing squares number 1 border.
  /// </summary>
  EclipsingSquares1 = 101,
  /// <summary>
  /// A birds border.
  /// </summary>
  Birds = 102,
  /// <summary>
  /// A teacup border.
  /// </summary>
  FlowersTeacup = 103,
  /// <summary>
  /// A northwest border.
  /// </summary>
  Northwest = 104,
  /// <summary>
  /// A southwest border.
  /// </summary>
  Southwest = 105,
  /// <summary>
  /// A tribal number 6 border.
  /// </summary>
  Tribal6 = 106,
  /// <summary>
  /// A tribal number 4 border.
  /// </summary>
  Tribal4 = 107,
  /// <summary>
  /// A tribal number 3 border.
  /// </summary>
  Tribal3 = 108,
  /// <summary>
  /// A tribal number 2 border.
  /// </summary>
  Tribal2 = 109,
  /// <summary>
  /// A tribal number 5 border.
  /// </summary>
  Tribal5 = 110,
  /// <summary>
  /// An X illusion border.
  /// </summary>
  XIllusions = 111,
  /// <summary>
  /// A zany triangle border.
  /// </summary>
  ZanyTriangles = 112,
  /// <summary>
  /// A pyramids border.
  /// </summary>
  Pyramids = 113,
  /// <summary>
  /// An external pyramids border.
  /// </summary>
  PyramidsAbove = 114,
  /// <summary>
  /// A confetti border using shades of gray.
  /// </summary>
  ConfettiGrays = 115,
  /// <summary>
  /// A confetti outline border.
  /// </summary>
  ConfettiOutline = 116,
  /// <summary>
  /// A confetti white border.
  /// </summary>
  ConfettiWhite = 117,
  /// <summary>
  /// A mosaic border.
  /// </summary>
  Mosaic = 118,
  /// <summary>
  /// A lightning number 2 border.
  /// </summary>
  Lightning2 = 119,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  HeebieJeebies = 120,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  LightBulb = 121,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  Gradient = 122,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  TriangleParty = 123,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  TwistedLines2 = 124,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  Moons = 125,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  Ovals = 126,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  DoubleDiamonds = 127,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  ChainLink = 128,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  Triangles = 129,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  Tribal1 = 130,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  MarqueeToothed = 131,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  SharksTeeth = 132,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  Sawtooth = 133,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  SawtoothGray = 134,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  PostageStamp = 135,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  WeavingStrips = 136,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  ZigZag = 137,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  CrossStitch = 138,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  Gems = 139,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  CirclesRectangles = 140,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  CornerTriangles = 141,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  CreaturesInsects = 142,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  ZigZagStitch = 143,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  Checkered = 144,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  CheckedBarBlack = 145,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  Marquee = 146,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  BasicWhiteDots = 147,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  BasicWideMidline = 148,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  BasicWideOutline = 149,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  BasicWideInline = 150,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  BasicThinLines = 151,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  BasicWhiteDashes = 152,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  BasicWhiteSquares = 153,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  BasicBlackSquares = 154,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  BasicBlackDashes = 155,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  BasicBlackDots = 156,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  StarsTop = 157,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  CertificateBanner = 158,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  Handmade1 = 159,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  Handmade2 = 160,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  TornPaper = 161,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  TornPaperBlack = 162,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  CouponCutoutDashes = 163,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  CouponCutoutDots = 164
}
