namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Bar.
/// </summary>
public static class BarConverter
{
  /// <summary>
  /// Bar Properties.
  /// </summary>
  private static DMMath.BarProperties? GetBarProperties(DXMath.Bar openXmlElement)
  {
    return DMXMath.BarPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.BarProperties>());
  }
  
  private static bool CmpBarProperties(DXMath.Bar openXmlElement, DMMath.BarProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BarPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.BarProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBarProperties(DXMath.Bar openXmlElement, DMMath.BarProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BarProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BarPropertiesConverter.CreateOpenXmlElement<DXMath.BarProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.Bar openXmlElement)
  {
    return DMXMath.BaseConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Base>());
  }
  
  private static bool CmpBase(DXMath.Bar openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Base>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBase(DXMath.Bar openXmlElement, DMMath.Base? value)
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
  
  public static DMMath.Bar? CreateModelElement(DXMath.Bar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Bar();
      value.BarProperties = GetBarProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.Bar? openXmlElement, DMMath.Bar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBarProperties(openXmlElement, value.BarProperties, diffs, objName))
        ok = false;
      if (!CmpBase(openXmlElement, value.Base, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Bar? value)
    where OpenXmlElementType: DXMath.Bar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBarProperties(openXmlElement, value?.BarProperties);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
