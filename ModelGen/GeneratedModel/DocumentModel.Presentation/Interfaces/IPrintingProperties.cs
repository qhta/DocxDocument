namespace DocumentModel.Presentation;

public interface IPrintingProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public PrintOutput? PrintWhat { get ; set; }
  
  public PrintColorMode? ColorMode { get ; set; }
  
  public bool? HiddenSlides { get ; set; }
  
  public bool? ScaleToFitPaper { get ; set; }
  
  public bool? FrameSlides { get ; set; }
  
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
