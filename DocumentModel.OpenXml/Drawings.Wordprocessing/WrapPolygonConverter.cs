namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Tight Wrapping Extents Polygon.
/// </summary>
public static class WrapPolygonConverter
{
  /// <summary>
  /// Wrapping Points Modified
  /// </summary>
  private static Boolean? GetEdited(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon openXmlElement)
  {
    return openXmlElement?.Edited?.Value;
  }
  
  private static void SetEdited(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Edited = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Edited = null;
  }
  
  /// <summary>
  /// Wrapping Polygon Start.
  /// </summary>
  private static DocumentModel.Drawings.Wordprocessing.Point2DType? GetStartPoint(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.StartPoint>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStartPoint(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon openXmlElement, DocumentModel.Drawings.Wordprocessing.Point2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.StartPoint>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.Point2DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.StartPoint>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Wordprocessing.Point2DType? GetLineTo(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.LineTo>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Wordprocessing.Point2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineTo(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon openXmlElement, DocumentModel.Drawings.Wordprocessing.Point2DType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.LineTo>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Wordprocessing.Point2DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.LineTo>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.WrapPolygon? CreateModelElement(DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.WrapPolygon();
      value.Edited = GetEdited(openXmlElement);
      value.StartPoint = GetStartPoint(openXmlElement);
      value.LineTo = GetLineTo(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.WrapPolygon? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Wordprocessing.WrapPolygon, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEdited(openXmlElement, value?.Edited);
      SetStartPoint(openXmlElement, value?.StartPoint);
      SetLineTo(openXmlElement, value?.LineTo);
      return openXmlElement;
    }
    return default;
  }
}
