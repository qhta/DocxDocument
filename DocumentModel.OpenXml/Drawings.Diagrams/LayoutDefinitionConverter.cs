using DocumentFormat.OpenXml.Drawing.Diagrams;
using CategoryList = DocumentModel.Drawings.Diagrams.CategoryList;
using ColorData = DocumentModel.Drawings.Diagrams.ColorData;
using Description = DocumentModel.Drawings.Diagrams.Description;
using DiagramDefinitionExtensionList = DocumentModel.Drawings.Diagrams.DiagramDefinitionExtensionList;
using LayoutNode = DocumentModel.Drawings.Diagrams.LayoutNode;
using SampleData = DocumentModel.Drawings.Diagrams.SampleData;
using StyleData = DocumentModel.Drawings.Diagrams.StyleData;
using Title = DocumentModel.Drawings.Diagrams.Title;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Layout Definition.
/// </summary>
public static class LayoutDefinitionConverter
{
  /// <summary>
  ///   uniqueId
  /// </summary>
  public static String? GetUniqueId(LayoutDefinition? openXmlElement)
  {
    return openXmlElement?.UniqueId?.Value;
  }

  public static void SetUniqueId(LayoutDefinition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UniqueId = new StringValue { Value = value };
      else
        openXmlElement.UniqueId = null;
  }

  /// <summary>
  ///   minVer
  /// </summary>
  public static String? GetMinVersion(LayoutDefinition? openXmlElement)
  {
    return openXmlElement?.MinVersion?.Value;
  }

  public static void SetMinVersion(LayoutDefinition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MinVersion = new StringValue { Value = value };
      else
        openXmlElement.MinVersion = null;
  }

  /// <summary>
  ///   defStyle
  /// </summary>
  public static String? GetDefaultStyle(LayoutDefinition? openXmlElement)
  {
    return openXmlElement?.DefaultStyle?.Value;
  }

  public static void SetDefaultStyle(LayoutDefinition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DefaultStyle = new StringValue { Value = value };
      else
        openXmlElement.DefaultStyle = null;
  }

  public static Collection<Title>? GetTitles(LayoutDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Title>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Title>())
      {
        var newItem = TitleConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetTitles(LayoutDefinition? openXmlElement, Collection<Title>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Title>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = TitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Title>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Collection<Description>? GetDescriptions(LayoutDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Description>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Description>())
      {
        var newItem = DescriptionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetDescriptions(LayoutDefinition? openXmlElement, Collection<Description>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Description>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = DescriptionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Description>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static CategoryList? GetCategoryList(LayoutDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList>();
    if (itemElement != null)
      return CategoryListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCategoryList(LayoutDefinition? openXmlElement, CategoryList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CategoryListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SampleData? GetSampleData(LayoutDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.SampleData>();
    if (itemElement != null)
      return SampleDataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSampleData(LayoutDefinition? openXmlElement, SampleData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.SampleData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SampleDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.SampleData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static StyleData? GetStyleData(LayoutDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleData>();
    if (itemElement != null)
      return StyleDataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStyleData(LayoutDefinition? openXmlElement, StyleData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.StyleData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ColorData? GetColorData(LayoutDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorData>();
    if (itemElement != null)
      return ColorDataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorData(LayoutDefinition? openXmlElement, ColorData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ColorData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LayoutNode? GetLayoutNode(LayoutDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
    if (itemElement != null)
      return LayoutNodeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLayoutNode(LayoutDefinition? openXmlElement, LayoutNode? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LayoutNodeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DiagramDefinitionExtensionList? GetDiagramDefinitionExtensionList(LayoutDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList>();
    if (itemElement != null)
      return DiagramDefinitionExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDiagramDefinitionExtensionList(LayoutDefinition? openXmlElement, DiagramDefinitionExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DiagramDefinitionExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramDefinitionExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.LayoutDefinition? CreateModelElement(LayoutDefinition? openXmlElement)
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
    where OpenXmlElementType : LayoutDefinition, new()
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