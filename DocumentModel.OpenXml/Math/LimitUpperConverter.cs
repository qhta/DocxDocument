namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.LimitUpper"/> class from/to OpenXml converter.
/// </summary>
public static class LimitUpperConverter
{
  #region Upper Limit Properties conversion.
  private static DMM.LimitUpperProperties? GetLimitUpperProperties(DXM.LimitUpper openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.LimitUpperProperties>();
    if (element != null)
      return DMXM.LimitUpperPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLimitUpperProperties(DXM.LimitUpper openXmlElement, DMM.LimitUpperProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.LimitUpperPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.LimitUpperProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetLimitUpperProperties(DXM.LimitUpper openXmlElement, DMM.LimitUpperProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.LimitUpperProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.LimitUpperPropertiesConverter.CreateOpenXmlElement<DXM.LimitUpperProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Base conversion.
  private static DMM.Argument? GetArgument(DXM.LimitUpper openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Base>();
    if (element != null)
      return DMXM.ArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgument(DXM.LimitUpper openXmlElement, DMM.Argument? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName, propName);
  }
  
  private static void SetArgument(DXM.LimitUpper openXmlElement, DMM.Argument? value)
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

  #region Limit (Upper) conversion.
  private static DMM.Limit? GetLimit(DXM.LimitUpper openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Limit>();
    if (element != null)
      return DMXM.LimitConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLimit(DXM.LimitUpper openXmlElement, DMM.Limit? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.LimitConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Limit>(), value, diffs, objName, propName);
  }
  
  private static void SetLimit(DXM.LimitUpper openXmlElement, DMM.Limit? value)
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

  #region LimitUpper model conversion.
  public static DMM.LimitUpper? CreateModelElement(DXM.LimitUpper? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.LimitUpper();
      model.LimitUpperProperties = GetLimitUpperProperties(openXmlElement);
      model.Argument = GetArgument(openXmlElement);
      model.Limit = GetLimit(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.LimitUpper? openXmlElement, DMM.LimitUpper? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpLimitUpperProperties(openXmlElement, model.LimitUpperProperties, diffs, objName, propName))
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
  
  public static DXM.LimitUpper CreateOpenXmlElement(DMM.LimitUpper model)
  {
    var openXmlElement = new DXM.LimitUpper();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.LimitUpper openXmlElement, DMM.LimitUpper model)
  {
    SetLimitUpperProperties(openXmlElement, model.LimitUpperProperties);
    SetArgument(openXmlElement, model.Argument);
    SetLimit(openXmlElement, model.Limit);
    return true;
  }
  #endregion
}
