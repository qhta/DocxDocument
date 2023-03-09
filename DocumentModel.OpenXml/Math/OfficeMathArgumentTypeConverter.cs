namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Defines the OfficeMathArgumentType Class.
/// </summary>
public static class OfficeMathArgumentTypeConverter
{
  /// <summary>
  /// Argument Properties.
  /// </summary>
  private static DMMath.ArgumentProperties? GetArgumentProperties(DXMath.OfficeMathArgumentType openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.ArgumentProperties>();
    if (element != null)
      return DMXMath.ArgumentPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgumentProperties(DXMath.OfficeMathArgumentType openXmlElement, DMMath.ArgumentProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ArgumentPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.ArgumentProperties>(), value, diffs, objName);
  }
  
  private static void SetArgumentProperties(DXMath.OfficeMathArgumentType openXmlElement, DMMath.ArgumentProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ArgumentProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ArgumentPropertiesConverter.CreateOpenXmlElement<DXMath.ArgumentProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.OfficeMathArgumentType? CreateModelElement(DXMath.OfficeMathArgumentType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.OfficeMathArgumentType();
      value.ArgumentProperties = GetArgumentProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.OfficeMathArgumentType? openXmlElement, DMMath.OfficeMathArgumentType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpArgumentProperties(openXmlElement, value.ArgumentProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.OfficeMathArgumentType value)
    where OpenXmlElementType: DXMath.OfficeMathArgumentType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.OfficeMathArgumentType openXmlElement, DMMath.OfficeMathArgumentType value)
  {
    SetArgumentProperties(openXmlElement, value?.ArgumentProperties);
  }
}
