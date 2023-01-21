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
    return openXmlElement.Dpi?.Value;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Blip>();
    if (itemElement != null)
      return DMXDraws.BlipConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.SourceRectangle>();
    if (itemElement != null)
      return DMXDraws.RelativeRectangleTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Tile>();
    if (itemElement != null)
      return DMXDraws.TileConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Stretch>();
    if (itemElement != null)
      return DMXDraws.StretchConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDraws.BlipFill? CreateModelElement(DXDraw.BlipFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.BlipFill();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BlipFill? value)
    where OpenXmlElementType: DXDraw.BlipFill, new()
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
