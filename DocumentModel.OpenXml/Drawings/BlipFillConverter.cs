namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BlipFill Class.
/// </summary>
public static class BlipFillConverter
{
  /// <summary>
  /// DPI Setting
  /// </summary>
  private static UInt32? GetDpi(DXD.BlipFill openXmlElement)
  {
    return openXmlElement?.Dpi?.Value;
  }
  
  private static bool CmpDpi(DXD.BlipFill openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Dpi?.Value == value) return true;
    diffs?.Add(objName, "Dpi", openXmlElement?.Dpi?.Value, value);
    return false;
  }
  
  private static void SetDpi(DXD.BlipFill openXmlElement, UInt32? value)
  {
    openXmlElement.Dpi = value;
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  private static Boolean? GetRotateWithShape(DXD.BlipFill openXmlElement)
  {
    return openXmlElement?.RotateWithShape?.Value;
  }
  
  private static bool CmpRotateWithShape(DXD.BlipFill openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RotateWithShape?.Value == value) return true;
    diffs?.Add(objName, "RotateWithShape", openXmlElement?.RotateWithShape?.Value, value);
    return false;
  }
  
  private static void SetRotateWithShape(DXD.BlipFill openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.RotateWithShape = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.RotateWithShape = null;
  }
  
  /// <summary>
  /// Blip.
  /// </summary>
  private static DMD.Blip? GetBlip(DXD.BlipFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Blip>();
    if (element != null)
      return DMXD.BlipConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBlip(DXD.BlipFill openXmlElement, DMD.Blip? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.BlipConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Blip>(), value, diffs, objName, propName);
  }
  
  private static void SetBlip(DXD.BlipFill openXmlElement, DMD.Blip? value)
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
  private static DMD.RelativeRectangleType? GetSourceRectangle(DXD.BlipFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.SourceRectangle>();
    if (element != null)
      return DMXD.RelativeRectangleTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSourceRectangle(DXD.BlipFill openXmlElement, DMD.RelativeRectangleType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.RelativeRectangleTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.SourceRectangle>(), value, diffs, objName, propName);
  }
  
  private static void SetSourceRectangle(DXD.BlipFill openXmlElement, DMD.RelativeRectangleType? value)
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
  
  private static DMD.Tile? GetTile(DXD.BlipFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Tile>();
    if (element != null)
      return DMXD.TileConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTile(DXD.BlipFill openXmlElement, DMD.Tile? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.TileConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Tile>(), value, diffs, objName, propName);
  }
  
  private static void SetTile(DXD.BlipFill openXmlElement, DMD.Tile? value)
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
  
  private static DMD.Stretch? GetStretch(DXD.BlipFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Stretch>();
    if (element != null)
      return DMXD.StretchConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStretch(DXD.BlipFill openXmlElement, DMD.Stretch? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.StretchConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Stretch>(), value, diffs, objName, propName);
  }
  
  private static void SetStretch(DXD.BlipFill openXmlElement, DMD.Stretch? value)
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
  
  public static DocumentModel.Drawings.BlipFill? CreateModelElement(DXD.BlipFill? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.BlipFill? openXmlElement, DMD.BlipFill? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static DXD.BlipFill CreateOpenXmlElement(DMD.BlipFill value)
  {
    var openXmlElement = new DXD.BlipFill();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXD.BlipFill openXmlElement, DMD.BlipFill value)
  {
    SetDpi(openXmlElement, value?.Dpi);
    SetRotateWithShape(openXmlElement, value?.RotateWithShape);
    SetBlip(openXmlElement, value?.Blip);
    SetSourceRectangle(openXmlElement, value?.SourceRectangle);
    SetTile(openXmlElement, value?.Tile);
    SetStretch(openXmlElement, value?.Stretch);
    return true;
  }
}
