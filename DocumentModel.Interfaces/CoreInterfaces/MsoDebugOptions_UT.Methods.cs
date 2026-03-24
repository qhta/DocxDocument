using System.Reflection;

namespace DocumentModel.Interfaces;

/// <summary>
/// Represents a debug unit test.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_ut?view=office-pia"/>
public partial interface MsoDebugOptions_UT
{
  /// <summary>
  /// Runs the unit test.
  /// </summary>
  /// <returns>The unit test run result.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_ut.run?view=office-pia"/>
  public MsoDebugOptions_UTRunResult Run();
}

