namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the country/region setting of the current system.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcountry?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdCountry")]
public enum Country
{
  /// <summary>
  /// United States
  /// </summary>
  [InteropEnumValue("wdUS")]
  US = 1,
  /// <summary>
  /// Canada
  /// </summary>
  [InteropEnumValue("wdCanada")]
  Canada = 2,
  /// <summary>
  /// Latin America
  /// </summary>
  [InteropEnumValue("wdLatinAmerica")]
  LatinAmerica = 3,
  /// <summary>
  /// Netherlands
  /// </summary>
  [InteropEnumValue("wdNetherlands")]
  Netherlands = 31,
  /// <summary>
  /// France
  /// </summary>
  [InteropEnumValue("wdFrance")]
  France = 33,
  /// <summary>
  /// Spain
  /// </summary>
  [InteropEnumValue("wdSpain")]
  Spain = 34,
  /// <summary>
  /// Italy
  /// </summary>
  [InteropEnumValue("wdItaly")]
  Italy = 39,
  /// <summary>
  /// United Kingdom
  /// </summary>
  [InteropEnumValue("wdUK")]
  UK = 44,
  /// <summary>
  /// Denmark
  /// </summary>
  [InteropEnumValue("wdDenmark")]
  Denmark = 45,
  /// <summary>
  /// Sweden
  /// </summary>
  [InteropEnumValue("wdSweden")]
  Sweden = 46,
  /// <summary>
  /// Norway
  /// </summary>
  [InteropEnumValue("wdNorway")]
  Norway = 47,
  /// <summary>
  /// Germany
  /// </summary>
  [InteropEnumValue("wdGermany")]
  Germany = 49,
  /// <summary>
  /// Peru
  /// </summary>
  [InteropEnumValue("wdPeru")]
  Peru = 51,
  /// <summary>
  /// Mexico
  /// </summary>
  [InteropEnumValue("wdMexico")]
  Mexico = 52,
  /// <summary>
  /// Argentina
  /// </summary>
  [InteropEnumValue("wdArgentina")]
  Argentina = 54,
  /// <summary>
  /// Brazil
  /// </summary>
  [InteropEnumValue("wdBrazil")]
  Brazil = 55,
  /// <summary>
  /// Chile
  /// </summary>
  [InteropEnumValue("wdChile")]
  Chile = 56,
  /// <summary>
  /// Venezuela
  /// </summary>
  [InteropEnumValue("wdVenezuela")]
  Venezuela = 58,
  /// <summary>
  /// Japan
  /// </summary>
  [InteropEnumValue("wdJapan")]
  Japan = 81,
  /// <summary>
  /// Korea
  /// </summary>
  [InteropEnumValue("wdKorea")]
  Korea = 82,
  /// <summary>
  /// China
  /// </summary>
  [InteropEnumValue("wdChina")]
  China = 86,
  /// <summary>
  /// Iceland
  /// </summary>
  [InteropEnumValue("wdIceland")]
  Iceland = 354,
  /// <summary>
  /// Finland
  /// </summary>
  [InteropEnumValue("wdFinland")]
  Finland = 358,
  /// <summary>
  /// Taiwan
  /// </summary>
  [InteropEnumValue("wdTaiwan")]
  Taiwan = 886
}
