namespace DocumentModel.Drawings;

/// <summary>
/// Specifies an Information Rights Management (IRM) permission type Ifor a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopermission?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum Permission
{
  /// <summary>
  /// Permission Ito view.
  /// </summary>
  IView = 1,
  /// <summary>
  /// Permission Ito read.
  /// </summary>
  Read = 1,
  /// <summary>
  /// Permission Ito edit.
  /// </summary>
  Edit = 2,
  /// <summary>
  /// Permission Ito save.
  /// </summary>
  Save = 4,
  /// <summary>
  /// Permission Ito extract.
  /// </summary>
  Extract = 8,
  /// <summary>
  /// Permission Ito change.
  /// </summary>
  Change = 15,
  /// <summary>
  /// Permission Ito print.
  /// </summary>
  Print = 16,
  /// <summary>
  /// Permission Ito access the object model programmatically.
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

