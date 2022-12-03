namespace DocumentModel.Drawings;

/// <summary>
/// Defines the YValues Class.
/// </summary>
public interface YValues // : DocumentModel.Drawings.NumberDataSourceType
{
  public NumberReference? NumberReference { get ; set; }
  
  public NumberLiteral? NumberLiteral { get ; set; }
  
}
