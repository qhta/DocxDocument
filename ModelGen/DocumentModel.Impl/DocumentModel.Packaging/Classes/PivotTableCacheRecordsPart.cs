namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PivotTableCacheRecordsPart
/// </summary>
public partial class PivotTableCacheRecordsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, PivotTableCacheRecordsPart
{
  public new DocumentFormat.OpenXml.Packaging.PivotTableCacheRecordsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.PivotTableCacheRecordsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PivotTableCacheRecordsPartImpl(): base() {}
  
  public PivotTableCacheRecordsPartImpl(DocumentFormat.OpenXml.Packaging.PivotTableCacheRecordsPart openXmlElement): base(openXmlElement)
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
