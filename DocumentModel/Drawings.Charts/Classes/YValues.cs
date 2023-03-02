namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the YValues Class.
/// </summary>
public record YValues
{
  public NumberReference? NumberReference { get; set; }

  public NumberLiteral? NumberLiteral { get; set; }
}