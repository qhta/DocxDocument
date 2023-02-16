namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// 2D Transform for Grouped Objects.
/// </summary>
public static class TransformGroupConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  private static Int32? GetRotation(DXDraw.TransformGroup openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  private static bool CmpRotation(DXDraw.TransformGroup openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Rotation?.Value == value) return true;
    diffs?.Add(objName, "Rotation", openXmlElement?.Rotation?.Value, value);
    return false;
  }
  
  private static void SetRotation(DXDraw.TransformGroup openXmlElement, Int32? value)
  {
    openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Horizontal Flip
  /// </summary>
  private static Boolean? GetHorizontalFlip(DXDraw.TransformGroup openXmlElement)
  {
    return openXmlElement?.HorizontalFlip?.Value;
  }
  
  private static bool CmpHorizontalFlip(DXDraw.TransformGroup openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HorizontalFlip?.Value == value) return true;
    diffs?.Add(objName, "HorizontalFlip", openXmlElement?.HorizontalFlip?.Value, value);
    return false;
  }
  
  private static void SetHorizontalFlip(DXDraw.TransformGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.HorizontalFlip = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.HorizontalFlip = null;
  }
  
  /// <summary>
  /// Vertical Flip
  /// </summary>
  private static Boolean? GetVerticalFlip(DXDraw.TransformGroup openXmlElement)
  {
    return openXmlElement?.VerticalFlip?.Value;
  }
  
  private static bool CmpVerticalFlip(DXDraw.TransformGroup openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.VerticalFlip?.Value == value) return true;
    diffs?.Add(objName, "VerticalFlip", openXmlElement?.VerticalFlip?.Value, value);
    return false;
  }
  
  private static void SetVerticalFlip(DXDraw.TransformGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.VerticalFlip = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.VerticalFlip = null;
  }
  
  /// <summary>
  /// Offset.
  /// </summary>
  private static DMDraws.Point2DType? GetOffset(DXDraw.TransformGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Offset>();
    if (element != null)
      return DMXDraws.Point2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOffset(DXDraw.TransformGroup openXmlElement, DMDraws.Point2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Point2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Offset>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOffset(DXDraw.TransformGroup openXmlElement, DMDraws.Point2DType? value)
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
  private static DMDraws.PositiveSize2DType? GetExtents(DXDraw.TransformGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Extents>();
    if (element != null)
      return DMXDraws.PositiveSize2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtents(DXDraw.TransformGroup openXmlElement, DMDraws.PositiveSize2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PositiveSize2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Extents>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtents(DXDraw.TransformGroup openXmlElement, DMDraws.PositiveSize2DType? value)
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
  
  /// <summary>
  /// Child Offset.
  /// </summary>
  private static DMDraws.Point2DType? GetChildOffset(DXDraw.TransformGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ChildOffset>();
    if (element != null)
      return DMXDraws.Point2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildOffset(DXDraw.TransformGroup openXmlElement, DMDraws.Point2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.Point2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ChildOffset>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChildOffset(DXDraw.TransformGroup openXmlElement, DMDraws.Point2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ChildOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.Point2DTypeConverter.CreateOpenXmlElement<DXDraw.ChildOffset>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Child Extents.
  /// </summary>
  private static DMDraws.PositiveSize2DType? GetChildExtents(DXDraw.TransformGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ChildExtents>();
    if (element != null)
      return DMXDraws.PositiveSize2DTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildExtents(DXDraw.TransformGroup openXmlElement, DMDraws.PositiveSize2DType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PositiveSize2DTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ChildExtents>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChildExtents(DXDraw.TransformGroup openXmlElement, DMDraws.PositiveSize2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ChildExtents>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PositiveSize2DTypeConverter.CreateOpenXmlElement<DXDraw.ChildExtents>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.TransformGroup? CreateModelElement(DXDraw.TransformGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TransformGroup();
      value.Rotation = GetRotation(openXmlElement);
      value.HorizontalFlip = GetHorizontalFlip(openXmlElement);
      value.VerticalFlip = GetVerticalFlip(openXmlElement);
      value.Offset = GetOffset(openXmlElement);
      value.Extents = GetExtents(openXmlElement);
      value.ChildOffset = GetChildOffset(openXmlElement);
      value.ChildExtents = GetChildExtents(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.TransformGroup? openXmlElement, DMDraws.TransformGroup? value, DiffList? diffs, string? objName)
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
      if (!CmpChildOffset(openXmlElement, value.ChildOffset, diffs, objName))
        ok = false;
      if (!CmpChildExtents(openXmlElement, value.ChildExtents, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.TransformGroup? value)
    where OpenXmlElementType: DXDraw.TransformGroup, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRotation(openXmlElement, value?.Rotation);
      SetHorizontalFlip(openXmlElement, value?.HorizontalFlip);
      SetVerticalFlip(openXmlElement, value?.VerticalFlip);
      SetOffset(openXmlElement, value?.Offset);
      SetExtents(openXmlElement, value?.Extents);
      SetChildOffset(openXmlElement, value?.ChildOffset);
      SetChildExtents(openXmlElement, value?.ChildExtents);
      return openXmlElement;
    }
    return default;
  }
}
