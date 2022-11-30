namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the DLblExtension Class.
/// </summary>
public interface IDLblExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IDataLabelFieldTable? DataLabelFieldTable { get ; set; }
  
  public System.Boolean? ExceptionForSave { get ; set; }
  
  public System.Boolean? ShowDataLabelsRange { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.ILayout? Layout { get ; set; }
  
}
