namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the language to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlanguageid?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdLanguageID")]
public enum LanguageID
{
  /// <summary>
  /// No specified language.
  /// </summary>
  [InteropEnumValue("wdLanguageNone")]
  LanguageNone = 0,
  /// <summary>
  /// Disables proofing if the language ID identifies a language in which an object is grammatically validated using
  /// the Word proofing tools.
  /// </summary>
  [InteropEnumValue("wdNoProofing")]
  NoProofing = 1024,
  /// <summary>
  /// Arabic language.
  /// </summary>
  [InteropEnumValue("wdArabic")]
  Arabic = 1025,
  /// <summary>
  /// Bulgarian language.
  /// </summary>
  [InteropEnumValue("wdBulgarian")]
  Bulgarian = 1026,
  /// <summary>
  /// Catalan language.
  /// </summary>
  [InteropEnumValue("wdCatalan")]
  Catalan = 1027,
  /// <summary>
  /// Traditional Chinese language.
  /// </summary>
  [InteropEnumValue("wdTraditionalChinese")]
  TraditionalChinese = 1028,
  /// <summary>
  /// Czech language.
  /// </summary>
  [InteropEnumValue("wdCzech")]
  Czech = 1029,
  /// <summary>
  /// Danish language.
  /// </summary>
  [InteropEnumValue("wdDanish")]
  Danish = 1030,
  /// <summary>
  /// German language.
  /// </summary>
  [InteropEnumValue("wdGerman")]
  German = 1031,
  /// <summary>
  /// Greek language.
  /// </summary>
  [InteropEnumValue("wdGreek")]
  Greek = 1032,
  /// <summary>
  /// United States English language.
  /// </summary>
  [InteropEnumValue("wdEnglishUS")]
  EnglishUS = 1033,
  /// <summary>
  /// Spanish language.
  /// </summary>
  [InteropEnumValue("wdSpanish")]
  Spanish = 1034,
  /// <summary>
  /// Finnish language.
  /// </summary>
  [InteropEnumValue("wdFinnish")]
  Finnish = 1035,
  /// <summary>
  /// French language.
  /// </summary>
  [InteropEnumValue("wdFrench")]
  French = 1036,
  /// <summary>
  /// Hebrew language.
  /// </summary>
  [InteropEnumValue("wdHebrew")]
  Hebrew = 1037,
  /// <summary>
  /// Hungarian language.
  /// </summary>
  [InteropEnumValue("wdHungarian")]
  Hungarian = 1038,
  /// <summary>
  /// Icelandic language.
  /// </summary>
  [InteropEnumValue("wdIcelandic")]
  Icelandic = 1039,
  /// <summary>
  /// Italian language.
  /// </summary>
  [InteropEnumValue("wdItalian")]
  Italian = 1040,
  /// <summary>
  /// Japanese language.
  /// </summary>
  [InteropEnumValue("wdJapanese")]
  Japanese = 1041,
  /// <summary>
  /// Korean language.
  /// </summary>
  [InteropEnumValue("wdKorean")]
  Korean = 1042,
  /// <summary>
  /// Dutch language.
  /// </summary>
  [InteropEnumValue("wdDutch")]
  Dutch = 1043,
  /// <summary>
  /// Norwegian Bokmol language.
  /// </summary>
  [InteropEnumValue("wdNorwegianBokmol")]
  NorwegianBokmol = 1044,
  /// <summary>
  /// Polish language.
  /// </summary>
  [InteropEnumValue("wdPolish")]
  Polish = 1045,
  /// <summary>
  /// Portuguese (Brazil) language.
  /// </summary>
  [InteropEnumValue("wdPortugueseBrazil")]
  PortugueseBrazil = 1046,
  /// <summary>
  /// Rhaeto Romanic language.
  /// </summary>
  [InteropEnumValue("wdRhaetoRomanic")]
  RhaetoRomanic = 1047,
  /// <summary>
  /// Romanian language.
  /// </summary>
  [InteropEnumValue("wdRomanian")]
  Romanian = 1048,
  /// <summary>
  /// Russian language.
  /// </summary>
  [InteropEnumValue("wdRussian")]
  Russian = 1049,
  /// <summary>
  /// Croatian language.
  /// </summary>
  [InteropEnumValue("wdCroatian")]
  Croatian = 1050,
  /// <summary>
  /// Slovakian language.
  /// </summary>
  [InteropEnumValue("wdSlovak")]
  Slovak = 1051,
  /// <summary>
  /// Albanian language.
  /// </summary>
  [InteropEnumValue("wdAlbanian")]
  Albanian = 1052,
  /// <summary>
  /// Swedish language.
  /// </summary>
  [InteropEnumValue("wdSwedish")]
  Swedish = 1053,
  /// <summary>
  /// Thai language.
  /// </summary>
  [InteropEnumValue("wdThai")]
  Thai = 1054,
  /// <summary>
  /// Turkish language.
  /// </summary>
  [InteropEnumValue("wdTurkish")]
  Turkish = 1055,
  /// <summary>
  /// Urdu language.
  /// </summary>
  [InteropEnumValue("wdUrdu")]
  Urdu = 1056,
  /// <summary>
  /// Indonesian language.
  /// </summary>
  [InteropEnumValue("wdIndonesian")]
  Indonesian = 1057,
  /// <summary>
  /// Ukrainian language.
  /// </summary>
  [InteropEnumValue("wdUkrainian")]
  Ukrainian = 1058,
  /// <summary>
  /// Belarusian language.
  /// </summary>
  [InteropEnumValue("wdByelorussian")]
  Byelorussian = 1059,
  /// <summary>
  /// Slovenian language.
  /// </summary>
  [InteropEnumValue("wdSlovenian")]
  Slovenian = 1060,
  /// <summary>
  /// Estonian language.
  /// </summary>
  [InteropEnumValue("wdEstonian")]
  Estonian = 1061,
  /// <summary>
  /// Latvian language.
  /// </summary>
  [InteropEnumValue("wdLatvian")]
  Latvian = 1062,
  /// <summary>
  /// Lithuanian language.
  /// </summary>
  [InteropEnumValue("wdLithuanian")]
  Lithuanian = 1063,
  /// <summary>
  /// Tajik language.
  /// </summary>
  [InteropEnumValue("wdTajik")]
  Tajik = 1064,
  /// <summary>
  /// Persian language.
  /// </summary>
  [InteropEnumValue("wdPersian")]
  Persian = 1065,
  /// <summary>
  /// Vietnamese language.
  /// </summary>
  [InteropEnumValue("wdVietnamese")]
  Vietnamese = 1066,
  /// <summary>
  /// Armenian language.
  /// </summary>
  [InteropEnumValue("wdArmenian")]
  Armenian = 1067,
  /// <summary>
  /// Azeri Latin language.
  /// </summary>
  [InteropEnumValue("wdAzeriLatin")]
  AzeriLatin = 1068,
  /// <summary>
  /// Basque language.
  /// </summary>
  [InteropEnumValue("wdBasque")]
  Basque = 1069,
  /// <summary>
  /// Sorbian language.
  /// </summary>
  [InteropEnumValue("wdSorbian")]
  Sorbian = 1070,
  /// <summary>
  /// Macedonian (FYROM) language.
  /// </summary>
  [InteropEnumValue("wdMacedonianFYROM")]
  MacedonianFYROM = 1071,
  /// <summary>
  /// Sutu language.
  /// </summary>
  [InteropEnumValue("wdSutu")]
  Sutu = 1072,
  /// <summary>
  /// Sesotho language.
  /// </summary>
  [InteropEnumValue("wdSesotho")]
  Sesotho = 1072,
  /// <summary>
  /// Tsonga language.
  /// </summary>
  [InteropEnumValue("wdTsonga")]
  Tsonga = 1073,
  /// <summary>
  /// Tswana language.
  /// </summary>
  [InteropEnumValue("wdTswana")]
  Tswana = 1074,
  /// <summary>
  /// Venda language.
  /// </summary>
  [InteropEnumValue("wdVenda")]
  Venda = 1075,
  /// <summary>
  /// Xhosa language.
  /// </summary>
  [InteropEnumValue("wdXhosa")]
  Xhosa = 1076,
  /// <summary>
  /// Zulu language.
  /// </summary>
  [InteropEnumValue("wdZulu")]
  Zulu = 1077,
  /// <summary>
  /// African language.
  /// </summary>
  [InteropEnumValue("wdAfrikaans")]
  Afrikaans = 1078,
  /// <summary>
  /// Georgian language.
  /// </summary>
  [InteropEnumValue("wdGeorgian")]
  Georgian = 1079,
  /// <summary>
  /// Faeroese language.
  /// </summary>
  [InteropEnumValue("wdFaeroese")]
  Faeroese = 1080,
  /// <summary>
  /// Hindi language.
  /// </summary>
  [InteropEnumValue("wdHindi")]
  Hindi = 1081,
  /// <summary>
  /// Maltese language.
  /// </summary>
  [InteropEnumValue("wdMaltese")]
  Maltese = 1082,
  /// <summary>
  /// Sami Lappish language.
  /// </summary>
  [InteropEnumValue("wdSamiLappish")]
  SamiLappish = 1083,
  /// <summary>
  /// Gaelic Scottish language.
  /// </summary>
  [InteropEnumValue("wdGaelicScotland")]
  GaelicScotland = 1084,
  /// <summary>
  /// Yiddish language.
  /// </summary>
  [InteropEnumValue("wdYiddish")]
  Yiddish = 1085,
  /// <summary>
  /// Malaysian language.
  /// </summary>
  [InteropEnumValue("wdMalaysian")]
  Malaysian = 1086,
  /// <summary>
  /// Kazakh language.
  /// </summary>
  [InteropEnumValue("wdKazakh")]
  Kazakh = 1087,
  /// <summary>
  /// Kyrgyz language.
  /// </summary>
  [InteropEnumValue("wdKyrgyz")]
  Kyrgyz = 1088,
  /// <summary>
  /// Kirghiz language.
  /// </summary>
  [InteropEnumValue("wdKirghiz")]
  Kirghiz = 1088,
  /// <summary>
  /// Swahili language.
  /// </summary>
  [InteropEnumValue("wdSwahili")]
  Swahili = 1089,
  /// <summary>
  /// Turkmen language.
  /// </summary>
  [InteropEnumValue("wdTurkmen")]
  Turkmen = 1090,
  /// <summary>
  /// Uzbek Latin language.
  /// </summary>
  [InteropEnumValue("wdUzbekLatin")]
  UzbekLatin = 1091,
  /// <summary>
  /// Tatar language.
  /// </summary>
  [InteropEnumValue("wdTatar")]
  Tatar = 1092,
  /// <summary>
  /// Bengali language.
  /// </summary>
  [InteropEnumValue("wdBengali")]
  Bengali = 1093,
  /// <summary>
  /// Punjabi language.
  /// </summary>
  [InteropEnumValue("wdPunjabi")]
  Punjabi = 1094,
  /// <summary>
  /// Gujarati language.
  /// </summary>
  [InteropEnumValue("wdGujarati")]
  Gujarati = 1095,
  /// <summary>
  /// Oriya language.
  /// </summary>
  [InteropEnumValue("wdOriya")]
  Oriya = 1096,
  /// <summary>
  /// Tamil language.
  /// </summary>
  [InteropEnumValue("wdTamil")]
  Tamil = 1097,
  /// <summary>
  /// Telugu language.
  /// </summary>
  [InteropEnumValue("wdTelugu")]
  Telugu = 1098,
  /// <summary>
  /// Kannada language.
  /// </summary>
  [InteropEnumValue("wdKannada")]
  Kannada = 1099,
  /// <summary>
  /// Malayalam language.
  /// </summary>
  [InteropEnumValue("wdMalayalam")]
  Malayalam = 1100,
  /// <summary>
  /// Assamese language.
  /// </summary>
  [InteropEnumValue("wdAssamese")]
  Assamese = 1101,
  /// <summary>
  /// Marathi language.
  /// </summary>
  [InteropEnumValue("wdMarathi")]
  Marathi = 1102,
  /// <summary>
  /// Sanskrit language.
  /// </summary>
  [InteropEnumValue("wdSanskrit")]
  Sanskrit = 1103,
  /// <summary>
  /// Mongolian language.
  /// </summary>
  [InteropEnumValue("wdMongolian")]
  Mongolian = 1104,
  /// <summary>
  /// Tibetan language.
  /// </summary>
  [InteropEnumValue("wdTibetan")]
  Tibetan = 1105,
  /// <summary>
  /// Welsh language.
  /// </summary>
  [InteropEnumValue("wdWelsh")]
  Welsh = 1106,
  /// <summary>
  /// Khmer language.
  /// </summary>
  [InteropEnumValue("wdKhmer")]
  Khmer = 1107,
  /// <summary>
  /// Lao language.
  /// </summary>
  [InteropEnumValue("wdLao")]
  Lao = 1108,
  /// <summary>
  /// Burmese language.
  /// </summary>
  [InteropEnumValue("wdBurmese")]
  Burmese = 1109,
  /// <summary>
  /// Galician language.
  /// </summary>
  [InteropEnumValue("wdGalician")]
  Galician = 1110,
  /// <summary>
  /// Konkani language.
  /// </summary>
  [InteropEnumValue("wdKonkani")]
  Konkani = 1111,
  /// <summary>
  /// Manipuri language.
  /// </summary>
  [InteropEnumValue("wdManipuri")]
  Manipuri = 1112,
  /// <summary>
  /// Sindhi language.
  /// </summary>
  [InteropEnumValue("wdSindhi")]
  Sindhi = 1113,
  /// <summary>
  /// Syriac language.
  /// </summary>
  [InteropEnumValue("wdSyriac")]
  Syriac = 1114,
  /// <summary>
  /// Sinhalese language.
  /// </summary>
  [InteropEnumValue("wdSinhalese")]
  Sinhalese = 1115,
  /// <summary>
  /// Cherokee language.
  /// </summary>
  [InteropEnumValue("wdCherokee")]
  Cherokee = 1116,
  /// <summary>
  /// Inuktitut language.
  /// </summary>
  [InteropEnumValue("wdInuktitut")]
  Inuktitut = 1117,
  /// <summary>
  /// Amharic language.
  /// </summary>
  [InteropEnumValue("wdAmharic")]
  Amharic = 1118,
  /// <summary>
  /// Tamazight language.
  /// </summary>
  [InteropEnumValue("wdTamazight")]
  Tamazight = 1119,
  /// <summary>
  /// Kashmiri language.
  /// </summary>
  [InteropEnumValue("wdKashmiri")]
  Kashmiri = 1120,
  /// <summary>
  /// Nepali language.
  /// </summary>
  [InteropEnumValue("wdNepali")]
  Nepali = 1121,
  /// <summary>
  /// Frisian Netherlands language.
  /// </summary>
  [InteropEnumValue("wdFrisianNetherlands")]
  FrisianNetherlands = 1122,
  /// <summary>
  /// Pashto language.
  /// </summary>
  [InteropEnumValue("wdPashto")]
  Pashto = 1123,
  /// <summary>
  /// Filipino language.
  /// </summary>
  [InteropEnumValue("wdFilipino")]
  Filipino = 1124,
  /// <summary>
  /// Divehi language.
  /// </summary>
  [InteropEnumValue("wdDivehi")]
  Divehi = 1125,
  /// <summary>
  /// Edo language.
  /// </summary>
  [InteropEnumValue("wdEdo")]
  Edo = 1126,
  /// <summary>
  /// Fulfulde language.
  /// </summary>
  [InteropEnumValue("wdFulfulde")]
  Fulfulde = 1127,
  /// <summary>
  /// Hausa language.
  /// </summary>
  [InteropEnumValue("wdHausa")]
  Hausa = 1128,
  /// <summary>
  /// Ibibio language.
  /// </summary>
  [InteropEnumValue("wdIbibio")]
  Ibibio = 1129,
  /// <summary>
  /// Yoruba language.
  /// </summary>
  [InteropEnumValue("wdYoruba")]
  Yoruba = 1130,
  /// <summary>
  /// Igbo language.
  /// </summary>
  [InteropEnumValue("wdIgbo")]
  Igbo = 1136,
  /// <summary>
  /// Kanuri language.
  /// </summary>
  [InteropEnumValue("wdKanuri")]
  Kanuri = 1137,
  /// <summary>
  /// Oromo language.
  /// </summary>
  [InteropEnumValue("wdOromo")]
  Oromo = 1138,
  /// <summary>
  /// Tigrigna Ethiopic language.
  /// </summary>
  [InteropEnumValue("wdTigrignaEthiopic")]
  TigrignaEthiopic = 1139,
  /// <summary>
  /// Guarani language.
  /// </summary>
  [InteropEnumValue("wdGuarani")]
  Guarani = 1140,
  /// <summary>
  /// Hawaiian language.
  /// </summary>
  [InteropEnumValue("wdHawaiian")]
  Hawaiian = 1141,
  /// <summary>
  /// Latin language.
  /// </summary>
  [InteropEnumValue("wdLatin")]
  Latin = 1142,
  /// <summary>
  /// Somali language.
  /// </summary>
  [InteropEnumValue("wdSomali")]
  Somali = 1143,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdYi")]
  Yi = 1144,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdArabicIraq")]
  ArabicIraq = 2049,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSimplifiedChinese")]
  SimplifiedChinese = 2052,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSwissGerman")]
  SwissGerman = 2055,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdEnglishUK")]
  EnglishUK = 2057,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdMexicanSpanish")]
  MexicanSpanish = 2058,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdBelgianFrench")]
  BelgianFrench = 2060,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSwissItalian")]
  SwissItalian = 2064,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdBelgianDutch")]
  BelgianDutch = 2067,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdNorwegianNynorsk")]
  NorwegianNynorsk = 2068,
  /// <summary>
  /// Portuguese (Brazil) language.
  /// </summary>
  [InteropEnumValue("wdPortuguese")]
  Portuguese = 2070,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdRomanianMoldova")]
  RomanianMoldova = 2072,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdRussianMoldova")]
  RussianMoldova = 2073,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSerbianLatin")]
  SerbianLatin = 2074,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSwedishFinland")]
  SwedishFinland = 2077,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdAzeriCyrillic")]
  AzeriCyrillic = 2092,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdGaelicIreland")]
  GaelicIreland = 2108,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdMalayBruneiDarussalam")]
  MalayBruneiDarussalam = 2110,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdUzbekCyrillic")]
  UzbekCyrillic = 2115,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSindhiPakistan")]
  SindhiPakistan = 2137,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdTamazightLatin")]
  TamazightLatin = 2143,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdTigrignaEritrea")]
  TigrignaEritrea = 2163,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdArabicEgypt")]
  ArabicEgypt = 3073,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdChineseHongKongSAR")]
  ChineseHongKongSAR = 3076,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdGermanAustria")]
  GermanAustria = 3079,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdEnglishAUS")]
  EnglishAUS = 3081,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishModernSort")]
  SpanishModernSort = 3082,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdFrenchCanadian")]
  FrenchCanadian = 3084,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSerbianCyrillic")]
  SerbianCyrillic = 3098,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdArabicLibya")]
  ArabicLibya = 4097,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdChineseSingapore")]
  ChineseSingapore = 4100,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdGermanLuxembourg")]
  GermanLuxembourg = 4103,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdEnglishCanadian")]
  EnglishCanadian = 4105,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishGuatemala")]
  SpanishGuatemala = 4106,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSwissFrench")]
  SwissFrench = 4108,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdArabicAlgeria")]
  ArabicAlgeria = 5121,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdChineseMacaoSAR")]
  ChineseMacaoSAR = 5124,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdGermanLiechtenstein")]
  GermanLiechtenstein = 5127,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdEnglishNewZealand")]
  EnglishNewZealand = 5129,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishCostaRica")]
  SpanishCostaRica = 5130,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdFrenchLuxembourg")]
  FrenchLuxembourg = 5132,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdArabicMorocco")]
  ArabicMorocco = 6145,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdEnglishIreland")]
  EnglishIreland = 6153,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishPanama")]
  SpanishPanama = 6154,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdFrenchMonaco")]
  FrenchMonaco = 6156,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdArabicTunisia")]
  ArabicTunisia = 7169,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdEnglishSouthAfrica")]
  EnglishSouthAfrica = 7177,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishDominicanRepublic")]
  SpanishDominicanRepublic = 7178,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdFrenchWestIndies")]
  FrenchWestIndies = 7180,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdArabicOman")]
  ArabicOman = 8193,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdEnglishJamaica")]
  EnglishJamaica = 8201,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishVenezuela")]
  SpanishVenezuela = 8202,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdFrenchReunion")]
  FrenchReunion = 8204,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdArabicYemen")]
  ArabicYemen = 9217,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdEnglishCaribbean")]
  EnglishCaribbean = 9225,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishColombia")]
  SpanishColombia = 9226,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdFrenchCongoDRC")]
  FrenchCongoDRC = 9228,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdArabicSyria")]
  ArabicSyria = 10241,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdEnglishBelize")]
  EnglishBelize = 10249,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishPeru")]
  SpanishPeru = 10250,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdFrenchSenegal")]
  FrenchSenegal = 10252,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdArabicJordan")]
  ArabicJordan = 11265,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdEnglishTrinidadTobago")]
  EnglishTrinidadTobago = 11273,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishArgentina")]
  SpanishArgentina = 11274,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdFrenchCameroon")]
  FrenchCameroon = 11276,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdArabicLebanon")]
  ArabicLebanon = 12289,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdEnglishZimbabwe")]
  EnglishZimbabwe = 12297,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishEcuador")]
  SpanishEcuador = 12298,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdFrenchCotedIvoire")]
  FrenchCotedIvoire = 12300,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdArabicKuwait")]
  ArabicKuwait = 13313,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdEnglishPhilippines")]
  EnglishPhilippines = 13321,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishChile")]
  SpanishChile = 13322,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdFrenchMali")]
  FrenchMali = 13324,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdArabicUAE")]
  ArabicUAE = 14337,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdEnglishIndonesia")]
  EnglishIndonesia = 14345,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishUruguay")]
  SpanishUruguay = 14346,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdFrenchMorocco")]
  FrenchMorocco = 14348,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdArabicBahrain")]
  ArabicBahrain = 15361,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishParaguay")]
  SpanishParaguay = 15370,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdFrenchHaiti")]
  FrenchHaiti = 15372,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdArabicQatar")]
  ArabicQatar = 16385,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishBolivia")]
  SpanishBolivia = 16394,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishElSalvador")]
  SpanishElSalvador = 17418,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishHonduras")]
  SpanishHonduras = 18442,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishNicaragua")]
  SpanishNicaragua = 19466,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [InteropEnumValue("wdSpanishPuertoRico")]
  SpanishPuertoRico = 20490
}
