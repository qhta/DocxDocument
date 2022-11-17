namespace DocumentModel.Drawing;

public interface IFontScheme // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Name { get ; set; }
  
  public IMajorFont? MajorFont { get ; set; }
  
  public IMinorFont? MinorFont { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
