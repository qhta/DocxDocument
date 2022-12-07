namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CustomXmlRun Class.
/// </summary>
public class CustomXmlRunImpl: DocumentModel.Wordprocessing.CustomXmlElementImpl, CustomXmlRun
{
  public override CustomXmlProperties? CustomXmlProperties
  {
    get;
    set;
  }
  
}
