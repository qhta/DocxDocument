namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WorksheetSortMapPart
/// </summary>
public class WorksheetSortMapPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WorksheetSortMapPart
{
  public new DocumentFormat.OpenXml.Packaging.WorksheetSortMapPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WorksheetSortMapPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WorksheetSortMapPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WorksheetSortMapPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
