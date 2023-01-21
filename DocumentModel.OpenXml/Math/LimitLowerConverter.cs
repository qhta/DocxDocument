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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.LimitLowerProperties>();
    if (itemElement != null)
      return DMXMath.LimitLowerPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      return DMXMath.BaseConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Limit>();
    if (itemElement != null)
      return DMXMath.LimitConverter.CreateModelElement(itemElement);
    return null;
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
