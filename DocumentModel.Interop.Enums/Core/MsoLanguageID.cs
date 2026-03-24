
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which language to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolanguageid?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoLanguageID
{
  /// <summary>
  /// Mixed languages.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// No language specified.
  /// </summary>
  None = 0,
  /// <summary>
  /// No proofing requested.
  /// </summary>
  NoProofing = 1024,
  /// <summary>
  /// Afrikaans.
  /// </summary>
  Afrikaans = 1078,
  /// <summary>
  /// Albanian.
  /// </summary>
  Albanian = 1052,
  /// <summary>
  /// Amharic.
  /// </summary>
  Amharic = 1118,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ArabicAlgeria = 5121,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ArabicBahrain = 15361,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ArabicEgypt = 3073,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ArabicIraq = 2049,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ArabicJordan = 11265,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ArabicKuwait = 13313,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ArabicLebanon = 12289,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ArabicLibya = 4097,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ArabicMorocco = 6145,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ArabicOman = 8193,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ArabicQatar = 16385,
  /// <summary>
  /// Arabic.
  /// </summary>
  Arabic = 1025,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ArabicSyria = 10241,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ArabicTunisia = 7169,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ArabicUAE = 14337,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ArabicYemen = 9217,
  /// <summary>
  /// Armenian.
  /// </summary>
  Armenian = 1067,
  /// <summary>
  /// Assamese.
  /// </summary>
  Assamese = 1101,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  AzeriCyrillic = 2092,
  /// <summary>
  /// Azeri-Latin.
  /// </summary>
  AzeriLatin = 1068,
  /// <summary>
  /// Basque.
  /// </summary>
  Basque = 1069,
  /// <summary>
  /// Belarusian.
  /// </summary>
  Byelorussian = 1059,
  /// <summary>
  /// Bengali.
  /// </summary>
  Bengali = 1093,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  Bosnian = 4122,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  BosnianBosniaHerzegovinaCyrillic = 8218,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  BosnianBosniaHerzegovinaLatin = 5146,
  /// <summary>
  /// Bulgarian.
  /// </summary>
  Bulgarian = 1026,
  /// <summary>
  /// Burmese.
  /// </summary>
  Burmese = 1109,
  /// <summary>
  /// Catalan.
  /// </summary>
  Catalan = 1027,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ChineseHongKongSAR = 3076,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ChineseMacaoSAR = 5124,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SimplifiedChinese = 2052,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  ChineseSingapore = 4100,
  /// <summary>
  /// Traditional Chinese.
  /// </summary>
  TraditionalChinese = 1028,
  /// <summary>
  /// Cherokee.
  /// </summary>
  Cherokee = 1116,
  /// <summary>
  /// Croatian.
  /// </summary>
  Croatian = 1050,
  /// <summary>
  /// Czech.
  /// </summary>
  Czech = 1029,
  /// <summary>
  /// Danish.
  /// </summary>
  Danish = 1030,
  /// <summary>
  /// Divehi.
  /// </summary>
  Divehi = 1125,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  BelgianDutch = 2067,
  /// <summary>
  /// Dutch.
  /// </summary>
  Dutch = 1043,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  DzongkhaBhutan = 2129,
  /// <summary>
  /// Edo.
  /// </summary>
  Edo = 1126,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  EnglishAUS = 3081,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  EnglishBelize = 10249,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  EnglishCanadian = 4105,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  EnglishCaribbean = 9225,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  EnglishIndonesia = 14345,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  EnglishIreland = 6153,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  EnglishJamaica = 8201,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  EnglishNewZealand = 5129,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  EnglishPhilippines = 13321,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  EnglishSouthAfrica = 7177,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  EnglishTrinidadTobago = 11273,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  EnglishUK = 2057,
  /// <summary>
  /// English as spoken in the United States.
  /// </summary>
  EnglishUS = 1033,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  EnglishZimbabwe = 12297,
  /// <summary>
  /// Estonian.
  /// </summary>
  Estonian = 1061,
  /// <summary>
  /// Faeroese.
  /// </summary>
  Faeroese = 1080,
  /// <summary>
  /// Farsi.
  /// </summary>
  Farsi = 1065,
  /// <summary>
  /// Filipina.
  /// </summary>
  Filipino = 1124,
  /// <summary>
  /// Finnish.
  /// </summary>
  Finnish = 1035,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  BelgianFrench = 2060,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  FrenchCameroon = 11276,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  FrenchCanadian = 3084,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  FrenchCotedIvoire = 12300,
  /// <summary>
  /// French.
  /// </summary>
  French = 1036,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  FrenchHaiti = 15372,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  FrenchLuxembourg = 5132,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  FrenchMali = 13324,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  FrenchMonaco = 6156,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  FrenchMorocco = 14348,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  FrenchReunion = 8204,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  FrenchSenegal = 10252,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SwissFrench = 4108,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  FrenchWestIndies = 7180,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  FrenchZaire = 9228,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  FrenchCongoDRC = 9228,
  /// <summary>
  /// Frisian as spoken in the Netherlands.
  /// </summary>
  FrisianNetherlands = 1122,
  /// <summary>
  /// Fulfulde.
  /// </summary>
  Fulfulde = 1127,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  GaelicIreland = 2108,
  /// <summary>
  /// Gaelic as spoken in Scotland.
  /// </summary>
  GaelicScotland = 1084,
  /// <summary>
  /// Galician.
  /// </summary>
  Galician = 1110,
  /// <summary>
  /// Georgian.
  /// </summary>
  Georgian = 1079,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  GermanAustria = 3079,
  /// <summary>
  /// German.
  /// </summary>
  German = 1031,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  GermanLiechtenstein = 5127,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  GermanLuxembourg = 4103,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SwissGerman = 2055,
  /// <summary>
  /// Greek.
  /// </summary>
  Greek = 1032,
  /// <summary>
  /// Guarani.
  /// </summary>
  Guarani = 1140,
  /// <summary>
  /// Gujarati.
  /// </summary>
  Gujarati = 1095,
  /// <summary>
  /// Hausa.
  /// </summary>
  Hausa = 1128,
  /// <summary>
  /// Hawaiian.
  /// </summary>
  Hawaiian = 1141,
  /// <summary>
  /// Hebrew.
  /// </summary>
  Hebrew = 1037,
  /// <summary>
  /// Hindi.
  /// </summary>
  Hindi = 1081,
  /// <summary>
  /// Hungarian.
  /// </summary>
  Hungarian = 1038,
  /// <summary>
  /// Ibibio.
  /// </summary>
  Ibibio = 1129,
  /// <summary>
  /// Icelandic.
  /// </summary>
  Icelandic = 1039,
  /// <summary>
  /// Igbo.
  /// </summary>
  Igbo = 1136,
  /// <summary>
  /// Indonesian.
  /// </summary>
  Indonesian = 1057,
  /// <summary>
  /// Inuktitut.
  /// </summary>
  Inuktitut = 1117,
  /// <summary>
  /// Italian.
  /// </summary>
  Italian = 1040,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SwissItalian = 2064,
  /// <summary>
  /// Japanese.
  /// </summary>
  Japanese = 1041,
  /// <summary>
  /// Kannada.
  /// </summary>
  Kannada = 1099,
  /// <summary>
  /// Kanuri.
  /// </summary>
  Kanuri = 1137,
  /// <summary>
  /// Kashmiri.
  /// </summary>
  Kashmiri = 1120,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  KashmiriDevanagari = 2144,
  /// <summary>
  /// Kazakh.
  /// </summary>
  Kazakh = 1087,
  /// <summary>
  /// Khmer.
  /// </summary>
  Khmer = 1107,
  /// <summary>
  /// Kirghiz.
  /// </summary>
  Kirghiz = 1088,
  /// <summary>
  /// Konkani.
  /// </summary>
  Konkani = 1111,
  /// <summary>
  /// Korean.
  /// </summary>
  Korean = 1042,
  /// <summary>
  /// Kyrgyz.
  /// </summary>
  Kyrgyz = 1088,
  /// <summary>
  /// Latin.
  /// </summary>
  Latin = 1142,
  /// <summary>
  /// Lao.
  /// </summary>
  Lao = 1108,
  /// <summary>
  /// Latvian.
  /// </summary>
  Latvian = 1062,
  /// <summary>
  /// Lithuanian.
  /// </summary>
  Lithuanian = 1063,
  /// <summary>
  /// Macedonian.
  /// </summary>
  Macedonian = 1071,
  /// <summary>
  /// Macedonian FYROM language.
  /// </summary>
  MacedonianFYROM = 1071,
  /// <summary>
  /// Malaysian.
  /// </summary>
  Malaysian = 1086,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  MalayBruneiDarussalam = 2110,
  /// <summary>
  /// Malayalam.
  /// </summary>
  Malayalam = 1100,
  /// <summary>
  /// Maltese.
  /// </summary>
  Maltese = 1082,
  /// <summary>
  /// Manipuri.
  /// </summary>
  Manipuri = 1112,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  Maori = 1153,
  /// <summary>
  /// Marathi.
  /// </summary>
  Marathi = 1102,
  /// <summary>
  /// Mongolian.
  /// </summary>
  Mongolian = 1104,
  /// <summary>
  /// Nepali.
  /// </summary>
  Nepali = 1121,
  /// <summary>
  /// Bokmol as spoken in Norway.
  /// </summary>
  NorwegianBokmol = 1044,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  NorwegianNynorsk = 2068,
  /// <summary>
  /// Oriya.
  /// </summary>
  Oriya = 1096,
  /// <summary>
  /// Oromo.
  /// </summary>
  Oromo = 1138,
  /// <summary>
  /// Pashto.
  /// </summary>
  Pashto = 1123,
  /// <summary>
  /// Polish.
  /// </summary>
  Polish = 1045,
  /// <summary>
  /// Brazilian Portuguese.
  /// </summary>
  BrazilianPortuguese = 1046,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  Portuguese = 2070,
  /// <summary>
  /// Punjabi.
  /// </summary>
  Punjabi = 1094,
  /// <summary>
  /// Quechua as spoken in Bolivia.
  /// </summary>
  QuechuaBolivia = 1131,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  QuechuaEcuador = 2155,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  QuechuaPeru = 3179,
  /// <summary>
  /// Rhaeto-Romanic.
  /// </summary>
  RhaetoRomanic = 1047,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  RomanianMoldova = 2072,
  /// <summary>
  /// Romanian.
  /// </summary>
  Romanian = 1048,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  RussianMoldova = 2073,
  /// <summary>
  /// Russian.
  /// </summary>
  Russian = 1049,
  /// <summary>
  /// Sami/Lappish.
  /// </summary>
  SamiLappish = 1083,
  /// <summary>
  /// Sanskrit.
  /// </summary>
  Sanskrit = 1103,
  /// <summary>
  /// Sepedi.
  /// </summary>
  Sepedi = 1132,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SerbianBosniaHerzegovinaCyrillic = 7194,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SerbianBosniaHerzegovinaLatin = 6170,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SerbianCyrillic = 3098,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SerbianLatin = 2074,
  /// <summary>
  /// Sesotho.
  /// </summary>
  Sesotho = 1072,
  /// <summary>
  /// Sindhi.
  /// </summary>
  Sindhi = 1113,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SindhiPakistan = 2137,
  /// <summary>
  /// Sinhalese.
  /// </summary>
  Sinhalese = 1115,
  /// <summary>
  /// Slovak.
  /// </summary>
  Slovak = 1051,
  /// <summary>
  /// Slovenian.
  /// </summary>
  Slovenian = 1060,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  Somali = 1143,
  /// <summary>
  /// Sorbian.
  /// </summary>
  Sorbian = 1070,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishArgentina = 11274,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishBolivia = 16394,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishChile = 13322,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishColombia = 9226,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishCostaRica = 5130,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishDominicanRepublic = 7178,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishEcuador = 12298,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishElSalvador = 17418,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishGuatemala = 4106,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishHonduras = 18442,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  MexicanSpanish = 2058,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishNicaragua = 19466,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishPanama = 6154,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishParaguay = 15370,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishPeru = 10250,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishPuertoRico = 20490,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishModernSort = 3082,
  /// <summary>
  /// Spanish. public enum class MsoLanguageID
  /// </summary>
  Spanish = 1034,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishUruguay = 14346,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SpanishVenezuela = 8202,
  /// <summary>
  /// Sutu.
  /// </summary>
  Sutu = 1072,
  /// <summary>
  /// Swahili.
  /// </summary>
  Swahili = 1089,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  SwedishFinland = 2077,
  /// <summary>
  /// Swedish.
  /// </summary>
  Swedish = 1053,
  /// <summary>
  /// Syriac.
  /// </summary>
  Syriac = 1114,
  /// <summary>
  /// Tajik.
  /// </summary>
  Tajik = 1064,
  /// <summary>
  /// Tamil.
  /// </summary>
  Tamil = 1097,
  /// <summary>
  /// Tamazight.
  /// </summary>
  Tamazight = 1119,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  TamazightLatin = 2143,
  /// <summary>
  /// Tatar.
  /// </summary>
  Tatar = 1092,
  /// <summary>
  /// Telugu.
  /// </summary>
  Telugu = 1098,
  /// <summary>
  /// Thai.
  /// </summary>
  Thai = 1054,
  /// <summary>
  /// Tibetan.
  /// </summary>
  Tibetan = 1105,
  /// <summary>
  /// Tigrigna as spoken in Ethiopia.
  /// </summary>
  TigrignaEthiopic = 1139,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  TigrignaEritrea = 2163,
  /// <summary>
  /// Tsonga.
  /// </summary>
  Tsonga = 1073,
  /// <summary>
  /// Tswana.
  /// </summary>
  Tswana = 1074,
  /// <summary>
  /// Turkish.
  /// </summary>
  Turkish = 1055,
  /// <summary>
  /// Turkmen.
  /// </summary>
  Turkmen = 1090,
  /// <summary>
  /// Ukrainian.
  /// </summary>
  Ukrainian = 1058,
  /// <summary>
  /// Urdu.
  /// </summary>
  Urdu = 1056,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  UzbekCyrillic = 2115,
  /// <summary>
  /// Uzbek (Latin).
  /// </summary>
  UzbekLatin = 1091,
  /// <summary>
  /// Venda.
  /// </summary>
  Venda = 1075,
  /// <summary>
  /// Vietnamese.
  /// </summary>
  Vietnamese = 1066,
  /// <summary>
  /// Welsh.
  /// </summary>
  Welsh = 1106,
  /// <summary>
  /// Xhosa.
  /// </summary>
  Xhosa = 1076,
  /// <summary>
  /// Specifies which language to use.
  /// </summary>
  Yi = 1144,
  /// <summary>
  /// Yiddish.
  /// </summary>
  Yiddish = 1085,
  /// <summary>
  /// Yoruba.
  /// </summary>
  Yoruba = 1130,
  /// <summary>
  /// Zulu.
  /// </summary>
  Zulu = 1077
}
