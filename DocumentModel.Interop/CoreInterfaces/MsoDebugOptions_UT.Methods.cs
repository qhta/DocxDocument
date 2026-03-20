using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `MsoDebugOptions_UT` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_ut?view=office-pia` for Office interop details.
/// </remarks>
public partial interface MsoDebugOptions_UT
{
  /// <summary>
  /// Invokes `Run`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_ut.run?view=office-pia
  /// </remarks>
  public MsoDebugOptions_UTRunResult Run();
}
