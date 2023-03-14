namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Border-Box Function.
/// </summary>
public static class BorderBoxConverter
{
  /// <summary>
  /// Border Box Properties.
  /// </summary>
  private static DMMath.BorderBoxProperties? GetBorderBoxProperties(DXMath.BorderBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.BorderBoxProperties>();
    if (element != null)
      return DMXMath.BorderBoxPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBorderBoxProperties(DXMath.BorderBox openXmlElement, DMMath.BorderBoxProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BorderBoxPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.BorderBoxProperties>(), value, diffs, objName);
  }
  
  private static void SetBorderBoxProperties(DXMath.BorderBox openXmlElement, DMMath.BorderBoxProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BorderBoxProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BorderBoxPropertiesConverter.CreateOpenXmlElement<DXMath.BorderBoxProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.BorderBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (element != null)
      return DMXMath.BaseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBase(DXMath.BorderBox openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Base>(), value, diffs, objName);
  }
  
  private static void SetBase(DXMath.BorderBox openXmlElement, DMMath.Base? value)
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
  
  public static DMMath.BorderBox? CreateModelElement(DXMath.BorderBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.BorderBox();
      value.BorderBoxProperties = GetBorderBoxProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.BorderBox? openXmlElement, DMMath.BorderBox? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBorderBoxProperties(openXmlElement, value.BorderBoxProperties, diffs, objName))
        ok = false;
      if (!CmpBase(openXmlElement, value.Base, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXMath.BorderBox CreateOpenXmlElement(DMMath.BorderBox value)
  {
    var openXmlElement = new DXMath.BorderBox();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXMath.BorderBox openXmlElement, DMMath.BorderBox value)
  {
    SetBorderBoxProperties(openXmlElement, value?.BorderBoxProperties);
    SetBase(openXmlElement, value?.Base);
    return true;
  }
}
