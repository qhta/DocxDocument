namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Object Extents Including Effects.
/// </summary>
public static class EffectExtentConverter
{
  /// <summary>
  /// Additional Extent on Left Edge
  /// </summary>
  public static Int64? GetLeftEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent? openXmlElement)
  {
    return openXmlElement?.LeftEdge?.Value;
  }
  
  public static void SetLeftEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.LeftEdge = value;
  }
  
  /// <summary>
  /// Additional Extent on Top Edge
  /// </summary>
  public static Int64? GetTopEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent? openXmlElement)
  {
    return openXmlElement?.TopEdge?.Value;
  }
  
  public static void SetTopEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.TopEdge = value;
  }
  
  /// <summary>
  /// Additional Extent on Right Edge
  /// </summary>
  public static Int64? GetRightEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent? openXmlElement)
  {
    return openXmlElement?.RightEdge?.Value;
  }
  
  public static void SetRightEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.RightEdge = value;
  }
  
  /// <summary>
  /// Additional Extent on Bottom Edge
  /// </summary>
  public static Int64? GetBottomEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent? openXmlElement)
  {
    return openXmlElement?.BottomEdge?.Value;
  }
  
  public static void SetBottomEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.BottomEdge = value;
  }
  
  public static DocumentModel.Drawings.Wordprocessing.EffectExtent? CreateModelElement(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.EffectExtent();
      value.LeftEdge = GetLeftEdge(openXmlElement);
      value.TopEdge = GetTopEdge(openXmlElement);
      value.RightEdge = GetRightEdge(openXmlElement);
      value.BottomEdge = GetBottomEdge(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.EffectExtent? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
