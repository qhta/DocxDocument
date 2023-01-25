namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Color Transform Definitions.
/// </summary>
public static class ColorsDefinitionConverter
{
  /// <summary>
  /// Unique ID
  /// </summary>
  private static String? GetUniqueId(DXDrawDgms.ColorsDefinition openXmlElement)
  {
    return openXmlElement?.UniqueId?.Value;
  }
  
  private static bool CmpUniqueId(DXDrawDgms.ColorsDefinition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UniqueId?.Value == value;
  }
  
  private static void SetUniqueId(DXDrawDgms.ColorsDefinition openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.UniqueId = new StringValue { Value = value };
    else
      openXmlElement.UniqueId = null;
  }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  private static String? GetMinVersion(DXDrawDgms.ColorsDefinition openXmlElement)
  {
    return openXmlElement?.MinVersion?.Value;
  }
  
  private static bool CmpMinVersion(DXDrawDgms.ColorsDefinition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.MinVersion?.Value == value;
  }
  
  private static void SetMinVersion(DXDrawDgms.ColorsDefinition openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MinVersion = new StringValue { Value = value };
    else
      openXmlElement.MinVersion = null;
  }
  
  private static Collection<DMDrawsDgms.ColorDefinitionTitle> GetColorDefinitionTitles(DXDrawDgms.ColorsDefinition openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.ColorDefinitionTitle>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.ColorDefinitionTitle>())
    {
      var newItem = DMXDrawsDgms.ColorDefinitionTitleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpColorDefinitionTitles(DXDrawDgms.ColorsDefinition openXmlElement, Collection<DMDrawsDgms.ColorDefinitionTitle>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawDgms.ColorDefinitionTitle>();
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
        if (!DMXDrawsDgms.ColorDefinitionTitleConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
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
  
  private static Collection<DMDrawsDgms.ColorTransformDescription> GetColorTransformDescriptions(DXDrawDgms.ColorsDefinition openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.ColorTransformDescription>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.ColorTransformDescription>())
    {
      var newItem = DMXDrawsDgms.ColorTransformDescriptionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpColorTransformDescriptions(DXDrawDgms.ColorsDefinition openXmlElement, Collection<DMDrawsDgms.ColorTransformDescription>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawDgms.ColorTransformDescription>();
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
        if (!DMXDrawsDgms.ColorTransformDescriptionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
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
    return DMXDrawsDgms.ColorTransformCategoriesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ColorTransformCategories>());
  }
  
  private static bool CmpColorTransformCategories(DXDrawDgms.ColorsDefinition openXmlElement, DMDrawsDgms.ColorTransformCategories? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ColorTransformCategoriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ColorTransformCategories>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static Collection<DMDrawsDgms.ColorTransformStyleLabel> GetColorTransformStyleLabels(DXDrawDgms.ColorsDefinition openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.ColorTransformStyleLabel>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.ColorTransformStyleLabel>())
    {
      var newItem = DMXDrawsDgms.ColorTransformStyleLabelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpColorTransformStyleLabels(DXDrawDgms.ColorsDefinition openXmlElement, Collection<DMDrawsDgms.ColorTransformStyleLabel>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXDrawDgms.ColorTransformStyleLabel>();
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
        if (!DMXDrawsDgms.ColorTransformStyleLabelConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
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
    return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXDrawDgms.ColorsDefinition openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMDrawsDgms.ColorsDefinition? CreateModelElement(DXDrawDgms.ColorsDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.ColorsDefinition();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ColorsDefinition? value)
    where OpenXmlElementType: DXDrawDgms.ColorsDefinition, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUniqueId(openXmlElement, value?.UniqueId);
      SetMinVersion(openXmlElement, value?.MinVersion);
      SetColorDefinitionTitles(openXmlElement, value?.ColorDefinitionTitles);
      SetColorTransformDescriptions(openXmlElement, value?.ColorTransformDescriptions);
      SetColorTransformCategories(openXmlElement, value?.ColorTransformCategories);
      SetColorTransformStyleLabels(openXmlElement, value?.ColorTransformStyleLabels);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
