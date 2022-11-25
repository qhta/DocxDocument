namespace DocumentModel.Presentation;

/// <summary>
/// Defines the HeaderFooter Class.
/// </summary>
public interface IHeaderFooter // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Slide Number Placeholder
  /// </summary>
  public System.Boolean? SlideNumber { get ; set; }
  
  /// <summary>
  /// Header Placeholder
  /// </summary>
  public System.Boolean? Header { get ; set; }
  
  /// <summary>
  /// Footer Placeholder
  /// </summary>
  public System.Boolean? Footer { get ; set; }
  
  /// <summary>
  /// Date/Time Placeholder
  /// </summary>
  public System.Boolean? DateTime { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public DocumentModel.Presentation.IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
