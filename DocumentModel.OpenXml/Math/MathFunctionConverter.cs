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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.FunctionProperties>();
    if (itemElement != null)
      return DMXMath.FunctionPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.FunctionName>();
    if (itemElement != null)
      return DMXMath.FunctionNameConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      return DMXMath.BaseConverter.CreateModelElement(itemElement);
    return null;
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
