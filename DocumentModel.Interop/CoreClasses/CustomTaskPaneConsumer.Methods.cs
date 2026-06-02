
namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides access to creating custom task panes.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomtaskpaneconsumer?view=office-pia"/>
public partial class CustomTaskPaneConsumer
{
  /// <summary>
  /// Passes an `ICTPFactory` object that can be used to create a custom task pane.
  /// </summary>
  /// <param name="CTPFactoryInst">The `CTPFactoryInst` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomtaskpaneconsumer.ctpfactoryavailable?view=office-pia"/>
  public void CTPFactoryAvailable(ICTPFactory CTPFactoryInst) { throw new NotImplementedException(); }
}


