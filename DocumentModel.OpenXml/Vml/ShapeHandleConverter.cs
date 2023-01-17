namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Handle.
/// </summary>
public static class ShapeHandleConverter
{
  /// <summary>
  /// Handle Position
  /// </summary>
  private static String? GetPosition(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.Position?.Value;
  }
  
  private static void SetPosition(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Position = new StringValue { Value = value };
    else
      openXmlElement.Position = null;
  }
  
  /// <summary>
  /// Handle Polar Center
  /// </summary>
  private static String? GetPolar(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.Polar?.Value;
  }
  
  private static void SetPolar(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Polar = new StringValue { Value = value };
    else
      openXmlElement.Polar = null;
  }
  
  /// <summary>
  /// Handle Coordinate Mapping
  /// </summary>
  private static String? GetMap(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.Map?.Value;
  }
  
  private static void SetMap(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Map = new StringValue { Value = value };
    else
      openXmlElement.Map = null;
  }
  
  /// <summary>
  /// Invert Handle's X Position
  /// </summary>
  private static Boolean? GetInvertX(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.InvertX?.Value;
  }
  
  private static void SetInvertX(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InvertX = value;
    else
      openXmlElement.InvertX = null;
  }
  
  /// <summary>
  /// Invert Handle's Y Position
  /// </summary>
  private static Boolean? GetInvertY(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.InvertY?.Value;
  }
  
  private static void SetInvertY(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InvertY = value;
    else
      openXmlElement.InvertY = null;
  }
  
  /// <summary>
  /// Handle Inversion Toggle
  /// </summary>
  private static Boolean? GetSwitch(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.Switch?.Value;
  }
  
  private static void SetSwitch(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Switch = value;
    else
      openXmlElement.Switch = null;
  }
  
  /// <summary>
  /// Handle X Position Range
  /// </summary>
  private static String? GetXRange(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.XRange?.Value;
  }
  
  private static void SetXRange(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.XRange = new StringValue { Value = value };
    else
      openXmlElement.XRange = null;
  }
  
  /// <summary>
  /// Handle Y Position Range
  /// </summary>
  private static String? GetYRange(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.YRange?.Value;
  }
  
  private static void SetYRange(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.YRange = new StringValue { Value = value };
    else
      openXmlElement.YRange = null;
  }
  
  /// <summary>
  /// Handle Polar Radius Range
  /// </summary>
  private static String? GetRadiusRange(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement)
  {
    return openXmlElement?.RadiusRange?.Value;
  }
  
  private static void SetRadiusRange(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement, String? value)
  {
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
