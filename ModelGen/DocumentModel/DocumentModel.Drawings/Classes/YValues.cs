namespace DocumentModel.Drawings;

/// <summary>
/// Defines the YValues Class.
/// </summary>
public class YValues: DocumentModel.Drawings.NumberDataSourceType
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
