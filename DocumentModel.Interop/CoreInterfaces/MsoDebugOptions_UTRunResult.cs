using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `MsoDebugOptions_UTRunResult` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utrunresult?view=office-pia` for Office interop details.
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
