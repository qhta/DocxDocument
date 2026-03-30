
namespace DocumentModel.Application;

/// <summary>
/// Represents debug options for Office.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions?view=office-pia"/>
public partial interface IMsoDebugOptions: IModelObject
{
  /// <summary>
  /// Gets or sets the `FeatureReports` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.featurereports?view=office-pia"/>
  public int FeatureReports { get; set; }
  /// <summary>
  /// Gets or sets the `OutputToDebugger` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.outputtodebugger?view=office-pia"/>
  public bool OutputToDebugger { get; set; }
  /// <summary>
  /// Gets or sets the `OutputToFile` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.outputtofile?view=office-pia"/>
  public bool OutputToFile { get; set; }
  /// <summary>
  /// Gets or sets the `OutputToMessageBox` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.outputtomessagebox?view=office-pia"/>
  public bool OutputToMessageBox { get; set; }
  /// <summary>
  /// Gets the `UnitTestManager` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.unittestmanager?view=office-pia"/>
  public object UnitTestManager { get; }
}

