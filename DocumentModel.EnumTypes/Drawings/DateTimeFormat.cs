namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the format of a date/time data type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodatetimeformat?view=office-pia` for Office interop details.
/// </remarks>
public enum DateTimeFormat
{
  /// <summary>
  /// Specifies a mixed format.
  /// </summary>
  FormatMixed = -2,
  /// <summary>
  /// Specifies a Mdyy format.
  /// </summary>
  ShortestDate = 1,
  /// <summary>
  /// Specifies a ddddMMMMddyyyy format.
  /// </summary>
  LongestDate = 2,
  /// <summary>
  /// Specifies MMMMyyyy format.
  /// </summary>
  LongMonthLongYear = 3,
  /// <summary>
  /// Specifies a MMMMdyyyy format.
  /// </summary>
  LongMonthDayLongYear = 4,
  /// <summary>
  /// Specifies MMMyy format.
  /// </summary>
  MediumMonthShortYear = 5,
  /// <summary>
  /// Specifies a MMMMyy format.
  /// </summary>
  LongMonthShortYear = 6,
  /// <summary>
  /// Specifies a MMyy format.
  /// </summary>
  ShortMonthShortYear = 7,
  /// <summary>
  /// Specifies a MMddyyHmm format.
  /// </summary>
  ShortDateTime24 = 8,
  /// <summary>
  /// Specifies a MMddyyhmmAMPM format.
  /// </summary>
  ShortDateTime12 = 9,
  /// <summary>
  /// Specifies Hmm format.
  /// </summary>
  ShortestTime = 10,
  /// <summary>
  /// Specifies a Hmmss format.
  /// </summary>
  ShortTimeWithSeconds = 11,
  /// <summary>
  /// Specifies a hmmAMPM format.
  /// </summary>
  ShortTime12 = 12,
  /// <summary>
  /// Specifies a hmmssAMPM format.
  /// </summary>
  ShortTime12WithSeconds = 13,
  /// <summary>
  /// Specifies Ithat the Office application will determine the format.
  /// </summary>
  Auto = 14
}

