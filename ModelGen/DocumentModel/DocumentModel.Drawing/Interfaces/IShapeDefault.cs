namespace DocumentModel.Drawing;

/// <summary>
/// Shape Default.
/// </summary>
public interface IShapeDefault // : DocumentModel.Drawing.IDefaultShapeDefinitionType
{
  public IShapeProperties? ShapeProperties { get ; set; }
  
  public IBodyProperties? BodyProperties { get ; set; }
  
  public IListStyle? ListStyle { get ; set; }
  
  public IShapeStyle? ShapeStyle { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
