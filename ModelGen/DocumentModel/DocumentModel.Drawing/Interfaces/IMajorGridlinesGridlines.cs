namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MajorGridlinesGridlines Class.
/// </summary>
public interface IMajorGridlinesGridlines // : DocumentModel.Drawing.IOpenXmlGridlinesElement
{
  public IShapeProperties? ShapeProperties { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
