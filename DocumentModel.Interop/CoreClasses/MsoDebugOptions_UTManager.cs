using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Manages debug unit tests.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager?view=office-pia"/>
public partial class MsoDebugOptions_UTManager: InteropObject
{
  /// <summary>
  /// Gets or sets the `UnitTests` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager.unittests?view=office-pia"/>
  public MsoDebugOptions_UTs UnitTests { get; }
  /// <summary>
  /// Gets or sets the `ReportErrors` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager.reporterrors?view=office-pia"/>
  public bool ReportErrors { get; set; }


  #region methods

/// <summary>
  /// Notifies the start of a unit test suite run.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager.notifystartoftestsuiterun?view=office-pia"/>
  public void NotifyStartOfTestSuiteRun() { throw new NotImplementedException(); }
  /// <summary>
  /// Notifies the end of a unit test suite run.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions_utmanager.notifyendoftestsuiterun?view=office-pia"/>
  public void NotifyEndOfTestSuiteRun() { throw new NotImplementedException(); }

  #endregion methods
}

