namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Function"/> class from/to OpenXml converter.
/// </summary>
public static class MathFunctionConverter
{
  #region Function Properties. conversion.
  private static DMM.FunctionProperties? GetFunctionProperties(DXM.MathFunction openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.FunctionProperties>();
    if (element != null)
      return DMXM.FunctionPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFunctionProperties(DXM.MathFunction openXmlElement, DMM.FunctionProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.FunctionPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.FunctionProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetFunctionProperties(DXM.MathFunction openXmlElement, DMM.FunctionProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.FunctionProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.FunctionPropertiesConverter.CreateOpenXmlElement<DXM.FunctionProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Function Name conversion.
  private static DMM.FunctionName? GetFunctionName(DXM.MathFunction openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.FunctionName>();
    if (element != null)
      return DMXM.FunctionNameConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFunctionName(DXM.MathFunction openXmlElement, DMM.FunctionName? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.FunctionNameConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.FunctionName>(), value, diffs, objName, propName);
  }
  
  private static void SetFunctionName(DXM.MathFunction openXmlElement, DMM.FunctionName? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.FunctionName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.FunctionNameConverter.CreateOpenXmlElement<DXM.FunctionName>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Base (Argument) conversion.
  private static DMM.Argument? GetArgument(DXM.MathFunction openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Base>();
    if (element != null)
      return DMXM.ArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgument(DXM.MathFunction openXmlElement, DMM.Argument? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName, propName);
  }
  
  private static void SetArgument(DXM.MathFunction openXmlElement, DMM.Argument? value)
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

  #region MathFunction model conversion.
  public static DMM.Function? CreateModelElement(DXM.MathFunction? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.Function();
      model.FunctionProperties = GetFunctionProperties(openXmlElement);
      model.FunctionName = GetFunctionName(openXmlElement);
      model.Argument = GetArgument(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.MathFunction? openXmlElement, DMM.Function? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpFunctionProperties(openXmlElement, model.FunctionProperties, diffs, objName, propName))
        ok = false;
      if (!CmpFunctionName(openXmlElement, model.FunctionName, diffs, objName, propName))
        ok = false;
      if (!CmpArgument(openXmlElement, model.Argument, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.MathFunction CreateOpenXmlElement(DMM.Function model)
  {
    var openXmlElement = new DXM.MathFunction();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.MathFunction openXmlElement, DMM.Function model)
  {
    SetFunctionProperties(openXmlElement, model.FunctionProperties);
    SetFunctionName(openXmlElement, model.FunctionName);
    SetArgument(openXmlElement, model.Argument);
    return true;
  }
  #endregion
}
