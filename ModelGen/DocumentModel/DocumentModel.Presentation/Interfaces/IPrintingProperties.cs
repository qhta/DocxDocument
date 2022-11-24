namespace DocumentModel.Presentation;

/// <summary>
/// Defines the PrintingProperties Class.
/// </summary>
public interface IPrintingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public Boolean? HiddenSlides { get ; set; }
  
  /// <summary>
  /// Scale to Fit Paper when printing
  /// </summary>
  public Boolean? ScaleToFitPaper { get ; set; }
  
  /// <summary>
  /// Frame slides when printing
  /// </summary>
  public Boolean? FrameSlides { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
