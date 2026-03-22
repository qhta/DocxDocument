namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies an Information Rights Management (IRM) permission type for a document.
/// </summary>
public enum MsoPermission
{
  /// <summary>
  /// Permission to view.
  /// </summary>
  msoPermissionView = 1,
  /// <summary>
  /// Permission to read.
  /// </summary>
  msoPermissionRead = 1,
  /// <summary>
  /// Permission to edit.
  /// </summary>
  msoPermissionEdit = 2,
  /// <summary>
  /// Permission to save.
  /// </summary>
  msoPermissionSave = 4,
  /// <summary>
  /// Permission to extract.
  /// </summary>
  msoPermissionExtract = 8,
  /// <summary>
  /// Permission to change.
  /// </summary>
  msoPermissionChange = 15,
  /// <summary>
  /// Permission to print.
  /// </summary>
  msoPermissionPrint = 16,
  /// <summary>
  /// Permission to access the object model programmatically. msoPermissionFullControl64 Full control permissions.
  /// msoPermissionAllCommon127
  /// </summary>
  msoPermissionObjModel = 32,
  /// <summary>
  /// Specifies an Information Rights Management (IRM) permission type for a document.
  /// </summary>
  msoPermissionFullControl = 64,
  /// <summary>
  /// Specifies an Information Rights Management (IRM) permission type for a document.
  /// </summary>
  msoPermissionAllCommon = 127
}
