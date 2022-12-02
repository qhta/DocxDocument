namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MinorGridlinesGridlines Class.
/// </summary>
public interface IMinorGridlinesGridlines // : DocumentModel.Drawing.IOpenXmlGridlinesElement
{
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
