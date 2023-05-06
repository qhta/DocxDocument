namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.MatrixProperties"/> class from/to OpenXml converter.
/// </summary>
public static class MatrixPropertiesConverter
{
  #region Matrix Base Justification. conversion.
  private static DMM.VerticalAlignmentKind? GetBaseJustification(DXM.MatrixProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMM.VerticalAlignmentKind>(openXmlElement.GetFirstChild<DXM.BaseJustification>()?.Val?.Value);
  }
  
  private static bool CmpBaseJustification(DXM.MatrixProperties openXmlElement, DMM.VerticalAlignmentKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMM.VerticalAlignmentKind>(openXmlElement.GetFirstChild<DXM.BaseJustification>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetBaseJustification(DXM.MatrixProperties openXmlElement, DMM.VerticalAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.BaseJustification>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMM.VerticalAlignmentKind>(itemElement, (DMM.VerticalAlignmentKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXM.BaseJustification, DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMM.VerticalAlignmentKind>((DMM.VerticalAlignmentKind)value));
  }
  #endregion

  #region Hide Placeholders (Matrix) conversion.
  private static bool? GetHidePlaceholder(DXM.MatrixProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.HidePlaceholder>()?.Val?.Value);
  }
  
  private static bool CmpHidePlaceholder(DXM.MatrixProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.HidePlaceholder>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetHidePlaceholder(DXM.MatrixProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.HidePlaceholder>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.HidePlaceholder>((bool)value));
  }
  #endregion

  #region Row Spacing Rule Kind conversion.
  private static DMM.RowSpacingRuleKind? GetRowSpacingRule(DXM.MatrixProperties openXmlElement)
  {
    return (DMM.RowSpacingRuleKind?)Int32ValueConverter.GetValue(openXmlElement.RowSpacingRule?.Val);
  }

  private static bool CmpRowSpacingRule(DXM.MatrixProperties openXmlElement, DMM.RowSpacingRuleKind? value, DiffList? diffs, string? objName)
  {
    return Int32ValueConverter.CmpValue(openXmlElement.RowSpacingRule?.Val, (Int32?)value, diffs, objName, "RowSpacingRule");
  }

  private static void SetRowSpacingRule(DXM.MatrixProperties openXmlElement, DMM.RowSpacingRuleKind? value)
  {
    if (value != null)
      openXmlElement.RowSpacingRule = new DocumentFormat.OpenXml.Math.RowSpacingRule { Val = Int32ValueConverter.CreateIntegerValue((Int32?)value) };
    else
      openXmlElement.RowSpacingRule = null;
  }
  #endregion

  #region Row Spacing Value conversion.
  private static UInt16? GetRowSpacingValue(DXM.MatrixProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.RowSpacing>()?.Val);
  }
  
  private static bool CmpRowSpacingValue(DXM.MatrixProperties openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.RowSpacing>()?.Val, value, diffs, objName, "RowSpacing");
  }
  
  private static void SetRowSpacingValue(DXM.MatrixProperties openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXM.RowSpacing,System.UInt16>(openXmlElement, value);
  }
  #endregion

  #region Row Spacing struct conversion.
  private static DMM.RowSpacing? GetRowSpacing(DXM.MatrixProperties openXmlElement)
  {
    var rule = GetRowSpacingRule(openXmlElement);
    var val = GetRowSpacingValue(openXmlElement);
    if (rule == null && val == null)
      return null;
    return new DMM.RowSpacing(rule ?? DMM.RowSpacingRuleKind.Single, val);
  }

  private static bool CmpRowSpacing(DXM.MatrixProperties openXmlElement, DMM.RowSpacing? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null)
    {
      var ok = true;
      if (!CmpRowSpacingRule(openXmlElement, value?.Rule, diffs, objName))
        ok = false;
      if (!CmpRowSpacingValue(openXmlElement, value?.Value, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;

  }

  private static void SetRowSpacing(DXM.MatrixProperties openXmlElement, DMM.RowSpacing? value)
  {
    if (value != null)
    {
      SetRowSpacingRule(openXmlElement, ((DMM.RowSpacing)value).Rule);
      SetRowSpacingValue(openXmlElement, ((DMM.RowSpacing)value).Value);
    }
    else
    {
      openXmlElement.RowSpacingRule = null;
      openXmlElement.RowSpacing = null;
    }
  }
  #endregion

  #region Matrix Column Gap Rule conversion.
  private static Int64? GetColumnGapRule(DXM.MatrixProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.ColumnGapRule>()?.Val);
  }
  
  private static bool CmpColumnGapRule(DXM.MatrixProperties openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.ColumnGapRule>()?.Val, value, diffs, objName, "ColumnGapRule");
  }
  
