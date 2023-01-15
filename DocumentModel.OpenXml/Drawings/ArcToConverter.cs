using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Draw Arc To.
/// </summary>
public static class ArcToConverter
{
  /// <summary>
  ///   Shape Arc Width Radius
  /// </summary>
  public static String? GetWidthRadius(ArcTo? openXmlElement)
  {
    return openXmlElement?.WidthRadius?.Value;
  }

  public static void SetWidthRadius(ArcTo? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.WidthRadius = new StringValue { Value = value };
      else
        openXmlElement.WidthRadius = null;
  }

  /// <summary>
  ///   Shape Arc Height Radius
  /// </summary>
  public static String? GetHeightRadius(ArcTo? openXmlElement)
  {
    return openXmlElement?.HeightRadius?.Value;
  }

  public static void SetHeightRadius(ArcTo? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HeightRadius = new StringValue { Value = value };
      else
        openXmlElement.HeightRadius = null;
  }

  /// <summary>
  ///   Shape Arc Start Angle
  /// </summary>
  public static String? GetStartAngle(ArcTo? openXmlElement)
  {
    return openXmlElement?.StartAngle?.Value;
  }

  public static void SetStartAngle(ArcTo? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StartAngle = new StringValue { Value = value };
      else
        openXmlElement.StartAngle = null;
  }

  /// <summary>
  ///   Shape Arc Swing Angle
  /// </summary>
  public static String? GetSwingAngle(ArcTo? openXmlElement)
  {
    return openXmlElement?.SwingAngle?.Value;
  }

  public static void SetSwingAngle(ArcTo? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SwingAngle = new StringValue { Value = value };
      else
        openXmlElement.SwingAngle = null;
  }

  public static DocumentModel.Drawings.ArcTo? CreateModelElement(ArcTo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ArcTo();
      value.WidthRadius = GetWidthRadius(openXmlElement);
      value.HeightRadius = GetHeightRadius(openXmlElement);
      value.StartAngle = GetStartAngle(openXmlElement);
      value.SwingAngle = GetSwingAngle(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ArcTo? value)
    where OpenXmlElementType : ArcTo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidthRadius(openXmlElement, value?.WidthRadius);
      SetHeightRadius(openXmlElement, value?.HeightRadius);
      SetStartAngle(openXmlElement, value?.StartAngle);
      SetSwingAngle(openXmlElement, value?.SwingAngle);
      return openXmlElement;
    }
    return default;
  }
}