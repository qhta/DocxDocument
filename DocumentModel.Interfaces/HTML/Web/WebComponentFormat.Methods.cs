
namespace DocumentModel.Application;

/// <summary>
/// Represents the `WebComponentFormat` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat?view=office-pia"/>
public partial interface IWebComponentFormat: IModelObject
{
  /// <summary>
  /// Invokes `LaunchPropertiesWindow`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat.launchpropertieswindow?view=office-pia"/>
  public void LaunchPropertiesWindow();
}

