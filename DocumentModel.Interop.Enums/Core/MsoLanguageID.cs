
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which language to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolanguageid?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoLanguageID")]
public enum LanguageID
{
  /// <summary>
  /// Mixed languages.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDMixed")]
  Mixed = -2,
  /// <summary>
  /// No language specified.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDNone")]
  None = 0,
  /// <summary>
  /// No proofing requested.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDNoProofing")]
  NoProofing = 1024,
  /// <summary>
  /// Afrikaans.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDAfrikaans")]
  Afrikaans = 1078,
  /// <summary>
  /// Albanian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDAlbanian")]
  Albanian = 1052,
  /// <summary>
  /// Amharic.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDAmharic")]
  Amharic = 1118,
  /// <summary>
  /// Arabic as spoken in Algeria.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabicAlgeria")]
  ArabicAlgeria = 5121,
  /// <summary>
  /// Arabic as spoken in Bahrain.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabicBahrain")]
  ArabicBahrain = 15361,
  /// <summary>
  /// Arabic as spoken in Egypt.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabicEgypt")]
  ArabicEgypt = 3073,
  /// <summary>
  /// Arabic as spoken in Iraq.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabicIraq")]
  ArabicIraq = 2049,
  /// <summary>
  /// Arabic as spoken in Jordan.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabicJordan")]
  ArabicJordan = 11265,
  /// <summary>
  /// Arabic as spoken in Kuwait.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabicKuwait")]
  ArabicKuwait = 13313,
  /// <summary>
  /// Arabic as spoken in Lebanon.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabicLebanon")]
  ArabicLebanon = 12289,
  /// <summary>
  /// Arabic as spoken in Libya.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabicLibya")]
  ArabicLibya = 4097,
  /// <summary>
  /// Arabic as spoken in Morocco.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabicMorocco")]
  ArabicMorocco = 6145,
  /// <summary>
  /// Arabic as spoken in Oman.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabicOman")]
  ArabicOman = 8193,
  /// <summary>
  /// Arabic as spoken in Qatar.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabicQatar")]
  ArabicQatar = 16385,
  /// <summary>
  /// Arabic.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabic")]
  Arabic = 1025,
  /// <summary>
  /// Arabic as spoken in Syria.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabicSyria")]
  ArabicSyria = 10241,
  /// <summary>
  /// Arabic as spoken in Tunisia.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabicTunisia")]
  ArabicTunisia = 7169,
  /// <summary>
  /// Arabic as spoken in the United Arab Emirates.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabicUAE")]
  ArabicUAE = 14337,
  /// <summary>
  /// Arabic as spoken in Yemen.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArabicYemen")]
  ArabicYemen = 9217,
  /// <summary>
  /// Armenian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDArmenian")]
  Armenian = 1067,
  /// <summary>
  /// Assamese.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDAssamese")]
  Assamese = 1101,
  /// <summary>
  /// Azeri-Cyrillic.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDAzeriCyrillic")]
  AzeriCyrillic = 2092,
  /// <summary>
  /// Azeri-Latin.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDAzeriLatin")]
  AzeriLatin = 1068,
  /// <summary>
  /// Basque.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDBasque")]
  Basque = 1069,
  /// <summary>
  /// Belarusian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDByelorussian")]
  Byelorussian = 1059,
  /// <summary>
  /// Bengali.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDBengali")]
  Bengali = 1093,
  /// <summary>
  /// Bosnian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDBosnian")]
  Bosnian = 4122,
  /// <summary>
  /// The Bosnian Bosnia Herzegovina Cyrillic language.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDBosnianBosniaHerzegovinaCyrillic")]
  BosnianBosniaHerzegovinaCyrillic = 8218,
  /// <summary>
  /// The Bosnian Bosnia Herzegovina Latin language.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDBosnianBosniaHerzegovinaLatin")]
  BosnianBosniaHerzegovinaLatin = 5146,
  /// <summary>
  /// Bulgarian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDBulgarian")]
  Bulgarian = 1026,
  /// <summary>
  /// Burmese.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDBurmese")]
  Burmese = 1109,
  /// <summary>
  /// Catalan.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDCatalan")]
  Catalan = 1027,
  /// <summary>
  /// Chinese as spoken in Hong Kong SAR.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDChineseHongKongSAR")]
  ChineseHongKongSAR = 3076,
  /// <summary>
  /// Chinese as spoken in Macao SAR.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDChineseMacaoSAR")]
  ChineseMacaoSAR = 5124,
  /// <summary>
  /// Simplified Chinese.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSimplifiedChinese")]
  SimplifiedChinese = 2052,
  /// <summary>
  /// Chinese as spoken in Singapore.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDChineseSingapore")]
  ChineseSingapore = 4100,
  /// <summary>
  /// Traditional Chinese.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDTraditionalChinese")]
  TraditionalChinese = 1028,
  /// <summary>
  /// Cherokee.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDCherokee")]
  Cherokee = 1116,
  /// <summary>
  /// Croatian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDCroatian")]
  Croatian = 1050,
  /// <summary>
  /// Czech.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDCzech")]
  Czech = 1029,
  /// <summary>
  /// Danish.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDDanish")]
  Danish = 1030,
  /// <summary>
  /// Divehi.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDDivehi")]
  Divehi = 1125,
  /// <summary>
  /// Belgian Dutch.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDBelgianDutch")]
  BelgianDutch = 2067,
  /// <summary>
  /// Dutch.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDDutch")]
  Dutch = 1043,
  /// <summary>
  /// Dzongkha as spoken in Bhutan.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDDzongkhaBhutan")]
  DzongkhaBhutan = 2129,
  /// <summary>
  /// Edo.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEdo")]
  Edo = 1126,
  /// <summary>
  /// English as spoken in Australia.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEnglishAUS")]
  EnglishAUS = 3081,
  /// <summary>
  /// English as spoken in Belize.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEnglishBelize")]
  EnglishBelize = 10249,
  /// <summary>
  /// English as spoken in Canada.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEnglishCanadian")]
  EnglishCanadian = 4105,
  /// <summary>
  /// English as spoken in the Caribbean.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEnglishCaribbean")]
  EnglishCaribbean = 9225,
  /// <summary>
  /// English as spoken in Indonesia.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEnglishIndonesia")]
  EnglishIndonesia = 14345,
  /// <summary>
  /// English as spoken in Ireland.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEnglishIreland")]
  EnglishIreland = 6153,
  /// <summary>
  /// English as spoken in Jamaica.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEnglishJamaica")]
  EnglishJamaica = 8201,
  /// <summary>
  /// English as spoken in New Zealand.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEnglishNewZealand")]
  EnglishNewZealand = 5129,
  /// <summary>
  /// English as spoken in the Philippines.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEnglishPhilippines")]
  EnglishPhilippines = 13321,
  /// <summary>
  /// English as spoken in South Africa.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEnglishSouthAfrica")]
  EnglishSouthAfrica = 7177,
  /// <summary>
  /// English as spoken in Trinidad and Tobago.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEnglishTrinidadTobago")]
  EnglishTrinidadTobago = 11273,
  /// <summary>
  /// English as spoken in the United Kingdom.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEnglishUK")]
  EnglishUK = 2057,
  /// <summary>
  /// English as spoken in the United States.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEnglishUS")]
  EnglishUS = 1033,
  /// <summary>
  /// English as spoken in Zimbabwe.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEnglishZimbabwe")]
  EnglishZimbabwe = 12297,
  /// <summary>
  /// Estonian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDEstonian")]
  Estonian = 1061,
  /// <summary>
  /// Faeroese.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFaeroese")]
  Faeroese = 1080,
  /// <summary>
  /// Farsi.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFarsi")]
  Farsi = 1065,
  /// <summary>
  /// Filipina.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFilipino")]
  Filipino = 1124,
  /// <summary>
  /// Finnish.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFinnish")]
  Finnish = 1035,
  /// <summary>
  /// Belgian French.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDBelgianFrench")]
  BelgianFrench = 2060,
  /// <summary>
  /// French as spoken in Cameroon.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFrenchCameroon")]
  FrenchCameroon = 11276,
  /// <summary>
  /// French as spoken in Canada.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFrenchCanadian")]
  FrenchCanadian = 3084,
  /// <summary>
  /// French as spoken in Cote d'Ivoire.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFrenchCotedIvoire")]
  FrenchCotedIvoire = 12300,
  /// <summary>
  /// French.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFrench")]
  French = 1036,
  /// <summary>
  /// French as spoken in Haiti.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFrenchHaiti")]
  FrenchHaiti = 15372,
  /// <summary>
  /// French as spoken in Luxembourg.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFrenchLuxembourg")]
  FrenchLuxembourg = 5132,
  /// <summary>
  /// French as spoken in Mali.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFrenchMali")]
  FrenchMali = 13324,
  /// <summary>
  /// French as spoken in Monaco.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFrenchMonaco")]
  FrenchMonaco = 6156,
  /// <summary>
  /// French as spoken in Morocco.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFrenchMorocco")]
  FrenchMorocco = 14348,
  /// <summary>
  /// French as spoken in French Reunion Island.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFrenchReunion")]
  FrenchReunion = 8204,
  /// <summary>
  /// French as spoken in Senegal.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFrenchSenegal")]
  FrenchSenegal = 10252,
  /// <summary>
  /// French as spoken in Switzerland.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSwissFrench")]
  SwissFrench = 4108,
  /// <summary>
  /// French as spoken in the West Indies.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFrenchWestIndies")]
  FrenchWestIndies = 7180,
  /// <summary>
  /// French as spoken in Zaire.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFrenchZaire")]
  FrenchZaire = 9228,
  /// <summary>
  /// The French Congo DRC language.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFrenchCongoDRC")]
  FrenchCongoDRC = 9228,
  /// <summary>
  /// Frisian as spoken in the Netherlands.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFrisianNetherlands")]
  FrisianNetherlands = 1122,
  /// <summary>
  /// Fulfulde.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDFulfulde")]
  Fulfulde = 1127,
  /// <summary>
  /// Gaelic as spoken in Ireland.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDGaelicIreland")]
  GaelicIreland = 2108,
  /// <summary>
  /// Gaelic as spoken in Scotland.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDGaelicScotland")]
  GaelicScotland = 1084,
  /// <summary>
  /// Galician.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDGalician")]
  Galician = 1110,
  /// <summary>
  /// Georgian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDGeorgian")]
  Georgian = 1079,
  /// <summary>
  /// German as spoken in Austria.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDGermanAustria")]
  GermanAustria = 3079,
  /// <summary>
  /// German.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDGerman")]
  German = 1031,
  /// <summary>
  /// German as spoken in Liechtenstein.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDGermanLiechtenstein")]
  GermanLiechtenstein = 5127,
  /// <summary>
  /// German as spoken in Luxembourg.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDGermanLuxembourg")]
  GermanLuxembourg = 4103,
  /// <summary>
  /// German as spoken in Switzerland.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSwissGerman")]
  SwissGerman = 2055,
  /// <summary>
  /// Greek.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDGreek")]
  Greek = 1032,
  /// <summary>
  /// Guarani.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDGuarani")]
  Guarani = 1140,
  /// <summary>
  /// Gujarati.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDGujarati")]
  Gujarati = 1095,
  /// <summary>
  /// Hausa.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDHausa")]
  Hausa = 1128,
  /// <summary>
  /// Hawaiian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDHawaiian")]
  Hawaiian = 1141,
  /// <summary>
  /// Hebrew.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDHebrew")]
  Hebrew = 1037,
  /// <summary>
  /// Hindi.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDHindi")]
  Hindi = 1081,
  /// <summary>
  /// Hungarian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDHungarian")]
  Hungarian = 1038,
  /// <summary>
  /// Ibibio.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDIbibio")]
  Ibibio = 1129,
  /// <summary>
  /// Icelandic.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDIcelandic")]
  Icelandic = 1039,
  /// <summary>
  /// Igbo.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDIgbo")]
  Igbo = 1136,
  /// <summary>
  /// Indonesian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDIndonesian")]
  Indonesian = 1057,
  /// <summary>
  /// Inuktitut.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDInuktitut")]
  Inuktitut = 1117,
  /// <summary>
  /// Italian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDItalian")]
  Italian = 1040,
  /// <summary>
  /// Italian as spoken in Switzerland.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSwissItalian")]
  SwissItalian = 2064,
  /// <summary>
  /// Japanese.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDJapanese")]
  Japanese = 1041,
  /// <summary>
  /// Kannada.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDKannada")]
  Kannada = 1099,
  /// <summary>
  /// Kanuri.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDKanuri")]
  Kanuri = 1137,
  /// <summary>
  /// Kashmiri.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDKashmiri")]
  Kashmiri = 1120,
  /// <summary>
  /// Kashmiri in Devanagari script.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDKashmiriDevanagari")]
  KashmiriDevanagari = 2144,
  /// <summary>
  /// Kazakh.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDKazakh")]
  Kazakh = 1087,
  /// <summary>
  /// Khmer.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDKhmer")]
  Khmer = 1107,
  /// <summary>
  /// Kirghiz.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDKirghiz")]
  Kirghiz = 1088,
  /// <summary>
  /// Konkani.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDKonkani")]
  Konkani = 1111,
  /// <summary>
  /// Korean.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDKorean")]
  Korean = 1042,
  /// <summary>
  /// Kyrgyz.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDKyrgyz")]
  Kyrgyz = 1088,
  /// <summary>
  /// Latin.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDLatin")]
  Latin = 1142,
  /// <summary>
  /// Lao.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDLao")]
  Lao = 1108,
  /// <summary>
  /// Latvian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDLatvian")]
  Latvian = 1062,
  /// <summary>
  /// Lithuanian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDLithuanian")]
  Lithuanian = 1063,
  /// <summary>
  /// Macedonian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDMacedonian")]
  Macedonian = 1071,
  /// <summary>
  /// Macedonian FYROM language.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDMacedonianFYROM")]
  MacedonianFYROM = 1071,
  /// <summary>
  /// Malaysian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDMalaysian")]
  Malaysian = 1086,
  /// <summary>
  /// Malay as spoken in Brunei Darussalam.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDMalayBruneiDarussalam")]
  MalayBruneiDarussalam = 2110,
  /// <summary>
  /// Malayalam.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDMalayalam")]
  Malayalam = 1100,
  /// <summary>
  /// Maltese.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDMaltese")]
  Maltese = 1082,
  /// <summary>
  /// Manipuri.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDManipuri")]
  Manipuri = 1112,
  /// <summary>
  /// Maori.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDMaori")]
  Maori = 1153,
  /// <summary>
  /// Marathi.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDMarathi")]
  Marathi = 1102,
  /// <summary>
  /// Mongolian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDMongolian")]
  Mongolian = 1104,
  /// <summary>
  /// Nepali.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDNepali")]
  Nepali = 1121,
  /// <summary>
  /// Bokmol as spoken in Norway.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDNorwegianBokmol")]
  NorwegianBokmol = 1044,
  /// <summary>
  /// Nynorsk as spoken in Norway.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDNorwegianNynorsk")]
  NorwegianNynorsk = 2068,
  /// <summary>
  /// Oriya.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDOriya")]
  Oriya = 1096,
  /// <summary>
  /// Oromo.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDOromo")]
  Oromo = 1138,
  /// <summary>
  /// Pashto.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDPashto")]
  Pashto = 1123,
  /// <summary>
  /// Polish.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDPolish")]
  Polish = 1045,
  /// <summary>
  /// Brazilian Portuguese.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDBrazilianPortuguese")]
  BrazilianPortuguese = 1046,
  /// <summary>
  /// Portuguese.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDPortuguese")]
  Portuguese = 2070,
  /// <summary>
  /// Punjabi.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDPunjabi")]
  Punjabi = 1094,
  /// <summary>
  /// Quechua as spoken in Bolivia.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDQuechuaBolivia")]
  QuechuaBolivia = 1131,
  /// <summary>
  /// Quechua as spoken in Ecuador.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDQuechuaEcuador")]
  QuechuaEcuador = 2155,
  /// <summary>
  /// Quechua as spoken in Peru.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDQuechuaPeru")]
  QuechuaPeru = 3179,
  /// <summary>
  /// Rhaeto-Romanic.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDRhaetoRomanic")]
  RhaetoRomanic = 1047,
  /// <summary>
  /// Romanian as spoken in Moldova.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDRomanianMoldova")]
  RomanianMoldova = 2072,
  /// <summary>
  /// Romanian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDRomanian")]
  Romanian = 1048,
  /// <summary>
  /// Russian as spoken in Moldova.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDRussianMoldova")]
  RussianMoldova = 2073,
  /// <summary>
  /// Russian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDRussian")]
  Russian = 1049,
  /// <summary>
  /// Sami/Lappish.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSamiLappish")]
  SamiLappish = 1083,
  /// <summary>
  /// Sanskrit.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSanskrit")]
  Sanskrit = 1103,
  /// <summary>
  /// Sepedi.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSepedi")]
  Sepedi = 1132,
  /// <summary>
  /// The Serbian Bosnia Herzegovina Cyrillic language.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSerbianBosniaHerzegovinaCyrillic")]
  SerbianBosniaHerzegovinaCyrillic = 7194,
  /// <summary>
  /// The Serbian Bosnia Herzegovina Latin language.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSerbianBosniaHerzegovinaLatin")]
  SerbianBosniaHerzegovinaLatin = 6170,
  /// <summary>
  /// Serbian/Cyrillic.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSerbianCyrillic")]
  SerbianCyrillic = 3098,
  /// <summary>
  /// Serbian/Latin.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSerbianLatin")]
  SerbianLatin = 2074,
  /// <summary>
  /// Sesotho.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSesotho")]
  Sesotho = 1072,
  /// <summary>
  /// Sindhi.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSindhi")]
  Sindhi = 1113,
  /// <summary>
  /// Sindhi as spoken in Pakistan.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSindhiPakistan")]
  SindhiPakistan = 2137,
  /// <summary>
  /// Sinhalese.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSinhalese")]
  Sinhalese = 1115,
  /// <summary>
  /// Slovak.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSlovak")]
  Slovak = 1051,
  /// <summary>
  /// Slovenian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSlovenian")]
  Slovenian = 1060,
  /// <summary>
  /// Somali.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSomali")]
  Somali = 1143,
  /// <summary>
  /// Sorbian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSorbian")]
  Sorbian = 1070,
  /// <summary>
  /// Spanish as spoken in Argentina.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishArgentina")]
  SpanishArgentina = 11274,
  /// <summary>
  /// Spanish as spoken in Bolivia.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishBolivia")]
  SpanishBolivia = 16394,
  /// <summary>
  /// Spanish as spoken in Chile.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishChile")]
  SpanishChile = 13322,
  /// <summary>
  /// Spanish as spoken in Colombia.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishColombia")]
  SpanishColombia = 9226,
  /// <summary>
  /// Spanish as spoken in Costa Rica.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishCostaRica")]
  SpanishCostaRica = 5130,
  /// <summary>
  /// Spanish as spoken in the Dominican Republic.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishDominicanRepublic")]
  SpanishDominicanRepublic = 7178,
  /// <summary>
  /// Spanish as spoken in Ecuador.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishEcuador")]
  SpanishEcuador = 12298,
  /// <summary>
  /// Spanish as spoken in El Salvador.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishElSalvador")]
  SpanishElSalvador = 17418,
  /// <summary>
  /// Spanish as spoken in Guatemala.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishGuatemala")]
  SpanishGuatemala = 4106,
  /// <summary>
  /// Spanish as spoken in Honduras.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishHonduras")]
  SpanishHonduras = 18442,
  /// <summary>
  /// Spanish as spoken in Mexico.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDMexicanSpanish")]
  MexicanSpanish = 2058,
  /// <summary>
  /// Spanish as spoken in Nicaragua.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishNicaragua")]
  SpanishNicaragua = 19466,
  /// <summary>
  /// Spanish as spoken in Panama.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishPanama")]
  SpanishPanama = 6154,
  /// <summary>
  /// Spanish as spoken in Paraguay.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishParaguay")]
  SpanishParaguay = 15370,
  /// <summary>
  /// Spanish as spoken in Peru.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishPeru")]
  SpanishPeru = 10250,
  /// <summary>
  /// Spanish as spoken in Puerto Rico.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishPuertoRico")]
  SpanishPuertoRico = 20490,
  /// <summary>
  /// Spanish (Modern Sort).
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishModernSort")]
  SpanishModernSort = 3082,
  /// <summary>
  /// Spanish.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanish")]
  Spanish = 1034,
  /// <summary>
  /// Spanish as spoken in Uruguay.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishUruguay")]
  SpanishUruguay = 14346,
  /// <summary>
  /// Spanish as spoken in Venezuela.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSpanishVenezuela")]
  SpanishVenezuela = 8202,
  /// <summary>
  /// Sutu.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSutu")]
  Sutu = 1072,
  /// <summary>
  /// Swahili.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSwahili")]
  Swahili = 1089,
  /// <summary>
  /// Swedish as spoken in Finland.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSwedishFinland")]
  SwedishFinland = 2077,
  /// <summary>
  /// Swedish.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSwedish")]
  Swedish = 1053,
  /// <summary>
  /// Syriac.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDSyriac")]
  Syriac = 1114,
  /// <summary>
  /// Tajik.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDTajik")]
  Tajik = 1064,
  /// <summary>
  /// Tamil.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDTamil")]
  Tamil = 1097,
  /// <summary>
  /// Tamazight.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDTamazight")]
  Tamazight = 1119,
  /// <summary>
  /// Tamazight (Latin).
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDTamazightLatin")]
  TamazightLatin = 2143,
  /// <summary>
  /// Tatar.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDTatar")]
  Tatar = 1092,
  /// <summary>
  /// Telugu.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDTelugu")]
  Telugu = 1098,
  /// <summary>
  /// Thai.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDThai")]
  Thai = 1054,
  /// <summary>
  /// Tibetan.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDTibetan")]
  Tibetan = 1105,
  /// <summary>
  /// Tigrigna as spoken in Ethiopia.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDTigrignaEthiopic")]
  TigrignaEthiopic = 1139,
  /// <summary>
  /// Tigrigna as spoken in Eritrea.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDTigrignaEritrea")]
  TigrignaEritrea = 2163,
  /// <summary>
  /// Tsonga.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDTsonga")]
  Tsonga = 1073,
  /// <summary>
  /// Tswana.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDTswana")]
  Tswana = 1074,
  /// <summary>
  /// Turkish.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDTurkish")]
  Turkish = 1055,
  /// <summary>
  /// Turkmen.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDTurkmen")]
  Turkmen = 1090,
  /// <summary>
  /// Ukrainian.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDUkrainian")]
  Ukrainian = 1058,
  /// <summary>
  /// Urdu.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDUrdu")]
  Urdu = 1056,
  /// <summary>
  /// Uzbek (Cyrillic).
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDUzbekCyrillic")]
  UzbekCyrillic = 2115,
  /// <summary>
  /// Uzbek (Latin).
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDUzbekLatin")]
  UzbekLatin = 1091,
  /// <summary>
  /// Venda.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDVenda")]
  Venda = 1075,
  /// <summary>
  /// Vietnamese.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDVietnamese")]
  Vietnamese = 1066,
  /// <summary>
  /// Welsh.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDWelsh")]
  Welsh = 1106,
  /// <summary>
  /// Xhosa.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDXhosa")]
  Xhosa = 1076,
  /// <summary>
  /// Yi.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDYi")]
  Yi = 1144,
  /// <summary>
  /// Yiddish.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDYiddish")]
  Yiddish = 1085,
  /// <summary>
  /// Yoruba.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDYoruba")]
  Yoruba = 1130,
  /// <summary>
  /// Zulu.
  /// </summary>
  [OfficeInteropEnumValue("msoLanguageIDZulu")]
  Zulu = 1077
}
