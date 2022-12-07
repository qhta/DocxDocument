namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CustomXmlRuby Class.
/// </summary>
public class CustomXmlRubyImpl: DocumentModel.Wordprocessing.CustomXmlElementImpl, CustomXmlRuby
{
  public override CustomXmlProperties? CustomXmlProperties
  {
    get;
    set;
  }
  
}
