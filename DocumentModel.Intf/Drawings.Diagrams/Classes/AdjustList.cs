namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Shape Adjust List.
/// </summary>
public class AdjustList: ModelElement
{
  public Collection<Adjust>? Adjusts { get; set; }
}