namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the GradientFill Class.
/// </summary>
public static class GradientFillConverter
{
  /// <summary>
  /// Tile Flip
  /// </summary>
  private static DMDraws.TileFlipKind? GetFlip(DXDraw.GradientFill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DMDraws.TileFlipKind>(openXmlElement?.Flip?.Value);
  }
  
  private static bool CmpFlip(DXDraw.GradientFill openXmlElement, DMDraws.TileFlipKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DMDraws.TileFlipKind>(openXmlElement?.Flip?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFlip(DXDraw.GradientFill openXmlElement, DMDraws.TileFlipKind? value)
  {
    openXmlElement.Flip = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TileFlipValues, DMDraws.TileFlipKind>(value);
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  private static Boolean? GetRotateWithShape(DXDraw.GradientFill openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }
  
  private static bool CmpRotateWithShape(DXDraw.GradientFill openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RotateWithShape?.Value == value;
  }
  
  private static void SetRotateWithShape(DXDraw.GradientFill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.RotateWithShape = null;
  }
  
  /// <summary>
  /// Gradient Stop List.
  /// </summary>
  private static DMDraws.GradientStopList? GetGradientStopList(DXDraw.GradientFill openXmlElement)
  {
    return DMXDraws.GradientStopListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.GradientStopList>());
  }
  
  private static bool CmpGradientStopList(DXDraw.GradientFill openXmlElement, DMDraws.GradientStopList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.GradientStopListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.GradientStopList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGradientStopList(DXDraw.GradientFill openXmlElement, DMDraws.GradientStopList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.GradientStopList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.GradientStopListConverter.CreateOpenXmlElement<DXDraw.GradientStopList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.LinearGradientFill? GetLinearGradientFill(DXDraw.GradientFill openXmlElement)
  {
    return DMXDraws.LinearGradientFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.LinearGradientFill>());
  }
  
  private static bool CmpLinearGradientFill(DXDraw.GradientFill openXmlElement, DMDraws.LinearGradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LinearGradientFillConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.LinearGradientFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLinearGradientFill(DXDraw.GradientFill openXmlElement, DMDraws.LinearGradientFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.LinearGradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LinearGradientFillConverter.CreateOpenXmlElement<DXDraw.LinearGradientFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.PathGradientFill? GetPathGradientFill(DXDraw.GradientFill openXmlElement)
  {
    return DMXDraws.PathGradientFillConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.PathGradientFill>());
  }
  
  private static bool CmpPathGradientFill(DXDraw.GradientFill openXmlElement, DMDraws.PathGradientFill? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PathGradientFillConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.PathGradientFill>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPathGradientFill(DXDraw.GradientFill openXmlElement, DMDraws.PathGradientFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PathGradientFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PathGradientFillConverter.CreateOpenXmlElement<DXDraw.PathGradientFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.RelativeRectangleType? GetTileRectangle(DXDraw.GradientFill openXmlElement)
  {
    return DMXDraws.RelativeRectangleTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.TileRectangle>());
  }
  
  private static bool CmpTileRectangle(DXDraw.GradientFill openXmlElement, DMDraws.RelativeRectangleType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RelativeRectangleTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.TileRectangle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTileRectangle(DXDraw.GradientFill openXmlElement, DMDraws.RelativeRectangleType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.TileRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RelativeRectangleTypeConverter.CreateOpenXmlElement<DXDraw.TileRectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.GradientFill? CreateModelElement(DXDraw.GradientFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.GradientFill();
      value.Flip = GetFlip(openXmlElement);
      value.RotateWithShape = GetRotateWithShape(openXmlElement);
      value.GradientStopList = GetGradientStopList(openXmlElement);
      value.LinearGradientFill = GetLinearGradientFill(openXmlElement);
      value.PathGradientFill = GetPathGradientFill(openXmlElement);
      value.TileRectangle = GetTileRectangle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.GradientFill? openXmlElement, DMDraws.GradientFill? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFlip(openXmlElement, value.Flip, diffs, objName))
        ok = false;
      if (!CmpRotateWithShape(openXmlElement, value.RotateWithShape, diffs, objName))
        ok = false;
      if (!CmpGradientStopList(openXmlElement, value.GradientStopList, diffs, objName))
        ok = false;
      if (!CmpLinearGradientFill(openXmlElement, value.LinearGradientFill, diffs, objName))
        ok = false;
      if (!CmpPathGradientFill(openXmlElement, value.PathGradientFill, diffs, objName))
        ok = false;
      if (!CmpTileRectangle(openXmlElement, value.TileRectangle, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.GradientFill? value)
    where OpenXmlElementType: DXDraw.GradientFill, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFlip(openXmlElement, value?.Flip);
      SetRotateWithShape(openXmlElement, value?.RotateWithShape);
      SetGradientStopList(openXmlElement, value?.GradientStopList);
      SetLinearGradientFill(openXmlElement, value?.LinearGradientFill);
      SetPathGradientFill(openXmlElement, value?.PathGradientFill);
      SetTileRectangle(openXmlElement, value?.TileRectangle);
      return openXmlElement;
    }
    return default;
  }
}
