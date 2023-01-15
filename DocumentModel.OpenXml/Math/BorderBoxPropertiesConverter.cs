using DocumentFormat.OpenXml.Math;
using DocumentModel.Math;
using BorderBoxProperties = DocumentFormat.OpenXml.Math.BorderBoxProperties;
using ControlProperties = DocumentModel.Math.ControlProperties;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Border Box Properties.
/// </summary>
public static class BorderBoxPropertiesConverter
{
  /// <summary>
  ///   Hide Top Edge.
  /// </summary>
  public static BooleanKind? GetHideTop(BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HideTop>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetHideTop(BorderBoxProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HideTop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<HideTop, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Hide Bottom Edge.
  /// </summary>
  public static BooleanKind? GetHideBottom(BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HideBottom>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetHideBottom(BorderBoxProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HideBottom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<HideBottom, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Hide Left Edge.
  /// </summary>
  public static BooleanKind? GetHideLeft(BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HideLeft>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetHideLeft(BorderBoxProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HideLeft>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<HideLeft, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Hide Right Edge.
  /// </summary>
  public static BooleanKind? GetHideRight(BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HideRight>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetHideRight(BorderBoxProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HideRight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<HideRight, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Border Box Strikethrough Horizontal.
  /// </summary>
  public static BooleanKind? GetStrikeHorizontal(BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StrikeHorizontal>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetStrikeHorizontal(BorderBoxProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StrikeHorizontal>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<StrikeHorizontal, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Border Box Strikethrough Vertical.
  /// </summary>
  public static BooleanKind? GetStrikeVertical(BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StrikeVertical>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetStrikeVertical(BorderBoxProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StrikeVertical>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<StrikeVertical, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Border Box Strikethrough Bottom-Left to Top-Right.
  /// </summary>
  public static BooleanKind? GetStrikeBottomLeftToTopRight(BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StrikeBottomLeftToTopRight>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetStrikeBottomLeftToTopRight(BorderBoxProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StrikeBottomLeftToTopRight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<StrikeBottomLeftToTopRight, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Border Box Strikethrough Top-Left to Bottom-Right.
  /// </summary>
  public static BooleanKind? GetStrikeTopLeftToBottomRight(BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StrikeTopLeftToBottomRight>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetStrikeTopLeftToBottomRight(BorderBoxProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StrikeTopLeftToBottomRight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<StrikeTopLeftToBottomRight, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public static ControlProperties? GetControlProperties(BorderBoxProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetControlProperties(BorderBoxProperties? openXmlElement, ControlProperties? value)
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

  public static DocumentModel.Math.BorderBoxProperties? CreateModelElement(BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.BorderBoxProperties();
      value.HideTop = GetHideTop(openXmlElement);
      value.HideBottom = GetHideBottom(openXmlElement);
      value.HideLeft = GetHideLeft(openXmlElement);
      value.HideRight = GetHideRight(openXmlElement);
      value.StrikeHorizontal = GetStrikeHorizontal(openXmlElement);
      value.StrikeVertical = GetStrikeVertical(openXmlElement);
      value.StrikeBottomLeftToTopRight = GetStrikeBottomLeftToTopRight(openXmlElement);
      value.StrikeTopLeftToBottomRight = GetStrikeTopLeftToBottomRight(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.BorderBoxProperties? value)
    where OpenXmlElementType : BorderBoxProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHideTop(openXmlElement, value?.HideTop);
      SetHideBottom(openXmlElement, value?.HideBottom);
      SetHideLeft(openXmlElement, value?.HideLeft);
      SetHideRight(openXmlElement, value?.HideRight);
      SetStrikeHorizontal(openXmlElement, value?.StrikeHorizontal);
      SetStrikeVertical(openXmlElement, value?.StrikeVertical);
      SetStrikeBottomLeftToTopRight(openXmlElement, value?.StrikeBottomLeftToTopRight);
      SetStrikeTopLeftToBottomRight(openXmlElement, value?.StrikeTopLeftToBottomRight);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}