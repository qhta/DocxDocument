namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Object Extents Including Effects.
/// </summary>
public static class EffectExtentConverter
{
  /// <summary>
  /// Additional Extent on Left Edge
  /// </summary>
  private static Int64? GetLeftEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent openXmlElement)
  {
    return openXmlElement.LeftEdge?.Value;
  }
  
  private static void SetLeftEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent openXmlElement, Int64? value)
  {
    openXmlElement.LeftEdge = value;
  }
  
  /// <summary>
  /// Additional Extent on Top Edge
  /// </summary>
  private static Int64? GetTopEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent openXmlElement)
  {
    return openXmlElement.TopEdge?.Value;
  }
  
  private static void SetTopEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent openXmlElement, Int64? value)
  {
    openXmlElement.TopEdge = value;
  }
  
  /// <summary>
  /// Additional Extent on Right Edge
  /// </summary>
  private static Int64? GetRightEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent openXmlElement)
  {
    return openXmlElement.RightEdge?.Value;
  }
  
  private static void SetRightEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent openXmlElement, Int64? value)
  {
    openXmlElement.RightEdge = value;
  }
  
  /// <summary>
  /// Additional Extent on Bottom Edge
  /// </summary>
  private static Int64? GetBottomEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent openXmlElement)
  {
    return openXmlElement.BottomEdge?.Value;
  }
  
  private static void SetBottomEdge(DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent openXmlElement, Int64? value)
  {
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLeftEdge(openXmlElement, value?.LeftEdge);
      SetTopEdge(openXmlElement, value?.TopEdge);
      SetRightEdge(openXmlElement, value?.RightEdge);
      SetBottomEdge(openXmlElement, value?.BottomEdge);
      return openXmlElement;
    }
    return default;
  }
}
