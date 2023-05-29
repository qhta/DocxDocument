namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// <see cref="DMD.ListStyle"/> class from/to OpenXml converter.
/// </summary>
public static class ListStyleConverter
{
  #region Default Paragraph Style conversion.
  private static DMD.ParagraphProperties? GetDefaultParagraphProperties(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.DefaultParagraphProperties>();
    if (element != null)
      return DMXD.ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDefaultParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.DefaultParagraphProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetDefaultParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.DefaultParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.DefaultParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region List Level 1 Text Style conversion.
  private static DMD.ParagraphProperties? GetLevel1ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level1ParagraphProperties>();
    if (element != null)
      return DMXD.ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel1ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level1ParagraphProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetLevel1ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level1ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level1ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region List Level 2 Text Style conversion.
  private static DMD.ParagraphProperties? GetLevel2ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level2ParagraphProperties>();
    if (element != null)
      return DMXD.ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel2ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level2ParagraphProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetLevel2ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level2ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level2ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region List Level 3 Text Style conversion.
  private static DMD.ParagraphProperties? GetLevel3ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level3ParagraphProperties>();
    if (element != null)
      return DMXD.ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel3ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level3ParagraphProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetLevel3ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level3ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level3ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region List Level 4 Text Style conversion.
  private static DMD.ParagraphProperties? GetLevel4ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level4ParagraphProperties>();
    if (element != null)
      return DMXD.ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel4ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level4ParagraphProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetLevel4ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level4ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level4ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region List Level 5 Text Style conversion.
  private static DMD.ParagraphProperties? GetLevel5ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level5ParagraphProperties>();
    if (element != null)
      return DMXD.ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel5ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level5ParagraphProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetLevel5ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level5ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level5ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region List Level 6 Text Style conversion.
  private static DMD.ParagraphProperties? GetLevel6ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level6ParagraphProperties>();
    if (element != null)
      return DMXD.ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel6ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level6ParagraphProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetLevel6ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level6ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level6ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region List Level 7 Text Style conversion.
  private static DMD.ParagraphProperties? GetLevel7ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level7ParagraphProperties>();
    if (element != null)
      return DMXD.ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel7ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level7ParagraphProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetLevel7ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level7ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level7ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region List Level 8 Text Style conversion.
  private static DMD.ParagraphProperties? GetLevel8ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level8ParagraphProperties>();
    if (element != null)
      return DMXD.ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel8ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level8ParagraphProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetLevel8ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level8ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level8ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region List Level 9 Text Style conversion.
  private static DMD.ParagraphProperties? GetLevel9ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Level9ParagraphProperties>();
    if (element != null)
      return DMXD.ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLevel9ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Level9ParagraphProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetLevel9ParagraphProperties(DX.OpenXmlCompositeElement openXmlElement, DMD.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Level9ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.Level9ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ExtensionList conversion.
  private static DMD.ExtensionList? GetExtensionList(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DX.OpenXmlCompositeElement openXmlElement, DMD.ExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetExtensionList(DX.OpenXmlCompositeElement openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ListStyle model conversion.
  public static DMD.ListStyle? CreateModelElement(DX.OpenXmlCompositeElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ListStyle();
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
  
  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMD.ListStyle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDefaultParagraphProperties(openXmlElement, value.DefaultParagraphProperties, diffs, objName, propName))
        ok = false;
      if (!CmpLevel1ParagraphProperties(openXmlElement, value.Level1ParagraphProperties, diffs, objName, propName))
        ok = false;
      if (!CmpLevel2ParagraphProperties(openXmlElement, value.Level2ParagraphProperties, diffs, objName, propName))
        ok = false;
      if (!CmpLevel3ParagraphProperties(openXmlElement, value.Level3ParagraphProperties, diffs, objName, propName))
        ok = false;
      if (!CmpLevel4ParagraphProperties(openXmlElement, value.Level4ParagraphProperties, diffs, objName, propName))
        ok = false;
      if (!CmpLevel5ParagraphProperties(openXmlElement, value.Level5ParagraphProperties, diffs, objName, propName))
        ok = false;
      if (!CmpLevel6ParagraphProperties(openXmlElement, value.Level6ParagraphProperties, diffs, objName, propName))
        ok = false;
      if (!CmpLevel7ParagraphProperties(openXmlElement, value.Level7ParagraphProperties, diffs, objName, propName))
        ok = false;
      if (!CmpLevel8ParagraphProperties(openXmlElement, value.Level8ParagraphProperties, diffs, objName, propName))
        ok = false;
      if (!CmpLevel9ParagraphProperties(openXmlElement, value.Level9ParagraphProperties, diffs, objName, propName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ListStyle value)
    where OpenXmlElementType: DX.OpenXmlCompositeElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMD.ListStyle value)
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
  #endregion
}
