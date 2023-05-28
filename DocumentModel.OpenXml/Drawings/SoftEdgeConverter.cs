namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Soft Edge Effect.
/// </summary>
public static class SoftEdgeConverter
{
  /// <summary>
  /// Radius
  /// </summary>
  private static Int64? GetRadius(DXD.SoftEdge openXmlElement)
  {
    return openXmlElement?.Radius?.Value;
  }
  
  private static bool CmpRadius(DXD.SoftEdge openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Radius?.Value == value) return true;
    diffs?.Add(objName, "Radius", openXmlElement?.Radius?.Value, value);
    return false;
  }
  
  private static void SetRadius(DXD.SoftEdge openXmlElement, Int64? value)
  {
    openXmlElement.Radius = value;
  }
  
  public static DMD.SoftEdge? CreateModelElement(DXD.SoftEdge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.SoftEdge();
      value.Radius = GetRadius(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.SoftEdge? openXmlElement, DMD.SoftEdge? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRadius(openXmlElement, value.Radius, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.SoftEdge value)
    where OpenXmlElementType: DXD.SoftEdge, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.SoftEdge openXmlElement, DMD.SoftEdge value)
  {
    SetRadius(openXmlElement, value?.Radius);
  }
}
