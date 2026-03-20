using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Manages debug unit tests.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager?view=office-pia
/// </remarks>
public partial interface MsoDebugOptions_UTManager: InteropObject
{
  /// <summary>
  /// Gets or sets the `UnitTests` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager.unittests?view=office-pia
  /// </remarks>
  public MsoDebugOptions_UTs UnitTests { get; }
  /// <summary>
  /// Gets or sets the `ReportErrors` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager.reporterrors?view=office-pia
  /// </remarks>
  public bool ReportErrors { get; set; }
}
