namespace DocumentModel.Packaging;

/// <summary>
/// Defines the LegacyDiagramTextPart
/// </summary>
public class LegacyDiagramTextPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, LegacyDiagramTextPart
{
  public new DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.LegacyDiagramTextPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
