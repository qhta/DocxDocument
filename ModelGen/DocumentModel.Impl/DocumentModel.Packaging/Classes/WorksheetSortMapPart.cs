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
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
