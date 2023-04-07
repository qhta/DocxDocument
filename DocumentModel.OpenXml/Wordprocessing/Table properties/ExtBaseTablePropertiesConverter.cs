namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.ExtBaseTableProperties"/> class from/to OpenXml converter.
/// </summary>
public static class ExtBaseTablePropertiesConverter
{
  #region TableStyle conversion.
  private static String? GetTableStyle(DX.OpenXmlCompositeElement openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.TableStyle>()?.Val);
  }

  private static bool CmpTableStyle(DX.OpenXmlCompositeElement openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.TableStyle>()?.Val, value, diffs, objName, "TableStyle");
  }

  private static void SetTableStyle(DX.OpenXmlCompositeElement openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.TableStyle>(openXmlElement, value);
  }
  #endregion

  #region TablePositionProperties conversion.
  private static DMW.TablePositionProperties? GetTablePositionProperties(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TablePositionProperties>();
    if (element != null)
      return DMXW.TablePositionPropertiesConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpTablePositionProperties(DX.OpenXmlCompositeElement openXmlElement, DMW.TablePositionProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.TablePositionPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TablePositionProperties>(), value, diffs, objName);
  }

  private static void SetTablePositionProperties(DX.OpenXmlCompositeElement openXmlElement, DMW.TablePositionProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TablePositionProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TablePositionPropertiesConverter.CreateOpenXmlElement<DXW.TablePositionProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TableOverlap conversion.
  private static DMW.TableOverlapKind? GetTableOverlap(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues, DMW.TableOverlapKind>(openXmlElement.GetFirstChild<DXW.TableOverlap>()?.Val?.Value);
  }

  private static bool CmpTableOverlap(DX.OpenXmlCompositeElement openXmlElement, DMW.TableOverlapKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues, DMW.TableOverlapKind>(openXmlElement.GetFirstChild<DXW.TableOverlap>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetTableOverlap(DX.OpenXmlCompositeElement openXmlElement, DMW.TableOverlapKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableOverlap>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues, DMW.TableOverlapKind>(itemElement, (DMW.TableOverlapKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableOverlap, DocumentFormat.OpenXml.Wordprocessing.TableOverlapValues, DMW.TableOverlapKind>((DMW.TableOverlapKind)value));
  }
  #endregion

  #region BiDiVisual conversion.
  private static Boolean GetBiDiVisual(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.BiDiVisual>());
  }

  private static bool CmpBiDiVisual(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.BiDiVisual>(), value, diffs, objName);
  }

  private static void SetBiDiVisual(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.BiDiVisual>(openXmlElement, value);
  }
  #endregion

  #region TableCaption conversion.
  private static String? GetTableCaption(DX.OpenXmlCompositeElement openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.TableCaption>()?.Val?.Value;
  }

  private static bool CmpTableCaption(DX.OpenXmlCompositeElement openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCaption>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "TableCaption", itemElement?.Val?.Value, value);
    return false;
  }

  private static void SetTableCaption(DX.OpenXmlCompositeElement openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCaption>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.TableCaption { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TableDescription conversion.
  private static String? GetTableDescription(DX.OpenXmlCompositeElement openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXW.TableDescription>()?.Val?.Value;
  }

  private static bool CmpTableDescription(DX.OpenXmlCompositeElement openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableDescription>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "TableDescription", itemElement?.Val?.Value, value);
    return false;
  }

  private static void SetTableDescription(DX.OpenXmlCompositeElement openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableDescription>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.TableDescription { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region 
  public static void UpdateModelElement(DMW.ExtBaseTableProperties value, DX.OpenXmlCompositeElement openXmlElement)
  {
    BaseTablePropertiesConverter.UpdateModelElement(value, openXmlElement);
    value.TableStyle = GetTableStyle(openXmlElement);
    value.TablePositionProperties = GetTablePositionProperties(openXmlElement);
    value.TableOverlap = GetTableOverlap(openXmlElement);
    value.BiDiVisual = GetBiDiVisual(openXmlElement);
    value.TableCaption = GetTableCaption(openXmlElement);
    value.TableDescription = GetTableDescription(openXmlElement);
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.ExtBaseTableProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!BaseTablePropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName))
        ok = false;
      if (!CmpTableStyle(openXmlElement, value.TableStyle, diffs, objName))
        ok = false;
      if (!CmpTablePositionProperties(openXmlElement, value.TablePositionProperties, diffs, objName))
        ok = false;
      if (!CmpTableOverlap(openXmlElement, value.TableOverlap, diffs, objName))
        ok = false;
      if (!CmpBiDiVisual(openXmlElement, value.BiDiVisual, diffs, objName))
        ok = false;
      if (!CmpTableCaption(openXmlElement, value.TableCaption, diffs, objName))
        ok = false;
      if (!CmpTableDescription(openXmlElement, value.TableDescription, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.ExtBaseTableProperties value)
  {
    BaseTablePropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
    SetTableStyle(openXmlElement, value?.TableStyle);
    SetTablePositionProperties(openXmlElement, value?.TablePositionProperties);
    SetTableOverlap(openXmlElement, value?.TableOverlap);
    SetBiDiVisual(openXmlElement, value?.BiDiVisual);
    SetTableCaption(openXmlElement, value?.TableCaption);
    SetTableDescription(openXmlElement, value?.TableDescription);
  }
  #endregion
}
