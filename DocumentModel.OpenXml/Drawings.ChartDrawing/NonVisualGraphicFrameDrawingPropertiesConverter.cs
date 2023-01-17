namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Graphic Frame Drawing Properties.
/// </summary>
public static class NonVisualGraphicFrameDrawingPropertiesConverter
{
  /// <summary>
  /// Graphic Frame Locks.
  /// </summary>
  private static DocumentModel.Drawings.GraphicFrameLocks? GetGraphicFrameLocks(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GraphicFrameLocks>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GraphicFrameLocksConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGraphicFrameLocks(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties openXmlElement, DocumentModel.Drawings.GraphicFrameLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GraphicFrameLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.GraphicFrameLocksConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.GraphicFrameLocks>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameDrawingProperties? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameDrawingProperties();
      value.GraphicFrameLocks = GetGraphicFrameLocks(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.NonVisualGraphicFrameDrawingProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGraphicFrameDrawingProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGraphicFrameLocks(openXmlElement, value?.GraphicFrameLocks);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
