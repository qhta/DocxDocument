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
    return openXmlElement?.UniqueId?.Value;
  }
  
  private static void SetUniqueId(DXDrawDgms.StyleDefinition openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.UniqueId = new StringValue { Value = value };
    else
      openXmlElement.UniqueId = null;
  }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  private static String? GetMinVersion(DXDrawDgms.StyleDefinition openXmlElement)
  {
    return openXmlElement?.MinVersion?.Value;
  }
  
  private static void SetMinVersion(DXDrawDgms.StyleDefinition openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MinVersion = new StringValue { Value = value };
    else
      openXmlElement.MinVersion = null;
  }
  
  private static Collection<DMDrawsDgms.StyleDefinitionTitle> GetStyleDefinitionTitles(DXDrawDgms.StyleDefinition openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.StyleDefinitionTitle>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.StyleDefinitionTitle>())
    {
      var newItem = DMXDrawsDgms.StyleDefinitionTitleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
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
  
  private static Collection<DMDrawsDgms.StyleLabelDescription> GetStyleLabelDescriptions(DXDrawDgms.StyleDefinition openXmlElement)
  {
    var collection = new Collection<DMDrawsDgms.StyleLabelDescription>();
    foreach (var item in openXmlElement.Elements<DXDrawDgms.StyleLabelDescription>())
    {
      var newItem = DMXDrawsDgms.StyleLabelDescriptionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.StyleDisplayCategories>();
    if (itemElement != null)
      return DMXDrawsDgms.StyleDisplayCategoriesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.Scene3D>();
    if (itemElement != null)
      return DMXDrawsDgms.Scene3DConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.StyleLabel>();
    if (itemElement != null)
      return DMXDrawsDgms.StyleLabelConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsDgms.StyleDefinition? CreateModelElement(DXDrawDgms.StyleDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.StyleDefinition();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.StyleDefinition? value)
    where OpenXmlElementType: DXDrawDgms.StyleDefinition, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUniqueId(openXmlElement, value?.UniqueId);
      SetMinVersion(openXmlElement, value?.MinVersion);
      SetStyleDefinitionTitles(openXmlElement, value?.StyleDefinitionTitles);
      SetStyleLabelDescriptions(openXmlElement, value?.StyleLabelDescriptions);
      SetStyleDisplayCategories(openXmlElement, value?.StyleDisplayCategories);
      SetScene3D(openXmlElement, value?.Scene3D);
      SetStyleLabel(openXmlElement, value?.StyleLabel);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
