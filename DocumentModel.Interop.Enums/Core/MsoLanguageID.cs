
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies which language to use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolanguageid?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoLanguageID))]
public enum LanguageID
{
  /// <summary>
  /// Mixed languages.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDMixed))]
  Mixed = -2,
  /// <summary>
  /// No language specified.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDNone))]
  None = 0,
  /// <summary>
  /// No proofing requested.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDNoProofing))]
  NoProofing = 1024,
  /// <summary>
  /// Afrikaans.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDAfrikaans))]
  Afrikaans = 1078,
  /// <summary>
  /// Albanian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDAlbanian))]
  Albanian = 1052,
  /// <summary>
  /// Amharic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDAmharic))]
  Amharic = 1118,
  /// <summary>
  /// Arabic as spoken in Algeria.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabicAlgeria))]
  ArabicAlgeria = 5121,
  /// <summary>
  /// Arabic as spoken in Bahrain.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabicBahrain))]
  ArabicBahrain = 15361,
  /// <summary>
  /// Arabic as spoken in Egypt.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabicEgypt))]
  ArabicEgypt = 3073,
  /// <summary>
  /// Arabic as spoken in Iraq.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabicIraq))]
  ArabicIraq = 2049,
  /// <summary>
  /// Arabic as spoken in Jordan.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabicJordan))]
  ArabicJordan = 11265,
  /// <summary>
  /// Arabic as spoken in Kuwait.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabicKuwait))]
  ArabicKuwait = 13313,
  /// <summary>
  /// Arabic as spoken in Lebanon.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabicLebanon))]
  ArabicLebanon = 12289,
  /// <summary>
  /// Arabic as spoken in Libya.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabicLibya))]
  ArabicLibya = 4097,
  /// <summary>
  /// Arabic as spoken in Morocco.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabicMorocco))]
  ArabicMorocco = 6145,
  /// <summary>
  /// Arabic as spoken in Oman.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabicOman))]
  ArabicOman = 8193,
  /// <summary>
  /// Arabic as spoken in Qatar.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabicQatar))]
  ArabicQatar = 16385,
  /// <summary>
  /// Arabic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabic))]
  Arabic = 1025,
  /// <summary>
  /// Arabic as spoken in Syria.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabicSyria))]
  ArabicSyria = 10241,
  /// <summary>
  /// Arabic as spoken in Tunisia.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabicTunisia))]
  ArabicTunisia = 7169,
  /// <summary>
  /// Arabic as spoken in the United Arab Emirates.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabicUAE))]
  ArabicUAE = 14337,
  /// <summary>
  /// Arabic as spoken in Yemen.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArabicYemen))]
  ArabicYemen = 9217,
  /// <summary>
  /// Armenian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDArmenian))]
  Armenian = 1067,
  /// <summary>
  /// Assamese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDAssamese))]
  Assamese = 1101,
  /// <summary>
  /// Azeri-Cyrillic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDAzeriCyrillic))]
  AzeriCyrillic = 2092,
  /// <summary>
  /// Azeri-Latin.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDAzeriLatin))]
  AzeriLatin = 1068,
  /// <summary>
  /// Basque.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDBasque))]
  Basque = 1069,
  /// <summary>
  /// Belarusian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDByelorussian))]
  Byelorussian = 1059,
  /// <summary>
  /// Bengali.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDBengali))]
  Bengali = 1093,
  /// <summary>
  /// Bosnian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDBosnian))]
  Bosnian = 4122,
  /// <summary>
  /// The Bosnian Bosnia Herzegovina Cyrillic language.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDBosnianBosniaHerzegovinaCyrillic))]
  BosnianBosniaHerzegovinaCyrillic = 8218,
  /// <summary>
  /// The Bosnian Bosnia Herzegovina Latin language.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDBosnianBosniaHerzegovinaLatin))]
  BosnianBosniaHerzegovinaLatin = 5146,
  /// <summary>
  /// Bulgarian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDBulgarian))]
  Bulgarian = 1026,
  /// <summary>
  /// Burmese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDBurmese))]
  Burmese = 1109,
  /// <summary>
  /// Catalan.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDCatalan))]
  Catalan = 1027,
  /// <summary>
  /// Chinese as spoken in Hong Kong SAR.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDChineseHongKongSAR))]
  ChineseHongKongSAR = 3076,
  /// <summary>
  /// Chinese as spoken in Macao SAR.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDChineseMacaoSAR))]
  ChineseMacaoSAR = 5124,
  /// <summary>
  /// Simplified Chinese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSimplifiedChinese))]
  SimplifiedChinese = 2052,
  /// <summary>
  /// Chinese as spoken in Singapore.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDChineseSingapore))]
  ChineseSingapore = 4100,
  /// <summary>
  /// Traditional Chinese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDTraditionalChinese))]
  TraditionalChinese = 1028,
  /// <summary>
  /// Cherokee.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDCherokee))]
  Cherokee = 1116,
  /// <summary>
  /// Croatian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDCroatian))]
  Croatian = 1050,
  /// <summary>
  /// Czech.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDCzech))]
  Czech = 1029,
  /// <summary>
  /// Danish.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDDanish))]
  Danish = 1030,
  /// <summary>
  /// Divehi.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDDivehi))]
  Divehi = 1125,
  /// <summary>
  /// Belgian Dutch.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDBelgianDutch))]
  BelgianDutch = 2067,
  /// <summary>
  /// Dutch.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDDutch))]
  Dutch = 1043,
  /// <summary>
  /// Dzongkha as spoken in Bhutan.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDDzongkhaBhutan))]
  DzongkhaBhutan = 2129,
  /// <summary>
  /// Edo.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEdo))]
  Edo = 1126,
  /// <summary>
  /// English as spoken in Australia.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEnglishAUS))]
  EnglishAUS = 3081,
  /// <summary>
  /// English as spoken in Belize.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEnglishBelize))]
  EnglishBelize = 10249,
  /// <summary>
  /// English as spoken in Canada.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEnglishCanadian))]
  EnglishCanadian = 4105,
  /// <summary>
  /// English as spoken in the Caribbean.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEnglishCaribbean))]
  EnglishCaribbean = 9225,
  /// <summary>
  /// English as spoken in Indonesia.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEnglishIndonesia))]
  EnglishIndonesia = 14345,
  /// <summary>
  /// English as spoken in Ireland.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEnglishIreland))]
  EnglishIreland = 6153,
  /// <summary>
  /// English as spoken in Jamaica.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEnglishJamaica))]
  EnglishJamaica = 8201,
  /// <summary>
  /// English as spoken in New Zealand.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEnglishNewZealand))]
  EnglishNewZealand = 5129,
  /// <summary>
  /// English as spoken in the Philippines.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEnglishPhilippines))]
  EnglishPhilippines = 13321,
  /// <summary>
  /// English as spoken in South Africa.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEnglishSouthAfrica))]
  EnglishSouthAfrica = 7177,
  /// <summary>
  /// English as spoken in Trinidad and Tobago.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEnglishTrinidadTobago))]
  EnglishTrinidadTobago = 11273,
  /// <summary>
  /// English as spoken in the United Kingdom.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEnglishUK))]
  EnglishUK = 2057,
  /// <summary>
  /// English as spoken in the United States.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEnglishUS))]
  EnglishUS = 1033,
  /// <summary>
  /// English as spoken in Zimbabwe.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEnglishZimbabwe))]
  EnglishZimbabwe = 12297,
  /// <summary>
  /// Estonian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDEstonian))]
  Estonian = 1061,
  /// <summary>
  /// Faeroese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFaeroese))]
  Faeroese = 1080,
  /// <summary>
  /// Farsi.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFarsi))]
  Farsi = 1065,
  /// <summary>
  /// Filipina.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFilipino))]
  Filipino = 1124,
  /// <summary>
  /// Finnish.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFinnish))]
  Finnish = 1035,
  /// <summary>
  /// Belgian French.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDBelgianFrench))]
  BelgianFrench = 2060,
  /// <summary>
  /// French as spoken in Cameroon.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFrenchCameroon))]
  FrenchCameroon = 11276,
  /// <summary>
  /// French as spoken in Canada.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFrenchCanadian))]
  FrenchCanadian = 3084,
  /// <summary>
  /// French as spoken in Cote d'Ivoire.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFrenchCotedIvoire))]
  FrenchCotedIvoire = 12300,
  /// <summary>
  /// French.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFrench))]
  French = 1036,
  /// <summary>
  /// French as spoken in Haiti.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFrenchHaiti))]
  FrenchHaiti = 15372,
  /// <summary>
  /// French as spoken in Luxembourg.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFrenchLuxembourg))]
  FrenchLuxembourg = 5132,
  /// <summary>
  /// French as spoken in Mali.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFrenchMali))]
  FrenchMali = 13324,
  /// <summary>
  /// French as spoken in Monaco.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFrenchMonaco))]
  FrenchMonaco = 6156,
  /// <summary>
  /// French as spoken in Morocco.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFrenchMorocco))]
  FrenchMorocco = 14348,
  /// <summary>
  /// French as spoken in French Reunion Island.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFrenchReunion))]
  FrenchReunion = 8204,
  /// <summary>
  /// French as spoken in Senegal.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFrenchSenegal))]
  FrenchSenegal = 10252,
  /// <summary>
  /// French as spoken in Switzerland.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSwissFrench))]
  SwissFrench = 4108,
  /// <summary>
  /// French as spoken in the West Indies.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFrenchWestIndies))]
  FrenchWestIndies = 7180,
  /// <summary>
  /// French as spoken in Zaire.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFrenchZaire))]
  FrenchZaire = 9228,
  /// <summary>
  /// The French Congo DRC language.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFrenchCongoDRC))]
  FrenchCongoDRC = 9228,
  /// <summary>
  /// Frisian as spoken in the Netherlands.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFrisianNetherlands))]
  FrisianNetherlands = 1122,
  /// <summary>
  /// Fulfulde.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDFulfulde))]
  Fulfulde = 1127,
  /// <summary>
  /// Gaelic as spoken in Ireland.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDGaelicIreland))]
  GaelicIreland = 2108,
  /// <summary>
  /// Gaelic as spoken in Scotland.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDGaelicScotland))]
  GaelicScotland = 1084,
  /// <summary>
  /// Galician.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDGalician))]
  Galician = 1110,
  /// <summary>
  /// Georgian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDGeorgian))]
  Georgian = 1079,
  /// <summary>
  /// German as spoken in Austria.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDGermanAustria))]
  GermanAustria = 3079,
  /// <summary>
  /// German.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDGerman))]
  German = 1031,
  /// <summary>
  /// German as spoken in Liechtenstein.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDGermanLiechtenstein))]
  GermanLiechtenstein = 5127,
  /// <summary>
  /// German as spoken in Luxembourg.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDGermanLuxembourg))]
  GermanLuxembourg = 4103,
  /// <summary>
  /// German as spoken in Switzerland.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSwissGerman))]
  SwissGerman = 2055,
  /// <summary>
  /// Greek.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDGreek))]
  Greek = 1032,
  /// <summary>
  /// Guarani.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDGuarani))]
  Guarani = 1140,
  /// <summary>
  /// Gujarati.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDGujarati))]
  Gujarati = 1095,
  /// <summary>
  /// Hausa.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDHausa))]
  Hausa = 1128,
  /// <summary>
  /// Hawaiian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDHawaiian))]
  Hawaiian = 1141,
  /// <summary>
  /// Hebrew.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDHebrew))]
  Hebrew = 1037,
  /// <summary>
  /// Hindi.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDHindi))]
  Hindi = 1081,
  /// <summary>
  /// Hungarian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDHungarian))]
  Hungarian = 1038,
  /// <summary>
  /// Ibibio.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDIbibio))]
  Ibibio = 1129,
  /// <summary>
  /// Icelandic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDIcelandic))]
  Icelandic = 1039,
  /// <summary>
  /// Igbo.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDIgbo))]
  Igbo = 1136,
  /// <summary>
  /// Indonesian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDIndonesian))]
  Indonesian = 1057,
  /// <summary>
  /// Inuktitut.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDInuktitut))]
  Inuktitut = 1117,
  /// <summary>
  /// Italian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDItalian))]
  Italian = 1040,
  /// <summary>
  /// Italian as spoken in Switzerland.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSwissItalian))]
  SwissItalian = 2064,
  /// <summary>
  /// Japanese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDJapanese))]
  Japanese = 1041,
  /// <summary>
  /// Kannada.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDKannada))]
  Kannada = 1099,
  /// <summary>
  /// Kanuri.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDKanuri))]
  Kanuri = 1137,
  /// <summary>
  /// Kashmiri.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDKashmiri))]
  Kashmiri = 1120,
  /// <summary>
  /// Kashmiri in Devanagari script.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDKashmiriDevanagari))]
  KashmiriDevanagari = 2144,
  /// <summary>
  /// Kazakh.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDKazakh))]
  Kazakh = 1087,
  /// <summary>
  /// Khmer.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDKhmer))]
  Khmer = 1107,
  /// <summary>
  /// Kirghiz.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDKirghiz))]
  Kirghiz = 1088,
  /// <summary>
  /// Konkani.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDKonkani))]
  Konkani = 1111,
  /// <summary>
  /// Korean.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDKorean))]
  Korean = 1042,
  /// <summary>
  /// Kyrgyz.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDKyrgyz))]
  Kyrgyz = 1088,
  /// <summary>
  /// Latin.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDLatin))]
  Latin = 1142,
  /// <summary>
  /// Lao.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDLao))]
  Lao = 1108,
  /// <summary>
  /// Latvian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDLatvian))]
  Latvian = 1062,
  /// <summary>
  /// Lithuanian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDLithuanian))]
  Lithuanian = 1063,
  /// <summary>
  /// Macedonian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDMacedonian))]
  Macedonian = 1071,
  /// <summary>
  /// Macedonian FYROM language.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDMacedonianFYROM))]
  MacedonianFYROM = 1071,
  /// <summary>
  /// Malaysian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDMalaysian))]
  Malaysian = 1086,
  /// <summary>
  /// Malay as spoken in Brunei Darussalam.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDMalayBruneiDarussalam))]
  MalayBruneiDarussalam = 2110,
  /// <summary>
  /// Malayalam.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDMalayalam))]
  Malayalam = 1100,
  /// <summary>
  /// Maltese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDMaltese))]
  Maltese = 1082,
  /// <summary>
  /// Manipuri.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDManipuri))]
  Manipuri = 1112,
  /// <summary>
  /// Maori.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDMaori))]
  Maori = 1153,
  /// <summary>
  /// Marathi.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDMarathi))]
  Marathi = 1102,
  /// <summary>
  /// Mongolian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDMongolian))]
  Mongolian = 1104,
  /// <summary>
  /// Nepali.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDNepali))]
  Nepali = 1121,
  /// <summary>
  /// Bokmol as spoken in Norway.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDNorwegianBokmol))]
  NorwegianBokmol = 1044,
  /// <summary>
  /// Nynorsk as spoken in Norway.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDNorwegianNynorsk))]
  NorwegianNynorsk = 2068,
  /// <summary>
  /// Oriya.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDOriya))]
  Oriya = 1096,
  /// <summary>
  /// Oromo.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDOromo))]
  Oromo = 1138,
  /// <summary>
  /// Pashto.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDPashto))]
  Pashto = 1123,
  /// <summary>
  /// Polish.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDPolish))]
  Polish = 1045,
  /// <summary>
  /// Brazilian Portuguese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDBrazilianPortuguese))]
  BrazilianPortuguese = 1046,
  /// <summary>
  /// Portuguese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDPortuguese))]
  Portuguese = 2070,
  /// <summary>
  /// Punjabi.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDPunjabi))]
  Punjabi = 1094,
  /// <summary>
  /// Quechua as spoken in Bolivia.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDQuechuaBolivia))]
  QuechuaBolivia = 1131,
  /// <summary>
  /// Quechua as spoken in Ecuador.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDQuechuaEcuador))]
  QuechuaEcuador = 2155,
  /// <summary>
  /// Quechua as spoken in Peru.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDQuechuaPeru))]
  QuechuaPeru = 3179,
  /// <summary>
  /// Rhaeto-Romanic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDRhaetoRomanic))]
  RhaetoRomanic = 1047,
  /// <summary>
  /// Romanian as spoken in Moldova.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDRomanianMoldova))]
  RomanianMoldova = 2072,
  /// <summary>
  /// Romanian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDRomanian))]
  Romanian = 1048,
  /// <summary>
  /// Russian as spoken in Moldova.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDRussianMoldova))]
  RussianMoldova = 2073,
  /// <summary>
  /// Russian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDRussian))]
  Russian = 1049,
  /// <summary>
  /// Sami/Lappish.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSamiLappish))]
  SamiLappish = 1083,
  /// <summary>
  /// Sanskrit.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSanskrit))]
  Sanskrit = 1103,
  /// <summary>
  /// Sepedi.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSepedi))]
  Sepedi = 1132,
  /// <summary>
  /// The Serbian Bosnia Herzegovina Cyrillic language.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSerbianBosniaHerzegovinaCyrillic))]
  SerbianBosniaHerzegovinaCyrillic = 7194,
  /// <summary>
  /// The Serbian Bosnia Herzegovina Latin language.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSerbianBosniaHerzegovinaLatin))]
  SerbianBosniaHerzegovinaLatin = 6170,
  /// <summary>
  /// Serbian/Cyrillic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSerbianCyrillic))]
  SerbianCyrillic = 3098,
  /// <summary>
  /// Serbian/Latin.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSerbianLatin))]
  SerbianLatin = 2074,
  /// <summary>
  /// Sesotho.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSesotho))]
  Sesotho = 1072,
  /// <summary>
  /// Sindhi.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSindhi))]
  Sindhi = 1113,
  /// <summary>
  /// Sindhi as spoken in Pakistan.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSindhiPakistan))]
  SindhiPakistan = 2137,
  /// <summary>
  /// Sinhalese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSinhalese))]
  Sinhalese = 1115,
  /// <summary>
  /// Slovak.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSlovak))]
  Slovak = 1051,
  /// <summary>
  /// Slovenian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSlovenian))]
  Slovenian = 1060,
  /// <summary>
  /// Somali.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSomali))]
  Somali = 1143,
  /// <summary>
  /// Sorbian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSorbian))]
  Sorbian = 1070,
  /// <summary>
  /// Spanish as spoken in Argentina.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishArgentina))]
  SpanishArgentina = 11274,
  /// <summary>
  /// Spanish as spoken in Bolivia.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishBolivia))]
  SpanishBolivia = 16394,
  /// <summary>
  /// Spanish as spoken in Chile.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishChile))]
  SpanishChile = 13322,
  /// <summary>
  /// Spanish as spoken in Colombia.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishColombia))]
  SpanishColombia = 9226,
  /// <summary>
  /// Spanish as spoken in Costa Rica.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishCostaRica))]
  SpanishCostaRica = 5130,
  /// <summary>
  /// Spanish as spoken in the Dominican Republic.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishDominicanRepublic))]
  SpanishDominicanRepublic = 7178,
  /// <summary>
  /// Spanish as spoken in Ecuador.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishEcuador))]
  SpanishEcuador = 12298,
  /// <summary>
  /// Spanish as spoken in El Salvador.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishElSalvador))]
  SpanishElSalvador = 17418,
  /// <summary>
  /// Spanish as spoken in Guatemala.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishGuatemala))]
  SpanishGuatemala = 4106,
  /// <summary>
  /// Spanish as spoken in Honduras.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishHonduras))]
  SpanishHonduras = 18442,
  /// <summary>
  /// Spanish as spoken in Mexico.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDMexicanSpanish))]
  MexicanSpanish = 2058,
  /// <summary>
  /// Spanish as spoken in Nicaragua.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishNicaragua))]
  SpanishNicaragua = 19466,
  /// <summary>
  /// Spanish as spoken in Panama.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishPanama))]
  SpanishPanama = 6154,
  /// <summary>
  /// Spanish as spoken in Paraguay.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishParaguay))]
  SpanishParaguay = 15370,
  /// <summary>
  /// Spanish as spoken in Peru.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishPeru))]
  SpanishPeru = 10250,
  /// <summary>
  /// Spanish as spoken in Puerto Rico.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishPuertoRico))]
  SpanishPuertoRico = 20490,
  /// <summary>
  /// Spanish (Modern Sort).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishModernSort))]
  SpanishModernSort = 3082,
  /// <summary>
  /// Spanish.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanish))]
  Spanish = 1034,
  /// <summary>
  /// Spanish as spoken in Uruguay.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishUruguay))]
  SpanishUruguay = 14346,
  /// <summary>
  /// Spanish as spoken in Venezuela.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSpanishVenezuela))]
  SpanishVenezuela = 8202,
  /// <summary>
  /// Sutu.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSutu))]
  Sutu = 1072,
  /// <summary>
  /// Swahili.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSwahili))]
  Swahili = 1089,
  /// <summary>
  /// Swedish as spoken in Finland.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSwedishFinland))]
  SwedishFinland = 2077,
  /// <summary>
  /// Swedish.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSwedish))]
  Swedish = 1053,
  /// <summary>
  /// Syriac.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDSyriac))]
  Syriac = 1114,
  /// <summary>
  /// Tajik.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDTajik))]
  Tajik = 1064,
  /// <summary>
  /// Tamil.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDTamil))]
  Tamil = 1097,
  /// <summary>
  /// Tamazight.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDTamazight))]
  Tamazight = 1119,
  /// <summary>
  /// Tamazight (Latin).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDTamazightLatin))]
  TamazightLatin = 2143,
  /// <summary>
  /// Tatar.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDTatar))]
  Tatar = 1092,
  /// <summary>
  /// Telugu.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDTelugu))]
  Telugu = 1098,
  /// <summary>
  /// Thai.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDThai))]
  Thai = 1054,
  /// <summary>
  /// Tibetan.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDTibetan))]
  Tibetan = 1105,
  /// <summary>
  /// Tigrigna as spoken in Ethiopia.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDTigrignaEthiopic))]
  TigrignaEthiopic = 1139,
  /// <summary>
  /// Tigrigna as spoken in Eritrea.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDTigrignaEritrea))]
  TigrignaEritrea = 2163,
  /// <summary>
  /// Tsonga.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDTsonga))]
  Tsonga = 1073,
  /// <summary>
  /// Tswana.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDTswana))]
  Tswana = 1074,
  /// <summary>
  /// Turkish.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDTurkish))]
  Turkish = 1055,
  /// <summary>
  /// Turkmen.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDTurkmen))]
  Turkmen = 1090,
  /// <summary>
  /// Ukrainian.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDUkrainian))]
  Ukrainian = 1058,
  /// <summary>
  /// Urdu.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDUrdu))]
  Urdu = 1056,
  /// <summary>
  /// Uzbek (Cyrillic).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDUzbekCyrillic))]
  UzbekCyrillic = 2115,
  /// <summary>
  /// Uzbek (Latin).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDUzbekLatin))]
  UzbekLatin = 1091,
  /// <summary>
  /// Venda.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDVenda))]
  Venda = 1075,
  /// <summary>
  /// Vietnamese.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDVietnamese))]
  Vietnamese = 1066,
  /// <summary>
  /// Welsh.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDWelsh))]
  Welsh = 1106,
  /// <summary>
  /// Xhosa.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDXhosa))]
  Xhosa = 1076,
  /// <summary>
  /// Yi.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDYi))]
  Yi = 1144,
  /// <summary>
  /// Yiddish.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDYiddish))]
  Yiddish = 1085,
  /// <summary>
  /// Yoruba.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDYoruba))]
  Yoruba = 1130,
  /// <summary>
  /// Zulu.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoLanguageID.msoLanguageIDZulu))]
  Zulu = 1077
}
