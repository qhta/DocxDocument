namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Minor fonts.
/// </summary>
public static class MinorFontConverter
{
  private static DMDraws.TextFontType? GetLatinFont(DXDraw.MinorFont openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LatinFont>();
    if (itemElement != null)
      return DMXDraws.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLatinFont(DXDraw.MinorFont openXmlElement, DMDraws.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LatinFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TextFontTypeConverter.CreateOpenXmlElement<DXDraw.LatinFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.TextFontType? GetEastAsianFont(DXDraw.MinorFont openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EastAsianFont>();
    if (itemElement != null)
      return DMXDraws.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEastAsianFont(DXDraw.MinorFont openXmlElement, DMDraws.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EastAsianFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TextFontTypeConverter.CreateOpenXmlElement<DXDraw.EastAsianFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.TextFontType? GetComplexScriptFont(DXDraw.MinorFont openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ComplexScriptFont>();
    if (itemElement != null)
      return DMXDraws.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetComplexScriptFont(DXDraw.MinorFont openXmlElement, DMDraws.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ComplexScriptFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TextFontTypeConverter.CreateOpenXmlElement<DXDraw.ComplexScriptFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDraws.SupplementalFont> GetSupplementalFonts(DXDraw.MinorFont openXmlElement)
  {
    var collection = new Collection<DMDraws.SupplementalFont>();
    foreach (var item in openXmlElement.Elements<DXDraw.SupplementalFont>())
    {
      var newItem = DMXDraws.SupplementalFontConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetSupplementalFonts(DXDraw.MinorFont openXmlElement, Collection<DMDraws.SupplementalFont>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.SupplementalFont>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.SupplementalFontConverter.CreateOpenXmlElement<DXDraw.SupplementalFont>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.MinorFont openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.MinorFont openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.MinorFont? CreateModelElement(DXDraw.MinorFont? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.MinorFont();
      value.LatinFont = GetLatinFont(openXmlElement);
      value.EastAsianFont = GetEastAsianFont(openXmlElement);
      value.ComplexScriptFont = GetComplexScriptFont(openXmlElement);
      value.SupplementalFonts = GetSupplementalFonts(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.MinorFont? value)
    where OpenXmlElementType: DXDraw.MinorFont, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLatinFont(openXmlElement, value?.LatinFont);
      SetEastAsianFont(openXmlElement, value?.EastAsianFont);
      SetComplexScriptFont(openXmlElement, value?.ComplexScriptFont);
      SetSupplementalFonts(openXmlElement, value?.SupplementalFonts);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
