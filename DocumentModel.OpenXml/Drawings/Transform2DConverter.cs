namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Transform2D Class.
/// </summary>
public static class Transform2DConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  private static Int32? GetRotation(DXDraw.Transform2D openXmlElement)
  {
    return openXmlElement.Rotation?.Value;
  }
  
  private static bool CmpRotation(DXDraw.Transform2D openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Rotation?.Value == value;
  }
  
  private static void SetRotation(DXDraw.Transform2D openXmlElement, Int32? value)
  {
    openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Horizontal Flip
  /// </summary>
  private static Boolean? GetHorizontalFlip(DXDraw.Transform2D openXmlElement)
  {
    return openXmlElement?.HorizontalFlip?.Value;
  }
  
  private static bool CmpHorizontalFlip(DXDraw.Transform2D openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.HorizontalFlip?.Value == value;
  }
  
  private static void SetHorizontalFlip(DXDraw.Transform2D openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalFlip = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.HorizontalFlip = null;
  }
  
  /// <summary>
  /// Vertical Flip
  /// </summary>
  private static Boolean? GetVerticalFlip(DXDraw.Transform2D openXmlElement)
  {
    return openXmlElement?.VerticalFlip?.Value;
  }
  
  private static bool CmpVerticalFlip(DXDraw.Transform2D openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.VerticalFlip?.Value == value;
  }
  
  private static void SetVerticalFlip(DXDraw.Transform2D openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.VerticalFlip = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.VerticalFlip = null;
  }
  
  /// <summary>
  /// Offset.
  /// </summary>
  private static DMDraws.Point2DType? GetOffset(DXDraw.Transform2D openXmlElement)
  {
    return DMXDraws.Point2DTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Offset>());
  }
  
  private static bool CmpOffset(DXDraw.Transform2D openXmlElement, DMDraws.Point2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Point2DTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Offset>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOffset(DXDraw.Transform2D openXmlElement, DMDraws.Point2DType? value)
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
  private static DMDraws.PositiveSize2DType? GetExtents(DXDraw.Transform2D openXmlElement)
  {
    return DMXDraws.PositiveSize2DTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Extents>());
  }
  
  private static bool CmpExtents(DXDraw.Transform2D openXmlElement, DMDraws.PositiveSize2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PositiveSize2DTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Extents>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtents(DXDraw.Transform2D openXmlElement, DMDraws.PositiveSize2DType? value)
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
  
  public static DMDraws.Transform2D? CreateModelElement(DXDraw.Transform2D? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Transform2D();
      value.Rotation = GetRotation(openXmlElement);
      value.HorizontalFlip = GetHorizontalFlip(openXmlElement);
      value.VerticalFlip = GetVerticalFlip(openXmlElement);
      value.Offset = GetOffset(openXmlElement);
      value.Extents = GetExtents(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Transform2D? openXmlElement, DMDraws.Transform2D? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Transform2D? value)
    where OpenXmlElementType: DXDraw.Transform2D, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRotation(openXmlElement, value?.Rotation);
      SetHorizontalFlip(openXmlElement, value?.HorizontalFlip);
      SetVerticalFlip(openXmlElement, value?.VerticalFlip);
      SetOffset(openXmlElement, value?.Offset);
      SetExtents(openXmlElement, value?.Extents);
      return openXmlElement;
    }
    return default;
  }
}
