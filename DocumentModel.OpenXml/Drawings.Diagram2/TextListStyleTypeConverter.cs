namespace DocumentModel.OpenXml.Drawings.Diagram2;

/// <summary>
/// Defines the TextListStyleType Class.
/// </summary>
public static class TextListStyleTypeConverter
{
  /// <summary>
  /// Default Paragraph Style.
  /// </summary>
  private static DMD.DefaultParagraphProperties? GetDefaultParagraphProperties(DXO19DD12.TextListStyleType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.DefaultParagraphProperties>();
    if (element != null)
      return DMXD.DefaultParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDefaultParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.DefaultParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.DefaultParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.DefaultParagraphProperties>(), value, diffs, objName);
  }
  
  private static void SetDefaultParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.DefaultParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.DefaultParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.DefaultParagraphPropertiesConverter.CreateOpenXmlElement<DXD.DefaultParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 1 Text Style.
  /// </summary>
  private static DMD.Level1ParagraphProperties? GetLevel1ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level1ParagraphProperties>();
    if (element != null)
      return DMXD.Level1ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel1ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level1ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.Level1ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level1ParagraphProperties>(), value, diffs, objName);
  }
  
  private static void SetLevel1ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level1ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level1ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Level1ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level1ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 2 Text Style.
  /// </summary>
  private static DMD.Level2ParagraphProperties? GetLevel2ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level2ParagraphProperties>();
    if (element != null)
      return DMXD.Level2ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel2ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level2ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.Level2ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level2ParagraphProperties>(), value, diffs, objName);
  }
  
  private static void SetLevel2ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level2ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level2ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Level2ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level2ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 3 Text Style.
  /// </summary>
  private static DMD.Level3ParagraphProperties? GetLevel3ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level3ParagraphProperties>();
    if (element != null)
      return DMXD.Level3ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel3ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level3ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.Level3ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level3ParagraphProperties>(), value, diffs, objName);
  }
  
  private static void SetLevel3ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level3ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level3ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Level3ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level3ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 4 Text Style.
  /// </summary>
  private static DMD.Level4ParagraphProperties? GetLevel4ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level4ParagraphProperties>();
    if (element != null)
      return DMXD.Level4ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel4ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level4ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.Level4ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level4ParagraphProperties>(), value, diffs, objName);
  }
  
  private static void SetLevel4ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level4ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level4ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Level4ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level4ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 5 Text Style.
  /// </summary>
  private static DMD.Level5ParagraphProperties? GetLevel5ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level5ParagraphProperties>();
    if (element != null)
      return DMXD.Level5ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel5ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level5ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.Level5ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level5ParagraphProperties>(), value, diffs, objName);
  }
  
  private static void SetLevel5ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level5ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level5ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Level5ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level5ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 6 Text Style.
  /// </summary>
  private static DMD.Level6ParagraphProperties? GetLevel6ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level6ParagraphProperties>();
    if (element != null)
      return DMXD.Level6ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel6ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level6ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.Level6ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level6ParagraphProperties>(), value, diffs, objName);
  }
  
  private static void SetLevel6ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level6ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level6ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Level6ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level6ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 7 Text Style.
  /// </summary>
  private static DMD.Level7ParagraphProperties? GetLevel7ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level7ParagraphProperties>();
    if (element != null)
      return DMXD.Level7ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel7ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level7ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.Level7ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level7ParagraphProperties>(), value, diffs, objName);
  }
  
  private static void SetLevel7ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level7ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level7ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Level7ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level7ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 8 Text Style.
  /// </summary>
  private static DMD.Level8ParagraphProperties? GetLevel8ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level8ParagraphProperties>();
    if (element != null)
      return DMXD.Level8ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel8ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level8ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.Level8ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level8ParagraphProperties>(), value, diffs, objName);
  }
  
  private static void SetLevel8ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level8ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level8ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Level8ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level8ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// List Level 9 Text Style.
  /// </summary>
  private static DMD.Level9ParagraphProperties? GetLevel9ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level9ParagraphProperties>();
    if (element != null)
      return DMXD.Level9ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel9ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level9ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.Level9ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level9ParagraphProperties>(), value, diffs, objName);
  }
  
  private static void SetLevel9ParagraphProperties(DXO19DD12.TextListStyleType openXmlElement, DMD.Level9ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level9ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Level9ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level9ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXO19DD12.TextListStyleType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO19DD12.TextListStyleType openXmlElement, DMD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXO19DD12.TextListStyleType openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagram2.TextListStyleType? CreateModelElement(DXO19DD12.TextListStyleType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagram2.TextListStyleType();
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
  
  public static bool CompareModelElement(DXO19DD12.TextListStyleType? openXmlElement, DMDD2.TextListStyleType? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD2.TextListStyleType value)
    where OpenXmlElementType: DXO19DD12.TextListStyleType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO19DD12.TextListStyleType openXmlElement, DMDD2.TextListStyleType value)
  {
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
  }
}
