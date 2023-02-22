namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Style Definition.
/// </summary>
public static class StyleDefinitionConverter
{
  /// <summary>
  /// Unique Style ID
  /// </summary>
  private static String? GetUniqueId(DXDrawDgms.StyleDefinition openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.UniqueId);
  }
  
  private static bool CmpUniqueId(DXDrawDgms.StyleDefinition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.UniqueId, value, diffs, objName, "UniqueId");
  }
  
  private static void SetUniqueId(DXDrawDgms.StyleDefinition openXmlElement, String? value)
  {
    openXmlElement.UniqueId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  private static String? GetMinVersion(DXDrawDgms.StyleDefinition openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinVersion);
  }
  
  private static bool CmpMinVersion(DXDrawDgms.StyleDefinition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinVersion, value, diffs, objName, "MinVersion");
  }
  
  private static void SetMinVersion(DXDrawDgms.StyleDefinition openXmlElement, String? value)
  {
    openXmlElement.MinVersion = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMDrawsDgms.StyleDefinitionTitle>? GetStyleDefinitionTitles(DXDrawDgms.StyleDefinition openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.StyleDefinitionTitle>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.StyleDefinitionTitle>())
    {
      var newItem = DMXDrawsDgms.StyleDefinitionTitleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpStyleDefinitionTitles(DXDrawDgms.StyleDefinition openXmlElement, Collection<DMDrawsDgms.StyleDefinitionTitle>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawDgms.StyleDefinitionTitle>();
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
        if (!DMXDrawsDgms.StyleDefinitionTitleConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStyleDefinitionTitles(DXDrawDgms.StyleDefinition openXmlElement, Collection<DMDrawsDgms.StyleDefinitionTitle>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.StyleDefinitionTitle>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.StyleDefinitionTitleConverter.CreateOpenXmlElement<DXDrawDgms.StyleDefinitionTitle>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DMDrawsDgms.StyleLabelDescription>? GetStyleLabelDescriptions(DXDrawDgms.StyleDefinition openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.StyleLabelDescription>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.StyleLabelDescription>())
    {
      var newItem = DMXDrawsDgms.StyleLabelDescriptionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpStyleLabelDescriptions(DXDrawDgms.StyleDefinition openXmlElement, Collection<DMDrawsDgms.StyleLabelDescription>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawDgms.StyleLabelDescription>();
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
        if (!DMXDrawsDgms.StyleLabelDescriptionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStyleLabelDescriptions(DXDrawDgms.StyleDefinition openXmlElement, Collection<DMDrawsDgms.StyleLabelDescription>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.StyleLabelDescription>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.StyleLabelDescriptionConverter.CreateOpenXmlElement<DXDrawDgms.StyleLabelDescription>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsDgms.StyleDisplayCategories? GetStyleDisplayCategories(DXDrawDgms.StyleDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.StyleDisplayCategories>();
    if (element != null)
      return DMXDrawsDgms.StyleDisplayCategoriesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyleDisplayCategories(DXDrawDgms.StyleDefinition openXmlElement, DMDrawsDgms.StyleDisplayCategories? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.StyleDisplayCategoriesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.StyleDisplayCategories>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStyleDisplayCategories(DXDrawDgms.StyleDefinition openXmlElement, DMDrawsDgms.StyleDisplayCategories? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.StyleDisplayCategories>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.StyleDisplayCategoriesConverter.CreateOpenXmlElement<DXDrawDgms.StyleDisplayCategories>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.Scene3D? GetScene3D(DXDrawDgms.StyleDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.Scene3D>();
    if (element != null)
      return DMXDrawsDgms.Scene3DConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpScene3D(DXDrawDgms.StyleDefinition openXmlElement, DMDrawsDgms.Scene3D? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.Scene3DConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.Scene3D>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetScene3D(DXDrawDgms.StyleDefinition openXmlElement, DMDrawsDgms.Scene3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Scene3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.Scene3DConverter.CreateOpenXmlElement<DXDrawDgms.Scene3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.StyleLabel? GetStyleLabel(DXDrawDgms.StyleDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.StyleLabel>();
    if (element != null)
      return DMXDrawsDgms.StyleLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyleLabel(DXDrawDgms.StyleDefinition openXmlElement, DMDrawsDgms.StyleLabel? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.StyleLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.StyleLabel>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStyleLabel(DXDrawDgms.StyleDefinition openXmlElement, DMDrawsDgms.StyleLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.StyleLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.StyleLabelConverter.CreateOpenXmlElement<DXDrawDgms.StyleLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.ExtensionList? GetExtensionList(DXDrawDgms.StyleDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (element != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDrawDgms.StyleDefinition openXmlElement, DMDrawsDgms.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDrawDgms.StyleDefinition openXmlElement, DMDrawsDgms.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Diagrams.StyleDefinition? CreateModelElement(DXDrawDgms.StyleDefinition? openXmlElement)
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
  
  public static bool CompareModelElement(DXDrawDgms.StyleDefinition? openXmlElement, DMDrawsDgms.StyleDefinition? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.StyleDefinition value)
    where OpenXmlElementType: DXDrawDgms.StyleDefinition, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.StyleDefinition openXmlElement, DMDrawsDgms.StyleDefinition value)
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
