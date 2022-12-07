namespace DocumentModel.Wordprocessing;

/// <summary>
/// Cell-Level Custom XML Element.
/// </summary>
public class CustomXmlCellImpl: DocumentModel.Wordprocessing.CustomXmlElementImpl, CustomXmlCell
{
  public override CustomXmlProperties? CustomXmlProperties
  {
    get;
    set;
  }
  
}
