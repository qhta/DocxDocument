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
    return openXmlElement?.UniqueId?.Value;
  }
  
  private static void SetUniqueId(DXDrawDgms.LayoutDefinition openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.UniqueId = new StringValue { Value = value };
    else
      openXmlElement.UniqueId = null;
  }
  
  /// <summary>
  /// minVer
  /// </summary>
  private static String? GetMinVersion(DXDrawDgms.LayoutDefinition openXmlElement)
  {
    return openXmlElement?.MinVersion?.Value;
  }
  
  private static void SetMinVersion(DXDrawDgms.LayoutDefinition openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MinVersion = new StringValue { Value = value };
    else
      openXmlElement.MinVersion = null;
  }
  
  /// <summary>
  /// defStyle
  /// </summary>
  private static String? GetDefaultStyle(DXDrawDgms.LayoutDefinition openXmlElement)
  {
    return openXmlElement?.DefaultStyle?.Value;
  }
  
  private static void SetDefaultStyle(DXDrawDgms.LayoutDefinition openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DefaultStyle = new StringValue { Value = value };
    else
      openXmlElement.DefaultStyle = null;
  }
  
  private static Collection<DMDrawsDgms.Title> GetTitles(DXDrawDgms.LayoutDefinition openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Title>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Title>())
    {
      var newItem = DMXDrawsDgms.TitleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
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
  
  private static Collection<DMDrawsDgms.Description> GetDescriptions(DXDrawDgms.LayoutDefinition openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.Description>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.Description>())
    {
      var newItem = DMXDrawsDgms.DescriptionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.CategoryList>();
    if (itemElement != null)
      return DMXDrawsDgms.CategoryListConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.SampleData>();
    if (itemElement != null)
      return DMXDrawsDgms.SampleDataConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.StyleData>();
    if (itemElement != null)
      return DMXDrawsDgms.StyleDataConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ColorData>();
    if (itemElement != null)
      return DMXDrawsDgms.ColorDataConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.LayoutNode>();
    if (itemElement != null)
      return DMXDrawsDgms.LayoutNodeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.DiagramDefinitionExtensionList>();
    if (itemElement != null)
      return DMXDrawsDgms.DiagramDefinitionExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsDgms.LayoutDefinition? CreateModelElement(DXDrawDgms.LayoutDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.LayoutDefinition();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.LayoutDefinition? value)
    where OpenXmlElementType: DXDrawDgms.LayoutDefinition, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
