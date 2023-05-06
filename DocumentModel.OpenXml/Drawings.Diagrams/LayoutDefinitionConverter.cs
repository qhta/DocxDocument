namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Layout Definition.
/// </summary>
public static class LayoutDefinitionConverter
{
  /// <summary>
  /// uniqueId
  /// </summary>
  private static String? GetUniqueId(DXDD.LayoutDefinition openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.UniqueId);
  }
  
  private static bool CmpUniqueId(DXDD.LayoutDefinition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.UniqueId, value, diffs, objName, "UniqueId");
  }
  
  private static void SetUniqueId(DXDD.LayoutDefinition openXmlElement, String? value)
  {
    openXmlElement.UniqueId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// minVer
  /// </summary>
  private static String? GetMinVersion(DXDD.LayoutDefinition openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinVersion);
  }
  
  private static bool CmpMinVersion(DXDD.LayoutDefinition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinVersion, value, diffs, objName, "MinVersion");
  }
  
  private static void SetMinVersion(DXDD.LayoutDefinition openXmlElement, String? value)
  {
    openXmlElement.MinVersion = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// defStyle
  /// </summary>
  private static String? GetDefaultStyle(DXDD.LayoutDefinition openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.DefaultStyle);
  }
  
  private static bool CmpDefaultStyle(DXDD.LayoutDefinition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.DefaultStyle, value, diffs, objName, "DefaultStyle");
  }
  
  private static void SetDefaultStyle(DXDD.LayoutDefinition openXmlElement, String? value)
  {
    openXmlElement.DefaultStyle = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMDD.Title>? GetTitles(DXDD.LayoutDefinition openXmlElement)
  {
    var collection = new Collection<DMDD.Title>();
    foreach (var item in openXmlElement.Elements<DXDD.Title>())
    {
      var newItem = DMXDD.TitleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpTitles(DXDD.LayoutDefinition openXmlElement, Collection<DMDD.Title>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDD.Title>();
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
        if (!DMXDD.TitleConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetTitles(DXDD.LayoutDefinition openXmlElement, Collection<DMDD.Title>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.Title>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.TitleConverter.CreateOpenXmlElement<DXDD.Title>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static Collection<DMDD.Description>? GetDescriptions(DXDD.LayoutDefinition openXmlElement)
  {
    var collection = new Collection<DMDD.Description>();
    foreach (var item in openXmlElement.Elements<DXDD.Description>())
    {
      var newItem = DMXDD.DescriptionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDescriptions(DXDD.LayoutDefinition openXmlElement, Collection<DMDD.Description>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDD.Description>();
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
        if (!DMXDD.DescriptionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDescriptions(DXDD.LayoutDefinition openXmlElement, Collection<DMDD.Description>? value)
  {
    openXmlElement.RemoveAllChildren<DXDD.Description>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDD.DescriptionConverter.CreateOpenXmlElement<DXDD.Description>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDD.CategoryList? GetCategoryList(DXDD.LayoutDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.CategoryList>();
    if (element != null)
      return DMXDD.CategoryListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryList(DXDD.LayoutDefinition openXmlElement, DMDD.CategoryList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.CategoryListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.CategoryList>(), value, diffs, objName);
  }
  
  private static void SetCategoryList(DXDD.LayoutDefinition openXmlElement, DMDD.CategoryList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.CategoryList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.CategoryListConverter.CreateOpenXmlElement<DXDD.CategoryList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD.SampleData? GetSampleData(DXDD.LayoutDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.SampleData>();
    if (element != null)
      return DMXDD.SampleDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSampleData(DXDD.LayoutDefinition openXmlElement, DMDD.SampleData? value, DiffList? diffs, string? objName)
  {
    return DMXDD.SampleDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.SampleData>(), value, diffs, objName);
  }
  
  private static void SetSampleData(DXDD.LayoutDefinition openXmlElement, DMDD.SampleData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.SampleData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.SampleDataConverter.CreateOpenXmlElement<DXDD.SampleData>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD.StyleData? GetStyleData(DXDD.LayoutDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.StyleData>();
    if (element != null)
      return DMXDD.StyleDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyleData(DXDD.LayoutDefinition openXmlElement, DMDD.StyleData? value, DiffList? diffs, string? objName)
  {
    return DMXDD.StyleDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.StyleData>(), value, diffs, objName);
  }
  
  private static void SetStyleData(DXDD.LayoutDefinition openXmlElement, DMDD.StyleData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.StyleData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.StyleDataConverter.CreateOpenXmlElement<DXDD.StyleData>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD.ColorData? GetColorData(DXDD.LayoutDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.ColorData>();
    if (element != null)
      return DMXDD.ColorDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorData(DXDD.LayoutDefinition openXmlElement, DMDD.ColorData? value, DiffList? diffs, string? objName)
  {
    return DMXDD.ColorDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.ColorData>(), value, diffs, objName);
  }
  
  private static void SetColorData(DXDD.LayoutDefinition openXmlElement, DMDD.ColorData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ColorData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.ColorDataConverter.CreateOpenXmlElement<DXDD.ColorData>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD.LayoutNode? GetLayoutNode(DXDD.LayoutDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.LayoutNode>();
    if (element != null)
      return DMXDD.LayoutNodeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLayoutNode(DXDD.LayoutDefinition openXmlElement, DMDD.LayoutNode? value, DiffList? diffs, string? objName)
  {
    return DMXDD.LayoutNodeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.LayoutNode>(), value, diffs, objName);
  }
  
  private static void SetLayoutNode(DXDD.LayoutDefinition openXmlElement, DMDD.LayoutNode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.LayoutNode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.LayoutNodeConverter.CreateOpenXmlElement<DXDD.LayoutNode>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD.DiagramDefinitionExtensionList? GetDiagramDefinitionExtensionList(DXDD.LayoutDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDD.DiagramDefinitionExtensionList>();
    if (element != null)
      return DMXDD.DiagramDefinitionExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDiagramDefinitionExtensionList(DXDD.LayoutDefinition openXmlElement, DMDD.DiagramDefinitionExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDD.DiagramDefinitionExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDD.DiagramDefinitionExtensionList>(), value, diffs, objName);
  }
  
  private static void SetDiagramDefinitionExtensionList(DXDD.LayoutDefinition openXmlElement, DMDD.DiagramDefinitionExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.DiagramDefinitionExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDD.DiagramDefinitionExtensionListConverter.CreateOpenXmlElement<DXDD.DiagramDefinitionExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.LayoutDefinition? CreateModelElement(DXDD.LayoutDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.LayoutDefinition();
      value.UniqueId = GetUniqueId(openXmlElement);
      value.MinVersion = GetMinVersion(openXmlElement);
      value.DefaultStyle = GetDefaultStyle(openXmlElement);
      value.Titles = GetTitles(openXmlElement);
      value.Descriptions = GetDescriptions(openXmlElement);
      value.CategoryList = GetCategoryList(openXmlElement);
      value.SampleData = GetSampleData(openXmlElement);
      value.StyleData = GetStyleData(openXmlElement);
      value.ColorData = GetColorData(openXmlElement);
      value.LayoutNode = GetLayoutNode(openXmlElement);
      value.DiagramDefinitionExtensionList = GetDiagramDefinitionExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.LayoutDefinition? openXmlElement, DMDD.LayoutDefinition? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUniqueId(openXmlElement, value.UniqueId, diffs, objName))
        ok = false;
      if (!CmpMinVersion(openXmlElement, value.MinVersion, diffs, objName))
        ok = false;
      if (!CmpDefaultStyle(openXmlElement, value.DefaultStyle, diffs, objName))
        ok = false;
      if (!CmpTitles(openXmlElement, value.Titles, diffs, objName))
        ok = false;
      if (!CmpDescriptions(openXmlElement, value.Descriptions, diffs, objName))
        ok = false;
      if (!CmpCategoryList(openXmlElement, value.CategoryList, diffs, objName))
        ok = false;
      if (!CmpSampleData(openXmlElement, value.SampleData, diffs, objName))
        ok = false;
      if (!CmpStyleData(openXmlElement, value.StyleData, diffs, objName))
        ok = false;
      if (!CmpColorData(openXmlElement, value.ColorData, diffs, objName))
        ok = false;
      if (!CmpLayoutNode(openXmlElement, value.LayoutNode, diffs, objName))
        ok = false;
      if (!CmpDiagramDefinitionExtensionList(openXmlElement, value.DiagramDefinitionExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.LayoutDefinition value)
    where OpenXmlElementType: DXDD.LayoutDefinition, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.LayoutDefinition openXmlElement, DMDD.LayoutDefinition value)
  {
    SetUniqueId(openXmlElement, value?.UniqueId);
    SetMinVersion(openXmlElement, value?.MinVersion);
    SetDefaultStyle(openXmlElement, value?.DefaultStyle);
    SetTitles(openXmlElement, value?.Titles);
    SetDescriptions(openXmlElement, value?.Descriptions);
    SetCategoryList(openXmlElement, value?.CategoryList);
    SetSampleData(openXmlElement, value?.SampleData);
    SetStyleData(openXmlElement, value?.StyleData);
    SetColorData(openXmlElement, value?.ColorData);
    SetLayoutNode(openXmlElement, value?.LayoutNode);
    SetDiagramDefinitionExtensionList(openXmlElement, value?.DiagramDefinitionExtensionList);
  }
}
