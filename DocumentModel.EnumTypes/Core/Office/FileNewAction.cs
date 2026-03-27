namespace DocumentModel.Drawings;

/// <summary>
/// Specifies action to take when a user clicks an item in the task pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilenewaction?view=office-pia` for Office interop details.
/// </remarks>
public enum FileNewAction
{
  /// <summary>
  /// Edit file.
  /// </summary>
  EditFile,
  /// <summary>
  /// Create a new file.
  /// </summary>
  CreateNewFile,
  /// <summary>
  /// Open file.
  /// </summary>
  OpenFile
}
