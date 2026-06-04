namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the language to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlanguageid?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdLanguageID))]
public enum LanguageID
{
  /// <summary>
  /// No specified language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdLanguageNone))]
  LanguageNone = 0,
  /// <summary>
  /// Disables proofing if the language ID identifies a language in which an object is grammatically validated using
  /// the Word proofing tools.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdNoProofing))]
  NoProofing = 1024,
  /// <summary>
  /// Arabic language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabic))]
  Arabic = 1025,
  /// <summary>
  /// Bulgarian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdBulgarian))]
  Bulgarian = 1026,
  /// <summary>
  /// Catalan language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdCatalan))]
  Catalan = 1027,
  /// <summary>
  /// Traditional Chinese language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdTraditionalChinese))]
  TraditionalChinese = 1028,
  /// <summary>
  /// Czech language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdCzech))]
  Czech = 1029,
  /// <summary>
  /// Danish language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdDanish))]
  Danish = 1030,
  /// <summary>
  /// German language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdGerman))]
  German = 1031,
  /// <summary>
  /// Greek language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdGreek))]
  Greek = 1032,
  /// <summary>
  /// United States English language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEnglishUS))]
  EnglishUS = 1033,
  /// <summary>
  /// Spanish language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanish))]
  Spanish = 1034,
  /// <summary>
  /// Finnish language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFinnish))]
  Finnish = 1035,
  /// <summary>
  /// French language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFrench))]
  French = 1036,
  /// <summary>
  /// Hebrew language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdHebrew))]
  Hebrew = 1037,
  /// <summary>
  /// Hungarian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdHungarian))]
  Hungarian = 1038,
  /// <summary>
  /// Icelandic language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdIcelandic))]
  Icelandic = 1039,
  /// <summary>
  /// Italian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdItalian))]
  Italian = 1040,
  /// <summary>
  /// Japanese language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdJapanese))]
  Japanese = 1041,
  /// <summary>
  /// Korean language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdKorean))]
  Korean = 1042,
  /// <summary>
  /// Dutch language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdDutch))]
  Dutch = 1043,
  /// <summary>
  /// Norwegian Bokmol language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdNorwegianBokmol))]
  NorwegianBokmol = 1044,
  /// <summary>
  /// Polish language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdPolish))]
  Polish = 1045,
  /// <summary>
  /// Portuguese (Brazil) language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdPortugueseBrazil))]
  PortugueseBrazil = 1046,
  /// <summary>
  /// Rhaeto Romanic language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdRhaetoRomanic))]
  RhaetoRomanic = 1047,
  /// <summary>
  /// Romanian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdRomanian))]
  Romanian = 1048,
  /// <summary>
  /// Russian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdRussian))]
  Russian = 1049,
  /// <summary>
  /// Croatian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdCroatian))]
  Croatian = 1050,
  /// <summary>
  /// Slovakian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSlovak))]
  Slovak = 1051,
  /// <summary>
  /// Albanian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdAlbanian))]
  Albanian = 1052,
  /// <summary>
  /// Swedish language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSwedish))]
  Swedish = 1053,
  /// <summary>
  /// Thai language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdThai))]
  Thai = 1054,
  /// <summary>
  /// Turkish language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdTurkish))]
  Turkish = 1055,
  /// <summary>
  /// Urdu language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdUrdu))]
  Urdu = 1056,
  /// <summary>
  /// Indonesian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdIndonesian))]
  Indonesian = 1057,
  /// <summary>
  /// Ukrainian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdUkrainian))]
  Ukrainian = 1058,
  /// <summary>
  /// Belarusian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdByelorussian))]
  Byelorussian = 1059,
  /// <summary>
  /// Slovenian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSlovenian))]
  Slovenian = 1060,
  /// <summary>
  /// Estonian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEstonian))]
  Estonian = 1061,
  /// <summary>
  /// Latvian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdLatvian))]
  Latvian = 1062,
  /// <summary>
  /// Lithuanian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdLithuanian))]
  Lithuanian = 1063,
  /// <summary>
  /// Tajik language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdTajik))]
  Tajik = 1064,
  /// <summary>
  /// Persian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdPersian))]
  Persian = 1065,
  /// <summary>
  /// Vietnamese language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdVietnamese))]
  Vietnamese = 1066,
  /// <summary>
  /// Armenian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArmenian))]
  Armenian = 1067,
  /// <summary>
  /// Azeri Latin language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdAzeriLatin))]
  AzeriLatin = 1068,
  /// <summary>
  /// Basque language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdBasque))]
  Basque = 1069,
  /// <summary>
  /// Sorbian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSorbian))]
  Sorbian = 1070,
  /// <summary>
  /// Macedonian (FYROM) language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdMacedonianFYROM))]
  MacedonianFYROM = 1071,
  /// <summary>
  /// Sutu language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSutu))]
  Sutu = 1072,
  /// <summary>
  /// Sesotho language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSesotho))]
  Sesotho = 1072,
  /// <summary>
  /// Tsonga language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdTsonga))]
  Tsonga = 1073,
  /// <summary>
  /// Tswana language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdTswana))]
  Tswana = 1074,
  /// <summary>
  /// Venda language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdVenda))]
  Venda = 1075,
  /// <summary>
  /// Xhosa language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdXhosa))]
  Xhosa = 1076,
  /// <summary>
  /// Zulu language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdZulu))]
  Zulu = 1077,
  /// <summary>
  /// African language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdAfrikaans))]
  Afrikaans = 1078,
  /// <summary>
  /// Georgian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdGeorgian))]
  Georgian = 1079,
  /// <summary>
  /// Faeroese language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFaeroese))]
  Faeroese = 1080,
  /// <summary>
  /// Hindi language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdHindi))]
  Hindi = 1081,
  /// <summary>
  /// Maltese language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdMaltese))]
  Maltese = 1082,
  /// <summary>
  /// Sami Lappish language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSamiLappish))]
  SamiLappish = 1083,
  /// <summary>
  /// Gaelic Scottish language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdGaelicScotland))]
  GaelicScotland = 1084,
  /// <summary>
  /// Yiddish language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdYiddish))]
  Yiddish = 1085,
  /// <summary>
  /// Malaysian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdMalaysian))]
  Malaysian = 1086,
  /// <summary>
  /// Kazakh language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdKazakh))]
  Kazakh = 1087,
  /// <summary>
  /// Kyrgyz language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdKyrgyz))]
  Kyrgyz = 1088,
  /// <summary>
  /// Kirghiz language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdKirghiz))]
  Kirghiz = 1088,
  /// <summary>
  /// Swahili language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSwahili))]
  Swahili = 1089,
  /// <summary>
  /// Turkmen language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdTurkmen))]
  Turkmen = 1090,
  /// <summary>
  /// Uzbek Latin language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdUzbekLatin))]
  UzbekLatin = 1091,
  /// <summary>
  /// Tatar language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdTatar))]
  Tatar = 1092,
  /// <summary>
  /// Bengali language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdBengali))]
  Bengali = 1093,
  /// <summary>
  /// Punjabi language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdPunjabi))]
  Punjabi = 1094,
  /// <summary>
  /// Gujarati language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdGujarati))]
  Gujarati = 1095,
  /// <summary>
  /// Oriya language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdOriya))]
  Oriya = 1096,
  /// <summary>
  /// Tamil language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdTamil))]
  Tamil = 1097,
  /// <summary>
  /// Telugu language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdTelugu))]
  Telugu = 1098,
  /// <summary>
  /// Kannada language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdKannada))]
  Kannada = 1099,
  /// <summary>
  /// Malayalam language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdMalayalam))]
  Malayalam = 1100,
  /// <summary>
  /// Assamese language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdAssamese))]
  Assamese = 1101,
  /// <summary>
  /// Marathi language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdMarathi))]
  Marathi = 1102,
  /// <summary>
  /// Sanskrit language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSanskrit))]
  Sanskrit = 1103,
  /// <summary>
  /// Mongolian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdMongolian))]
  Mongolian = 1104,
  /// <summary>
  /// Tibetan language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdTibetan))]
  Tibetan = 1105,
  /// <summary>
  /// Welsh language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdWelsh))]
  Welsh = 1106,
  /// <summary>
  /// Khmer language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdKhmer))]
  Khmer = 1107,
  /// <summary>
  /// Lao language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdLao))]
  Lao = 1108,
  /// <summary>
  /// Burmese language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdBurmese))]
  Burmese = 1109,
  /// <summary>
  /// Galician language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdGalician))]
  Galician = 1110,
  /// <summary>
  /// Konkani language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdKonkani))]
  Konkani = 1111,
  /// <summary>
  /// Manipuri language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdManipuri))]
  Manipuri = 1112,
  /// <summary>
  /// Sindhi language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSindhi))]
  Sindhi = 1113,
  /// <summary>
  /// Syriac language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSyriac))]
  Syriac = 1114,
  /// <summary>
  /// Sinhalese language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSinhalese))]
  Sinhalese = 1115,
  /// <summary>
  /// Cherokee language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdCherokee))]
  Cherokee = 1116,
  /// <summary>
  /// Inuktitut language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdInuktitut))]
  Inuktitut = 1117,
  /// <summary>
  /// Amharic language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdAmharic))]
  Amharic = 1118,
  /// <summary>
  /// Tamazight language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdTamazight))]
  Tamazight = 1119,
  /// <summary>
  /// Kashmiri language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdKashmiri))]
  Kashmiri = 1120,
  /// <summary>
  /// Nepali language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdNepali))]
  Nepali = 1121,
  /// <summary>
  /// Frisian Netherlands language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFrisianNetherlands))]
  FrisianNetherlands = 1122,
  /// <summary>
  /// Pashto language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdPashto))]
  Pashto = 1123,
  /// <summary>
  /// Filipino language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFilipino))]
  Filipino = 1124,
  /// <summary>
  /// Divehi language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdDivehi))]
  Divehi = 1125,
  /// <summary>
  /// Edo language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEdo))]
  Edo = 1126,
  /// <summary>
  /// Fulfulde language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFulfulde))]
  Fulfulde = 1127,
  /// <summary>
  /// Hausa language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdHausa))]
  Hausa = 1128,
  /// <summary>
  /// Ibibio language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdIbibio))]
  Ibibio = 1129,
  /// <summary>
  /// Yoruba language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdYoruba))]
  Yoruba = 1130,
  /// <summary>
  /// Igbo language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdIgbo))]
  Igbo = 1136,
  /// <summary>
  /// Kanuri language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdKanuri))]
  Kanuri = 1137,
  /// <summary>
  /// Oromo language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdOromo))]
  Oromo = 1138,
  /// <summary>
  /// Tigrigna Ethiopic language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdTigrignaEthiopic))]
  TigrignaEthiopic = 1139,
  /// <summary>
  /// Guarani language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdGuarani))]
  Guarani = 1140,
  /// <summary>
  /// Hawaiian language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdHawaiian))]
  Hawaiian = 1141,
  /// <summary>
  /// Latin language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdLatin))]
  Latin = 1142,
  /// <summary>
  /// Somali language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSomali))]
  Somali = 1143,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdYi))]
  Yi = 1144,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabicIraq))]
  ArabicIraq = 2049,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSimplifiedChinese))]
  SimplifiedChinese = 2052,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSwissGerman))]
  SwissGerman = 2055,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEnglishUK))]
  EnglishUK = 2057,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdMexicanSpanish))]
  MexicanSpanish = 2058,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdBelgianFrench))]
  BelgianFrench = 2060,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSwissItalian))]
  SwissItalian = 2064,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdBelgianDutch))]
  BelgianDutch = 2067,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdNorwegianNynorsk))]
  NorwegianNynorsk = 2068,
  /// <summary>
  /// Portuguese (Brazil) language.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdPortuguese))]
  Portuguese = 2070,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdRomanianMoldova))]
  RomanianMoldova = 2072,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdRussianMoldova))]
  RussianMoldova = 2073,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSerbianLatin))]
  SerbianLatin = 2074,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSwedishFinland))]
  SwedishFinland = 2077,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdAzeriCyrillic))]
  AzeriCyrillic = 2092,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdGaelicIreland))]
  GaelicIreland = 2108,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdMalayBruneiDarussalam))]
  MalayBruneiDarussalam = 2110,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdUzbekCyrillic))]
  UzbekCyrillic = 2115,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSindhiPakistan))]
  SindhiPakistan = 2137,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdTamazightLatin))]
  TamazightLatin = 2143,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdTigrignaEritrea))]
  TigrignaEritrea = 2163,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabicEgypt))]
  ArabicEgypt = 3073,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdChineseHongKongSAR))]
  ChineseHongKongSAR = 3076,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdGermanAustria))]
  GermanAustria = 3079,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEnglishAUS))]
  EnglishAUS = 3081,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishModernSort))]
  SpanishModernSort = 3082,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFrenchCanadian))]
  FrenchCanadian = 3084,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSerbianCyrillic))]
  SerbianCyrillic = 3098,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabicLibya))]
  ArabicLibya = 4097,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdChineseSingapore))]
  ChineseSingapore = 4100,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdGermanLuxembourg))]
  GermanLuxembourg = 4103,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEnglishCanadian))]
  EnglishCanadian = 4105,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishGuatemala))]
  SpanishGuatemala = 4106,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSwissFrench))]
  SwissFrench = 4108,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabicAlgeria))]
  ArabicAlgeria = 5121,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdChineseMacaoSAR))]
  ChineseMacaoSAR = 5124,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdGermanLiechtenstein))]
  GermanLiechtenstein = 5127,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEnglishNewZealand))]
  EnglishNewZealand = 5129,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishCostaRica))]
  SpanishCostaRica = 5130,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFrenchLuxembourg))]
  FrenchLuxembourg = 5132,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabicMorocco))]
  ArabicMorocco = 6145,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEnglishIreland))]
  EnglishIreland = 6153,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishPanama))]
  SpanishPanama = 6154,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFrenchMonaco))]
  FrenchMonaco = 6156,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabicTunisia))]
  ArabicTunisia = 7169,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEnglishSouthAfrica))]
  EnglishSouthAfrica = 7177,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishDominicanRepublic))]
  SpanishDominicanRepublic = 7178,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFrenchWestIndies))]
  FrenchWestIndies = 7180,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabicOman))]
  ArabicOman = 8193,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEnglishJamaica))]
  EnglishJamaica = 8201,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishVenezuela))]
  SpanishVenezuela = 8202,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFrenchReunion))]
  FrenchReunion = 8204,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabicYemen))]
  ArabicYemen = 9217,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEnglishCaribbean))]
  EnglishCaribbean = 9225,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishColombia))]
  SpanishColombia = 9226,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFrenchCongoDRC))]
  FrenchCongoDRC = 9228,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabicSyria))]
  ArabicSyria = 10241,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEnglishBelize))]
  EnglishBelize = 10249,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishPeru))]
  SpanishPeru = 10250,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFrenchSenegal))]
  FrenchSenegal = 10252,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabicJordan))]
  ArabicJordan = 11265,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEnglishTrinidadTobago))]
  EnglishTrinidadTobago = 11273,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishArgentina))]
  SpanishArgentina = 11274,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFrenchCameroon))]
  FrenchCameroon = 11276,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabicLebanon))]
  ArabicLebanon = 12289,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEnglishZimbabwe))]
  EnglishZimbabwe = 12297,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishEcuador))]
  SpanishEcuador = 12298,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFrenchCotedIvoire))]
  FrenchCotedIvoire = 12300,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabicKuwait))]
  ArabicKuwait = 13313,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEnglishPhilippines))]
  EnglishPhilippines = 13321,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishChile))]
  SpanishChile = 13322,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFrenchMali))]
  FrenchMali = 13324,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabicUAE))]
  ArabicUAE = 14337,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdEnglishIndonesia))]
  EnglishIndonesia = 14345,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishUruguay))]
  SpanishUruguay = 14346,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFrenchMorocco))]
  FrenchMorocco = 14348,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabicBahrain))]
  ArabicBahrain = 15361,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishParaguay))]
  SpanishParaguay = 15370,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdFrenchHaiti))]
  FrenchHaiti = 15372,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdArabicQatar))]
  ArabicQatar = 16385,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishBolivia))]
  SpanishBolivia = 16394,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishElSalvador))]
  SpanishElSalvador = 17418,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishHonduras))]
  SpanishHonduras = 18442,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishNicaragua))]
  SpanishNicaragua = 19466,
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLanguageID.wdSpanishPuertoRico))]
  SpanishPuertoRico = 20490
}
