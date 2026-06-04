
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which language to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolanguageid?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoLanguageID")]
public enum LanguageID
{
  /// <summary>
  /// Mixed languages.
  /// </summary>
  [InteropEnumValue("msoLanguageIDMixed")]
  Mixed = -2,
  /// <summary>
  /// No language specified.
  /// </summary>
  [InteropEnumValue("msoLanguageIDNone")]
  None = 0,
  /// <summary>
  /// No proofing requested.
  /// </summary>
  [InteropEnumValue("msoLanguageIDNoProofing")]
  NoProofing = 1024,
  /// <summary>
  /// Afrikaans.
  /// </summary>
  [InteropEnumValue("msoLanguageIDAfrikaans")]
  Afrikaans = 1078,
  /// <summary>
  /// Albanian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDAlbanian")]
  Albanian = 1052,
  /// <summary>
  /// Amharic.
  /// </summary>
  [InteropEnumValue("msoLanguageIDAmharic")]
  Amharic = 1118,
  /// <summary>
  /// Arabic as spoken in Algeria.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabicAlgeria")]
  ArabicAlgeria = 5121,
  /// <summary>
  /// Arabic as spoken in Bahrain.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabicBahrain")]
  ArabicBahrain = 15361,
  /// <summary>
  /// Arabic as spoken in Egypt.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabicEgypt")]
  ArabicEgypt = 3073,
  /// <summary>
  /// Arabic as spoken in Iraq.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabicIraq")]
  ArabicIraq = 2049,
  /// <summary>
  /// Arabic as spoken in Jordan.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabicJordan")]
  ArabicJordan = 11265,
  /// <summary>
  /// Arabic as spoken in Kuwait.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabicKuwait")]
  ArabicKuwait = 13313,
  /// <summary>
  /// Arabic as spoken in Lebanon.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabicLebanon")]
  ArabicLebanon = 12289,
  /// <summary>
  /// Arabic as spoken in Libya.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabicLibya")]
  ArabicLibya = 4097,
  /// <summary>
  /// Arabic as spoken in Morocco.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabicMorocco")]
  ArabicMorocco = 6145,
  /// <summary>
  /// Arabic as spoken in Oman.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabicOman")]
  ArabicOman = 8193,
  /// <summary>
  /// Arabic as spoken in Qatar.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabicQatar")]
  ArabicQatar = 16385,
  /// <summary>
  /// Arabic.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabic")]
  Arabic = 1025,
  /// <summary>
  /// Arabic as spoken in Syria.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabicSyria")]
  ArabicSyria = 10241,
  /// <summary>
  /// Arabic as spoken in Tunisia.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabicTunisia")]
  ArabicTunisia = 7169,
  /// <summary>
  /// Arabic as spoken in the United Arab Emirates.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabicUAE")]
  ArabicUAE = 14337,
  /// <summary>
  /// Arabic as spoken in Yemen.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArabicYemen")]
  ArabicYemen = 9217,
  /// <summary>
  /// Armenian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDArmenian")]
  Armenian = 1067,
  /// <summary>
  /// Assamese.
  /// </summary>
  [InteropEnumValue("msoLanguageIDAssamese")]
  Assamese = 1101,
  /// <summary>
  /// Azeri-Cyrillic.
  /// </summary>
  [InteropEnumValue("msoLanguageIDAzeriCyrillic")]
  AzeriCyrillic = 2092,
  /// <summary>
  /// Azeri-Latin.
  /// </summary>
  [InteropEnumValue("msoLanguageIDAzeriLatin")]
  AzeriLatin = 1068,
  /// <summary>
  /// Basque.
  /// </summary>
  [InteropEnumValue("msoLanguageIDBasque")]
  Basque = 1069,
  /// <summary>
  /// Belarusian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDByelorussian")]
  Byelorussian = 1059,
  /// <summary>
  /// Bengali.
  /// </summary>
  [InteropEnumValue("msoLanguageIDBengali")]
  Bengali = 1093,
  /// <summary>
  /// Bosnian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDBosnian")]
  Bosnian = 4122,
  /// <summary>
  /// The Bosnian Bosnia Herzegovina Cyrillic language.
  /// </summary>
  [InteropEnumValue("msoLanguageIDBosnianBosniaHerzegovinaCyrillic")]
  BosnianBosniaHerzegovinaCyrillic = 8218,
  /// <summary>
  /// The Bosnian Bosnia Herzegovina Latin language.
  /// </summary>
  [InteropEnumValue("msoLanguageIDBosnianBosniaHerzegovinaLatin")]
  BosnianBosniaHerzegovinaLatin = 5146,
  /// <summary>
  /// Bulgarian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDBulgarian")]
  Bulgarian = 1026,
  /// <summary>
  /// Burmese.
  /// </summary>
  [InteropEnumValue("msoLanguageIDBurmese")]
  Burmese = 1109,
  /// <summary>
  /// Catalan.
  /// </summary>
  [InteropEnumValue("msoLanguageIDCatalan")]
  Catalan = 1027,
  /// <summary>
  /// Chinese as spoken in Hong Kong SAR.
  /// </summary>
  [InteropEnumValue("msoLanguageIDChineseHongKongSAR")]
  ChineseHongKongSAR = 3076,
  /// <summary>
  /// Chinese as spoken in Macao SAR.
  /// </summary>
  [InteropEnumValue("msoLanguageIDChineseMacaoSAR")]
  ChineseMacaoSAR = 5124,
  /// <summary>
  /// Simplified Chinese.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSimplifiedChinese")]
  SimplifiedChinese = 2052,
  /// <summary>
  /// Chinese as spoken in Singapore.
  /// </summary>
  [InteropEnumValue("msoLanguageIDChineseSingapore")]
  ChineseSingapore = 4100,
  /// <summary>
  /// Traditional Chinese.
  /// </summary>
  [InteropEnumValue("msoLanguageIDTraditionalChinese")]
  TraditionalChinese = 1028,
  /// <summary>
  /// Cherokee.
  /// </summary>
  [InteropEnumValue("msoLanguageIDCherokee")]
  Cherokee = 1116,
  /// <summary>
  /// Croatian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDCroatian")]
  Croatian = 1050,
  /// <summary>
  /// Czech.
  /// </summary>
  [InteropEnumValue("msoLanguageIDCzech")]
  Czech = 1029,
  /// <summary>
  /// Danish.
  /// </summary>
  [InteropEnumValue("msoLanguageIDDanish")]
  Danish = 1030,
  /// <summary>
  /// Divehi.
  /// </summary>
  [InteropEnumValue("msoLanguageIDDivehi")]
  Divehi = 1125,
  /// <summary>
  /// Belgian Dutch.
  /// </summary>
  [InteropEnumValue("msoLanguageIDBelgianDutch")]
  BelgianDutch = 2067,
  /// <summary>
  /// Dutch.
  /// </summary>
  [InteropEnumValue("msoLanguageIDDutch")]
  Dutch = 1043,
  /// <summary>
  /// Dzongkha as spoken in Bhutan.
  /// </summary>
  [InteropEnumValue("msoLanguageIDDzongkhaBhutan")]
  DzongkhaBhutan = 2129,
  /// <summary>
  /// Edo.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEdo")]
  Edo = 1126,
  /// <summary>
  /// English as spoken in Australia.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEnglishAUS")]
  EnglishAUS = 3081,
  /// <summary>
  /// English as spoken in Belize.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEnglishBelize")]
  EnglishBelize = 10249,
  /// <summary>
  /// English as spoken in Canada.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEnglishCanadian")]
  EnglishCanadian = 4105,
  /// <summary>
  /// English as spoken in the Caribbean.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEnglishCaribbean")]
  EnglishCaribbean = 9225,
  /// <summary>
  /// English as spoken in Indonesia.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEnglishIndonesia")]
  EnglishIndonesia = 14345,
  /// <summary>
  /// English as spoken in Ireland.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEnglishIreland")]
  EnglishIreland = 6153,
  /// <summary>
  /// English as spoken in Jamaica.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEnglishJamaica")]
  EnglishJamaica = 8201,
  /// <summary>
  /// English as spoken in New Zealand.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEnglishNewZealand")]
  EnglishNewZealand = 5129,
  /// <summary>
  /// English as spoken in the Philippines.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEnglishPhilippines")]
  EnglishPhilippines = 13321,
  /// <summary>
  /// English as spoken in South Africa.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEnglishSouthAfrica")]
  EnglishSouthAfrica = 7177,
  /// <summary>
  /// English as spoken in Trinidad and Tobago.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEnglishTrinidadTobago")]
  EnglishTrinidadTobago = 11273,
  /// <summary>
  /// English as spoken in the United Kingdom.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEnglishUK")]
  EnglishUK = 2057,
  /// <summary>
  /// English as spoken in the United States.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEnglishUS")]
  EnglishUS = 1033,
  /// <summary>
  /// English as spoken in Zimbabwe.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEnglishZimbabwe")]
  EnglishZimbabwe = 12297,
  /// <summary>
  /// Estonian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDEstonian")]
  Estonian = 1061,
  /// <summary>
  /// Faeroese.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFaeroese")]
  Faeroese = 1080,
  /// <summary>
  /// Farsi.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFarsi")]
  Farsi = 1065,
  /// <summary>
  /// Filipina.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFilipino")]
  Filipino = 1124,
  /// <summary>
  /// Finnish.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFinnish")]
  Finnish = 1035,
  /// <summary>
  /// Belgian French.
  /// </summary>
  [InteropEnumValue("msoLanguageIDBelgianFrench")]
  BelgianFrench = 2060,
  /// <summary>
  /// French as spoken in Cameroon.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFrenchCameroon")]
  FrenchCameroon = 11276,
  /// <summary>
  /// French as spoken in Canada.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFrenchCanadian")]
  FrenchCanadian = 3084,
  /// <summary>
  /// French as spoken in Cote d'Ivoire.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFrenchCotedIvoire")]
  FrenchCotedIvoire = 12300,
  /// <summary>
  /// French.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFrench")]
  French = 1036,
  /// <summary>
  /// French as spoken in Haiti.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFrenchHaiti")]
  FrenchHaiti = 15372,
  /// <summary>
  /// French as spoken in Luxembourg.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFrenchLuxembourg")]
  FrenchLuxembourg = 5132,
  /// <summary>
  /// French as spoken in Mali.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFrenchMali")]
  FrenchMali = 13324,
  /// <summary>
  /// French as spoken in Monaco.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFrenchMonaco")]
  FrenchMonaco = 6156,
  /// <summary>
  /// French as spoken in Morocco.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFrenchMorocco")]
  FrenchMorocco = 14348,
  /// <summary>
  /// French as spoken in French Reunion Island.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFrenchReunion")]
  FrenchReunion = 8204,
  /// <summary>
  /// French as spoken in Senegal.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFrenchSenegal")]
  FrenchSenegal = 10252,
  /// <summary>
  /// French as spoken in Switzerland.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSwissFrench")]
  SwissFrench = 4108,
  /// <summary>
  /// French as spoken in the West Indies.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFrenchWestIndies")]
  FrenchWestIndies = 7180,
  /// <summary>
  /// French as spoken in Zaire.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFrenchZaire")]
  FrenchZaire = 9228,
  /// <summary>
  /// The French Congo DRC language.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFrenchCongoDRC")]
  FrenchCongoDRC = 9228,
  /// <summary>
  /// Frisian as spoken in the Netherlands.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFrisianNetherlands")]
  FrisianNetherlands = 1122,
  /// <summary>
  /// Fulfulde.
  /// </summary>
  [InteropEnumValue("msoLanguageIDFulfulde")]
  Fulfulde = 1127,
  /// <summary>
  /// Gaelic as spoken in Ireland.
  /// </summary>
  [InteropEnumValue("msoLanguageIDGaelicIreland")]
  GaelicIreland = 2108,
  /// <summary>
  /// Gaelic as spoken in Scotland.
  /// </summary>
  [InteropEnumValue("msoLanguageIDGaelicScotland")]
  GaelicScotland = 1084,
  /// <summary>
  /// Galician.
  /// </summary>
  [InteropEnumValue("msoLanguageIDGalician")]
  Galician = 1110,
  /// <summary>
  /// Georgian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDGeorgian")]
  Georgian = 1079,
  /// <summary>
  /// German as spoken in Austria.
  /// </summary>
  [InteropEnumValue("msoLanguageIDGermanAustria")]
  GermanAustria = 3079,
  /// <summary>
  /// German.
  /// </summary>
  [InteropEnumValue("msoLanguageIDGerman")]
  German = 1031,
  /// <summary>
  /// German as spoken in Liechtenstein.
  /// </summary>
  [InteropEnumValue("msoLanguageIDGermanLiechtenstein")]
  GermanLiechtenstein = 5127,
  /// <summary>
  /// German as spoken in Luxembourg.
  /// </summary>
  [InteropEnumValue("msoLanguageIDGermanLuxembourg")]
  GermanLuxembourg = 4103,
  /// <summary>
  /// German as spoken in Switzerland.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSwissGerman")]
  SwissGerman = 2055,
  /// <summary>
  /// Greek.
  /// </summary>
  [InteropEnumValue("msoLanguageIDGreek")]
  Greek = 1032,
  /// <summary>
  /// Guarani.
  /// </summary>
  [InteropEnumValue("msoLanguageIDGuarani")]
  Guarani = 1140,
  /// <summary>
  /// Gujarati.
  /// </summary>
  [InteropEnumValue("msoLanguageIDGujarati")]
  Gujarati = 1095,
  /// <summary>
  /// Hausa.
  /// </summary>
  [InteropEnumValue("msoLanguageIDHausa")]
  Hausa = 1128,
  /// <summary>
  /// Hawaiian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDHawaiian")]
  Hawaiian = 1141,
  /// <summary>
  /// Hebrew.
  /// </summary>
  [InteropEnumValue("msoLanguageIDHebrew")]
  Hebrew = 1037,
  /// <summary>
  /// Hindi.
  /// </summary>
  [InteropEnumValue("msoLanguageIDHindi")]
  Hindi = 1081,
  /// <summary>
  /// Hungarian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDHungarian")]
  Hungarian = 1038,
  /// <summary>
  /// Ibibio.
  /// </summary>
  [InteropEnumValue("msoLanguageIDIbibio")]
  Ibibio = 1129,
  /// <summary>
  /// Icelandic.
  /// </summary>
  [InteropEnumValue("msoLanguageIDIcelandic")]
  Icelandic = 1039,
  /// <summary>
  /// Igbo.
  /// </summary>
  [InteropEnumValue("msoLanguageIDIgbo")]
  Igbo = 1136,
  /// <summary>
  /// Indonesian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDIndonesian")]
  Indonesian = 1057,
  /// <summary>
  /// Inuktitut.
  /// </summary>
  [InteropEnumValue("msoLanguageIDInuktitut")]
  Inuktitut = 1117,
  /// <summary>
  /// Italian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDItalian")]
  Italian = 1040,
  /// <summary>
  /// Italian as spoken in Switzerland.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSwissItalian")]
  SwissItalian = 2064,
  /// <summary>
  /// Japanese.
  /// </summary>
  [InteropEnumValue("msoLanguageIDJapanese")]
  Japanese = 1041,
  /// <summary>
  /// Kannada.
  /// </summary>
  [InteropEnumValue("msoLanguageIDKannada")]
  Kannada = 1099,
  /// <summary>
  /// Kanuri.
  /// </summary>
  [InteropEnumValue("msoLanguageIDKanuri")]
  Kanuri = 1137,
  /// <summary>
  /// Kashmiri.
  /// </summary>
  [InteropEnumValue("msoLanguageIDKashmiri")]
  Kashmiri = 1120,
  /// <summary>
  /// Kashmiri in Devanagari script.
  /// </summary>
  [InteropEnumValue("msoLanguageIDKashmiriDevanagari")]
  KashmiriDevanagari = 2144,
  /// <summary>
  /// Kazakh.
  /// </summary>
  [InteropEnumValue("msoLanguageIDKazakh")]
  Kazakh = 1087,
  /// <summary>
  /// Khmer.
  /// </summary>
  [InteropEnumValue("msoLanguageIDKhmer")]
  Khmer = 1107,
  /// <summary>
  /// Kirghiz.
  /// </summary>
  [InteropEnumValue("msoLanguageIDKirghiz")]
  Kirghiz = 1088,
  /// <summary>
  /// Konkani.
  /// </summary>
  [InteropEnumValue("msoLanguageIDKonkani")]
  Konkani = 1111,
  /// <summary>
  /// Korean.
  /// </summary>
  [InteropEnumValue("msoLanguageIDKorean")]
  Korean = 1042,
  /// <summary>
  /// Kyrgyz.
  /// </summary>
  [InteropEnumValue("msoLanguageIDKyrgyz")]
  Kyrgyz = 1088,
  /// <summary>
  /// Latin.
  /// </summary>
  [InteropEnumValue("msoLanguageIDLatin")]
  Latin = 1142,
  /// <summary>
  /// Lao.
  /// </summary>
  [InteropEnumValue("msoLanguageIDLao")]
  Lao = 1108,
  /// <summary>
  /// Latvian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDLatvian")]
  Latvian = 1062,
  /// <summary>
  /// Lithuanian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDLithuanian")]
  Lithuanian = 1063,
  /// <summary>
  /// Macedonian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDMacedonian")]
  Macedonian = 1071,
  /// <summary>
  /// Macedonian FYROM language.
  /// </summary>
  [InteropEnumValue("msoLanguageIDMacedonianFYROM")]
  MacedonianFYROM = 1071,
  /// <summary>
  /// Malaysian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDMalaysian")]
  Malaysian = 1086,
  /// <summary>
  /// Malay as spoken in Brunei Darussalam.
  /// </summary>
  [InteropEnumValue("msoLanguageIDMalayBruneiDarussalam")]
  MalayBruneiDarussalam = 2110,
  /// <summary>
  /// Malayalam.
  /// </summary>
  [InteropEnumValue("msoLanguageIDMalayalam")]
  Malayalam = 1100,
  /// <summary>
  /// Maltese.
  /// </summary>
  [InteropEnumValue("msoLanguageIDMaltese")]
  Maltese = 1082,
  /// <summary>
  /// Manipuri.
  /// </summary>
  [InteropEnumValue("msoLanguageIDManipuri")]
  Manipuri = 1112,
  /// <summary>
  /// Maori.
  /// </summary>
  [InteropEnumValue("msoLanguageIDMaori")]
  Maori = 1153,
  /// <summary>
  /// Marathi.
  /// </summary>
  [InteropEnumValue("msoLanguageIDMarathi")]
  Marathi = 1102,
  /// <summary>
  /// Mongolian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDMongolian")]
  Mongolian = 1104,
  /// <summary>
  /// Nepali.
  /// </summary>
  [InteropEnumValue("msoLanguageIDNepali")]
  Nepali = 1121,
  /// <summary>
  /// Bokmol as spoken in Norway.
  /// </summary>
  [InteropEnumValue("msoLanguageIDNorwegianBokmol")]
  NorwegianBokmol = 1044,
  /// <summary>
  /// Nynorsk as spoken in Norway.
  /// </summary>
  [InteropEnumValue("msoLanguageIDNorwegianNynorsk")]
  NorwegianNynorsk = 2068,
  /// <summary>
  /// Oriya.
  /// </summary>
  [InteropEnumValue("msoLanguageIDOriya")]
  Oriya = 1096,
  /// <summary>
  /// Oromo.
  /// </summary>
  [InteropEnumValue("msoLanguageIDOromo")]
  Oromo = 1138,
  /// <summary>
  /// Pashto.
  /// </summary>
  [InteropEnumValue("msoLanguageIDPashto")]
  Pashto = 1123,
  /// <summary>
  /// Polish.
  /// </summary>
  [InteropEnumValue("msoLanguageIDPolish")]
  Polish = 1045,
  /// <summary>
  /// Brazilian Portuguese.
  /// </summary>
  [InteropEnumValue("msoLanguageIDBrazilianPortuguese")]
  BrazilianPortuguese = 1046,
  /// <summary>
  /// Portuguese.
  /// </summary>
  [InteropEnumValue("msoLanguageIDPortuguese")]
  Portuguese = 2070,
  /// <summary>
  /// Punjabi.
  /// </summary>
  [InteropEnumValue("msoLanguageIDPunjabi")]
  Punjabi = 1094,
  /// <summary>
  /// Quechua as spoken in Bolivia.
  /// </summary>
  [InteropEnumValue("msoLanguageIDQuechuaBolivia")]
  QuechuaBolivia = 1131,
  /// <summary>
  /// Quechua as spoken in Ecuador.
  /// </summary>
  [InteropEnumValue("msoLanguageIDQuechuaEcuador")]
  QuechuaEcuador = 2155,
  /// <summary>
  /// Quechua as spoken in Peru.
  /// </summary>
  [InteropEnumValue("msoLanguageIDQuechuaPeru")]
  QuechuaPeru = 3179,
  /// <summary>
  /// Rhaeto-Romanic.
  /// </summary>
  [InteropEnumValue("msoLanguageIDRhaetoRomanic")]
  RhaetoRomanic = 1047,
  /// <summary>
  /// Romanian as spoken in Moldova.
  /// </summary>
  [InteropEnumValue("msoLanguageIDRomanianMoldova")]
  RomanianMoldova = 2072,
  /// <summary>
  /// Romanian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDRomanian")]
  Romanian = 1048,
  /// <summary>
  /// Russian as spoken in Moldova.
  /// </summary>
  [InteropEnumValue("msoLanguageIDRussianMoldova")]
  RussianMoldova = 2073,
  /// <summary>
  /// Russian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDRussian")]
  Russian = 1049,
  /// <summary>
  /// Sami/Lappish.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSamiLappish")]
  SamiLappish = 1083,
  /// <summary>
  /// Sanskrit.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSanskrit")]
  Sanskrit = 1103,
  /// <summary>
  /// Sepedi.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSepedi")]
  Sepedi = 1132,
  /// <summary>
  /// The Serbian Bosnia Herzegovina Cyrillic language.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSerbianBosniaHerzegovinaCyrillic")]
  SerbianBosniaHerzegovinaCyrillic = 7194,
  /// <summary>
  /// The Serbian Bosnia Herzegovina Latin language.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSerbianBosniaHerzegovinaLatin")]
  SerbianBosniaHerzegovinaLatin = 6170,
  /// <summary>
  /// Serbian/Cyrillic.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSerbianCyrillic")]
  SerbianCyrillic = 3098,
  /// <summary>
  /// Serbian/Latin.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSerbianLatin")]
  SerbianLatin = 2074,
  /// <summary>
  /// Sesotho.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSesotho")]
  Sesotho = 1072,
  /// <summary>
  /// Sindhi.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSindhi")]
  Sindhi = 1113,
  /// <summary>
  /// Sindhi as spoken in Pakistan.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSindhiPakistan")]
  SindhiPakistan = 2137,
  /// <summary>
  /// Sinhalese.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSinhalese")]
  Sinhalese = 1115,
  /// <summary>
  /// Slovak.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSlovak")]
  Slovak = 1051,
  /// <summary>
  /// Slovenian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSlovenian")]
  Slovenian = 1060,
  /// <summary>
  /// Somali.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSomali")]
  Somali = 1143,
  /// <summary>
  /// Sorbian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSorbian")]
  Sorbian = 1070,
  /// <summary>
  /// Spanish as spoken in Argentina.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishArgentina")]
  SpanishArgentina = 11274,
  /// <summary>
  /// Spanish as spoken in Bolivia.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishBolivia")]
  SpanishBolivia = 16394,
  /// <summary>
  /// Spanish as spoken in Chile.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishChile")]
  SpanishChile = 13322,
  /// <summary>
  /// Spanish as spoken in Colombia.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishColombia")]
  SpanishColombia = 9226,
  /// <summary>
  /// Spanish as spoken in Costa Rica.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishCostaRica")]
  SpanishCostaRica = 5130,
  /// <summary>
  /// Spanish as spoken in the Dominican Republic.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishDominicanRepublic")]
  SpanishDominicanRepublic = 7178,
  /// <summary>
  /// Spanish as spoken in Ecuador.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishEcuador")]
  SpanishEcuador = 12298,
  /// <summary>
  /// Spanish as spoken in El Salvador.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishElSalvador")]
  SpanishElSalvador = 17418,
  /// <summary>
  /// Spanish as spoken in Guatemala.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishGuatemala")]
  SpanishGuatemala = 4106,
  /// <summary>
  /// Spanish as spoken in Honduras.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishHonduras")]
  SpanishHonduras = 18442,
  /// <summary>
  /// Spanish as spoken in Mexico.
  /// </summary>
  [InteropEnumValue("msoLanguageIDMexicanSpanish")]
  MexicanSpanish = 2058,
  /// <summary>
  /// Spanish as spoken in Nicaragua.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishNicaragua")]
  SpanishNicaragua = 19466,
  /// <summary>
  /// Spanish as spoken in Panama.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishPanama")]
  SpanishPanama = 6154,
  /// <summary>
  /// Spanish as spoken in Paraguay.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishParaguay")]
  SpanishParaguay = 15370,
  /// <summary>
  /// Spanish as spoken in Peru.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishPeru")]
  SpanishPeru = 10250,
  /// <summary>
  /// Spanish as spoken in Puerto Rico.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishPuertoRico")]
  SpanishPuertoRico = 20490,
  /// <summary>
  /// Spanish (Modern Sort).
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishModernSort")]
  SpanishModernSort = 3082,
  /// <summary>
  /// Spanish.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanish")]
  Spanish = 1034,
  /// <summary>
  /// Spanish as spoken in Uruguay.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishUruguay")]
  SpanishUruguay = 14346,
  /// <summary>
  /// Spanish as spoken in Venezuela.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSpanishVenezuela")]
  SpanishVenezuela = 8202,
  /// <summary>
  /// Sutu.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSutu")]
  Sutu = 1072,
  /// <summary>
  /// Swahili.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSwahili")]
  Swahili = 1089,
  /// <summary>
  /// Swedish as spoken in Finland.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSwedishFinland")]
  SwedishFinland = 2077,
  /// <summary>
  /// Swedish.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSwedish")]
  Swedish = 1053,
  /// <summary>
  /// Syriac.
  /// </summary>
  [InteropEnumValue("msoLanguageIDSyriac")]
  Syriac = 1114,
  /// <summary>
  /// Tajik.
  /// </summary>
  [InteropEnumValue("msoLanguageIDTajik")]
  Tajik = 1064,
  /// <summary>
  /// Tamil.
  /// </summary>
  [InteropEnumValue("msoLanguageIDTamil")]
  Tamil = 1097,
  /// <summary>
  /// Tamazight.
  /// </summary>
  [InteropEnumValue("msoLanguageIDTamazight")]
  Tamazight = 1119,
  /// <summary>
  /// Tamazight (Latin).
  /// </summary>
  [InteropEnumValue("msoLanguageIDTamazightLatin")]
  TamazightLatin = 2143,
  /// <summary>
  /// Tatar.
  /// </summary>
  [InteropEnumValue("msoLanguageIDTatar")]
  Tatar = 1092,
  /// <summary>
  /// Telugu.
  /// </summary>
  [InteropEnumValue("msoLanguageIDTelugu")]
  Telugu = 1098,
  /// <summary>
  /// Thai.
  /// </summary>
  [InteropEnumValue("msoLanguageIDThai")]
  Thai = 1054,
  /// <summary>
  /// Tibetan.
  /// </summary>
  [InteropEnumValue("msoLanguageIDTibetan")]
  Tibetan = 1105,
  /// <summary>
  /// Tigrigna as spoken in Ethiopia.
  /// </summary>
  [InteropEnumValue("msoLanguageIDTigrignaEthiopic")]
  TigrignaEthiopic = 1139,
  /// <summary>
  /// Tigrigna as spoken in Eritrea.
  /// </summary>
  [InteropEnumValue("msoLanguageIDTigrignaEritrea")]
  TigrignaEritrea = 2163,
  /// <summary>
  /// Tsonga.
  /// </summary>
  [InteropEnumValue("msoLanguageIDTsonga")]
  Tsonga = 1073,
  /// <summary>
  /// Tswana.
  /// </summary>
  [InteropEnumValue("msoLanguageIDTswana")]
  Tswana = 1074,
  /// <summary>
  /// Turkish.
  /// </summary>
  [InteropEnumValue("msoLanguageIDTurkish")]
  Turkish = 1055,
  /// <summary>
  /// Turkmen.
  /// </summary>
  [InteropEnumValue("msoLanguageIDTurkmen")]
  Turkmen = 1090,
  /// <summary>
  /// Ukrainian.
  /// </summary>
  [InteropEnumValue("msoLanguageIDUkrainian")]
  Ukrainian = 1058,
  /// <summary>
  /// Urdu.
  /// </summary>
  [InteropEnumValue("msoLanguageIDUrdu")]
  Urdu = 1056,
  /// <summary>
  /// Uzbek (Cyrillic).
  /// </summary>
  [InteropEnumValue("msoLanguageIDUzbekCyrillic")]
  UzbekCyrillic = 2115,
  /// <summary>
  /// Uzbek (Latin).
  /// </summary>
  [InteropEnumValue("msoLanguageIDUzbekLatin")]
  UzbekLatin = 1091,
  /// <summary>
  /// Venda.
  /// </summary>
  [InteropEnumValue("msoLanguageIDVenda")]
  Venda = 1075,
  /// <summary>
  /// Vietnamese.
  /// </summary>
  [InteropEnumValue("msoLanguageIDVietnamese")]
  Vietnamese = 1066,
  /// <summary>
  /// Welsh.
  /// </summary>
  [InteropEnumValue("msoLanguageIDWelsh")]
  Welsh = 1106,
  /// <summary>
  /// Xhosa.
  /// </summary>
  [InteropEnumValue("msoLanguageIDXhosa")]
  Xhosa = 1076,
  /// <summary>
  /// Yi.
  /// </summary>
  [InteropEnumValue("msoLanguageIDYi")]
  Yi = 1144,
  /// <summary>
  /// Yiddish.
  /// </summary>
  [InteropEnumValue("msoLanguageIDYiddish")]
  Yiddish = 1085,
  /// <summary>
  /// Yoruba.
  /// </summary>
  [InteropEnumValue("msoLanguageIDYoruba")]
  Yoruba = 1130,
  /// <summary>
  /// Zulu.
  /// </summary>
  [InteropEnumValue("msoLanguageIDZulu")]
  Zulu = 1077
}
