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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ColorTransformCategories>();
    if (itemElement != null)
      return DMXDrawsDgms.ColorTransformCategoriesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsDgms.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
