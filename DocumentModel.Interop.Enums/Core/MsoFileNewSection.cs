namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the task pane section to which to add a file or where the file reference exists.
/// </summary>
public enum MsoFileNewSection
{
  /// <summary>
  /// Open Document section.
  /// </summary>
  OpenDocument,
  /// <summary>
  /// New section.
  /// </summary>
  New,
  /// <summary>
  /// New from Existing File section.
  /// </summary>
  NewfromExistingFile,
  /// <summary>
  /// New from Template section.
  /// </summary>
  NewfromTemplate,
  /// <summary>
  /// Bottom section.
  /// </summary>
  BottomSection
}
