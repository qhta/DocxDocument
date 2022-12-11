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
  
  public PivotTableCacheDefinitionPartImpl(): base() {}
  
  public PivotTableCacheDefinitionPartImpl(DocumentFormat.OpenXml.Packaging.PivotTableCacheDefinitionPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.PivotTableCacheDefinitionPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.PivotTableCacheDefinitionPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
