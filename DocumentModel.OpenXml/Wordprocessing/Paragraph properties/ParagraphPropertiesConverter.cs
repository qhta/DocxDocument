namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.ParagraphProperties"/> class from/to OpenXml converter.
/// </summary>
public static class ParagraphPropertiesConverter
{
  #region ParagraphMarkRunProperties conversion.
  public static DMW.ParagraphMarkRunProperties? GetParagraphMarkRunProperties(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ParagraphMarkRunProperties>();
    if (element != null)
      return DMXW.ParagraphMarkRunPropertiesConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpParagraphMarkRunProperties(DX.OpenXmlCompositeElement openXmlElement, DMW.ParagraphMarkRunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.ParagraphMarkRunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ParagraphMarkRunProperties>(), value, diffs, objName);
  }

  public static void SetParagraphMarkRunProperties(DX.OpenXmlCompositeElement openXmlElement, DMW.ParagraphMarkRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphMarkRunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ParagraphMarkRunPropertiesConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region SectionProperties conversion.
  public static DMW.SectionProperties? GetSectionProperties(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.SectionProperties>();
    if (element != null)
      return DMXW.SectionPropertiesConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpSectionProperties(DX.OpenXmlCompositeElement openXmlElement, DMW.SectionProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.SectionPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SectionProperties>(), value, diffs, objName);
  }

  public static void SetSectionProperties(DX.OpenXmlCompositeElement openXmlElement, DMW.SectionProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SectionProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SectionPropertiesConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion


  #region ParagraphPropertiesChange conversion.
  public static DMW.ParagraphPropertiesChange? GetParagraphPropertiesChange(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ParagraphPropertiesChange>();
    if (element != null)
      return DMXW.ParagraphPropertiesChangeConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpParagraphPropertiesChange(DX.OpenXmlCompositeElement openXmlElement, DMW.ParagraphPropertiesChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.ParagraphPropertiesChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ParagraphPropertiesChange>(), value, diffs, objName);
  }

  public static void SetParagraphPropertiesChange(DX.OpenXmlCompositeElement openXmlElement, DMW.ParagraphPropertiesChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphPropertiesChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ParagraphPropertiesChangeConverter.CreateOpenXmlElement<DXW.ParagraphPropertiesChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region ParagraphProperties model conversion.
  public static DMW.ParagraphProperties? CreateModelElement(DX.OpenXmlCompositeElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ParagraphProperties();
      UpdateModelElement(value, openXmlElement);
      return value;
    }
    return null;
  }

  public static void UpdateModelElement(DMW.ParagraphProperties value, DX.OpenXmlCompositeElement openXmlElement)
  {
    ExtBaseParagraphPropertiesConverter.UpdateModelElement(value, openXmlElement);
    value.ParagraphMarkRunProperties = GetParagraphMarkRunProperties(openXmlElement);
    value.SectionProperties = GetSectionProperties(openXmlElement);
    value.ParagraphPropertiesChange = GetParagraphPropertiesChange(openXmlElement);
  }

  public static bool CompareModelElement(DXW.ParagraphProperties? openXmlElement, DMW.ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!ExtBaseParagraphPropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName))
        ok = false;
      if (!CmpParagraphMarkRunProperties(openXmlElement, value.ParagraphMarkRunProperties, diffs, objName))
        ok = false;
      if (!CmpSectionProperties(openXmlElement, value.SectionProperties, diffs, objName))
        ok = false;
      if (!CmpParagraphPropertiesChange(openXmlElement, value.ParagraphPropertiesChange, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static DXW.ParagraphProperties CreateOpenXmlElement(DMW.ParagraphProperties value)
  {
    var openXmlElement = new DXW.ParagraphProperties();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.ParagraphProperties openXmlElement, DMW.ParagraphProperties value)
  {
    ExtBaseParagraphPropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
    SetParagraphMarkRunProperties(openXmlElement, value.ParagraphMarkRunProperties);
    SetSectionProperties(openXmlElement, value.SectionProperties);
    SetParagraphPropertiesChange(openXmlElement, value.ParagraphPropertiesChange);
  }
  #endregion
}
