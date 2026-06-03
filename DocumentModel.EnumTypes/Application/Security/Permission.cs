namespace DocumentModel.Drawings;

/// <summary>
/// Specifies an Information Rights Management (IRM) permission type for a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopermission?view=office-pia` for Office interop details.
/// </remarks>
public enum Permission
{
  /// <summary>
  /// Permission to view.
  /// </summary>
  IView = 1,
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
  /// Permission to access the object model programmatically.
  /// </summary>
  ObjModel = 32,
  /// <summary>
  /// Full control permissions.
  /// </summary>
  FullControl = 64,
  /// <summary>
  /// No description is available.
  /// </summary>
  AllCommon = 127
}

