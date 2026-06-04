namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the country/region setting of the current system.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcountry?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdCountry")]
public enum Country
{
  /// <summary>
  /// United States
  /// </summary>
  [WordInteropEnumValue("wdUS")]
  US = 1,
  /// <summary>
  /// Canada
  /// </summary>
  [WordInteropEnumValue("wdCanada")]
  Canada = 2,
  /// <summary>
  /// Latin America
  /// </summary>
  [WordInteropEnumValue("wdLatinAmerica")]
  LatinAmerica = 3,
  /// <summary>
  /// Netherlands
  /// </summary>
  [WordInteropEnumValue("wdNetherlands")]
  Netherlands = 31,
  /// <summary>
  /// France
  /// </summary>
  [WordInteropEnumValue("wdFrance")]
  France = 33,
  /// <summary>
  /// Spain
  /// </summary>
  [WordInteropEnumValue("wdSpain")]
  Spain = 34,
  /// <summary>
  /// Italy
  /// </summary>
  [WordInteropEnumValue("wdItaly")]
  Italy = 39,
  /// <summary>
  /// United Kingdom
  /// </summary>
  [WordInteropEnumValue("wdUK")]
  UK = 44,
  /// <summary>
  /// Denmark
  /// </summary>
  [WordInteropEnumValue("wdDenmark")]
  Denmark = 45,
  /// <summary>
  /// Sweden
  /// </summary>
  [WordInteropEnumValue("wdSweden")]
  Sweden = 46,
  /// <summary>
  /// Norway
  /// </summary>
  [WordInteropEnumValue("wdNorway")]
  Norway = 47,
  /// <summary>
  /// Germany
  /// </summary>
  [WordInteropEnumValue("wdGermany")]
  Germany = 49,
  /// <summary>
  /// Peru
  /// </summary>
  [WordInteropEnumValue("wdPeru")]
  Peru = 51,
  /// <summary>
  /// Mexico
  /// </summary>
  [WordInteropEnumValue("wdMexico")]
  Mexico = 52,
  /// <summary>
  /// Argentina
  /// </summary>
  [WordInteropEnumValue("wdArgentina")]
  Argentina = 54,
  /// <summary>
  /// Brazil
  /// </summary>
  [WordInteropEnumValue("wdBrazil")]
  Brazil = 55,
  /// <summary>
  /// Chile
  /// </summary>
  [WordInteropEnumValue("wdChile")]
  Chile = 56,
  /// <summary>
  /// Venezuela
  /// </summary>
  [WordInteropEnumValue("wdVenezuela")]
  Venezuela = 58,
  /// <summary>
  /// Japan
  /// </summary>
  [WordInteropEnumValue("wdJapan")]
  Japan = 81,
  /// <summary>
  /// Korea
  /// </summary>
  [WordInteropEnumValue("wdKorea")]
  Korea = 82,
  /// <summary>
  /// China
  /// </summary>
  [WordInteropEnumValue("wdChina")]
  China = 86,
  /// <summary>
  /// Iceland
  /// </summary>
  [WordInteropEnumValue("wdIceland")]
  Iceland = 354,
  /// <summary>
  /// Finland
  /// </summary>
  [WordInteropEnumValue("wdFinland")]
  Finland = 358,
  /// <summary>
  /// Taiwan
  /// </summary>
  [WordInteropEnumValue("wdTaiwan")]
  Taiwan = 886
}
