namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.EquationArrayProperties"/> class from/to OpenXml converter.
/// </summary>
public static class EquationArrayPropertiesConverter
{
  #region Equation Array Base Justification conversion.
  private static DMM.VerticalAlignmentKind? GetBaseJustification(DXM.EquationArrayProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMM.VerticalAlignmentKind>(openXmlElement.GetFirstChild<DXM.BaseJustification>()?.Val?.Value);
  }

  private static bool CmpBaseJustification(DXM.EquationArrayProperties openXmlElement, DMM.VerticalAlignmentKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMM.VerticalAlignmentKind>(openXmlElement.GetFirstChild<DXM.BaseJustification>()?.Val?.Value, value, diffs, objName, propName);
  }

  private static void SetBaseJustification(DXM.EquationArrayProperties openXmlElement, DMM.VerticalAlignmentKind? value)
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

  #region Maximum Distribution conversion.
  private static bool? GetMaxDistribution(DXM.EquationArrayProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.MaxDistribution>()?.Val?.Value);
  }

  private static bool CmpMaxDistribution(DXM.EquationArrayProperties openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.MaxDistribution>()?.Val?.Value, value, diffs, objName, propName);
  }

  private static void SetMaxDistribution(DXM.EquationArrayProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.MaxDistribution>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.MaxDistribution>((bool)value));
  }
  #endregion

  #region Object Distribution conversion.
  private static bool? GetObjectDistribution(DXM.EquationArrayProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.ObjectDistribution>()?.Val?.Value);
  }

  private static bool CmpObjectDistribution(DXM.EquationArrayProperties openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.ObjectDistribution>()?.Val?.Value, value, diffs, objName, propName);
  }

  private static void SetObjectDistribution(DXM.EquationArrayProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.ObjectDistribution>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.ObjectDistribution>((bool)value));
  }
  #endregion

  #region Row Spacing Rule Kind conversion.
  private static DMM.RowSpacingRuleKind? GetRowSpacingRule(DXM.EquationArrayProperties openXmlElement)
  {
    return (DMM.RowSpacingRuleKind?)Int32ValueConverter.GetValue(openXmlElement.RowSpacingRule?.Val);
  }

  private static bool CmpRowSpacingRule(DXM.EquationArrayProperties openXmlElement, DMM.RowSpacingRuleKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return Int32ValueConverter.CmpValue(openXmlElement.RowSpacingRule?.Val, (Int32?)value, diffs, objName, "RowSpacingRule");
  }

  private static void SetRowSpacingRule(DXM.EquationArrayProperties openXmlElement, DMM.RowSpacingRuleKind? value)
  {
    if (value != null)
      openXmlElement.RowSpacingRule = new DocumentFormat.OpenXml.Math.RowSpacingRule { Val = Int32ValueConverter.CreateIntegerValue((Int32?)value) };
    else
      openXmlElement.RowSpacingRule = null;
  }
  #endregion

  #region Row Spacing Value conversion.
  private static UInt16? GetRowSpacingValue(DXM.EquationArrayProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.RowSpacing>()?.Val);
  }

  private static bool CmpRowSpacingValue(DXM.EquationArrayProperties openXmlElement, UInt16? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.RowSpacing>()?.Val, value, diffs, objName, "RowSpacing");
  }

  private static void SetRowSpacingValue(DXM.EquationArrayProperties openXmlElement, UInt16? value)
  {
    SimpleValueConverter.SetValue<DXM.RowSpacing, System.UInt16>(openXmlElement, value);
  }
  #endregion

  #region Row Spacing struct conversion.
  private static DMM.RowSpacing? GetRowSpacing(DXM.EquationArrayProperties openXmlElement)
  {
    var rule = GetRowSpacingRule(openXmlElement);
    var val = GetRowSpacingValue(openXmlElement);
    if (rule == null && val == null)
      return null;
    return new DMM.RowSpacing(rule ?? DMM.RowSpacingRuleKind.Single, val);
  }

  private static bool CmpRowSpacing(DXM.EquationArrayProperties openXmlElement, DMM.RowSpacing? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null)
    {
      var ok = true;
      if (!CmpRowSpacingRule(openXmlElement, value?.Rule, diffs, objName, propName))
        ok = false;
      if (!CmpRowSpacingValue(openXmlElement, value?.Value, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;

  }

  private static void SetRowSpacing(DXM.EquationArrayProperties openXmlElement, DMM.RowSpacing? value)
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

  #region ControlProperties conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.EquationArrayProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }

  private static bool CmpControlProperties(DXM.EquationArrayProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName, propName);
  }

  private static void SetControlProperties(DXM.EquationArrayProperties openXmlElement, DMM.ControlProperties? value)
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

  #region EquationArrayProperties model conversion.
  public static DMM.EquationArrayProperties? CreateModelElement(DXM.EquationArrayProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.EquationArrayProperties();
      model.BaseJustification = GetBaseJustification(openXmlElement);
      model.MaxDistribution = GetMaxDistribution(openXmlElement);
      model.ObjectDistribution = GetObjectDistribution(openXmlElement);
      model.RowSpacing = GetRowSpacing(openXmlElement);
      model.ControlProperties = GetControlProperties(openXmlElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXM.EquationArrayProperties? openXmlElement, DMM.EquationArrayProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpBaseJustification(openXmlElement, model.BaseJustification, diffs, objName, propName))
        ok = false;
      if (!CmpMaxDistribution(openXmlElement, model.MaxDistribution, diffs, objName, propName))
        ok = false;
      if (!CmpObjectDistribution(openXmlElement, model.ObjectDistribution, diffs, objName, propName))
        ok = false;
      if (!CmpRowSpacing(openXmlElement, model.RowSpacing, diffs, objName, propName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, model.ControlProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.EquationArrayProperties model)
    where OpenXmlElementType : DXM.EquationArrayProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXM.EquationArrayProperties openXmlElement, DMM.EquationArrayProperties model)
  {
    SetBaseJustification(openXmlElement, model?.BaseJustification);
    SetMaxDistribution(openXmlElement, model?.MaxDistribution);
    SetObjectDistribution(openXmlElement, model?.ObjectDistribution);
    SetRowSpacing(openXmlElement, model?.RowSpacing);
    SetControlProperties(openXmlElement, model?.ControlProperties);
  }
  #endregion
}
