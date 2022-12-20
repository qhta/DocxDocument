namespace DocumentModel.Packaging;

/// <summary>
/// Defines the SingleCellTablePart
/// </summary>
public partial class SingleCellTablePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, SingleCellTablePart
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
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
