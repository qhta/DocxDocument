namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Style Definition.
/// </summary>
public static class StyleDefinitionConverter
{
  /// <summary>
  /// Unique Style ID
  /// </summary>
  private static String? GetUniqueId(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement)
  {
    return openXmlElement?.UniqueId?.Value;
  }
  
  private static void SetUniqueId(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.UniqueId = new StringValue { Value = value };
    else
      openXmlElement.UniqueId = null;
  }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  private static String? GetMinVersion(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement)
  {
    return openXmlElement?.MinVersion?.Value;
  }
  
  private static void SetMinVersion(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MinVersion = new StringValue { Value = value };
    else
      openXmlElement.MinVersion = null;
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.StyleDefinitionTitle> GetStyleDefinitionTitles(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.StyleDefinitionTitle>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Diagrams.StyleDefinitionTitleConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetStyleDefinitionTitles(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.StyleDefinitionTitle>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.StyleDefinitionTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.StyleLabelDescription> GetStyleLabelDescriptions(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.StyleLabelDescription>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Diagrams.StyleLabelDescriptionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetStyleLabelDescriptions(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.StyleLabelDescription>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.StyleLabelDescriptionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Drawings.Diagrams.StyleDisplayCategories? GetStyleDisplayCategories(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.StyleDisplayCategoriesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStyleDisplayCategories(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement, DocumentModel.Drawings.Diagrams.StyleDisplayCategories? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.StyleDisplayCategoriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Diagrams.Scene3D? GetScene3D(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.Scene3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetScene3D(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement, DocumentModel.Drawings.Diagrams.Scene3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.Scene3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Diagrams.StyleLabel? GetStyleLabel(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.StyleLabelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStyleLabel(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement, DocumentModel.Drawings.Diagrams.StyleLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.StyleLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.StyleDefinition? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.StyleDefinition? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition, new()
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
