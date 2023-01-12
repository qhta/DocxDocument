namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Stretch.
/// </summary>
public static class StretchConverter
{
  /// <summary>
  /// Fill Rectangle.
  /// </summary>
  public static DocumentModel.Drawings.RelativeRectangleType? GetFillRectangle(DocumentFormat.OpenXml.Drawing.Stretch? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillRectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RelativeRectangleTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFillRectangle(DocumentFormat.OpenXml.Drawing.Stretch? openXmlElement, DocumentModel.Drawings.RelativeRectangleType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.RelativeRectangleTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FillRectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Stretch? CreateModelElement(DocumentFormat.OpenXml.Drawing.Stretch? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Stretch();
      value.FillRectangle = GetFillRectangle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Stretch? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Stretch, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFillRectangle(openXmlElement, value?.FillRectangle);
      return openXmlElement;
    }
    return default;
  }
}
