namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines StylesPart. The StylesPart served as the base class of StylesWithEffectsPart and StyleDefinitionsPart.
/// </summary>
public static class StylesPartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMW.Styles? GetStyles(DXPack.StylesPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXW.Styles rootElement)
      return DMXW.StylesConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetStyles(DXPack.StylesPart openXmlElement, DMW.Styles? value)
  {
    if (value != null)
    {
       var rootElement = DMXW.StylesConverter.CreateOpenXmlElement<DXW.Styles>(value);
       if (rootElement != null)
         openXmlElement.Styles = rootElement;
    }
  }
  
  public static DMPack.StylesPart? CreateModelElement(DXPack.StylesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.StylesPart();
      value.Styles = GetStyles(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.StylesPart? value)
    where OpenXmlElementType: DXPack.StylesPart, new()
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
