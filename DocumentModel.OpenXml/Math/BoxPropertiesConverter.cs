namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.BoxProperties"/> class from/to OpenXml converter.
/// </summary>
public static class BoxPropertiesConverter
{
  #region Operator Emulator. conversion.
  private static bool? GetOperatorEmulator(DXM.BoxProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.OperatorEmulator>()?.Val?.Value);
  }
  
  private static bool CmpOperatorEmulator(DXM.BoxProperties openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.OperatorEmulator>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetOperatorEmulator(DXM.BoxProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.OperatorEmulator>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement<DXM.OperatorEmulator>(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.OperatorEmulator>((bool)value));
  }
  #endregion

  #region No Break conversion.
  private static bool? GetNoBreak(DXM.BoxProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.NoBreak>()?.Val?.Value);
  }
  
  private static bool CmpNoBreak(DXM.BoxProperties openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.NoBreak>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetNoBreak(DXM.BoxProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.NoBreak>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.NoBreak>((bool)value));
  }
  #endregion

  #region Differential conversion.
  private static bool? GetDifferential(DXM.BoxProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.Differential>()?.Val?.Value);
  }
  
  private static bool CmpDifferential(DXM.BoxProperties openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.Differential>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetDifferential(DXM.BoxProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Differential>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.Differential>((bool)value));
  }
  #endregion

  #region Break conversion.
  private static DMM.Break? GetBreak(DXM.BoxProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Break>();
    if (element != null)
      return DMXM.BreakConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBreak(DXM.BoxProperties openXmlElement, DMM.Break? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.BreakConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Break>(), value, diffs, objName, propName);
  }
  
  private static void SetBreak(DXM.BoxProperties openXmlElement, DMM.Break? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Break>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.BreakConverter.CreateOpenXmlElement<DXM.Break>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Alignment conversion.
  private static bool? GetAlignment(DXM.BoxProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.Alignment>()?.Val?.Value);
  }
  
  private static bool CmpAlignment(DXM.BoxProperties openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.Alignment>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAlignment(DXM.BoxProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Alignment>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.Alignment>((bool)value));
  }
  #endregion

  #region ControlProperties conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.BoxProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.BoxProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetControlProperties(DXM.BoxProperties openXmlElement, DMM.ControlProperties? value)
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

  #region BoxProperties model conversion.
  public static DMM.BoxProperties? CreateModelElement(DXM.BoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.BoxProperties();
      model.OperatorEmulator = GetOperatorEmulator(openXmlElement);
      model.NoBreak = GetNoBreak(openXmlElement);
      model.Differential = GetDifferential(openXmlElement);
      model.Break = GetBreak(openXmlElement);
      model.Alignment = GetAlignment(openXmlElement);
      model.ControlProperties = GetControlProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.BoxProperties? openXmlElement, DMM.BoxProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpOperatorEmulator(openXmlElement, model.OperatorEmulator, diffs, objName, propName))
        ok = false;
      if (!CmpNoBreak(openXmlElement, model.NoBreak, diffs, objName, propName))
        ok = false;
      if (!CmpDifferential(openXmlElement, model.Differential, diffs, objName, propName))
        ok = false;
      if (!CmpBreak(openXmlElement, model.Break, diffs, objName, propName))
        ok = false;
      if (!CmpAlignment(openXmlElement, model.Alignment, diffs, objName, propName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, model.ControlProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.BoxProperties model)
    where OpenXmlElementType: DXM.BoxProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.BoxProperties openXmlElement, DMM.BoxProperties model)
  {
    SetOperatorEmulator(openXmlElement, model?.OperatorEmulator);
    SetNoBreak(openXmlElement, model?.NoBreak);
    SetDifferential(openXmlElement, model?.Differential);
    SetBreak(openXmlElement, model?.Break);
    SetAlignment(openXmlElement, model?.Alignment);
    SetControlProperties(openXmlElement, model?.ControlProperties);
  }
  #endregion
}
