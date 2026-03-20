
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartDocument` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument?view=office-pia
/// </remarks>
public partial interface SmartDocument: InteropObject
{
  /// <summary>
  /// Gets or sets the `SolutionID` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument.solutionid?view=office-pia
  /// </remarks>
  public string SolutionID { get; set; }
  /// <summary>
  /// Gets or sets the `SolutionURL` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartdocument.solutionurl?view=office-pia
  /// </remarks>
  public string SolutionURL { get; set; }
}
