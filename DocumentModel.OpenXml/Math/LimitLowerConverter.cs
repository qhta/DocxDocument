namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.LimitLower"/> class from/to OpenXml converter.
/// </summary>
public static class LimitLowerConverter
{
  #region Lower Limit Properties conversion.
  private static DMM.LimitLowerProperties? GetLimitLowerProperties(DXM.LimitLower openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.LimitLowerProperties>();
    if (element != null)
      return DMXM.LimitLowerPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLimitLowerProperties(DXM.LimitLower openXmlElement, DMM.LimitLowerProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.LimitLowerPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.LimitLowerProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetLimitLowerProperties(DXM.LimitLower openXmlElement, DMM.LimitLowerProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.LimitLowerProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.LimitLowerPropertiesConverter.CreateOpenXmlElement<DXM.LimitLowerProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Base conversion.
  private static DMM.Argument? GetArgument(DXM.LimitLower openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Base>();
    if (element != null)
      return DMXM.ArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgument(DXM.LimitLower openXmlElement, DMM.Argument? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName, propName);
  }
  
  private static void SetArgument(DXM.LimitLower openXmlElement, DMM.Argument? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Base>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.ArgumentConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Limit (Lower) conversion.
  private static DMM.Limit? GetLimit(DXM.LimitLower openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Limit>();
    if (element != null)
      return DMXM.LimitConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLimit(DXM.LimitLower openXmlElement, DMM.Limit? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.LimitConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Limit>(), value, diffs, objName, propName);
  }
  
  private static void SetLimit(DXM.LimitLower openXmlElement, DMM.Limit? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Limit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.LimitConverter.CreateOpenXmlElement<DXM.Limit>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region LimitLower model conversion.
  public static DMM.LimitLower? CreateModelElement(DXM.LimitLower? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.LimitLower();
      model.LimitLowerProperties = GetLimitLowerProperties(openXmlElement);
      model.Argument = GetArgument(openXmlElement);
      model.Limit = GetLimit(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.LimitLower? openXmlElement, DMM.LimitLower? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpLimitLowerProperties(openXmlElement, model.LimitLowerProperties, diffs, objName, propName))
        ok = false;
      if (!CmpArgument(openXmlElement, model.Argument, diffs, objName, propName))
        ok = false;
      if (!CmpLimit(openXmlElement, model.Limit, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.LimitLower CreateOpenXmlElement(DMM.LimitLower model)
  {
    var openXmlElement = new DXM.LimitLower();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.LimitLower openXmlElement, DMM.LimitLower model)
  {
    SetLimitLowerProperties(openXmlElement, model?.LimitLowerProperties);
    SetArgument(openXmlElement, model?.Argument);
    SetLimit(openXmlElement, model?.Limit);
    return true;
  }
  #endregion
}
