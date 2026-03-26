namespace DocumentModel.Interop.Word;

/// <summary>
/// When comparing two files for differences, specifies whether to create a new file or mark the differences
/// between the two documents in the original document or the revised document. Version Added: Word 2007
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcomparedestination?view=office-pia` for Office interop details.
/// </remarks>
public enum CompareDestination
{
  /// <summary>
  /// Tracks the differences between the two files using tracked changes in the original document.
  /// </summary>
  Original = 0,
  /// <summary>
  /// Tracks the differences between the two files using tracked changes in the revised document.
  /// </summary>
  Revised = 1,
  /// <summary>
  /// Creates a new file and tracks the diferences between the original document and the revised document using
  /// tracked changes.
  /// </summary>
  New = 2
}
