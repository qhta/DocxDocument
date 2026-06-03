
namespace DocumentModel.Interop.Core;

/// <summary>
/// Defines how the Ribbon UI communicates with a COM add-in to customize the UI.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonextensibility?view=office-pia"/>
public partial class RibbonExtensibility
{


  #region methods

/// <summary>
  /// Loads the XML markup that customizes the Ribbon UI.
  /// </summary>
  /// <param name="ribbonID">The `RibbonID` parameter.</param>
  /// <returns>The custom Ribbon UI XML markup.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iribbonextensibility.getcustomui?view=office-pia"/>
  public string GetCustomUI(string ribbonID) { throw new NotImplementedException(); }

  #endregion methods
}


