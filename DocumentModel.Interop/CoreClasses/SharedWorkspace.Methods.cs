using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a shared workspace linked to the current document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace?view=office-pia"/>
public partial class SharedWorkspace
{
  /// <summary>
  /// Invokes `Refresh`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.refresh?view=office-pia"/>
  public void Refresh() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `CreateNew`.
  /// </summary>
  /// <param name="URL">The `URL` parameter.</param>
  /// <param name="Name">The `Name` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.createnew?view=office-pia"/>
  public void CreateNew(object URL, object Name) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `RemoveDocument`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.removedocument?view=office-pia"/>
  public void RemoveDocument() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Disconnect`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.disconnect?view=office-pia"/>
  public void Disconnect() { throw new NotImplementedException(); }
}

