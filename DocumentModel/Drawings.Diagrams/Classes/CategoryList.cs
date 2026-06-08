namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   ICategory IList.
/// </summary>
public class CategoryList: ModelElement
{
  public Collection<ICategory>? ICategories { get; set; }
}
