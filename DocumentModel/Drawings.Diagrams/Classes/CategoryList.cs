namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Category List.
/// </summary>
public class CategoryList: ModelElement
{
  public Collection<Category>? Categories { get; set; }
}