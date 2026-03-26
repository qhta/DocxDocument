namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the task pane section to which to add a file or where the file reference exists.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilenewsection?view=office-pia` for Office interop details.
/// </remarks>
public enum FileNewSection
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
