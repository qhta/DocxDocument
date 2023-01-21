namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Through Wrapping.
/// </summary>
public static class WrapThroughConverter
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  private static DMDrawsW.WrapTextKind? GetWrapText(DXDrawW.WrapThrough openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DMDrawsW.WrapTextKind>(openXmlElement?.WrapText?.Value);
  }
  
  private static void SetWrapText(DXDrawW.WrapThrough openXmlElement, DMDrawsW.WrapTextKind? value)
  {
    openXmlElement.WrapText = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DMDrawsW.WrapTextKind>(value);
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  private static UInt32? GetDistanceFromLeft(DXDrawW.WrapThrough openXmlElement)
  {
    return openXmlElement.DistanceFromLeft?.Value;
  }
  
  private static void SetDistanceFromLeft(DXDrawW.WrapThrough openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromLeft = value;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  private static UInt32? GetDistanceFromRight(DXDrawW.WrapThrough openXmlElement)
  {
    return openXmlElement.DistanceFromRight?.Value;
  }
  
  private static void SetDistanceFromRight(DXDrawW.WrapThrough openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromRight = value;
  }
  
  /// <summary>
  /// Wrapping Polygon.
  /// </summary>
  private static DMDrawsW.WrapPolygon? GetWrapPolygon(DXDrawW.WrapThrough openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawW.WrapPolygon>();
    if (itemElement != null)
      return DMXDrawsW.WrapPolygonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetWrapPolygon(DXDrawW.WrapThrough openXmlElement, DMDrawsW.WrapPolygon? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.WrapPolygon>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.WrapPolygonConverter.CreateOpenXmlElement<DXDrawW.WrapPolygon>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsW.WrapThrough? CreateModelElement(DXDrawW.WrapThrough? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsW.WrapThrough();
      value.WrapText = GetWrapText(openXmlElement);
      value.DistanceFromLeft = GetDistanceFromLeft(openXmlElement);
      value.DistanceFromRight = GetDistanceFromRight(openXmlElement);
      value.WrapPolygon = GetWrapPolygon(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.WrapThrough? value)
    where OpenXmlElementType: DXDrawW.WrapThrough, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWrapText(openXmlElement, value?.WrapText);
      SetDistanceFromLeft(openXmlElement, value?.DistanceFromLeft);
      SetDistanceFromRight(openXmlElement, value?.DistanceFromRight);
      SetWrapPolygon(openXmlElement, value?.WrapPolygon);
      return openXmlElement;
    }
    return default;
  }
}
