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

  #region ExtBaseTableProperties model conversion
  public static void UpdateModelElement(DMW.ExtBaseTableProperties model, DX.OpenXmlCompositeElement openXmlElement)
  {
    CurrentTablePropertiesConverter.UpdateModelElement(model, openXmlElement);
    model.TableStyle = GetTableStyle(openXmlElement);
    model.TablePositionProperties = GetTablePositionProperties(openXmlElement);
    model.TableOverlap = GetTableOverlap(openXmlElement);
    model.BiDiVisual = GetBiDiVisual(openXmlElement);
    model.TableCaption = GetTableCaption(openXmlElement);
    model.TableDescription = GetTableDescription(openXmlElement);
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.ExtBaseTableProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CurrentTablePropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName))
        ok = false;
      if (!CmpTableStyle(openXmlElement, model.TableStyle, diffs, objName))
        ok = false;
      if (!CmpTablePositionProperties(openXmlElement, model.TablePositionProperties, diffs, objName))
        ok = false;
      if (!CmpTableOverlap(openXmlElement, model.TableOverlap, diffs, objName))
        ok = false;
      if (!CmpBiDiVisual(openXmlElement, model.BiDiVisual, diffs, objName))
        ok = false;
      if (!CmpTableCaption(openXmlElement, model.TableCaption, diffs, objName))
        ok = false;
      if (!CmpTableDescription(openXmlElement, model.TableDescription, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.ExtBaseTableProperties model)
  {
    CurrentTablePropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
    SetTableStyle(openXmlElement, model?.TableStyle);
    SetTablePositionProperties(openXmlElement, model?.TablePositionProperties);
    SetTableOverlap(openXmlElement, model?.TableOverlap);
    SetBiDiVisual(openXmlElement, model?.BiDiVisual);
    SetTableCaption(openXmlElement, model?.TableCaption);
    SetTableDescription(openXmlElement, model?.TableDescription);
  }
  #endregion
}
