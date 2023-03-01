namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Subscript Function.
/// </summary>
public static class SubscriptConverter
{
  /// <summary>
  /// Subscript Properties.
  /// </summary>
  private static DMMath.SubscriptProperties? GetSubscriptProperties(DXMath.Subscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.SubscriptProperties>();
    if (element != null)
      return DMXMath.SubscriptPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubscriptProperties(DXMath.Subscript openXmlElement, DMMath.SubscriptProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubscriptPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.SubscriptProperties>(), value, diffs, objName);
  }
  
  private static void SetSubscriptProperties(DXMath.Subscript openXmlElement, DMMath.SubscriptProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SubscriptProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SubscriptPropertiesConverter.CreateOpenXmlElement<DXMath.SubscriptProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.Subscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (element != null)
      return DMXMath.BaseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBase(DXMath.Subscript openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Base>(), value, diffs, objName);
  }
  
  private static void SetBase(DXMath.Subscript openXmlElement, DMMath.Base? value)
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
  /// Subscript (Subscript function).
  /// </summary>
  private static DMMath.SubArgument? GetSubArgument(DXMath.Subscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.SubArgument>();
    if (element != null)
      return DMXMath.SubArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubArgument(DXMath.Subscript openXmlElement, DMMath.SubArgument? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.SubArgument>(), value, diffs, objName);
  }
  
  private static void SetSubArgument(DXMath.Subscript openXmlElement, DMMath.SubArgument? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SubArgument>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SubArgumentConverter.CreateOpenXmlElement<DXMath.SubArgument>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.Subscript? CreateModelElement(DXMath.Subscript? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Subscript();
      value.SubscriptProperties = GetSubscriptProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      value.SubArgument = GetSubArgument(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.Subscript? openXmlElement, DMMath.Subscript? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSubscriptProperties(openXmlElement, value.SubscriptProperties, diffs, objName))
        ok = false;
      if (!CmpBase(openXmlElement, value.Base, diffs, objName))
        ok = false;
      if (!CmpSubArgument(openXmlElement, value.SubArgument, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.Subscript value)
    where OpenXmlElementType: DXMath.Subscript, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.Subscript openXmlElement, DMMath.Subscript value)
  {
    SetSubscriptProperties(openXmlElement, value?.SubscriptProperties);
    SetBase(openXmlElement, value?.Base);
    SetSubArgument(openXmlElement, value?.SubArgument);
  }
}
