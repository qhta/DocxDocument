namespace DocumentModel.Interop.Word;

/// <summary>
/// When comparing two files for differences, specifies whether to create a new file or mark the differences
/// between the two documents in the original document or the revised document. Version Added: Word 2007
/// </summary>
public enum WdCompareDestination
{
  /// <summary>
  /// When comparing two files for differences, specifies whether to create a new file or mark the differences
  /// between the two documents in the original document or the revised document. Version Added: Word 2007
  /// </summary>
  Original = 0,
  /// <summary>
  /// Tracks the differences between the two files using tracked changes in the revised document.
  /// wdCompareDestinationNew2 Creates a new file and tracks the diferences between the original document and the
  /// revised document using tracked changes.
  /// </summary>
  Revised = 1,
  /// <summary>
  /// When comparing two files for differences, specifies whether to create a new file or mark the differences
  /// between the two documents in the original document or the revised document. Version Added: Word 2007
  /// </summary>
  New = 2
}
