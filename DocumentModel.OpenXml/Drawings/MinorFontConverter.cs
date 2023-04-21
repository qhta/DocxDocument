namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Minor fonts.
/// </summary>
public static class MinorFontConverter
{
  private static DMD.TextFontType? GetLatinFont(DXD.MinorFont openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.LatinFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLatinFont(DXD.MinorFont openXmlElement, DMD.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.LatinFont>(), value, diffs, objName);
  }
  
  private static void SetLatinFont(DXD.MinorFont openXmlElement, DMD.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.LatinFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.TextFontTypeConverter.CreateOpenXmlElement<DXD.LatinFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.TextFontType? GetEastAsianFont(DXD.MinorFont openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EastAsianFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEastAsianFont(DXD.MinorFont openXmlElement, DMD.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EastAsianFont>(), value, diffs, objName);
  }
  
  private static void SetEastAsianFont(DXD.MinorFont openXmlElement, DMD.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EastAsianFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.TextFontTypeConverter.CreateOpenXmlElement<DXD.EastAsianFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.TextFontType? GetComplexScriptFont(DXD.MinorFont openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ComplexScriptFont>();
    if (element != null)
      return DMXD.TextFontTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpComplexScriptFont(DXD.MinorFont openXmlElement, DMD.TextFontType? value, DiffList? diffs, string? objName)
  {
    return DMXD.TextFontTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ComplexScriptFont>(), value, diffs, objName);
  }
  
  private static void SetComplexScriptFont(DXD.MinorFont openXmlElement, DMD.TextFontType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ComplexScriptFont>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.TextFontTypeConverter.CreateOpenXmlElement<DXD.ComplexScriptFont>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMD.SupplementalFont>? GetSupplementalFonts(DXD.MinorFont openXmlElement)
  {
    var collection = new Collection<DMD.SupplementalFont>();
    foreach (var item in openXmlElement.Elements<DXD.SupplementalFont>())
    {
      var newItem = DMXD.SupplementalFontConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpSupplementalFonts(DXD.MinorFont openXmlElement, Collection<DMD.SupplementalFont>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXD.SupplementalFont>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
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
        if (!DMXD.SupplementalFontConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetSupplementalFonts(DXD.MinorFont openXmlElement, Collection<DMD.SupplementalFont>? value)
  {
    openXmlElement.RemoveAllChildren<DXD.SupplementalFont>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXD.SupplementalFontConverter.CreateOpenXmlElement<DXD.SupplementalFont>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMD.ExtensionList? GetExtensionList(DXD.MinorFont openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.MinorFont openXmlElement, DMD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXD.MinorFont openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.MinorFont? CreateModelElement(DXD.MinorFont? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.MinorFont();
      value.LatinFont = GetLatinFont(openXmlElement);
      value.EastAsianFont = GetEastAsianFont(openXmlElement);
      value.ComplexScriptFont = GetComplexScriptFont(openXmlElement);
      value.SupplementalFonts = GetSupplementalFonts(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.MinorFont? openXmlElement, DMD.MinorFont? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.MinorFont value)
    where OpenXmlElementType: DXD.MinorFont, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.MinorFont openXmlElement, DMD.MinorFont value)
  {
    SetLatinFont(openXmlElement, value?.LatinFont);
    SetEastAsianFont(openXmlElement, value?.EastAsianFont);
    SetComplexScriptFont(openXmlElement, value?.ComplexScriptFont);
    SetSupplementalFonts(openXmlElement, value?.SupplementalFonts);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
