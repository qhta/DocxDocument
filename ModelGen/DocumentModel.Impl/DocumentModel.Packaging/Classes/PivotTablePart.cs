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
  
  public PivotTablePartImpl(): base() {}
  
  public PivotTablePartImpl(DocumentFormat.OpenXml.Packaging.PivotTablePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.PivotTablePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.PivotTablePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
