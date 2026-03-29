namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of field separator.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsortseparator?view=office-pia` for Office interop details.
/// </remarks>
public enum SortSeparator
{
  /// <summary>
  /// Tab.
  /// </summary>
  Tabs = 0,
  /// <summary>
  /// Comma.
  /// </summary>
  Commas = 1,
  /// <summary>
  /// Default table separator.
  /// </summary>
  DefaultTableSeparator = 2
}
