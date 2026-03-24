
namespace DocumentModel.Interfaces;

/// <summary>
/// Represents the `SmartDocument` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument?view=office-pia"/>
public partial interface SmartDocument: InteropObject
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
}

