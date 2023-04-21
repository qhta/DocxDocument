namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Style Definition.
/// </summary>
public static class StyleDefinitionConverter
{
  /// <summary>
  /// Unique Style ID
  /// </summary>
  private static String? GetUniqueId(DXDD.StyleDefinition openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.UniqueId);
  }
  
  private static bool CmpUniqueId(DXDD.StyleDefinition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.UniqueId, value, diffs, objName, "UniqueId");
  }
  
  private static void SetUniqueId(DXDD.StyleDefinition openXmlElement, String? value)
  {
    openXmlElement.UniqueId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  private static String? GetMinVersion(DXDD.StyleDefinition openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinVersion);
  }
  
  private static bool CmpMinVersion(DXDD.StyleDefinition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinVersion, value, diffs, objName, "MinVersion");
  }
  
  private static void SetMinVersion(DXDD.StyleDefinition openXmlElement, String? value)
  {
    openXmlElement.MinVersion = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMDD.StyleDefinitionTitle>? GetStyleDefinitionTitles(DXDD.StyleDefinition openXmlElement)
  {
    var collection = new Collection<DMDD.StyleDefinitionTitle>();
    foreach (var item in openXmlElement.Elements<DXDD.StyleDefinitionTitle>())
    {
      var newItem = DMXDD.StyleDefinitionTitleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpStyleDefinitionTitles(DXDD.StyleDefinition openXmlElement, Collection<DMDD.StyleDefinitionTitle>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDD.StyleDefinitionTitle>();
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
        if (!DMXDD.StyleDefinitionTitleConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStyleDefinitionTitles(DXDD.StyleDefinition openXmlElement, Collection<DMDD.StyleDefinitionTitle>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.StyleDefinitionTitle>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.StyleDefinitionTitleConverter.CreateOpenXmlElement<DXDD.StyleDefinitionTitle>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DMDD.StyleLabelDescription>? GetStyleLabelDescriptions(DXDD.StyleDefinition openXmlElement)
  {
    var collection = new Collection<DMDD.StyleLabelDescription>();
    foreach (var item in openXmlElement.Elements<DXDD.StyleLabelDescription>())
    {
      var newItem = DMXDD.StyleLabelDescriptionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpStyleLabelDescriptions(DXDD.StyleDefinition openXmlElement, Collection<DMDD.StyleLabelDescription>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDD.StyleLabelDescription>();
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
        if (!DMXDD.StyleLabelDescriptionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStyleLabelDescriptions(DXDD.StyleDefinition openXmlElement, Collection<DMDD.StyleLabelDescription>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.StyleLabelDescription>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.StyleLabelDescriptionConverter.CreateOpenXmlElement<DXDD.StyleLabelDescription>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDD.StyleDisplayCategories? GetStyleDisplayCategories(DXDD.StyleDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.StyleDisplayCategories>();
    if (element != null)
      return DMXDD.StyleDisplayCategoriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyleDisplayCategories(DXDD.StyleDefinition openXmlElement, DMDD.StyleDisplayCategories? value, DiffList? diffs, string? objName)
  {
    return DMXDD.StyleDisplayCategoriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.StyleDisplayCategories>(), value, diffs, objName);
  }
  
  private static void SetStyleDisplayCategories(DXDD.StyleDefinition openXmlElement, DMDD.StyleDisplayCategories? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.StyleDisplayCategories>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.StyleDisplayCategoriesConverter.CreateOpenXmlElement<DXDD.StyleDisplayCategories>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDD.Scene3D? GetScene3D(DXDD.StyleDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.Scene3D>();
    if (element != null)
      return DMXDD.Scene3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScene3D(DXDD.StyleDefinition openXmlElement, DMDD.Scene3D? value, DiffList? diffs, string? objName)
  {
    return DMXDD.Scene3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.Scene3D>(), value, diffs, objName);
  }
  
  private static void SetScene3D(DXDD.StyleDefinition openXmlElement, DMDD.Scene3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.Scene3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.Scene3DConverter.CreateOpenXmlElement<DXDD.Scene3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDD.StyleLabel? GetStyleLabel(DXDD.StyleDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.StyleLabel>();
    if (element != null)
      return DMXDD.StyleLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyleLabel(DXDD.StyleDefinition openXmlElement, DMDD.StyleLabel? value, DiffList? diffs, string? objName)
  {
    return DMXDD.StyleLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.StyleLabel>(), value, diffs, objName);
  }
  
  private static void SetStyleLabel(DXDD.StyleDefinition openXmlElement, DMDD.StyleLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.StyleLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.StyleLabelConverter.CreateOpenXmlElement<DXDD.StyleLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDD.ExtensionList? GetExtensionList(DXDD.StyleDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ExtensionList>();
    if (element != null)
      return DMXDD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDD.StyleDefinition openXmlElement, DMDD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDD.StyleDefinition openXmlElement, DMDD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ExtensionListConverter.CreateOpenXmlElement<DXDD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.StyleDefinition? CreateModelElement(DXDD.StyleDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.StyleDefinition();
      value.UniqueId = GetUniqueId(openXmlElement);
      value.MinVersion = GetMinVersion(openXmlElement);
      value.StyleDefinitionTitles = GetStyleDefinitionTitles(openXmlElement);
      value.StyleLabelDescriptions = GetStyleLabelDescriptions(openXmlElement);
      value.StyleDisplayCategories = GetStyleDisplayCategories(openXmlElement);
      value.Scene3D = GetScene3D(openXmlElement);
      value.StyleLabel = GetStyleLabel(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.StyleDefinition? openXmlElement, DMDD.StyleDefinition? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUniqueId(openXmlElement, value.UniqueId, diffs, objName))
        ok = false;
      if (!CmpMinVersion(openXmlElement, value.MinVersion, diffs, objName))
        ok = false;
      if (!CmpStyleDefinitionTitles(openXmlElement, value.StyleDefinitionTitles, diffs, objName))
        ok = false;
      if (!CmpStyleLabelDescriptions(openXmlElement, value.StyleLabelDescriptions, diffs, objName))
        ok = false;
      if (!CmpStyleDisplayCategories(openXmlElement, value.StyleDisplayCategories, diffs, objName))
        ok = false;
      if (!CmpScene3D(openXmlElement, value.Scene3D, diffs, objName))
        ok = false;
      if (!CmpStyleLabel(openXmlElement, value.StyleLabel, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.StyleDefinition value)
    where OpenXmlElementType: DXDD.StyleDefinition, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.StyleDefinition openXmlElement, DMDD.StyleDefinition value)
  {
    SetUniqueId(openXmlElement, value?.UniqueId);
    SetMinVersion(openXmlElement, value?.MinVersion);
    SetStyleDefinitionTitles(openXmlElement, value?.StyleDefinitionTitles);
    SetStyleLabelDescriptions(openXmlElement, value?.StyleLabelDescriptions);
    SetStyleDisplayCategories(openXmlElement, value?.StyleDisplayCategories);
    SetScene3D(openXmlElement, value?.Scene3D);
    SetStyleLabel(openXmlElement, value?.StyleLabel);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
