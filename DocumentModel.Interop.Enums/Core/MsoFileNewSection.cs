namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the task pane section to which to add a file or where the file reference exists.
/// </summary>
public enum MsoFileNewSection
{
  /// <summary>
  /// Open Document section.
  /// </summary>
  msoOpenDocument,
  /// <summary>
  /// New section.
  /// </summary>
  msoNew,
  /// <summary>
  /// New from Existing File section.
  /// </summary>
  msoNewfromExistingFile,
  /// <summary>
  /// New from Template section.
  /// </summary>
  msoNewfromTemplate,
  /// <summary>
  /// Bottom section.
  /// </summary>
  msoBottomSection
}
