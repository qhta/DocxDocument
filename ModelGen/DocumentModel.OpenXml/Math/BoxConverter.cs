namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Box Function.
/// </summary>
public static class BoxConverter
{
  /// <summary>
  /// Box Properties.
  /// </summary>
  private static DMMath.BoxProperties? GetBoxProperties(DXMath.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.BoxProperties>();
    if (element != null)
      return DMXMath.BoxPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBoxProperties(DXMath.Box openXmlElement, DMMath.BoxProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BoxPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.BoxProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBoxProperties(DXMath.Box openXmlElement, DMMath.BoxProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BoxProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BoxPropertiesConverter.CreateOpenXmlElement<DXMath.BoxProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (element != null)
      return DMXMath.BaseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBase(DXMath.Box openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Base>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBase(DXMath.Box openXmlElement, DMMath.Base? value)
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
  
  public static DocumentModel.Math.Box? CreateModelElement(DXMath.Box? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Box();
      value.BoxProperties = GetBoxProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.Box? openXmlElement, DMMath.Box? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBoxProperties(openXmlElement, value.BoxProperties, diffs, objName))
        ok = false;
      if (!CmpBase(openXmlElement, value.Base, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.Box value)
    where OpenXmlElementType: DXMath.Box, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.Box openXmlElement, DMMath.Box value)
  {
    SetBoxProperties(openXmlElement, value?.BoxProperties);
    SetBase(openXmlElement, value?.Base);
  }
}
