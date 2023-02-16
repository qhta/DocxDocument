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
      return DMXW.StylesConverter.CreateModelElement(openXmlElement?.RootElement as DXW.Styles);
  }
  
  private static bool CmpStyles(DXPack.StylesPart openXmlElement, DMW.Styles? value, DiffList? diffs, string? objName)
  {
      return true;
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
  
  public static DocumentModel.Packaging.StylesPart? CreateModelElement(DXPack.StylesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.StylesPart();
      value.Styles = GetStyles(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.StylesPart? openXmlElement, DMPack.StylesPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStyles(openXmlElement, value.Styles, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
