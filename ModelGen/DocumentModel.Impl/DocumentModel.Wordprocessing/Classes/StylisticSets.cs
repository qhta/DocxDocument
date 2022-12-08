namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the StylisticSets Class.
/// </summary>
public class StylisticSetsImpl: ModelElementImpl, StylisticSets
{
  public DocumentFormat.OpenXml.Office2010.Word.StylisticSets? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.StylisticSets?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<StyleSet>? StyleSets
  {
    get;
    set;
  }
  
}
