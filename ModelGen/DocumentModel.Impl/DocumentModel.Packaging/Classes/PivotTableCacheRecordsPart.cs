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
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
