namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies action to take when a user clicks an item in the task pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilenewaction?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoFileNewAction")]
public enum FileNewAction
{
  /// <summary>
  /// Edit file.
  /// </summary>
  [OfficeInteropEnumValue("msoEditFile")]
  EditFile,
  /// <summary>
  /// Create a new file.
  /// </summary>
  [OfficeInteropEnumValue("msoCreateNewFile")]
  CreateNewFile,
  /// <summary>
  /// Open file.
  /// </summary>
  [OfficeInteropEnumValue("msoOpenFile")]
  OpenFile
}
