namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Border Box Properties.
/// </summary>
public static class BorderBoxPropertiesConverter
{
  /// <summary>
  /// Hide Top Edge.
  /// </summary>
  private static DMMath.BooleanKind? GetHideTop(DXMath.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.HideTop>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHideTop(DXMath.BorderBoxProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.HideTop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.HideTop, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hide Bottom Edge.
  /// </summary>
  private static DMMath.BooleanKind? GetHideBottom(DXMath.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.HideBottom>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHideBottom(DXMath.BorderBoxProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.HideBottom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.HideBottom, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hide Left Edge.
  /// </summary>
  private static DMMath.BooleanKind? GetHideLeft(DXMath.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.HideLeft>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHideLeft(DXMath.BorderBoxProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.HideLeft>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.HideLeft, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hide Right Edge.
  /// </summary>
  private static DMMath.BooleanKind? GetHideRight(DXMath.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.HideRight>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHideRight(DXMath.BorderBoxProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.HideRight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.HideRight, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Border Box Strikethrough Horizontal.
  /// </summary>
  private static DMMath.BooleanKind? GetStrikeHorizontal(DXMath.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.StrikeHorizontal>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetStrikeHorizontal(DXMath.BorderBoxProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.StrikeHorizontal>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.StrikeHorizontal, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Border Box Strikethrough Vertical.
  /// </summary>
  private static DMMath.BooleanKind? GetStrikeVertical(DXMath.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.StrikeVertical>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetStrikeVertical(DXMath.BorderBoxProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.StrikeVertical>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.StrikeVertical, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Border Box Strikethrough Bottom-Left to Top-Right.
  /// </summary>
  private static DMMath.BooleanKind? GetStrikeBottomLeftToTopRight(DXMath.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.StrikeBottomLeftToTopRight>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetStrikeBottomLeftToTopRight(DXMath.BorderBoxProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.StrikeBottomLeftToTopRight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.StrikeBottomLeftToTopRight, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Border Box Strikethrough Top-Left to Bottom-Right.
  /// </summary>
  private static DMMath.BooleanKind? GetStrikeTopLeftToBottomRight(DXMath.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.StrikeTopLeftToBottomRight>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetStrikeTopLeftToBottomRight(DXMath.BorderBoxProperties openXmlElement, DMMath.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.StrikeTopLeftToBottomRight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.StrikeTopLeftToBottomRight, DocumentFormat.OpenXml.Math.BooleanValues, DMMath.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DMMath.ControlProperties? GetControlProperties(DXMath.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ControlProperties>();
    if (itemElement != null)
      return DMXMath.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControlProperties(DXMath.BorderBoxProperties openXmlElement, DMMath.ControlProperties? value)
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
  
  public static DMMath.BorderBoxProperties? CreateModelElement(DXMath.BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.BorderBoxProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.BorderBoxProperties? value)
    where OpenXmlElementType: DXMath.BorderBoxProperties, new()
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
