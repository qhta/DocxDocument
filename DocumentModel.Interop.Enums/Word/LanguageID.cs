namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the language to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlanguageid?view=office-pia` for Office interop details.
/// </remarks>
public enum LanguageID
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
  /// United States English language.
  /// </summary>
  EnglishUS = 1033,
  /// <summary>
  /// Spanish language.
  /// </summary>
  Spanish = 1034,
  /// <summary>
  /// Finnish language.
  /// </summary>
  Finnish = 1035,
  /// <summary>
  /// French language.
  /// </summary>
  French = 1036,
  /// <summary>
  /// Hebrew language.
  /// </summary>
  Hebrew = 1037,
  /// <summary>
  /// Hungarian language.
  /// </summary>
  Hungarian = 1038,
  /// <summary>
  /// Icelandic language.
  /// </summary>
  Icelandic = 1039,
  /// <summary>
  /// Italian language.
  /// </summary>
  Italian = 1040,
  /// <summary>
  /// Japanese language.
  /// </summary>
  Japanese = 1041,
  /// <summary>
  /// Korean language.
  /// </summary>
  Korean = 1042,
  /// <summary>
  /// Dutch language.
  /// </summary>
  Dutch = 1043,
  /// <summary>
  /// Norwegian Bokmol language.
  /// </summary>
  NorwegianBokmol = 1044,
  /// <summary>
  /// Polish language.
  /// </summary>
  Polish = 1045,
  /// <summary>
  /// Portuguese (Brazil) language.
  /// </summary>
  PortugueseBrazil = 1046,
  /// <summary>
  /// Rhaeto Romanic language.
  /// </summary>
  RhaetoRomanic = 1047,
  /// <summary>
  /// Romanian language.
  /// </summary>
  Romanian = 1048,
  /// <summary>
  /// Russian language.
  /// </summary>
  Russian = 1049,
  /// <summary>
  /// Croatian language.
  /// </summary>
  Croatian = 1050,
  /// <summary>
  /// Slovakian language.
  /// </summary>
  Slovak = 1051,
  /// <summary>
  /// Albanian language.
  /// </summary>
  Albanian = 1052,
  /// <summary>
  /// Swedish language.
  /// </summary>
  Swedish = 1053,
  /// <summary>
  /// Thai language.
  /// </summary>
  Thai = 1054,
  /// <summary>
  /// Turkish language.
  /// </summary>
  Turkish = 1055,
  /// <summary>
  /// Urdu language.
  /// </summary>
  Urdu = 1056,
  /// <summary>
  /// Indonesian language.
  /// </summary>
  Indonesian = 1057,
  /// <summary>
  /// Ukrainian language.
  /// </summary>
  Ukrainian = 1058,
  /// <summary>
  /// Belarusian language.
  /// </summary>
  Byelorussian = 1059,
  /// <summary>
  /// Slovenian language.
  /// </summary>
  Slovenian = 1060,
  /// <summary>
  /// Estonian language.
  /// </summary>
  Estonian = 1061,
  /// <summary>
  /// Latvian language.
  /// </summary>
  Latvian = 1062,
  /// <summary>
  /// Lithuanian language.
  /// </summary>
  Lithuanian = 1063,
  /// <summary>
  /// Tajik language.
  /// </summary>
  Tajik = 1064,
  /// <summary>
  /// Persian language.
  /// </summary>
  Persian = 1065,
  /// <summary>
  /// Vietnamese language.
  /// </summary>
  Vietnamese = 1066,
  /// <summary>
  /// Armenian language.
  /// </summary>
  Armenian = 1067,
  /// <summary>
  /// Azeri Latin language.
  /// </summary>
  AzeriLatin = 1068,
  /// <summary>
  /// Basque language.
  /// </summary>
  Basque = 1069,
  /// <summary>
  /// Sorbian language.
  /// </summary>
  Sorbian = 1070,
  /// <summary>
  /// Macedonian (FYROM) language.
  /// </summary>
  MacedonianFYROM = 1071,
  /// <summary>
  /// Sutu language.
  /// </summary>
  Sutu = 1072,
  /// <summary>
  /// Sesotho language.
  /// </summary>
  Sesotho = 1072,
  /// <summary>
  /// Tsonga language.
  /// </summary>
  Tsonga = 1073,
  /// <summary>
  /// Tswana language.
  /// </summary>
  Tswana = 1074,
  /// <summary>
  /// Venda language.
  /// </summary>
  Venda = 1075,
  /// <summary>
  /// Xhosa language.
  /// </summary>
  Xhosa = 1076,
  /// <summary>
  /// Zulu language.
  /// </summary>
  Zulu = 1077,
  /// <summary>
  /// African language.
  /// </summary>
  Afrikaans = 1078,
  /// <summary>
  /// Georgian language.
  /// </summary>
  Georgian = 1079,
  /// <summary>
  /// Faeroese language.
  /// </summary>
  Faeroese = 1080,
  /// <summary>
  /// Hindi language.
  /// </summary>
  Hindi = 1081,
  /// <summary>
  /// Maltese language.
  /// </summary>
  Maltese = 1082,
  /// <summary>
  /// Sami Lappish language.
  /// </summary>
  SamiLappish = 1083,
  /// <summary>
  /// Gaelic Scottish language.
  /// </summary>
  GaelicScotland = 1084,
  /// <summary>
  /// Yiddish language.
  /// </summary>
  Yiddish = 1085,
  /// <summary>
  /// Malaysian language.
  /// </summary>
  Malaysian = 1086,
  /// <summary>
  /// Kazakh language.
  /// </summary>
  Kazakh = 1087,
  /// <summary>
  /// Kyrgyz language.
  /// </summary>
  Kyrgyz = 1088,
  /// <summary>
  /// Kirghiz language.
  /// </summary>
  Kirghiz = 1088,
  /// <summary>
  /// Swahili language.
  /// </summary>
  Swahili = 1089,
  /// <summary>
  /// Turkmen language.
  /// </summary>
  Turkmen = 1090,
  /// <summary>
  /// Uzbek Latin language.
  /// </summary>
  UzbekLatin = 1091,
  /// <summary>
  /// Tatar language.
  /// </summary>
  Tatar = 1092,
  /// <summary>
  /// Bengali language.
  /// </summary>
  Bengali = 1093,
  /// <summary>
  /// Punjabi language.
  /// </summary>
  Punjabi = 1094,
  /// <summary>
  /// Gujarati language.
  /// </summary>
  Gujarati = 1095,
  /// <summary>
  /// Oriya language.
  /// </summary>
  Oriya = 1096,
  /// <summary>
  /// Tamil language.
  /// </summary>
  Tamil = 1097,
  /// <summary>
  /// Telugu language.
  /// </summary>
  Telugu = 1098,
  /// <summary>
  /// Kannada language.
  /// </summary>
  Kannada = 1099,
  /// <summary>
  /// Malayalam language.
  /// </summary>
  Malayalam = 1100,
  /// <summary>
  /// Assamese language.
  /// </summary>
  Assamese = 1101,
  /// <summary>
  /// Marathi language.
  /// </summary>
  Marathi = 1102,
  /// <summary>
  /// Sanskrit language.
  /// </summary>
  Sanskrit = 1103,
  /// <summary>
  /// Mongolian language.
  /// </summary>
  Mongolian = 1104,
  /// <summary>
  /// Tibetan language.
  /// </summary>
  Tibetan = 1105,
  /// <summary>
  /// Welsh language.
  /// </summary>
  Welsh = 1106,
  /// <summary>
  /// Khmer language.
  /// </summary>
  Khmer = 1107,
  /// <summary>
  /// Lao language.
  /// </summary>
  Lao = 1108,
  /// <summary>
  /// Burmese language.
  /// </summary>
  Burmese = 1109,
  /// <summary>
  /// Galician language.
  /// </summary>
  Galician = 1110,
  /// <summary>
  /// Konkani language.
  /// </summary>
  Konkani = 1111,
  /// <summary>
  /// Manipuri language.
  /// </summary>
  Manipuri = 1112,
  /// <summary>
  /// Sindhi language.
  /// </summary>
  Sindhi = 1113,
  /// <summary>
  /// Syriac language.
  /// </summary>
  Syriac = 1114,
  /// <summary>
  /// Sinhalese language.
  /// </summary>
  Sinhalese = 1115,
  /// <summary>
  /// Cherokee language.
  /// </summary>
  Cherokee = 1116,
  /// <summary>
  /// Inuktitut language.
  /// </summary>
  Inuktitut = 1117,
  /// <summary>
  /// Amharic language.
  /// </summary>
  Amharic = 1118,
  /// <summary>
  /// Tamazight language.
  /// </summary>
  Tamazight = 1119,
  /// <summary>
  /// Kashmiri language.
  /// </summary>
  Kashmiri = 1120,
  /// <summary>
  /// Nepali language.
  /// </summary>
  Nepali = 1121,
  /// <summary>
  /// Frisian Netherlands language.
  /// </summary>
  FrisianNetherlands = 1122,
  /// <summary>
  /// Pashto language.
  /// </summary>
  Pashto = 1123,
  /// <summary>
  /// Filipino language.
  /// </summary>
  Filipino = 1124,
  /// <summary>
  /// Divehi language.
  /// </summary>
  Divehi = 1125,
  /// <summary>
  /// Edo language.
  /// </summary>
  Edo = 1126,
  /// <summary>
  /// Fulfulde language.
  /// </summary>
  Fulfulde = 1127,
  /// <summary>
  /// Hausa language.
  /// </summary>
  Hausa = 1128,
  /// <summary>
  /// Ibibio language.
  /// </summary>
  Ibibio = 1129,
  /// <summary>
  /// Yoruba language.
  /// </summary>
  Yoruba = 1130,
  /// <summary>
  /// Igbo language.
  /// </summary>
  Igbo = 1136,
  /// <summary>
  /// Kanuri language.
  /// </summary>
  Kanuri = 1137,
  /// <summary>
  /// Oromo language.
  /// </summary>
  Oromo = 1138,
  /// <summary>
  /// Tigrigna Ethiopic language.
  /// </summary>
  TigrignaEthiopic = 1139,
  /// <summary>
  /// Guarani language.
  /// </summary>
  Guarani = 1140,
  /// <summary>
  /// Hawaiian language.
  /// </summary>
  Hawaiian = 1141,
  /// <summary>
  /// Latin language.
  /// </summary>
  Latin = 1142,
  /// <summary>
  /// Somali language.
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
  /// Portuguese (Brazil) language.
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
