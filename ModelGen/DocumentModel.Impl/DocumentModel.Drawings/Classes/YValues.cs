namespace DocumentModel.Drawings;

/// <summary>
/// Defines the YValues Class.
/// </summary>
public class YValuesImpl: DocumentModel.Drawings.NumberDataSourceTypeImpl, YValues
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
