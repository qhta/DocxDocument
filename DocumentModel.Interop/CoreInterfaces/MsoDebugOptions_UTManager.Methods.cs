using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `MsoDebugOptions_UTManager` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager?view=office-pia` for Office interop details.
/// </remarks>
public partial interface MsoDebugOptions_UTManager
{
  /// <summary>
  /// Invokes `NotifyStartOfTestSuiteRun`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager.notifystartoftestsuiterun?view=office-pia
  /// </remarks>
  public void NotifyStartOfTestSuiteRun();
  /// <summary>
  /// Invokes `NotifyEndOfTestSuiteRun`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager.notifyendoftestsuiterun?view=office-pia
  /// </remarks>
  public void NotifyEndOfTestSuiteRun();
}
