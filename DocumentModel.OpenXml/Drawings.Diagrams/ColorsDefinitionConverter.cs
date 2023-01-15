using DocumentFormat.OpenXml.Drawing.Diagrams;
using ColorDefinitionTitle = DocumentModel.Drawings.Diagrams.ColorDefinitionTitle;
using ColorTransformCategories = DocumentModel.Drawings.Diagrams.ColorTransformCategories;
using ColorTransformDescription = DocumentModel.Drawings.Diagrams.ColorTransformDescription;
using ColorTransformStyleLabel = DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Color Transform Definitions.
/// </summary>
public static class ColorsDefinitionConverter
{
  /// <summary>
  ///   Unique ID
  /// </summary>
  public static String? GetUniqueId(ColorsDefinition? openXmlElement)
  {
    return openXmlElement?.UniqueId?.Value;
  }

  public static void SetUniqueId(ColorsDefinition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UniqueId = new StringValue { Value = value };
      else
        openXmlElement.UniqueId = null;
  }

  /// <summary>
  ///   Minimum Version
  /// </summary>
  public static String? GetMinVersion(ColorsDefinition? openXmlElement)
  {
    return openXmlElement?.MinVersion?.Value;
  }

  public static void SetMinVersion(ColorsDefinition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MinVersion = new StringValue { Value = value };
      else
        openXmlElement.MinVersion = null;
  }

  public static Collection<ColorDefinitionTitle>? GetColorDefinitionTitles(ColorsDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ColorDefinitionTitle>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle>())
      {
        var newItem = ColorDefinitionTitleConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetColorDefinitionTitles(ColorsDefinition? openXmlElement, Collection<ColorDefinitionTitle>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ColorDefinitionTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Collection<ColorTransformDescription>? GetColorTransformDescriptions(ColorsDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ColorTransformDescription>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription>())
      {
        var newItem = ColorTransformDescriptionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetColorTransformDescriptions(ColorsDefinition? openXmlElement, Collection<ColorTransformDescription>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ColorTransformDescriptionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static ColorTransformCategories? GetColorTransformCategories(ColorsDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories>();
    if (itemElement != null)
      return ColorTransformCategoriesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorTransformCategories(ColorsDefinition? openXmlElement, ColorTransformCategories? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorTransformCategoriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<ColorTransformStyleLabel>? GetColorTransformStyleLabels(ColorsDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ColorTransformStyleLabel>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel>())
      {
        var newItem = ColorTransformStyleLabelConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetColorTransformStyleLabels(ColorsDefinition? openXmlElement, Collection<ColorTransformStyleLabel>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ColorTransformStyleLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(ColorsDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(ColorsDefinition? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.ColorsDefinition? CreateModelElement(ColorsDefinition? openXmlElement)
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
    where OpenXmlElementType : ColorsDefinition, new()
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