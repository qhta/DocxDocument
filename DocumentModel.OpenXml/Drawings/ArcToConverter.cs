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
    return StringValueConverter.GetValue(openXmlElement?.WidthRadius);
  }
  
  private static bool CmpWidthRadius(DXDraw.ArcTo openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.WidthRadius, value, diffs, objName, "WidthRadius");
  }
  
  private static void SetWidthRadius(DXDraw.ArcTo openXmlElement, String? value)
  {
    openXmlElement.WidthRadius = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Arc Height Radius
  /// </summary>
  private static String? GetHeightRadius(DXDraw.ArcTo openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.HeightRadius);
  }
  
  private static bool CmpHeightRadius(DXDraw.ArcTo openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.HeightRadius, value, diffs, objName, "HeightRadius");
  }
  
  private static void SetHeightRadius(DXDraw.ArcTo openXmlElement, String? value)
  {
    openXmlElement.HeightRadius = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Arc Start Angle
  /// </summary>
  private static String? GetStartAngle(DXDraw.ArcTo openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.StartAngle);
  }
  
  private static bool CmpStartAngle(DXDraw.ArcTo openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.StartAngle, value, diffs, objName, "StartAngle");
  }
  
  private static void SetStartAngle(DXDraw.ArcTo openXmlElement, String? value)
  {
    openXmlElement.StartAngle = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shape Arc Swing Angle
  /// </summary>
  private static String? GetSwingAngle(DXDraw.ArcTo openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SwingAngle);
  }
  
  private static bool CmpSwingAngle(DXDraw.ArcTo openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SwingAngle, value, diffs, objName, "SwingAngle");
  }
  
  private static void SetSwingAngle(DXDraw.ArcTo openXmlElement, String? value)
  {
    openXmlElement.SwingAngle = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.ArcTo? CreateModelElement(DXDraw.ArcTo? openXmlElement)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ArcTo value)
    where OpenXmlElementType: DXDraw.ArcTo, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.ArcTo openXmlElement, DMDraws.ArcTo value)
  {
    SetWidthRadius(openXmlElement, value?.WidthRadius);
    SetHeightRadius(openXmlElement, value?.HeightRadius);
    SetStartAngle(openXmlElement, value?.StartAngle);
    SetSwingAngle(openXmlElement, value?.SwingAngle);
    }
  }
