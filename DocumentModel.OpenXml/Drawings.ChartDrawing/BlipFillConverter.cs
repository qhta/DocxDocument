namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Picture Fill.
/// </summary>
public static class BlipFillConverter
{
  /// <summary>
  /// DPI Setting
  /// </summary>
  private static UInt32? GetDpi(DXDCD.BlipFill openXmlElement)
  {
    return openXmlElement?.Dpi?.Value;
  }
  
  private static bool CmpDpi(DXDCD.BlipFill openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Dpi?.Value == value) return true;
    diffs?.Add(objName, "Dpi", openXmlElement?.Dpi?.Value, value);
    return false;
  }
  
  private static void SetDpi(DXDCD.BlipFill openXmlElement, UInt32? value)
  {
    openXmlElement.Dpi = value;
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  private static Boolean? GetRotateWithShape(DXDCD.BlipFill openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }
  
  private static bool CmpRotateWithShape(DXDCD.BlipFill openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RotateWithShape?.Value == value) return true;
    diffs?.Add(objName, "RotateWithShape", openXmlElement?.RotateWithShape?.Value, value);
    return false;
  }
  
  private static void SetRotateWithShape(DXDCD.BlipFill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.RotateWithShape = null;
  }
  
  /// <summary>
  /// Blip.
  /// </summary>
  private static DMD.Blip? GetBlip(DXDCD.BlipFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Blip>();
    if (element != null)
      return DMXD.BlipConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlip(DXDCD.BlipFill openXmlElement, DMD.Blip? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.BlipConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Blip>(), value, diffs, objName, propName);
  }
  
  private static void SetBlip(DXDCD.BlipFill openXmlElement, DMD.Blip? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Blip>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BlipConverter.CreateOpenXmlElement<DXD.Blip>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Source Rectangle.
  /// </summary>
  private static DMD.RelativeRectangleType? GetSourceRectangle(DXDCD.BlipFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SourceRectangle>();
    if (element != null)
      return DMXD.RelativeRectangleTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSourceRectangle(DXDCD.BlipFill openXmlElement, DMD.RelativeRectangleType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.RelativeRectangleTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SourceRectangle>(), value, diffs, objName, propName);
  }
  
  private static void SetSourceRectangle(DXDCD.BlipFill openXmlElement, DMD.RelativeRectangleType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.SourceRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RelativeRectangleTypeConverter.CreateOpenXmlElement<DXD.SourceRectangle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Tile? GetTile(DXDCD.BlipFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Tile>();
    if (element != null)
      return DMXD.TileConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTile(DXDCD.BlipFill openXmlElement, DMD.Tile? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TileConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Tile>(), value, diffs, objName, propName);
  }
  
  private static void SetTile(DXDCD.BlipFill openXmlElement, DMD.Tile? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Tile>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.TileConverter.CreateOpenXmlElement<DXD.Tile>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Stretch? GetStretch(DXDCD.BlipFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Stretch>();
    if (element != null)
      return DMXD.StretchConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStretch(DXDCD.BlipFill openXmlElement, DMD.Stretch? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.StretchConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Stretch>(), value, diffs, objName, propName);
  }
  
  private static void SetStretch(DXDCD.BlipFill openXmlElement, DMD.Stretch? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Stretch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.StretchConverter.CreateOpenXmlElement<DXD.Stretch>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.ChartDrawing.BlipFill? CreateModelElement(DXDCD.BlipFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ChartDrawing.BlipFill();
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
  
  public static bool CompareModelElement(DXDCD.BlipFill? openXmlElement, DMDCD.BlipFill? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDpi(openXmlElement, value.Dpi, diffs, objName, propName))
        ok = false;
      if (!CmpRotateWithShape(openXmlElement, value.RotateWithShape, diffs, objName, propName))
        ok = false;
      if (!CmpBlip(openXmlElement, value.Blip, diffs, objName, propName))
        ok = false;
      if (!CmpSourceRectangle(openXmlElement, value.SourceRectangle, diffs, objName, propName))
        ok = false;
      if (!CmpTile(openXmlElement, value.Tile, diffs, objName, propName))
        ok = false;
      if (!CmpStretch(openXmlElement, value.Stretch, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.BlipFill value)
    where OpenXmlElementType: DXDCD.BlipFill, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.BlipFill openXmlElement, DMDCD.BlipFill value)
  {
    SetDpi(openXmlElement, value?.Dpi);
    SetRotateWithShape(openXmlElement, value?.RotateWithShape);
    SetBlip(openXmlElement, value?.Blip);
    SetSourceRectangle(openXmlElement, value?.SourceRectangle);
    SetTile(openXmlElement, value?.Tile);
    SetStretch(openXmlElement, value?.Stretch);
  }
}
