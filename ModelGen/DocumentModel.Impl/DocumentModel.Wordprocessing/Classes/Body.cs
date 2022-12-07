namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Body Class.
/// </summary>
public class BodyImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.Body>, Body
{
  public SectionProperties? SectionProperties
  {
    get;
    set;
  }
  
}
