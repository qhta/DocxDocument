namespace DocumentModel.Drawings;

/// <summary>
/// Plus.
/// </summary>
public class Plus: DocumentModel.Drawings.NumberDataSourceType
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
