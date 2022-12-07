namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkOnHover Class.
/// </summary>
public class HyperlinkOnHoverImpl: DocumentModel.Drawings.HyperlinkTypeImpl, HyperlinkOnHover
{
  public override HyperlinkExtensionList? HyperlinkExtensionList
  {
    get;
    set;
  }
  
}
