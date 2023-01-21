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
    var itemElement = openXmlElement.GetFirstChild<DXMath.ShowPhantom>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetShowPhantom(DXMath.PhantomProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ShowPhantom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.ShowPhantom, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Phantom Zero Width.
  /// </summary>
  private static DMMath.BooleanKind? GetZeroWidth(DXMath.PhantomProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ZeroWidth>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetZeroWidth(DXMath.PhantomProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ZeroWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.ZeroWidth, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Phantom Zero Ascent.
  /// </summary>
  private static DMMath.BooleanKind? GetZeroAscent(DXMath.PhantomProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ZeroAscent>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetZeroAscent(DXMath.PhantomProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ZeroAscent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.ZeroAscent, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Phantom Zero Descent.
  /// </summary>
  private static DMMath.BooleanKind? GetZeroDescent(DXMath.PhantomProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ZeroDescent>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetZeroDescent(DXMath.PhantomProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ZeroDescent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.ZeroDescent, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Transparent (Phantom).
  /// </summary>
  private static DMMath.BooleanKind? GetTransparent(DXMath.PhantomProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Transparent>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTransparent(DXMath.PhantomProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Transparent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.Transparent, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.PhantomProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMMath.PhantomProperties? CreateModelElement(DXMath.PhantomProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.PhantomProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.PhantomProperties? value)
    where OpenXmlElementType: DXMath.PhantomProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShowPhantom(openXmlElement, value?.ShowPhantom);
      SetZeroWidth(openXmlElement, value?.ZeroWidth);
      SetZeroAscent(openXmlElement, value?.ZeroAscent);
      SetZeroDescent(openXmlElement, value?.ZeroDescent);
      SetTransparent(openXmlElement, value?.Transparent);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}
