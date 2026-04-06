
namespace DocumentModel.Application;

/// <summary>
/// Represents the `SmartDocument` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument?view=office-pia"/>
public partial interface ISmartDocument: IModelObject
{
  /// <summary>
  /// Invokes `PickSolution`.
  /// </summary>
  /// <param name="ConsiderAllSchemas">The `ConsiderAllSchemas` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument.picksolution?view=office-pia"/>
  public void PickSolution(bool ConsiderAllSchemas);
  /// <summary>
  /// Invokes `RefreshPane`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument.refreshpane?view=office-pia"/>
  public void RefreshPane();
}

