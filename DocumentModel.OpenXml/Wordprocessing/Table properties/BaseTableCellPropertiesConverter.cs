namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.BaseTableCellProperties"/> class from/to OpenXml converter.
/// </summary>
public static class BaseTableCellPropertiesConverter
{
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

  #region TableCellWidth conversion.
  private static DMW.TableWidth? GetTableCellWidth(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellWidth>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpTableCellWidth(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellWidth>(), value, diffs, objName);
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
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region GridSpan conversion.
  private static Int32? GetGridSpan(DX.OpenXmlCompositeElement openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.GridSpan>()?.Val);
  }

  private static bool CmpGridSpan(DX.OpenXmlCompositeElement openXmlElement, Int32? value, DiffList? diffs, string? objName)
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>(openXmlElement.GetFirstChild<DXW.HorizontalMerge>()?.Val?.Value);
  }

  private static bool CmpHorizontalMerge(DX.OpenXmlCompositeElement openXmlElement, DMW.MergedCellKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>(openXmlElement.GetFirstChild<DXW.HorizontalMerge>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetHorizontalMerge(DX.OpenXmlCompositeElement openXmlElement, DMW.MergedCellKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.HorizontalMerge>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>(itemElement, (DMW.MergedCellKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.HorizontalMerge, DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>((DMW.MergedCellKind)value));
  }
  #endregion

  #region VerticalMerge conversion.
  private static DMW.MergedCellKind? GetVerticalMerge(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>(openXmlElement.GetFirstChild<DXW.VerticalMerge>()?.Val?.Value);
  }

  private static bool CmpVerticalMerge(DX.OpenXmlCompositeElement openXmlElement, DMW.MergedCellKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>(openXmlElement.GetFirstChild<DXW.VerticalMerge>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetVerticalMerge(DX.OpenXmlCompositeElement openXmlElement, DMW.MergedCellKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.VerticalMerge>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>(itemElement, (DMW.MergedCellKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.VerticalMerge, DocumentFormat.OpenXml.Wordprocessing.MergedCellValues, DMW.MergedCellKind>((DMW.MergedCellKind)value));
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

  private static bool CmpTableCellBorders(DX.OpenXmlCompositeElement openXmlElement, DMW.TableCellBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableCellBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellBorders>(), value, diffs, objName);
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
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

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

  #region TextDirection conversion.
  private static DMW.TextDirectionKind? GetTextDirection(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value);
  }

  private static bool CmpTextDirection(DX.OpenXmlCompositeElement openXmlElement, DMW.TextDirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(openXmlElement.GetFirstChild<DXW.TextDirection>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetTextDirection(DX.OpenXmlCompositeElement openXmlElement, DMW.TextDirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TextDirection>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>(itemElement, (DMW.TextDirectionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextDirection, DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DMW.TextDirectionKind>((DMW.TextDirectionKind)value));
  }
  #endregion

  #region TableCellFitText conversion.
  private static Boolean GetTableCellFitText(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.TableCellFitText>());
  }

  private static bool CmpTableCellFitText(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.TableCellFitText>(), value, diffs, objName);
  }

  private static void SetTableCellFitText(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.TableCellFitText>(openXmlElement, value);
  }
  #endregion

  #region TableCellVerticalAlignment conversion.
  private static DMW.TableVerticalAlignmentKind? GetTableCellVerticalAlignment(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>()?.Val?.Value);
  }

  private static bool CmpTableCellVerticalAlignment(DX.OpenXmlCompositeElement openXmlElement, DMW.TableVerticalAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetTableCellVerticalAlignment(DX.OpenXmlCompositeElement openXmlElement, DMW.TableVerticalAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(itemElement, (DMW.TableVerticalAlignmentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableCellVerticalAlignment, DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>((DMW.TableVerticalAlignmentKind)value));
  }
  #endregion

  #region HideMark conversion.
  private static Boolean GetHideMark(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.HideMark>());
  }

  private static bool CmpHideMark(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.HideMark>(), value, diffs, objName);
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

  private static bool CmpCellInsertion(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CellInsertion>(), value, diffs, objName);
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
        openXmlElement.AddChild(itemElement);
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

  private static bool CmpCellDeletion(DX.OpenXmlCompositeElement openXmlElement, DMW.TrackChangeType? value, DiffList? diffs, string? objName)
  {
    return DMXW.TrackChangeTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CellDeletion>(), value, diffs, objName);
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
        openXmlElement.AddChild(itemElement);
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

  private static bool CmpCellMerge(DX.OpenXmlCompositeElement openXmlElement, DMW.CellMerge? value, DiffList? diffs, string? objName)
  {
    return DMXW.CellMergeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CellMerge>(), value, diffs, objName);
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
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region BaseTableCellProperties model conversion.
  public static void UpdateModelElement(DMW.BaseTableCellProperties value, DX.OpenXmlCompositeElement openXmlElement)
  {
    value.ConditionalFormatStyle = GetConditionalFormatStyle(openXmlElement);
    value.TableCellWidth = GetTableCellWidth(openXmlElement);
    value.GridSpan = GetGridSpan(openXmlElement);
    value.HorizontalMerge = GetHorizontalMerge(openXmlElement);
    value.VerticalMerge = GetVerticalMerge(openXmlElement);
    value.TableCellBorders = GetTableCellBorders(openXmlElement);
    value.Shading = GetShading(openXmlElement);
    value.NoWrap = GetNoWrap(openXmlElement);
    value.TableCellMargin = GetTableCellMargin(openXmlElement);
    value.TextDirection = GetTextDirection(openXmlElement);
    value.TableCellFitText = GetTableCellFitText(openXmlElement);
    value.TableCellVerticalAlignment = GetTableCellVerticalAlignment(openXmlElement);
    value.HideMark = GetHideMark(openXmlElement);
    value.CellInsertion = GetCellInsertion(openXmlElement);
    value.CellDeletion = GetCellDeletion(openXmlElement);
    value.CellMerge = GetCellMerge(openXmlElement);
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.BaseTableCellProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpConditionalFormatStyle(openXmlElement, value.ConditionalFormatStyle, diffs, objName))
        ok = false;
      if (!CmpTableCellWidth(openXmlElement, value.TableCellWidth, diffs, objName))
        ok = false;
      if (!CmpGridSpan(openXmlElement, value.GridSpan, diffs, objName))
        ok = false;
      if (!CmpHorizontalMerge(openXmlElement, value.HorizontalMerge, diffs, objName))
        ok = false;
      if (!CmpVerticalMerge(openXmlElement, value.VerticalMerge, diffs, objName))
        ok = false;
      if (!CmpTableCellBorders(openXmlElement, value.TableCellBorders, diffs, objName))
        ok = false;
      if (!CmpShading(openXmlElement, value.Shading, diffs, objName))
        ok = false;
      if (!CmpNoWrap(openXmlElement, value.NoWrap, diffs, objName))
        ok = false;
      if (!CmpTableCellMargin(openXmlElement, value.TableCellMargin, diffs, objName))
        ok = false;
      if (!CmpTextDirection(openXmlElement, value.TextDirection, diffs, objName))
        ok = false;
      if (!CmpTableCellFitText(openXmlElement, value.TableCellFitText, diffs, objName))
        ok = false;
      if (!CmpTableCellVerticalAlignment(openXmlElement, value.TableCellVerticalAlignment, diffs, objName))
        ok = false;
      if (!CmpHideMark(openXmlElement, value.HideMark, diffs, objName))
        ok = false;
      if (!CmpCellInsertion(openXmlElement, value.CellInsertion, diffs, objName))
        ok = false;
      if (!CmpCellDeletion(openXmlElement, value.CellDeletion, diffs, objName))
        ok = false;
      if (!CmpCellMerge(openXmlElement, value.CellMerge, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.BaseTableCellProperties value)
  {
    SetConditionalFormatStyle(openXmlElement, value?.ConditionalFormatStyle);
    SetTableCellWidth(openXmlElement, value?.TableCellWidth);
    SetGridSpan(openXmlElement, value?.GridSpan);
    SetHorizontalMerge(openXmlElement, value?.HorizontalMerge);
    SetVerticalMerge(openXmlElement, value?.VerticalMerge);
    SetTableCellBorders(openXmlElement, value?.TableCellBorders);
    SetShading(openXmlElement, value?.Shading);
    SetNoWrap(openXmlElement, value?.NoWrap);
    SetTableCellMargin(openXmlElement, value?.TableCellMargin);
    SetTextDirection(openXmlElement, value?.TextDirection);
    SetTableCellFitText(openXmlElement, value?.TableCellFitText);
    SetTableCellVerticalAlignment(openXmlElement, value?.TableCellVerticalAlignment);
    SetHideMark(openXmlElement, value?.HideMark);
    SetCellInsertion(openXmlElement, value?.CellInsertion);
    SetCellDeletion(openXmlElement, value?.CellDeletion);
    SetCellMerge(openXmlElement, value?.CellMerge);
  }
  #endregion
}
