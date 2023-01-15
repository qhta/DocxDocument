using DocumentFormat.OpenXml.Office2010.Drawing;
using HiddenEffectsProperties = DocumentModel.Drawings.HiddenEffectsProperties;
using HiddenFillProperties = DocumentModel.Drawings.HiddenFillProperties;
using HiddenLineProperties = DocumentModel.Drawings.HiddenLineProperties;
using HiddenScene3D = DocumentModel.Drawings.HiddenScene3D;
using HiddenShape3D = DocumentModel.Drawings.HiddenShape3D;
using ShapePropertiesExtension = DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ShapePropertiesExtension Class.
/// </summary>
public static class ShapePropertiesExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(ShapePropertiesExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(ShapePropertiesExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static HiddenFillProperties? GetHiddenFillProperties(ShapePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenFillProperties>();
    if (itemElement != null)
      return HiddenFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHiddenFillProperties(ShapePropertiesExtension? openXmlElement, HiddenFillProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenFillProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HiddenFillPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.HiddenFillProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static HiddenLineProperties? GetHiddenLineProperties(ShapePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties>();
    if (itemElement != null)
      return HiddenLinePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHiddenLineProperties(ShapePropertiesExtension? openXmlElement, HiddenLineProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HiddenLinePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static HiddenEffectsProperties? GetHiddenEffectsProperties(ShapePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties>();
    if (itemElement != null)
      return HiddenEffectsPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHiddenEffectsProperties(ShapePropertiesExtension? openXmlElement, HiddenEffectsProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HiddenEffectsPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static HiddenScene3D? GetHiddenScene3D(ShapePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenScene3D>();
    if (itemElement != null)
      return HiddenScene3DConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHiddenScene3D(ShapePropertiesExtension? openXmlElement, HiddenScene3D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenScene3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HiddenScene3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.HiddenScene3D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static HiddenShape3D? GetHiddenShape3D(ShapePropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D>();
    if (itemElement != null)
      return HiddenShape3DConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHiddenShape3D(ShapePropertiesExtension? openXmlElement, HiddenShape3D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HiddenShape3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShadowObscured(ShapePropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShadowObscured>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShadowObscured(ShapePropertiesExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShadowObscured>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShadowObscured();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ShapePropertiesExtension? CreateModelElement(ShapePropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ShapePropertiesExtension();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ShapePropertiesExtension? value)
    where OpenXmlElementType : ShapePropertiesExtension, new()
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