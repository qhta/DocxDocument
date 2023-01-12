namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public static class GroupShapeNonVisualPropertiesConverter
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public static DocumentModel.Drawings.Office.NonVisualDrawingProperties? GetNonVisualDrawingProperties(DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.NonVisualDrawingPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNonVisualDrawingProperties(DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties? openXmlElement, DocumentModel.Drawings.Office.NonVisualDrawingProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Office.NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Office.NonVisualGroupDrawingShapeProperties? GetNonVisualGroupDrawingShapeProperties(DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.NonVisualGroupDrawingShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNonVisualGroupDrawingShapeProperties(DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties? openXmlElement, DocumentModel.Drawings.Office.NonVisualGroupDrawingShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Office.NonVisualGroupDrawingShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? CreateModelElement(DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.GroupShapeNonVisualProperties();
      value.NonVisualDrawingProperties = GetNonVisualDrawingProperties(openXmlElement);
      value.NonVisualGroupDrawingShapeProperties = GetNonVisualGroupDrawingShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNonVisualDrawingProperties(openXmlElement, value?.NonVisualDrawingProperties);
      SetNonVisualGroupDrawingShapeProperties(openXmlElement, value?.NonVisualGroupDrawingShapeProperties);
      return openXmlElement;
    }
    return default;
  }
}
