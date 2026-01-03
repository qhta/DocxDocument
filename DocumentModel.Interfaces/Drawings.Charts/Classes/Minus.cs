namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Minus.
/// </summary>
public interface Minus: IModelElement
{
  public NumberReference? NumberReference { get; set; }
  public NumberLiteral? NumberLiteral { get; set; }
}