namespace DocumentModel.Drawings;

/// <summary>
/// Category List.
/// </summary>
public class StyleDisplayCategoriesImpl: ModelElementImpl, StyleDisplayCategories
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StyleDisplayCategoriesImpl(): base() {}
  
  public StyleDisplayCategoriesImpl(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<StyleDisplayCategory>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
