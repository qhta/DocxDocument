namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ShapePropertiesExtension Class.
/// </summary>
public static class ShapePropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.ShapePropertiesExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDraw.ShapePropertiesExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDraws.HiddenFillProperties? GetHiddenFillProperties(DXDraw.ShapePropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.HiddenFillProperties>();
    if (itemElement != null)
      return DMXDraws.HiddenFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHiddenFillProperties(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.HiddenFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.HiddenFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HiddenFillPropertiesConverter.CreateOpenXmlElement<DXO2010Draw.HiddenFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.HiddenLineProperties? GetHiddenLineProperties(DXDraw.ShapePropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.HiddenLineProperties>();
    if (itemElement != null)
      return DMXDraws.HiddenLinePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHiddenLineProperties(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.HiddenLineProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.HiddenLineProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HiddenLinePropertiesConverter.CreateOpenXmlElement<DXO2010Draw.HiddenLineProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.HiddenEffectsProperties? GetHiddenEffectsProperties(DXDraw.ShapePropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.HiddenEffectsProperties>();
    if (itemElement != null)
      return DMXDraws.HiddenEffectsPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHiddenEffectsProperties(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.HiddenEffectsProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.HiddenEffectsProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HiddenEffectsPropertiesConverter.CreateOpenXmlElement<DXO2010Draw.HiddenEffectsProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.HiddenScene3D? GetHiddenScene3D(DXDraw.ShapePropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.HiddenScene3D>();
    if (itemElement != null)
      return DMXDraws.HiddenScene3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHiddenScene3D(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.HiddenScene3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.HiddenScene3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HiddenScene3DConverter.CreateOpenXmlElement<DXO2010Draw.HiddenScene3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.HiddenShape3D? GetHiddenShape3D(DXDraw.ShapePropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.HiddenShape3D>();
    if (itemElement != null)
      return DMXDraws.HiddenShape3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHiddenShape3D(DXDraw.ShapePropertiesExtension openXmlElement, DMDraws.HiddenShape3D? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.HiddenShape3D>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HiddenShape3DConverter.CreateOpenXmlElement<DXO2010Draw.HiddenShape3D>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShadowObscured(DXDraw.ShapePropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ShadowObscured>();
    return itemElement != null;
  }
  
  private static void SetShadowObscured(DXDraw.ShapePropertiesExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.ShadowObscured>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010Draw.ShadowObscured();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.ShapePropertiesExtension? CreateModelElement(DXDraw.ShapePropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ShapePropertiesExtension();
      value.Uri = GetUri(openXmlElement);
      value.HiddenFillProperties = GetHiddenFillProperties(openXmlElement);
      value.HiddenLineProperties = GetHiddenLineProperties(openXmlElement);
      value.HiddenEffectsProperties = GetHiddenEffectsProperties(openXmlElement);
      value.HiddenScene3D = GetHiddenScene3D(openXmlElement);
      value.HiddenShape3D = GetHiddenShape3D(openXmlElement);
      value.ShadowObscured = GetShadowObscured(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ShapePropertiesExtension? value)
    where OpenXmlElementType: DXDraw.ShapePropertiesExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetHiddenFillProperties(openXmlElement, value?.HiddenFillProperties);
      SetHiddenLineProperties(openXmlElement, value?.HiddenLineProperties);
      SetHiddenEffectsProperties(openXmlElement, value?.HiddenEffectsProperties);
      SetHiddenScene3D(openXmlElement, value?.HiddenScene3D);
      SetHiddenShape3D(openXmlElement, value?.HiddenShape3D);
      SetShadowObscured(openXmlElement, value?.ShadowObscured);
      return openXmlElement;
    }
    return default;
  }
}
