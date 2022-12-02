namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public interface IChartData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ExternalData.
  /// </summary>
  public IExternalData? ExternalData { get ; set; }
  
  public Collection<IData>? Datas { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
