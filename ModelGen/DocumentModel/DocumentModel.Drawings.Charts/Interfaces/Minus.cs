namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Minus.
/// </summary>
public partial interface Minus
{
  public DocumentModel.Drawings.Charts.NumberReference? NumberReference { get; set; }
  
  public DocumentModel.Drawings.Charts.NumberLiteral? NumberLiteral { get; set; }
  
}
