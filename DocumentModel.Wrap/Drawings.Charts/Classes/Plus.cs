namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Plus.
/// </summary>
public class Plus: ModelElement
{
  public NumberReference? NumberReference { get; set; }

  public NumberLiteral? NumberLiteral { get; set; }
}