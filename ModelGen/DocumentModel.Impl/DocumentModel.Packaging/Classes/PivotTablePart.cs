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
