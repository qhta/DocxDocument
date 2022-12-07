namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkOnClick Class.
/// </summary>
public class HyperlinkOnClickImpl: DocumentModel.Drawings.HyperlinkTypeImpl, HyperlinkOnClick
{
  public override HyperlinkExtensionList? HyperlinkExtensionList
  {
    get;
    set;
  }
  
}
