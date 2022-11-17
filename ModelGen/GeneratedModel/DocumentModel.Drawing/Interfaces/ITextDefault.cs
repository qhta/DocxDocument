namespace DocumentModel.Drawing;

public interface ITextDefault // : DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType
{
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  public IBodyProperties? BodyProperties { get ; set; }
  
  public IListStyle? ListStyle { get ; set; }
  
  public DocumentModel.Drawing.IShapeStyle? ShapeStyle { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
