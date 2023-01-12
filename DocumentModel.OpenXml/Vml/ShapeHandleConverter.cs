namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Handle.
/// </summary>
public static class ShapeHandleConverter
{
  /// <summary>
  /// Handle Position
  /// </summary>
  public static String? GetPosition(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement)
  {
    return openXmlElement?.Position?.Value;
  }
  
  public static void SetPosition(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Position = new StringValue { Value = value };
      else
        openXmlElement.Position = null;
  }
  
  /// <summary>
  /// Handle Polar Center
  /// </summary>
  public static String? GetPolar(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement)
  {
    return openXmlElement?.Polar?.Value;
  }
  
  public static void SetPolar(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Polar = new StringValue { Value = value };
      else
        openXmlElement.Polar = null;
  }
  
  /// <summary>
  /// Handle Coordinate Mapping
  /// </summary>
  public static String? GetMap(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement)
  {
    return openXmlElement?.Map?.Value;
  }
  
  public static void SetMap(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Map = new StringValue { Value = value };
      else
        openXmlElement.Map = null;
  }
  
  /// <summary>
  /// Invert Handle's X Position
  /// </summary>
  public static Boolean? GetInvertX(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  public static void SetInvertX(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  /// <summary>
  /// Invert Handle's Y Position
  /// </summary>
  public static Boolean? GetInvertY(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  public static void SetInvertY(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  /// <summary>
  /// Handle Inversion Toggle
  /// </summary>
  public static Boolean? GetSwitch(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  public static void SetSwitch(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  /// <summary>
  /// Handle X Position Range
  /// </summary>
  public static String? GetXRange(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement)
  {
    return openXmlElement?.XRange?.Value;
  }
  
  public static void SetXRange(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.XRange = new StringValue { Value = value };
      else
        openXmlElement.XRange = null;
  }
  
  /// <summary>
  /// Handle Y Position Range
  /// </summary>
  public static String? GetYRange(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement)
  {
    return openXmlElement?.YRange?.Value;
  }
  
  public static void SetYRange(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.YRange = new StringValue { Value = value };
      else
        openXmlElement.YRange = null;
  }
  
  /// <summary>
  /// Handle Polar Radius Range
  /// </summary>
  public static String? GetRadiusRange(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement)
  {
    return openXmlElement?.RadiusRange?.Value;
  }
  
  public static void SetRadiusRange(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RadiusRange = new StringValue { Value = value };
      else
        openXmlElement.RadiusRange = null;
  }
  
  public static DocumentModel.Vml.ShapeHandle? CreateModelElement(DocumentFormat.OpenXml.Vml.ShapeHandle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.ShapeHandle();
      value.Position = GetPosition(openXmlElement);
      value.Polar = GetPolar(openXmlElement);
      value.Map = GetMap(openXmlElement);
      value.InvertX = GetInvertX(openXmlElement);
      value.InvertY = GetInvertY(openXmlElement);
      value.Switch = GetSwitch(openXmlElement);
      value.XRange = GetXRange(openXmlElement);
      value.YRange = GetYRange(openXmlElement);
      value.RadiusRange = GetRadiusRange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.ShapeHandle? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Vml.ShapeHandle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPosition(openXmlElement, value?.Position);
      SetPolar(openXmlElement, value?.Polar);
      SetMap(openXmlElement, value?.Map);
      SetInvertX(openXmlElement, value?.InvertX);
      SetInvertY(openXmlElement, value?.InvertY);
      SetSwitch(openXmlElement, value?.Switch);
      SetXRange(openXmlElement, value?.XRange);
      SetYRange(openXmlElement, value?.YRange);
      SetRadiusRange(openXmlElement, value?.RadiusRange);
      return openXmlElement;
    }
    return default;
  }
}
