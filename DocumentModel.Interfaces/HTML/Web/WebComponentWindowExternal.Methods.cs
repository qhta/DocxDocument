
namespace DocumentModel.Application;

/// <summary>
/// Represents the `WebComponentWindowExternal` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal?view=office-pia"/>
public partial interface IWebComponentWindowExternal: IModelObject
{
  /// <summary>
  /// Invokes `CloseWindow`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal.closewindow?view=office-pia"/>
  public void CloseWindow();
}

