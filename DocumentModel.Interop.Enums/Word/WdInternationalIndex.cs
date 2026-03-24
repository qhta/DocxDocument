namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies information specific to the current country/region and international settings.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdinternationalindex?view=office-pia` for Office interop details.
/// </remarks>
public enum WdInternationalIndex
{
  /// <summary>
  /// Returns the list separator (, in U.S. English).
  /// </summary>
  ListSeparator = 17,
  /// <summary>
  /// Returns the decimal separator (. in U.S. English).
  /// </summary>
  DecimalSeparator = 18,
  /// <summary>
  /// Returns the thousands separator (, in U.S. English).
  /// </summary>
  ThousandsSeparator = 19,
  /// <summary>
  /// Returns the currency symbol ($ in U.S. English).
  /// </summary>
  CurrencyCode = 20,
  /// <summary>
  /// Specifies information specific to the current country/region and international settings.
  /// </summary>
  TwentyFourHourClock = 21,
  /// <summary>
  /// Returns the string used to indicate morning hours (for example, 10 AM).
  /// </summary>
  InternationalAM = 22,
  /// <summary>
  /// Returns the string used to indicate afternoon and evening hours (for example, 2 PM).
  /// </summary>
  InternationalPM = 23,
  /// <summary>
  /// Returns the time separator (: in U.S. English).
  /// </summary>
  TimeSeparator = 24,
  /// <summary>
  /// Returns the date separator (/ in U.S. English).
  /// </summary>
  DateSeparator = 25,
  /// <summary>
  /// Returns the language version of Word.
  /// </summary>
  ProductLanguageID = 26
}
