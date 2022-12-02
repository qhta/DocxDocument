namespace DocumentModel.Drawing;

/// <summary>
/// Line Default.
/// </summary>
public interface ILineDefault // : DocumentModel.Drawing.IDefaultShapeDefinitionType
{
  public IShapeProperties? ShapeProperties { get ; set; }
  
  public IBodyProperties? BodyProperties { get ; set; }
  
  public IListStyle? ListStyle { get ; set; }
  
  public IShapeStyle? ShapeStyle { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
