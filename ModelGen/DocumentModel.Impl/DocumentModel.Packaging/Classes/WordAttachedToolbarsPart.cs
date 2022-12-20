namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordAttachedToolbarsPart
/// </summary>
public partial class WordAttachedToolbarsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WordAttachedToolbarsPart
{
  public new DocumentFormat.OpenXml.Packaging.WordAttachedToolbarsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WordAttachedToolbarsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WordAttachedToolbarsPartImpl(): base() {}
  
  public WordAttachedToolbarsPartImpl(DocumentFormat.OpenXml.Packaging.WordAttachedToolbarsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
