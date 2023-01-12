namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Layout Definition.
/// </summary>
public static class LayoutDefinitionConverter
{
  /// <summary>
  /// uniqueId
  /// </summary>
  public static String? GetUniqueId(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement)
  {
    return openXmlElement?.UniqueId?.Value;
  }
  
  public static void SetUniqueId(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UniqueId = new StringValue { Value = value };
      else
        openXmlElement.UniqueId = null;
  }
  
  /// <summary>
  /// minVer
  /// </summary>
  public static String? GetMinVersion(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement)
  {
    return openXmlElement?.MinVersion?.Value;
  }
  
  public static void SetMinVersion(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MinVersion = new StringValue { Value = value };
      else
        openXmlElement.MinVersion = null;
  }
  
  /// <summary>
  /// defStyle
  /// </summary>
  public static String? GetDefaultStyle(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement)
  {
    return openXmlElement?.DefaultStyle?.Value;
  }
  
  public static void SetDefaultStyle(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DefaultStyle = new StringValue { Value = value };
      else
        openXmlElement.DefaultStyle = null;
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Title>? GetTitles(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Title>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Title>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.TitleConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetTitles(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Title>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Title>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Diagrams.TitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Title>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Description>? GetDescriptions(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Description>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Description>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagrams.DescriptionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetDescriptions(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagrams.Description>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Description>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Diagrams.DescriptionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Description>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.CategoryList? GetCategoryList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.CategoryListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCategoryList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement, DocumentModel.Drawings.Diagrams.CategoryList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.CategoryListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.SampleData? GetSampleData(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.SampleData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.SampleDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSampleData(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement, DocumentModel.Drawings.Diagrams.SampleData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.SampleData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.SampleDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.SampleData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.StyleData? GetStyleData(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.StyleDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStyleData(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement, DocumentModel.Drawings.Diagrams.StyleData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.StyleDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.StyleData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ColorData? GetColorData(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ColorDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetColorData(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement, DocumentModel.Drawings.Diagrams.ColorData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ColorDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ColorData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.LayoutNode? GetLayoutNode(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.LayoutNodeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLayoutNode(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement, DocumentModel.Drawings.Diagrams.LayoutNode? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.LayoutNodeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.DiagramDefinitionExtensionList? GetDiagramDefinitionExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.DiagramDefinitionExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDiagramDefinitionExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement, DocumentModel.Drawings.Diagrams.DiagramDefinitionExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.DiagramDefinitionExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.LayoutDefinition? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.LayoutDefinition? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUniqueId(openXmlElement, value?.UniqueId);
      SetMinVersion(openXmlElement, value?.MinVersion);
      SetDefaultStyle(openXmlElement, value?.DefaultStyle);
      return openXmlElement;
    }
    return default;
  }
}
