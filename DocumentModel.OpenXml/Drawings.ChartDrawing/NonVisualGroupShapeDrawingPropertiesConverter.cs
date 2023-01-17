namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Group Shape Drawing Properties.
/// </summary>
public static class NonVisualGroupShapeDrawingPropertiesConverter
{
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  private static DocumentModel.Drawings.GroupShapeLocks? GetGroupShapeLocks(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GroupShapeLocksConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupShapeLocks(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties openXmlElement, DocumentModel.Drawings.GroupShapeLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.GroupShapeLocksConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList? GetNonVisualGroupDrawingShapePropsExtensionList(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.NonVisualGroupDrawingShapePropsExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualGroupDrawingShapePropsExtensionList(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties openXmlElement, DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.NonVisualGroupDrawingShapePropsExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeDrawingProperties? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeDrawingProperties();
      value.GroupShapeLocks = GetGroupShapeLocks(openXmlElement);
      value.NonVisualGroupDrawingShapePropsExtensionList = GetNonVisualGroupDrawingShapePropsExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeDrawingProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGroupShapeLocks(openXmlElement, value?.GroupShapeLocks);
      SetNonVisualGroupDrawingShapePropsExtensionList(openXmlElement, value?.NonVisualGroupDrawingShapePropsExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
