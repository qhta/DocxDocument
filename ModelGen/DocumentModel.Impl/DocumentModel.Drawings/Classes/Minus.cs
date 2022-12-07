namespace DocumentModel.Drawings;

/// <summary>
/// Minus.
/// </summary>
public class MinusImpl: DocumentModel.Drawings.NumberDataSourceTypeImpl, Minus
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
