namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HyperlinkExtension Class.
/// </summary>
public interface IHyperlinkExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.HyperlinkColorEnum? HyperlinkColor { get ; set; }
  
}
