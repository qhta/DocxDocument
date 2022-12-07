namespace DocumentModel.Drawings;

/// <summary>
/// Defines the XValues Class.
/// </summary>
public class XValuesImpl: DocumentModel.Drawings.AxisDataSourceType1Impl, XValues
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
