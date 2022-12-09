namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PivotTableCacheDefinitionPart
/// </summary>
public class PivotTableCacheDefinitionPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, PivotTableCacheDefinitionPart
{
  public new DocumentFormat.OpenXml.Packaging.PivotTableCacheDefinitionPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.PivotTableCacheDefinitionPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.PivotTableCacheDefinitionPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.PivotTableCacheDefinitionPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
