namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Transform Effect.
/// </summary>
public static class TransformEffectConverter
{
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  private static Int32? GetHorizontalRatio(DXDraw.TransformEffect openXmlElement)
  {
    return openXmlElement.HorizontalRatio?.Value;
  }
  
  private static void SetHorizontalRatio(DXDraw.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalRatio = value;
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  private static Int32? GetVerticalRatio(DXDraw.TransformEffect openXmlElement)
  {
    return openXmlElement.VerticalRatio?.Value;
  }
  
  private static void SetVerticalRatio(DXDraw.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.VerticalRatio = value;
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  private static Int32? GetHorizontalSkew(DXDraw.TransformEffect openXmlElement)
  {
    return openXmlElement.HorizontalSkew?.Value;
  }
  
  private static void SetHorizontalSkew(DXDraw.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalSkew = value;
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  private static Int32? GetVerticalSkew(DXDraw.TransformEffect openXmlElement)
  {
    return openXmlElement.VerticalSkew?.Value;
  }
  
  private static void SetVerticalSkew(DXDraw.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.VerticalSkew = value;
  }
  
  /// <summary>
  /// Horizontal Shift
  /// </summary>
  private static Int64? GetHorizontalShift(DXDraw.TransformEffect openXmlElement)
  {
    return openXmlElement.HorizontalShift?.Value;
  }
  
  private static void SetHorizontalShift(DXDraw.TransformEffect openXmlElement, Int64? value)
  {
    openXmlElement.HorizontalShift = value;
  }
  
  /// <summary>
  /// Vertical Shift
  /// </summary>
  private static Int64? GetVerticalShift(DXDraw.TransformEffect openXmlElement)
  {
    return openXmlElement.VerticalShift?.Value;
  }
  
  private static void SetVerticalShift(DXDraw.TransformEffect openXmlElement, Int64? value)
  {
    openXmlElement.VerticalShift = value;
  }
  
  public static DMDraws.TransformEffect? CreateModelElement(DXDraw.TransformEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.TransformEffect();
      value.HorizontalRatio = GetHorizontalRatio(openXmlElement);
      value.VerticalRatio = GetVerticalRatio(openXmlElement);
      value.HorizontalSkew = GetHorizontalSkew(openXmlElement);
      value.VerticalSkew = GetVerticalSkew(openXmlElement);
      value.HorizontalShift = GetHorizontalShift(openXmlElement);
      value.VerticalShift = GetVerticalShift(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.TransformEffect? value)
    where OpenXmlElementType: DXDraw.TransformEffect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHorizontalRatio(openXmlElement, value?.HorizontalRatio);
      SetVerticalRatio(openXmlElement, value?.VerticalRatio);
      SetHorizontalSkew(openXmlElement, value?.HorizontalSkew);
      SetVerticalSkew(openXmlElement, value?.VerticalSkew);
      SetHorizontalShift(openXmlElement, value?.HorizontalShift);
      SetVerticalShift(openXmlElement, value?.VerticalShift);
      return openXmlElement;
    }
    return default;
  }
}
