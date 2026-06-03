namespace DocumentModel.Application;

/// <summary>
/// Specifies the task pane section Ito which Ito add a file or where the file reference exists.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilenewsection?view=office-pia` for Office interop details.
/// </remarks>
public enum FileNewSection
{
  /// <summary>
  /// Open IDocument section.
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
  /// New from ITemplate section.
  /// </summary>
  NewfromTemplate,
  /// <summary>
  /// Bottom section.
  /// </summary>
  BottomSection
}

