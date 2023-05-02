namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Values Class.
/// </summary>
public class Values: ModelElement
{
  public NumberReference? NumberReference { get; set; }

  public NumberLiteral? NumberLiteral { get; set; }
}