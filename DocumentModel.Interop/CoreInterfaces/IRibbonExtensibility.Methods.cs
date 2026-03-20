
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IRibbonExtensibility` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonextensibility?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IRibbonExtensibility
{
  /// <summary>
  /// Invokes `GetCustomUI`.
  /// </summary>
  /// <param name="RibbonID">The `RibbonID` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonextensibility.getcustomui?view=office-pia
  /// </remarks>
  public string GetCustomUI(string RibbonID);
}
