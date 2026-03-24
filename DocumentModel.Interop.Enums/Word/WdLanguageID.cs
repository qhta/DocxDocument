namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the language to use.
/// </summary>
public enum WdLanguageID
{
  /// <summary>
  /// No specified language.
  /// </summary>
  LanguageNone = unchecked((int)0),
  /// <summary>
  /// Disables proofing if the language ID identifies a language in which an object is grammatically validated using
  /// the Word proofing tools.
  /// </summary>
  NoProofing = unchecked((int)1024),
  /// <summary>
  /// Arabic language.
  /// </summary>
  Arabic = unchecked((int)1025),
  /// <summary>
  /// Bulgarian language.
  /// </summary>
  Bulgarian = unchecked((int)1026),
  /// <summary>
  /// Catalan language.
  /// </summary>
  Catalan = unchecked((int)1027),
  /// <summary>
  /// Traditional Chinese language.
  /// </summary>
  TraditionalChinese = unchecked((int)1028),
  /// <summary>
  /// Czech language.
  /// </summary>
  Czech = unchecked((int)1029),
  /// <summary>
  /// Danish language.
  /// </summary>
  Danish = unchecked((int)1030),
  /// <summary>
  /// German language.
  /// </summary>
  German = unchecked((int)1031),
  /// <summary>
  /// Greek language. [System.Runtime.InteropServices.Guid("1614FDAC-2173-3FB1-ADD3-1A35B81F8897")] public enum
  /// WdLanguageID ﾉ Expand table
  /// </summary>
  Greek = unchecked((int)1032),
  /// <summary>
  /// United States English language.
  /// </summary>
  EnglishUS = unchecked((int)1033),
  /// <summary>
  /// Spanish language.
  /// </summary>
  Spanish = unchecked((int)1034),
  /// <summary>
  /// Finnish language.
  /// </summary>
  Finnish = unchecked((int)1035),
  /// <summary>
  /// French language.
  /// </summary>
  French = unchecked((int)1036),
  /// <summary>
  /// Hebrew language.
  /// </summary>
  Hebrew = unchecked((int)1037),
  /// <summary>
  /// Hungarian language.
  /// </summary>
  Hungarian = unchecked((int)1038),
  /// <summary>
  /// Icelandic language.
  /// </summary>
  Icelandic = unchecked((int)1039),
  /// <summary>
  /// Italian language.
  /// </summary>
  Italian = unchecked((int)1040),
  /// <summary>
  /// Japanese language.
  /// </summary>
  Japanese = unchecked((int)1041),
  /// <summary>
  /// Korean language.
  /// </summary>
  Korean = unchecked((int)1042),
  /// <summary>
  /// Dutch language.
  /// </summary>
  Dutch = unchecked((int)1043),
  /// <summary>
  /// Norwegian Bokmol language.
  /// </summary>
  NorwegianBokmol = unchecked((int)1044),
  /// <summary>
  /// Polish language.
  /// </summary>
  Polish = unchecked((int)1045),
  /// <summary>
  /// Portuguese (Brazil) language.
  /// </summary>
  PortugueseBrazil = unchecked((int)1046),
  /// <summary>
  /// Rhaeto Romanic language.
  /// </summary>
  RhaetoRomanic = unchecked((int)1047),
  /// <summary>
  /// Romanian language.
  /// </summary>
  Romanian = unchecked((int)1048),
  /// <summary>
  /// Russian language.
  /// </summary>
  Russian = unchecked((int)1049),
  /// <summary>
  /// Croatian language.
  /// </summary>
  Croatian = unchecked((int)1050),
  /// <summary>
  /// Slovakian language.
  /// </summary>
  Slovak = unchecked((int)1051),
  /// <summary>
  /// Albanian language.
  /// </summary>
  Albanian = unchecked((int)1052),
  /// <summary>
  /// Swedish language.
  /// </summary>
  Swedish = unchecked((int)1053),
  /// <summary>
  /// Thai language.
  /// </summary>
  Thai = unchecked((int)1054),
  /// <summary>
  /// Turkish language.
  /// </summary>
  Turkish = unchecked((int)1055),
  /// <summary>
  /// Urdu language.
  /// </summary>
  Urdu = unchecked((int)1056),
  /// <summary>
  /// Indonesian language.
  /// </summary>
  Indonesian = unchecked((int)1057),
  /// <summary>
  /// Ukrainian language.
  /// </summary>
  Ukrainian = unchecked((int)1058),
  /// <summary>
  /// Belarusian language.
  /// </summary>
  Byelorussian = unchecked((int)1059),
  /// <summary>
  /// Slovenian language.
  /// </summary>
  Slovenian = unchecked((int)1060),
  /// <summary>
  /// Estonian language.
  /// </summary>
  Estonian = unchecked((int)1061),
  /// <summary>
  /// Latvian language.
  /// </summary>
  Latvian = unchecked((int)1062),
  /// <summary>
  /// Lithuanian language.
  /// </summary>
  Lithuanian = unchecked((int)1063),
  /// <summary>
  /// Tajik language.
  /// </summary>
  Tajik = unchecked((int)1064),
  /// <summary>
  /// Persian language.
  /// </summary>
  Persian = unchecked((int)1065),
  /// <summary>
  /// Vietnamese language.
  /// </summary>
  Vietnamese = unchecked((int)1066),
  /// <summary>
  /// Armenian language.
  /// </summary>
  Armenian = unchecked((int)1067),
  /// <summary>
  /// Azeri Latin language.
  /// </summary>
  AzeriLatin = unchecked((int)1068),
  /// <summary>
  /// Basque language.
  /// </summary>
  Basque = unchecked((int)1069),
  /// <summary>
  /// Sorbian language.
  /// </summary>
  Sorbian = unchecked((int)1070),
  /// <summary>
  /// Macedonian (FYROM) language.
  /// </summary>
  MacedonianFYROM = unchecked((int)1071),
  /// <summary>
  /// Sutu language.
  /// </summary>
  Sutu = unchecked((int)1072),
  /// <summary>
  /// Sesotho language.
  /// </summary>
  Sesotho = unchecked((int)1072),
  /// <summary>
  /// Tsonga language.
  /// </summary>
  Tsonga = unchecked((int)1073),
  /// <summary>
  /// Tswana language.
  /// </summary>
  Tswana = unchecked((int)1074),
  /// <summary>
  /// Venda language.
  /// </summary>
  Venda = unchecked((int)1075),
  /// <summary>
  /// Xhosa language.
  /// </summary>
  Xhosa = unchecked((int)1076),
  /// <summary>
  /// Zulu language.
  /// </summary>
  Zulu = unchecked((int)1077),
  /// <summary>
  /// African language.
  /// </summary>
  Afrikaans = unchecked((int)1078),
  /// <summary>
  /// Georgian language.
  /// </summary>
  Georgian = unchecked((int)1079),
  /// <summary>
  /// Faeroese language.
  /// </summary>
  Faeroese = unchecked((int)1080),
  /// <summary>
  /// Hindi language.
  /// </summary>
  Hindi = unchecked((int)1081),
  /// <summary>
  /// Maltese language.
  /// </summary>
  Maltese = unchecked((int)1082),
  /// <summary>
  /// Sami Lappish language.
  /// </summary>
  SamiLappish = unchecked((int)1083),
  /// <summary>
  /// Gaelic Scottish language.
  /// </summary>
  GaelicScotland = unchecked((int)1084),
  /// <summary>
  /// Yiddish language.
  /// </summary>
  Yiddish = unchecked((int)1085),
  /// <summary>
  /// Malaysian language.
  /// </summary>
  Malaysian = unchecked((int)1086),
  /// <summary>
  /// Kazakh language.
  /// </summary>
  Kazakh = unchecked((int)1087),
  /// <summary>
  /// Kyrgyz language.
  /// </summary>
  Kyrgyz = unchecked((int)1088),
  /// <summary>
  /// Kirghiz language.
  /// </summary>
  Kirghiz = unchecked((int)1088),
  /// <summary>
  /// Swahili language.
  /// </summary>
  Swahili = unchecked((int)1089),
  /// <summary>
  /// Turkmen language.
  /// </summary>
  Turkmen = unchecked((int)1090),
  /// <summary>
  /// Uzbek Latin language.
  /// </summary>
  UzbekLatin = unchecked((int)1091),
  /// <summary>
  /// Tatar language.
  /// </summary>
  Tatar = unchecked((int)1092),
  /// <summary>
  /// Bengali language.
  /// </summary>
  Bengali = unchecked((int)1093),
  /// <summary>
  /// Punjabi language.
  /// </summary>
  Punjabi = unchecked((int)1094),
  /// <summary>
  /// Gujarati language.
  /// </summary>
  Gujarati = unchecked((int)1095),
  /// <summary>
  /// Oriya language.
  /// </summary>
  Oriya = unchecked((int)1096),
  /// <summary>
  /// Tamil language.
  /// </summary>
  Tamil = unchecked((int)1097),
  /// <summary>
  /// Telugu language.
  /// </summary>
  Telugu = unchecked((int)1098),
  /// <summary>
  /// Kannada language.
  /// </summary>
  Kannada = unchecked((int)1099),
  /// <summary>
  /// Malayalam language.
  /// </summary>
  Malayalam = unchecked((int)1100),
  /// <summary>
  /// Assamese language.
  /// </summary>
  Assamese = unchecked((int)1101),
  /// <summary>
  /// Marathi language.
  /// </summary>
  Marathi = unchecked((int)1102),
  /// <summary>
  /// Sanskrit language.
  /// </summary>
  Sanskrit = unchecked((int)1103),
  /// <summary>
  /// Mongolian language.
  /// </summary>
  Mongolian = unchecked((int)1104),
  /// <summary>
  /// Tibetan language.
  /// </summary>
  Tibetan = unchecked((int)1105),
  /// <summary>
  /// Welsh language.
  /// </summary>
  Welsh = unchecked((int)1106),
  /// <summary>
  /// Khmer language.
  /// </summary>
  Khmer = unchecked((int)1107),
  /// <summary>
  /// Lao language.
  /// </summary>
  Lao = unchecked((int)1108),
  /// <summary>
  /// Burmese language.
  /// </summary>
  Burmese = unchecked((int)1109),
  /// <summary>
  /// Galician language.
  /// </summary>
  Galician = unchecked((int)1110),
  /// <summary>
  /// Konkani language.
  /// </summary>
  Konkani = unchecked((int)1111),
  /// <summary>
  /// Manipuri language.
  /// </summary>
  Manipuri = unchecked((int)1112),
  /// <summary>
  /// Sindhi language.
  /// </summary>
  Sindhi = unchecked((int)1113),
  /// <summary>
  /// Syriac language.
  /// </summary>
  Syriac = unchecked((int)1114),
  /// <summary>
  /// Sinhalese language.
  /// </summary>
  Sinhalese = unchecked((int)1115),
  /// <summary>
  /// Cherokee language.
  /// </summary>
  Cherokee = unchecked((int)1116),
  /// <summary>
  /// Inuktitut language.
  /// </summary>
  Inuktitut = unchecked((int)1117),
  /// <summary>
  /// Amharic language.
  /// </summary>
  Amharic = unchecked((int)1118),
  /// <summary>
  /// Tamazight language.
  /// </summary>
  Tamazight = unchecked((int)1119),
  /// <summary>
  /// Kashmiri language.
  /// </summary>
  Kashmiri = unchecked((int)1120),
  /// <summary>
  /// Nepali language.
  /// </summary>
  Nepali = unchecked((int)1121),
  /// <summary>
  /// Frisian Netherlands language.
  /// </summary>
  FrisianNetherlands = unchecked((int)1122),
  /// <summary>
  /// Pashto language.
  /// </summary>
  Pashto = unchecked((int)1123),
  /// <summary>
  /// Filipino language.
  /// </summary>
  Filipino = unchecked((int)1124),
  /// <summary>
  /// Divehi language.
  /// </summary>
  Divehi = unchecked((int)1125),
  /// <summary>
  /// Edo language.
  /// </summary>
  Edo = unchecked((int)1126),
  /// <summary>
  /// Fulfulde language.
  /// </summary>
  Fulfulde = unchecked((int)1127),
  /// <summary>
  /// Hausa language.
  /// </summary>
  Hausa = unchecked((int)1128),
  /// <summary>
  /// Ibibio language.
  /// </summary>
  Ibibio = unchecked((int)1129),
  /// <summary>
  /// Yoruba language.
  /// </summary>
  Yoruba = unchecked((int)1130),
  /// <summary>
  /// Igbo language.
  /// </summary>
  Igbo = unchecked((int)1136),
  /// <summary>
  /// Kanuri language.
  /// </summary>
  Kanuri = unchecked((int)1137),
  /// <summary>
  /// Oromo language.
  /// </summary>
  Oromo = unchecked((int)1138),
  /// <summary>
  /// Tigrigna Ethiopic language.
  /// </summary>
  TigrignaEthiopic = unchecked((int)1139),
  /// <summary>
  /// Guarani language.
  /// </summary>
  Guarani = unchecked((int)1140),
  /// <summary>
  /// Hawaiian language.
  /// </summary>
  Hawaiian = unchecked((int)1141),
  /// <summary>
  /// Latin language.
  /// </summary>
  Latin = unchecked((int)1142),
  /// <summary>
  /// Somali language.
  /// </summary>
  Somali = unchecked((int)1143),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Yi = unchecked((int)1144),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicIraq = unchecked((int)2049),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SimplifiedChinese = unchecked((int)2052),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SwissGerman = unchecked((int)2055),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishUK = unchecked((int)2057),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  MexicanSpanish = unchecked((int)2058),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  BelgianFrench = unchecked((int)2060),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SwissItalian = unchecked((int)2064),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  BelgianDutch = unchecked((int)2067),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  NorwegianNynorsk = unchecked((int)2068),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  Portuguese = unchecked((int)2070),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  RomanianMoldova = unchecked((int)2072),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  RussianMoldova = unchecked((int)2073),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SerbianLatin = unchecked((int)2074),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SwedishFinland = unchecked((int)2077),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  AzeriCyrillic = unchecked((int)2092),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  GaelicIreland = unchecked((int)2108),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  MalayBruneiDarussalam = unchecked((int)2110),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  UzbekCyrillic = unchecked((int)2115),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SindhiPakistan = unchecked((int)2137),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  TamazightLatin = unchecked((int)2143),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  TigrignaEritrea = unchecked((int)2163),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicEgypt = unchecked((int)3073),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ChineseHongKongSAR = unchecked((int)3076),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  GermanAustria = unchecked((int)3079),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishAUS = unchecked((int)3081),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishModernSort = unchecked((int)3082),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchCanadian = unchecked((int)3084),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SerbianCyrillic = unchecked((int)3098),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicLibya = unchecked((int)4097),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ChineseSingapore = unchecked((int)4100),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  GermanLuxembourg = unchecked((int)4103),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishCanadian = unchecked((int)4105),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishGuatemala = unchecked((int)4106),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SwissFrench = unchecked((int)4108),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicAlgeria = unchecked((int)5121),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ChineseMacaoSAR = unchecked((int)5124),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  GermanLiechtenstein = unchecked((int)5127),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishNewZealand = unchecked((int)5129),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishCostaRica = unchecked((int)5130),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchLuxembourg = unchecked((int)5132),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicMorocco = unchecked((int)6145),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishIreland = unchecked((int)6153),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishPanama = unchecked((int)6154),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchMonaco = unchecked((int)6156),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicTunisia = unchecked((int)7169),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishSouthAfrica = unchecked((int)7177),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishDominicanRepublic = unchecked((int)7178),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchWestIndies = unchecked((int)7180),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicOman = unchecked((int)8193),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishJamaica = unchecked((int)8201),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishVenezuela = unchecked((int)8202),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchReunion = unchecked((int)8204),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicYemen = unchecked((int)9217),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishCaribbean = unchecked((int)9225),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishColombia = unchecked((int)9226),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchCongoDRC = unchecked((int)9228),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicSyria = unchecked((int)10241),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishBelize = unchecked((int)10249),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishPeru = unchecked((int)10250),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchSenegal = unchecked((int)10252),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicJordan = unchecked((int)11265),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishTrinidadTobago = unchecked((int)11273),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishArgentina = unchecked((int)11274),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchCameroon = unchecked((int)11276),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicLebanon = unchecked((int)12289),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishZimbabwe = unchecked((int)12297),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishEcuador = unchecked((int)12298),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchCotedIvoire = unchecked((int)12300),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicKuwait = unchecked((int)13313),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishPhilippines = unchecked((int)13321),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishChile = unchecked((int)13322),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchMali = unchecked((int)13324),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicUAE = unchecked((int)14337),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  EnglishIndonesia = unchecked((int)14345),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishUruguay = unchecked((int)14346),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchMorocco = unchecked((int)14348),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicBahrain = unchecked((int)15361),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishParaguay = unchecked((int)15370),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  FrenchHaiti = unchecked((int)15372),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  ArabicQatar = unchecked((int)16385),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishBolivia = unchecked((int)16394),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishElSalvador = unchecked((int)17418),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishHonduras = unchecked((int)18442),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishNicaragua = unchecked((int)19466),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  SpanishPuertoRico = unchecked((int)20490)
}
