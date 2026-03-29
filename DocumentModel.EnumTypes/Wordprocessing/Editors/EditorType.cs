namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies a user or group of users for a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdeditortype?view=office-pia` for Office interop details.
/// </remarks>
public enum EditorType
{
  /// <summary>
  /// Represents the current user of the document.
  /// </summary>
  Current = -6,
  /// <summary>
  /// Represents the Editors group for documents that use Information Rights Management.
  /// </summary>
  Editors = -5,
  /// <summary>
  /// Represents the Owners group for documents that use Information Rights Management.
  /// </summary>
  Owners = -4,
  /// <summary>
  /// Represents all users who open a document.
  /// </summary>
  Everyone = -1
}
