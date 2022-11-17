namespace DocumentModel.Drawing.Spreadsheet;

public interface INonVisualShapeDrawingProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? TextBox { get ; set; }
  
  public IShapeLocks? ShapeLocks { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
