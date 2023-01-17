namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Border Box Properties.
/// </summary>
public static class BorderBoxPropertiesConverter
{
  /// <summary>
  /// Hide Top Edge.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetHideTop(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HideTop>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHideTop(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HideTop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.HideTop, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hide Bottom Edge.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetHideBottom(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HideBottom>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHideBottom(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HideBottom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.HideBottom, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hide Left Edge.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetHideLeft(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HideLeft>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHideLeft(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HideLeft>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.HideLeft, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hide Right Edge.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetHideRight(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HideRight>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHideRight(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HideRight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.HideRight, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Border Box Strikethrough Horizontal.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetStrikeHorizontal(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.StrikeHorizontal>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetStrikeHorizontal(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.StrikeHorizontal>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.StrikeHorizontal, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Border Box Strikethrough Vertical.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetStrikeVertical(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.StrikeVertical>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetStrikeVertical(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.StrikeVertical>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.StrikeVertical, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Border Box Strikethrough Bottom-Left to Top-Right.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetStrikeBottomLeftToTopRight(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.StrikeBottomLeftToTopRight>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetStrikeBottomLeftToTopRight(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.StrikeBottomLeftToTopRight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.StrikeBottomLeftToTopRight, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Border Box Strikethrough Top-Left to Bottom-Right.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetStrikeTopLeftToBottomRight(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.StrikeTopLeftToBottomRight>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetStrikeTopLeftToBottomRight(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.StrikeTopLeftToBottomRight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.StrikeTopLeftToBottomRight, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControlProperties(DocumentFormat.OpenXml.Math.BorderBoxProperties openXmlElement, DocumentModel.Math.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.BorderBoxProperties? CreateModelElement(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.BorderBoxProperties, new()
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
