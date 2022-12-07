namespace DocumentModel.Drawings;

/// <summary>
/// Plus.
/// </summary>
public class PlusImpl: DocumentModel.Drawings.NumberDataSourceTypeImpl, Plus
{
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
  
}
