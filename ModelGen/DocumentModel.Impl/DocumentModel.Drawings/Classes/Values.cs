namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Values Class.
/// </summary>
public class ValuesImpl: DocumentModel.Drawings.NumberDataSourceTypeImpl, Values
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
