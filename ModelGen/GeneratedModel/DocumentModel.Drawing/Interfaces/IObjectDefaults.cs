namespace DocumentModel.Drawing;

public interface IObjectDefaults // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IShapeDefault? ShapeDefault { get ; set; }
  
  public ILineDefault? LineDefault { get ; set; }
  
  public ITextDefault? TextDefault { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
