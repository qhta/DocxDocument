namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the CategoryAxisData Class.
/// </summary>
public record CategoryAxisData
{
  public MultiLevelStringReference? MultiLevelStringReference { get; set; }

  public NumberReference? NumberReference { get; set; }

  public NumberLiteral? NumberLiteral { get; set; }

  public StringReference? StringReference { get; set; }

  public StringLiteral? StringLiteral { get; set; }
}