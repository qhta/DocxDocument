namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the YValues Class.
/// </summary>
public partial interface YValues
{
  public DocumentModel.Drawings.Charts.NumberReference? NumberReference { get; set; }
  
  public DocumentModel.Drawings.Charts.NumberLiteral? NumberLiteral { get; set; }
  
}
