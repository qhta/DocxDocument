namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies an Information Rights Management (IRM) permission type for a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopermission?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoPermission")]
public enum MsoPermission
{
  /// <summary>
  /// Permission to view.
  /// </summary>
  [InteropEnumValue("msoPermissionView")]
  View = 1,
  /// <summary>
  /// Permission to read.
  /// </summary>
  [InteropEnumValue("msoPermissionRead")]
  Read = 1,
  /// <summary>
  /// Permission to edit.
  /// </summary>
  [InteropEnumValue("msoPermissionEdit")]
  Edit = 2,
  /// <summary>
  /// Permission to save.
  /// </summary>
  [InteropEnumValue("msoPermissionSave")]
  Save = 4,
  /// <summary>
  /// Permission to extract.
  /// </summary>
  [InteropEnumValue("msoPermissionExtract")]
  Extract = 8,
  /// <summary>
  /// Permission to change.
  /// </summary>
  [InteropEnumValue("msoPermissionChange")]
  Change = 15,
  /// <summary>
  /// Permission to print.
  /// </summary>
  [InteropEnumValue("msoPermissionPrint")]
  Print = 16,
  /// <summary>
  /// Permission to access the object model programmatically.
  /// </summary>
  [InteropEnumValue("msoPermissionObjModel")]
  ObjModel = 32,
  /// <summary>
  /// Full control permissions.
  /// </summary>
  [InteropEnumValue("msoPermissionFullControl")]
  FullControl = 64,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoPermissionAllCommon")]
  AllCommon = 127
}
