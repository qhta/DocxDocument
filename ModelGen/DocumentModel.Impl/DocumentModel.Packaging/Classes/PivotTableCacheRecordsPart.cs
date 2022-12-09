namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PivotTableCacheRecordsPart
/// </summary>
public class PivotTableCacheRecordsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, PivotTableCacheRecordsPart
{
  public new DocumentFormat.OpenXml.Packaging.PivotTableCacheRecordsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.PivotTableCacheRecordsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.PivotTableCacheRecordsPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public override String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.PivotTableCacheRecordsPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
