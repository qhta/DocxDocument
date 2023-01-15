using DocumentModel.Drawings;
using ListStyle = DocumentFormat.OpenXml.Drawing.ListStyle;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ListStyle Class.
/// </summary>
public static class ListStyleConverter
{
  /// <summary>
  ///   Default Paragraph Style.
  /// </summary>
  public static DefaultParagraphProperties? GetDefaultParagraphProperties(ListStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties>();
    if (itemElement != null)
      return DefaultParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDefaultParagraphProperties(ListStyle? openXmlElement, DefaultParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DefaultParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   List Level 1 Text Style.
  /// </summary>
  public static Level1ParagraphProperties? GetLevel1ParagraphProperties(ListStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties>();
    if (itemElement != null)
      return Level1ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLevel1ParagraphProperties(ListStyle? openXmlElement, Level1ParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level1ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   List Level 2 Text Style.
  /// </summary>
  public static Level2ParagraphProperties? GetLevel2ParagraphProperties(ListStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties>();
    if (itemElement != null)
      return Level2ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLevel2ParagraphProperties(ListStyle? openXmlElement, Level2ParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level2ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   List Level 3 Text Style.
  /// </summary>
  public static Level3ParagraphProperties? GetLevel3ParagraphProperties(ListStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties>();
    if (itemElement != null)
      return Level3ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLevel3ParagraphProperties(ListStyle? openXmlElement, Level3ParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level3ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   List Level 4 Text Style.
  /// </summary>
  public static Level4ParagraphProperties? GetLevel4ParagraphProperties(ListStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties>();
    if (itemElement != null)
      return Level4ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLevel4ParagraphProperties(ListStyle? openXmlElement, Level4ParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level4ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   List Level 5 Text Style.
  /// </summary>
  public static Level5ParagraphProperties? GetLevel5ParagraphProperties(ListStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties>();
    if (itemElement != null)
      return Level5ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLevel5ParagraphProperties(ListStyle? openXmlElement, Level5ParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level5ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   List Level 6 Text Style.
  /// </summary>
  public static Level6ParagraphProperties? GetLevel6ParagraphProperties(ListStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties>();
    if (itemElement != null)
      return Level6ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLevel6ParagraphProperties(ListStyle? openXmlElement, Level6ParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level6ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   List Level 7 Text Style.
  /// </summary>
  public static Level7ParagraphProperties? GetLevel7ParagraphProperties(ListStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties>();
    if (itemElement != null)
      return Level7ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLevel7ParagraphProperties(ListStyle? openXmlElement, Level7ParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level7ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   List Level 8 Text Style.
  /// </summary>
  public static Level8ParagraphProperties? GetLevel8ParagraphProperties(ListStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties>();
    if (itemElement != null)
      return Level8ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLevel8ParagraphProperties(ListStyle? openXmlElement, Level8ParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level8ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   List Level 9 Text Style.
  /// </summary>
  public static Level9ParagraphProperties? GetLevel9ParagraphProperties(ListStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties>();
    if (itemElement != null)
      return Level9ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLevel9ParagraphProperties(ListStyle? openXmlElement, Level9ParagraphProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Level9ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(ListStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(ListStyle? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ListStyle? CreateModelElement(ListStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ListStyle();
      value.DefaultParagraphProperties = GetDefaultParagraphProperties(openXmlElement);
      value.Level1ParagraphProperties = GetLevel1ParagraphProperties(openXmlElement);
      value.Level2ParagraphProperties = GetLevel2ParagraphProperties(openXmlElement);
      value.Level3ParagraphProperties = GetLevel3ParagraphProperties(openXmlElement);
      value.Level4ParagraphProperties = GetLevel4ParagraphProperties(openXmlElement);
      value.Level5ParagraphProperties = GetLevel5ParagraphProperties(openXmlElement);
      value.Level6ParagraphProperties = GetLevel6ParagraphProperties(openXmlElement);
      value.Level7ParagraphProperties = GetLevel7ParagraphProperties(openXmlElement);
      value.Level8ParagraphProperties = GetLevel8ParagraphProperties(openXmlElement);
      value.Level9ParagraphProperties = GetLevel9ParagraphProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ListStyle? value)
    where OpenXmlElementType : ListStyle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDefaultParagraphProperties(openXmlElement, value?.DefaultParagraphProperties);
      SetLevel1ParagraphProperties(openXmlElement, value?.Level1ParagraphProperties);
      SetLevel2ParagraphProperties(openXmlElement, value?.Level2ParagraphProperties);
      SetLevel3ParagraphProperties(openXmlElement, value?.Level3ParagraphProperties);
      SetLevel4ParagraphProperties(openXmlElement, value?.Level4ParagraphProperties);
      SetLevel5ParagraphProperties(openXmlElement, value?.Level5ParagraphProperties);
      SetLevel6ParagraphProperties(openXmlElement, value?.Level6ParagraphProperties);
      SetLevel7ParagraphProperties(openXmlElement, value?.Level7ParagraphProperties);
      SetLevel8ParagraphProperties(openXmlElement, value?.Level8ParagraphProperties);
      SetLevel9ParagraphProperties(openXmlElement, value?.Level9ParagraphProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}