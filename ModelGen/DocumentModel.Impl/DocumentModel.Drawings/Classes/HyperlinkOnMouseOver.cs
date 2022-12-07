namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkOnMouseOver Class.
/// </summary>
public class HyperlinkOnMouseOverImpl: DocumentModel.Drawings.HyperlinkTypeImpl, HyperlinkOnMouseOver
{
  public override HyperlinkExtensionList? HyperlinkExtensionList
  {
    get;
    set;
  }
  
}
