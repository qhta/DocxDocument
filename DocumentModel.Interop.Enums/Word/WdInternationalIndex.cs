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
  wdListSeparator = unchecked((int)17),
  /// <summary>
  /// Specifies information specific to the current country/region and international settings.
  /// </summary>
  wdDecimalSeparator = unchecked((int)18),
  /// <summary>
  /// Specifies information specific to the current country/region and international settings.
  /// </summary>
  wdThousandsSeparator = unchecked((int)19),
  /// <summary>
  /// Returns the currency symbol ($ in U.S. English).
  /// </summary>
  wdCurrencyCode = unchecked((int)20),
  /// <summary>
  /// Returns True if you're using 24-hour time; returns False if you're using 12-hour time.
  /// </summary>
  wd24HourClock = unchecked((int)21),
  /// <summary>
  /// Returns the string used to indicate morning hours (for example, 10 AM).
  /// </summary>
  wdInternationalAM = unchecked((int)22),
  /// <summary>
  /// Returns the string used to indicate afternoon and evening hours (for example, 2 PM).
  /// </summary>
  wdInternationalPM = unchecked((int)23),
  /// <summary>
  /// Returns the time separator (: in U.S. English).
  /// </summary>
  wdTimeSeparator = unchecked((int)24),
  /// <summary>
  /// Returns the date separator (/ in U.S. English).
  /// [System.Runtime.InteropServices.Guid("5077203F-7859-39B5-BF08-8308BDE14529")] public enum WdInternationalIndex
  /// ﾉ Expand table wdProductLanguageID26 Returns the language version of Word.
  /// </summary>
  wdDateSeparator = unchecked((int)25),
  /// <summary>
  /// Specifies information specific to the current country/region and international settings.
  /// </summary>
  wdProductLanguageID = unchecked((int)26)
}
