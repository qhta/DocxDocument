namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BlipFill Class.
/// </summary>
public static class BlipFillConverter
{
  /// <summary>
  /// DPI Setting
  /// </summary>
  private static UInt32? GetDpi(DXDraw.BlipFill openXmlElement)
  {
    return openXmlElement?.Dpi?.Value;
  }
  
  private static bool CmpDpi(DXDraw.BlipFill openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Dpi?.Value == value) return true;
    diffs?.Add(objName, "Dpi", openXmlElement?.Dpi?.Value, value);
    return false;
  }
  
  private static void SetDpi(DXDraw.BlipFill openXmlElement, UInt32? value)
  {
    openXmlElement.Dpi = value;
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  private static Boolean? GetRotateWithShape(DXDraw.BlipFill openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }
  
  private static bool CmpRotateWithShape(DXDraw.BlipFill openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RotateWithShape?.Value == value) return true;
    diffs?.Add(objName, "RotateWithShape", openXmlElement?.RotateWithShape?.Value, value);
    return false;
  }
  
  private static void SetRotateWithShape(DXDraw.BlipFill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.RotateWithShape = null;
  }
  
  /// <summary>
  /// Blip.
  /// </summary>
  private static DMDraws.Blip? GetBlip(DXDraw.BlipFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Blip>();
    if (element != null)
      return DMXDraws.BlipConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlip(DXDraw.BlipFill openXmlElement, DMDraws.Blip? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BlipConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Blip>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBlip(DXDraw.BlipFill openXmlElement, DMDraws.Blip? value)
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
  private static DMDraws.RelativeRectangleType? GetSourceRectangle(DXDraw.BlipFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.SourceRectangle>();
    if (element != null)
      return DMXDraws.RelativeRectangleTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSourceRectangle(DXDraw.BlipFill openXmlElement, DMDraws.RelativeRectangleType? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RelativeRectangleTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.SourceRectangle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSourceRectangle(DXDraw.BlipFill openXmlElement, DMDraws.RelativeRectangleType? value)
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
  
  private static DMDraws.Tile? GetTile(DXDraw.BlipFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Tile>();
    if (element != null)
      return DMXDraws.TileConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTile(DXDraw.BlipFill openXmlElement, DMDraws.Tile? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.TileConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Tile>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTile(DXDraw.BlipFill openXmlElement, DMDraws.Tile? value)
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
  
  private static DMDraws.Stretch? GetStretch(DXDraw.BlipFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Stretch>();
    if (element != null)
      return DMXDraws.StretchConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStretch(DXDraw.BlipFill openXmlElement, DMDraws.Stretch? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.StretchConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Stretch>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStretch(DXDraw.BlipFill openXmlElement, DMDraws.Stretch? value)
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
  
  public static DocumentModel.Drawings.BlipFill? CreateModelElement(DXDraw.BlipFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BlipFill();
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
  
  public static bool CompareModelElement(DXDraw.BlipFill? openXmlElement, DMDraws.BlipFill? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BlipFill value)
    where OpenXmlElementType: DXDraw.BlipFill, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.BlipFill openXmlElement, DMDraws.BlipFill value)
  {
    SetDpi(openXmlElement, value?.Dpi);
    SetRotateWithShape(openXmlElement, value?.RotateWithShape);
    SetBlip(openXmlElement, value?.Blip);
    SetSourceRectangle(openXmlElement, value?.SourceRectangle);
    SetTile(openXmlElement, value?.Tile);
    SetStretch(openXmlElement, value?.Stretch);
    }
  }
