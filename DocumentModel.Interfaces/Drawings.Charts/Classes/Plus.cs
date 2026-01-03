namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Plus.
/// </summary>
public interface Plus: IModelElement
{
  public NumberReference? NumberReference { get; set; }
  public NumberLiteral? NumberLiteral { get; set; }
}