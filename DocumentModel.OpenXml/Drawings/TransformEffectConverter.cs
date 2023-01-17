namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Transform Effect.
/// </summary>
public static class TransformEffectConverter
{
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  private static Int32? GetHorizontalRatio(DocumentFormat.OpenXml.Drawing.TransformEffect openXmlElement)
  {
    return openXmlElement.HorizontalRatio?.Value;
  }
  
  private static void SetHorizontalRatio(DocumentFormat.OpenXml.Drawing.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalRatio = value;
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  private static Int32? GetVerticalRatio(DocumentFormat.OpenXml.Drawing.TransformEffect openXmlElement)
  {
    return openXmlElement.VerticalRatio?.Value;
  }
  
  private static void SetVerticalRatio(DocumentFormat.OpenXml.Drawing.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.VerticalRatio = value;
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  private static Int32? GetHorizontalSkew(DocumentFormat.OpenXml.Drawing.TransformEffect openXmlElement)
  {
    return openXmlElement.HorizontalSkew?.Value;
  }
  
  private static void SetHorizontalSkew(DocumentFormat.OpenXml.Drawing.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.HorizontalSkew = value;
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  private static Int32? GetVerticalSkew(DocumentFormat.OpenXml.Drawing.TransformEffect openXmlElement)
  {
    return openXmlElement.VerticalSkew?.Value;
  }
  
  private static void SetVerticalSkew(DocumentFormat.OpenXml.Drawing.TransformEffect openXmlElement, Int32? value)
  {
    openXmlElement.VerticalSkew = value;
  }
  
  /// <summary>
  /// Horizontal Shift
  /// </summary>
  private static Int64? GetHorizontalShift(DocumentFormat.OpenXml.Drawing.TransformEffect openXmlElement)
  {
    return openXmlElement.HorizontalShift?.Value;
  }
  
  private static void SetHorizontalShift(DocumentFormat.OpenXml.Drawing.TransformEffect openXmlElement, Int64? value)
  {
    openXmlElement.HorizontalShift = value;
  }
  
  /// <summary>
  /// Vertical Shift
  /// </summary>
  private static Int64? GetVerticalShift(DocumentFormat.OpenXml.Drawing.TransformEffect openXmlElement)
  {
    return openXmlElement.VerticalShift?.Value;
  }
  
  private static void SetVerticalShift(DocumentFormat.OpenXml.Drawing.TransformEffect openXmlElement, Int64? value)
  {
    openXmlElement.VerticalShift = value;
  }
  
  public static DocumentModel.Drawings.TransformEffect? CreateModelElement(DocumentFormat.OpenXml.Drawing.TransformEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TransformEffect();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.TransformEffect? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.TransformEffect, new()
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
