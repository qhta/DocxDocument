namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Transform2D Class.
/// </summary>
public static class Transform2DConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  private static Int32? GetRotation(DXD.Transform2D openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  private static bool CmpRotation(DXD.Transform2D openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Rotation?.Value == value) return true;
    diffs?.Add(objName, "Rotation", openXmlElement?.Rotation?.Value, value);
    return false;
  }
  
  private static void SetRotation(DXD.Transform2D openXmlElement, Int32? value)
  {
    openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Horizontal Flip
  /// </summary>
  private static Boolean? GetHorizontalFlip(DXD.Transform2D openXmlElement)
  {
    return openXmlElement?.HorizontalFlip?.Value;
  }
  
  private static bool CmpHorizontalFlip(DXD.Transform2D openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.HorizontalFlip?.Value == value) return true;
    diffs?.Add(objName, "HorizontalFlip", openXmlElement?.HorizontalFlip?.Value, value);
    return false;
  }
  
  private static void SetHorizontalFlip(DXD.Transform2D openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalFlip = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.HorizontalFlip = null;
  }
  
  /// <summary>
  /// Vertical Flip
  /// </summary>
  private static Boolean? GetVerticalFlip(DXD.Transform2D openXmlElement)
  {
    return openXmlElement?.VerticalFlip?.Value;
  }
  
  private static bool CmpVerticalFlip(DXD.Transform2D openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.VerticalFlip?.Value == value) return true;
    diffs?.Add(objName, "VerticalFlip", openXmlElement?.VerticalFlip?.Value, value);
    return false;
  }
  
  private static void SetVerticalFlip(DXD.Transform2D openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.VerticalFlip = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.VerticalFlip = null;
  }
  
  /// <summary>
  /// Offset.
  /// </summary>
  private static DMD.Point2DType? GetOffset(DXD.Transform2D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Offset>();
    if (element != null)
      return DMXD.Point2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOffset(DXD.Transform2D openXmlElement, DMD.Point2DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.Point2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Offset>(), value, diffs, objName, propName);
  }
  
  private static void SetOffset(DXD.Transform2D openXmlElement, DMD.Point2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Offset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.Point2DTypeConverter.CreateOpenXmlElement<DXD.Offset>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Extents.
  /// </summary>
  private static DMD.PositiveSize2DType? GetExtents(DXD.Transform2D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Extents>();
    if (element != null)
      return DMXD.PositiveSize2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtents(DXD.Transform2D openXmlElement, DMD.PositiveSize2DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.PositiveSize2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Extents>(), value, diffs, objName, propName);
  }
  
  private static void SetExtents(DXD.Transform2D openXmlElement, DMD.PositiveSize2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Extents>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PositiveSize2DTypeConverter.CreateOpenXmlElement<DXD.Extents>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Transform2D? CreateModelElement(DXD.Transform2D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Transform2D();
      value.Rotation = GetRotation(openXmlElement);
      value.HorizontalFlip = GetHorizontalFlip(openXmlElement);
      value.VerticalFlip = GetVerticalFlip(openXmlElement);
      value.Offset = GetOffset(openXmlElement);
      value.Extents = GetExtents(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Transform2D? openXmlElement, DMD.Transform2D? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRotation(openXmlElement, value.Rotation, diffs, objName, propName))
        ok = false;
      if (!CmpHorizontalFlip(openXmlElement, value.HorizontalFlip, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalFlip(openXmlElement, value.VerticalFlip, diffs, objName, propName))
        ok = false;
      if (!CmpOffset(openXmlElement, value.Offset, diffs, objName, propName))
        ok = false;
      if (!CmpExtents(openXmlElement, value.Extents, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Transform2D value)
    where OpenXmlElementType: DXD.Transform2D, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Transform2D openXmlElement, DMD.Transform2D value)
  {
    SetRotation(openXmlElement, value?.Rotation);
    SetHorizontalFlip(openXmlElement, value?.HorizontalFlip);
    SetVerticalFlip(openXmlElement, value?.VerticalFlip);
    SetOffset(openXmlElement, value?.Offset);
    SetExtents(openXmlElement, value?.Extents);
  }
}
