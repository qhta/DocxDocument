namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the language to use.
/// </summary>
public enum WdLanguageID
{
  /// <summary>
  /// No specified language.
  /// </summary>
  wdLanguageNone = unchecked((int)0),
  /// <summary>
  /// Disables proofing if the language ID identifies a language in which an object is grammatically validated using
  /// the Word proofing tools.
  /// </summary>
  wdNoProofing = unchecked((int)1024),
  /// <summary>
  /// Arabic language.
  /// </summary>
  wdArabic = unchecked((int)1025),
  /// <summary>
  /// Bulgarian language.
  /// </summary>
  wdBulgarian = unchecked((int)1026),
  /// <summary>
  /// Catalan language.
  /// </summary>
  wdCatalan = unchecked((int)1027),
  /// <summary>
  /// Traditional Chinese language.
  /// </summary>
  wdTraditionalChinese = unchecked((int)1028),
  /// <summary>
  /// Czech language.
  /// </summary>
  wdCzech = unchecked((int)1029),
  /// <summary>
  /// Danish language.
  /// </summary>
  wdDanish = unchecked((int)1030),
  /// <summary>
  /// German language.
  /// </summary>
  wdGerman = unchecked((int)1031),
  /// <summary>
  /// Greek language. [System.Runtime.InteropServices.Guid("1614FDAC-2173-3FB1-ADD3-1A35B81F8897")] public enum
  /// WdLanguageID ﾉ Expand table
  /// </summary>
  wdGreek = unchecked((int)1032),
  /// <summary>
  /// United States English language.
  /// </summary>
  wdEnglishUS = unchecked((int)1033),
  /// <summary>
  /// Spanish language.
  /// </summary>
  wdSpanish = unchecked((int)1034),
  /// <summary>
  /// Finnish language.
  /// </summary>
  wdFinnish = unchecked((int)1035),
  /// <summary>
  /// French language.
  /// </summary>
  wdFrench = unchecked((int)1036),
  /// <summary>
  /// Hebrew language.
  /// </summary>
  wdHebrew = unchecked((int)1037),
  /// <summary>
  /// Hungarian language.
  /// </summary>
  wdHungarian = unchecked((int)1038),
  /// <summary>
  /// Icelandic language.
  /// </summary>
  wdIcelandic = unchecked((int)1039),
  /// <summary>
  /// Italian language.
  /// </summary>
  wdItalian = unchecked((int)1040),
  /// <summary>
  /// Japanese language.
  /// </summary>
  wdJapanese = unchecked((int)1041),
  /// <summary>
  /// Korean language.
  /// </summary>
  wdKorean = unchecked((int)1042),
  /// <summary>
  /// Dutch language.
  /// </summary>
  wdDutch = unchecked((int)1043),
  /// <summary>
  /// Norwegian Bokmol language.
  /// </summary>
  wdNorwegianBokmol = unchecked((int)1044),
  /// <summary>
  /// Polish language.
  /// </summary>
  wdPolish = unchecked((int)1045),
  /// <summary>
  /// Portuguese (Brazil) language.
  /// </summary>
  wdPortugueseBrazil = unchecked((int)1046),
  /// <summary>
  /// Rhaeto Romanic language.
  /// </summary>
  wdRhaetoRomanic = unchecked((int)1047),
  /// <summary>
  /// Romanian language.
  /// </summary>
  wdRomanian = unchecked((int)1048),
  /// <summary>
  /// Russian language.
  /// </summary>
  wdRussian = unchecked((int)1049),
  /// <summary>
  /// Croatian language.
  /// </summary>
  wdCroatian = unchecked((int)1050),
  /// <summary>
  /// Slovakian language.
  /// </summary>
  wdSlovak = unchecked((int)1051),
  /// <summary>
  /// Albanian language.
  /// </summary>
  wdAlbanian = unchecked((int)1052),
  /// <summary>
  /// Swedish language.
  /// </summary>
  wdSwedish = unchecked((int)1053),
  /// <summary>
  /// Thai language.
  /// </summary>
  wdThai = unchecked((int)1054),
  /// <summary>
  /// Turkish language.
  /// </summary>
  wdTurkish = unchecked((int)1055),
  /// <summary>
  /// Urdu language.
  /// </summary>
  wdUrdu = unchecked((int)1056),
  /// <summary>
  /// Indonesian language.
  /// </summary>
  wdIndonesian = unchecked((int)1057),
  /// <summary>
  /// Ukrainian language.
  /// </summary>
  wdUkrainian = unchecked((int)1058),
  /// <summary>
  /// Belarusian language.
  /// </summary>
  wdByelorussian = unchecked((int)1059),
  /// <summary>
  /// Slovenian language.
  /// </summary>
  wdSlovenian = unchecked((int)1060),
  /// <summary>
  /// Estonian language.
  /// </summary>
  wdEstonian = unchecked((int)1061),
  /// <summary>
  /// Latvian language.
  /// </summary>
  wdLatvian = unchecked((int)1062),
  /// <summary>
  /// Lithuanian language.
  /// </summary>
  wdLithuanian = unchecked((int)1063),
  /// <summary>
  /// Tajik language.
  /// </summary>
  wdTajik = unchecked((int)1064),
  /// <summary>
  /// Persian language.
  /// </summary>
  wdPersian = unchecked((int)1065),
  /// <summary>
  /// Vietnamese language.
  /// </summary>
  wdVietnamese = unchecked((int)1066),
  /// <summary>
  /// Armenian language.
  /// </summary>
  wdArmenian = unchecked((int)1067),
  /// <summary>
  /// Azeri Latin language.
  /// </summary>
  wdAzeriLatin = unchecked((int)1068),
  /// <summary>
  /// Basque language.
  /// </summary>
  wdBasque = unchecked((int)1069),
  /// <summary>
  /// Sorbian language.
  /// </summary>
  wdSorbian = unchecked((int)1070),
  /// <summary>
  /// Macedonian (FYROM) language.
  /// </summary>
  wdMacedonianFYROM = unchecked((int)1071),
  /// <summary>
  /// Sutu language.
  /// </summary>
  wdSutu = unchecked((int)1072),
  /// <summary>
  /// Sesotho language.
  /// </summary>
  wdSesotho = unchecked((int)1072),
  /// <summary>
  /// Tsonga language.
  /// </summary>
  wdTsonga = unchecked((int)1073),
  /// <summary>
  /// Tswana language.
  /// </summary>
  wdTswana = unchecked((int)1074),
  /// <summary>
  /// Venda language.
  /// </summary>
  wdVenda = unchecked((int)1075),
  /// <summary>
  /// Xhosa language.
  /// </summary>
  wdXhosa = unchecked((int)1076),
  /// <summary>
  /// Zulu language.
  /// </summary>
  wdZulu = unchecked((int)1077),
  /// <summary>
  /// African language.
  /// </summary>
  wdAfrikaans = unchecked((int)1078),
  /// <summary>
  /// Georgian language.
  /// </summary>
  wdGeorgian = unchecked((int)1079),
  /// <summary>
  /// Faeroese language.
  /// </summary>
  wdFaeroese = unchecked((int)1080),
  /// <summary>
  /// Hindi language.
  /// </summary>
  wdHindi = unchecked((int)1081),
  /// <summary>
  /// Maltese language.
  /// </summary>
  wdMaltese = unchecked((int)1082),
  /// <summary>
  /// Sami Lappish language.
  /// </summary>
  wdSamiLappish = unchecked((int)1083),
  /// <summary>
  /// Gaelic Scottish language.
  /// </summary>
  wdGaelicScotland = unchecked((int)1084),
  /// <summary>
  /// Yiddish language.
  /// </summary>
  wdYiddish = unchecked((int)1085),
  /// <summary>
  /// Malaysian language.
  /// </summary>
  wdMalaysian = unchecked((int)1086),
  /// <summary>
  /// Kazakh language.
  /// </summary>
  wdKazakh = unchecked((int)1087),
  /// <summary>
  /// Kyrgyz language.
  /// </summary>
  wdKyrgyz = unchecked((int)1088),
  /// <summary>
  /// Kirghiz language.
  /// </summary>
  wdKirghiz = unchecked((int)1088),
  /// <summary>
  /// Swahili language.
  /// </summary>
  wdSwahili = unchecked((int)1089),
  /// <summary>
  /// Turkmen language.
  /// </summary>
  wdTurkmen = unchecked((int)1090),
  /// <summary>
  /// Uzbek Latin language.
  /// </summary>
  wdUzbekLatin = unchecked((int)1091),
  /// <summary>
  /// Tatar language.
  /// </summary>
  wdTatar = unchecked((int)1092),
  /// <summary>
  /// Bengali language.
  /// </summary>
  wdBengali = unchecked((int)1093),
  /// <summary>
  /// Punjabi language.
  /// </summary>
  wdPunjabi = unchecked((int)1094),
  /// <summary>
  /// Gujarati language.
  /// </summary>
  wdGujarati = unchecked((int)1095),
  /// <summary>
  /// Oriya language.
  /// </summary>
  wdOriya = unchecked((int)1096),
  /// <summary>
  /// Tamil language.
  /// </summary>
  wdTamil = unchecked((int)1097),
  /// <summary>
  /// Telugu language.
  /// </summary>
  wdTelugu = unchecked((int)1098),
  /// <summary>
  /// Kannada language.
  /// </summary>
  wdKannada = unchecked((int)1099),
  /// <summary>
  /// Malayalam language.
  /// </summary>
  wdMalayalam = unchecked((int)1100),
  /// <summary>
  /// Assamese language.
  /// </summary>
  wdAssamese = unchecked((int)1101),
  /// <summary>
  /// Marathi language.
  /// </summary>
  wdMarathi = unchecked((int)1102),
  /// <summary>
  /// Sanskrit language.
  /// </summary>
  wdSanskrit = unchecked((int)1103),
  /// <summary>
  /// Mongolian language.
  /// </summary>
  wdMongolian = unchecked((int)1104),
  /// <summary>
  /// Tibetan language.
  /// </summary>
  wdTibetan = unchecked((int)1105),
  /// <summary>
  /// Welsh language.
  /// </summary>
  wdWelsh = unchecked((int)1106),
  /// <summary>
  /// Khmer language.
  /// </summary>
  wdKhmer = unchecked((int)1107),
  /// <summary>
  /// Lao language.
  /// </summary>
  wdLao = unchecked((int)1108),
  /// <summary>
  /// Burmese language.
  /// </summary>
  wdBurmese = unchecked((int)1109),
  /// <summary>
  /// Galician language.
  /// </summary>
  wdGalician = unchecked((int)1110),
  /// <summary>
  /// Konkani language.
  /// </summary>
  wdKonkani = unchecked((int)1111),
  /// <summary>
  /// Manipuri language.
  /// </summary>
  wdManipuri = unchecked((int)1112),
  /// <summary>
  /// Sindhi language.
  /// </summary>
  wdSindhi = unchecked((int)1113),
  /// <summary>
  /// Syriac language.
  /// </summary>
  wdSyriac = unchecked((int)1114),
  /// <summary>
  /// Sinhalese language.
  /// </summary>
  wdSinhalese = unchecked((int)1115),
  /// <summary>
  /// Cherokee language.
  /// </summary>
  wdCherokee = unchecked((int)1116),
  /// <summary>
  /// Inuktitut language.
  /// </summary>
  wdInuktitut = unchecked((int)1117),
  /// <summary>
  /// Amharic language.
  /// </summary>
  wdAmharic = unchecked((int)1118),
  /// <summary>
  /// Tamazight language.
  /// </summary>
  wdTamazight = unchecked((int)1119),
  /// <summary>
  /// Kashmiri language.
  /// </summary>
  wdKashmiri = unchecked((int)1120),
  /// <summary>
  /// Nepali language.
  /// </summary>
  wdNepali = unchecked((int)1121),
  /// <summary>
  /// Frisian Netherlands language.
  /// </summary>
  wdFrisianNetherlands = unchecked((int)1122),
  /// <summary>
  /// Pashto language.
  /// </summary>
  wdPashto = unchecked((int)1123),
  /// <summary>
  /// Filipino language.
  /// </summary>
  wdFilipino = unchecked((int)1124),
  /// <summary>
  /// Divehi language.
  /// </summary>
  wdDivehi = unchecked((int)1125),
  /// <summary>
  /// Edo language.
  /// </summary>
  wdEdo = unchecked((int)1126),
  /// <summary>
  /// Fulfulde language.
  /// </summary>
  wdFulfulde = unchecked((int)1127),
  /// <summary>
  /// Hausa language.
  /// </summary>
  wdHausa = unchecked((int)1128),
  /// <summary>
  /// Ibibio language.
  /// </summary>
  wdIbibio = unchecked((int)1129),
  /// <summary>
  /// Yoruba language.
  /// </summary>
  wdYoruba = unchecked((int)1130),
  /// <summary>
  /// Igbo language.
  /// </summary>
  wdIgbo = unchecked((int)1136),
  /// <summary>
  /// Kanuri language.
  /// </summary>
  wdKanuri = unchecked((int)1137),
  /// <summary>
  /// Oromo language.
  /// </summary>
  wdOromo = unchecked((int)1138),
  /// <summary>
  /// Tigrigna Ethiopic language.
  /// </summary>
  wdTigrignaEthiopic = unchecked((int)1139),
  /// <summary>
  /// Guarani language.
  /// </summary>
  wdGuarani = unchecked((int)1140),
  /// <summary>
  /// Hawaiian language.
  /// </summary>
  wdHawaiian = unchecked((int)1141),
  /// <summary>
  /// Latin language.
  /// </summary>
  wdLatin = unchecked((int)1142),
  /// <summary>
  /// Somali language.
  /// </summary>
  wdSomali = unchecked((int)1143),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdYi = unchecked((int)1144),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdArabicIraq = unchecked((int)2049),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSimplifiedChinese = unchecked((int)2052),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSwissGerman = unchecked((int)2055),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdEnglishUK = unchecked((int)2057),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdMexicanSpanish = unchecked((int)2058),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdBelgianFrench = unchecked((int)2060),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSwissItalian = unchecked((int)2064),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdBelgianDutch = unchecked((int)2067),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdNorwegianNynorsk = unchecked((int)2068),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdPortuguese = unchecked((int)2070),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdRomanianMoldova = unchecked((int)2072),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdRussianMoldova = unchecked((int)2073),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSerbianLatin = unchecked((int)2074),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSwedishFinland = unchecked((int)2077),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdAzeriCyrillic = unchecked((int)2092),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdGaelicIreland = unchecked((int)2108),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdMalayBruneiDarussalam = unchecked((int)2110),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdUzbekCyrillic = unchecked((int)2115),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSindhiPakistan = unchecked((int)2137),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdTamazightLatin = unchecked((int)2143),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdTigrignaEritrea = unchecked((int)2163),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdArabicEgypt = unchecked((int)3073),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdChineseHongKongSAR = unchecked((int)3076),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdGermanAustria = unchecked((int)3079),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdEnglishAUS = unchecked((int)3081),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishModernSort = unchecked((int)3082),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdFrenchCanadian = unchecked((int)3084),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSerbianCyrillic = unchecked((int)3098),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdArabicLibya = unchecked((int)4097),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdChineseSingapore = unchecked((int)4100),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdGermanLuxembourg = unchecked((int)4103),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdEnglishCanadian = unchecked((int)4105),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishGuatemala = unchecked((int)4106),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSwissFrench = unchecked((int)4108),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdArabicAlgeria = unchecked((int)5121),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdChineseMacaoSAR = unchecked((int)5124),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdGermanLiechtenstein = unchecked((int)5127),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdEnglishNewZealand = unchecked((int)5129),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishCostaRica = unchecked((int)5130),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdFrenchLuxembourg = unchecked((int)5132),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdArabicMorocco = unchecked((int)6145),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdEnglishIreland = unchecked((int)6153),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishPanama = unchecked((int)6154),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdFrenchMonaco = unchecked((int)6156),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdArabicTunisia = unchecked((int)7169),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdEnglishSouthAfrica = unchecked((int)7177),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishDominicanRepublic = unchecked((int)7178),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdFrenchWestIndies = unchecked((int)7180),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdArabicOman = unchecked((int)8193),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdEnglishJamaica = unchecked((int)8201),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishVenezuela = unchecked((int)8202),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdFrenchReunion = unchecked((int)8204),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdArabicYemen = unchecked((int)9217),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdEnglishCaribbean = unchecked((int)9225),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishColombia = unchecked((int)9226),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdFrenchCongoDRC = unchecked((int)9228),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdArabicSyria = unchecked((int)10241),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdEnglishBelize = unchecked((int)10249),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishPeru = unchecked((int)10250),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdFrenchSenegal = unchecked((int)10252),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdArabicJordan = unchecked((int)11265),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdEnglishTrinidadTobago = unchecked((int)11273),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishArgentina = unchecked((int)11274),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdFrenchCameroon = unchecked((int)11276),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdArabicLebanon = unchecked((int)12289),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdEnglishZimbabwe = unchecked((int)12297),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishEcuador = unchecked((int)12298),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdFrenchCotedIvoire = unchecked((int)12300),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdArabicKuwait = unchecked((int)13313),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdEnglishPhilippines = unchecked((int)13321),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishChile = unchecked((int)13322),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdFrenchMali = unchecked((int)13324),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdArabicUAE = unchecked((int)14337),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdEnglishIndonesia = unchecked((int)14345),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishUruguay = unchecked((int)14346),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdFrenchMorocco = unchecked((int)14348),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdArabicBahrain = unchecked((int)15361),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishParaguay = unchecked((int)15370),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdFrenchHaiti = unchecked((int)15372),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdArabicQatar = unchecked((int)16385),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishBolivia = unchecked((int)16394),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishElSalvador = unchecked((int)17418),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishHonduras = unchecked((int)18442),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishNicaragua = unchecked((int)19466),
  /// <summary>
  /// Specifies the language to use.
  /// </summary>
  wdSpanishPuertoRico = unchecked((int)20490)
}
