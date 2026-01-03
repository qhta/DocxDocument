namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Color Transform Category List.
/// </summary>
public interface ColorTransformCategories: IModelElement
{
  public Collection<ColorTransformCategory>? Items { get; set; }
}