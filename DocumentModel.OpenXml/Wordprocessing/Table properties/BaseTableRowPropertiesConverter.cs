namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.BaseTableRowProperties"/> class from/to OpenXml converter.
/// </summary>
public static class BaseTableRowPropertiesConverter
{
  #region ConditionalFormatStyle conversion.
  public static DMW.ConditionalFormatFlags? GetConditionalFormatStyle(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ConditionalFormatStyle>();
    if (element != null)
      return DMXW.ConditionalFormatStyleConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpConditionalFormatStyle(DX.OpenXmlCompositeElement openXmlElement, DMW.ConditionalFormatFlags? value, DiffList? diffs, string? objName)
  {
    return DMXW.ConditionalFormatStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ConditionalFormatStyle>(), value, diffs, objName);
  }

  public static void SetConditionalFormatStyle(DX.OpenXmlCompositeElement openXmlElement, DMW.ConditionalFormatFlags? value)
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

  #region DivId conversion.
  public static String? GetDivId(DX.OpenXmlCompositeElement openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.DivId>()?.Val);
  }

  public static bool CmpDivId(DX.OpenXmlCompositeElement openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.DivId>()?.Val, value, diffs, objName, "DivId");
  }

  public static void SetDivId(DX.OpenXmlCompositeElement openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXW.DivId>(openXmlElement, value);
  }
  #endregion

  #region GridBefore conversion.
  public static Int32? GetGridBefore(DX.OpenXmlCompositeElement openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.GridBefore>()?.Val);
  }

  public static bool CmpGridBefore(DX.OpenXmlCompositeElement openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.GridBefore>()?.Val, value, diffs, objName, "GridBefore");
  }

  public static void SetGridBefore(DX.OpenXmlCompositeElement openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.GridBefore, System.Int32>(openXmlElement, value);
  }
  #endregion

  #region GridAfter conversion.
  public static Int32? GetGridAfter(DX.OpenXmlCompositeElement openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.GridAfter>()?.Val);
  }

  public static bool CmpGridAfter(DX.OpenXmlCompositeElement openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.GridAfter>()?.Val, value, diffs, objName, "GridAfter");
  }

  public static void SetGridAfter(DX.OpenXmlCompositeElement openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.GridAfter, System.Int32>(openXmlElement, value);
  }
  #endregion

  #region WidthBeforeTableRow conversion.
  public static DMW.TableWidth? GetWidthBeforeTableRow(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.WidthBeforeTableRow>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpWidthBeforeTableRow(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.WidthBeforeTableRow>(), value, diffs, objName);
  }

  public static void SetWidthBeforeTableRow(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.WidthBeforeTableRow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.WidthBeforeTableRow>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region WidthAfterTableRow conversion.
  public static DMW.TableWidth? GetWidthAfterTableRow(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.WidthAfterTableRow>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpWidthAfterTableRow(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.WidthAfterTableRow>(), value, diffs, objName);
  }

  public static void SetWidthAfterTableRow(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.WidthAfterTableRow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.WidthAfterTableRow>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableRowHeight conversion.
  public static DMW.TableRowHeight? GetTableRowHeight(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableRowHeight>();
    if (element != null)
      return DMXW.TableRowHeightConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpTableRowHeight(DX.OpenXmlCompositeElement openXmlElement, DMW.TableRowHeight? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableRowHeightConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableRowHeight>(), value, diffs, objName);
  }

  public static void SetTableRowHeight(DX.OpenXmlCompositeElement openXmlElement, DMW.TableRowHeight? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableRowHeight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableRowHeightConverter.CreateOpenXmlElement<DXW.TableRowHeight>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Hidden coversion.
  public static Boolean? GetHidden(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Hidden>());
  }

  public static bool CmpHidden(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Hidden>(), value, diffs, objName);
  }

  public static void SetHidden(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Hidden>(openXmlElement, value);
  }
  #endregion

  #region CantSplit conversion.
  public static Boolean GetCantSplit(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.CantSplit>());
  }

  public static bool CmpCantSplit(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.CantSplit>(), value, diffs, objName);
  }

  public static void SetCantSplit(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.CantSplit>(openXmlElement, value);
  }
  #endregion

  #region TableHeader conversion.
  public static Boolean GetTableHeader(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.TableHeader>());
  }

  public static bool CmpTableHeader(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.TableHeader>(), value, diffs, objName);
  }

  public static void SetTableHeader(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.TableHeader>(openXmlElement, value);
  }
  #endregion

  #region TableCellSpacing conversion.
  public static DMW.TableWidth? GetTableCellSpacing(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellSpacing>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }

  public static bool CmpTableCellSpacing(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellSpacing>(), value, diffs, objName);
  }

  public static void SetTableCellSpacing(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.TableCellSpacing>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableJustification conversion.
  public static DMW.TableRowAlignmentKind? GetTableJustification(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value);
  }

  public static bool CmpTableJustification(DX.OpenXmlCompositeElement openXmlElement, DMW.TableRowAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value, value, diffs, objName);
  }

  public static void SetTableJustification(DX.OpenXmlCompositeElement openXmlElement, DMW.TableRowAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableJustification>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(itemElement, (DMW.TableRowAlignmentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableJustification, DXW.TableRowAlignmentValues, DMW.TableRowAlignmentKind>((DMW.TableRowAlignmentKind)value));
  }
  #endregion

  #region BaseTableRowProperties model conversion.
  public static void UpdateModelElement(DMW.BaseTableRowProperties model, DX.OpenXmlCompositeElement openXmlElement)
  {
    model.ConditionalFormatStyle = GetConditionalFormatStyle(openXmlElement);
    model.DivId = GetDivId(openXmlElement);
    model.GridBefore = GetGridBefore(openXmlElement);
    model.GridAfter = GetGridAfter(openXmlElement);
    model.WidthBefore = GetWidthBeforeTableRow(openXmlElement);
    model.WidthAfter = GetWidthAfterTableRow(openXmlElement);
    model.RowHeight = GetTableRowHeight(openXmlElement);
    model.GlyphHidden = GetHidden(openXmlElement);
    model.CantSplit = GetCantSplit(openXmlElement);
    model.IsHeader = GetTableHeader(openXmlElement);
    model.CellSpacing = GetTableCellSpacing(openXmlElement);
    model.RowAlignment = GetTableJustification(openXmlElement);
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.BaseTableRowProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpConditionalFormatStyle(openXmlElement, model.ConditionalFormatStyle, diffs, objName))
        ok = false;
      if (!CmpDivId(openXmlElement, model.DivId, diffs, objName))
        ok = false;
      if (!CmpGridBefore(openXmlElement, model.GridBefore, diffs, objName))
        ok = false;
      if (!CmpGridAfter(openXmlElement, model.GridAfter, diffs, objName))
        ok = false;
      if (!CmpWidthBeforeTableRow(openXmlElement, model.WidthBefore, diffs, objName))
        ok = false;
      if (!CmpWidthAfterTableRow(openXmlElement, model.WidthAfter, diffs, objName))
        ok = false;
      if (!CmpTableRowHeight(openXmlElement, model.RowHeight, diffs, objName))
        ok = false;
      if (!CmpHidden(openXmlElement, model.GlyphHidden, diffs, objName))
        ok = false;
      if (!CmpCantSplit(openXmlElement, model.CantSplit, diffs, objName))
        ok = false;
      if (!CmpTableHeader(openXmlElement, model.IsHeader, diffs, objName))
        ok = false;
      if (!CmpTableCellSpacing(openXmlElement, model.CellSpacing, diffs, objName))
        ok = false;
      if (!CmpTableJustification(openXmlElement, model.RowAlignment, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.BaseTableRowProperties model)
  {
    SetConditionalFormatStyle(openXmlElement, model?.ConditionalFormatStyle);
    SetDivId(openXmlElement, model?.DivId);
    SetGridBefore(openXmlElement, model?.GridBefore);
    SetGridAfter(openXmlElement, model?.GridAfter);
    SetWidthBeforeTableRow(openXmlElement, model?.WidthBefore);
    SetWidthAfterTableRow(openXmlElement, model?.WidthAfter);
    SetTableRowHeight(openXmlElement, model?.RowHeight);
    SetHidden(openXmlElement, model?.GlyphHidden);
    SetCantSplit(openXmlElement, model?.CantSplit);
    SetTableHeader(openXmlElement, model?.IsHeader);
    SetTableCellSpacing(openXmlElement, model?.CellSpacing);
    SetTableJustification(openXmlElement, model?.RowAlignment);
  }
  #endregion
}
