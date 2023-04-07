namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.BaseTableRowProperties"/> class from/to OpenXml converter.
/// </summary>
public static class BaseTableRowPropertiesConverter
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

  #region GridBefore conversion.
  private static Int32? GetGridBefore(DX.OpenXmlCompositeElement openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.GridBefore>()?.Val);
  }

  private static bool CmpGridBefore(DX.OpenXmlCompositeElement openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.GridBefore>()?.Val, value, diffs, objName, "GridBefore");
  }

  private static void SetGridBefore(DX.OpenXmlCompositeElement openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.GridBefore, System.Int32>(openXmlElement, value);
  }
  #endregion

  #region GridAfter conversion.
  private static Int32? GetGridAfter(DX.OpenXmlCompositeElement openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.GridAfter>()?.Val);
  }

  private static bool CmpGridAfter(DX.OpenXmlCompositeElement openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.GridAfter>()?.Val, value, diffs, objName, "GridAfter");
  }

  private static void SetGridAfter(DX.OpenXmlCompositeElement openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.GridAfter, System.Int32>(openXmlElement, value);
  }
  #endregion

  #region WidthBeforeTableRow conversion.
  private static DMW.TableWidth? GetWidthBeforeTableRow(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.WidthBeforeTableRow>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpWidthBeforeTableRow(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.WidthBeforeTableRow>(), value, diffs, objName);
  }

  private static void SetWidthBeforeTableRow(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.WidthBeforeTableRow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.WidthBeforeTableRow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region WidthAfterTableRow conversion.
  private static DMW.TableWidth? GetWidthAfterTableRow(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.WidthAfterTableRow>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpWidthAfterTableRow(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.WidthAfterTableRow>(), value, diffs, objName);
  }

  private static void SetWidthAfterTableRow(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.WidthAfterTableRow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.WidthAfterTableRow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TableRowHeight conversion.
  private static DMW.TableRowHeight? GetTableRowHeight(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableRowHeight>();
    if (element != null)
      return DMXW.TableRowHeightConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpTableRowHeight(DX.OpenXmlCompositeElement openXmlElement, DMW.TableRowHeight? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableRowHeightConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableRowHeight>(), value, diffs, objName);
  }

  private static void SetTableRowHeight(DX.OpenXmlCompositeElement openXmlElement, DMW.TableRowHeight? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableRowHeight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableRowHeightConverter.CreateOpenXmlElement<DXW.TableRowHeight>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Hidden coversion.
  private static Boolean? GetHidden(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.Hidden>());
  }

  private static bool CmpHidden(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.Hidden>(), value, diffs, objName);
  }

  private static void SetHidden(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.Hidden>(openXmlElement, value);
  }
  #endregion

  #region CantSplit conversion.
  private static Boolean GetCantSplit(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.CantSplit>());
  }

  private static bool CmpCantSplit(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.CantSplit>(), value, diffs, objName);
  }

  private static void SetCantSplit(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.CantSplit>(openXmlElement, value);
  }
  #endregion

  #region TableHeader conversion.
  private static Boolean GetTableHeader(DX.OpenXmlCompositeElement openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.TableHeader>());
  }

  private static bool CmpTableHeader(DX.OpenXmlCompositeElement openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.TableHeader>(), value, diffs, objName);
  }

  private static void SetTableHeader(DX.OpenXmlCompositeElement openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.TableHeader>(openXmlElement, value);
  }
  #endregion

  #region TableCellSpacing conversion.
  private static DMW.TableWidth? GetTableCellSpacing(DX.OpenXmlCompositeElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellSpacing>();
    if (element != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpTableCellSpacing(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableWidthTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellSpacing>(), value, diffs, objName);
  }

  private static void SetTableCellSpacing(DX.OpenXmlCompositeElement openXmlElement, DMW.TableWidth? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.TableCellSpacing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TableJustification conversion.
  private static DMW.TableRowAlignmentKind? GetTableJustification(DX.OpenXmlCompositeElement openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value);
  }

  private static bool CmpTableJustification(DX.OpenXmlCompositeElement openXmlElement, DMW.TableRowAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value, value, diffs, objName);
  }

  private static void SetTableJustification(DX.OpenXmlCompositeElement openXmlElement, DMW.TableRowAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableJustification>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(itemElement, (DMW.TableRowAlignmentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableJustification, DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>((DMW.TableRowAlignmentKind)value));
  }
  #endregion

  #region BaseTableRowProperties model conversion.
  public static void UpdateModelElement(DMW.BaseTableRowProperties value, DX.OpenXmlCompositeElement openXmlElement)
  {
    value.ConditionalFormatStyle = GetConditionalFormatStyle(openXmlElement);
    value.DivId = GetDivId(openXmlElement);
    value.GridBefore = GetGridBefore(openXmlElement);
    value.GridAfter = GetGridAfter(openXmlElement);
    value.WidthBeforeTableRow = GetWidthBeforeTableRow(openXmlElement);
    value.WidthAfterTableRow = GetWidthAfterTableRow(openXmlElement);
    value.TableRowHeight = GetTableRowHeight(openXmlElement);
    value.Hidden = GetHidden(openXmlElement);
    value.CantSplit = GetCantSplit(openXmlElement);
    value.TableHeader = GetTableHeader(openXmlElement);
    value.TableCellSpacing = GetTableCellSpacing(openXmlElement);
    value.TableJustification = GetTableJustification(openXmlElement);
  }

  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.BaseTableRowProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpConditionalFormatStyle(openXmlElement, value.ConditionalFormatStyle, diffs, objName))
        ok = false;
      if (!CmpDivId(openXmlElement, value.DivId, diffs, objName))
        ok = false;
      if (!CmpGridBefore(openXmlElement, value.GridBefore, diffs, objName))
        ok = false;
      if (!CmpGridAfter(openXmlElement, value.GridAfter, diffs, objName))
        ok = false;
      if (!CmpWidthBeforeTableRow(openXmlElement, value.WidthBeforeTableRow, diffs, objName))
        ok = false;
      if (!CmpWidthAfterTableRow(openXmlElement, value.WidthAfterTableRow, diffs, objName))
        ok = false;
      if (!CmpTableRowHeight(openXmlElement, value.TableRowHeight, diffs, objName))
        ok = false;
      if (!CmpHidden(openXmlElement, value.Hidden, diffs, objName))
        ok = false;
      if (!CmpCantSplit(openXmlElement, value.CantSplit, diffs, objName))
        ok = false;
      if (!CmpTableHeader(openXmlElement, value.TableHeader, diffs, objName))
        ok = false;
      if (!CmpTableCellSpacing(openXmlElement, value.TableCellSpacing, diffs, objName))
        ok = false;
      if (!CmpTableJustification(openXmlElement, value.TableJustification, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.BaseTableRowProperties value)
  {
    SetConditionalFormatStyle(openXmlElement, value?.ConditionalFormatStyle);
    SetDivId(openXmlElement, value?.DivId);
    SetGridBefore(openXmlElement, value?.GridBefore);
    SetGridAfter(openXmlElement, value?.GridAfter);
    SetWidthBeforeTableRow(openXmlElement, value?.WidthBeforeTableRow);
    SetWidthAfterTableRow(openXmlElement, value?.WidthAfterTableRow);
    SetTableRowHeight(openXmlElement, value?.TableRowHeight);
    SetHidden(openXmlElement, value?.Hidden);
    SetCantSplit(openXmlElement, value?.CantSplit);
    SetTableHeader(openXmlElement, value?.TableHeader);
    SetTableCellSpacing(openXmlElement, value?.TableCellSpacing);
    SetTableJustification(openXmlElement, value?.TableJustification);
  }
  #endregion
}
