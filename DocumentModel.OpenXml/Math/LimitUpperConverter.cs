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
  
  private static bool CmpLimitUpperProperties(DXM.LimitUpper openXmlElement, DMM.LimitUpperProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.LimitUpperPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.LimitUpperProperties>(), value, diffs, objName);
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
  
  private static bool CmpArgument(DXM.LimitUpper openXmlElement, DMM.Argument? value, DiffList? diffs, string? objName)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName);
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
  
  private static bool CmpLimit(DXM.LimitUpper openXmlElement, DMM.Limit? value, DiffList? diffs, string? objName)
  {
    return DMXM.LimitConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Limit>(), value, diffs, objName);
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
  
  public static bool CompareModelElement(DXM.LimitUpper? openXmlElement, DMM.LimitUpper? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpLimitUpperProperties(openXmlElement, model.LimitUpperProperties, diffs, objName))
        ok = false;
      if (!CmpArgument(openXmlElement, model.Argument, diffs, objName))
        ok = false;
      if (!CmpLimit(openXmlElement, model.Limit, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
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
