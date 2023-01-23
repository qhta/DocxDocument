namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Phonetic Guide.
/// </summary>
public static class RubyConverter
{
  /// <summary>
  /// Phonetic Guide Properties.
  /// </summary>
  private static DMW.RubyProperties? GetRubyProperties(DXW.Ruby openXmlElement)
  {
    return DMXW.RubyPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.RubyProperties>());
  }
  
  private static bool CmpRubyProperties(DXW.Ruby openXmlElement, DMW.RubyProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.RubyPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.RubyProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRubyProperties(DXW.Ruby openXmlElement, DMW.RubyProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RubyProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RubyPropertiesConverter.CreateOpenXmlElement<DXW.RubyProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Phonetic Guide Text.
  /// </summary>
  private static DMW.RubyContent? GetRubyContent(DXW.Ruby openXmlElement)
  {
    return DMXW.RubyContentConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.RubyContent>());
  }
  
  private static bool CmpRubyContent(DXW.Ruby openXmlElement, DMW.RubyContent? value, DiffList? diffs, string? objName)
  {
    return DMXW.RubyContentConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.RubyContent>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRubyContent(DXW.Ruby openXmlElement, DMW.RubyContent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RubyContent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RubyContentConverter.CreateOpenXmlElement<DXW.RubyContent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Phonetic Guide Base Text.
  /// </summary>
  private static DMW.RubyBase? GetRubyBase(DXW.Ruby openXmlElement)
  {
    return DMXW.RubyBaseConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.RubyBase>());
  }
  
  private static bool CmpRubyBase(DXW.Ruby openXmlElement, DMW.RubyBase? value, DiffList? diffs, string? objName)
  {
    return DMXW.RubyBaseConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.RubyBase>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRubyBase(DXW.Ruby openXmlElement, DMW.RubyBase? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RubyBase>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RubyBaseConverter.CreateOpenXmlElement<DXW.RubyBase>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Ruby? CreateModelElement(DXW.Ruby? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Ruby();
      value.RubyProperties = GetRubyProperties(openXmlElement);
      value.RubyContent = GetRubyContent(openXmlElement);
      value.RubyBase = GetRubyBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Ruby? openXmlElement, DMW.Ruby? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRubyProperties(openXmlElement, value.RubyProperties, diffs, objName))
        ok = false;
      if (!CmpRubyContent(openXmlElement, value.RubyContent, diffs, objName))
        ok = false;
      if (!CmpRubyBase(openXmlElement, value.RubyBase, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Ruby? value)
    where OpenXmlElementType: DXW.Ruby, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRubyProperties(openXmlElement, value?.RubyProperties);
      SetRubyContent(openXmlElement, value?.RubyContent);
      SetRubyBase(openXmlElement, value?.RubyBase);
      return openXmlElement;
    }
    return default;
  }
}
