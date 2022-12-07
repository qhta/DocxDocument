namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CategoryAxisData Class.
/// </summary>
public class CategoryAxisDataImpl: DocumentModel.Drawings.AxisDataSourceType1Impl, CategoryAxisData
{
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
