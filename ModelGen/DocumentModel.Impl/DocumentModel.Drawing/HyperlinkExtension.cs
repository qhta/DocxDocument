namespace DocumentModel.Drawing;

/// <summary>
/// Defines the HyperlinkExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2019.Drawing.HyperLinkColor.IHyperlinkColor))]
public class HyperlinkExtension: IHyperlinkExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
