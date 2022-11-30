namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the DLblsExtension Class.
/// </summary>
public interface IDLblsExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IChartText? ChartText { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IDataLabelFieldTable? DataLabelFieldTable { get ; set; }
  
  public System.Boolean? ShowDataLabelsRange { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.ILayout? Layout { get ; set; }
  
  public System.Boolean? ShowLeaderLines { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.ILeaderLines? LeaderLines { get ; set; }
  
}
