namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Layout Definition.
/// </summary>
public static class LayoutDefinitionConverter
{
  /// <summary>
  /// uniqueId
  /// </summary>
  private static String? GetUniqueId(DXDrawDgms.LayoutDefinition openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.UniqueId);
  }
  
  private static bool CmpUniqueId(DXDrawDgms.LayoutDefinition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.UniqueId, value, diffs, objName, "UniqueId");
  }
  
  private static void SetUniqueId(DXDrawDgms.LayoutDefinition openXmlElement, String? value)
  {
    openXmlElement.UniqueId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// minVer
  /// </summary>
  private static String? GetMinVersion(DXDrawDgms.LayoutDefinition openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.MinVersion);
  }
  
  private static bool CmpMinVersion(DXDrawDgms.LayoutDefinition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.MinVersion, value, diffs, objName, "MinVersion");
  }
  
  private static void SetMinVersion(DXDrawDgms.LayoutDefinition openXmlElement, String? value)
  {
    openXmlElement.MinVersion = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// defStyle
  /// </summary>
  private static String? GetDefaultStyle(DXDrawDgms.LayoutDefinition openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.DefaultStyle);
  }
  
  private static bool CmpDefaultStyle(DXDrawDgms.LayoutDefinition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.DefaultStyle, value, diffs, objName, "DefaultStyle");
  }
  
  private static void SetDefaultStyle(DXDrawDgms.LayoutDefinition openXmlElement, String? value)
  {
    openXmlElement.DefaultStyle = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMDrawsDgms.Title>? GetTitles(DXDrawDgms.LayoutDefinition openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Title>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Title>())
    {
      var newItem = DMXDrawsDgms.TitleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpTitles(DXDrawDgms.LayoutDefinition openXmlElement, Collection<DMDrawsDgms.Title>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawDgms.Title>();
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
        if (!DMXDrawsDgms.TitleConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetTitles(DXDrawDgms.LayoutDefinition openXmlElement, Collection<DMDrawsDgms.Title>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.Title>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.TitleConverter.CreateOpenXmlElement<DXDrawDgms.Title>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static Collection<DMDrawsDgms.Description>? GetDescriptions(DXDrawDgms.LayoutDefinition openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Description>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Description>())
    {
      var newItem = DMXDrawsDgms.DescriptionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpDescriptions(DXDrawDgms.LayoutDefinition openXmlElement, Collection<DMDrawsDgms.Description>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXDrawDgms.Description>();
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
        if (!DMXDrawsDgms.DescriptionConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetDescriptions(DXDrawDgms.LayoutDefinition openXmlElement, Collection<DMDrawsDgms.Description>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawDgms.Description>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsDgms.DescriptionConverter.CreateOpenXmlElement<DXDrawDgms.Description>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsDgms.CategoryList? GetCategoryList(DXDrawDgms.LayoutDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.CategoryList>();
    if (element != null)
      return DMXDrawsDgms.CategoryListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCategoryList(DXDrawDgms.LayoutDefinition openXmlElement, DMDrawsDgms.CategoryList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.CategoryListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.CategoryList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCategoryList(DXDrawDgms.LayoutDefinition openXmlElement, DMDrawsDgms.CategoryList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.CategoryList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.CategoryListConverter.CreateOpenXmlElement<DXDrawDgms.CategoryList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.SampleData? GetSampleData(DXDrawDgms.LayoutDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.SampleData>();
    if (element != null)
      return DMXDrawsDgms.SampleDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSampleData(DXDrawDgms.LayoutDefinition openXmlElement, DMDrawsDgms.SampleData? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.SampleDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.SampleData>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSampleData(DXDrawDgms.LayoutDefinition openXmlElement, DMDrawsDgms.SampleData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.SampleData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.SampleDataConverter.CreateOpenXmlElement<DXDrawDgms.SampleData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.StyleData? GetStyleData(DXDrawDgms.LayoutDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.StyleData>();
    if (element != null)
      return DMXDrawsDgms.StyleDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyleData(DXDrawDgms.LayoutDefinition openXmlElement, DMDrawsDgms.StyleData? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.StyleDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.StyleData>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStyleData(DXDrawDgms.LayoutDefinition openXmlElement, DMDrawsDgms.StyleData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.StyleData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.StyleDataConverter.CreateOpenXmlElement<DXDrawDgms.StyleData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.ColorData? GetColorData(DXDrawDgms.LayoutDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.ColorData>();
    if (element != null)
      return DMXDrawsDgms.ColorDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorData(DXDrawDgms.LayoutDefinition openXmlElement, DMDrawsDgms.ColorData? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.ColorDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.ColorData>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetColorData(DXDrawDgms.LayoutDefinition openXmlElement, DMDrawsDgms.ColorData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ColorData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.ColorDataConverter.CreateOpenXmlElement<DXDrawDgms.ColorData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.LayoutNode? GetLayoutNode(DXDrawDgms.LayoutDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.LayoutNode>();
    if (element != null)
      return DMXDrawsDgms.LayoutNodeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLayoutNode(DXDrawDgms.LayoutDefinition openXmlElement, DMDrawsDgms.LayoutNode? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.LayoutNodeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.LayoutNode>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLayoutNode(DXDrawDgms.LayoutDefinition openXmlElement, DMDrawsDgms.LayoutNode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.LayoutNode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.LayoutNodeConverter.CreateOpenXmlElement<DXDrawDgms.LayoutNode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.DiagramDefinitionExtensionList? GetDiagramDefinitionExtensionList(DXDrawDgms.LayoutDefinition openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawDgms.DiagramDefinitionExtensionList>();
    if (element != null)
      return DMXDrawsDgms.DiagramDefinitionExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDiagramDefinitionExtensionList(DXDrawDgms.LayoutDefinition openXmlElement, DMDrawsDgms.DiagramDefinitionExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsDgms.DiagramDefinitionExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawDgms.DiagramDefinitionExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDiagramDefinitionExtensionList(DXDrawDgms.LayoutDefinition openXmlElement, DMDrawsDgms.DiagramDefinitionExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.DiagramDefinitionExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsDgms.DiagramDefinitionExtensionListConverter.CreateOpenXmlElement<DXDrawDgms.DiagramDefinitionExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.LayoutDefinition? CreateModelElement(DXDrawDgms.LayoutDefinition? openXmlElement)
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
  
  public static bool CompareModelElement(DXDrawDgms.LayoutDefinition? openXmlElement, DMDrawsDgms.LayoutDefinition? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.LayoutDefinition value)
    where OpenXmlElementType: DXDrawDgms.LayoutDefinition, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.LayoutDefinition openXmlElement, DMDrawsDgms.LayoutDefinition value)
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
