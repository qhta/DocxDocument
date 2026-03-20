using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the result of a debug unit test run.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utrunresult?view=office-pia
/// </remarks>
public partial interface MsoDebugOptions_UTRunResult: InteropObject
{
  /// <summary>
  /// Gets the `Passed` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utrunresult.passed?view=office-pia
  /// </remarks>
  public bool Passed { get; }
  /// <summary>
  /// Gets the `ErrorString` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utrunresult.errorstring?view=office-pia
  /// </remarks>
  public string ErrorString { get; }
}
