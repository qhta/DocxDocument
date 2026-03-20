
namespace DocumentModel.Interop.Core;

/// <summary>
/// Defines how the Ribbon UI communicates with a COM add-in to customize the UI.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonextensibility?view=office-pia
/// </remarks>
public partial interface IRibbonExtensibility
{
  /// <summary>
  /// Loads the XML markup that customizes the Ribbon UI.
  /// </summary>
  /// <param name="RibbonID">The `RibbonID` parameter.</param>
  /// <returns>The custom Ribbon UI XML markup.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonextensibility.getcustomui?view=office-pia
  /// </remarks>
  public string GetCustomUI(string RibbonID);
}
