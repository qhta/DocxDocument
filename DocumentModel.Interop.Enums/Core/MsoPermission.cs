namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies an Information Rights Management (IRM) permission type for a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopermission?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoPermission
{
  /// <summary>
  /// Permission to view.
  /// </summary>
  View = 1,
  /// <summary>
  /// Permission to read.
  /// </summary>
  Read = 1,
  /// <summary>
  /// Permission to edit.
  /// </summary>
  Edit = 2,
  /// <summary>
  /// Permission to save.
  /// </summary>
  Save = 4,
  /// <summary>
  /// Permission to extract.
  /// </summary>
  Extract = 8,
  /// <summary>
  /// Permission to change.
  /// </summary>
  Change = 15,
  /// <summary>
  /// Permission to print.
  /// </summary>
  Print = 16,
  /// <summary>
  /// Permission to access the object model programmatically. msoPermissionFullControl64 Full control permissions.
  /// msoPermissionAllCommon127
  /// </summary>
  ObjModel = 32,
  /// <summary>
  /// Specifies an Information Rights Management (IRM) permission type for a document.
  /// </summary>
  FullControl = 64,
  /// <summary>
  /// Specifies an Information Rights Management (IRM) permission type for a document.
  /// </summary>
  AllCommon = 127
}
