namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DLblExtension Class.
/// </summary>
public interface IDLblExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IDataLabelFieldTable? DataLabelFieldTable { get ; set; }
  
  public Boolean? ExceptionForSave { get ; set; }
  
  public Boolean? ShowDataLabelsRange { get ; set; }
  
  public IShapeProperties? ShapeProperties { get ; set; }
  
  public ILayout? Layout { get ; set; }
  
}