  private static void SetColumnGapRule(DXM.MatrixProperties openXmlElement, Int64? value)
  {
    SimpleValueConverter.SetValue<DXM.ColumnGapRule,System.Int64>(openXmlElement, value);
  }
  #endregion

  #region Matrix Column Spacing conversion.
  private static UInt32? GetColumnSpacing(DXM.MatrixProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.ColumnSpacing>()?.Val);
  }
  
  private static bool CmpColumnSpacing(DXM.MatrixProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.ColumnSpacing>()?.Val, value, diffs, objName, "ColumnSpacing");
  }
  
  private static void SetColumnSpacing(DXM.MatrixProperties openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXM.ColumnSpacing,System.UInt32>(openXmlElement, value);
  }
  #endregion

  #region Matrix Column Gap conversion.
  private static UInt16? GetColumnGap(DXM.MatrixProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.ColumnGap>()?.Val);
  }
  
  private static bool CmpColumnGap(DXM.MatrixProperties openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.ColumnGap>()?.Val, value, diffs, objName, "ColumnGap");
  }
  
  private static void SetColumnGap(DXM.MatrixProperties openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXM.ColumnGap,System.UInt16>(openXmlElement, value);
  }
  #endregion

  #region Matrix Columns conversion.
  private static DMM.MatrixColumns? GetMatrixColumns(DXM.MatrixProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.MatrixColumns>();
    if (element != null)
      return DMXM.MatrixColumnsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMatrixColumns(DXM.MatrixProperties openXmlElement, DMM.MatrixColumns? value, DiffList? diffs, string? objName)
  {
    return DMXM.MatrixColumnsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.MatrixColumns>(), value, diffs, objName);
  }
  
  private static void SetMatrixColumns(DXM.MatrixProperties openXmlElement, DMM.MatrixColumns? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.MatrixColumns>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.MatrixColumnsConverter.CreateOpenXmlElement<DXM.MatrixColumns>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ControlProperties conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.MatrixProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.MatrixProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName);
  }
  
  private static void SetControlProperties(DXM.MatrixProperties openXmlElement, DMM.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.ControlPropertiesConverter.CreateOpenXmlElement<DXM.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region MatrixProperties model conversion.
  public static DMM.MatrixProperties? CreateModelElement(DXM.MatrixProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.MatrixProperties();
      model.BaseJustification = GetBaseJustification(openXmlElement);
      model.HidePlaceholder = GetHidePlaceholder(openXmlElement);
      model.ColumnGapRule = GetColumnGapRule(openXmlElement);
      model.RowSpacing = GetRowSpacing(openXmlElement);
      model.ColumnSpacing = GetColumnSpacing(openXmlElement);
      model.ColumnGap = GetColumnGap(openXmlElement);
      model.MatrixColumns = GetMatrixColumns(openXmlElement);
      model.ControlProperties = GetControlProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.MatrixProperties? openXmlElement, DMM.MatrixProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpBaseJustification(openXmlElement, model.BaseJustification, diffs, objName))
        ok = false;
      if (!CmpHidePlaceholder(openXmlElement, model.HidePlaceholder, diffs, objName))
        ok = false;
      if (!CmpColumnGapRule(openXmlElement, model.ColumnGapRule, diffs, objName))
        ok = false;
      if (!CmpRowSpacing(openXmlElement, model.RowSpacing, diffs, objName))
        ok = false;
      if (!CmpColumnSpacing(openXmlElement, model.ColumnSpacing, diffs, objName))
        ok = false;
      if (!CmpColumnGap(openXmlElement, model.ColumnGap, diffs, objName))
        ok = false;
      if (!CmpMatrixColumns(openXmlElement, model.MatrixColumns, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, model.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.MatrixProperties model)
    where OpenXmlElementType: DXM.MatrixProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.MatrixProperties openXmlElement, DMM.MatrixProperties model)
  {
    SetBaseJustification(openXmlElement, model?.BaseJustification);
    SetHidePlaceholder(openXmlElement, model?.HidePlaceholder);
    SetColumnGapRule(openXmlElement, model?.ColumnGapRule);
    SetRowSpacing(openXmlElement, model?.RowSpacing);
    SetColumnSpacing(openXmlElement, model?.ColumnSpacing);
    SetColumnGap(openXmlElement, model?.ColumnGap);
    SetMatrixColumns(openXmlElement, model?.MatrixColumns);
    SetControlProperties(openXmlElement, model?.ControlProperties);
  }
  #endregion
}
