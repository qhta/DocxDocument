using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents a shared workspace linked to the current document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace?view=office-pia"/>
public partial interface SharedWorkspace: IModelObject
{
  /// <summary>
  /// Invokes `Refresh`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.refresh?view=office-pia"/>
  public void Refresh();
  /// <summary>
  /// Invokes `CreateNew`.
  /// </summary>
  /// <param name="URL">The `URL` parameter.</param>
  /// <param name="Name">The `Name` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.createnew?view=office-pia"/>
  public void CreateNew(object URL, object Name);
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.delete?view=office-pia"/>
  public void Delete();
  /// <summary>
  /// Invokes `RemoveDocument`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.removedocument?view=office-pia"/>
  public void RemoveDocument();
  /// <summary>
  /// Invokes `Disconnect`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.disconnect?view=office-pia"/>
  public void Disconnect();
}

