namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Draw Arc To.
/// </summary>
public static class ArcToConverter
{
  /// <summary>
  /// Shape Arc Width Radius
  /// </summary>
  private static String? GetWidthRadius(DXDraw.ArcTo openXmlElement)
  {
    return openXmlElement?.WidthRadius?.Value;
  }
  
  private static bool CmpWidthRadius(DXDraw.ArcTo openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.WidthRadius?.Value == value;
  }
  
  private static void SetWidthRadius(DXDraw.ArcTo openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.WidthRadius = new StringValue { Value = value };
    else
      openXmlElement.WidthRadius = null;
  }
  
  /// <summary>
  /// Shape Arc Height Radius
  /// </summary>
  private static String? GetHeightRadius(DXDraw.ArcTo openXmlElement)
  {
    return openXmlElement?.HeightRadius?.Value;
  }
  
  private static bool CmpHeightRadius(DXDraw.ArcTo openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.HeightRadius?.Value == value;
  }
  
  private static void SetHeightRadius(DXDraw.ArcTo openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.HeightRadius = new StringValue { Value = value };
    else
      openXmlElement.HeightRadius = null;
  }
  
  /// <summary>
  /// Shape Arc Start Angle
  /// </summary>
  private static String? GetStartAngle(DXDraw.ArcTo openXmlElement)
  {
    return openXmlElement?.StartAngle?.Value;
  }
  
  private static bool CmpStartAngle(DXDraw.ArcTo openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.StartAngle?.Value == value;
  }
  
  private static void SetStartAngle(DXDraw.ArcTo openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.StartAngle = new StringValue { Value = value };
    else
      openXmlElement.StartAngle = null;
  }
  
  /// <summary>
  /// Shape Arc Swing Angle
  /// </summary>
  private static String? GetSwingAngle(DXDraw.ArcTo openXmlElement)
  {
    return openXmlElement?.SwingAngle?.Value;
  }
  
  private static bool CmpSwingAngle(DXDraw.ArcTo openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SwingAngle?.Value == value;
  }
  
  private static void SetSwingAngle(DXDraw.ArcTo openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.SwingAngle = new StringValue { Value = value };
    else
      openXmlElement.SwingAngle = null;
  }
  
  public static DMDraws.ArcTo? CreateModelElement(DXDraw.ArcTo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ArcTo();
      value.WidthRadius = GetWidthRadius(openXmlElement);
      value.HeightRadius = GetHeightRadius(openXmlElement);
      value.StartAngle = GetStartAngle(openXmlElement);
      value.SwingAngle = GetSwingAngle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ArcTo? openXmlElement, DMDraws.ArcTo? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpWidthRadius(openXmlElement, value.WidthRadius, diffs, objName))
        ok = false;
      if (!CmpHeightRadius(openXmlElement, value.HeightRadius, diffs, objName))
        ok = false;
      if (!CmpStartAngle(openXmlElement, value.StartAngle, diffs, objName))
        ok = false;
      if (!CmpSwingAngle(openXmlElement, value.SwingAngle, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArcTo? value)
    where OpenXmlElementType: DXDraw.ArcTo, new()
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
