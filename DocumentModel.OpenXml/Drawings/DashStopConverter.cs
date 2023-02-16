namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Dash Stop.
/// </summary>
public static class DashStopConverter
{
  /// <summary>
  /// Dash Length
  /// </summary>
  private static Int32? GetDashLength(DXDraw.DashStop openXmlElement)
  {
    return openXmlElement?.DashLength?.Value;
  }
  
  private static bool CmpDashLength(DXDraw.DashStop openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.DashLength?.Value == value) return true;
    diffs?.Add(objName, "DashLength", openXmlElement?.DashLength?.Value, value);
    return false;
  }
  
  private static void SetDashLength(DXDraw.DashStop openXmlElement, Int32? value)
  {
    openXmlElement.DashLength = value;
  }
  
  /// <summary>
  /// Space Length
  /// </summary>
  private static Int32? GetSpaceLength(DXDraw.DashStop openXmlElement)
  {
    return openXmlElement?.SpaceLength?.Value;
  }
  
  private static bool CmpSpaceLength(DXDraw.DashStop openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.SpaceLength?.Value == value) return true;
    diffs?.Add(objName, "SpaceLength", openXmlElement?.SpaceLength?.Value, value);
    return false;
  }
  
  private static void SetSpaceLength(DXDraw.DashStop openXmlElement, Int32? value)
  {
    openXmlElement.SpaceLength = value;
  }
  
  public static DocumentModel.Drawings.DashStop? CreateModelElement(DXDraw.DashStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.DashStop();
      value.DashLength = GetDashLength(openXmlElement);
      value.SpaceLength = GetSpaceLength(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.DashStop? openXmlElement, DMDraws.DashStop? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDashLength(openXmlElement, value.DashLength, diffs, objName))
        ok = false;
      if (!CmpSpaceLength(openXmlElement, value.SpaceLength, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.DashStop? value)
    where OpenXmlElementType: DXDraw.DashStop, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDashLength(openXmlElement, value?.DashLength);
      SetSpaceLength(openXmlElement, value?.SpaceLength);
      return openXmlElement;
    }
    return default;
  }
}
