namespace DocumentModel.Drawings;

/// <summary>
/// Category List.
/// </summary>
public class CategoryListImpl: ModelElementImpl, CategoryList
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Category>? Categories
  {
    get;
    set;
  }
  
}
