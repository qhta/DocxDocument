namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Constraint List.
/// </summary>
public record Constraints
{
  public Collection<Constraint>? Items { get; set; }
}