using DocumentFormat.OpenXml.Packaging;
using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines StylesPart. The StylesPart served as the base class of StylesWithEffectsPart and StyleDefinitionsPart.
/// </summary>
public static class StylesPartConverter
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static Styles? GetStyles(StylesPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.Styles rootElement)
      return StylesConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetStyles(StylesPart? openXmlElement, Styles? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = StylesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Styles>(value);
        if (rootElement != null)
          openXmlElement.Styles = rootElement;
      }
  }

  public static DocumentModel.Packaging.StylesPart? CreateModelElement(StylesPart? openXmlElement)
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
    where OpenXmlElementType : StylesPart, new()
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