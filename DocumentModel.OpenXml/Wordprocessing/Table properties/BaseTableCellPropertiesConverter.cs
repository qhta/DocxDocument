namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.BaseTableCellProperties"/> class from/to OpenXml converter.
/// </summary>
public static class BaseTableCellPropertiesConverter
{
  #region Shading conversion.
  private static DMW.Shading? GetShading(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (element != null)
      return DMXW.ShadingConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpShading(DX.OpenXmlCompositeElement openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName);
  }

  private static void SetShading(DX.OpenXmlCompositeElement openXmlElement, DMW.Shading? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ShadingConverter.CreateOpenXmlElement<DXW.Shading>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region NoWrap conversion.
  private static Boolean GetNoWrap(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoWrap>());
  }

  private static bool CmpNoWrap(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoWrap>(), value, diffs, objName);
  }

  private static void SetNoWrap(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.NoWrap>(openXmlElement, value);
  }
  #endregion

  #region TableCellMargin conversion.
  private static DMW.TableCellMargin? GetTableCellMargin(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellMargin>();
    if (element != null)
      return DMXW.TableCellMarginConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpTableCellMargin(DX.OpenXmlCompositeElement openXmlElement, DMW.TableCellMargin? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableCellMarginConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellMargin>(), value, diffs, objName);
  }

  private static void SetTableCellMargin(DX.OpenXmlCompositeElement openXmlElement, DMW.TableCellMargin? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableCellMarginConverter.CreateOpenXmlElement<DXW.TableCellMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TableCellVerticalAlignment conversion.
  private static DMW.TableVerticalAlignmentKind? GetTableCellVerticalAlignment(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>()?.Val?.Value);
  }

  private static bool CmpTableCellVerticalAlignment(DX.OpenXmlCompositeElement openXmlElement, DMW.TableVerticalAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetTableCellVerticalAlignment(DX.OpenXmlCompositeElement openXmlElement, DMW.TableVerticalAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(itemElement, (DMW.TableVerticalAlignmentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableCellVerticalAlignment, DXW.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>((DMW.TableVerticalAlignmentKind)value));
  }
  #endregion

  #region BaseTableCellProperties model conversion.
  public static void UpdateModelElement(DMW.BaseTableCellProperties model, DX.OpenXmlCompositeElement openXmlElement)
  {
    model.Shading = GetShading(openXmlElement);
    model.NoWrap = GetNoWrap(openXmlElement);
    model.TableCellMargin = GetTableCellMargin(openXmlElement);
    model.TableCellVerticalAlignment = GetTableCellVerticalAlignment(openXmlElement);
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.BaseTableCellProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpShading(openXmlElement, model.Shading, diffs, objName))
        ok = false;
      if (!CmpNoWrap(openXmlElement, model.NoWrap, diffs, objName))
        ok = false;
      if (!CmpTableCellMargin(openXmlElement, model.TableCellMargin, diffs, objName))
        ok = false;
      if (!CmpTableCellVerticalAlignment(openXmlElement, model.TableCellVerticalAlignment, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.BaseTableCellProperties model)
  {
    SetShading(openXmlElement, model?.Shading);
    SetNoWrap(openXmlElement, model?.NoWrap);
    SetTableCellMargin(openXmlElement, model?.TableCellMargin);
    SetTableCellVerticalAlignment(openXmlElement, model?.TableCellVerticalAlignment);
  }
  #endregion
}
