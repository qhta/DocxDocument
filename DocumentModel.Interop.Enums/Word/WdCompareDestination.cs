namespace DocumentModel.Interop.Word;

/// <summary>
/// When comparing two files for differences, specifies whether to create a new file or mark the differences
/// between the two documents in the original document or the revised document. Version Added: Word 2007
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcomparedestination?view=office-pia` for Office interop details.
/// </remarks>
public enum WdCompareDestination
{
  /// <summary>
  /// When comparing two files for differences, specifies whether to create a new file or mark the differences
  /// between the two documents in the original document or the revised document. Version Added: Word 2007
  /// </summary>
  Original = 0,
  /// <summary>
  /// When comparing two files for differences, specifies whether to create a new file or mark the differences
  /// between the two documents in the original document or the revised document. Version Added: Word 2007
  /// </summary>
  Revised = 1,
  /// <summary>
  /// When comparing two files for differences, specifies whether to create a new file or mark the differences
  /// between the two documents in the original document or the revised document. Version Added: Word 2007
  /// </summary>
  New = 2
}
