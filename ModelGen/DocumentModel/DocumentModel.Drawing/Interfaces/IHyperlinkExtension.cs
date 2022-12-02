namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HyperlinkExtension Class.
/// </summary>
public interface IHyperlinkExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public HyperlinkColorEnum? HyperlinkColor { get ; set; }
  
}
