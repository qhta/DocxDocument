namespace DocumentModel.Presentation;

/// <summary>
/// Defines the HeaderFooter Class.
/// </summary>
public interface IHeaderFooter // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Slide Number Placeholder
  /// </summary>
  public Boolean? SlideNumber { get ; set; }
  
  /// <summary>
  /// Header Placeholder
  /// </summary>
  public Boolean? Header { get ; set; }
  
  /// <summary>
  /// Footer Placeholder
  /// </summary>
  public Boolean? Footer { get ; set; }
  
  /// <summary>
  /// Date/Time Placeholder
  /// </summary>
  public Boolean? DateTime { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
