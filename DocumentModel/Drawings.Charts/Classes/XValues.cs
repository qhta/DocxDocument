namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the XValues Class.
/// </summary>
public class XValues: ModelElement
{
  public MultiLevelStringReference? MultiLevelStringReference { get; set; }

  public NumberReference? NumberReference { get; set; }

  public NumberLiteral? NumberLiteral { get; set; }

  public StringReference? StringReference { get; set; }

  public StringLiteral? StringLiteral { get; set; }
}