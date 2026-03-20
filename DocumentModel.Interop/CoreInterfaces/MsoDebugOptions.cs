
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `MsoDebugOptions` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions?view=office-pia` for Office interop details.
/// </remarks>
public partial interface MsoDebugOptions: InteropObject
{
  /// <summary>
  /// Gets or sets the `FeatureReports` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.featurereports?view=office-pia
  /// </remarks>
  public int FeatureReports { get; set; }
  /// <summary>
  /// Gets or sets the `OutputToDebugger` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.outputtodebugger?view=office-pia
  /// </remarks>
  public bool OutputToDebugger { get; set; }
  /// <summary>
  /// Gets or sets the `OutputToFile` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.outputtofile?view=office-pia
  /// </remarks>
  public bool OutputToFile { get; set; }
  /// <summary>
  /// Gets or sets the `OutputToMessageBox` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.outputtomessagebox?view=office-pia
  /// </remarks>
  public bool OutputToMessageBox { get; set; }
  /// <summary>
  /// Gets the `UnitTestManager` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodebugoptions.unittestmanager?view=office-pia
  /// </remarks>
  public object UnitTestManager { get; }
}
