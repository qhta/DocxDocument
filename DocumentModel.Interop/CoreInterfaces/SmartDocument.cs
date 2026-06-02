
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartDocument` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument?view=office-pia"/>
public partial interface ISmartDocument: IInteropObject
{
  /// <summary>
  /// Gets or sets the `SolutionID` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument.solutionid?view=office-pia"/>
  public string SolutionID { get; set; }
  /// <summary>
  /// Gets or sets the `SolutionURL` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument.solutionurl?view=office-pia"/>
  public string SolutionURL { get; set; }


  #region methods

/// <summary>
  /// Invokes `PickSolution`.
  /// </summary>
  /// <param name="ConsiderAllSchemas">The `ConsiderAllSchemas` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument.picksolution?view=office-pia"/>
  public void PickSolution(bool ConsiderAllSchemas);
  /// <summary>
  /// Invokes `RefreshPane`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument.refreshpane?view=office-pia"/>
  public void RefreshPane();

  #endregion methods
}

