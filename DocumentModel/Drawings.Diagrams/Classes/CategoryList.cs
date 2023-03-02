namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Category List.
/// </summary>
public record CategoryList
{
  public Collection<Category>? Categories { get; set; }
}