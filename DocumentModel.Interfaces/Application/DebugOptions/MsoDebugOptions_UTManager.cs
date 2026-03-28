using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Manages debug unit tests.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager?view=office-pia"/>
public partial interface MsoDebugOptions_UTManager: InteropObject
{
  /// <summary>
  /// Gets or sets the `UnitTests` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager.unittests?view=office-pia"/>
  public MsoDebugOptions_UTs UnitTests { get; }
  /// <summary>
  /// Gets or sets the `ReportErrors` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager.reporterrors?view=office-pia"/>
  public bool ReportErrors { get; set; }
}

