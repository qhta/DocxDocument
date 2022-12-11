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
  
  public CategoryListImpl(): base() {}
  
  public CategoryListImpl(DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Category>? Categories
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
