namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the task pane section to which to add a file or where the file reference exists.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilenewsection?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoFileNewSection))]
public enum FileNewSection
{
  /// <summary>
  /// Open Document section.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileNewSection.msoOpenDocument))]
  OpenDocument,
  /// <summary>
  /// New section.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileNewSection.msoNew))]
  New,
  /// <summary>
  /// New from Existing File section.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileNewSection.msoNewfromExistingFile))]
  NewfromExistingFile,
  /// <summary>
  /// New from Template section.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileNewSection.msoNewfromTemplate))]
  NewfromTemplate,
  /// <summary>
  /// Bottom section.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileNewSection.msoBottomSection))]
  BottomSection
}
