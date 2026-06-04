namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the task pane section to which to add a file or where the file reference exists.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilenewsection?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoFileNewSection")]
public enum FileNewSection
{
  /// <summary>
  /// Open Document section.
  /// </summary>
  [OfficeInteropEnumValue("msoOpenDocument")]
  OpenDocument,
  /// <summary>
  /// New section.
  /// </summary>
  [OfficeInteropEnumValue("msoNew")]
  New,
  /// <summary>
  /// New from Existing File section.
  /// </summary>
  [OfficeInteropEnumValue("msoNewfromExistingFile")]
  NewfromExistingFile,
  /// <summary>
  /// New from Template section.
  /// </summary>
  [OfficeInteropEnumValue("msoNewfromTemplate")]
  NewfromTemplate,
  /// <summary>
  /// Bottom section.
  /// </summary>
  [OfficeInteropEnumValue("msoBottomSection")]
  BottomSection
}
