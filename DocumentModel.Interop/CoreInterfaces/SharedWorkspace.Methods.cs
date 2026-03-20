using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspace` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspace
{
  /// <summary>
  /// Invokes `Refresh`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.refresh?view=office-pia
  /// </remarks>
  public void Refresh();
  /// <summary>
  /// Invokes `CreateNew`.
  /// </summary>
  /// <param name="URL">The `URL` parameter.</param>
  /// <param name="Name">The `Name` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.createnew?view=office-pia
  /// </remarks>
  public void CreateNew(object URL, object Name);
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.delete?view=office-pia
  /// </remarks>
  public void Delete();
  /// <summary>
  /// Invokes `RemoveDocument`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.removedocument?view=office-pia
  /// </remarks>
  public void RemoveDocument();
  /// <summary>
  /// Invokes `Disconnect`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspace.disconnect?view=office-pia
  /// </remarks>
  public void Disconnect();
}
