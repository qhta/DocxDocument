namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.ExtBaseParagraphProperties"/> class from/to OpenXml converter.
/// </summary>
public static class ExtBaseParagraphPropertiesConverter
{
  #region ParagraphStyleId conversion.
  private static String? GetParagraphStyleId(DX.OpenXmlCompositeElement openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.ParagraphStyleId>()?.Val?.Value;
  }

  private static bool CmpParagraphStyleId(DX.OpenXmlCompositeElement openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphStyleId>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "ParagraphStyleId", itemElement?.Val?.Value, value);
    return false;
  }

  private static void SetParagraphStyleId(DX.OpenXmlCompositeElement openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphStyleId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.ParagraphStyleId { Val = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region DivId conversion.
  private static String? GetDivId(DX.OpenXmlCompositeElement openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DivId>()?.Val);
  }

  private static bool CmpDivId(DX.OpenXmlCompositeElement openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DivId>()?.Val, value, diffs, objName, "DivId");
  }

  private static void SetDivId(DX.OpenXmlCompositeElement openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.DivId>(openXmlElement, value);
  }
  #endregion

  #region ConditionalFormatStyle conversion.
  private static DMW.ConditionalFormatFlags? GetConditionalFormatStyle(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ConditionalFormatStyle>();
    if (element != null)
      return DMXW.ConditionalFormatStyleConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpConditionalFormatStyle(DX.OpenXmlCompositeElement openXmlElement, DMW.ConditionalFormatFlags? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.ConditionalFormatStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ConditionalFormatStyle>(), value, diffs, objName, propName);
  }

  private static void SetConditionalFormatStyle(DX.OpenXmlCompositeElement openXmlElement, DMW.ConditionalFormatFlags? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ConditionalFormatStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ConditionalFormatStyleConverter.CreateOpenXmlElement<DXW.ConditionalFormatStyle>((DMW.ConditionalFormatFlags)value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ExtBaseParagraphProperties model conversion.
  public static void UpdateModelElement(DMW.ExtBaseParagraphProperties value, DX.OpenXmlCompositeElement openXmlElement)
  {
    BaseParagraphPropertiesConverter.UpdateModelElement(value, openXmlElement);
    value.ParagraphStyleId = GetParagraphStyleId(openXmlElement);
    value.DivId = GetDivId(openXmlElement);
    value.ConditionalFormatStyle = GetConditionalFormatStyle(openXmlElement);
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.ExtBaseParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!BaseParagraphPropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName, propName))
        ok = false;
      if (!CmpParagraphStyleId(openXmlElement, value.ParagraphStyleId, diffs, objName, propName))
        ok = false;
      if (!CmpDivId(openXmlElement, value.DivId, diffs, objName, propName))
        ok = false;
      if (!CmpConditionalFormatStyle(openXmlElement, value.ConditionalFormatStyle, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ExtBaseParagraphProperties value)
    where OpenXmlElementType : DX.OpenXmlCompositeElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.ExtBaseParagraphProperties value)
  {
    BaseParagraphPropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
    SetParagraphStyleId(openXmlElement, value?.ParagraphStyleId);
    SetDivId(openXmlElement, value?.DivId);
    SetConditionalFormatStyle(openXmlElement, value?.ConditionalFormatStyle);
  }
  #endregion

}
