namespace DocumentModel.Drawings;

/// <summary>
/// Category List.
/// </summary>
public interface CategoryList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Category>? Categories { get ; set; }
  
}
