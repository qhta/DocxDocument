
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartDocument` class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument?view=office-pia"/>
public partial class SmartDocument: InteropObject
{
  /// <summary>
  /// Gets or sets the `SolutionID` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument.solutionid?view=office-pia"/>
  public string SolutionID { get; set; }
  /// <summary>
  /// Gets or sets the `SolutionURL` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument.solutionurl?view=office-pia"/>
  public string SolutionURL { get; set; }


  #region methods

/// <summary>
  /// Invokes `PickSolution`.
  /// </summary>
  /// <param name="ConsiderAllSchemas">The `ConsiderAllSchemas` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument.picksolution?view=office-pia"/>
  public void PickSolution(bool ConsiderAllSchemas) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `RefreshPane`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument.refreshpane?view=office-pia"/>
  public void RefreshPane() { throw new NotImplementedException(); }

  #endregion methods
}

