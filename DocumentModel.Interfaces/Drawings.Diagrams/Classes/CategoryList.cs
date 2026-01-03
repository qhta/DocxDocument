namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Category List.
/// </summary>
public interface CategoryList: IModelElement
{
  public Collection<Category>? Categories { get; set; }
}