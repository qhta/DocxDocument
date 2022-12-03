namespace DocumentModel.Drawings;

/// <summary>
/// Plus.
/// </summary>
public interface Plus // : DocumentModel.Drawings.NumberDataSourceType
{
  public NumberReference? NumberReference { get ; set; }
  
  public NumberLiteral? NumberLiteral { get ; set; }
  
}
