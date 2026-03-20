using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a debug unit test.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_ut?view=office-pia
/// </remarks>
public partial interface MsoDebugOptions_UT
{
  /// <summary>
  /// Runs the unit test.
  /// </summary>
  /// <returns>The unit test run result.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_ut.run?view=office-pia
  /// </remarks>
  public MsoDebugOptions_UTRunResult Run();
}
