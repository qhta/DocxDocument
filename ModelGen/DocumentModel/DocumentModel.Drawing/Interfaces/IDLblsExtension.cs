namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DLblsExtension Class.
/// </summary>
public interface IDLblsExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IChartText? ChartText { get ; set; }
  
  public DocumentModel.Drawing.IDataLabelFieldTable? DataLabelFieldTable { get ; set; }
  
  public System.Boolean? ShowDataLabelsRange { get ; set; }
  
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.ILayout? Layout { get ; set; }
  
  public System.Boolean? ShowLeaderLines { get ; set; }
  
  public DocumentModel.Drawing.ILeaderLines? LeaderLines { get ; set; }
  
}
