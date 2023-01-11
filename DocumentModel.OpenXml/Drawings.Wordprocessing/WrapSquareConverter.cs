namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Square Wrapping.
/// </summary>
public static class WrapSquareConverter
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.WrapTextKind? GetWrapText(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DocumentModel.Drawings.Wordprocessing.WrapTextKind>(openXmlElement?.WrapText?.Value);
  }
  
  public static void SetWrapText(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement, DocumentModel.Drawings.Wordprocessing.WrapTextKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.WrapText = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DocumentModel.Drawings.Wordprocessing.WrapTextKind>(value);
  }
  
  /// <summary>
  /// Distance From Text (Top)
  /// </summary>
  public static UInt32? GetDistanceFromTop(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement)
  {
    return openXmlElement?.DistanceFromTop?.Value;
  }
  
  public static void SetDistanceFromTop(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromTop = value;
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  public static UInt32? GetDistanceFromBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement)
  {
    return openXmlElement?.DistanceFromBottom?.Value;
  }
  
  public static void SetDistanceFromBottom(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromBottom = value;
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public static UInt32? GetDistanceFromLeft(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement)
  {
    return openXmlElement?.DistanceFromLeft?.Value;
  }
  
  public static void SetDistanceFromLeft(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromLeft = value;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public static UInt32? GetDistanceFromRight(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement)
  {
    return openXmlElement?.DistanceFromRight?.Value;
  }
  
  public static void SetDistanceFromRight(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromRight = value;
  }
  
  /// <summary>
  /// Object Extents Including Effects.
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.EffectExtent? GetEffectExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.EffectExtent>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.EffectExtentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectExtent(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement, DocumentModel.Drawings.Wordprocessing.EffectExtent? value)
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
  
  public static DocumentModel.Drawings.Wordprocessing.WrapSquare? CreateModelElement(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.WrapSquare();
      value.WrapText = GetWrapText(openXmlElement);
      value.DistanceFromTop = GetDistanceFromTop(openXmlElement);
      value.DistanceFromBottom = GetDistanceFromBottom(openXmlElement);
      value.DistanceFromLeft = GetDistanceFromLeft(openXmlElement);
      value.DistanceFromRight = GetDistanceFromRight(openXmlElement);
      value.EffectExtent = GetEffectExtent(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.WrapSquare? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapSquare, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
