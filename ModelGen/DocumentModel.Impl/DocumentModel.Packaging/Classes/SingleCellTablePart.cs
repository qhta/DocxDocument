namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SingleCellTablePart
/// </summary>
public class SingleCellTablePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, SingleCellTablePart
{
  public new DocumentFormat.OpenXml.Packaging.SingleCellTablePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.SingleCellTablePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SingleCellTablePartImpl(): base() {}
  
  public SingleCellTablePartImpl(DocumentFormat.OpenXml.Packaging.SingleCellTablePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.SingleCellTablePart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.SingleCellTablePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
