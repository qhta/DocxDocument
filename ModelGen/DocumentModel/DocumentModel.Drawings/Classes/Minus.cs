namespace DocumentModel.Drawings;

/// <summary>
/// Minus.
/// </summary>
public class Minus: DocumentModel.Drawings.NumberDataSourceType
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
