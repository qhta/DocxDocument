namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.NaryProperties"/> class from/to OpenXml converter.
/// </summary>
public static class NaryPropertiesConverter
{
  #region n-ary Operator Character. conversion.
  private static String? GetAccentChar(DXM.NaryProperties openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.AccentChar>()?.Val);
  }
  
  private static bool CmpAccentChar(DXM.NaryProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.AccentChar>()?.Val, value, diffs, objName, "Operator");
  }
  
  private static void SetAccentChar(DXM.NaryProperties openXmlElement, String? value)
  {
    StringValueConverter.SetValue<DXM.AccentChar>(openXmlElement, value);
  }
  #endregion

  #region n-ary Limit Location conversion.
  private static DMM.LimitLocationKind? GetLimitLocation(DXM.NaryProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMM.LimitLocationKind>(openXmlElement.GetFirstChild<DXM.LimitLocation>()?.Val?.Value);
  }
  
  private static bool CmpLimitLocation(DXM.NaryProperties openXmlElement, DMM.LimitLocationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.LimitLocationValues, DMM.LimitLocationKind>(openXmlElement.GetFirstChild<DXM.LimitLocation>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetLimitLocation(DXM.NaryProperties openXmlElement, DMM.LimitLocationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.LimitLocation>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitLocationValues, DMM.LimitLocationKind>(itemElement, (DMM.LimitLocationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.LimitLocation, DocumentFormat.OpenXml.Math.LimitLocationValues, DMM.LimitLocationKind>((DMM.LimitLocationKind)value));
  }
  #endregion

  #region n-ary Grow conversion.
  private static bool? GetGrowOperators(DXM.NaryProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.GrowOperators>()?.Val?.Value);
  }
  
  private static bool CmpGrowOperators(DXM.NaryProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.GrowOperators>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetGrowOperators(DXM.NaryProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.GrowOperators>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXM.GrowOperators>((bool)value));
  }
  #endregion

  #region Hide Subscript (n-ary) conversion.
  private static bool? GetHideSubArgument(DXM.NaryProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.HideSubArgument>()?.Val?.Value);
  }
  
  private static bool CmpHideSubArgument(DXM.NaryProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.HideSubArgument>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetHideSubArgument(DXM.NaryProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.HideSubArgument>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXM.HideSubArgument>((bool)value));
  }
  #endregion

  #region Hide Superscript (n-ary) conversion.
  private static bool? GetHideSuperArgument(DXM.NaryProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.HideSuperArgument>()?.Val?.Value);
  }
  
  private static bool CmpHideSuperArgument(DXM.NaryProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.HideSuperArgument>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetHideSuperArgument(DXM.NaryProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.HideSuperArgument>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXM.HideSuperArgument>((bool)value));
  }
  #endregion

  #region ControlProperties conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.NaryProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.NaryProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName);
  }
  
  private static void SetControlProperties(DXM.NaryProperties openXmlElement, DMM.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.ControlPropertiesConverter.CreateOpenXmlElement<DXM.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region NaryProperties model conversion.
  public static DMM.NaryProperties? CreateModelElement(DXM.NaryProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.NaryProperties();
      model.Operator = GetAccentChar(openXmlElement);
      model.LimitLocation = GetLimitLocation(openXmlElement);
      model.GrowOperators = GetGrowOperators(openXmlElement);
      model.HideSubArgument = GetHideSubArgument(openXmlElement);
      model.HideSuperArgument = GetHideSuperArgument(openXmlElement);
      model.ControlProperties = GetControlProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.NaryProperties? openXmlElement, DMM.NaryProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpAccentChar(openXmlElement, model.Operator, diffs, objName))
        ok = false;
      if (!CmpLimitLocation(openXmlElement, model.LimitLocation, diffs, objName))
        ok = false;
      if (!CmpGrowOperators(openXmlElement, model.GrowOperators, diffs, objName))
        ok = false;
      if (!CmpHideSubArgument(openXmlElement, model.HideSubArgument, diffs, objName))
        ok = false;
      if (!CmpHideSuperArgument(openXmlElement, model.HideSuperArgument, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, model.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.NaryProperties model)
    where OpenXmlElementType: DXM.NaryProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.NaryProperties openXmlElement, DMM.NaryProperties model)
  {
    SetAccentChar(openXmlElement, model?.Operator);
    SetLimitLocation(openXmlElement, model?.LimitLocation);
    SetGrowOperators(openXmlElement, model?.GrowOperators);
    SetHideSubArgument(openXmlElement, model?.HideSubArgument);
    SetHideSuperArgument(openXmlElement, model?.HideSuperArgument);
    SetControlProperties(openXmlElement, model?.ControlProperties);
  }
  #endregion
}
