namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Outer Shadow Effect.
/// </summary>
public static class OuterShadowConverter
{
  /// <summary>
  /// Blur Radius
  /// </summary>
  public static Int64? GetBlurRadius(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    return openXmlElement?.BlurRadius?.Value;
  }
  
  public static void SetBlurRadius(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlurRadius = value;
  }
  
  /// <summary>
  /// Shadow Offset Distance
  /// </summary>
  public static Int64? GetDistance(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    return openXmlElement?.Distance?.Value;
  }
  
  public static void SetDistance(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.Distance = value;
  }
  
  /// <summary>
  /// Shadow Direction
  /// </summary>
  public static Int32? GetDirection(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    return openXmlElement?.Direction?.Value;
  }
  
  public static void SetDirection(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Direction = value;
  }
  
  /// <summary>
  /// Horizontal Scaling Factor
  /// </summary>
  public static Int32? GetHorizontalRatio(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    return openXmlElement?.HorizontalRatio?.Value;
  }
  
  public static void SetHorizontalRatio(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalRatio = value;
  }
  
  /// <summary>
  /// Vertical Scaling Factor
  /// </summary>
  public static Int32? GetVerticalRatio(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    return openXmlElement?.VerticalRatio?.Value;
  }
  
  public static void SetVerticalRatio(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalRatio = value;
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  public static Int32? GetHorizontalSkew(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    return openXmlElement?.HorizontalSkew?.Value;
  }
  
  public static void SetHorizontalSkew(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalSkew = value;
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  public static Int32? GetVerticalSkew(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    return openXmlElement?.VerticalSkew?.Value;
  }
  
  public static void SetVerticalSkew(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalSkew = value;
  }
  
  /// <summary>
  /// Shadow Alignment
  /// </summary>
  public static DocumentModel.Drawings.RectangleAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DocumentModel.Drawings.RectangleAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  public static void SetAlignment(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement, DocumentModel.Drawings.RectangleAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues, DocumentModel.Drawings.RectangleAlignmentKind>(value);
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public static Boolean? GetRotateWithShape(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }
  
  public static void SetRotateWithShape(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.RotateWithShape = null;
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public static DocumentModel.Drawings.RgbColorModelPercentage? GetRgbColorModelPercentage(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RgbColorModelPercentageConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRgbColorModelPercentage(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement, DocumentModel.Drawings.RgbColorModelPercentage? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.RgbColorModelPercentageConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public static DocumentModel.Drawings.RgbColorModelHex? GetRgbColorModelHex(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRgbColorModelHex(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement, DocumentModel.Drawings.RgbColorModelHex? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.RgbColorModelHexConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public static DocumentModel.Drawings.HslColor? GetHslColor(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HslColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHslColor(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement, DocumentModel.Drawings.HslColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.HslColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HslColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public static DocumentModel.Drawings.SystemColor? GetSystemColor(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SystemColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSystemColor(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement, DocumentModel.Drawings.SystemColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.SystemColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SystemColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public static DocumentModel.Drawings.SchemeColor? GetSchemeColor(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSchemeColor(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement, DocumentModel.Drawings.SchemeColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.SchemeColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SchemeColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public static DocumentModel.Drawings.PresetColor? GetPresetColor(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PresetColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPresetColor(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement, DocumentModel.Drawings.PresetColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.PresetColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.OuterShadow? CreateModelElement(DocumentFormat.OpenXml.Drawing.OuterShadow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.OuterShadow();
      value.BlurRadius = GetBlurRadius(openXmlElement);
      value.Distance = GetDistance(openXmlElement);
      value.Direction = GetDirection(openXmlElement);
      value.HorizontalRatio = GetHorizontalRatio(openXmlElement);
      value.VerticalRatio = GetVerticalRatio(openXmlElement);
      value.HorizontalSkew = GetHorizontalSkew(openXmlElement);
      value.VerticalSkew = GetVerticalSkew(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.RotateWithShape = GetRotateWithShape(openXmlElement);
      value.RgbColorModelPercentage = GetRgbColorModelPercentage(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.HslColor = GetHslColor(openXmlElement);
      value.SystemColor = GetSystemColor(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      value.PresetColor = GetPresetColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.OuterShadow? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.OuterShadow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlurRadius(openXmlElement, value?.BlurRadius);
      SetDistance(openXmlElement, value?.Distance);
      SetDirection(openXmlElement, value?.Direction);
      SetHorizontalRatio(openXmlElement, value?.HorizontalRatio);
      SetVerticalRatio(openXmlElement, value?.VerticalRatio);
      SetHorizontalSkew(openXmlElement, value?.HorizontalSkew);
      SetVerticalSkew(openXmlElement, value?.VerticalSkew);
      SetAlignment(openXmlElement, value?.Alignment);
      SetRotateWithShape(openXmlElement, value?.RotateWithShape);
      SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetHslColor(openXmlElement, value?.HslColor);
      SetSystemColor(openXmlElement, value?.SystemColor);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      SetPresetColor(openXmlElement, value?.PresetColor);
      return openXmlElement;
    }
    return default;
  }
}
