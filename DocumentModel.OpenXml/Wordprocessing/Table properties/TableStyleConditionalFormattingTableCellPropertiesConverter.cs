namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties"/> class from/to OpenXml converter./// </summary>
public static class TableStyleConditionalFormattingTableCellPropertiesConverter
{
  #region TableCellBorders conversion.
  private static DMW.TableCellBorders? GetTableCellBorders(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellBorders>();
    if (element != null)
      return DMXW.TableCellBordersConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellBorders(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableCellBorders? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableCellBordersConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellBorders>(), value, diffs, objName);
  }
  
  private static void SetTableCellBorders(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableCellBorders? value)
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

  #region Shading conversion.
  private static DMW.Shading? GetShading(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (element != null)
      return DMXW.ShadingConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShading(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    return DMXW.ShadingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Shading>(), value, diffs, objName);
  }
  
  private static void SetShading(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.Shading? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ShadingConverter.CreateOpenXmlElement<DXW.Shading>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region NoWrap conversion.
  private static Boolean GetNoWrap(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.NoWrap>());
  }
  
  private static bool CmpNoWrap(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.NoWrap>(), value, diffs, objName);
  }
  
  private static void SetNoWrap(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffOnlyType<DXW.NoWrap>(openXmlElement, value);
  }
  #endregion

  #region TableCellMargin conversion.
  private static DMW.TableCellMargin? GetTableCellMargin(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableCellMargin>();
    if (element != null)
      return DMXW.TableCellMarginConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableCellMargin(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableCellMargin? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableCellMarginConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableCellMargin>(), value, diffs, objName);
  }
  
  private static void SetTableCellMargin(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableCellMargin? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableCellMarginConverter.CreateOpenXmlElement<DXW.TableCellMargin>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableCellVerticalAlignment conversion.
  private static DMW.TableVerticalAlignmentKind? GetTableCellVerticalAlignment(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>()?.Val?.Value);
  }
  
  private static bool CmpTableCellVerticalAlignment(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableVerticalAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTableCellVerticalAlignment(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableVerticalAlignmentKind? value)
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
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableCellVerticalAlignment, DXW.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>((DMW.TableVerticalAlignmentKind)value));
  }
  #endregion

  #region TableStyleConditionCellProperties model conversion.
  public static DMW.TableStyleConditionalCellProperties? CreateModelElement(DXW.TableStyleConditionalFormattingTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.TableStyleConditionalCellProperties();
      model.TableCellBorders = GetTableCellBorders(openXmlElement);
      model.Shading = GetShading(openXmlElement);
      model.NoWrap = GetNoWrap(openXmlElement);
      model.TableCellMargin = GetTableCellMargin(openXmlElement);
      model.TableCellVerticalAlignment = GetTableCellVerticalAlignment(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableStyleConditionalFormattingTableCellProperties? openXmlElement, DMW.TableStyleConditionalCellProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpTableCellBorders(openXmlElement, model.TableCellBorders, diffs, objName))
        ok = false;
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableStyleConditionalCellProperties model)
    where OpenXmlElementType: DXW.TableStyleConditionalFormattingTableCellProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableStyleConditionalCellProperties model)
  {
    SetTableCellBorders(openXmlElement, model?.TableCellBorders);
    SetShading(openXmlElement, model?.Shading);
    SetNoWrap(openXmlElement, model?.NoWrap);
    SetTableCellMargin(openXmlElement, model?.TableCellMargin);
    SetTableCellVerticalAlignment(openXmlElement, model?.TableCellVerticalAlignment);
  }
  #endregion
}
