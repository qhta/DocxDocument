namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Vector3DType Class.
/// </summary>
public static class Vector3DTypeConverter
{
  /// <summary>
  /// Distance along X-axis in 3D
  /// </summary>
  private static Int64? GetDx(DXDraw.Vector3DType openXmlElement)
  {
    return openXmlElement?.Dx?.Value;
  }
  
  private static bool CmpDx(DXDraw.Vector3DType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Dx?.Value == value) return true;
    diffs?.Add(objName, "Dx", openXmlElement?.Dx?.Value, value);
    return false;
  }
  
  private static void SetDx(DXDraw.Vector3DType openXmlElement, Int64? value)
  {
    openXmlElement.Dx = value;
  }
  
  /// <summary>
  /// Distance along Y-axis in 3D
  /// </summary>
  private static Int64? GetDy(DXDraw.Vector3DType openXmlElement)
  {
    return openXmlElement?.Dy?.Value;
  }
  
  private static bool CmpDy(DXDraw.Vector3DType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Dy?.Value == value) return true;
    diffs?.Add(objName, "Dy", openXmlElement?.Dy?.Value, value);
    return false;
  }
  
  private static void SetDy(DXDraw.Vector3DType openXmlElement, Int64? value)
  {
    openXmlElement.Dy = value;
  }
  
  /// <summary>
  /// Distance along Z-axis in 3D
  /// </summary>
  private static Int64? GetDz(DXDraw.Vector3DType openXmlElement)
  {
    return openXmlElement?.Dz?.Value;
  }
  
  private static bool CmpDz(DXDraw.Vector3DType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Dz?.Value == value) return true;
    diffs?.Add(objName, "Dz", openXmlElement?.Dz?.Value, value);
    return false;
  }
  
  private static void SetDz(DXDraw.Vector3DType openXmlElement, Int64? value)
  {
    openXmlElement.Dz = value;
  }
  
  public static DMDraws.Vector3DType? CreateModelElement(DXDraw.Vector3DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Vector3DType();
      value.Dx = GetDx(openXmlElement);
      value.Dy = GetDy(openXmlElement);
      value.Dz = GetDz(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Vector3DType? openXmlElement, DMDraws.Vector3DType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDx(openXmlElement, value.Dx, diffs, objName))
        ok = false;
      if (!CmpDy(openXmlElement, value.Dy, diffs, objName))
        ok = false;
      if (!CmpDz(openXmlElement, value.Dz, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Vector3DType? value)
    where OpenXmlElementType: DXDraw.Vector3DType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDx(openXmlElement, value?.Dx);
      SetDy(openXmlElement, value?.Dy);
      SetDz(openXmlElement, value?.Dz);
      return openXmlElement;
    }
    return default;
  }
}
