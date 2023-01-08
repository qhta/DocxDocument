namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Border Box Properties.
/// </summary>
public static class BorderBoxPropertiesConverter
{
  /// <summary>
  /// Hide Top Edge.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetHideTop(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HideTop>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetHideTop(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Hide Bottom Edge.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetHideBottom(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HideBottom>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetHideBottom(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Hide Left Edge.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetHideLeft(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HideLeft>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetHideLeft(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Hide Right Edge.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetHideRight(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HideRight>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetHideRight(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Border Box Strikethrough Horizontal.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetStrikeHorizontal(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.StrikeHorizontal>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetStrikeHorizontal(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Border Box Strikethrough Vertical.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetStrikeVertical(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.StrikeVertical>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetStrikeVertical(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Border Box Strikethrough Bottom-Left to Top-Right.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetStrikeBottomLeftToTopRight(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.StrikeBottomLeftToTopRight>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetStrikeBottomLeftToTopRight(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Border Box Strikethrough Top-Left to Bottom-Right.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetStrikeTopLeftToBottomRight(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.StrikeTopLeftToBottomRight>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetStrikeTopLeftToBottomRight(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetControlProperties(DocumentFormat.OpenXml.Math.BorderBoxProperties? openXmlElement, DocumentModel.Math.ControlProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
