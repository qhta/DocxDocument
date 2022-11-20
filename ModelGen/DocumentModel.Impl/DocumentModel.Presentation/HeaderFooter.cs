namespace DocumentModel.Presentation;

/// <summary>
/// Defines the HeaderFooter Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionListWithModification))]
public class HeaderFooter: IHeaderFooter
{
  /// <summary>
  /// Slide Number Placeholder
  /// </summary>
  public bool? SlideNumber
  {
    get;
    set;
  }
  
  /// <summary>
  /// Header Placeholder
  /// </summary>
  public bool? Header
  {
    get;
    set;
  }
  
  /// <summary>
  /// Footer Placeholder
  /// </summary>
  public bool? Footer
  {
    get;
    set;
  }
  
  /// <summary>
  /// Date/Time Placeholder
  /// </summary>
  public bool? DateTime
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public IExtensionListWithModification? ExtensionListWithModification
  {
    get;
    set;
  }
  
}
