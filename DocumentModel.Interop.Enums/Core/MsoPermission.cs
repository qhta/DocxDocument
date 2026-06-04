namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies an Information Rights Management (IRM) permission type for a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopermission?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoPermission")]
public enum MsoPermission
{
  /// <summary>
  /// Permission to view.
  /// </summary>
  [OfficeInteropEnumValue("msoPermissionView")]
  View = 1,
  /// <summary>
  /// Permission to read.
  /// </summary>
  [OfficeInteropEnumValue("msoPermissionRead")]
  Read = 1,
  /// <summary>
  /// Permission to edit.
  /// </summary>
  [OfficeInteropEnumValue("msoPermissionEdit")]
  Edit = 2,
  /// <summary>
  /// Permission to save.
  /// </summary>
  [OfficeInteropEnumValue("msoPermissionSave")]
  Save = 4,
  /// <summary>
  /// Permission to extract.
  /// </summary>
  [OfficeInteropEnumValue("msoPermissionExtract")]
  Extract = 8,
  /// <summary>
  /// Permission to change.
  /// </summary>
  [OfficeInteropEnumValue("msoPermissionChange")]
  Change = 15,
  /// <summary>
  /// Permission to print.
  /// </summary>
  [OfficeInteropEnumValue("msoPermissionPrint")]
  Print = 16,
  /// <summary>
  /// Permission to access the object model programmatically.
  /// </summary>
  [OfficeInteropEnumValue("msoPermissionObjModel")]
  ObjModel = 32,
  /// <summary>
  /// Full control permissions.
  /// </summary>
  [OfficeInteropEnumValue("msoPermissionFullControl")]
  FullControl = 64,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoPermissionAllCommon")]
  AllCommon = 127
}
