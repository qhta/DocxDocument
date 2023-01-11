namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Transform Effect.
/// </summary>
public static class TransformEffectConverter
{
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  public static Int32? GetHorizontalRatio(DocumentFormat.OpenXml.Drawing.TransformEffect? openXmlElement)
  {
    return openXmlElement?.HorizontalRatio?.Value;
  }
  
  public static void SetHorizontalRatio(DocumentFormat.OpenXml.Drawing.TransformEffect? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalRatio = value;
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  public static Int32? GetVerticalRatio(DocumentFormat.OpenXml.Drawing.TransformEffect? openXmlElement)
  {
    return openXmlElement?.VerticalRatio?.Value;
  }
  
  public static void SetVerticalRatio(DocumentFormat.OpenXml.Drawing.TransformEffect? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalRatio = value;
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  public static Int32? GetHorizontalSkew(DocumentFormat.OpenXml.Drawing.TransformEffect? openXmlElement)
  {
    return openXmlElement?.HorizontalSkew?.Value;
  }
  
  public static void SetHorizontalSkew(DocumentFormat.OpenXml.Drawing.TransformEffect? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalSkew = value;
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  public static Int32? GetVerticalSkew(DocumentFormat.OpenXml.Drawing.TransformEffect? openXmlElement)
  {
    return openXmlElement?.VerticalSkew?.Value;
  }
  
  public static void SetVerticalSkew(DocumentFormat.OpenXml.Drawing.TransformEffect? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalSkew = value;
  }
  
  /// <summary>
  /// Horizontal Shift
  /// </summary>
  public static Int64? GetHorizontalShift(DocumentFormat.OpenXml.Drawing.TransformEffect? openXmlElement)
  {
    return openXmlElement?.HorizontalShift?.Value;
  }
  
  public static void SetHorizontalShift(DocumentFormat.OpenXml.Drawing.TransformEffect? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalShift = value;
  }
  
  /// <summary>
  /// Vertical Shift
  /// </summary>
  public static Int64? GetVerticalShift(DocumentFormat.OpenXml.Drawing.TransformEffect? openXmlElement)
  {
    return openXmlElement?.VerticalShift?.Value;
  }
  
  public static void SetVerticalShift(DocumentFormat.OpenXml.Drawing.TransformEffect? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
