namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TxPrTextBody Class.
/// </summary>
public class TxPrTextBody: DocumentModel.Drawings.TextBodyType2
{
  public override BodyProperties? BodyProperties
  {
    get;
    set;
  }
  
  public override ListStyle? ListStyle
  {
    get;
    set;
  }
  
}
