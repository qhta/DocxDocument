namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Plus.
/// </summary>
public interface Plus:
{
  public NumberReference? NumberReference { get; set; }
  public NumberLiteral? NumberLiteral { get; set; }
}