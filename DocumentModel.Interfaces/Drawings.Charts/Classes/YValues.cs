namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the YValues Class.
/// </summary>
public interface YValues: IModelElement
{
  public NumberReference? NumberReference { get; set; }
  public NumberLiteral? NumberLiteral { get; set; }
}