namespace DocumentModel.Drawings;

/// <summary>
/// Color Transform Category List.
/// </summary>
public class ColorTransformCategoriesImpl: ModelElementImpl, ColorTransformCategories
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<ColorTransformCategory>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
