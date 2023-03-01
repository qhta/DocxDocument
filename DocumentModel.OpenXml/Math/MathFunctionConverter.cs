namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Function Apply Function.
/// </summary>
public static class MathFunctionConverter
{
  /// <summary>
  /// Function Properties.
  /// </summary>
  private static DMMath.FunctionProperties? GetFunctionProperties(DXMath.MathFunction openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.FunctionProperties>();
    if (element != null)
      return DMXMath.FunctionPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFunctionProperties(DXMath.MathFunction openXmlElement, DMMath.FunctionProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.FunctionPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.FunctionProperties>(), value, diffs, objName);
  }
  
  private static void SetFunctionProperties(DXMath.MathFunction openXmlElement, DMMath.FunctionProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.FunctionProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.FunctionPropertiesConverter.CreateOpenXmlElement<DXMath.FunctionProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Function Name.
  /// </summary>
  private static DMMath.FunctionName? GetFunctionName(DXMath.MathFunction openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.FunctionName>();
    if (element != null)
      return DMXMath.FunctionNameConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFunctionName(DXMath.MathFunction openXmlElement, DMMath.FunctionName? value, DiffList? diffs, string? objName)
  {
    return DMXMath.FunctionNameConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.FunctionName>(), value, diffs, objName);
  }
  
  private static void SetFunctionName(DXMath.MathFunction openXmlElement, DMMath.FunctionName? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.FunctionName>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.FunctionNameConverter.CreateOpenXmlElement<DXMath.FunctionName>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base (Argument).
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.MathFunction openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (element != null)
      return DMXMath.BaseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBase(DXMath.MathFunction openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Base>(), value, diffs, objName);
  }
  
  private static void SetBase(DXMath.MathFunction openXmlElement, DMMath.Base? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BaseConverter.CreateOpenXmlElement<DXMath.Base>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.MathFunction? CreateModelElement(DXMath.MathFunction? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.MathFunction();
      value.FunctionProperties = GetFunctionProperties(openXmlElement);
      value.FunctionName = GetFunctionName(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.MathFunction? openXmlElement, DMMath.MathFunction? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFunctionProperties(openXmlElement, value.FunctionProperties, diffs, objName))
        ok = false;
      if (!CmpFunctionName(openXmlElement, value.FunctionName, diffs, objName))
        ok = false;
      if (!CmpBase(openXmlElement, value.Base, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.MathFunction value)
    where OpenXmlElementType: DXMath.MathFunction, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.MathFunction openXmlElement, DMMath.MathFunction value)
  {
    SetFunctionProperties(openXmlElement, value?.FunctionProperties);
    SetFunctionName(openXmlElement, value?.FunctionName);
    SetBase(openXmlElement, value?.Base);
  }
}
