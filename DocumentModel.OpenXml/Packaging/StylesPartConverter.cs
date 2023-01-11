namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines StylesPart. The StylesPart served as the base class of StylesWithEffectsPart and StyleDefinitionsPart.
/// </summary>
public static class StylesPartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Wordprocessing.Styles? GetStyles(DocumentFormat.OpenXml.Packaging.StylesPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetStyles(DocumentFormat.OpenXml.Packaging.StylesPart? openXmlElement, DocumentModel.Wordprocessing.Styles? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static DocumentModel.Packaging.StylesPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.StylesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.StylesPart();
      value.Styles = GetStyles(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.StylesPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.StylesPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
