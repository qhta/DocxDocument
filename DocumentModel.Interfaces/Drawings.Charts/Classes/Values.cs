namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the Values Class.
/// </summary>
public interface Values:
{
  public NumberReference? NumberReference { get; set; }
  public NumberLiteral? NumberLiteral { get; set; }
}