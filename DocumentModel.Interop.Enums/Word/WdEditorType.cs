namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a user or group of users for a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdeditortype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdEditorType
{
  /// <summary>
  /// Specifies a user or group of users for a document.
  /// </summary>
  Current = -6,
  /// <summary>
  /// Specifies a user or group of users for a document.
  /// </summary>
  Editors = -5,
  /// <summary>
  /// Specifies a user or group of users for a document.
  /// </summary>
  Owners = -4,
  /// <summary>
  /// Specifies a user or group of users for a document.
  /// </summary>
  Everyone = -1
}
