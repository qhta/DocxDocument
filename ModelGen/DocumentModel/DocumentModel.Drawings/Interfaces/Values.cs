namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Values Class.
/// </summary>
public interface Values // : DocumentModel.Drawings.NumberDataSourceType
{
  public NumberReference? NumberReference { get ; set; }
  
  public NumberLiteral? NumberLiteral { get ; set; }
  
}
