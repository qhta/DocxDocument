namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.CurrentTableCellProperties"/> class from/to OpenXml converter.
/// </summary>
public static class CurrentTableCellPropertiesConverter
{
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

  #region TableCellWidth conversion.
  private static DMW.TableWidth? GetTableCellWidth(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellWidth>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpTableCellWidth(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellWidth>(), value, diffs, objName, propName);
  }

  private static void SetTableCellWidth(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.TableCellWidth>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region GridSpan conversion.
  private static Int32? GetGridSpan(DX.OpenXmlCompositeElement openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.GridSpan>()?.Val);
  }

  private static bool CmpGridSpan(DX.OpenXmlCompositeElement openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.GridSpan>()?.Val, value, diffs, objName, "GridSpan");
  }

  private static void SetGridSpan(DX.OpenXmlCompositeElement openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.GridSpan, System.Int32>(openXmlElement, value);
  }
  #endregion

  #region HorizontalMerge conversion.
  private static DMW.MergedCellKind? GetHorizontalMerge(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.MergedCellValues, DMW.MergedCellKind>(openXmlElement.GetFirstChild<DXW.HorizontalMerge>()?.Val?.Value);
  }

  private static bool CmpHorizontalMerge(DX.OpenXmlCompositeElement openXmlElement, DMW.MergedCellKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.MergedCellValues, DMW.MergedCellKind>(openXmlElement.GetFirstChild<DXW.HorizontalMerge>()?.Val?.Value, value, diffs, objName, propName);
  }

  private static void SetHorizontalMerge(DX.OpenXmlCompositeElement openXmlElement, DMW.MergedCellKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.HorizontalMerge>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.MergedCellValues, DMW.MergedCellKind>(itemElement, (DMW.MergedCellKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.HorizontalMerge, DXW.MergedCellValues, DMW.MergedCellKind>((DMW.MergedCellKind)value));
  }
  #endregion

  #region VerticalMerge conversion.
  private static DMW.MergedCellKind? GetVerticalMerge(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.MergedCellValues, DMW.MergedCellKind>(openXmlElement.GetFirstChild<DXW.VerticalMerge>()?.Val?.Value);
  }

  private static bool CmpVerticalMerge(DX.OpenXmlCompositeElement openXmlElement, DMW.MergedCellKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.MergedCellValues, DMW.MergedCellKind>(openXmlElement.GetFirstChild<DXW.VerticalMerge>()?.Val?.Value, value, diffs, objName, propName);
  }

  private static void SetVerticalMerge(DX.OpenXmlCompositeElement openXmlElement, DMW.MergedCellKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.VerticalMerge>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.MergedCellValues, DMW.MergedCellKind>(itemElement, (DMW.MergedCellKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.VerticalMerge, DXW.MergedCellValues, DMW.MergedCellKind>((DMW.MergedCellKind)value));
  }
  #endregion

  #region TableCellBorders conversion.
  private static DMW.TableCellBorders? GetTableCellBorders(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellBorders>();
    if (element != null)
      return DMXW.TableCellBordersConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpTableCellBorders(DX.OpenXmlCompositeElement openXmlElement, DMW.TableCellBorders? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.TableCellBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellBorders>(), value, diffs, objName, propName);
  }

  private static void SetTableCellBorders(DX.OpenXmlCompositeElement openXmlElement, DMW.TableCellBorders? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableCellBordersConverter.CreateOpenXmlElement<DXW.TableCellBorders>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TextDirection conversion.
  private static DMW.TextDirectionKind? GetTextDirection(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value);
  }

  private static bool CmpTextDirection(DX.OpenXmlCompositeElement openXmlElement, DMW.TextDirectionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value, value, diffs, objName, propName);
  }

  private static void SetTextDirection(DX.OpenXmlCompositeElement openXmlElement, DMW.TextDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextDirection>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.TextDirectionValues, DMW.TextDirectionKind>(itemElement, (DMW.TextDirectionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextDirection, DXW.TextDirectionValues, DMW.TextDirectionKind>((DMW.TextDirectionKind)value));
  }
  #endregion

  #region TableCellFitText conversion.
  private static Boolean GetTableCellFitText(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.TableCellFitText>());
  }

  private static bool CmpTableCellFitText(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.TableCellFitText>(), value, diffs, objName, propName);
  }

  private static void SetTableCellFitText(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.TableCellFitText>(openXmlElement, value);
  }
  #endregion

  #region HideMark conversion.
  private static Boolean GetHideMark(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.HideMark>());
  }

  private static bool CmpHideMark(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.HideMark>(), value, diffs, objName, propName);
  }

  private static void SetHideMark(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.HideMark>(openXmlElement, value);
  }
  #endregion

  #region CellInsertion conversion.
  private static DMW.CellInsertion? GetCellInsertion(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CellInsertion>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpCellInsertion(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CellInsertion>(), value, diffs, objName, propName);
  }

  private static void SetCellInsertion(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CellInsertion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CellInsertion>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region CellDeletion conversion.
  private static DMW.CellDeletion? GetCellDeletion(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CellDeletion>();
    if (element != null)
      return DMXW.TrackChangeTypeConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpCellDeletion(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CellDeletion>(), value, diffs, objName, propName);
  }

  private static void SetCellDeletion(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CellDeletion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TrackChangeTypeConverter.CreateOpenXmlElement<DXW.CellDeletion>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region CellMerge conversion.
  private static DMW.CellMerge? GetCellMerge(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CellMerge>();
    if (element != null)
      return DMXW.CellMergeConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpCellMerge(DX.OpenXmlCompositeElement openXmlElement, DMW.CellMerge? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.CellMergeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CellMerge>(), value, diffs, objName, propName);
  }

  private static void SetCellMerge(DX.OpenXmlCompositeElement openXmlElement, DMW.CellMerge? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CellMerge>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CellMergeConverter.CreateOpenXmlElement<DXW.CellMerge>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region CurrentTableCellProperties model conversion.
  public static void UpdateModelElement(DMW.CurrentTableCellProperties model, DX.OpenXmlCompositeElement openXmlElement)
  {
    BaseTableCellPropertiesConverter.UpdateModelElement(model, openXmlElement);
    model.ConditionalFormatStyle = GetConditionalFormatStyle(openXmlElement);
    model.TableCellWidth = GetTableCellWidth(openXmlElement);
    model.GridSpan = GetGridSpan(openXmlElement);
    model.HorizontalMerge = GetHorizontalMerge(openXmlElement);
    model.VerticalMerge = GetVerticalMerge(openXmlElement);
    model.TableCellBorders = GetTableCellBorders(openXmlElement);
    model.TextDirection = GetTextDirection(openXmlElement);
    model.TableCellFitText = GetTableCellFitText(openXmlElement);
    model.HideMark = GetHideMark(openXmlElement);
    model.CellInsertion = GetCellInsertion(openXmlElement);
    model.CellDeletion = GetCellDeletion(openXmlElement);
    model.CellMerge = GetCellMerge(openXmlElement);
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.CurrentTableCellProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!BaseTableCellPropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName))
        ok = false;
      if (!CmpConditionalFormatStyle(openXmlElement, model.ConditionalFormatStyle, diffs, objName, propName))
        ok = false;
      if (!CmpTableCellWidth(openXmlElement, model.TableCellWidth, diffs, objName, propName))
        ok = false;
      if (!CmpGridSpan(openXmlElement, model.GridSpan, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalMerge(openXmlElement, model.HorizontalMerge, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalMerge(openXmlElement, model.VerticalMerge, diffs, objName, propName))
        ok = false;
      if (!CmpTableCellBorders(openXmlElement, model.TableCellBorders, diffs, objName, propName))
        ok = false;
      if (!CmpTextDirection(openXmlElement, model.TextDirection, diffs, objName, propName))
        ok = false;
      if (!CmpTableCellFitText(openXmlElement, model.TableCellFitText, diffs, objName, propName))
        ok = false;
      if (!CmpHideMark(openXmlElement, model.HideMark, diffs, objName, propName))
        ok = false;
      if (!CmpCellInsertion(openXmlElement, model.CellInsertion, diffs, objName, propName))
        ok = false;
      if (!CmpCellDeletion(openXmlElement, model.CellDeletion, diffs, objName, propName))
        ok = false;
      if (!CmpCellMerge(openXmlElement, model.CellMerge, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.CurrentTableCellProperties model)
  {
    BaseTableCellPropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
    SetConditionalFormatStyle(openXmlElement, model?.ConditionalFormatStyle);
    SetTableCellWidth(openXmlElement, model?.TableCellWidth);
    SetGridSpan(openXmlElement, model?.GridSpan);
    SetHorizontalMerge(openXmlElement, model?.HorizontalMerge);
    SetVerticalMerge(openXmlElement, model?.VerticalMerge);
    SetTableCellBorders(openXmlElement, model?.TableCellBorders);
    SetTextDirection(openXmlElement, model?.TextDirection);
    SetTableCellFitText(openXmlElement, model?.TableCellFitText);
    SetHideMark(openXmlElement, model?.HideMark);
    SetCellInsertion(openXmlElement, model?.CellInsertion);
    SetCellDeletion(openXmlElement, model?.CellDeletion);
    SetCellMerge(openXmlElement, model?.CellMerge);
  }
  #endregion
}
