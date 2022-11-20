namespace DocumentModel.Presentation;

/// <summary>
/// Defines the PrintingProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public interface IPrintingProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Print Output
  /// </summary>
  public PrintOutputValues? PrintWhat { get ; set; }
  
  /// <summary>
  /// Print Color Mode
  /// </summary>
  public PrintColorModeValues? ColorMode { get ; set; }
  
  /// <summary>
  /// Print Hidden Slides
  /// </summary>
  public bool? HiddenSlides { get ; set; }
  
  /// <summary>
  /// Scale to Fit Paper when printing
  /// </summary>
  public bool? ScaleToFitPaper { get ; set; }
  
  /// <summary>
  /// Frame slides when printing
  /// </summary>
  public bool? FrameSlides { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
