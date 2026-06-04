namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a user or group of users for a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdeditortype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdEditorType))]
public enum EditorType
{
  /// <summary>
  /// Represents the current user of the document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEditorType.wdEditorCurrent))]
  Current = -6,
  /// <summary>
  /// Represents the Editors group for documents that use Information Rights Management.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEditorType.wdEditorEditors))]
  Editors = -5,
  /// <summary>
  /// Represents the Owners group for documents that use Information Rights Management.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEditorType.wdEditorOwners))]
  Owners = -4,
  /// <summary>
  /// Represents all users who open a document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEditorType.wdEditorEveryone))]
  Everyone = -1
}
