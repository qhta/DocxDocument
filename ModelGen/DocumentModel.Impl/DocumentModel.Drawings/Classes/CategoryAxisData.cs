namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CategoryAxisData Class.
/// </summary>
public class CategoryAxisDataImpl: DocumentModel.Drawings.AxisDataSourceType1Impl, CategoryAxisData
{
  public new DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override MultiLevelStringReference? MultiLevelStringReference
  {
    get;
    set;
  }
  
  public override NumberReference? NumberReference
  {
    get;
    set;
  }
  
  public override NumberLiteral? NumberLiteral
  {
    get;
    set;
  }
  
  public override StringReference? StringReference
  {
    get;
    set;
  }
  
  public override StringLiteral? StringLiteral
  {
    get;
    set;
  }
  
}
