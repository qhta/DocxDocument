namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DLblsExtension Class.
/// </summary>
public interface IDLblsExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IChartText? ChartText { get ; set; }
  
  public IDataLabelFieldTable? DataLabelFieldTable { get ; set; }
  
  public Boolean? ShowDataLabelsRange { get ; set; }
  
  public IShapeProperties? ShapeProperties { get ; set; }
  
  public ILayout? Layout { get ; set; }
  
  public Boolean? ShowLeaderLines { get ; set; }
  
  public ILeaderLines? LeaderLines { get ; set; }
  
}
