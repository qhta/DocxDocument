namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HyperlinkExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.HyperLinkColor.IHyperlinkColor))]
public interface IHyperlinkExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
