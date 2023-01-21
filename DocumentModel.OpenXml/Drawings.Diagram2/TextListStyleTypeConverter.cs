namespace DocumentModel.OpenXml.Drawings.Diagram2;

/// <summary>
/// Defines the TextListStyleType Class.
/// </summary>
public static class TextListStyleTypeConverter
{
  /// <summary>
  /// Default Paragraph Style.
  /// </summary>
  private static DMDraws.DefaultParagraphProperties? GetDefaultParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.DefaultParagraphProperties>();
    if (itemElement != null)
      return DMXDraws.DefaultParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDefaultParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.DefaultParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.DefaultParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.DefaultParagraphPropertiesConverter.CreateOpenXmlElement<DXDraw.DefaultParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 1 Text Style.
  /// </summary>
  private static DMDraws.Level1ParagraphProperties? GetLevel1ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Level1ParagraphProperties>();
    if (itemElement != null)
      return DMXDraws.Level1ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel1ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level1ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Level1ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Level1ParagraphPropertiesConverter.CreateOpenXmlElement<DXDraw.Level1ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 2 Text Style.
  /// </summary>
  private static DMDraws.Level2ParagraphProperties? GetLevel2ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Level2ParagraphProperties>();
    if (itemElement != null)
      return DMXDraws.Level2ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel2ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level2ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Level2ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Level2ParagraphPropertiesConverter.CreateOpenXmlElement<DXDraw.Level2ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 3 Text Style.
  /// </summary>
  private static DMDraws.Level3ParagraphProperties? GetLevel3ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Level3ParagraphProperties>();
    if (itemElement != null)
      return DMXDraws.Level3ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel3ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level3ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Level3ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Level3ParagraphPropertiesConverter.CreateOpenXmlElement<DXDraw.Level3ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 4 Text Style.
  /// </summary>
  private static DMDraws.Level4ParagraphProperties? GetLevel4ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Level4ParagraphProperties>();
    if (itemElement != null)
      return DMXDraws.Level4ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel4ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level4ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Level4ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Level4ParagraphPropertiesConverter.CreateOpenXmlElement<DXDraw.Level4ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 5 Text Style.
  /// </summary>
  private static DMDraws.Level5ParagraphProperties? GetLevel5ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Level5ParagraphProperties>();
    if (itemElement != null)
      return DMXDraws.Level5ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel5ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level5ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Level5ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Level5ParagraphPropertiesConverter.CreateOpenXmlElement<DXDraw.Level5ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 6 Text Style.
  /// </summary>
  private static DMDraws.Level6ParagraphProperties? GetLevel6ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Level6ParagraphProperties>();
    if (itemElement != null)
      return DMXDraws.Level6ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel6ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level6ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Level6ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Level6ParagraphPropertiesConverter.CreateOpenXmlElement<DXDraw.Level6ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 7 Text Style.
  /// </summary>
  private static DMDraws.Level7ParagraphProperties? GetLevel7ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Level7ParagraphProperties>();
    if (itemElement != null)
      return DMXDraws.Level7ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel7ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level7ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Level7ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Level7ParagraphPropertiesConverter.CreateOpenXmlElement<DXDraw.Level7ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 8 Text Style.
  /// </summary>
  private static DMDraws.Level8ParagraphProperties? GetLevel8ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Level8ParagraphProperties>();
    if (itemElement != null)
      return DMXDraws.Level8ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel8ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level8ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Level8ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Level8ParagraphPropertiesConverter.CreateOpenXmlElement<DXDraw.Level8ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 9 Text Style.
  /// </summary>
  private static DMDraws.Level9ParagraphProperties? GetLevel9ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Level9ParagraphProperties>();
    if (itemElement != null)
      return DMXDraws.Level9ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLevel9ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level9ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Level9ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Level9ParagraphPropertiesConverter.CreateOpenXmlElement<DXDraw.Level9ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXO2019DrawDgm12.TextListStyleType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgm2.TextListStyleType? CreateModelElement(DXO2019DrawDgm12.TextListStyleType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgm2.TextListStyleType();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgm2.TextListStyleType? value)
    where OpenXmlElementType: DXO2019DrawDgm12.TextListStyleType, new()
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
