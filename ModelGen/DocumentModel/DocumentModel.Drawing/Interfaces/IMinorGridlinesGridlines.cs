namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MinorGridlinesGridlines Class.
/// </summary>
public interface IMinorGridlinesGridlines // : DocumentModel.Drawing.IOpenXmlGridlinesElement
{
  public IShapeProperties? ShapeProperties { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
