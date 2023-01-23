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
    return DMXDraws.DefaultParagraphPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.DefaultParagraphProperties>());
  }
  
  private static bool CmpDefaultParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.DefaultParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.DefaultParagraphPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.DefaultParagraphProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.Level1ParagraphPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Level1ParagraphProperties>());
  }
  
  private static bool CmpLevel1ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level1ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Level1ParagraphPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Level1ParagraphProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.Level2ParagraphPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Level2ParagraphProperties>());
  }
  
  private static bool CmpLevel2ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level2ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Level2ParagraphPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Level2ParagraphProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.Level3ParagraphPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Level3ParagraphProperties>());
  }
  
  private static bool CmpLevel3ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level3ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Level3ParagraphPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Level3ParagraphProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.Level4ParagraphPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Level4ParagraphProperties>());
  }
  
  private static bool CmpLevel4ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level4ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Level4ParagraphPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Level4ParagraphProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.Level5ParagraphPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Level5ParagraphProperties>());
  }
  
  private static bool CmpLevel5ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level5ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Level5ParagraphPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Level5ParagraphProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.Level6ParagraphPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Level6ParagraphProperties>());
  }
  
  private static bool CmpLevel6ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level6ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Level6ParagraphPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Level6ParagraphProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.Level7ParagraphPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Level7ParagraphProperties>());
  }
  
  private static bool CmpLevel7ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level7ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Level7ParagraphPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Level7ParagraphProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.Level8ParagraphPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Level8ParagraphProperties>());
  }
  
  private static bool CmpLevel8ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level8ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Level8ParagraphPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Level8ParagraphProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.Level9ParagraphPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Level9ParagraphProperties>());
  }
  
  private static bool CmpLevel9ParagraphProperties(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.Level9ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Level9ParagraphPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Level9ParagraphProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.ExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>());
  }
  
  private static bool CmpExtensionList(DXO2019DrawDgm12.TextListStyleType openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXO2019DrawDgm12.TextListStyleType? openXmlElement, DMDrawsDgm2.TextListStyleType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDefaultParagraphProperties(openXmlElement, value.DefaultParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpLevel1ParagraphProperties(openXmlElement, value.Level1ParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpLevel2ParagraphProperties(openXmlElement, value.Level2ParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpLevel3ParagraphProperties(openXmlElement, value.Level3ParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpLevel4ParagraphProperties(openXmlElement, value.Level4ParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpLevel5ParagraphProperties(openXmlElement, value.Level5ParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpLevel6ParagraphProperties(openXmlElement, value.Level6ParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpLevel7ParagraphProperties(openXmlElement, value.Level7ParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpLevel8ParagraphProperties(openXmlElement, value.Level8ParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpLevel9ParagraphProperties(openXmlElement, value.Level9ParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
