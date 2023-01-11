namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Style Definition.
/// </summary>
public static class StyleDefinitionConverter
{
  /// <summary>
  /// Unique Style ID
  /// </summary>
  public static String? GetUniqueId(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement)
  {
    return openXmlElement?.UniqueId?.Value;
  }
  
  public static void SetUniqueId(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement, String? value)
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
  public static String? GetMinVersion(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement)
  {
    return openXmlElement?.MinVersion?.Value;
  }
  
  public static void SetMinVersion(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MinVersion = new StringValue { Value = value };
      else
        openXmlElement.MinVersion = null;
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.StyleDefinitionTitle>? GetStyleDefinitionTitles(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetStyleDefinitionTitles(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.StyleDefinitionTitle>? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.StyleLabelDescription>? GetStyleLabelDescriptions(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetStyleLabelDescriptions(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.StyleLabelDescription>? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Diagrams.StyleDisplayCategories? GetStyleDisplayCategories(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.StyleDisplayCategoriesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStyleDisplayCategories(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement, DocumentModel.Drawings.Diagrams.StyleDisplayCategories? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Diagrams.Scene3D? GetScene3D(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.Scene3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetScene3D(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement, DocumentModel.Drawings.Diagrams.Scene3D? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Diagrams.StyleLabel? GetStyleLabel(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.StyleLabelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStyleLabel(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement, DocumentModel.Drawings.Diagrams.StyleLabel? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
