namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Plus.
/// </summary>
public partial interface Plus
{
  public DocumentModel.Drawings.Charts.NumberReference? NumberReference { get; set; }
  
  public DocumentModel.Drawings.Charts.NumberLiteral? NumberLiteral { get; set; }
  
}
