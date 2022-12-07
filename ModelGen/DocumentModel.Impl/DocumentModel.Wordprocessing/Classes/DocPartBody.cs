namespace DocumentModel.Wordprocessing;

/// <summary>
/// Contents of Glossary Document Entry.
/// </summary>
public class DocPartBodyImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.DocPartBody>, DocPartBody
{
  public SectionProperties? SectionProperties
  {
    get;
    set;
  }
  
}
