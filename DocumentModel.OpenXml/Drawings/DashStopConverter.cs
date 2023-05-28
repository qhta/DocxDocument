namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Dash Stop.
/// </summary>
public static class DashStopConverter
{
  /// <summary>
  /// Dash Length
  /// </summary>
  private static Int32? GetDashLength(DXD.DashStop openXmlElement)
  {
    return openXmlElement?.DashLength?.Value;
  }
  
  private static bool CmpDashLength(DXD.DashStop openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.DashLength?.Value == value) return true;
    diffs?.Add(objName, "DashLength", openXmlElement?.DashLength?.Value, value);
    return false;
  }
  
  private static void SetDashLength(DXD.DashStop openXmlElement, Int32? value)
  {
    openXmlElement.DashLength = value;
  }
  
  /// <summary>
  /// Space Length
  /// </summary>
  private static Int32? GetSpaceLength(DXD.DashStop openXmlElement)
  {
    return openXmlElement?.SpaceLength?.Value;
  }
  
  private static bool CmpSpaceLength(DXD.DashStop openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.SpaceLength?.Value == value) return true;
    diffs?.Add(objName, "SpaceLength", openXmlElement?.SpaceLength?.Value, value);
    return false;
  }
  
  private static void SetSpaceLength(DXD.DashStop openXmlElement, Int32? value)
  {
    openXmlElement.SpaceLength = value;
  }
  
  public static DMD.DashStop? CreateModelElement(DXD.DashStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.DashStop();
      value.DashLength = GetDashLength(openXmlElement);
      value.SpaceLength = GetSpaceLength(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.DashStop? openXmlElement, DMD.DashStop? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDashLength(openXmlElement, value.DashLength, diffs, objName, propName))
        ok = false;
      if (!CmpSpaceLength(openXmlElement, value.SpaceLength, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.DashStop value)
    where OpenXmlElementType: DXD.DashStop, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.DashStop openXmlElement, DMD.DashStop value)
  {
    SetDashLength(openXmlElement, value?.DashLength);
    SetSpaceLength(openXmlElement, value?.SpaceLength);
  }
}
