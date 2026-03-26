namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format in which to display month names.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmonthnames?view=office-pia` for Office interop details.
/// </remarks>
public enum MonthNames
{
  /// <summary>
  /// Arabic format.
  /// </summary>
  Arabic = 0,
  /// <summary>
  /// English format.
  /// </summary>
  English = 1,
  /// <summary>
  /// French format.
  /// </summary>
  French = 2
}
