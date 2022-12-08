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
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
