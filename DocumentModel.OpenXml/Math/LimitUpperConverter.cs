namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Upper-Limit Function.
/// </summary>
public static class LimitUpperConverter
{
  /// <summary>
  /// Upper Limit Properties.
  /// </summary>
  private static DMMath.LimitUpperProperties? GetLimitUpperProperties(DXMath.LimitUpper openXmlElement)
  {
    return DMXMath.LimitUpperPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.LimitUpperProperties>());
  }
  
  private static bool CmpLimitUpperProperties(DXMath.LimitUpper openXmlElement, DMMath.LimitUpperProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitUpperPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.LimitUpperProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLimitUpperProperties(DXMath.LimitUpper openXmlElement, DMMath.LimitUpperProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.LimitUpperProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.LimitUpperPropertiesConverter.CreateOpenXmlElement<DXMath.LimitUpperProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.LimitUpper openXmlElement)
  {
    return DMXMath.BaseConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Base>());
  }
  
  private static bool CmpBase(DXMath.LimitUpper openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Base>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBase(DXMath.LimitUpper openXmlElement, DMMath.Base? value)
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
  /// Limit (Upper).
  /// </summary>
  private static DMMath.Limit? GetLimit(DXMath.LimitUpper openXmlElement)
  {
    return DMXMath.LimitConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Limit>());
  }
  
  private static bool CmpLimit(DXMath.LimitUpper openXmlElement, DMMath.Limit? value, DiffList? diffs, string? objName)
  {
    return DMXMath.LimitConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Limit>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLimit(DXMath.LimitUpper openXmlElement, DMMath.Limit? value)
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
  
  public static DMMath.LimitUpper? CreateModelElement(DXMath.LimitUpper? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.LimitUpper();
      value.LimitUpperProperties = GetLimitUpperProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      value.Limit = GetLimit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.LimitUpper? openXmlElement, DMMath.LimitUpper? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLimitUpperProperties(openXmlElement, value.LimitUpperProperties, diffs, objName))
        ok = false;
      if (!CmpBase(openXmlElement, value.Base, diffs, objName))
        ok = false;
      if (!CmpLimit(openXmlElement, value.Limit, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.LimitUpper? value)
    where OpenXmlElementType: DXMath.LimitUpper, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLimitUpperProperties(openXmlElement, value?.LimitUpperProperties);
      SetBase(openXmlElement, value?.Base);
      SetLimit(openXmlElement, value?.Limit);
      return openXmlElement;
    }
    return default;
  }
}
