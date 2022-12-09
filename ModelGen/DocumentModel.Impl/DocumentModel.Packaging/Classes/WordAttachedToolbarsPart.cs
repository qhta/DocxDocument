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
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordAttachedToolbarsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordAttachedToolbarsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
