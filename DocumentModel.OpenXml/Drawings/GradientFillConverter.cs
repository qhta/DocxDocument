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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.GradientStopList>();
    if (itemElement != null)
      return DMXDraws.GradientStopListConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.LinearGradientFill>();
    if (itemElement != null)
      return DMXDraws.LinearGradientFillConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.PathGradientFill>();
    if (itemElement != null)
      return DMXDraws.PathGradientFillConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.TileRectangle>();
    if (itemElement != null)
      return DMXDraws.RelativeRectangleTypeConverter.CreateModelElement(itemElement);
    return null;
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
