namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Stretch.
/// </summary>
public static class StretchConverter
{
  /// <summary>
  /// Fill Rectangle.
  /// </summary>
  private static DMDraws.RelativeRectangleType? GetFillRectangle(DXDraw.Stretch openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FillRectangle>();
    if (itemElement != null)
      return DMXDraws.RelativeRectangleTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFillRectangle(DXDraw.Stretch openXmlElement, DMDraws.RelativeRectangleType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FillRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RelativeRectangleTypeConverter.CreateOpenXmlElement<DXDraw.FillRectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.Stretch? CreateModelElement(DXDraw.Stretch? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Stretch();
      value.FillRectangle = GetFillRectangle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Stretch? value)
    where OpenXmlElementType: DXDraw.Stretch, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFillRectangle(openXmlElement, value?.FillRectangle);
      return openXmlElement;
    }
    return default;
  }
}
