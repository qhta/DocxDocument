namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the number of replacements Ito be made when find and replace is used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreplace?view=office-pia` for Office interop details.
/// </remarks>
public enum Replace
{
  /// <summary>
  /// Replace no occurrences.
  /// </summary>
  None = 0,
  /// <summary>
  /// Replace the first occurrence encountered.
  /// </summary>
  One = 1,
  /// <summary>
  /// Replace all occurrences.
  /// </summary>
  All = 2
}

