
namespace DocumentModel.Interop.Core;

/// <summary>
/// Used to create a custom task pane.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ictpfactory?view=office-pia
/// </remarks>
public partial interface ICTPFactory
{
  /// <summary>
  /// Creates an instance of a custom task pane.
  /// </summary>
  /// <param name="CTPAxID">The `CTPAxID` parameter.</param>
  /// <param name="CTPTitle">The `CTPTitle` parameter.</param>
  /// <param name="CTPParentWindow">The `CTPParentWindow` parameter.</param>
  /// <returns>The created custom task pane.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ictpfactory.createctp?view=office-pia
  /// </remarks>
  public CustomTaskPane CreateCTP(string CTPAxID, string CTPTitle, object CTPParentWindow);
}
