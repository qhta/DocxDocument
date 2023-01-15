using DocumentFormat.OpenXml.Drawing.Diagrams;
using Scene3D = DocumentModel.Drawings.Diagrams.Scene3D;
using StyleDefinitionTitle = DocumentModel.Drawings.Diagrams.StyleDefinitionTitle;
using StyleDisplayCategories = DocumentModel.Drawings.Diagrams.StyleDisplayCategories;
using StyleLabel = DocumentModel.Drawings.Diagrams.StyleLabel;
using StyleLabelDescription = DocumentModel.Drawings.Diagrams.StyleLabelDescription;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Style Definition.
/// </summary>
public static class StyleDefinitionConverter
{
  /// <summary>
  ///   Unique Style ID
  /// </summary>
  public static String? GetUniqueId(StyleDefinition? openXmlElement)
  {
    return openXmlElement?.UniqueId?.Value;
  }

  public static void SetUniqueId(StyleDefinition? openXmlElement, String? value)
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
  public static String? GetMinVersion(StyleDefinition? openXmlElement)
  {
    return openXmlElement?.MinVersion?.Value;
  }

  public static void SetMinVersion(StyleDefinition? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MinVersion = new StringValue { Value = value };
      else
        openXmlElement.MinVersion = null;
  }

  public static Collection<StyleDefinitionTitle>? GetStyleDefinitionTitles(StyleDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<StyleDefinitionTitle>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle>())
      {
        var newItem = StyleDefinitionTitleConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetStyleDefinitionTitles(StyleDefinition? openXmlElement, Collection<StyleDefinitionTitle>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StyleDefinitionTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static Collection<StyleLabelDescription>? GetStyleLabelDescriptions(StyleDefinition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<StyleLabelDescription>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription>())
      {
        var newItem = StyleLabelDescriptionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetStyleLabelDescriptions(StyleDefinition? openXmlElement, Collection<StyleLabelDescription>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StyleLabelDescriptionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static StyleDisplayCategories? GetStyleDisplayCategories(StyleDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories>();
    if (itemElement != null)
      return StyleDisplayCategoriesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStyleDisplayCategories(StyleDefinition? openXmlElement, StyleDisplayCategories? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleDisplayCategoriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Scene3D? GetScene3D(StyleDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>();
    if (itemElement != null)
      return Scene3DConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetScene3D(StyleDefinition? openXmlElement, Scene3D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Scene3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static StyleLabel? GetStyleLabel(StyleDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel>();
    if (itemElement != null)
      return StyleLabelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStyleLabel(StyleDefinition? openXmlElement, StyleLabel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(StyleDefinition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(StyleDefinition? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
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

  public static DocumentModel.Drawings.Diagrams.StyleDefinition? CreateModelElement(StyleDefinition? openXmlElement)
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
    where OpenXmlElementType : StyleDefinition, new()
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