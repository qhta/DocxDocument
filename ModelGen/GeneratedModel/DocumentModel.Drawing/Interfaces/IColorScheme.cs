namespace DocumentModel.Drawing;

public interface IColorScheme // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Name { get ; set; }
  
  public IDark1Color? Dark1Color { get ; set; }
  
  public ILight1Color? Light1Color { get ; set; }
  
  public IDark2Color? Dark2Color { get ; set; }
  
  public ILight2Color? Light2Color { get ; set; }
  
  public IAccent1Color? Accent1Color { get ; set; }
  
  public IAccent2Color? Accent2Color { get ; set; }
  
  public IAccent3Color? Accent3Color { get ; set; }
  
  public IAccent4Color? Accent4Color { get ; set; }
  
  public IAccent5Color? Accent5Color { get ; set; }
  
  public IAccent6Color? Accent6Color { get ; set; }
  
  public DocumentModel.Drawing.IHyperlink? Hyperlink { get ; set; }
  
  public IFollowedHyperlinkColor? FollowedHyperlinkColor { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
