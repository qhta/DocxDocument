namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Through Wrapping.
/// </summary>
public static class WrapThroughConverter
{
  /// <summary>
  /// Text Wrapping Location
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.WrapTextKind? GetWrapText(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DocumentModel.Drawings.Wordprocessing.WrapTextKind>(openXmlElement?.WrapText?.Value);
  }
  
  public static void SetWrapText(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough? openXmlElement, DocumentModel.Drawings.Wordprocessing.WrapTextKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.WrapText = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapTextValues, DocumentModel.Drawings.Wordprocessing.WrapTextKind>(value);
  }
  
  /// <summary>
  /// Distance From Text on Left Edge
  /// </summary>
  public static UInt32? GetDistanceFromLeft(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough? openXmlElement)
  {
    return openXmlElement?.DistanceFromLeft?.Value;
  }
  
  public static void SetDistanceFromLeft(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromLeft = value;
  }
  
  /// <summary>
  /// Distance From Text on Right Edge
  /// </summary>
  public static UInt32? GetDistanceFromRight(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough? openXmlElement)
  {
    return openXmlElement?.DistanceFromRight?.Value;
  }
  
  public static void SetDistanceFromRight(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DistanceFromRight = value;
  }
  
  /// <summary>
  /// Wrapping Polygon.
  /// </summary>
  public static DocumentModel.Drawings.Wordprocessing.WrapPolygon? GetWrapPolygon(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.WrapPolygonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetWrapPolygon(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough? openXmlElement, DocumentModel.Drawings.Wordprocessing.WrapPolygon? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.WrapPolygonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.WrapThrough? CreateModelElement(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.WrapThrough();
      value.WrapText = GetWrapText(openXmlElement);
      value.DistanceFromLeft = GetDistanceFromLeft(openXmlElement);
      value.DistanceFromRight = GetDistanceFromRight(openXmlElement);
      value.WrapPolygon = GetWrapPolygon(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.WrapThrough? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapThrough, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
