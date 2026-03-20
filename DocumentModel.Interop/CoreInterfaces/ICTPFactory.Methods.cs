
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ICTPFactory` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ictpfactory?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ICTPFactory
{
  /// <summary>
  /// Invokes `CreateCTP`.
  /// </summary>
  /// <param name="CTPAxID">The `CTPAxID` parameter.</param>
  /// <param name="CTPTitle">The `CTPTitle` parameter.</param>
  /// <param name="CTPParentWindow">The `CTPParentWindow` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ictpfactory.createctp?view=office-pia
  /// </remarks>
  public CustomTaskPane CreateCTP(string CTPAxID, string CTPTitle, object CTPParentWindow);
}
