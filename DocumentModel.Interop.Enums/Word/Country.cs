namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the country/region setting of the current system.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcountry?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdCountry))]
public enum Country
{
  /// <summary>
  /// United States
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdUS))]
  US = 1,
  /// <summary>
  /// Canada
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdCanada))]
  Canada = 2,
  /// <summary>
  /// Latin America
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdLatinAmerica))]
  LatinAmerica = 3,
  /// <summary>
  /// Netherlands
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdNetherlands))]
  Netherlands = 31,
  /// <summary>
  /// France
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdFrance))]
  France = 33,
  /// <summary>
  /// Spain
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdSpain))]
  Spain = 34,
  /// <summary>
  /// Italy
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdItaly))]
  Italy = 39,
  /// <summary>
  /// United Kingdom
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdUK))]
  UK = 44,
  /// <summary>
  /// Denmark
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdDenmark))]
  Denmark = 45,
  /// <summary>
  /// Sweden
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdSweden))]
  Sweden = 46,
  /// <summary>
  /// Norway
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdNorway))]
  Norway = 47,
  /// <summary>
  /// Germany
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdGermany))]
  Germany = 49,
  /// <summary>
  /// Peru
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdPeru))]
  Peru = 51,
  /// <summary>
  /// Mexico
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdMexico))]
  Mexico = 52,
  /// <summary>
  /// Argentina
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdArgentina))]
  Argentina = 54,
  /// <summary>
  /// Brazil
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdBrazil))]
  Brazil = 55,
  /// <summary>
  /// Chile
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdChile))]
  Chile = 56,
  /// <summary>
  /// Venezuela
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdVenezuela))]
  Venezuela = 58,
  /// <summary>
  /// Japan
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdJapan))]
  Japan = 81,
  /// <summary>
  /// Korea
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdKorea))]
  Korea = 82,
  /// <summary>
  /// China
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdChina))]
  China = 86,
  /// <summary>
  /// Iceland
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdIceland))]
  Iceland = 354,
  /// <summary>
  /// Finland
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdFinland))]
  Finland = 358,
  /// <summary>
  /// Taiwan
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCountry.wdTaiwan))]
  Taiwan = 886
}
