namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BubbleSize Class.
/// </summary>
public class BubbleSizeImpl: DocumentModel.Drawings.NumberDataSourceTypeImpl, BubbleSize
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
