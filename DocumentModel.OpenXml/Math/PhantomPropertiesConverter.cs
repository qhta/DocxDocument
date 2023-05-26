namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.PhantomProperties"/> class from/to OpenXml converter.
/// </summary>
public static class PhantomPropertiesConverter
{
  #region Phantom Show. conversion.
  private static bool? GetShowPhantom(DXM.PhantomProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.ShowPhantom>()?.Val?.Value);
  }
  
  private static bool CmpShowPhantom(DXM.PhantomProperties openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.ShowPhantom>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetShowPhantom(DXM.PhantomProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.ShowPhantom>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.ShowPhantom>((bool)value));
  }
  #endregion

  #region Phantom Zero Width conversion.
  private static bool? GetZeroWidth(DXM.PhantomProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.ZeroWidth>()?.Val?.Value);
  }
  
  private static bool CmpZeroWidth(DXM.PhantomProperties openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.ZeroWidth>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetZeroWidth(DXM.PhantomProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.ZeroWidth>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.ZeroWidth>((bool)value));
  }
  #endregion

  #region Phantom Zero Ascent conversion.
  private static bool? GetZeroAscent(DXM.PhantomProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.ZeroAscent>()?.Val?.Value);
  }
  
  private static bool CmpZeroAscent(DXM.PhantomProperties openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.ZeroAscent>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetZeroAscent(DXM.PhantomProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.ZeroAscent>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.ZeroAscent>((bool)value));
  }
  #endregion

  #region Phantom Zero Descent conversion.
  private static bool? GetZeroDescent(DXM.PhantomProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.ZeroDescent>()?.Val?.Value);
  }
  
  private static bool CmpZeroDescent(DXM.PhantomProperties openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.ZeroDescent>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetZeroDescent(DXM.PhantomProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.ZeroDescent>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.ZeroDescent>((bool)value));
  }
  #endregion

  #region Transparent (Phantom) conversion.
  private static bool? GetTransparent(DXM.PhantomProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.Transparent>()?.Val?.Value);
  }
  
  private static bool CmpTransparent(DXM.PhantomProperties openXmlElement, bool? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.Transparent>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetTransparent(DXM.PhantomProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Transparent>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(BooleanValueConverter.CreateOpenXmlElement<DXM.Transparent>((bool)value));
  }
  #endregion

  #region ControlProperties conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.PhantomProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.PhantomProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetControlProperties(DXM.PhantomProperties openXmlElement, DMM.ControlProperties? value)
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

  #region PhantomProperties model conversion.
  public static DMM.PhantomProperties? CreateModelElement(DXM.PhantomProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.PhantomProperties();
      model.ShowPhantom = GetShowPhantom(openXmlElement);
      model.ZeroWidth = GetZeroWidth(openXmlElement);
      model.ZeroAscent = GetZeroAscent(openXmlElement);
      model.ZeroDescent = GetZeroDescent(openXmlElement);
      model.Transparent = GetTransparent(openXmlElement);
      model.ControlProperties = GetControlProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.PhantomProperties? openXmlElement, DMM.PhantomProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpShowPhantom(openXmlElement, model.ShowPhantom, diffs, objName, propName))
        ok = false;
      if (!CmpZeroWidth(openXmlElement, model.ZeroWidth, diffs, objName, propName))
        ok = false;
      if (!CmpZeroAscent(openXmlElement, model.ZeroAscent, diffs, objName, propName))
        ok = false;
      if (!CmpZeroDescent(openXmlElement, model.ZeroDescent, diffs, objName, propName))
        ok = false;
      if (!CmpTransparent(openXmlElement, model.Transparent, diffs, objName, propName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, model.ControlProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.PhantomProperties model)
    where OpenXmlElementType: DXM.PhantomProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.PhantomProperties openXmlElement, DMM.PhantomProperties model)
  {
    SetShowPhantom(openXmlElement, model?.ShowPhantom);
    SetZeroWidth(openXmlElement, model?.ZeroWidth);
    SetZeroAscent(openXmlElement, model?.ZeroAscent);
    SetZeroDescent(openXmlElement, model?.ZeroDescent);
    SetTransparent(openXmlElement, model?.Transparent);
    SetControlProperties(openXmlElement, model?.ControlProperties);
  }
  #endregion
}
