namespace DocumentModel.Drawing;

/// <summary>
/// Line Default.
/// </summary>
public interface ILineDefault // : DocumentModel.Drawing.IDefaultShapeDefinitionType
{
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.IBodyProperties? BodyProperties { get ; set; }
  
  public DocumentModel.Drawing.IListStyle? ListStyle { get ; set; }
  
  public DocumentModel.Drawing.IShapeStyle? ShapeStyle { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
