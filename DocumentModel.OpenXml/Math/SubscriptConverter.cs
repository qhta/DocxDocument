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
    return DMXMath.SubscriptPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.SubscriptProperties>());
  }
  
  private static bool CmpSubscriptProperties(DXMath.Subscript openXmlElement, DMMath.SubscriptProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubscriptPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.SubscriptProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXMath.BaseConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Base>());
  }
  
  private static bool CmpBase(DXMath.Subscript openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Base>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXMath.SubArgumentConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.SubArgument>());
  }
  
  private static bool CmpSubArgument(DXMath.Subscript openXmlElement, DMMath.SubArgument? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubArgumentConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.SubArgument>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMMath.Subscript? CreateModelElement(DXMath.Subscript? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Subscript();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Subscript? value)
    where OpenXmlElementType: DXMath.Subscript, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSubscriptProperties(openXmlElement, value?.SubscriptProperties);
      SetBase(openXmlElement, value?.Base);
      SetSubArgument(openXmlElement, value?.SubArgument);
      return openXmlElement;
    }
    return default;
  }
}
