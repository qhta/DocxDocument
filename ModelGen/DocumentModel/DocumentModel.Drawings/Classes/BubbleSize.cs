namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BubbleSize Class.
/// </summary>
public class BubbleSize: DocumentModel.Drawings.NumberDataSourceType
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
