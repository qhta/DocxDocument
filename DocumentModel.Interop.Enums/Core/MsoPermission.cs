namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies an Information Rights Management (IRM) permission type for a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopermission?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoPermission))]
public enum MsoPermission
{
  /// <summary>
  /// Permission to view.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPermission.msoPermissionView))]
  View = 1,
  /// <summary>
  /// Permission to read.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPermission.msoPermissionRead))]
  Read = 1,
  /// <summary>
  /// Permission to edit.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPermission.msoPermissionEdit))]
  Edit = 2,
  /// <summary>
  /// Permission to save.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPermission.msoPermissionSave))]
  Save = 4,
  /// <summary>
  /// Permission to extract.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPermission.msoPermissionExtract))]
  Extract = 8,
  /// <summary>
  /// Permission to change.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPermission.msoPermissionChange))]
  Change = 15,
  /// <summary>
  /// Permission to print.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPermission.msoPermissionPrint))]
  Print = 16,
  /// <summary>
  /// Permission to access the object model programmatically.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPermission.msoPermissionObjModel))]
  ObjModel = 32,
  /// <summary>
  /// Full control permissions.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPermission.msoPermissionFullControl))]
  FullControl = 64,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoPermission.msoPermissionAllCommon))]
  AllCommon = 127
}
