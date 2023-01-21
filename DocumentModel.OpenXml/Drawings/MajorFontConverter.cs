namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Major Font.
/// </summary>
public static class MajorFontConverter
{
  private static DMDraws.TextFontType? GetLatinFont(DXDraw.MajorFont openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LatinFont>();
    if (itemElement != null)
      return DMXDraws.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLatinFont(DXDraw.MajorFont openXmlElement, DMDraws.TextFontType? value)
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
  
  private static DMDraws.TextFontType? GetEastAsianFont(DXDraw.MajorFont openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EastAsianFont>();
    if (itemElement != null)
      return DMXDraws.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEastAsianFont(DXDraw.MajorFont openXmlElement, DMDraws.TextFontType? value)
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
  
  private static DMDraws.TextFontType? GetComplexScriptFont(DXDraw.MajorFont openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ComplexScriptFont>();
    if (itemElement != null)
      return DMXDraws.TextFontTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetComplexScriptFont(DXDraw.MajorFont openXmlElement, DMDraws.TextFontType? value)
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
  
  private static Collection<DMDraws.SupplementalFont> GetSupplementalFonts(DXDraw.MajorFont openXmlElement)
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
  
  private static void SetSupplementalFonts(DXDraw.MajorFont openXmlElement, Collection<DMDraws.SupplementalFont>? value)
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
  
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.MajorFont openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDraw.MajorFont openXmlElement, DMDraws.ExtensionList? value)
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
  
  public static DMDraws.MajorFont? CreateModelElement(DXDraw.MajorFont? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.MajorFont();
      value.LatinFont = GetLatinFont(openXmlElement);
      value.EastAsianFont = GetEastAsianFont(openXmlElement);
      value.ComplexScriptFont = GetComplexScriptFont(openXmlElement);
      value.SupplementalFonts = GetSupplementalFonts(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.MajorFont? value)
    where OpenXmlElementType: DXDraw.MajorFont, new()
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
