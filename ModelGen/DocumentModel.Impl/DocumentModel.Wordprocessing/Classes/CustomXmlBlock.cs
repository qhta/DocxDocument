namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CustomXmlBlock Class.
/// </summary>
public class CustomXmlBlockImpl: DocumentModel.Wordprocessing.CustomXmlElementImpl, CustomXmlBlock
{
  public override CustomXmlProperties? CustomXmlProperties
  {
    get;
    set;
  }
  
}
