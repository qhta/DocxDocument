namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
public static class NonVisualGroupDrawingShapePropertiesConverter
{
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  public static DocumentModel.Drawings.GroupShapeLocks? GetGroupShapeLocks(DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GroupShapeLocksConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGroupShapeLocks(DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties? openXmlElement, DocumentModel.Drawings.GroupShapeLocks? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList? GetNonVisualGroupDrawingShapePropsExtensionList(DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.NonVisualGroupDrawingShapePropsExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNonVisualGroupDrawingShapePropsExtensionList(DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties? openXmlElement, DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Office.NonVisualGroupDrawingShapeProperties? CreateModelElement(DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.NonVisualGroupDrawingShapeProperties();
      value.GroupShapeLocks = GetGroupShapeLocks(openXmlElement);
      value.NonVisualGroupDrawingShapePropsExtensionList = GetNonVisualGroupDrawingShapePropsExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.NonVisualGroupDrawingShapeProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties, new()
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
