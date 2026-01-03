namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Constraint List.
/// </summary>
public interface Constraints: IModelElement
{
  public Collection<Constraint>? Items { get; set; }
}