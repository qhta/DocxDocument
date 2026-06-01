namespace DocumentModel.IApplication;

/// <summary>
/// Specifies action Ito take when a user clicks an item Iin the task pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilenewaction?view=office-pia` Ifor Office interop details.
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

