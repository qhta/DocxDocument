namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the Transform2D Class.
/// </summary>
public static class Transform2DConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  private static Int32? GetRotation(DXODraw.Transform2D openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  private static bool CmpRotation(DXODraw.Transform2D openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Rotation?.Value == value) return true;
    diffs?.Add(objName, "Rotation", openXmlElement?.Rotation?.Value, value);
    return false;
  }
  
  private static void SetRotation(DXODraw.Transform2D openXmlElement, Int32? value)
  {
    openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Horizontal Flip
  /// </summary>
  private static Boolean? GetHorizontalFlip(DXODraw.Transform2D openXmlElement)
  {
    return openXmlElement?.HorizontalFlip?.Value;
  }
  
  private static bool CmpHorizontalFlip(DXODraw.Transform2D openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalFlip?.Value == value) return true;
    diffs?.Add(objName, "HorizontalFlip", openXmlElement?.HorizontalFlip?.Value, value);
    return false;
  }
  
  private static void SetHorizontalFlip(DXODraw.Transform2D openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalFlip = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.HorizontalFlip = null;
  }
  
  /// <summary>
  /// Vertical Flip
  /// </summary>
  private static Boolean? GetVerticalFlip(DXODraw.Transform2D openXmlElement)
  {
    return openXmlElement?.VerticalFlip?.Value;
  }
  
  private static bool CmpVerticalFlip(DXODraw.Transform2D openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.VerticalFlip?.Value == value) return true;
    diffs?.Add(objName, "VerticalFlip", openXmlElement?.VerticalFlip?.Value, value);
    return false;
  }
  
  private static void SetVerticalFlip(DXODraw.Transform2D openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.VerticalFlip = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.VerticalFlip = null;
  }
  
  /// <summary>
  /// Offset.
  /// </summary>
  private static DMDraws.Point2DType? GetOffset(DXODraw.Transform2D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Offset>();
    if (element != null)
      return DMXDraws.Point2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOffset(DXODraw.Transform2D openXmlElement, DMDraws.Point2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Point2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Offset>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOffset(DXODraw.Transform2D openXmlElement, DMDraws.Point2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Offset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Point2DTypeConverter.CreateOpenXmlElement<DXDraw.Offset>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Extents.
  /// </summary>
  private static DMDraws.PositiveSize2DType? GetExtents(DXODraw.Transform2D openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Extents>();
    if (element != null)
      return DMXDraws.PositiveSize2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtents(DXODraw.Transform2D openXmlElement, DMDraws.PositiveSize2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PositiveSize2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Extents>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtents(DXODraw.Transform2D openXmlElement, DMDraws.PositiveSize2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Extents>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PositiveSize2DTypeConverter.CreateOpenXmlElement<DXDraw.Extents>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.Transform2D? CreateModelElement(DXODraw.Transform2D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.Transform2D();
      value.Rotation = GetRotation(openXmlElement);
      value.HorizontalFlip = GetHorizontalFlip(openXmlElement);
      value.VerticalFlip = GetVerticalFlip(openXmlElement);
      value.Offset = GetOffset(openXmlElement);
      value.Extents = GetExtents(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXODraw.Transform2D? openXmlElement, DMDrawsO.Transform2D? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRotation(openXmlElement, value.Rotation, diffs, objName))
        ok = false;
      if (!CmpHorizontalFlip(openXmlElement, value.HorizontalFlip, diffs, objName))
        ok = false;
      if (!CmpVerticalFlip(openXmlElement, value.VerticalFlip, diffs, objName))
        ok = false;
      if (!CmpOffset(openXmlElement, value.Offset, diffs, objName))
        ok = false;
      if (!CmpExtents(openXmlElement, value.Extents, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsO.Transform2D value)
    where OpenXmlElementType: DXODraw.Transform2D, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXODraw.Transform2D openXmlElement, DMDrawsO.Transform2D value)
  {
    SetRotation(openXmlElement, value?.Rotation);
    SetHorizontalFlip(openXmlElement, value?.HorizontalFlip);
    SetVerticalFlip(openXmlElement, value?.VerticalFlip);
    SetOffset(openXmlElement, value?.Offset);
    SetExtents(openXmlElement, value?.Extents);
  }
}
