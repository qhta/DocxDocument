namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Defines the Shadow Class.
/// </summary>
public static class ShadowConverter
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  private static String? GetId(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Shadow Toggle
  /// </summary>
  private static Boolean? GetOn(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.On?.Value;
  }
  
  private static void SetOn(DXVml.Shadow openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.On = value;
    else
      openXmlElement.On = null;
  }
  
  /// <summary>
  /// Shadow Type
  /// </summary>
  private static DMVml.ShadowKind? GetType(DXVml.Shadow openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ShadowValues, DMVml.ShadowKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXVml.Shadow openXmlElement, DMVml.ShadowKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ShadowValues, DMVml.ShadowKind>(value);
  }
  
  /// <summary>
  /// Shadow Transparency
  /// </summary>
  private static Boolean? GetObscured(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Obscured?.Value;
  }
  
  private static void SetObscured(DXVml.Shadow openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Obscured = value;
    else
      openXmlElement.Obscured = null;
  }
  
  /// <summary>
  /// Shadow Primary Color
  /// </summary>
  private static String? GetColor(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Color?.Value;
  }
  
  private static void SetColor(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
  }
  
  /// <summary>
  /// Shadow Opacity
  /// </summary>
  private static String? GetOpacity(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Opacity?.Value;
  }
  
  private static void SetOpacity(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Opacity = new StringValue { Value = value };
    else
      openXmlElement.Opacity = null;
  }
  
  /// <summary>
  /// Shadow Primary Offset
  /// </summary>
  private static String? GetOffset(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Offset?.Value;
  }
  
  private static void SetOffset(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Offset = new StringValue { Value = value };
    else
      openXmlElement.Offset = null;
  }
  
  /// <summary>
  /// Shadow Secondary Color
  /// </summary>
  private static String? GetColor2(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Color2?.Value;
  }
  
  private static void SetColor2(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color2 = new StringValue { Value = value };
    else
      openXmlElement.Color2 = null;
  }
  
  /// <summary>
  /// Shadow Secondary Offset
  /// </summary>
  private static String? GetOffset2(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Offset2?.Value;
  }
  
  private static void SetOffset2(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Offset2 = new StringValue { Value = value };
    else
      openXmlElement.Offset2 = null;
  }
  
  /// <summary>
  /// Shadow Origin
  /// </summary>
  private static String? GetOrigin(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Origin?.Value;
  }
  
  private static void SetOrigin(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Origin = new StringValue { Value = value };
    else
      openXmlElement.Origin = null;
  }
  
  /// <summary>
  /// Shadow Perspective Matrix
  /// </summary>
  private static String? GetMatrix(DXVml.Shadow openXmlElement)
  {
    return openXmlElement?.Matrix?.Value;
  }
  
  private static void SetMatrix(DXVml.Shadow openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Matrix = new StringValue { Value = value };
    else
      openXmlElement.Matrix = null;
  }
  
  public static DMVml.Shadow? CreateModelElement(DXVml.Shadow? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.Shadow();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.Shadow? value)
    where OpenXmlElementType: DXVml.Shadow, new()
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
