namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Values Class.
/// </summary>
public class Values: DocumentModel.Drawings.NumberDataSourceType
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
