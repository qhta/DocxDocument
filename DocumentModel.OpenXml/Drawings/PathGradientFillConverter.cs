namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Path Gradient.
/// </summary>
public static class PathGradientFillConverter
{
  /// <summary>
  /// Gradient Fill Path
  /// </summary>
  private static DMDraws.PathShadeKind? GetPath(DXDraw.PathGradientFill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PathShadeValues, DMDraws.PathShadeKind>(openXmlElement?.Path?.Value);
  }
  
  private static void SetPath(DXDraw.PathGradientFill openXmlElement, DMDraws.PathShadeKind? value)
  {
    openXmlElement.Path = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PathShadeValues, DMDraws.PathShadeKind>(value);
  }
  
  /// <summary>
  /// Fill To Rectangle.
  /// </summary>
  private static DMDraws.RelativeRectangleType? GetFillToRectangle(DXDraw.PathGradientFill openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.FillToRectangle>();
    if (itemElement != null)
      return DMXDraws.RelativeRectangleTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFillToRectangle(DXDraw.PathGradientFill openXmlElement, DMDraws.RelativeRectangleType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FillToRectangle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RelativeRectangleTypeConverter.CreateOpenXmlElement<DXDraw.FillToRectangle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.PathGradientFill? CreateModelElement(DXDraw.PathGradientFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.PathGradientFill();
      value.Path = GetPath(openXmlElement);
      value.FillToRectangle = GetFillToRectangle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PathGradientFill? value)
    where OpenXmlElementType: DXDraw.PathGradientFill, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPath(openXmlElement, value?.Path);
      SetFillToRectangle(openXmlElement, value?.FillToRectangle);
      return openXmlElement;
    }
    return default;
  }
}
