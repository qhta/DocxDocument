
namespace DocumentModel.Interfaces;

/// <summary>
/// Provides access to creating custom task panes.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomtaskpaneconsumer?view=office-pia"/>
public partial interface ICustomTaskPaneConsumer
{
  /// <summary>
  /// Passes an `ICTPFactory` object that can be used to create a custom task pane.
  /// </summary>
  /// <param name="CTPFactoryInst">The `CTPFactoryInst` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomtaskpaneconsumer.ctpfactoryavailable?view=office-pia"/>
  public void CTPFactoryAvailable(ICTPFactory CTPFactoryInst);
}

