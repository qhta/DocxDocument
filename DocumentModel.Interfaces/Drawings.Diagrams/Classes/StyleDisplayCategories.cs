namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Category List.
/// </summary>
public interface StyleDisplayCategories: IModelElement
{
  public Collection<StyleDisplayCategory>? Items { get; set; }
}