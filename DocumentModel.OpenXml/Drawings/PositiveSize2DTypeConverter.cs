namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PositiveSize2DType Class.
/// </summary>
public static class PositiveSize2DTypeConverter
{
  /// <summary>
  /// Extent Length
  /// </summary>
  private static Int64? GetCx(DXDraw.PositiveSize2DType openXmlElement)
  {
    return openXmlElement.Cx?.Value;
  }
  
  private static void SetCx(DXDraw.PositiveSize2DType openXmlElement, Int64? value)
  {
    openXmlElement.Cx = value;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  private static Int64? GetCy(DXDraw.PositiveSize2DType openXmlElement)
  {
    return openXmlElement.Cy?.Value;
  }
  
  private static void SetCy(DXDraw.PositiveSize2DType openXmlElement, Int64? value)
  {
    openXmlElement.Cy = value;
  }
  
  public static DMDraws.PositiveSize2DType? CreateModelElement(DXDraw.PositiveSize2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.PositiveSize2DType();
      value.Cx = GetCx(openXmlElement);
      value.Cy = GetCy(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PositiveSize2DType? value)
    where OpenXmlElementType: DXDraw.PositiveSize2DType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCx(openXmlElement, value?.Cx);
      SetCy(openXmlElement, value?.Cy);
      return openXmlElement;
    }
    return default;
  }
}
