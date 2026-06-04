namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the task pane section to which to add a file or where the file reference exists.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilenewsection?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoFileNewSection")]
public enum FileNewSection
{
  /// <summary>
  /// Open Document section.
  /// </summary>
  [InteropEnumValue("msoOpenDocument")]
  OpenDocument,
  /// <summary>
  /// New section.
  /// </summary>
  [InteropEnumValue("msoNew")]
  New,
  /// <summary>
  /// New from Existing File section.
  /// </summary>
  [InteropEnumValue("msoNewfromExistingFile")]
  NewfromExistingFile,
  /// <summary>
  /// New from Template section.
  /// </summary>
  [InteropEnumValue("msoNewfromTemplate")]
  NewfromTemplate,
  /// <summary>
  /// Bottom section.
  /// </summary>
  [InteropEnumValue("msoBottomSection")]
  BottomSection
}
