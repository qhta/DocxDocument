namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Major Font.
/// </summary>
public static class MajorFontConverter
{
  private static DMDraws.TextFontType? GetLatinFont(DXDraw.MajorFont openXmlElement)
  {
    return DMXDraws.TextFontTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.LatinFont>());
  }
  
  private static bool CmpLatinFont(DXDraw.MajorFont openXmlElement, DMDraws.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.LatinFont>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.TextFontTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.EastAsianFont>());
  }
  
  private static bool CmpEastAsianFont(DXDraw.MajorFont openXmlElement, DMDraws.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EastAsianFont>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.TextFontTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ComplexScriptFont>());
  }
  
  private static bool CmpComplexScriptFont(DXDraw.MajorFont openXmlElement, DMDraws.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ComplexScriptFont>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpSupplementalFonts(DXDraw.MajorFont openXmlElement, Collection<DMDraws.SupplementalFont>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDraw.SupplementalFont>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDraws.SupplementalFontConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDraw.MajorFont openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDraw.MajorFont? openXmlElement, DMDraws.MajorFont? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLatinFont(openXmlElement, value.LatinFont, diffs, objName))
        ok = false;
      if (!CmpEastAsianFont(openXmlElement, value.EastAsianFont, diffs, objName))
        ok = false;
      if (!CmpComplexScriptFont(openXmlElement, value.ComplexScriptFont, diffs, objName))
        ok = false;
      if (!CmpSupplementalFonts(openXmlElement, value.SupplementalFonts, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
