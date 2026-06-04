namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the graphical page border setting of a page.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpageborderart?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdPageBorderArt))]
public enum PageBorderArt
{
  /// <summary>
  /// An apple border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtApples))]
  Apples = 1,
  /// <summary>
  /// A maple muffins border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtMapleMuffins))]
  MapleMuffins = 2,
  /// <summary>
  /// A cake slice border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCakeSlice))]
  CakeSlice = 3,
  /// <summary>
  /// A candy corn border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCandyCorn))]
  CandyCorn = 4,
  /// <summary>
  /// An ice cream cones border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtIceCreamCones))]
  IceCreamCones = 5,
  /// <summary>
  /// A champagne bottle border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtChampagneBottle))]
  ChampagneBottle = 6,
  /// <summary>
  /// A party glass border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPartyGlass))]
  PartyGlass = 7,
  /// <summary>
  /// A Christmas tree border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtChristmasTree))]
  ChristmasTree = 8,
  /// <summary>
  /// A trees border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtTrees))]
  Trees = 9,
  /// <summary>
  /// A colored palms border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPalmsColor))]
  PalmsColor = 10,
  /// <summary>
  /// Balloons in three colors as the border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBalloons3Colors))]
  Balloons3Colors = 11,
  /// <summary>
  /// A hot air balloon border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBalloonsHotAir))]
  BalloonsHotAir = 12,
  /// <summary>
  /// A party favor border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPartyFavor))]
  PartyFavor = 13,
  /// <summary>
  /// A confetti streamers border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtConfettiStreamers))]
  ConfettiStreamers = 14,
  /// <summary>
  /// A hearts border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtHearts))]
  Hearts = 15,
  /// <summary>
  /// A heart balloon border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtHeartBalloon))]
  HeartBalloon = 16,
  /// <summary>
  /// A 3-D stars border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtStars3D))]
  Stars3D = 17,
  /// <summary>
  /// A shadowed stars border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtStarsShadowed))]
  StarsShadowed = 18,
  /// <summary>
  /// A stars border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtStars))]
  Stars = 19,
  /// <summary>
  /// A sun border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtSun))]
  Sun = 20,
  /// <summary>
  /// An earth number 2 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtEarth2))]
  Earth2 = 21,
  /// <summary>
  /// An earth number 1 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtEarth1))]
  Earth1 = 22,
  /// <summary>
  /// A people wearing hats border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPeopleHats))]
  PeopleHats = 23,
  /// <summary>
  /// A sombrero border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtSombrero))]
  Sombrero = 24,
  /// <summary>
  /// A pencils border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPencils))]
  Pencils = 25,
  /// <summary>
  /// A packages border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPackages))]
  Packages = 26,
  /// <summary>
  /// A clocks border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtClocks))]
  Clocks = 27,
  /// <summary>
  /// A fire crackers border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtFirecrackers))]
  Firecrackers = 28,
  /// <summary>
  /// A rings border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtRings))]
  Rings = 29,
  /// <summary>
  /// A map pins border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtMapPins))]
  MapPins = 30,
  /// <summary>
  /// A confetti border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtConfetti))]
  Confetti = 31,
  /// <summary>
  /// A butterfly border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCreaturesButterfly))]
  CreaturesButterfly = 32,
  /// <summary>
  /// A ladybug border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCreaturesLadyBug))]
  CreaturesLadyBug = 33,
  /// <summary>
  /// A fish border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCreaturesFish))]
  CreaturesFish = 34,
  /// <summary>
  /// A birds in flight border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBirdsFlight))]
  BirdsFlight = 35,
  /// <summary>
  /// A scared cat border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtScaredCat))]
  ScaredCat = 36,
  /// <summary>
  /// A bats border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBats))]
  Bats = 37,
  /// <summary>
  /// A rose border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtFlowersRoses))]
  FlowersRoses = 38,
  /// <summary>
  /// A red rose border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtFlowersRedRose))]
  FlowersRedRose = 39,
  /// <summary>
  /// A poinsettias border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPoinsettias))]
  Poinsettias = 40,
  /// <summary>
  /// A holly border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtHolly))]
  Holly = 41,
  /// <summary>
  /// A tiny flower border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtFlowersTiny))]
  FlowersTiny = 42,
  /// <summary>
  /// A pansy border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtFlowersPansy))]
  FlowersPansy = 43,
  /// <summary>
  /// A modern flowers number 2 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtFlowersModern2))]
  FlowersModern2 = 44,
  /// <summary>
  /// A modern flowers number 1 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtFlowersModern1))]
  FlowersModern1 = 45,
  /// <summary>
  /// A white flower border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtWhiteFlowers))]
  WhiteFlowers = 46,
  /// <summary>
  /// A vine border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtVine))]
  Vine = 47,
  /// <summary>
  /// A daisies border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtFlowersDaisies))]
  FlowersDaisies = 48,
  /// <summary>
  /// A block flowers print border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtFlowersBlockPrint))]
  FlowersBlockPrint = 49,
  /// <summary>
  /// A deco arch colored border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtDecoArchColor))]
  DecoArchColor = 50,
  /// <summary>
  /// A fans border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtFans))]
  Fans = 51,
  /// <summary>
  /// A film border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtFilm))]
  Film = 52,
  /// <summary>
  /// A lightning number 1 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtLightning1))]
  Lightning1 = 53,
  /// <summary>
  /// A compass border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCompass))]
  Compass = 54,
  /// <summary>
  /// A double-D border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtDoubleD))]
  DoubleD = 55,
  /// <summary>
  /// A classical wave border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtClassicalWave))]
  ClassicalWave = 56,
  /// <summary>
  /// A shadowed squared border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtShadowedSquares))]
  ShadowedSquares = 57,
  /// <summary>
  /// A twisted lines number 1 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtTwistedLines1))]
  TwistedLines1 = 58,
  /// <summary>
  /// A wave line border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtWaveline))]
  Waveline = 59,
  /// <summary>
  /// A quadrants border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtQuadrants))]
  Quadrants = 60,
  /// <summary>
  /// A checked-bar colored border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCheckedBarColor))]
  CheckedBarColor = 61,
  /// <summary>
  /// A swirling border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtSwirligig))]
  Swirligig = 62,
  /// <summary>
  /// A pushpin note number 1 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPushPinNote1))]
  PushPinNote1 = 63,
  /// <summary>
  /// A pushpin note number 2 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPushPinNote2))]
  PushPinNote2 = 64,
  /// <summary>
  /// A pumpkin number 1 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPumpkin1))]
  Pumpkin1 = 65,
  /// <summary>
  /// A black eggs border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtEggsBlack))]
  EggsBlack = 66,
  /// <summary>
  /// A cup border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCup))]
  Cup = 67,
  /// <summary>
  /// A heart border in shades of gray.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtHeartGray))]
  HeartGray = 68,
  /// <summary>
  /// A gingerbread man border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtGingerbreadMan))]
  GingerbreadMan = 69,
  /// <summary>
  /// A baby pacifier border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBabyPacifier))]
  BabyPacifier = 70,
  /// <summary>
  /// A baby rattle border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBabyRattle))]
  BabyRattle = 71,
  /// <summary>
  /// A cabins border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCabins))]
  Cabins = 72,
  /// <summary>
  /// A funky house border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtHouseFunky))]
  HouseFunky = 73,
  /// <summary>
  /// A black stars border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtStarsBlack))]
  StarsBlack = 74,
  /// <summary>
  /// A snowflake border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtSnowflakes))]
  Snowflakes = 75,
  /// <summary>
  /// A fancy snowflake border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtSnowflakeFancy))]
  SnowflakeFancy = 76,
  /// <summary>
  /// A sky rocket border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtSkyrocket))]
  Skyrocket = 77,
  /// <summary>
  /// A Seattle border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtSeattle))]
  Seattle = 78,
  /// <summary>
  /// A music notes border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtMusicNotes))]
  MusicNotes = 79,
  /// <summary>
  /// A black palms border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPalmsBlack))]
  PalmsBlack = 80,
  /// <summary>
  /// A maple leaf border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtMapleLeaf))]
  MapleLeaf = 81,
  /// <summary>
  /// A paper clips border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPaperClips))]
  PaperClips = 82,
  /// <summary>
  /// A shorebird tracks border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtShorebirdTracks))]
  ShorebirdTracks = 83,
  /// <summary>
  /// A people border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPeople))]
  People = 84,
  /// <summary>
  /// A people waving border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPeopleWaving))]
  PeopleWaving = 85,
  /// <summary>
  /// An eclipsing squares number 2 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtEclipsingSquares2))]
  EclipsingSquares2 = 86,
  /// <summary>
  /// A hypnotic border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtHypnotic))]
  Hypnotic = 87,
  /// <summary>
  /// A diamond border using shades of gray.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtDiamondsGray))]
  DiamondsGray = 88,
  /// <summary>
  /// A deco arch border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtDecoArch))]
  DecoArch = 89,
  /// <summary>
  /// A deco blocks border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtDecoBlocks))]
  DecoBlocks = 90,
  /// <summary>
  /// A circles and lines border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCirclesLines))]
  CirclesLines = 91,
  /// <summary>
  /// A papyrus border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPapyrus))]
  Papyrus = 92,
  /// <summary>
  /// A woodwork border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtWoodwork))]
  Woodwork = 93,
  /// <summary>
  /// A weaving braid border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtWeavingBraid))]
  WeavingBraid = 94,
  /// <summary>
  /// A weaving ribbon border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtWeavingRibbon))]
  WeavingRibbon = 95,
  /// <summary>
  /// A weaving angle border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtWeavingAngles))]
  WeavingAngles = 96,
  /// <summary>
  /// An arched scalloped border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtArchedScallops))]
  ArchedScallops = 97,
  /// <summary>
  /// A safari border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtSafari))]
  Safari = 98,
  /// <summary>
  /// A Celtic knot work border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCelticKnotwork))]
  CelticKnotwork = 99,
  /// <summary>
  /// A crazy maze border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCrazyMaze))]
  CrazyMaze = 100,
  /// <summary>
  /// An eclipsing squares number 1 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtEclipsingSquares1))]
  EclipsingSquares1 = 101,
  /// <summary>
  /// A birds border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBirds))]
  Birds = 102,
  /// <summary>
  /// A teacup border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtFlowersTeacup))]
  FlowersTeacup = 103,
  /// <summary>
  /// A northwest border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtNorthwest))]
  Northwest = 104,
  /// <summary>
  /// A southwest border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtSouthwest))]
  Southwest = 105,
  /// <summary>
  /// A tribal number 6 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtTribal6))]
  Tribal6 = 106,
  /// <summary>
  /// A tribal number 4 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtTribal4))]
  Tribal4 = 107,
  /// <summary>
  /// A tribal number 3 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtTribal3))]
  Tribal3 = 108,
  /// <summary>
  /// A tribal number 2 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtTribal2))]
  Tribal2 = 109,
  /// <summary>
  /// A tribal number 5 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtTribal5))]
  Tribal5 = 110,
  /// <summary>
  /// An X illusion border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtXIllusions))]
  XIllusions = 111,
  /// <summary>
  /// A zany triangle border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtZanyTriangles))]
  ZanyTriangles = 112,
  /// <summary>
  /// A pyramids border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPyramids))]
  Pyramids = 113,
  /// <summary>
  /// An external pyramids border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPyramidsAbove))]
  PyramidsAbove = 114,
  /// <summary>
  /// A confetti border using shades of gray.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtConfettiGrays))]
  ConfettiGrays = 115,
  /// <summary>
  /// A confetti outline border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtConfettiOutline))]
  ConfettiOutline = 116,
  /// <summary>
  /// A confetti white border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtConfettiWhite))]
  ConfettiWhite = 117,
  /// <summary>
  /// A mosaic border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtMosaic))]
  Mosaic = 118,
  /// <summary>
  /// A lightning number 2 border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtLightning2))]
  Lightning2 = 119,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtHeebieJeebies))]
  HeebieJeebies = 120,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtLightBulb))]
  LightBulb = 121,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtGradient))]
  Gradient = 122,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtTriangleParty))]
  TriangleParty = 123,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtTwistedLines2))]
  TwistedLines2 = 124,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtMoons))]
  Moons = 125,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtOvals))]
  Ovals = 126,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtDoubleDiamonds))]
  DoubleDiamonds = 127,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtChainLink))]
  ChainLink = 128,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtTriangles))]
  Triangles = 129,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtTribal1))]
  Tribal1 = 130,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtMarqueeToothed))]
  MarqueeToothed = 131,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtSharksTeeth))]
  SharksTeeth = 132,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtSawtooth))]
  Sawtooth = 133,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtSawtoothGray))]
  SawtoothGray = 134,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtPostageStamp))]
  PostageStamp = 135,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtWeavingStrips))]
  WeavingStrips = 136,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtZigZag))]
  ZigZag = 137,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCrossStitch))]
  CrossStitch = 138,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtGems))]
  Gems = 139,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCirclesRectangles))]
  CirclesRectangles = 140,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCornerTriangles))]
  CornerTriangles = 141,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCreaturesInsects))]
  CreaturesInsects = 142,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtZigZagStitch))]
  ZigZagStitch = 143,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCheckered))]
  Checkered = 144,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCheckedBarBlack))]
  CheckedBarBlack = 145,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtMarquee))]
  Marquee = 146,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBasicWhiteDots))]
  BasicWhiteDots = 147,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBasicWideMidline))]
  BasicWideMidline = 148,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBasicWideOutline))]
  BasicWideOutline = 149,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBasicWideInline))]
  BasicWideInline = 150,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBasicThinLines))]
  BasicThinLines = 151,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBasicWhiteDashes))]
  BasicWhiteDashes = 152,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBasicWhiteSquares))]
  BasicWhiteSquares = 153,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBasicBlackSquares))]
  BasicBlackSquares = 154,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBasicBlackDashes))]
  BasicBlackDashes = 155,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtBasicBlackDots))]
  BasicBlackDots = 156,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtStarsTop))]
  StarsTop = 157,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCertificateBanner))]
  CertificateBanner = 158,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtHandmade1))]
  Handmade1 = 159,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtHandmade2))]
  Handmade2 = 160,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtTornPaper))]
  TornPaper = 161,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtTornPaperBlack))]
  TornPaperBlack = 162,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCouponCutoutDashes))]
  CouponCutoutDashes = 163,
  /// <summary>
  /// Specifies the graphical page border setting of a page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPageBorderArt.wdArtCouponCutoutDots))]
  CouponCutoutDots = 164
}
