
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ICustomTaskPaneConsumer` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomtaskpaneconsumer?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ICustomTaskPaneConsumer
{
  /// <summary>
  /// Invokes `CTPFactoryAvailable`.
  /// </summary>
  /// <param name="CTPFactoryInst">The `CTPFactoryInst` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomtaskpaneconsumer.ctpfactoryavailable?view=office-pia
  /// </remarks>
  public void CTPFactoryAvailable(ICTPFactory CTPFactoryInst);
}
