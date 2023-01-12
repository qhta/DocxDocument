namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Color Transform Definitions.
/// </summary>
public static class ColorsDefinitionConverter
{
  /// <summary>
  /// Unique ID
  /// </summary>
  public static String? GetUniqueId(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? openXmlElement)
  {
    return openXmlElement?.UniqueId?.Value;
  }
  
  public static void SetUniqueId(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UniqueId = new StringValue { Value = value };
      else
        openXmlElement.UniqueId = null;
  }
  
  /// <summary>
  /// Minimum Version
  /// </summary>
  public static String? GetMinVersion(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? openXmlElement)
  {
    return openXmlElement?.MinVersion?.Value;
  }
  
  public static void SetMinVersion(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MinVersion = new StringValue { Value = value };
      else
        openXmlElement.MinVersion = null;
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.ColorDefinitionTitle>? GetColorDefinitionTitles(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.ColorDefinitionTitle>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.ColorDefinitionTitleConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetColorDefinitionTitles(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.ColorDefinitionTitle>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Diagrams.ColorDefinitionTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.ColorTransformDescription>? GetColorTransformDescriptions(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.ColorTransformDescription>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.ColorTransformDescriptionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetColorTransformDescriptions(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.ColorTransformDescription>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Diagrams.ColorTransformDescriptionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ColorTransformCategories? GetColorTransformCategories(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ColorTransformCategoriesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColorTransformCategories(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? openXmlElement, DocumentModel.Drawings.Diagrams.ColorTransformCategories? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ColorTransformCategoriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel>? GetColorTransformStyleLabels(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.ColorTransformStyleLabelConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetColorTransformStyleLabels(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Diagrams.ColorTransformStyleLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Diagrams.ColorsDefinition? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.ColorsDefinition? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUniqueId(openXmlElement, value?.UniqueId);
      SetMinVersion(openXmlElement, value?.MinVersion);
      return openXmlElement;
    }
    return default;
  }
}
