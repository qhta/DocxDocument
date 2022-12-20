namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PivotTableCacheDefinitionPart
/// </summary>
public partial class PivotTableCacheDefinitionPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, PivotTableCacheDefinitionPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.PivotTableCacheDefinitionPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.PivotTableCacheDefinitionPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public PivotTableCacheDefinitionPartImpl(): base() {}
  
  public PivotTableCacheDefinitionPartImpl(DocumentFormat.OpenXml.Packaging.PivotTableCacheDefinitionPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the PivotTableCacheRecordsPart of the PivotTableCacheDefinitionPart
  /// </summary>
  public DocumentModel.Packaging.PivotTableCacheRecordsPart? PivotTableCacheRecordsPart
  {
    get
    {
      if (OpenXmlElement?.PivotTableCacheRecordsPart != null)
        return new DocumentModel.Packaging.PivotTableCacheRecordsPartImpl(OpenXmlElement.PivotTableCacheRecordsPart);
      return null;
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
