namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MajorGridlinesGridlines Class.
/// </summary>
public interface IMajorGridlinesGridlines // : DocumentModel.Drawing.IOpenXmlGridlinesElement
{
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
