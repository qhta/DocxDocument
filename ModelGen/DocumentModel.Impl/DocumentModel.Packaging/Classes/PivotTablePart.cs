namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PivotTablePart
/// </summary>
public class PivotTablePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, PivotTablePart
{
  public new DocumentFormat.OpenXml.Packaging.PivotTablePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.PivotTablePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.PivotTablePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.PivotTablePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
