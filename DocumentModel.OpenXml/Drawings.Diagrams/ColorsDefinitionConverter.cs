namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Color Transform Definitions.
/// </summary>
public static class ColorsDefinitionConverter
{
  /// <summary>
  /// Unique ID
  /// </summary>
  private static String? GetUniqueId(DXDD.ColorsDefinition openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.UniqueId);
  }
  
  private static bool CmpUniqueId(DXDD.ColorsDefinition openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.UniqueId, value, diffs, objName, "UniqueId");
  }
  
  private static void SetUniqueId(DXDD.ColorsDefinition openXmlElement, String? value)
  {
    openXmlElement.UniqueId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  private static String? GetMinVersion(DXDD.ColorsDefinition openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinVersion);
  }
  
  private static bool CmpMinVersion(DXDD.ColorsDefinition openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinVersion, value, diffs, objName, "MinVersion");
  }
  
  private static void SetMinVersion(DXDD.ColorsDefinition openXmlElement, String? value)
  {
    openXmlElement.MinVersion = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMDD.ColorDefinitionTitle>? GetColorDefinitionTitles(DXDD.ColorsDefinition openXmlElement)
  {
    var collection = new Collection<DMDD.ColorDefinitionTitle>();
    foreach (var item in openXmlElement.Elements<DXDD.ColorDefinitionTitle>())
    {
      var newItem = DMXDD.ColorDefinitionTitleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpColorDefinitionTitles(DXDD.ColorsDefinition openXmlElement, Collection<DMDD.ColorDefinitionTitle>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDD.ColorDefinitionTitle>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDD.ColorDefinitionTitleConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetColorDefinitionTitles(DXDD.ColorsDefinition openXmlElement, Collection<DMDD.ColorDefinitionTitle>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.ColorDefinitionTitle>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.ColorDefinitionTitleConverter.CreateOpenXmlElement<DXDD.ColorDefinitionTitle>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static Collection<DMDD.ColorTransformDescription>? GetColorTransformDescriptions(DXDD.ColorsDefinition openXmlElement)
  {
    var collection = new Collection<DMDD.ColorTransformDescription>();
    foreach (var item in openXmlElement.Elements<DXDD.ColorTransformDescription>())
    {
      var newItem = DMXDD.ColorTransformDescriptionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpColorTransformDescriptions(DXDD.ColorsDefinition openXmlElement, Collection<DMDD.ColorTransformDescription>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDD.ColorTransformDescription>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDD.ColorTransformDescriptionConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetColorTransformDescriptions(DXDD.ColorsDefinition openXmlElement, Collection<DMDD.ColorTransformDescription>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.ColorTransformDescription>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.ColorTransformDescriptionConverter.CreateOpenXmlElement<DXDD.ColorTransformDescription>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDD.ColorTransformCategories? GetColorTransformCategories(DXDD.ColorsDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ColorTransformCategories>();
    if (element != null)
      return DMXDD.ColorTransformCategoriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorTransformCategories(DXDD.ColorsDefinition openXmlElement, DMDD.ColorTransformCategories? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.ColorTransformCategoriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ColorTransformCategories>(), value, diffs, objName, propName);
  }
  
  private static void SetColorTransformCategories(DXDD.ColorsDefinition openXmlElement, DMDD.ColorTransformCategories? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ColorTransformCategories>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ColorTransformCategoriesConverter.CreateOpenXmlElement<DXDD.ColorTransformCategories>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Collection<DMDD.ColorTransformStyleLabel>? GetColorTransformStyleLabels(DXDD.ColorsDefinition openXmlElement)
  {
    var collection = new Collection<DMDD.ColorTransformStyleLabel>();
    foreach (var item in openXmlElement.Elements<DXDD.ColorTransformStyleLabel>())
    {
      var newItem = DMXDD.ColorTransformStyleLabelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpColorTransformStyleLabels(DXDD.ColorsDefinition openXmlElement, Collection<DMDD.ColorTransformStyleLabel>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXDD.ColorTransformStyleLabel>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDD.ColorTransformStyleLabelConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetColorTransformStyleLabels(DXDD.ColorsDefinition openXmlElement, Collection<DMDD.ColorTransformStyleLabel>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.ColorTransformStyleLabel>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.ColorTransformStyleLabelConverter.CreateOpenXmlElement<DXDD.ColorTransformStyleLabel>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDD.ExtensionList? GetExtensionList(DXDD.ColorsDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ExtensionList>();
    if (element != null)
      return DMXDD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDD.ColorsDefinition openXmlElement, DMDD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DXDD.ColorsDefinition openXmlElement, DMDD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ExtensionListConverter.CreateOpenXmlElement<DXDD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDD.ColorsDefinition? CreateModelElement(DXDD.ColorsDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.ColorsDefinition();
      value.UniqueId = GetUniqueId(openXmlElement);
      value.MinVersion = GetMinVersion(openXmlElement);
      value.ColorDefinitionTitles = GetColorDefinitionTitles(openXmlElement);
      value.ColorTransformDescriptions = GetColorTransformDescriptions(openXmlElement);
      value.ColorTransformCategories = GetColorTransformCategories(openXmlElement);
      value.ColorTransformStyleLabels = GetColorTransformStyleLabels(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.ColorsDefinition? openXmlElement, DMDD.ColorsDefinition? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUniqueId(openXmlElement, value.UniqueId, diffs, objName, propName))
        ok = false;
      if (!CmpMinVersion(openXmlElement, value.MinVersion, diffs, objName, propName))
        ok = false;
      if (!CmpColorDefinitionTitles(openXmlElement, value.ColorDefinitionTitles, diffs, objName, propName))
        ok = false;
      if (!CmpColorTransformDescriptions(openXmlElement, value.ColorTransformDescriptions, diffs, objName, propName))
        ok = false;
      if (!CmpColorTransformCategories(openXmlElement, value.ColorTransformCategories, diffs, objName, propName))
        ok = false;
      if (!CmpColorTransformStyleLabels(openXmlElement, value.ColorTransformStyleLabels, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.ColorsDefinition value)
    where OpenXmlElementType: DXDD.ColorsDefinition, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.ColorsDefinition openXmlElement, DMDD.ColorsDefinition value)
  {
    SetUniqueId(openXmlElement, value?.UniqueId);
    SetMinVersion(openXmlElement, value?.MinVersion);
    SetColorDefinitionTitles(openXmlElement, value?.ColorDefinitionTitles);
    SetColorTransformDescriptions(openXmlElement, value?.ColorTransformDescriptions);
    SetColorTransformCategories(openXmlElement, value?.ColorTransformCategories);
    SetColorTransformStyleLabels(openXmlElement, value?.ColorTransformStyleLabels);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
