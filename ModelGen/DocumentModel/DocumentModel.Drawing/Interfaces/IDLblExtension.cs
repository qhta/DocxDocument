namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DLblExtension Class.
/// </summary>
public interface IDLblExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IDataLabelFieldTable? DataLabelFieldTable { get ; set; }
  
  public System.Boolean? ExceptionForSave { get ; set; }
  
  public System.Boolean? ShowDataLabelsRange { get ; set; }
  
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.ILayout? Layout { get ; set; }
  
}
