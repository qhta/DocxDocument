
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
  /// Arabic as spoken in Algeria.
  /// </summary>
  ArabicAlgeria = 5121,
  /// <summary>
  /// Arabic as spoken in Bahrain.
  /// </summary>
  ArabicBahrain = 15361,
  /// <summary>
  /// Arabic as spoken in Egypt.
  /// </summary>
  ArabicEgypt = 3073,
  /// <summary>
  /// Arabic as spoken in Iraq.
  /// </summary>
  ArabicIraq = 2049,
  /// <summary>
  /// Arabic as spoken in Jordan.
  /// </summary>
  ArabicJordan = 11265,
  /// <summary>
  /// Arabic as spoken in Kuwait.
  /// </summary>
  ArabicKuwait = 13313,
  /// <summary>
  /// Arabic as spoken in Lebanon.
  /// </summary>
  ArabicLebanon = 12289,
  /// <summary>
  /// Arabic as spoken in Libya.
  /// </summary>
  ArabicLibya = 4097,
  /// <summary>
  /// Arabic as spoken in Morocco.
  /// </summary>
  ArabicMorocco = 6145,
  /// <summary>
  /// Arabic as spoken in Oman.
  /// </summary>
  ArabicOman = 8193,
  /// <summary>
  /// Arabic as spoken in Qatar.
  /// </summary>
  ArabicQatar = 16385,
  /// <summary>
  /// Arabic.
  /// </summary>
  Arabic = 1025,
  /// <summary>
  /// Arabic as spoken in Syria.
  /// </summary>
  ArabicSyria = 10241,
  /// <summary>
  /// Arabic as spoken in Tunisia.
  /// </summary>
  ArabicTunisia = 7169,
  /// <summary>
  /// Arabic as spoken in the United Arab Emirates.
  /// </summary>
  ArabicUAE = 14337,
  /// <summary>
  /// Arabic as spoken in Yemen.
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
  /// Azeri-Cyrillic.
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
  /// Bosnian.
  /// </summary>
  Bosnian = 4122,
  /// <summary>
  /// The Bosnian Bosnia Herzegovina Cyrillic language.
  /// </summary>
  BosnianBosniaHerzegovinaCyrillic = 8218,
  /// <summary>
  /// The Bosnian Bosnia Herzegovina Latin language.
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
  /// Chinese as spoken in Hong Kong SAR.
  /// </summary>
  ChineseHongKongSAR = 3076,
  /// <summary>
  /// Chinese as spoken in Macao SAR.
  /// </summary>
  ChineseMacaoSAR = 5124,
  /// <summary>
  /// Simplified Chinese.
  /// </summary>
  SimplifiedChinese = 2052,
  /// <summary>
  /// Chinese as spoken in Singapore.
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
  /// Belgian Dutch.
  /// </summary>
  BelgianDutch = 2067,
  /// <summary>
  /// Dutch.
  /// </summary>
  Dutch = 1043,
  /// <summary>
  /// Dzongkha as spoken in Bhutan.
  /// </summary>
  DzongkhaBhutan = 2129,
  /// <summary>
  /// Edo.
  /// </summary>
  Edo = 1126,
  /// <summary>
  /// English as spoken in Australia.
  /// </summary>
  EnglishAUS = 3081,
  /// <summary>
  /// English as spoken in Belize.
  /// </summary>
  EnglishBelize = 10249,
  /// <summary>
  /// English as spoken in Canada.
  /// </summary>
  EnglishCanadian = 4105,
  /// <summary>
  /// English as spoken in the Caribbean.
  /// </summary>
  EnglishCaribbean = 9225,
  /// <summary>
  /// English as spoken in Indonesia.
  /// </summary>
  EnglishIndonesia = 14345,
  /// <summary>
  /// English as spoken in Ireland.
  /// </summary>
  EnglishIreland = 6153,
  /// <summary>
  /// English as spoken in Jamaica.
  /// </summary>
  EnglishJamaica = 8201,
  /// <summary>
  /// English as spoken in New Zealand.
  /// </summary>
  EnglishNewZealand = 5129,
  /// <summary>
  /// English as spoken in the Philippines.
  /// </summary>
  EnglishPhilippines = 13321,
  /// <summary>
  /// English as spoken in South Africa.
  /// </summary>
  EnglishSouthAfrica = 7177,
  /// <summary>
  /// English as spoken in Trinidad and Tobago.
  /// </summary>
  EnglishTrinidadTobago = 11273,
  /// <summary>
  /// English as spoken in the United Kingdom.
  /// </summary>
  EnglishUK = 2057,
  /// <summary>
  /// English as spoken in the United States.
  /// </summary>
  EnglishUS = 1033,
  /// <summary>
  /// English as spoken in Zimbabwe.
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
  /// Belgian French.
  /// </summary>
  BelgianFrench = 2060,
  /// <summary>
  /// French as spoken in Cameroon.
  /// </summary>
  FrenchCameroon = 11276,
  /// <summary>
  /// French as spoken in Canada.
  /// </summary>
  FrenchCanadian = 3084,
  /// <summary>
  /// French as spoken in Cote d'Ivoire.
  /// </summary>
  FrenchCotedIvoire = 12300,
  /// <summary>
  /// French.
  /// </summary>
  French = 1036,
  /// <summary>
  /// French as spoken in Haiti.
  /// </summary>
  FrenchHaiti = 15372,
  /// <summary>
  /// French as spoken in Luxembourg.
  /// </summary>
  FrenchLuxembourg = 5132,
  /// <summary>
  /// French as spoken in Mali.
  /// </summary>
  FrenchMali = 13324,
  /// <summary>
  /// French as spoken in Monaco.
  /// </summary>
  FrenchMonaco = 6156,
  /// <summary>
  /// French as spoken in Morocco.
  /// </summary>
  FrenchMorocco = 14348,
  /// <summary>
  /// French as spoken in French Reunion Island.
  /// </summary>
  FrenchReunion = 8204,
  /// <summary>
  /// French as spoken in Senegal.
  /// </summary>
  FrenchSenegal = 10252,
  /// <summary>
  /// French as spoken in Switzerland.
  /// </summary>
  SwissFrench = 4108,
  /// <summary>
  /// French as spoken in the West Indies.
  /// </summary>
  FrenchWestIndies = 7180,
  /// <summary>
  /// French as spoken in Zaire.
  /// </summary>
  FrenchZaire = 9228,
  /// <summary>
  /// The French Congo DRC language.
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
  /// Gaelic as spoken in Ireland.
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
  /// German as spoken in Austria.
  /// </summary>
  GermanAustria = 3079,
  /// <summary>
  /// German.
  /// </summary>
  German = 1031,
  /// <summary>
  /// German as spoken in Liechtenstein.
  /// </summary>
  GermanLiechtenstein = 5127,
  /// <summary>
  /// German as spoken in Luxembourg.
  /// </summary>
  GermanLuxembourg = 4103,
  /// <summary>
  /// German as spoken in Switzerland.
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
  /// Italian as spoken in Switzerland.
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
  /// Kashmiri in Devanagari script.
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
  /// Malay as spoken in Brunei Darussalam.
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
  /// Maori.
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
  /// Nynorsk as spoken in Norway.
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
  /// Portuguese.
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
  /// Quechua as spoken in Ecuador.
  /// </summary>
  QuechuaEcuador = 2155,
  /// <summary>
  /// Quechua as spoken in Peru.
  /// </summary>
  QuechuaPeru = 3179,
  /// <summary>
  /// Rhaeto-Romanic.
  /// </summary>
  RhaetoRomanic = 1047,
  /// <summary>
  /// Romanian as spoken in Moldova.
  /// </summary>
  RomanianMoldova = 2072,
  /// <summary>
  /// Romanian.
  /// </summary>
  Romanian = 1048,
  /// <summary>
  /// Russian as spoken in Moldova.
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
  /// The Serbian Bosnia Herzegovina Cyrillic language.
  /// </summary>
  SerbianBosniaHerzegovinaCyrillic = 7194,
  /// <summary>
  /// The Serbian Bosnia Herzegovina Latin language.
  /// </summary>
  SerbianBosniaHerzegovinaLatin = 6170,
  /// <summary>
  /// Serbian/Cyrillic.
  /// </summary>
  SerbianCyrillic = 3098,
  /// <summary>
  /// Serbian/Latin.
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
  /// Sindhi as spoken in Pakistan.
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
  /// Somali.
  /// </summary>
  Somali = 1143,
  /// <summary>
  /// Sorbian.
  /// </summary>
  Sorbian = 1070,
  /// <summary>
  /// Spanish as spoken in Argentina.
  /// </summary>
  SpanishArgentina = 11274,
  /// <summary>
  /// Spanish as spoken in Bolivia.
  /// </summary>
  SpanishBolivia = 16394,
  /// <summary>
  /// Spanish as spoken in Chile.
  /// </summary>
  SpanishChile = 13322,
  /// <summary>
  /// Spanish as spoken in Colombia.
  /// </summary>
  SpanishColombia = 9226,
  /// <summary>
  /// Spanish as spoken in Costa Rica.
  /// </summary>
  SpanishCostaRica = 5130,
  /// <summary>
  /// Spanish as spoken in the Dominican Republic.
  /// </summary>
  SpanishDominicanRepublic = 7178,
  /// <summary>
  /// Spanish as spoken in Ecuador.
  /// </summary>
  SpanishEcuador = 12298,
  /// <summary>
  /// Spanish as spoken in El Salvador.
  /// </summary>
  SpanishElSalvador = 17418,
  /// <summary>
  /// Spanish as spoken in Guatemala.
  /// </summary>
  SpanishGuatemala = 4106,
  /// <summary>
  /// Spanish as spoken in Honduras.
  /// </summary>
  SpanishHonduras = 18442,
  /// <summary>
  /// Spanish as spoken in Mexico.
  /// </summary>
  MexicanSpanish = 2058,
  /// <summary>
  /// Spanish as spoken in Nicaragua.
  /// </summary>
  SpanishNicaragua = 19466,
  /// <summary>
  /// Spanish as spoken in Panama.
  /// </summary>
  SpanishPanama = 6154,
  /// <summary>
  /// Spanish as spoken in Paraguay.
  /// </summary>
  SpanishParaguay = 15370,
  /// <summary>
  /// Spanish as spoken in Peru.
  /// </summary>
  SpanishPeru = 10250,
  /// <summary>
  /// Spanish as spoken in Puerto Rico.
  /// </summary>
  SpanishPuertoRico = 20490,
  /// <summary>
  /// Spanish (Modern Sort).
  /// </summary>
  SpanishModernSort = 3082,
  /// <summary>
  /// Spanish.
  /// </summary>
  Spanish = 1034,
  /// <summary>
  /// Spanish as spoken in Uruguay.
  /// </summary>
  SpanishUruguay = 14346,
  /// <summary>
  /// Spanish as spoken in Venezuela.
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
  /// Swedish as spoken in Finland.
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
  /// Tamazight (Latin).
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
  /// Tigrigna as spoken in Eritrea.
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
  /// Uzbek (Cyrillic).
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
  /// Yi.
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
