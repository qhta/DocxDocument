namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// User Shapes.
/// </summary>
public static class UserShapesConverter
{
  private static DocumentModel.Drawings.ChartDrawing.RelativeAnchorSize? GetRelativeAnchorSize(DocumentFormat.OpenXml.Drawing.Charts.UserShapes openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.RelativeAnchorSizeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRelativeAnchorSize(DocumentFormat.OpenXml.Drawing.Charts.UserShapes openXmlElement, DocumentModel.Drawings.ChartDrawing.RelativeAnchorSize? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.RelativeAnchorSizeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ChartDrawing.AbsoluteAnchorSize? GetAbsoluteAnchorSize(DocumentFormat.OpenXml.Drawing.Charts.UserShapes openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawing.AbsoluteAnchorSizeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAbsoluteAnchorSize(DocumentFormat.OpenXml.Drawing.Charts.UserShapes openXmlElement, DocumentModel.Drawings.ChartDrawing.AbsoluteAnchorSize? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawing.AbsoluteAnchorSizeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.UserShapes? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.UserShapes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.UserShapes();
      value.RelativeAnchorSize = GetRelativeAnchorSize(openXmlElement);
      value.AbsoluteAnchorSize = GetAbsoluteAnchorSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.UserShapes? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.UserShapes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRelativeAnchorSize(openXmlElement, value?.RelativeAnchorSize);
      SetAbsoluteAnchorSize(openXmlElement, value?.AbsoluteAnchorSize);
      return openXmlElement;
    }
    return default;
  }
}
