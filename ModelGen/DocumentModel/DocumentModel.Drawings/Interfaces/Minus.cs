namespace DocumentModel.Drawings;

/// <summary>
/// Minus.
/// </summary>
public interface Minus // : DocumentModel.Drawings.NumberDataSourceType
{
  public NumberReference? NumberReference { get ; set; }
  
  public NumberLiteral? NumberLiteral { get ; set; }
  
}
