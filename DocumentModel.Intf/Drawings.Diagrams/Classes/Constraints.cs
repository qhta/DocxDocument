namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Constraint List.
/// </summary>
public class Constraints: ModelElement
{
  public Collection<Constraint>? Items { get; set; }
}