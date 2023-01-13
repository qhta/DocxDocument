namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Shadow Class.
/// </summary>
public static class ShadowConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shadow Toggle
  /// </summary>
  public static Boolean? GetOn(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  public static void SetOn(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.On = value;
      else
        openXmlElement.On = null;
  }
  
  /// <summary>
  /// Shadow Type
  /// </summary>
  public static DocumentModel.Vml.ShadowKind? GetType(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ShadowValues, DocumentModel.Vml.ShadowKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement, DocumentModel.Vml.ShadowKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ShadowValues, DocumentModel.Vml.ShadowKind>(value);
  }
  
  /// <summary>
  /// Shadow Transparency
  /// </summary>
  public static Boolean? GetObscured(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement)
  {
    return openXmlElement?.Obscured?.Value;
  }
  
  public static void SetObscured(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Obscured = value;
      else
        openXmlElement.Obscured = null;
  }
  
  /// <summary>
  /// Shadow Primary Color
  /// </summary>
  public static String? GetColor(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  public static void SetColor(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color = new StringValue { Value = value };
      else
        openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Shadow Opacity
  /// </summary>
  public static String? GetOpacity(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement)
  {
    return openXmlElement?.Opacity?.Value;
  }
  
  public static void SetOpacity(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Opacity = new StringValue { Value = value };
      else
        openXmlElement.Opacity = null;
  }
  
  /// <summary>
  /// Shadow Primary Offset
  /// </summary>
  public static String? GetOffset(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement)
  {
    return openXmlElement?.Offset?.Value;
  }
  
  public static void SetOffset(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Offset = new StringValue { Value = value };
      else
        openXmlElement.Offset = null;
  }
  
  /// <summary>
  /// Shadow Secondary Color
  /// </summary>
  public static String? GetColor2(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement)
  {
    return openXmlElement?.Color2?.Value;
  }
  
  public static void SetColor2(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Color2 = new StringValue { Value = value };
      else
        openXmlElement.Color2 = null;
  }
  
  /// <summary>
  /// Shadow Secondary Offset
  /// </summary>
  public static String? GetOffset2(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement)
  {
    return openXmlElement?.Offset2?.Value;
  }
  
  public static void SetOffset2(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Offset2 = new StringValue { Value = value };
      else
        openXmlElement.Offset2 = null;
  }
  
  /// <summary>
  /// Shadow Origin
  /// </summary>
  public static String? GetOrigin(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement)
  {
    return openXmlElement?.Origin?.Value;
  }
  
  public static void SetOrigin(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Origin = new StringValue { Value = value };
      else
        openXmlElement.Origin = null;
  }
  
  /// <summary>
  /// Shadow Perspective Matrix
  /// </summary>
  public static String? GetMatrix(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement)
  {
    return openXmlElement?.Matrix?.Value;
  }
  
  public static void SetMatrix(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Matrix = new StringValue { Value = value };
      else
        openXmlElement.Matrix = null;
  }
  
  public static DocumentModel.Vml.Shadow? CreateModelElement(DocumentFormat.OpenXml.Vml.Shadow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.Shadow();
      value.Id = GetId(openXmlElement);
      value.On = GetOn(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.Obscured = GetObscured(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.Opacity = GetOpacity(openXmlElement);
      value.Offset = GetOffset(openXmlElement);
      value.Color2 = GetColor2(openXmlElement);
      value.Offset2 = GetOffset2(openXmlElement);
      value.Origin = GetOrigin(openXmlElement);
      value.Matrix = GetMatrix(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.Shadow? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.Shadow, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetOn(openXmlElement, value?.On);
      SetType(openXmlElement, value?.Type);
      SetObscured(openXmlElement, value?.Obscured);
      SetColor(openXmlElement, value?.Color);
      SetOpacity(openXmlElement, value?.Opacity);
      SetOffset(openXmlElement, value?.Offset);
      SetColor2(openXmlElement, value?.Color2);
      SetOffset2(openXmlElement, value?.Offset2);
      SetOrigin(openXmlElement, value?.Origin);
      SetMatrix(openXmlElement, value?.Matrix);
      return openXmlElement;
    }
    return default;
  }
}
