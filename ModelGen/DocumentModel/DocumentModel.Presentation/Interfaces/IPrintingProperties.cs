namespace DocumentModel.Presentation;

/// <summary>
/// Defines the PrintingProperties Class.
/// </summary>
public interface IPrintingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Print Output
  /// </summary>
  public DocumentModel.Presentation.PrintOutputKind? PrintWhat { get ; set; }
  
  /// <summary>
  /// Print Color Mode
  /// </summary>
  public DocumentModel.Presentation.PrintColorMode? ColorMode { get ; set; }
  
  /// <summary>
  /// Print Hidden Slides
  /// </summary>
  public System.Boolean? HiddenSlides { get ; set; }
  
  /// <summary>
  /// Scale to Fit Paper when printing
  /// </summary>
  public System.Boolean? ScaleToFitPaper { get ; set; }
  
  /// <summary>
  /// Frame slides when printing
  /// </summary>
  public System.Boolean? FrameSlides { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
