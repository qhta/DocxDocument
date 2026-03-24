using System.Reflection;

namespace DocumentModel.Interfaces;

/// <summary>
/// Manages debug unit tests.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager?view=office-pia"/>
public partial interface MsoDebugOptions_UTManager
{
  /// <summary>
  /// Notifies the start of a unit test suite run.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager.notifystartoftestsuiterun?view=office-pia"/>
  public void NotifyStartOfTestSuiteRun();
  /// <summary>
  /// Notifies the end of a unit test suite run.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager.notifyendoftestsuiterun?view=office-pia"/>
  public void NotifyEndOfTestSuiteRun();
}

