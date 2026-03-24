namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the language to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlanguageid?view=office-pia` for Office interop details.
/// </remarks>
public enum WdLanguageID
{
  /// <summary>
  /// No specified language.
  /// </summary>
  LanguageNone = 0,
  /// <summary>
  /// Disables proofing if the language ID identifies a language in which an object is grammatically validated using
  /// the Word proofing tools.
  /// </summary>
  NoProofing = 1024,
  /// <summary>
  /// Arabic language.
  /// </summary>
  Arabic = 1025,
  /// <summary>
  /// Bulgarian language.
  /// </summary>
  Bulgarian = 1026,
  /// <summary>
  /// Catalan language.
  /// </summary>
  Catalan = 1027,
  /// <summary>
  /// Traditional Chinese language.
  /// </summary>
  TraditionalChinese = 1028,
  /// <summary>
  /// Czech language.
  /// </summary>
  Czech = 1029,
  /// <summary>
  /// Danish language.
  /// </summary>
  Danish = 1030,
  /// <summary>
  /// German language.
  /// </summary>
  German = 1031,
  /// <summary>
  /// Greek language.
  /// </summary>
  Greek = 1032,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishUS = 1033,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Spanish = 1034,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Finnish = 1035,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  French = 1036,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Hebrew = 1037,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Hungarian = 1038,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Icelandic = 1039,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Italian = 1040,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Japanese = 1041,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Korean = 1042,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Dutch = 1043,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  NorwegianBokmol = 1044,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Polish = 1045,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  PortugueseBrazil = 1046,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  RhaetoRomanic = 1047,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Romanian = 1048,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Russian = 1049,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Croatian = 1050,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Slovak = 1051,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Albanian = 1052,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Swedish = 1053,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Thai = 1054,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Turkish = 1055,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Urdu = 1056,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Indonesian = 1057,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Ukrainian = 1058,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Byelorussian = 1059,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Slovenian = 1060,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Estonian = 1061,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Latvian = 1062,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Lithuanian = 1063,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Tajik = 1064,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Persian = 1065,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Vietnamese = 1066,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Armenian = 1067,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  AzeriLatin = 1068,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Basque = 1069,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Sorbian = 1070,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  MacedonianFYROM = 1071,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Sutu = 1072,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Sesotho = 1072,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Tsonga = 1073,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Tswana = 1074,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Venda = 1075,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Xhosa = 1076,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Zulu = 1077,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Afrikaans = 1078,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Georgian = 1079,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Faeroese = 1080,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Hindi = 1081,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Maltese = 1082,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SamiLappish = 1083,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  GaelicScotland = 1084,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Yiddish = 1085,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Malaysian = 1086,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Kazakh = 1087,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Kyrgyz = 1088,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Kirghiz = 1088,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Swahili = 1089,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Turkmen = 1090,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  UzbekLatin = 1091,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Tatar = 1092,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Bengali = 1093,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Punjabi = 1094,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Gujarati = 1095,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Oriya = 1096,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Tamil = 1097,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Telugu = 1098,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Kannada = 1099,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Malayalam = 1100,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Assamese = 1101,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Marathi = 1102,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Sanskrit = 1103,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Mongolian = 1104,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Tibetan = 1105,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Welsh = 1106,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Khmer = 1107,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Lao = 1108,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Burmese = 1109,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Galician = 1110,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Konkani = 1111,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Manipuri = 1112,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Sindhi = 1113,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Syriac = 1114,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Sinhalese = 1115,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Cherokee = 1116,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Inuktitut = 1117,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Amharic = 1118,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Tamazight = 1119,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Kashmiri = 1120,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Nepali = 1121,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrisianNetherlands = 1122,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Pashto = 1123,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Filipino = 1124,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Divehi = 1125,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Edo = 1126,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Fulfulde = 1127,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Hausa = 1128,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Ibibio = 1129,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Yoruba = 1130,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Igbo = 1136,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Kanuri = 1137,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Oromo = 1138,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  TigrignaEthiopic = 1139,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Guarani = 1140,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Hawaiian = 1141,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Latin = 1142,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Somali = 1143,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Yi = 1144,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicIraq = 2049,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SimplifiedChinese = 2052,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SwissGerman = 2055,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishUK = 2057,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  MexicanSpanish = 2058,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  BelgianFrench = 2060,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SwissItalian = 2064,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  BelgianDutch = 2067,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  NorwegianNynorsk = 2068,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Portuguese = 2070,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  RomanianMoldova = 2072,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  RussianMoldova = 2073,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SerbianLatin = 2074,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SwedishFinland = 2077,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  AzeriCyrillic = 2092,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  GaelicIreland = 2108,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  MalayBruneiDarussalam = 2110,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  UzbekCyrillic = 2115,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SindhiPakistan = 2137,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  TamazightLatin = 2143,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  TigrignaEritrea = 2163,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicEgypt = 3073,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ChineseHongKongSAR = 3076,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  GermanAustria = 3079,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishAUS = 3081,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishModernSort = 3082,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchCanadian = 3084,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SerbianCyrillic = 3098,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicLibya = 4097,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ChineseSingapore = 4100,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  GermanLuxembourg = 4103,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishCanadian = 4105,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishGuatemala = 4106,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SwissFrench = 4108,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicAlgeria = 5121,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ChineseMacaoSAR = 5124,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  GermanLiechtenstein = 5127,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishNewZealand = 5129,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishCostaRica = 5130,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchLuxembourg = 5132,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicMorocco = 6145,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishIreland = 6153,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishPanama = 6154,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchMonaco = 6156,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicTunisia = 7169,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishSouthAfrica = 7177,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishDominicanRepublic = 7178,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchWestIndies = 7180,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicOman = 8193,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishJamaica = 8201,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishVenezuela = 8202,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchReunion = 8204,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicYemen = 9217,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishCaribbean = 9225,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishColombia = 9226,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchCongoDRC = 9228,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicSyria = 10241,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishBelize = 10249,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishPeru = 10250,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchSenegal = 10252,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicJordan = 11265,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishTrinidadTobago = 11273,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishArgentina = 11274,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchCameroon = 11276,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicLebanon = 12289,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishZimbabwe = 12297,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishEcuador = 12298,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchCotedIvoire = 12300,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicKuwait = 13313,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishPhilippines = 13321,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishChile = 13322,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchMali = 13324,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicUAE = 14337,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishIndonesia = 14345,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishUruguay = 14346,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchMorocco = 14348,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicBahrain = 15361,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishParaguay = 15370,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchHaiti = 15372,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicQatar = 16385,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishBolivia = 16394,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishElSalvador = 17418,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishHonduras = 18442,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishNicaragua = 19466,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishPuertoRico = 20490
}
