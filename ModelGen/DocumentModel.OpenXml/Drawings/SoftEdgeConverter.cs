namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Soft Edge Effect.
/// </summary>
public static class SoftEdgeConverter
{
  /// <summary>
  /// Radius
  /// </summary>
  private static Int64? GetRadius(DXDraw.SoftEdge openXmlElement)
  {
    return openXmlElement?.Radius?.Value;
  }
  
  private static bool CmpRadius(DXDraw.SoftEdge openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Radius?.Value == value) return true;
    diffs?.Add(objName, "Radius", openXmlElement?.Radius?.Value, value);
    return false;
  }
  
  private static void SetRadius(DXDraw.SoftEdge openXmlElement, Int64? value)
  {
    openXmlElement.Radius = value;
  }
  
  public static DocumentModel.Drawings.SoftEdge? CreateModelElement(DXDraw.SoftEdge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SoftEdge();
      value.Radius = GetRadius(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.SoftEdge? openXmlElement, DMDraws.SoftEdge? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRadius(openXmlElement, value.Radius, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.SoftEdge value)
    where OpenXmlElementType: DXDraw.SoftEdge, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.SoftEdge openXmlElement, DMDraws.SoftEdge value)
  {
    SetRadius(openXmlElement, value?.Radius);
  }
}
