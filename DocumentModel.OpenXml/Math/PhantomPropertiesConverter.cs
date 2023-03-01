namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Phantom Properties.
/// </summary>
public static class PhantomPropertiesConverter
{
  /// <summary>
  /// Phantom Show.
  /// </summary>
  private static DMMath.BooleanKind? GetShowPhantom(DXMath.PhantomProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.ShowPhantom>()?.Val?.Value);
  }
  
  private static bool CmpShowPhantom(DXMath.PhantomProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.ShowPhantom>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetShowPhantom(DXMath.PhantomProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ShowPhantom>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.ShowPhantom, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
  }
  
  /// <summary>
  /// Phantom Zero Width.
  /// </summary>
  private static DMMath.BooleanKind? GetZeroWidth(DXMath.PhantomProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.ZeroWidth>()?.Val?.Value);
  }
  
  private static bool CmpZeroWidth(DXMath.PhantomProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.ZeroWidth>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetZeroWidth(DXMath.PhantomProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ZeroWidth>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.ZeroWidth, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
  }
  
  /// <summary>
  /// Phantom Zero Ascent.
  /// </summary>
  private static DMMath.BooleanKind? GetZeroAscent(DXMath.PhantomProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.ZeroAscent>()?.Val?.Value);
  }
  
  private static bool CmpZeroAscent(DXMath.PhantomProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.ZeroAscent>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetZeroAscent(DXMath.PhantomProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ZeroAscent>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.ZeroAscent, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
  }
  
  /// <summary>
  /// Phantom Zero Descent.
  /// </summary>
  private static DMMath.BooleanKind? GetZeroDescent(DXMath.PhantomProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.ZeroDescent>()?.Val?.Value);
  }
  
  private static bool CmpZeroDescent(DXMath.PhantomProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.ZeroDescent>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetZeroDescent(DXMath.PhantomProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ZeroDescent>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.ZeroDescent, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
  }
  
  /// <summary>
  /// Transparent (Phantom).
  /// </summary>
  private static DMMath.BooleanKind? GetTransparent(DXMath.PhantomProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.Transparent>()?.Val?.Value);
  }
  
  private static bool CmpTransparent(DXMath.PhantomProperties openXmlElement, DMMath.BooleanKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(openXmlElement.GetFirstChild<DXMath.Transparent>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetTransparent(DXMath.PhantomProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Transparent>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement, (DMMath.BooleanKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXMath.Transparent, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>((DMMath.BooleanKind)value));
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.PhantomProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (element != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXMath.PhantomProperties openXmlElement, DMMath.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.ControlProperties>(), value, diffs, objName);
  }
  
  private static void SetControlProperties(DXMath.PhantomProperties openXmlElement, DMMath.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.ControlPropertiesConverter.CreateOpenXmlElement<DXMath.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.PhantomProperties? CreateModelElement(DXMath.PhantomProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.PhantomProperties();
      value.ShowPhantom = GetShowPhantom(openXmlElement);
      value.ZeroWidth = GetZeroWidth(openXmlElement);
      value.ZeroAscent = GetZeroAscent(openXmlElement);
      value.ZeroDescent = GetZeroDescent(openXmlElement);
      value.Transparent = GetTransparent(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.PhantomProperties? openXmlElement, DMMath.PhantomProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShowPhantom(openXmlElement, value.ShowPhantom, diffs, objName))
        ok = false;
      if (!CmpZeroWidth(openXmlElement, value.ZeroWidth, diffs, objName))
        ok = false;
      if (!CmpZeroAscent(openXmlElement, value.ZeroAscent, diffs, objName))
        ok = false;
      if (!CmpZeroDescent(openXmlElement, value.ZeroDescent, diffs, objName))
        ok = false;
      if (!CmpTransparent(openXmlElement, value.Transparent, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, value.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMMath.PhantomProperties value)
    where OpenXmlElementType: DXMath.PhantomProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.PhantomProperties openXmlElement, DMMath.PhantomProperties value)
  {
    SetShowPhantom(openXmlElement, value?.ShowPhantom);
    SetZeroWidth(openXmlElement, value?.ZeroWidth);
    SetZeroAscent(openXmlElement, value?.ZeroAscent);
    SetZeroDescent(openXmlElement, value?.ZeroDescent);
    SetTransparent(openXmlElement, value?.Transparent);
    SetControlProperties(openXmlElement, value?.ControlProperties);
  }
}
