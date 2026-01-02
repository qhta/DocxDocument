namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Constraint List.
/// </summary>
public class Constraints: ModelElement
{
  public Collection<Constraint>? Items { get; set; }
}