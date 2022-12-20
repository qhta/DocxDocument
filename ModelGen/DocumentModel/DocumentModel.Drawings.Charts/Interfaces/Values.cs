namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Values Class.
/// </summary>
public partial interface Values
{
  public DocumentModel.Drawings.Charts.NumberReference? NumberReference { get; set; }
  
  public DocumentModel.Drawings.Charts.NumberLiteral? NumberLiteral { get; set; }
  
}
