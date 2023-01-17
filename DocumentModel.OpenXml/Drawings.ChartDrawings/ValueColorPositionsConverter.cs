namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColorPositions Class.
/// </summary>
public static class ValueColorPositionsConverter
{
  /// <summary>
  /// count, this property is only available in Office 2016 and later.
  /// </summary>
  private static Int32? GetCount(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions openXmlElement)
  {
    return openXmlElement.Count?.Value;
  }
  
  private static void SetCount(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions openXmlElement, Int32? value)
  {
    openXmlElement.Count = value;
  }
  
  /// <summary>
  /// MinValueColorEndPosition.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.MinValueColorEndPosition? GetMinValueColorEndPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinValueColorEndPosition>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.MinValueColorEndPositionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMinValueColorEndPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions openXmlElement, DocumentModel.Drawings.ChartDrawings.MinValueColorEndPosition? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinValueColorEndPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.MinValueColorEndPositionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinValueColorEndPosition>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ValueColorMiddlePosition.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition? GetValueColorMiddlePosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ValueColorMiddlePositionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetValueColorMiddlePosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions openXmlElement, DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ValueColorMiddlePositionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// MaxValueColorEndPosition.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.MaxValueColorEndPosition? GetMaxValueColorEndPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.MaxValueColorEndPositionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMaxValueColorEndPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions openXmlElement, DocumentModel.Drawings.ChartDrawings.MaxValueColorEndPosition? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.MaxValueColorEndPositionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ValueColorPositions? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ValueColorPositions();
      value.Count = GetCount(openXmlElement);
      value.MinValueColorEndPosition = GetMinValueColorEndPosition(openXmlElement);
      value.ValueColorMiddlePosition = GetValueColorMiddlePosition(openXmlElement);
      value.MaxValueColorEndPosition = GetMaxValueColorEndPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ValueColorPositions? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCount(openXmlElement, value?.Count);
      SetMinValueColorEndPosition(openXmlElement, value?.MinValueColorEndPosition);
      SetValueColorMiddlePosition(openXmlElement, value?.ValueColorMiddlePosition);
      SetMaxValueColorEndPosition(openXmlElement, value?.MaxValueColorEndPosition);
      return openXmlElement;
    }
    return default;
  }
}
