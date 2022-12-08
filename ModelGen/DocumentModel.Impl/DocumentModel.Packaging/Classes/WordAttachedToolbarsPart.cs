namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordAttachedToolbarsPart
/// </summary>
public class WordAttachedToolbarsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WordAttachedToolbarsPart
{
  public new DocumentFormat.OpenXml.Packaging.WordAttachedToolbarsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WordAttachedToolbarsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
