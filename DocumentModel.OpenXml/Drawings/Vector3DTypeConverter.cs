namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Vector3DType Class.
/// </summary>
public static class Vector3DTypeConverter
{
  /// <summary>
  /// Distance along X-axis in 3D
  /// </summary>
  private static Int64? GetDx(DXD.Vector3DType openXmlElement)
  {
    return openXmlElement?.Dx?.Value;
  }
  
  private static bool CmpDx(DXD.Vector3DType openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Dx?.Value == value) return true;
    diffs?.Add(objName, "Dx", openXmlElement?.Dx?.Value, value);
    return false;
  }
  
  private static void SetDx(DXD.Vector3DType openXmlElement, Int64? value)
  {
    openXmlElement.Dx = value;
  }
  
  /// <summary>
  /// Distance along Y-axis in 3D
  /// </summary>
  private static Int64? GetDy(DXD.Vector3DType openXmlElement)
  {
    return openXmlElement?.Dy?.Value;
  }
  
  private static bool CmpDy(DXD.Vector3DType openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Dy?.Value == value) return true;
    diffs?.Add(objName, "Dy", openXmlElement?.Dy?.Value, value);
    return false;
  }
  
  private static void SetDy(DXD.Vector3DType openXmlElement, Int64? value)
  {
    openXmlElement.Dy = value;
  }
  
  /// <summary>
  /// Distance along Z-axis in 3D
  /// </summary>
  private static Int64? GetDz(DXD.Vector3DType openXmlElement)
  {
    return openXmlElement?.Dz?.Value;
  }
  
  private static bool CmpDz(DXD.Vector3DType openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Dz?.Value == value) return true;
    diffs?.Add(objName, "Dz", openXmlElement?.Dz?.Value, value);
    return false;
  }
  
  private static void SetDz(DXD.Vector3DType openXmlElement, Int64? value)
  {
    openXmlElement.Dz = value;
  }
  
  public static DocumentModel.Drawings.Vector3DType? CreateModelElement(DXD.Vector3DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Vector3DType();
      value.Dx = GetDx(openXmlElement);
      value.Dy = GetDy(openXmlElement);
      value.Dz = GetDz(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Vector3DType? openXmlElement, DMD.Vector3DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDx(openXmlElement, value.Dx, diffs, objName, propName))
        ok = false;
      if (!CmpDy(openXmlElement, value.Dy, diffs, objName, propName))
        ok = false;
      if (!CmpDz(openXmlElement, value.Dz, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Vector3DType value)
    where OpenXmlElementType: DXD.Vector3DType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Vector3DType openXmlElement, DMD.Vector3DType value)
  {
    SetDx(openXmlElement, value?.Dx);
    SetDy(openXmlElement, value?.Dy);
    SetDz(openXmlElement, value?.Dz);
  }
}
