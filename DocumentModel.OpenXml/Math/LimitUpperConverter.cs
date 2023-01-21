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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.LimitUpperProperties>();
    if (itemElement != null)
      return DMXMath.LimitUpperPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      return DMXMath.BaseConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Limit>();
    if (itemElement != null)
      return DMXMath.LimitConverter.CreateModelElement(itemElement);
    return null;
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
