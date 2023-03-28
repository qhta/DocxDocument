namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Color Transform Definitions converter from/to OpenXml.
///</summary>
public static class ColorsDefinitionConverter
{
  /// <summary>
  /// Unique ID
  /// </summary>
  private static String? GetUniqueId(DXDrawDgms.ColorsDefinition openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.UniqueId);
  }
  
  private static bool CmpUniqueId(DXDrawDgms.ColorsDefinition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.UniqueId, value, diffs, objName, "UniqueId");
  }
  
  private static void SetUniqueId(DXDrawDgms.ColorsDefinition openXmlElement, String? value)
  {
    openXmlElement.UniqueId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  private static String? GetMinVersion(DXDrawDgms.ColorsDefinition openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinVersion);
  }
  
  private static bool CmpMinVersion(DXDrawDgms.ColorsDefinition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinVersion, value, diffs, objName, "MinVersion");
  }
  
  private static void SetMinVersion(DXDrawDgms.ColorsDefinition openXmlElement, String? value)
  {
    openXmlElement.MinVersion = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMDrawsDgms.ColorDefinitionTitle>? GetColorDefinitionTitles(DXDrawDgms.ColorsDefinition openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.ColorDefinitionTitle>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.ColorDefinitionTitle>())
    {
      var newItem = DMXDrawsDgms.ColorDefinitionTitleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpColorDefinitionTitles(DXDrawDgms.ColorsDefinition openXmlElement, Collection<DMDrawsDgms.ColorDefinitionTitle>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawDgms.ColorDefinitionTitle>();
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
        if (!DMXDrawsDgms.ColorDefinitionTitleConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetColorDefinitionTitles(DXDrawDgms.ColorsDefinition openXmlElement, Collection<DMDrawsDgms.ColorDefinitionTitle>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.ColorDefinitionTitle>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.ColorDefinitionTitleConverter.CreateOpenXmlElement<DXDrawDgms.ColorDefinitionTitle>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DMDrawsDgms.ColorTransformDescription>? GetColorTransformDescriptions(DXDrawDgms.ColorsDefinition openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.ColorTransformDescription>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.ColorTransformDescription>())
    {
      var newItem = DMXDrawsDgms.ColorTransformDescriptionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpColorTransformDescriptions(DXDrawDgms.ColorsDefinition openXmlElement, Collection<DMDrawsDgms.ColorTransformDescription>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawDgms.ColorTransformDescription>();
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
        if (!DMXDrawsDgms.ColorTransformDescriptionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetColorTransformDescriptions(DXDrawDgms.ColorsDefinition openXmlElement, Collection<DMDrawsDgms.ColorTransformDescription>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.ColorTransformDescription>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.ColorTransformDescriptionConverter.CreateOpenXmlElement<DXDrawDgms.ColorTransformDescription>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsDgms.ColorTransformCategories? GetColorTransformCategories(DXDrawDgms.ColorsDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.ColorTransformCategories>();
    if (element != null)
      return DMXDrawsDgms.ColorTransformCategoriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorTransformCategories(DXDrawDgms.ColorsDefinition openXmlElement, DMDrawsDgms.ColorTransformCategories? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ColorTransformCategoriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ColorTransformCategories>(), value, diffs, objName);
  }
  
  private static void SetColorTransformCategories(DXDrawDgms.ColorsDefinition openXmlElement, DMDrawsDgms.ColorTransformCategories? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ColorTransformCategories>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ColorTransformCategoriesConverter.CreateOpenXmlElement<DXDrawDgms.ColorTransformCategories>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsDgms.ColorTransformStyleLabel>? GetColorTransformStyleLabels(DXDrawDgms.ColorsDefinition openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.ColorTransformStyleLabel>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.ColorTransformStyleLabel>())
    {
      var newItem = DMXDrawsDgms.ColorTransformStyleLabelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpColorTransformStyleLabels(DXDrawDgms.ColorsDefinition openXmlElement, Collection<DMDrawsDgms.ColorTransformStyleLabel>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawDgms.ColorTransformStyleLabel>();
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
        if (!DMXDrawsDgms.ColorTransformStyleLabelConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetColorTransformStyleLabels(DXDrawDgms.ColorsDefinition openXmlElement, Collection<DMDrawsDgms.ColorTransformStyleLabel>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.ColorTransformStyleLabel>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.ColorTransformStyleLabelConverter.CreateOpenXmlElement<DXDrawDgms.ColorTransformStyleLabel>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.ColorsDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (element != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawDgms.ColorsDefinition openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDrawDgms.ColorsDefinition openXmlElement, DMDrawsDgms.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ExtensionListConverter.CreateOpenXmlElement<DXDrawDgms.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ColorsDefinition? CreateModelElement(DXDrawDgms.ColorsDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorsDefinition();
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
  
  public static bool CompareModelElement(DXDrawDgms.ColorsDefinition? openXmlElement, DMDrawsDgms.ColorsDefinition? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUniqueId(openXmlElement, value.UniqueId, diffs, objName))
        ok = false;
      if (!CmpMinVersion(openXmlElement, value.MinVersion, diffs, objName))
        ok = false;
      if (!CmpColorDefinitionTitles(openXmlElement, value.ColorDefinitionTitles, diffs, objName))
        ok = false;
      if (!CmpColorTransformDescriptions(openXmlElement, value.ColorTransformDescriptions, diffs, objName))
        ok = false;
      if (!CmpColorTransformCategories(openXmlElement, value.ColorTransformCategories, diffs, objName))
        ok = false;
      if (!CmpColorTransformStyleLabels(openXmlElement, value.ColorTransformStyleLabels, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ColorsDefinition value)
    where OpenXmlElementType: DXDrawDgms.ColorsDefinition, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.ColorsDefinition openXmlElement, DMDrawsDgms.ColorsDefinition value)
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
