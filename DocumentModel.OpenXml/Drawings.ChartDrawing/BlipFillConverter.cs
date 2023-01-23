namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Picture Fill.
/// </summary>
public static class BlipFillConverter
{
  /// <summary>
  /// DPI Setting
  /// </summary>
  private static UInt32? GetDpi(DXDrawChartDraw.BlipFill openXmlElement)
  {
    return openXmlElement.Dpi?.Value;
  }
  
  private static bool CmpDpi(DXDrawChartDraw.BlipFill openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Dpi?.Value == value;
  }
  
  private static void SetDpi(DXDrawChartDraw.BlipFill openXmlElement, UInt32? value)
  {
    openXmlElement.Dpi = value;
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  private static Boolean? GetRotateWithShape(DXDrawChartDraw.BlipFill openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }
  
  private static bool CmpRotateWithShape(DXDrawChartDraw.BlipFill openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RotateWithShape?.Value == value;
  }
  
  private static void SetRotateWithShape(DXDrawChartDraw.BlipFill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.RotateWithShape = null;
  }
  
  /// <summary>
  /// Blip.
  /// </summary>
  private static DMDraws.Blip? GetBlip(DXDrawChartDraw.BlipFill openXmlElement)
  {
    return DMXDraws.BlipConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Blip>());
  }
  
  private static bool CmpBlip(DXDrawChartDraw.BlipFill openXmlElement, DMDraws.Blip? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BlipConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Blip>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlip(DXDrawChartDraw.BlipFill openXmlElement, DMDraws.Blip? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Blip>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BlipConverter.CreateOpenXmlElement<DXDraw.Blip>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Source Rectangle.
  /// </summary>
  private static DMDraws.RelativeRectangleType? GetSourceRectangle(DXDrawChartDraw.BlipFill openXmlElement)
  {
    return DMXDraws.RelativeRectangleTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.SourceRectangle>());
  }
  
  private static bool CmpSourceRectangle(DXDrawChartDraw.BlipFill openXmlElement, DMDraws.RelativeRectangleType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RelativeRectangleTypeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.SourceRectangle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSourceRectangle(DXDrawChartDraw.BlipFill openXmlElement, DMDraws.RelativeRectangleType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.SourceRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RelativeRectangleTypeConverter.CreateOpenXmlElement<DXDraw.SourceRectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Tile? GetTile(DXDrawChartDraw.BlipFill openXmlElement)
  {
    return DMXDraws.TileConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Tile>());
  }
  
  private static bool CmpTile(DXDrawChartDraw.BlipFill openXmlElement, DMDraws.Tile? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TileConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Tile>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTile(DXDrawChartDraw.BlipFill openXmlElement, DMDraws.Tile? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Tile>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.TileConverter.CreateOpenXmlElement<DXDraw.Tile>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Stretch? GetStretch(DXDrawChartDraw.BlipFill openXmlElement)
  {
    return DMXDraws.StretchConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Stretch>());
  }
  
  private static bool CmpStretch(DXDrawChartDraw.BlipFill openXmlElement, DMDraws.Stretch? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.StretchConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Stretch>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStretch(DXDrawChartDraw.BlipFill openXmlElement, DMDraws.Stretch? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Stretch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.StretchConverter.CreateOpenXmlElement<DXDraw.Stretch>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraw.BlipFill? CreateModelElement(DXDrawChartDraw.BlipFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.BlipFill();
      value.Dpi = GetDpi(openXmlElement);
      value.RotateWithShape = GetRotateWithShape(openXmlElement);
      value.Blip = GetBlip(openXmlElement);
      value.SourceRectangle = GetSourceRectangle(openXmlElement);
      value.Tile = GetTile(openXmlElement);
      value.Stretch = GetStretch(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawChartDraw.BlipFill? openXmlElement, DMDrawsChartDraw.BlipFill? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDpi(openXmlElement, value.Dpi, diffs, objName))
        ok = false;
      if (!CmpRotateWithShape(openXmlElement, value.RotateWithShape, diffs, objName))
        ok = false;
      if (!CmpBlip(openXmlElement, value.Blip, diffs, objName))
        ok = false;
      if (!CmpSourceRectangle(openXmlElement, value.SourceRectangle, diffs, objName))
        ok = false;
      if (!CmpTile(openXmlElement, value.Tile, diffs, objName))
        ok = false;
      if (!CmpStretch(openXmlElement, value.Stretch, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.BlipFill? value)
    where OpenXmlElementType: DXDrawChartDraw.BlipFill, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDpi(openXmlElement, value?.Dpi);
      SetRotateWithShape(openXmlElement, value?.RotateWithShape);
      SetBlip(openXmlElement, value?.Blip);
      SetSourceRectangle(openXmlElement, value?.SourceRectangle);
      SetTile(openXmlElement, value?.Tile);
      SetStretch(openXmlElement, value?.Stretch);
      return openXmlElement;
    }
    return default;
  }
}
