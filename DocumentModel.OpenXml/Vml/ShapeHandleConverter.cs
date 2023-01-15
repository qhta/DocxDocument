using DocumentFormat.OpenXml.Vml;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Shape Handle.
/// </summary>
public static class ShapeHandleConverter
{
  /// <summary>
  ///   Handle Position
  /// </summary>
  public static String? GetPosition(ShapeHandle? openXmlElement)
  {
    return openXmlElement?.Position?.Value;
  }

  public static void SetPosition(ShapeHandle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Position = new StringValue { Value = value };
      else
        openXmlElement.Position = null;
  }

  /// <summary>
  ///   Handle Polar Center
  /// </summary>
  public static String? GetPolar(ShapeHandle? openXmlElement)
  {
    return openXmlElement?.Polar?.Value;
  }

  public static void SetPolar(ShapeHandle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Polar = new StringValue { Value = value };
      else
        openXmlElement.Polar = null;
  }

  /// <summary>
  ///   Handle Coordinate Mapping
  /// </summary>
  public static String? GetMap(ShapeHandle? openXmlElement)
  {
    return openXmlElement?.Map?.Value;
  }

  public static void SetMap(ShapeHandle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Map = new StringValue { Value = value };
      else
        openXmlElement.Map = null;
  }

  /// <summary>
  ///   Invert Handle's X Position
  /// </summary>
  public static Boolean? GetInvertX(ShapeHandle? openXmlElement)
  {
    return openXmlElement?.InvertX?.Value;
  }

  public static void SetInvertX(ShapeHandle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InvertX = value;
      else
        openXmlElement.InvertX = null;
  }

  /// <summary>
  ///   Invert Handle's Y Position
  /// </summary>
  public static Boolean? GetInvertY(ShapeHandle? openXmlElement)
  {
    return openXmlElement?.InvertY?.Value;
  }

  public static void SetInvertY(ShapeHandle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InvertY = value;
      else
        openXmlElement.InvertY = null;
  }

  /// <summary>
  ///   Handle Inversion Toggle
  /// </summary>
  public static Boolean? GetSwitch(ShapeHandle? openXmlElement)
  {
    return openXmlElement?.Switch?.Value;
  }

  public static void SetSwitch(ShapeHandle? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Switch = value;
      else
        openXmlElement.Switch = null;
  }

  /// <summary>
  ///   Handle X Position Range
  /// </summary>
  public static String? GetXRange(ShapeHandle? openXmlElement)
  {
    return openXmlElement?.XRange?.Value;
  }

  public static void SetXRange(ShapeHandle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.XRange = new StringValue { Value = value };
      else
        openXmlElement.XRange = null;
  }

  /// <summary>
  ///   Handle Y Position Range
  /// </summary>
  public static String? GetYRange(ShapeHandle? openXmlElement)
  {
    return openXmlElement?.YRange?.Value;
  }

  public static void SetYRange(ShapeHandle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.YRange = new StringValue { Value = value };
      else
        openXmlElement.YRange = null;
  }

  /// <summary>
  ///   Handle Polar Radius Range
  /// </summary>
  public static String? GetRadiusRange(ShapeHandle? openXmlElement)
  {
    return openXmlElement?.RadiusRange?.Value;
  }

  public static void SetRadiusRange(ShapeHandle? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.RadiusRange = new StringValue { Value = value };
      else
        openXmlElement.RadiusRange = null;
  }

  public static DocumentModel.Vml.ShapeHandle? CreateModelElement(ShapeHandle? openXmlElement)
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
    where OpenXmlElementType : ShapeHandle, new()
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