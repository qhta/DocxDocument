using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the result of a debug unit test run.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utrunresult?view=office-pia"/>
public interface IMsoDebugOptions_UTRunResult: IInteropObject
{
  /// <summary>
  /// Gets the `Passed` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utrunresult.passed?view=office-pia"/>
  public bool Passed { get; }
  /// <summary>
  /// Gets the `ErrorString` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utrunresult.errorstring?view=office-pia"/>
  public string ErrorString { get; }
}

