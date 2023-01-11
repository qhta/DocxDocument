namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Top and Bottom Wrapping.
/// </summary>
public static class WrapTopBottomConverter
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  public static UInt32? GetDistanceFromTop(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom? openXmlElement)
  {
    return openXmlElement?.DistanceFromTop?.Value;
  }
  
  public static void SetDistanceFromTop(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromTop = value;
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public static UInt32? GetDistanceFromBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom? openXmlElement)
  {
    return openXmlElement?.DistanceFromBottom?.Value;
  }
  
  public static void SetDistanceFromBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromBottom = value;
  }
  
  /// <summary>
  /// Wrapping Boundaries.
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.EffectExtent? GetEffectExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.EffectExtentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom? openXmlElement, DocumentModel.Drawings.Wordprocessing.EffectExtent? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.EffectExtentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.WrapTopBottom? CreateModelElement(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.WrapTopBottom();
      value.DistanceFromTop = GetDistanceFromTop(openXmlElement);
      value.DistanceFromBottom = GetDistanceFromBottom(openXmlElement);
      value.EffectExtent = GetEffectExtent(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.WrapTopBottom? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTopBottom, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
