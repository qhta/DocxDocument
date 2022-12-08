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
