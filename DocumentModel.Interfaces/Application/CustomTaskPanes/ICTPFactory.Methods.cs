
namespace DocumentModel.Application;

/// <summary>
/// Used to create a custom task pane.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ictpfactory?view=office-pia"/>
public partial interface ICTPFactory: IModelObject
{
  /// <summary>
  /// Creates an instance of a custom task pane.
  /// </summary>
  /// <param name="CTPAxID">The `CTPAxID` parameter.</param>
  /// <param name="CTPTitle">The `CTPTitle` parameter.</param>
  /// <param name="CTPParentWindow">The `CTPParentWindow` parameter.</param>
  /// <returns>The created custom task pane.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ictpfactory.createctp?view=office-pia"/>
  public ICustomTaskPane CreateCTP(string CTPAxID, string CTPTitle, object CTPParentWindow);
}

