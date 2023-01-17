namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines StylesPart. The StylesPart served as the base class of StylesWithEffectsPart and StyleDefinitionsPart.
/// </summary>
public static class StylesPartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.Wordprocessing.Styles? GetStyles(DocumentFormat.OpenXml.Packaging.StylesPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.Styles rootElement)
      return DocumentModel.OpenXml.Wordprocessing.StylesConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetStyles(DocumentFormat.OpenXml.Packaging.StylesPart openXmlElement, DocumentModel.Wordprocessing.Styles? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.Wordprocessing.StylesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Styles>(value);
       if (rootElement != null)
         openXmlElement.Styles = rootElement;
    }
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStyles(openXmlElement, value?.Styles);
      return openXmlElement;
    }
    return default;
  }
}
