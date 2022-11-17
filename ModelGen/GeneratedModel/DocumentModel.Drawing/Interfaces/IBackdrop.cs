namespace DocumentModel.Drawing;

public interface IBackdrop // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.IAnchor? Anchor { get ; set; }
  
  public INormal? Normal { get ; set; }
  
  public IUpVector? UpVector { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
