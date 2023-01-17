namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ListStyle Class.
/// </summary>
public static class ListStyleConverter
{
  /// <summary>
  /// Default Paragraph Style.
  /// </summary>
  private static DocumentModel.Drawings.DefaultParagraphProperties? GetDefaultParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.DefaultParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDefaultParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement, DocumentModel.Drawings.DefaultParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.DefaultParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 1 Text Style.
  /// </summary>
  private static DocumentModel.Drawings.Level1ParagraphProperties? GetLevel1ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Level1ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel1ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement, DocumentModel.Drawings.Level1ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Level1ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 2 Text Style.
  /// </summary>
  private static DocumentModel.Drawings.Level2ParagraphProperties? GetLevel2ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Level2ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel2ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement, DocumentModel.Drawings.Level2ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Level2ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 3 Text Style.
  /// </summary>
  private static DocumentModel.Drawings.Level3ParagraphProperties? GetLevel3ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Level3ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel3ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement, DocumentModel.Drawings.Level3ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Level3ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 4 Text Style.
  /// </summary>
  private static DocumentModel.Drawings.Level4ParagraphProperties? GetLevel4ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Level4ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel4ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement, DocumentModel.Drawings.Level4ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Level4ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 5 Text Style.
  /// </summary>
  private static DocumentModel.Drawings.Level5ParagraphProperties? GetLevel5ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Level5ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel5ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement, DocumentModel.Drawings.Level5ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Level5ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 6 Text Style.
  /// </summary>
  private static DocumentModel.Drawings.Level6ParagraphProperties? GetLevel6ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Level6ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel6ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement, DocumentModel.Drawings.Level6ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Level6ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 7 Text Style.
  /// </summary>
  private static DocumentModel.Drawings.Level7ParagraphProperties? GetLevel7ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Level7ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel7ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement, DocumentModel.Drawings.Level7ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Level7ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 8 Text Style.
  /// </summary>
  private static DocumentModel.Drawings.Level8ParagraphProperties? GetLevel8ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Level8ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel8ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement, DocumentModel.Drawings.Level8ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Level8ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 9 Text Style.
  /// </summary>
  private static DocumentModel.Drawings.Level9ParagraphProperties? GetLevel9ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Level9ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel9ParagraphProperties(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement, DocumentModel.Drawings.Level9ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Level9ParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.ListStyle openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ListStyle? CreateModelElement(DocumentFormat.OpenXml.Drawing.ListStyle? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ListStyle, new()
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
