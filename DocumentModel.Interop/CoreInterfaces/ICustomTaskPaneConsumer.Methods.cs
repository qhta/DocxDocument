
namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides access to creating custom task panes.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomtaskpaneconsumer?view=office-pia
/// </remarks>
public partial interface ICustomTaskPaneConsumer
{
  /// <summary>
  /// Passes an `ICTPFactory` object that can be used to create a custom task pane.
  /// </summary>
  /// <param name="CTPFactoryInst">The `CTPFactoryInst` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomtaskpaneconsumer.ctpfactoryavailable?view=office-pia
  /// </remarks>
  public void CTPFactoryAvailable(ICTPFactory CTPFactoryInst);
}
