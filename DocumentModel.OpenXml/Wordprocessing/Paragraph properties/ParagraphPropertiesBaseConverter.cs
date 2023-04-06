namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Paragraph Properties.
/// </summary>
public static class ParagraphPropertiesBaseConverter
{
  #region ParagraphStyleId conversion.
  private static String? GetParagraphStyleId(DX.OpenXmlCompositeElement openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.ParagraphStyleId>()?.Val?.Value;
  }

  private static bool CmpParagraphStyleId(DX.OpenXmlCompositeElement openXmlElement, String? value, DiffList? diffs, string? objName)
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
      openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region DivId conversion.
  private static String? GetDivId(DX.OpenXmlCompositeElement openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DivId>()?.Val);
  }

  private static bool CmpDivId(DX.OpenXmlCompositeElement openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DivId>()?.Val, value, diffs, objName, "DivId");
  }

  private static void SetDivId(DX.OpenXmlCompositeElement openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.DivId>(openXmlElement, value);
  }
  #endregion

  #region ConditionalFormatStyle conversion.
  private static DMW.ConditionalFormatStyle? GetConditionalFormatStyle(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ConditionalFormatStyle>();
    if (element != null)
      return DMXW.ConditionalFormatStyleConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpConditionalFormatStyle(DX.OpenXmlCompositeElement openXmlElement, DMW.ConditionalFormatStyle? value, DiffList? diffs, string? objName)
  {
    return DMXW.ConditionalFormatStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ConditionalFormatStyle>(), value, diffs, objName);
  }

  private static void SetConditionalFormatStyle(DX.OpenXmlCompositeElement openXmlElement, DMW.ConditionalFormatStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ConditionalFormatStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ConditionalFormatStyleConverter.CreateOpenXmlElement<DXW.ConditionalFormatStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region ParagraphPropertiesBase model conversion.
  public static void UpdateModelElement(DMW.ExtBaseParagraphProperties value, DX.OpenXmlCompositeElement openXmlElement)
  {
    ParagraphPropertiesBaseStyleConverter.UpdateModelElement(value, openXmlElement);
    value.ParagraphStyleId = GetParagraphStyleId(openXmlElement);
    value.DivId = GetDivId(openXmlElement);
    value.ConditionalFormatStyle = GetConditionalFormatStyle(openXmlElement);
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.ExtBaseParagraphProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!ParagraphPropertiesBaseStyleConverter.CompareModelElement(openXmlElement, value, diffs, objName))
        ok = false;
      if (!CmpParagraphStyleId(openXmlElement, value.ParagraphStyleId, diffs, objName))
        ok = false;
      if (!CmpDivId(openXmlElement, value.DivId, diffs, objName))
        ok = false;
      if (!CmpConditionalFormatStyle(openXmlElement, value.ConditionalFormatStyle, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
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
    ParagraphPropertiesBaseStyleConverter.UpdateOpenXmlElement(openXmlElement, value);
    SetParagraphStyleId(openXmlElement, value?.ParagraphStyleId);
    SetDivId(openXmlElement, value?.DivId);
    SetConditionalFormatStyle(openXmlElement, value?.ConditionalFormatStyle);
  }
  #endregion

}
