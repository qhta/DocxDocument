namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies information specific to the current country/region and international settings.
/// </summary>
public enum WdInternationalIndex
{
  /// <summary>
  /// Returns the list separator (, in U.S. English). wdDecimalSeparator18 Returns the decimal separator (. in U.S.
  /// English). wdThousandsSeparator19 Returns the thousands separator (, in U.S. English).
  /// </summary>
  ListSeparator = unchecked((int)17),
  /// <summary>
  /// Specifies information specific to the current country/region and international settings.
  /// </summary>
  DecimalSeparator = unchecked((int)18),
  /// <summary>
  /// Specifies information specific to the current country/region and international settings.
  /// </summary>
  ThousandsSeparator = unchecked((int)19),
  /// <summary>
  /// Returns the currency symbol ($ in U.S. English).
  /// </summary>
  CurrencyCode = unchecked((int)20),
  /// <summary>
  /// Returns True if you're using 24-hour time; returns False if you're using 12-hour time.
  /// </summary>
  TwentyFourHourClock = unchecked((int)21),
  /// <summary>
  /// Returns the string used to indicate morning hours (for example, 10 AM).
  /// </summary>
  InternationalAM = unchecked((int)22),
  /// <summary>
  /// Returns the string used to indicate afternoon and evening hours (for example, 2 PM).
  /// </summary>
  InternationalPM = unchecked((int)23),
  /// <summary>
  /// Returns the time separator (: in U.S. English).
  /// </summary>
  TimeSeparator = unchecked((int)24),
  /// <summary>
  /// Returns the date separator (/ in U.S. English).
  /// [System.Runtime.InteropServices.Guid("5077203F-7859-39B5-BF08-8308BDE14529")] public enum WdInternationalIndex
  /// ﾉ Expand table wdProductLanguageID26 Returns the language version of Word.
  /// </summary>
  DateSeparator = unchecked((int)25),
  /// <summary>
  /// Specifies information specific to the current country/region and international settings.
  /// </summary>
  ProductLanguageID = unchecked((int)26)
}
