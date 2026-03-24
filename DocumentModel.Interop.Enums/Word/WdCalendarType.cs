namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a calendar type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcalendartype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdCalendarType
{
  /// <summary>
  /// Western.
  /// </summary>
  Western = 0,
  /// <summary>
  /// Arabic.
  /// </summary>
  Arabic = 1,
  /// <summary>
  /// Hebrew.
  /// </summary>
  Hebrew = 2,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  Taiwan = 3,
  /// <summary>
  /// Japanese.
  /// </summary>
  Japan = 4,
  /// <summary>
  /// Thai.
  /// </summary>
  Thai = 5,
  /// <summary>
  /// Korean.
  /// </summary>
  Korean = 6,
  /// <summary>
  /// Saka Era.
  /// </summary>
  SakaEra = 7,
  /// <summary>
  /// English.
  /// </summary>
  TranslitEnglish = 8,
  /// <summary>
  /// French.
  /// </summary>
  TranslitFrench = 9,
  /// <summary>
  /// Reserved for internal use. [System.Runtime.InteropServices.Guid("2F1B54DB-4A60-3B71-9EB6-7AE77033B5B5")]
  /// public enum WdCalendarType ﾉ Expand table
  /// </summary>
  Umalqura = 13
}
