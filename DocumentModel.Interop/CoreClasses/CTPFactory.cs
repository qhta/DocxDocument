
namespace DocumentModel.Interop.Core;

/// <summary>
/// Used to create a custom task pane.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ictpfactory?view=office-pia"/>
public partial class CTPFactory
{


  #region methods

/// <summary>
  /// Creates an instance of a custom task pane.
  /// </summary>
  /// <param name="cTPAxID">The `CTPAxID` parameter.</param>
  /// <param name="cTPTitle">The `CTPTitle` parameter.</param>
  /// <param name="cTPParentWindow">The `CTPParentWindow` parameter.</param>
  /// <returns>The created custom task pane.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ictpfactory.createctp?view=office-pia"/>
  public CustomTaskPane CreateCTP(string cTPAxID, string cTPTitle, object cTPParentWindow) { throw new NotImplementedException(); }

  #endregion methods
}


