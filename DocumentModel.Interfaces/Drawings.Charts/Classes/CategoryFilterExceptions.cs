namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the CategoryFilterExceptions Class.
/// </summary>
public interface CategoryFilterExceptions: IModelElement
{
  public CategoryFilterException? CategoryFilterException { get; set; }
}