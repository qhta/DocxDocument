namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Drawing Object Non-Visual Properties.
/// </summary>
public class DocPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.DocProperties>, DocProperties
{
  /// <summary>
  /// Hyperlink associated with clicking or selecting the element..
  /// </summary>
  public DocumentModel.Drawings.HyperlinkOnClick? HyperlinkOnClick
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hyperlink associated with hovering over the element..
  /// </summary>
  public DocumentModel.Drawings.HyperlinkOnHover? HyperlinkOnHover
  {
    get;
    set;
  }
  
  /// <summary>
  /// Future extension.
  /// </summary>
  public DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList
  {
    get;
    set;
  }
  
}
