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
    return DMXMath.FunctionPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.FunctionProperties>());
  }
  
  private static bool CmpFunctionProperties(DXMath.MathFunction openXmlElement, DMMath.FunctionProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.FunctionPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.FunctionProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXMath.FunctionNameConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.FunctionName>());
  }
  
  private static bool CmpFunctionName(DXMath.MathFunction openXmlElement, DMMath.FunctionName? value, DiffList? diffs, string? objName)
  {
    return DMXMath.FunctionNameConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.FunctionName>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXMath.BaseConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Base>());
  }
  
  private static bool CmpBase(DXMath.MathFunction openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Base>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMMath.MathFunction? CreateModelElement(DXMath.MathFunction? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.MathFunction();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.MathFunction? value)
    where OpenXmlElementType: DXMath.MathFunction, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFunctionProperties(openXmlElement, value?.FunctionProperties);
      SetFunctionName(openXmlElement, value?.FunctionName);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
