namespace DocumentModel.Packaging;

/// <summary>
/// Defines the PivotTablePart
/// </summary>
public partial class PivotTablePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, PivotTablePart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.PivotTablePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.PivotTablePart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public PivotTablePartImpl(): base() {}
  
  public PivotTablePartImpl(DocumentFormat.OpenXml.Packaging.PivotTablePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the PivotTableCacheDefinitionPart of the PivotTablePart
  /// </summary>
  public DocumentModel.Packaging.PivotTableCacheDefinitionPart? PivotTableCacheDefinitionPart
  {
    get
    {
      if (OpenXmlElement?.PivotTableCacheDefinitionPart != null)
        return new DocumentModel.Packaging.PivotTableCacheDefinitionPartImpl(OpenXmlElement.PivotTableCacheDefinitionPart);
      return null;
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
