namespace DocumentModel.Wordprocessing;

/// <summary>
/// Row-Level Custom XML Element.
/// </summary>
public class CustomXmlRowImpl: DocumentModel.Wordprocessing.CustomXmlElementImpl, CustomXmlRow
{
  public override CustomXmlProperties? CustomXmlProperties
  {
    get;
    set;
  }
  
}
