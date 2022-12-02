namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public interface IChartData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ExternalData.
  /// </summary>
  public DocumentModel.Drawing.IExternalData? ExternalData { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IData>? Datas { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
