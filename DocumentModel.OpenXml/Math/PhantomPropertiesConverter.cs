using DocumentFormat.OpenXml.Math;
using DocumentModel.Math;
using ControlProperties = DocumentModel.Math.ControlProperties;
using PhantomProperties = DocumentFormat.OpenXml.Math.PhantomProperties;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Phantom Properties.
/// </summary>
public static class PhantomPropertiesConverter
{
  /// <summary>
  ///   Phantom Show.
  /// </summary>
  public static BooleanKind? GetShowPhantom(PhantomProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowPhantom>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetShowPhantom(PhantomProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowPhantom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<ShowPhantom, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Phantom Zero Width.
  /// </summary>
  public static BooleanKind? GetZeroWidth(PhantomProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ZeroWidth>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetZeroWidth(PhantomProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ZeroWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<ZeroWidth, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Phantom Zero Ascent.
  /// </summary>
  public static BooleanKind? GetZeroAscent(PhantomProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ZeroAscent>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetZeroAscent(PhantomProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ZeroAscent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<ZeroAscent, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Phantom Zero Descent.
  /// </summary>
  public static BooleanKind? GetZeroDescent(PhantomProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ZeroDescent>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetZeroDescent(PhantomProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ZeroDescent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<ZeroDescent, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Transparent (Phantom).
  /// </summary>
  public static BooleanKind? GetTransparent(PhantomProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Transparent>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTransparent(PhantomProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Transparent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Transparent, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public static ControlProperties? GetControlProperties(PhantomProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetControlProperties(PhantomProperties? openXmlElement, ControlProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ControlProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.PhantomProperties? CreateModelElement(PhantomProperties? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.PhantomProperties? value)
    where OpenXmlElementType : PhantomProperties, new()
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