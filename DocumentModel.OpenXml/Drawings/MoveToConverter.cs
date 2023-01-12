namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Move Path To.
/// </summary>
public static class MoveToConverter
{
  /// <summary>
  /// Move end point.
  /// </summary>
  public static DocumentModel.Drawings.AdjustPoint2DType? GetPoint(DocumentFormat.OpenXml.Drawing.MoveTo? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Point>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AdjustPoint2DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPoint(DocumentFormat.OpenXml.Drawing.MoveTo? openXmlElement, DocumentModel.Drawings.AdjustPoint2DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Point>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.AdjustPoint2DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Point>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.MoveTo? CreateModelElement(DocumentFormat.OpenXml.Drawing.MoveTo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.MoveTo();
      value.Point = GetPoint(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.MoveTo? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.MoveTo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPoint(openXmlElement, value?.Point);
      return openXmlElement;
    }
    return default;
  }
}
