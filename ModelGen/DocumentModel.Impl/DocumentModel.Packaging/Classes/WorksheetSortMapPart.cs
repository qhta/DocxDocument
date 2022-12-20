namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WorksheetSortMapPart
/// </summary>
public partial class WorksheetSortMapPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, WorksheetSortMapPart
{
  public new DocumentFormat.OpenXml.Packaging.WorksheetSortMapPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WorksheetSortMapPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WorksheetSortMapPartImpl(): base() {}
  
  public WorksheetSortMapPartImpl(DocumentFormat.OpenXml.Packaging.WorksheetSortMapPart openXmlElement): base(openXmlElement)
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
