namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Lower-Limit Function.
/// </summary>
public static class LimitLowerConverter
{
  /// <summary>
  /// Lower Limit Properties.
  /// </summary>
  private static DMMath.LimitLowerProperties? GetLimitLowerProperties(DXMath.LimitLower openXmlElement)
  {
    return DMXMath.LimitLowerPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.LimitLowerProperties>());
  }
  
  private static bool CmpLimitLowerProperties(DXMath.LimitLower openXmlElement, DMMath.LimitLowerProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitLowerPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.LimitLowerProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLimitLowerProperties(DXMath.LimitLower openXmlElement, DMMath.LimitLowerProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.LimitLowerProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.LimitLowerPropertiesConverter.CreateOpenXmlElement<DXMath.LimitLowerProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.LimitLower openXmlElement)
  {
    return DMXMath.BaseConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Base>());
  }
  
  private static bool CmpBase(DXMath.LimitLower openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Base>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBase(DXMath.LimitLower openXmlElement, DMMath.Base? value)
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
  
  /// <summary>
  /// Limit (Lower).
  /// </summary>
  private static DMMath.Limit? GetLimit(DXMath.LimitLower openXmlElement)
  {
    return DMXMath.LimitConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Limit>());
  }
  
  private static bool CmpLimit(DXMath.LimitLower openXmlElement, DMMath.Limit? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Limit>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLimit(DXMath.LimitLower openXmlElement, DMMath.Limit? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Limit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.LimitConverter.CreateOpenXmlElement<DXMath.Limit>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.LimitLower? CreateModelElement(DXMath.LimitLower? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.LimitLower();
      value.LimitLowerProperties = GetLimitLowerProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      value.Limit = GetLimit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.LimitLower? openXmlElement, DMMath.LimitLower? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLimitLowerProperties(openXmlElement, value.LimitLowerProperties, diffs, objName))
        ok = false;
      if (!CmpBase(openXmlElement, value.Base, diffs, objName))
        ok = false;
      if (!CmpLimit(openXmlElement, value.Limit, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.LimitLower? value)
    where OpenXmlElementType: DXMath.LimitLower, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLimitLowerProperties(openXmlElement, value?.LimitLowerProperties);
      SetBase(openXmlElement, value?.Base);
      SetLimit(openXmlElement, value?.Limit);
      return openXmlElement;
    }
    return default;
  }
}
