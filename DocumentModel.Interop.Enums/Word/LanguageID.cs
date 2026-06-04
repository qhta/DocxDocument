namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the language to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlanguageid?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdLanguageID")]
public enum LanguageID
{
  /// <summary>
  /// No specified language.
  /// </summary>
  [WordInteropEnumValue("wdLanguageNone")]
  LanguageNone = 0,
  /// <summary>
  /// Disables proofing if the language ID identifies a language in which an object is grammatically validated using
  /// the Word proofing tools.
  /// </summary>
  [WordInteropEnumValue("wdNoProofing")]
  NoProofing = 1024,
  /// <summary>
  /// Arabic language.
  /// </summary>
  [WordInteropEnumValue("wdArabic")]
  Arabic = 1025,
  /// <summary>
  /// Bulgarian language.
  /// </summary>
  [WordInteropEnumValue("wdBulgarian")]
  Bulgarian = 1026,
  /// <summary>
  /// Catalan language.
  /// </summary>
  [WordInteropEnumValue("wdCatalan")]
  Catalan = 1027,
  /// <summary>
  /// Traditional Chinese language.
  /// </summary>
  [WordInteropEnumValue("wdTraditionalChinese")]
  TraditionalChinese = 1028,
  /// <summary>
  /// Czech language.
  /// </summary>
  [WordInteropEnumValue("wdCzech")]
  Czech = 1029,
  /// <summary>
  /// Danish language.
  /// </summary>
  [WordInteropEnumValue("wdDanish")]
  Danish = 1030,
  /// <summary>
  /// German language.
  /// </summary>
  [WordInteropEnumValue("wdGerman")]
  German = 1031,
  /// <summary>
  /// Greek language.
  /// </summary>
  [WordInteropEnumValue("wdGreek")]
  Greek = 1032,
  /// <summary>
  /// United States English language.
  /// </summary>
  [WordInteropEnumValue("wdEnglishUS")]
  EnglishUS = 1033,
  /// <summary>
  /// Spanish language.
  /// </summary>
  [WordInteropEnumValue("wdSpanish")]
  Spanish = 1034,
  /// <summary>
  /// Finnish language.
  /// </summary>
  [WordInteropEnumValue("wdFinnish")]
  Finnish = 1035,
  /// <summary>
  /// French language.
  /// </summary>
  [WordInteropEnumValue("wdFrench")]
  French = 1036,
  /// <summary>
  /// Hebrew language.
  /// </summary>
  [WordInteropEnumValue("wdHebrew")]
  Hebrew = 1037,
  /// <summary>
  /// Hungarian language.
  /// </summary>
  [WordInteropEnumValue("wdHungarian")]
  Hungarian = 1038,
  /// <summary>
  /// Icelandic language.
  /// </summary>
  [WordInteropEnumValue("wdIcelandic")]
  Icelandic = 1039,
  /// <summary>
  /// Italian language.
  /// </summary>
  [WordInteropEnumValue("wdItalian")]
  Italian = 1040,
  /// <summary>
  /// Japanese language.
  /// </summary>
  [WordInteropEnumValue("wdJapanese")]
  Japanese = 1041,
  /// <summary>
  /// Korean language.
  /// </summary>
  [WordInteropEnumValue("wdKorean")]
  Korean = 1042,
  /// <summary>
  /// Dutch language.
  /// </summary>
  [WordInteropEnumValue("wdDutch")]
  Dutch = 1043,
  /// <summary>
  /// Norwegian Bokmol language.
  /// </summary>
  [WordInteropEnumValue("wdNorwegianBokmol")]
  NorwegianBokmol = 1044,
  /// <summary>
  /// Polish language.
  /// </summary>
  [WordInteropEnumValue("wdPolish")]
  Polish = 1045,
  /// <summary>
  /// Portuguese (Brazil) language.
  /// </summary>
  [WordInteropEnumValue("wdPortugueseBrazil")]
  PortugueseBrazil = 1046,
  /// <summary>
  /// Rhaeto Romanic language.
  /// </summary>
  [WordInteropEnumValue("wdRhaetoRomanic")]
  RhaetoRomanic = 1047,
  /// <summary>
  /// Romanian language.
  /// </summary>
  [WordInteropEnumValue("wdRomanian")]
  Romanian = 1048,
  /// <summary>
  /// Russian language.
  /// </summary>
  [WordInteropEnumValue("wdRussian")]
  Russian = 1049,
  /// <summary>
  /// Croatian language.
  /// </summary>
  [WordInteropEnumValue("wdCroatian")]
  Croatian = 1050,
  /// <summary>
  /// Slovakian language.
  /// </summary>
  [WordInteropEnumValue("wdSlovak")]
  Slovak = 1051,
  /// <summary>
  /// Albanian language.
  /// </summary>
  [WordInteropEnumValue("wdAlbanian")]
  Albanian = 1052,
  /// <summary>
  /// Swedish language.
  /// </summary>
  [WordInteropEnumValue("wdSwedish")]
  Swedish = 1053,
  /// <summary>
  /// Thai language.
  /// </summary>
  [WordInteropEnumValue("wdThai")]
  Thai = 1054,
  /// <summary>
  /// Turkish language.
  /// </summary>
  [WordInteropEnumValue("wdTurkish")]
  Turkish = 1055,
  /// <summary>
  /// Urdu language.
  /// </summary>
  [WordInteropEnumValue("wdUrdu")]
  Urdu = 1056,
  /// <summary>
  /// Indonesian language.
  /// </summary>
  [WordInteropEnumValue("wdIndonesian")]
  Indonesian = 1057,
  /// <summary>
  /// Ukrainian language.
  /// </summary>
  [WordInteropEnumValue("wdUkrainian")]
  Ukrainian = 1058,
  /// <summary>
  /// Belarusian language.
  /// </summary>
  [WordInteropEnumValue("wdByelorussian")]
  Byelorussian = 1059,
  /// <summary>
  /// Slovenian language.
  /// </summary>
  [WordInteropEnumValue("wdSlovenian")]
  Slovenian = 1060,
  /// <summary>
  /// Estonian language.
  /// </summary>
  [WordInteropEnumValue("wdEstonian")]
  Estonian = 1061,
  /// <summary>
  /// Latvian language.
  /// </summary>
  [WordInteropEnumValue("wdLatvian")]
  Latvian = 1062,
  /// <summary>
  /// Lithuanian language.
  /// </summary>
  [WordInteropEnumValue("wdLithuanian")]
  Lithuanian = 1063,
  /// <summary>
  /// Tajik language.
  /// </summary>
  [WordInteropEnumValue("wdTajik")]
  Tajik = 1064,
  /// <summary>
  /// Persian language.
  /// </summary>
  [WordInteropEnumValue("wdPersian")]
  Persian = 1065,
  /// <summary>
  /// Vietnamese language.
  /// </summary>
  [WordInteropEnumValue("wdVietnamese")]
  Vietnamese = 1066,
  /// <summary>
  /// Armenian language.
  /// </summary>
  [WordInteropEnumValue("wdArmenian")]
  Armenian = 1067,
  /// <summary>
  /// Azeri Latin language.
  /// </summary>
  [WordInteropEnumValue("wdAzeriLatin")]
  AzeriLatin = 1068,
  /// <summary>
  /// Basque language.
  /// </summary>
  [WordInteropEnumValue("wdBasque")]
  Basque = 1069,
  /// <summary>
  /// Sorbian language.
  /// </summary>
  [WordInteropEnumValue("wdSorbian")]
  Sorbian = 1070,
  /// <summary>
  /// Macedonian (FYROM) language.
  /// </summary>
  [WordInteropEnumValue("wdMacedonianFYROM")]
  MacedonianFYROM = 1071,
  /// <summary>
  /// Sutu language.
  /// </summary>
  [WordInteropEnumValue("wdSutu")]
  Sutu = 1072,
  /// <summary>
  /// Sesotho language.
  /// </summary>
  [WordInteropEnumValue("wdSesotho")]
  Sesotho = 1072,
  /// <summary>
  /// Tsonga language.
  /// </summary>
  [WordInteropEnumValue("wdTsonga")]
  Tsonga = 1073,
  /// <summary>
  /// Tswana language.
  /// </summary>
  [WordInteropEnumValue("wdTswana")]
  Tswana = 1074,
  /// <summary>
  /// Venda language.
  /// </summary>
  [WordInteropEnumValue("wdVenda")]
  Venda = 1075,
  /// <summary>
  /// Xhosa language.
  /// </summary>
  [WordInteropEnumValue("wdXhosa")]
  Xhosa = 1076,
  /// <summary>
  /// Zulu language.
  /// </summary>
  [WordInteropEnumValue("wdZulu")]
  Zulu = 1077,
  /// <summary>
  /// African language.
  /// </summary>
  [WordInteropEnumValue("wdAfrikaans")]
  Afrikaans = 1078,
  /// <summary>
  /// Georgian language.
  /// </summary>
  [WordInteropEnumValue("wdGeorgian")]
  Georgian = 1079,
  /// <summary>
  /// Faeroese language.
  /// </summary>
  [WordInteropEnumValue("wdFaeroese")]
  Faeroese = 1080,
  /// <summary>
  /// Hindi language.
  /// </summary>
  [WordInteropEnumValue("wdHindi")]
  Hindi = 1081,
  /// <summary>
  /// Maltese language.
  /// </summary>
  [WordInteropEnumValue("wdMaltese")]
  Maltese = 1082,
  /// <summary>
  /// Sami Lappish language.
  /// </summary>
  [WordInteropEnumValue("wdSamiLappish")]
  SamiLappish = 1083,
  /// <summary>
  /// Gaelic Scottish language.
  /// </summary>
  [WordInteropEnumValue("wdGaelicScotland")]
  GaelicScotland = 1084,
  /// <summary>
  /// Yiddish language.
  /// </summary>
  [WordInteropEnumValue("wdYiddish")]
  Yiddish = 1085,
  /// <summary>
  /// Malaysian language.
  /// </summary>
  [WordInteropEnumValue("wdMalaysian")]
  Malaysian = 1086,
  /// <summary>
  /// Kazakh language.
  /// </summary>
  [WordInteropEnumValue("wdKazakh")]
  Kazakh = 1087,
  /// <summary>
  /// Kyrgyz language.
  /// </summary>
  [WordInteropEnumValue("wdKyrgyz")]
  Kyrgyz = 1088,
  /// <summary>
  /// Kirghiz language.
  /// </summary>
  [WordInteropEnumValue("wdKirghiz")]
  Kirghiz = 1088,
  /// <summary>
  /// Swahili language.
  /// </summary>
  [WordInteropEnumValue("wdSwahili")]
  Swahili = 1089,
  /// <summary>
  /// Turkmen language.
  /// </summary>
  [WordInteropEnumValue("wdTurkmen")]
  Turkmen = 1090,
  /// <summary>
  /// Uzbek Latin language.
  /// </summary>
  [WordInteropEnumValue("wdUzbekLatin")]
  UzbekLatin = 1091,
  /// <summary>
  /// Tatar language.
  /// </summary>
  [WordInteropEnumValue("wdTatar")]
  Tatar = 1092,
  /// <summary>
  /// Bengali language.
  /// </summary>
  [WordInteropEnumValue("wdBengali")]
  Bengali = 1093,
  /// <summary>
  /// Punjabi language.
  /// </summary>
  [WordInteropEnumValue("wdPunjabi")]
  Punjabi = 1094,
  /// <summary>
  /// Gujarati language.
  /// </summary>
  [WordInteropEnumValue("wdGujarati")]
  Gujarati = 1095,
  /// <summary>
  /// Oriya language.
  /// </summary>
  [WordInteropEnumValue("wdOriya")]
  Oriya = 1096,
  /// <summary>
  /// Tamil language.
  /// </summary>
  [WordInteropEnumValue("wdTamil")]
  Tamil = 1097,
  /// <summary>
  /// Telugu language.
  /// </summary>
  [WordInteropEnumValue("wdTelugu")]
  Telugu = 1098,
  /// <summary>
  /// Kannada language.
  /// </summary>
  [WordInteropEnumValue("wdKannada")]
  Kannada = 1099,
  /// <summary>
  /// Malayalam language.
  /// </summary>
  [WordInteropEnumValue("wdMalayalam")]
  Malayalam = 1100,
  /// <summary>
  /// Assamese language.
  /// </summary>
  [WordInteropEnumValue("wdAssamese")]
  Assamese = 1101,
  /// <summary>
  /// Marathi language.
  /// </summary>
  [WordInteropEnumValue("wdMarathi")]
  Marathi = 1102,
  /// <summary>
  /// Sanskrit language.
  /// </summary>
  [WordInteropEnumValue("wdSanskrit")]
  Sanskrit = 1103,
  /// <summary>
  /// Mongolian language.
  /// </summary>
  [WordInteropEnumValue("wdMongolian")]
  Mongolian = 1104,
  /// <summary>
  /// Tibetan language.
  /// </summary>
  [WordInteropEnumValue("wdTibetan")]
  Tibetan = 1105,
  /// <summary>
  /// Welsh language.
  /// </summary>
  [WordInteropEnumValue("wdWelsh")]
  Welsh = 1106,
  /// <summary>
  /// Khmer language.
  /// </summary>
  [WordInteropEnumValue("wdKhmer")]
  Khmer = 1107,
  /// <summary>
  /// Lao language.
  /// </summary>
  [WordInteropEnumValue("wdLao")]
  Lao = 1108,
  /// <summary>
  /// Burmese language.
  /// </summary>
  [WordInteropEnumValue("wdBurmese")]
  Burmese = 1109,
  /// <summary>
  /// Galician language.
  /// </summary>
  [WordInteropEnumValue("wdGalician")]
  Galician = 1110,
  /// <summary>
  /// Konkani language.
  /// </summary>
  [WordInteropEnumValue("wdKonkani")]
  Konkani = 1111,
  /// <summary>
  /// Manipuri language.
  /// </summary>
  [WordInteropEnumValue("wdManipuri")]
  Manipuri = 1112,
  /// <summary>
  /// Sindhi language.
  /// </summary>
  [WordInteropEnumValue("wdSindhi")]
  Sindhi = 1113,
  /// <summary>
  /// Syriac language.
  /// </summary>
  [WordInteropEnumValue("wdSyriac")]
  Syriac = 1114,
  /// <summary>
  /// Sinhalese language.
  /// </summary>
  [WordInteropEnumValue("wdSinhalese")]
  Sinhalese = 1115,
  /// <summary>
  /// Cherokee language.
  /// </summary>
  [WordInteropEnumValue("wdCherokee")]
  Cherokee = 1116,
  /// <summary>
  /// Inuktitut language.
  /// </summary>
  [WordInteropEnumValue("wdInuktitut")]
  Inuktitut = 1117,
  /// <summary>
  /// Amharic language.
  /// </summary>
  [WordInteropEnumValue("wdAmharic")]
  Amharic = 1118,
  /// <summary>
  /// Tamazight language.
  /// </summary>
  [WordInteropEnumValue("wdTamazight")]
  Tamazight = 1119,
  /// <summary>
  /// Kashmiri language.
  /// </summary>
  [WordInteropEnumValue("wdKashmiri")]
  Kashmiri = 1120,
  /// <summary>
  /// Nepali language.
  /// </summary>
  [WordInteropEnumValue("wdNepali")]
  Nepali = 1121,
  /// <summary>
  /// Frisian Netherlands language.
  /// </summary>
  [WordInteropEnumValue("wdFrisianNetherlands")]
  FrisianNetherlands = 1122,
  /// <summary>
  /// Pashto language.
  /// </summary>
  [WordInteropEnumValue("wdPashto")]
  Pashto = 1123,
  /// <summary>
  /// Filipino language.
  /// </summary>
  [WordInteropEnumValue("wdFilipino")]
  Filipino = 1124,
  /// <summary>
  /// Divehi language.
  /// </summary>
  [WordInteropEnumValue("wdDivehi")]
  Divehi = 1125,
  /// <summary>
  /// Edo language.
  /// </summary>
  [WordInteropEnumValue("wdEdo")]
  Edo = 1126,
  /// <summary>
  /// Fulfulde language.
  /// </summary>
  [WordInteropEnumValue("wdFulfulde")]
  Fulfulde = 1127,
  /// <summary>
  /// Hausa language.
  /// </summary>
  [WordInteropEnumValue("wdHausa")]
  Hausa = 1128,
  /// <summary>
  /// Ibibio language.
  /// </summary>
  [WordInteropEnumValue("wdIbibio")]
  Ibibio = 1129,
  /// <summary>
  /// Yoruba language.
  /// </summary>
  [WordInteropEnumValue("wdYoruba")]
  Yoruba = 1130,
  /// <summary>
  /// Igbo language.
  /// </summary>
  [WordInteropEnumValue("wdIgbo")]
  Igbo = 1136,
  /// <summary>
  /// Kanuri language.
  /// </summary>
  [WordInteropEnumValue("wdKanuri")]
  Kanuri = 1137,
  /// <summary>
  /// Oromo language.
  /// </summary>
  [WordInteropEnumValue("wdOromo")]
  Oromo = 1138,
  /// <summary>
  /// Tigrigna Ethiopic language.
  /// </summary>
  [WordInteropEnumValue("wdTigrignaEthiopic")]
  TigrignaEthiopic = 1139,
  /// <summary>
  /// Guarani language.
  /// </summary>
  [WordInteropEnumValue("wdGuarani")]
  Guarani = 1140,
  /// <summary>
  /// Hawaiian language.
  /// </summary>
  [WordInteropEnumValue("wdHawaiian")]
  Hawaiian = 1141,
  /// <summary>
  /// Latin language.
  /// </summary>
  [WordInteropEnumValue("wdLatin")]
  Latin = 1142,
  /// <summary>
  /// Somali language.
  /// </summary>
  [WordInteropEnumValue("wdSomali")]
  Somali = 1143,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdYi")]
  Yi = 1144,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdArabicIraq")]
  ArabicIraq = 2049,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSimplifiedChinese")]
  SimplifiedChinese = 2052,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSwissGerman")]
  SwissGerman = 2055,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdEnglishUK")]
  EnglishUK = 2057,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdMexicanSpanish")]
  MexicanSpanish = 2058,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdBelgianFrench")]
  BelgianFrench = 2060,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSwissItalian")]
  SwissItalian = 2064,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdBelgianDutch")]
  BelgianDutch = 2067,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdNorwegianNynorsk")]
  NorwegianNynorsk = 2068,
  /// <summary>
  /// Portuguese (Brazil) language.
  /// </summary>
  [WordInteropEnumValue("wdPortuguese")]
  Portuguese = 2070,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdRomanianMoldova")]
  RomanianMoldova = 2072,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdRussianMoldova")]
  RussianMoldova = 2073,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSerbianLatin")]
  SerbianLatin = 2074,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSwedishFinland")]
  SwedishFinland = 2077,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdAzeriCyrillic")]
  AzeriCyrillic = 2092,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdGaelicIreland")]
  GaelicIreland = 2108,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdMalayBruneiDarussalam")]
  MalayBruneiDarussalam = 2110,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdUzbekCyrillic")]
  UzbekCyrillic = 2115,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSindhiPakistan")]
  SindhiPakistan = 2137,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdTamazightLatin")]
  TamazightLatin = 2143,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdTigrignaEritrea")]
  TigrignaEritrea = 2163,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdArabicEgypt")]
  ArabicEgypt = 3073,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdChineseHongKongSAR")]
  ChineseHongKongSAR = 3076,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdGermanAustria")]
  GermanAustria = 3079,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdEnglishAUS")]
  EnglishAUS = 3081,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishModernSort")]
  SpanishModernSort = 3082,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdFrenchCanadian")]
  FrenchCanadian = 3084,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSerbianCyrillic")]
  SerbianCyrillic = 3098,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdArabicLibya")]
  ArabicLibya = 4097,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdChineseSingapore")]
  ChineseSingapore = 4100,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdGermanLuxembourg")]
  GermanLuxembourg = 4103,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdEnglishCanadian")]
  EnglishCanadian = 4105,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishGuatemala")]
  SpanishGuatemala = 4106,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSwissFrench")]
  SwissFrench = 4108,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdArabicAlgeria")]
  ArabicAlgeria = 5121,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdChineseMacaoSAR")]
  ChineseMacaoSAR = 5124,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdGermanLiechtenstein")]
  GermanLiechtenstein = 5127,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdEnglishNewZealand")]
  EnglishNewZealand = 5129,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishCostaRica")]
  SpanishCostaRica = 5130,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdFrenchLuxembourg")]
  FrenchLuxembourg = 5132,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdArabicMorocco")]
  ArabicMorocco = 6145,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdEnglishIreland")]
  EnglishIreland = 6153,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishPanama")]
  SpanishPanama = 6154,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdFrenchMonaco")]
  FrenchMonaco = 6156,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdArabicTunisia")]
  ArabicTunisia = 7169,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdEnglishSouthAfrica")]
  EnglishSouthAfrica = 7177,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishDominicanRepublic")]
  SpanishDominicanRepublic = 7178,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdFrenchWestIndies")]
  FrenchWestIndies = 7180,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdArabicOman")]
  ArabicOman = 8193,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdEnglishJamaica")]
  EnglishJamaica = 8201,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishVenezuela")]
  SpanishVenezuela = 8202,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdFrenchReunion")]
  FrenchReunion = 8204,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdArabicYemen")]
  ArabicYemen = 9217,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdEnglishCaribbean")]
  EnglishCaribbean = 9225,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishColombia")]
  SpanishColombia = 9226,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdFrenchCongoDRC")]
  FrenchCongoDRC = 9228,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdArabicSyria")]
  ArabicSyria = 10241,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdEnglishBelize")]
  EnglishBelize = 10249,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishPeru")]
  SpanishPeru = 10250,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdFrenchSenegal")]
  FrenchSenegal = 10252,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdArabicJordan")]
  ArabicJordan = 11265,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdEnglishTrinidadTobago")]
  EnglishTrinidadTobago = 11273,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishArgentina")]
  SpanishArgentina = 11274,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdFrenchCameroon")]
  FrenchCameroon = 11276,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdArabicLebanon")]
  ArabicLebanon = 12289,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdEnglishZimbabwe")]
  EnglishZimbabwe = 12297,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishEcuador")]
  SpanishEcuador = 12298,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdFrenchCotedIvoire")]
  FrenchCotedIvoire = 12300,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdArabicKuwait")]
  ArabicKuwait = 13313,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdEnglishPhilippines")]
  EnglishPhilippines = 13321,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishChile")]
  SpanishChile = 13322,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdFrenchMali")]
  FrenchMali = 13324,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdArabicUAE")]
  ArabicUAE = 14337,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdEnglishIndonesia")]
  EnglishIndonesia = 14345,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishUruguay")]
  SpanishUruguay = 14346,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdFrenchMorocco")]
  FrenchMorocco = 14348,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdArabicBahrain")]
  ArabicBahrain = 15361,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishParaguay")]
  SpanishParaguay = 15370,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdFrenchHaiti")]
  FrenchHaiti = 15372,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdArabicQatar")]
  ArabicQatar = 16385,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishBolivia")]
  SpanishBolivia = 16394,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishElSalvador")]
  SpanishElSalvador = 17418,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishHonduras")]
  SpanishHonduras = 18442,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishNicaragua")]
  SpanishNicaragua = 19466,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue("wdSpanishPuertoRico")]
  SpanishPuertoRico = 20490
}
